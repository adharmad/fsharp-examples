#light
open System

// Sum all the odd numbers
let mutable sum = 0
let mutable i = 100
while i > 0 do
   sum <- sum + i
   i <- i - 1

printfn "Sum of all numbers from 0 to 100 is %i" sum
