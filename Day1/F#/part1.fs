(* this is fr my first bout with F#. trying to learn
from scratch to teach myself functional programming. 
i found this has a more intermediary feel than ocaml
so i'll start with that first. also gonna buff out a:

- java solution
- ocaml solution (if i can get fucking opam on my pc)
- rust solution
- C# solution
- i already did a python but i'll get that over too *)

open System.IO

let filepath: string = "../code.txt"
let lines: string seq = File.ReadLines filepath

// print with a newline each line in the program
for line in lines do
    printfn "%s" line