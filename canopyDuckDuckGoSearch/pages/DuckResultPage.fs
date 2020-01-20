module DuckResultPage

open canopy.classic

let _resultHeader = ".result__a"

let isFirstElementWithText text = 
    waitForElement _resultHeader
    let result = elements _resultHeader
    contains text (read result.Head)
