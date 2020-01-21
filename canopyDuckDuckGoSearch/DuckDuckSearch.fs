module DuckDuckSearch

open canopy.runner.classic
open canopy.classic
open canopy.reporters
open canopy.configuration
open canopy.types

let allTests () = 

before(fun _ -> 
     chromeDir <- System.AppContext.BaseDirectory
     start chrome
     url "https://duckduckgo.com/"
     ()
)

after(fun _ ->
    //TODO: finish reporting
    let pathToReports = __SOURCE_DIRECTORY__ + @"\canopy\"
    reporter <- new ConsoleReporter() :> IReporter
    //reporter <- new LiveHtmlReporter(chrome, chromeDir) :> IReporter
    //reporter.reportPath <- Some pathToReports
    ()
)

onFail (fun _ -> 
        let pathToScreens = __SOURCE_DIRECTORY__ + @"\canopy\"
        let filename = System.DateTime.Now.ToString("MMM-d_HH-mm-ss-fff")                
        screenshot pathToScreens filename
        |> ignore        
)

"duckduck search " &&& fun _ ->
    let expectedString = "Text"
    DuckSearchPage.searchText expectedString
    DuckResultPage.isFirstElementWithText expectedString
    ()