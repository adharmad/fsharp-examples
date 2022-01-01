#light
open System

// Regular enumeration using int
type Card =
   | Jack = 11
   | Queen = 12
   | King = 13
   | Ace = 14

let myCard = Card.King

printfn "myCard = %A" myCard
