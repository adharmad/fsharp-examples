#light
// Function composition

open System

let f0 x = x * 2
let f1 x = x + 7

// Compose a function g1(x) = f1(f0(x)) = 2x + 7
let g1 = f0 >> f1

// Compose a function g2(x) = f0(f1(x)) = 2x + 14
let g2 = f0 << f1

let res1 = g1 2
let res2 = g2 2

printfn "g1(2) = %i" res1
printfn "g2(2) = %i" res2
