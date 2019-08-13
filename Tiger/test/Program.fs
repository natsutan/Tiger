// F# の詳細については、http://fsharp.org を参照してください
// 詳細については、'F# チュートリアル' プロジェクトを参照してください。
open NUnit.Framework

[<Test>]
let sum_test() =
    Assert.AreEqual(9, 9)


[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // 整数の終了コードを返します
