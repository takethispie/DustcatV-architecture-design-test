module Tests

open System
open Xunit
open DustcatV
open ExecutionStageUnitsModule

[<Fact>]
let ``My test`` () =
    Assert.True(true)

[<Fact>]
let basicLoop () =
    let IEU: ExecutionUnit = 
        { 
            ReservationStations = [
                { Id = 1; State = Empty { Op = ""; Qj = 0; Qk = 0; Vj = ""; Vk = ""; }; Result = ""}
                { Id = 2; State = Empty { Op = ""; Qj = 0; Qk = 0; Vj = ""; Vk = ""; }; Result = ""}
                { Id = 3; State = Empty { Op = ""; Qj = 0; Qk = 0; Vj = ""; Vk = ""; }; Result = ""}
                { Id = 4; State = Empty { Op = ""; Qj = 0; Qk = 0; Vj = ""; Vk = ""; }; Result = ""}
            ]; 
            HasFreeStation = true; 
        }
    let (exunit, message) = IntegerExecutionUnit("add", 1, 1, { Source = 1; Value = "5"}, IEU)
    Assert.Equal(message.Source, 1)
    Assert.True(true)
