let mutable x = 10
let mutable y = 20

let add x y = x + y

let mutable z = add x y // Make z mutable

printfn "%d" z

x <- 100
y <- 200

z <- add x y // Update z

printfn "%d" z