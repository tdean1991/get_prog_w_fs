module Car

open System

//TODO: Create helper functions to provide the building blocks to implement driveTo.

/// Drives to a given destination given a starting amount of petrol
let getPetrol dest = 
   if dest = "Home" then 25
   elif dest = "Office" then 50
   elif dest = "Stadium" then 25
   elif dest = "Gas" then 10
   else failwith "Invalid destination"
    
let calcRemainingPetrol currentPetrol usedPetrol =
    let remainingPetrol = currentPetrol - usedPetrol
    if remainingPetrol >= 0 then remainingPetrol
    else failwith "Oops you ran out of petrol"


let driveTo currentPetrol destination = 
    let petrolNeeded = getPetrol destination
    let remainingPetrol = calcRemainingPetrol currentPetrol petrolNeeded
    if destination = "Gas" then remainingPetrol + 50
    else remainingPetrol


