let triangles = Seq.initInfinite (fun index -> seq { 0..index } |> Seq.sum) |> Seq.skip 1

let numFactors n =
    let factors n = seq {
        for d in 1..int(sqrt(float n)) do
        if n % d = 0 then
            yield d
            yield n / d
    }

    factors n |> Seq.length

triangles
|> Seq.find (fun n -> numFactors n >= 500)
|> printfn "%A"