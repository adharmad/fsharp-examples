// Try various identifiers
open System

let x = 10
let y = 20
let z = 3.14159

let raiseTo2 x = x ** 2.0

printfn "x = %d"  x
printfn "y = %d"  y
printfn "z = %f"  z
printfn "%f raised to 2 = %f"  z  (raiseTo2 z)
