#light
open System

let seq0 = seq { 1.. 10 }
let seq1 = seq { 10..-1..1}

printfn "seq0 = %A" seq0
printfn "seq1 = %A" seq1

// check if mySeq contains 3, which will make "fun n -> n = 3" return TRUE
if seq0 |> Seq.exists (fun n -> n = 3) then
   printfn "mySeq contains 3"

// more concise version to check if it contains number 3
if seq0 |> Seq.exists ((=) 3) then
   printfn "mySeq contains 3"

// check if two sequences contain the same element at the same location
if Seq.exists2 (fun n1 n2 -> n1 = n2) seq0 seq1 then
   printfn "two sequences contain same element"
