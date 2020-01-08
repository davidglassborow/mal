﻿[<EntryPoint>]
let main argv =
    let redirected = argv |> Array.exists ((=) "--raw")
    Lisp.Repl.run (not redirected) id id
    0 // return an integer exit code
