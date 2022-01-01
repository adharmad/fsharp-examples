#light
open System

let tup1 = ("one", "two")
printfn "tup1 = %A" tup1

let elem1 = fst tup1
let elem2 = snd tup1

printfn "first element of tuple = %s" elem1
printfn "second element of tuple = %s" elem2

let tup2 = ("hello", "world", "mike", "testing")
printfn "tup2 = %A" tup2

let third (_, _, c, _) = c
let fourth (_, _, _, c) = c

let elem3 = third tup2
let elem4 = fourth tup2

printfn "third element of tuple = %s" elem3
printfn "fourth element of tuple = %s" elem4
