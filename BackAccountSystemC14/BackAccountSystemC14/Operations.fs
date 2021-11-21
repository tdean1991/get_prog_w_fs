module Operations
open Domain
open Auditing


let deposit amt acct = 
    { acct with balance = acct.balance + amt}  

let withdrawal amt acct =
    let newBal = acct.balance - amt
    if newBal >= 0M then { acct with balance = newBal }
    else acct

let withdrawalWithConsoleAudit = auditAs "withdrawal" console withdrawal
let depositWithConsoleAudit = auditAs "deposit" console deposit

let withdrawalWithFileAudit = auditAs "withdrawal" fileSystemAudit withdrawal
let depositWithFileAudit = auditAs "deposit" fileSystemAudit deposit



