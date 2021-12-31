#light
open System

// define a divisibility function
let isDivisibleBy number elem = elem % number = 0

// Find function
let result = Seq.find (fun n -> isDivisibleBy 5 n) [ 1 .. 100 ]
printfn "result = %d" result

// map function
let mySeq = seq { 1..10 }
let result1 = mySeq
               |> Seq.map (fun n -> n*2)

printfn "result1 = %A " result1

// filter function
let result2 = mySeq
               |> Seq.filter(fun n -> n%3=0)

printfn "result2 = %A " result2

// fold function
// Calculate the sum of n numbers using fold function
let result3 = Seq.fold (fun acc n -> acc+n) 0 mySeq
printfn "result3 = %d " result3

// Calculate the factorial using fold function
let result4 = Seq.fold (fun acc n -> acc*n) 1 mySeq
printfn "result4 = %d " result4
