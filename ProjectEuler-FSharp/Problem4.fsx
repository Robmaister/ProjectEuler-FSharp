let isPalindrome (i: int) =
    let arr = i.ToString().ToCharArray()
    arr = Array.rev arr

seq { for n in 999..-1..100 do for n2 in 999..-1..100 do if isPalindrome (n * n2) then yield (n * n2) }
|> Seq.sort
|> Seq.last
|> printfn "%A"