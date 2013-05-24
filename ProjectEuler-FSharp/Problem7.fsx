let isprime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

seq { for n in 1..2000000000 do if isprime n then yield n }
|> Seq.skip 10001
|> Seq.take 1
|> printfn "%A"
