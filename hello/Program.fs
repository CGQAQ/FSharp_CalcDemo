
[<EntryPoint>]
let main args= 
    let str = stdin.ReadLine()

    for i = 0 to str.Length-1 do
        if str.[i].CompareTo('+') = 0 then
            let sub1:int = Core.int.Parse str.[0..i-1]
            let sub2:int = Core.int.Parse str.[i+1..str.Length-1]
            printfn "%A" (sub1+sub2)

        if str.[i].CompareTo('-') = 0 then
            let sub1:int = Core.int.Parse str.[0..i-1]
            let sub2:int = Core.int.Parse str.[i+1..str.Length-1]
            printfn "%A" (sub1-sub2)

        if str.[i].CompareTo('*') = 0 then
           let sub1:int = Core.int.Parse str.[0..i-1]
           let sub2:int = Core.int.Parse str.[i+1..str.Length-1]
           printfn "%A" (sub1*sub2)

        if str.[i].CompareTo('/') = 0 then
           let sub1:int = Core.int.Parse str.[0..i-1]
           let sub2:int = Core.int.Parse str.[i+1..str.Length-1]
           printfn "%A" (sub1/sub2)

    stdin.Read()
    0