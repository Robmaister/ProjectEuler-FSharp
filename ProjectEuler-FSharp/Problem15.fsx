let factorial (n: bigint) =
    let rec loop (i: bigint) (acc: bigint) =
        match i with
        | _ when i = 0I -> acc
        | _ when i = 1I -> acc
        | _ -> loop (i-1I) (acc * i)
    loop n 1I

let numPaths (n: bigint) =
    factorial (2I*n) / (factorial n * factorial n)

printfn "%A" (numPaths 20I)