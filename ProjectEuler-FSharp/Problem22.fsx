let charVal (c: char) =
    (int c) - (int 'A') + 1

let score str i =
    let sum =
        str.ToString().ToCharArray()
        |> Seq.map (fun c -> charVal c)
        |> Seq.sum
    sum * i

let names = 
    System.IO.File.ReadLines (__SOURCE_DIRECTORY__ + "/22/names.txt")
    |> Seq.map (fun l -> l.Split ',')
    |> Seq.concat
    |> Seq.map (fun n -> n.Substring(1, n.Length - 2))
    |> Seq.sort
    |> Seq.mapi(fun i n -> score n (i+1))
    |> Seq.sum
    |> printfn "%A"