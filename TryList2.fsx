#light
open System

let list0 = [1..10]
let list1 = [1;2;3]

// concatenation of two lists
let list2 = list0 @ list1
printfn "list2 = %A" list2

// concatenation of an element with a list
let list3 = 123::list2
printfn "list3 = %A" list3

for i in [0..list3.Length-1] do
   printfn "list3[%i] = %i" i list3.[i]
