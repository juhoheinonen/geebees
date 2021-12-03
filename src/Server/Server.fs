module Server

open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open FSharp.Data
open Saturn
open Shared
open System.IO

type Storage() =
    let todos = ResizeArray<_>()

    let getrandomitem (list:Todo List) =  
        let rand = new System.Random()
        let result = list.[rand.Next(list.Length)]
        Some result

    member __.GetTodos() = List.ofSeq todos |> getrandomitem

    member __.AddTodo(todo: Todo) =
        if Todo.isValid todo.Description then
            todos.Add todo
            Ok()
        else
            Error "Invalid todo"

let storage = Storage()

type Quotes = JsonProvider<"quotes.json">
let quotes = Quotes.Parse(File.ReadAllText("quotes.json"))

for quote in quotes do    
    storage.AddTodo(Todo.create (quote.Description, quote.Author))
    |> ignore

let todosApi =
    { getTodos = fun () -> async { return storage.GetTodos() }
      addTodo =
          fun todo ->
              async {
                  match storage.AddTodo todo with
                  | Ok () -> return todo
                  | Error e -> return failwith e
              } }

let webApp =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.fromValue todosApi
    |> Remoting.buildHttpHandler

let app =
    application {
        url "http://0.0.0.0:8085"
        use_router webApp
        memory_cache
        use_static "public"
        use_gzip
    }

run app
