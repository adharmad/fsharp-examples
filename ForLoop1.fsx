#light
open System

// Sum all the odd numbers
let mutable sum = 0
for i = 0 to 100 do
   if i%2 <> 0 then sum <- sum + i

printfn "Sum of all odd numbers from 0 to 100 is %i" sum

// Up counting
printfn "Up counting"
for i = 0 to 10 do
   printfn "%i" i

// Down counting
printfn "Down counting"
for i = 10 downto 0 do
   printfn "%i" i
