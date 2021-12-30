#light
#time "on"
open System

for num = 1 to 10 do
   match num with
      | 1 -> printfn "We got one"
      | 2 -> printfn "We got two"
      | 3 -> printfn "We got three"
      | _ -> printfn "We got something else"
