let rec evenlyDivisibleByAll num div =
    if num % div <> 0 then false
    else if div <= 2 then true
    else evenlyDivisibleByAll num (div-1)

seq { for i in 1..500000000 do yield i }
|> Seq.find(fun i -> evenlyDivisibleByAll i 20)
|> printfn "%A"