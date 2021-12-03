namespace Shared

open System

type Todo = { Id: Guid; Description: string; Author: string }

module Todo =
    let isValid (description: string) =
        String.IsNullOrWhiteSpace description |> not

    let create (description: string, author: string) =
        { Id = Guid.NewGuid()
          Description = description
          Author = author }

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName

type ITodosApi =
    { getTodos: unit -> Async<Todo option>
      addTodo: Todo -> Async<Todo> }
