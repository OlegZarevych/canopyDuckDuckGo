module Program =

open canopy.classic
open canopy.runner.classic
open System
open canopy.reporters
open canopy.configuration
open canopy.types

    [<EntryPoint>]
    let main _ = 
    DuckDuckSearch.allTests()
    
    run ()
    quit 

    Console.ReadKey() |> ignore
    0