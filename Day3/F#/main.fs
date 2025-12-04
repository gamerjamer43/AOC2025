open System.IO

let bestTwo (line: char seq) =
    let digits: int32 array = 
        line 
        |> Seq.map (fun c -> int c - int '0') 
        |> Seq.toArray

    // best has to always be beat (even tho no zeros)
    let mutable best = -1

    // first tens digit
    for i = 0 to digits.Length - 2 do
        let tens: int32 = digits[i]

        // then ones digit (first digit never it)
        let mutable ones = -1
        for j = i + 1 to digits.Length - 1 do
            if digits[j] > ones then ones <- digits[j]

        // check if the possible new best is greater, if so replace it
        let possiblility: int32 = tens * 10 + ones
        if possiblility > best then best <- possiblility

    // return best found
    best

let run () =
    // run thru best two and sum them all
    let sum: int32 =
        File.ReadLines "../input.txt"
        |> Seq.map bestTwo
        |> Seq.sum

    // yipe
    printfn "Total voltage = %d" sum

run()