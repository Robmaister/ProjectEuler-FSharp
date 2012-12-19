//Way too slow, need to implement Sieve of Eratosthenes

let isprime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

seq { for i in 1..1999999 do if isprime i then yield bigint i }
|> Seq.sum
|> printfn "%A"
