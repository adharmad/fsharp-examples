#light
// Recursive records

open System

// Create a Person type and use the Address type that is not defined
type Person =
  { Name: string
    Age: int
    Address: Address }

// Define the Address type which is used in the Person record
and Address =
  { Line1: string
    Line2: string
    PostCode: string
    Occupant: Person }

// Create a Person type and use the Address type that is not defined
let rec person1 =
    {
        Name = "John Doe"
        Age = 100
        Address =
            {
                Line1 = "Address line 1"
                Line2 = "Address line 2"
                PostCode = "94118"
                Occupant = person1
            }
    }


printfn "person1 = %A" person1
