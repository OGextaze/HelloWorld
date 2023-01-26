Imports System

Module Program
    Sub Main(args As String())
        'TODO: Генерируем число
        Dim number As String = "1234"
        Console.WriteLine("Угадай число")
        Dim ver As String

        Do
            ver = Console.ReadLine()

            For i As Integer = 0 To 3
                If ver.Chars(0) = number.Chars(i) Then
                    If i = 0 Then
                        Console.WriteLine("Первая цифра вашей версии - корова")
                    Else
                        Console.WriteLine("Первая цифра вашей версии - бык")
                    End If
                End If
            Next

            If number = ver Then
                Console.WriteLine("Угадал")
            Else
                Console.WriteLine("Неугадал")
            End If

        Loop Until number = ver

    End Sub
End Module
