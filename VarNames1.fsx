#light
open System

// variable name with space
let ``test variable`` = 100
printfn "``test variable`` = %i" ``test variable``

// using keyword as a variable name
let ``let`` = "my own let"
printfn "``let`` = %s" ``let``

// using apostrophe in variable name
let mySon'sBirthday = "Jan 1, 1984"
printfn "My son's birthday = %s" mySon'sBirthday

// variable ending in apostrophe
let pqr' = 10
printfn "pqr' = %i" pqr'

// include # in variable name
let ``var#`` = "var with #"
printfn "var# = %s" ``var#``
