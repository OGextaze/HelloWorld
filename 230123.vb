Imports System
Imports System.Diagnostics.Metrics

Module Program
    Sub Main(args As String())
        Dim s As String
        Dim counter As Integer = 0
        Console.WriteLine("������� ������")
        s = Console.ReadLine
        For i = 0 To s.Length - 1
            Console.WriteLine(s.Chars(1))
            Console.WriteLine(Asc(s.Chars(i)))
            If Asc(s.Chars(i)) = 32 Then
                counter = counter + 1
            End If
        Next
        Console.WriteLine("� ������ 0 ��������", counter)
    End Sub
End Module
