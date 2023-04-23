// -----------------------------------------------------------
// Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.
// 
// Note: input will never be an empty string
// -----------------------------------------------------------

let fakeBin x =
    String.map(fun binstr ->
        match binstr with
        |'0'|'1'|'2'|'3'|'4' -> '0'
        | _ -> '1') x;;

// or

let fakeBin x =
    String.map (fun binstr -> if binstr < '5' then '0' else '1') x;;

// or

let fakeBin =
    (fun binstr -> if binstr < '5' then "0" else "1")
    |> String.collect;;

// -----------------------------------------------------------
// License
// Tasks are the property of Codewars (https://www.codewars.com/) 
// and users of this resource.
// 
// All solution code in this repository 
// is the personal property of Vladimir Rukavishnikov
// (vladimirrukavishnikovmail@gmail.com).
// 
// Copyright (C) 2023 Vladimir Rukavishnikov
// 
// This file is part of the HungryVovka/Codewars-F-sharp
// (https://github.com/HungryVovka/Codewars-F-sharp)
// 
// License is GNU General Public License v3.0
// (https://github.com/HungryVovka/Codewars-F-sharp/blob/main/LICENSE)
// 
// You should have received a copy of the GNU General Public License v3.0
// along with this code. If not, see http://www.gnu.org/licenses/
// -----------------------------------------------------------