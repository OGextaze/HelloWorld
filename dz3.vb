Imports System

Module Program

    Sub main(args As String())
        Dim a As String
        Dim b As Integer = 0
        Dim c As Integer = 0
        Dim d As Integer = 0
        Dim e As Integer = 0
        Console.WriteLine("Введите предложение:")
        a = Console.ReadLine
        For i = 0 To a.Length - 1
            Select Case Asc(a.Chars(i))
                Case 65, 69, 73, 79, 85, 89, 97, 101, 105, 111, 117, 121
                    b = b + 1
                Case 66 To 68, 70 To 72, 74 To 78, 80 To 84, 86 To 88, 90, 98 To 100, 102 To 104, 106 To 110, 112 To 116, 118 To 120, 122
                    c = c + 1
                Case 32
                    d = d + 1
                Case 33 To 48, 59 To 64, 91 To 96, 123 To 126
                    e = e + 1
            End Select
        Next

        Console.WriteLine("Итог:")
        Console.WriteLine("{0} гласных", b)
        Console.WriteLine("{0} согласных", c)
        Console.WriteLine("{0} пробелов", d)
        Console.WriteLine("{0} знаков препинания", e)
    End Sub
End Module