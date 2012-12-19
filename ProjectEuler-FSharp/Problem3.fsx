let isprime n =
    let rec check i =
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

let factors x = seq { for n in 1L..int64(sqrt(double(x))) do if x % n = 0L && isprime (int n) then yield n }
printfn "%A" (Seq.max (factors 600851475143L))
