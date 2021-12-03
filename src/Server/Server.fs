module Server

open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open FSharp.Data
open Saturn
open Shared
open System.IO

type Storage() =
    let encouragements = ResizeArray<_>()

    let getrandomitem (list:Encouragement List) =  
        let rand = new System.Random()
        let result = list.[rand.Next(list.Length)]
        Some result

    member __.GetEncouragement() = List.ofSeq encouragements |> getrandomitem

    member __.AddEncouragement(encouragement: Encouragement) =
        if Encouragement.isValid encouragement.Description then
            encouragements.Add encouragement
            Ok()
        else
            Error "Invalid encouragement"

let storage = Storage()

type Quotes = JsonProvider<"quotes.json">
let quotes = Quotes.Parse(File.ReadAllText("quotes.json"))

for quote in quotes do    
    storage.AddEncouragement(Encouragement.create (quote.Description, quote.Author))
    |> ignore

let encouragementsApi =
    { getEncouragement = fun () -> async { return storage.GetEncouragement() }
    }

let webApp =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.fromValue encouragementsApi
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
