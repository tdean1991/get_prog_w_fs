open Domain
open Operations
open System
open System.IO

[<EntryPoint>]
let main argv = 
    let tony = { FirstName = "Tony"; LastName = "Dean"; Age = 47}

    let n2 = {FirstName = "Charlie"; LastName = "Brown"; Age = 7}
    let n3 = {FirstName = "Homer"; LastName = "Simpson"; Age = 35}

    let customers = [|tony; n2; n3|]
    //if tony |> isOlderThan 18 then printfn "%s is an adult!" tony.FirstName
    //else printfn "%s is a child" tony.FirstName
    let isOver35 = isOlderThan 35
    let fCustomers = customers |> where isOver35

    let printAgeToConsole = printCustomerAge Console.WriteLine

    let writeToFile text = File.WriteAllText(@"C:\temp\output.txt", text)
    for c in customers do
        printfn "%s %s" c.FirstName c.LastName
        c |> printCustomerAge Console.WriteLine
        c |> printCustomerAge writeToFile

    for c in fCustomers do
        printfn "%s %s" c.FirstName c.LastName
    0