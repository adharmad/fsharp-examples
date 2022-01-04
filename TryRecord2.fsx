#light
// Records

open System

type Car = { Make: string; Model: string; mutable mileage: int }
let car1 = {Car.Make="Toyota"; Model="Corolla"; mileage=123456}
printfn "car1 = %A" car1

car1.mileage <- car1.mileage + 198
printfn "car1 = %A" car1
