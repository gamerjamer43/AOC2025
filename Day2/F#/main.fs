open System.IO
open System.Text.RegularExpressions

// start with empty set (MAKE SURE TO USE 64 BIT INTS! SOME ARE TOO LARGE)
let mutable invalid: Set<int64> = Set.empty

// this pattern matches any instance of a one or more character string followed by another instance of itself 99 satisfies for example but not 333
let patternPt1: string = @"^(\d+)\1$"

// legit just matching the + matches ANY count. now 111 for example satisfies.
let patternPt2: string = @"^(\d+)\1+$"

// switches between part 1 and 2 
let part1: bool = true
let pattern: string = if part1 then patternPt1 else patternPt2

for line: string in File.ReadLines "../input.txt" do
    printfn "%s" line

    // split each line into an array of int64s (READ ABOVE)
    let split: int64 array = 
        line.Split("-")
        |> Array.map int64

    // parse start and stop, check using that matcher
    let start: int64 = int64 split[0]
    let stop: int64 = int64 split[1]
    for i: int64 in start .. stop do
        if Regex.IsMatch(string i, pattern) then invalid <- invalid.Add i

// then we have to sum each one (READ ABOVE)
let mutable sum: int64 = 0
for value: int64 in invalid do
    sum <- sum + value

printfn "Sum was %d" sum