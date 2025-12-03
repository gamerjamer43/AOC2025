(* this is fr my first bout with F#. trying to learn
from scratch to teach myself functional programming. 
i found this has a more intermediary feel than ocaml
so i'll start with that first. also gonna buff out a:

- java solution
- rust solution
- C++ solution
- ocaml solution (if i can get fucking opam on my pc)
- i also already did a python but i'll get that over too *)

open System.IO

// start dial at 50, no 0 stops yet
let mutable dial: int = 50
let mutable stopsAtZero: int = 0

let rotate (value: string) =
    // everything after the first char is a digit val
    let degrees: int = 
        match value[0] with
        | 'L' -> -1 * int value.[1..]
        | 'R' -> int value.[1..]
//      |
        | _ -> 0  // if somehow not L or R fuck that

    // returns unit (void)
    dial <- dial + degrees
    dial <- dial % 100

    if dial = 0 then stopsAtZero <- stopsAtZero + 1
        
// go thru each line and rotate
for line: string in File.ReadLines "../code.txt" do
    rotate line
    printfn "%s: %d" line dial

// print how many stops
printfn "Stops at zero: %d" stopsAtZero