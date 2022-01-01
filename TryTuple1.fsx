#light
open System

// Tuples are groupings of unnamed but ordered items
// Items in tuples can be of any types

let tup1 = (1, 10)
printfn "tup1 = %A" tup1

let tup2 = ("one", "two", "three")
printfn "tup2 = %A" tup2

let tup3 = ("one", 1, 3.14)
printfn "tup3 = %A" tup3

let tup4 = (("one", 1), "hello", 4.5)
printfn "tup4 = %A" tup4

// tuple without brackets
let tup5 = 6.7, 9.8
printfn "tup5 = %A" tup5
