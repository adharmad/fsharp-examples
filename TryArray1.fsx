#light
open System

let array0 = [| 1..10 |]
let array1 = [| 100; 101; 102 |]

printfn "array0 = %A" array0
printfn "array1 = %A" array1

let array2 = [| for i=0 to 10 do yield i*3 + 1 |]
printfn "array2 = %A" array2

// empty array
let emptyArr = Array.empty
printfn "emptyArr = %A" emptyArr

for i in [0..array2.Length-1] do
   printfn "array2[%i] = %i" i array2.[i]

// array slicing
let array3 = array2.[4..7]
printfn "array3 = %A" array3
