#light
// Pipe composition

open System

let seq0 = seq { 0..100 }

// both seqLen1 and seqLen2 are the same
let seqLen0 = seq0 |> Seq.length
let seqLen1 = Seq.length seq0

printfn "seqLen0 = %i" seqLen0
printfn "seqLen1 = %i" seqLen1

let arr0 = [| for i=0 to 10 do yield i*i |]
let arrLen0 = arr0 |> Array.length
printfn "arrLen0 = %i" arrLen0
