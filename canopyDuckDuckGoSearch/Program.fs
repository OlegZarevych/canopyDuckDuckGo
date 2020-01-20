module Program =

open canopy.runner.classic
open System

    [<EntryPoint>]
    let main _ = 
    DuckDuckSearch.allTests()
    
    run ()

    Console.ReadKey() |> ignore
    0