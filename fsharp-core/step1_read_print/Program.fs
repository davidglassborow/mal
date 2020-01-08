[<EntryPoint>]
let main argv =
    let redirected = argv |> Array.exists ((=) "--raw")
    Lisp.Repl.run (not redirected) Parse.strToAst Parse.astToStr
    0 // return an integer exit code
