// BasicFunction1.fsx
open System

let sign num =
   if num > 0 then "positive"
   elif num < 0 then "negative"
   else "zero"

let main() =
   printfn "Sign of 5: {0}", (sign 5)
   printfn "Sign of -15: {0}", (sign -15)
   printfn "Sign of 0: {0}", (sign 0)

main()
