#light
// Using Pipe

open System

seq { 0..100 }
   |> Seq.filter (fun n -> n%2 <> 0)
   |> Seq.sum
   |> printfn "The sum of odd numbers from 0 to 100 is %A"
