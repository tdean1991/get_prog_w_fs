open Domain
open Operations
open System

// For more formation see https://aka.ms/fsharp-console-apps

let getCustomer() =
    Console.WriteLine("Enter your First Name: ")
    let first = Console.ReadLine()
    Console.WriteLine("Enter your Last Name: ")
    let last = Console.ReadLine()
    {firstName = first; lastName = last}    

let getBalance() = 
    Console.WriteLine("Enter your opening balance: ")
    Decimal.Parse(Console.ReadLine())

let getAccount() = 
    let customer = getCustomer()
    let bal = getBalance()
    {id = Guid.NewGuid(); holder = customer; balance = bal }

let getOp() = 
    Console.WriteLine("Would you like to deposit(d), withdraw(w) or exit(e)")
    let cmd = Console.ReadLine()
    if cmd = "d" then
        Console.WriteLine("How much would you like to deposit: ")
        let amt = Decimal.Parse(Console.ReadLine())
        "deposit", amt
    elif cmd = "w" then
        Console.WriteLine("How much would you like to withdraw")
        let amt = Decimal.Parse(Console.ReadLine())
        "withdraw", amt
    elif cmd = "e" then
        "exit", -1M
    else
        "error", -1M

        
[<EntryPoint>]
let main argv =
    let mutable acct = getAccount()
    let mutable exit = false
    while not exit do 
        let cmd, amt = getOp()
        if cmd = "exit" then 
            exit <- true
        elif cmd = "deposit" then
            acct <- acct |> depositWithConsoleAudit amt
        elif cmd = "withdraw" then
            acct <- acct |> withdrawalWithConsoleAudit amt
        else 
            Console.WriteLine("Invalid operation entered")
    0
