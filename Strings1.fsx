#light
open System

// ascii string
let abc = "asciistring"B

printfn "abc = %A" abc

let s1 = "string ending in tab\t"
let s2 = @"string ending in tab\t"

printfn "s1 = %s:" s1
printfn "s2 = %s:" s2

let tripleQs = """Hello world! My name is "Hulk"."""
printfn "tripleQs = %s:" tripleQs
