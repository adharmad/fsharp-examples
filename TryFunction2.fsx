#light

let halfWay a b =
   let dif = b - a
   let mid = dif / 2
   mid + a

let main() =
   printfn "(halfWay of 5 11) = %i" (halfWay 5 11)
   printfn "(halfWay of 11 99) = %i" (halfWay 11 99)

main()
