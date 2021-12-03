namespace Shared

open System

type Encouragement = { Id: Guid; Description: string; Author: string }

module Encouragement =
    let isValid (description: string) =
        String.IsNullOrWhiteSpace description |> not

    let create (description: string, author: string) =
        { Id = Guid.NewGuid()
          Description = description
          Author = author }

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

type IEncouragementsApi =
    { getEncouragement: unit -> Async<Encouragement option>
    }
