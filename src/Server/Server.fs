module Server

open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open Saturn

open Shared

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

storage.AddTodo(Todo.create "Tough times never last, but tough people do.")
|> ignore

storage.AddTodo(Todo.create "In the depth of winter, I finally learned that within me there lay an invincible summer.")
|> ignore

storage.AddTodo(Todo.create "Although no one can go back and make a brand new start, anyone can start from now and make a brand new ending.")
|> ignore

storage.AddTodo(Todo.create "Anyone can hide. Facing up to things, working through them, that’s what makes you strong.")
|> ignore

storage.AddTodo(Todo.create "If one dream should fall and break into a thousand pieces, never be afraid to pick one of those pieces up and begin again.")
|> ignore

storage.AddTodo(Todo.create "When you’re feeling your worst, that’s when you get to know yourself the best.")
|> ignore

storage.AddTodo(Todo.create "In the middle of every difficulty lies opportunity.")
|> ignore

storage.AddTodo(Todo.create "Fall seven times, stand up eight.")
|> ignore

storage.AddTodo(Todo.create "Success is not final, failure is not fatal: it is the courage to continue that counts.")
|> ignore

storage.AddTodo(Todo.create "Failure is simply the opportunity to begin again, this time more intelligently.")
|> ignore

storage.AddTodo(Todo.create "Ever tried. Ever failed. No matter. Try Again. Fail again. Fail better.")
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
