let factorial (n: bigint) =
    let rec loop (i: bigint) (acc: bigint) =
        match i with
        | _ when i = 0I -> acc
        | _ when i = 1I -> acc
        | _ -> loop (i-1I) (acc * i)
    loop n 1I

(factorial 100I).ToString()
|> Seq.sumBy (fun d -> int (string d))
|> printfn "%A"

