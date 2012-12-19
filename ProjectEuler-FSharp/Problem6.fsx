let sumofsquare = Seq.sum(seq{ for n in 1..100 do yield n*n })

let sum = Seq.sum([|1..100|])
let squareofsum = sum*sum

printfn "%A" (squareofsum - sumofsquare)
