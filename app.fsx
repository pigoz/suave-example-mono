#r "packages/Suave/lib/net40/Suave.dll"
open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful

let app : WebPart =
  choose [
    GET >=> choose [
      path "/" >=> OK "hello world; go to /test"
      path "/test" >=> OK "it works!"
    ]
  ]
