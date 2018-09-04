// strict type checking
printfn "print string %s" 123 //compile error

// all values immutable by default
person1.First <- "new name"  //assignment error

// never have to check for nulls
let personFullName person =
   //person properties can be used safely
   person.First + " " + person.Last

// units of measure
[<Measure>] type m
[<Measure>] type ft

5<m> + 2<m>
let distance = 10<m> + 10<ft> // error!