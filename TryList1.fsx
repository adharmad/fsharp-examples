#light
open System

let list0 = [1..10]
let list1 = [1;2;3]

printfn "list0 = %A" list0
printfn "list1 = %A" list1

let list2 = [for i =1 to 10 do yield i*i]
printfn "list2 = %A" list2

let emptyLst = List.empty
printfn "emptyLst = %A" emptyLst
