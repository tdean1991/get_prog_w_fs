// Learn more about F# at http://fsharp.org

open System
open System.IO
let writeToFile (date:DateTime) fileName text =
    let path = "%s-%s.txt" (date.ToString "yyMMdd") fileName
    File.WriteAllText path text

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
    
