module AcctFunctions
open System.IO
open AccountDto


let deposit amt acct = 
    { acct with balance = acct.balance + amt}  

let withdrawal amt acct =
    let newBal = acct.balance - amt
    if newBal >= 0M then { acct with balance = newBal }
    else acct

let fileSystemAudit acct message = 
    let fileName = sprintf "C:\temp\accounts\{%s}-{%s}\{%s}.txt" acct.holder.lastName acct.holder.firstName (acct.id.ToString())
    //let out = File.AppendText fileName
    //out.W
    0