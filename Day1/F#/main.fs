module main

[<EntryPoint>]
let main argv =
    match argv with
    | [| "1" |] ->
        part1.run()
    | [| "2" |] ->
        part2.run()

    | _ ->
        printfn "Usage: dotnet run 1   (part 1)"
        printfn "       dotnet run 2   (part 2)"
    
    0