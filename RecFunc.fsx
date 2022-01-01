#light
open System

// Recursive functions
// No memoization

// Fibonnaci function
let rec fib n =
   if n <= 2 then 1
   else fib (n-1) + fib (n-2)

for i = 1 to 10 do
   let x = fib i
   printfn "%dth fib num = %d" i x

// Factorial function
let rec fact n =
   if n = 0 then 1
   else n * fact (n-1)

for i = 1 to 10 do
   let x = fact i
   printfn "%d! = %d" i x
