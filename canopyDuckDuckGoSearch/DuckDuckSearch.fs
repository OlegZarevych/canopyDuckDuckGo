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
    waitForElement "#search_form_homepage"
    "#search_form_input_homepage" << "Text"
    ()