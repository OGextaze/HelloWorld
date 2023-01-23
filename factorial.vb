Imports System

Module factorial
    Sub Main(args As String())
        Dim N As Integer, F As Integer = 1
        Console.Write("ß óìåþ ñ÷èòàòü ôàêòîðèàë. Ââåäèòå öåëîå ÷èñëî: N = ")
        N = Console.ReadLine
        For i As Integer = 1 To N
            If F <= Int32.MaxValue / i Then
                F = F * i
            Else
                Console.WriteLine("Ïåðåïîëíåíèå ïàìÿòè! Ðàñ÷åò âûïîëíåí äëÿ N = {0}", i - 1)
                Exit For
            End If
        Next
        Console.WriteLine("N! = {0}", F)
    End Sub
End Module
