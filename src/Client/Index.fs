module Index

open Elmish
open Fable.Remoting.Client
open Shared
open System

type Model = { Encouragement: Encouragement option }

type Msg =
    | GotEncouragement of Encouragement option

let encouragementsApi =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.buildProxy<IEncouragementsApi>

let init () : Model * Cmd<Msg> =
    let model = { Encouragement = Some {Description = ""; Id = Guid.NewGuid(); Author = "" } }

    let cmd =
        Cmd.OfAsync.perform encouragementsApi.getEncouragement () GotEncouragement

    model, cmd

let update (msg: Msg) (model: Model) : Model * Cmd<Msg> =
    match msg with
    | GotEncouragement encouragement -> { model with Encouragement = encouragement }, Cmd.none

open Feliz
open Feliz.Bulma

let containerBox (model: Model) (dispatch: Msg -> unit) =
    Bulma.box [
        Bulma.content [
            Html.strong [prop.text model.Encouragement.Value.Description]
            Html.p [prop.text model.Encouragement.Value.Author]
        ]
    ]

let view (model: Model) (dispatch: Msg -> unit) =
    Bulma.hero [
        hero.isFullHeight
        color.isPrimary
        prop.style [
            style.backgroundSize "cover"
            style.backgroundImageUrl "https://unsplash.it/1200/900?random"
            style.backgroundPosition "no-repeat center center fixed"
        ]
        prop.children [
            Bulma.heroHead [
                Bulma.navbar [
                    
                ]
            ]
            Bulma.heroBody [
                Bulma.container [
                    Bulma.column [
                        column.is6
                        column.isOffset3
                        prop.children [
                            Bulma.title [
                                text.hasTextCentered
                                prop.text "Uplifty"
                            ]
                            containerBox model dispatch
                        ]
                    ]
                ]
            ]
        ]
    ]
