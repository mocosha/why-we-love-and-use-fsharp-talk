// automatic equality and comparison
type Person = {First:string; Last:string}
let person1 = {First="John"; Last="Doe"}
let person2 = {First="Joe"; Last="Taxi"}
printfn "Equal? %A"  (person1 = person2)

// easy IDisposable logic with "use" keyword
use reader = new StreamReader(..)

// easy composition of functions
//let add2times3 = (+) 2 >> (*) 3
//let result = add2times3 5

let add2 x = x + 2
let mul3 x = x * 3
let add2times3 = add2 >> mul3

add2times3 5
