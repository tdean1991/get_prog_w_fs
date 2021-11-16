module AccountDto
open System

type Customer = {
    firstName : string
    lastName : string
}

type Account = {
    holder : Customer
    balance : decimal
    id : Guid
}

let cust = {firstName = "Tony"; lastName = "Dean"}
let acct = { holder = cust; id = Guid.NewGuid(); balance = decimal 700M}
