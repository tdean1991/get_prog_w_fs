module Operations
open Domain
open System

let getInitials customer = 
    customer.FirstName.[0], customer.LastName.[0]

let isOlderThan age customer = 
    customer.Age > age

let where filter customers = seq {
    for customer in customers do    
        if filter customer then
            yield customer
}

let printCustomerAge writer customer =     
    if customer |> isOlderThan 17 then writer "Adult"
    elif customer |> isOlderThan 12 then writer "Teen"
    else writer "Child"



