#light
open System

// zip function
let list0 = [ 1; 2; 3 ]
let list1 = [ "a"; "b"; "c" ]
let list2 = [ 1.1; 2.2; 3.3 ]
let zipLst1 = List.zip list0 list1
printfn "zipLst1 = %A" zipLst1
let zipLst2 = List.zip3 list0 list1 list2
printfn "zipLst2 = %A" zipLst2

// reverse function
let list3 = [ 1..10 ]
let revLst = List.rev list3
printfn "revLst = %A" revLst

// sort function
let list4 = [ 10; 9; 8; 7; 6; 5; 4; 3; 2; 1 ]
let sortedList = List.sort list4
printfn "sortedList = %A" sortedList
