// -----------------------------------------------------------
// In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
// 
// Example
// filter_list([1,2,'a','b']) == [1,2]
// filter_list([1,'a','b',0,15]) == [1,0,15]
// filter_list([1,2,'aasf','1','123',123]) == [1,2,123]
// -----------------------------------------------------------

open System

let isInteger i = box i :? int

let GetIntegersFromList (listOfItems: Object list) =
    listOfItems 
    |> List.filter isInteger
    |> List.map (fun i -> i :?> int);;

// or

open System

let GetIntegersFromList (listOfItems: Object list) =
    [for i in listOfItems do if i :? int then yield i :?> int];;