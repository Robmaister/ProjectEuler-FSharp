let fib = Seq.unfold(fun (a, b) -> Some(a, (b, a + b)))(1, 1)
let sum =
    fib
    |> Seq.takeWhile(fun n -> n < 4000000)
    |> Seq.sumBy(fun n -> if n % 2 = 0 then n else 0)
printfn "%A" sum
