Module Module1

    Sub Main()
        Dim a, b, c, d As Integer
        Dim e As String
        a = 0 : b = 0 : c = 0 : d = 0 : e = ""
        Console.WriteLine("輸入數字")
        a = Console.ReadLine()
        Do Until c = 1
            b = a Mod 2
            c = a \ 2
            a = c
            e = b & e
            d = c & e

        Loop
        Console.WriteLine(d)
        Console.Read()
    End Sub

End Module
