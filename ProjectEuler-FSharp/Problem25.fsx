let fib = Seq.unfold(fun (a, b) -> Some(a, (b, a + b)))(1I, 1I)
let inline add a b = a + b

fib
|> Seq.findIndex (fun i -> (string i).Length >= 1000)
|> add 1 //converts index to term #
|> printfn "%A"