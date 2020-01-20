module XunitDuckDuck

open System
open Xunit
open canopy.runner.classic
open canopy.configuration
open canopy.classic


[<Fact>]
let ``My test`` () =
    canopy.configuration.chromeDir <- System.AppContext.BaseDirectory
    start chrome
    url "https://duckduckgo.com/"
    waitForElement "#search_form_homepage"
    "#search_form_input_homepage" << "Text"
    Assert.True(true)