//Way too slow, need to implement Sieve of Eratosthenes

let isprime (n: bigint) =
    let rec check i =
        i > n/2I || (n % i <> 0I && check (i + 1I))
    check 2I

seq { for i in 1I..1999999I do if isprime i then yield i }
|> Seq.sum
|> printfn "%A"
