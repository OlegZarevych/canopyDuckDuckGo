module DuckSearchPage

open canopy.classic

//locators
let _searchInput = "#search_form_input_homepage"
let _searchButton = "#search_button_homepage"

let searchText text = 
    waitForElement _searchInput
    _searchInput << text
    click _searchButton
