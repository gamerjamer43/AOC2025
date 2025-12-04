// the same as my part1 w a couple changes

module part2
open System.IO

let run () =     // start dial at 50, no passes yet
    let mutable dial: int = 50
    let mutable passesOfZero: int = 0

    let rotate (value: string) =
        // everything after the first char is a digit val
        let mult: int = 
            match value[0] with
            | 'L' -> -1
            | 'R' -> 1
    //      |
            | _ -> 0  // if somehow not L or R fuck that

        // dont mod till AFTER the check
        let degrees = int value.[1..]
        
        // simulate every click... subotimal as fuck but whatever
        for _ in 1 .. degrees do
            dial <- (dial + mult + 100) % 100
            if dial = 0 then passesOfZero <- passesOfZero + 1
            
    // go thru each line and rotate
    for line: string in File.ReadLines "../code.txt" do
        rotate line
        printfn "%s: %d" line dial

    // print how many stops
    printfn "Stops at zero: %d" passesOfZero