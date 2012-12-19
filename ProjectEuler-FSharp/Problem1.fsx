let multiples = seq { for n in 1..999 do if n % 3 = 0 || n % 5 = 0 then yield n }
printfn "%A" (Seq.sum multiples)
