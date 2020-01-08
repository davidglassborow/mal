open System

open Mono.Terminal


[<EntryPoint>]
let main argv =

    let le = LineEditor("mal", HeuristicsMode = "lisp")

    let mutable complete = false
    while not complete do
        let line = le.Edit("user> ", "")
        if isNull line then complete <- true
        else
            printfn "%s" line

    printfn "-Done-"
    0 // return an integer exit code
