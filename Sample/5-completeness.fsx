// impure code when needed
let mutable counter = 0

// create C# compatible classes and interfaces
type IEnumerator<'a> = 
    abstract member Current : 'a
    abstract MoveNext : unit -> bool 

// extension methods
type System.Int32 with
    member this.IsEven = this % 2 = 0

let i=20
if i.IsEven then printfn "'%i' is even" i
	
// UI code
open System.Windows.Forms 
let form = new Form(Width= 400, Height = 300,
   Visible = true, Text = "Hello World")
form.TopMost <- true
form.Click.Add (fun args-> printfn "clicked!")
form.Show()