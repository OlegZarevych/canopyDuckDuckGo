module DuckDuckSearch

open canopy.runner.classic
open canopy.classic

let allTests () = 

before(fun _ -> 
     canopy.configuration.chromeDir <- System.AppContext.BaseDirectory
     start chrome
     url "https://duckduckgo.com/"
     ()
)

after(fun _ ->
    quit chrome
    ()
)

"duckduck search " &&& fun _ ->
    let expectedString = "Text"
    DuckSearchPage.searchText expectedString
    DuckResultPage.isFirstElementWithText expectedString
    ()