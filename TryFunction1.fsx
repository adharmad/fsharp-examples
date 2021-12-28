#light

let n = 10

// Function as value
let add a b = a + b

// Lazy application
let addFour = add 4

let result = addFour n

printfn "result = %i" result
