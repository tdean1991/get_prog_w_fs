module Auditing
open Domain
open System.IO

let fileSystemAudit acct message = 
    let fileName = sprintf "C:\temp\accounts\{%s}-{%s}\{%s}.txt" acct.holder.lastName acct.holder.firstName (acct.id.ToString())
    File.AppendAllText(fileName,message + "\n")
    

let console acct message = 
    printf "Account %s: %s\n" (acct.id.ToString()) message

let auditAs operationName audit operation amount account = 
    let newAcct = account |> operation amount
    let message = if account = newAcct then "Transation rejected" else sprintf "%s %M" operationName amount
    audit newAcct message
    let balMsg = sprintf "Balance: %M" newAcct.balance
    audit newAcct balMsg
    newAcct
