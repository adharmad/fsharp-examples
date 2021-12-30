#light
open System

let seq0 = seq { 1.. 10 }
let seq1 = seq { for i=1 to 10 do yield i*i*i }

printfn "seq0 = %A" seq0
printfn "seq1 = %A" seq1

// empty sequence
let emptySeq = Seq.empty
printfn "emptySeq = %A" emptySeq
