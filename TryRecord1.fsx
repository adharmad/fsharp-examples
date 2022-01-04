#light
// Records

open System

// Labels are separated by semicolons when defined on the same line.
type Point = { X: float; Y: float; Z: float; }
let p1 = { Point.X = 1.1; Y=2.2; Z=3.3 }
printfn "p1 = %A" p1

// You can define labels on their own line with or without a semicolon.
type Customer =
    { First: string
      Last: string;
      SSN: int;
      AccountNumber: int; }
let cust1 = { Customer.First="John"; Last="Doe"; SSN=1234567890; AccountNumber=100 }
printfn "cust1 = %A" cust1

// A struct record.
[<Struct>]
type StructPoint =
    { XX: float
      YY: float
      ZZ: float }
let sp1 = { StructPoint.XX = 1.1; YY=2.2; ZZ=3.3 }
printfn "sp1 = %A" sp1
