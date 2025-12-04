module main

[<EntryPoint>]
let main (argv: string array) =
    match argv with
    | [| "1" |] ->
        part1.run()
    | [| "2" |] ->
        part2.run()

    | _ ->
        printfn "Usage: dotnet run 1   (part 1)"
        printfn "       dotnet run 2   (part 2)"
    
    0 // explicitly return 0