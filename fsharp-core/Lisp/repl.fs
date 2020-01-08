namespace Lisp

open Mono.Terminal

module Repl =


    let private runInteractive eval astToString =
        let le = LineEditor("mal", HeuristicsMode = "lisp")

        let read () = le.Edit("user> ", "")
        let print s = printfn "%s" s 

        let mutable complete = false
        while not complete do
            let input = read()
            if isNull input then complete <- true
            else
                input |> eval |> astToString |> print
        ()

    let private runBatch eval astToString =

        let read () = 
            System.Console.Write("user> ");
            System.Console.ReadLine()
        let print s = printfn "%s" s 

        let mutable complete = false
        while not complete do
            let input = read()
            if isNull input then complete <- true
            else
                input |> eval |> astToString |> print
        ()

    let run interactive eval astToString =
        if interactive then runInteractive eval astToString else runBatch eval astToString
