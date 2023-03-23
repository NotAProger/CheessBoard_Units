Imports Microsoft.VisualBasic.Devices

Module Module1
    Sub one(Num As Integer)
        Console.Write(Num & "cm -> " & Num & "cm = ")
    End Sub

    Sub ten(Num As Integer)
        Console.Write(Num \ 10 & "dm, " & Num Mod 10 & "cm = ")
    End Sub
    Sub hundred(Num As Integer)
        Dim hund = Num \ 10
        hund = hund Mod 10
        Dim thousand = Num \ 100
        Console.Write(thousand & "m, " & hund & "dm, " & Num Mod 10 & "cm = ")
    End Sub

    Sub thous(Num As Integer)
        Dim hund = Num \ 10
        hund = hund Mod 10
        Dim thousand = Num \ 100
        thousand = thousand Mod 1000
        Console.Write(Num \ 100000 & "km, " & thousand & "m, " & hund & "dm, " & Num Mod 10 & "cm")
    End Sub
    Sub Input()
        Dim Num As Integer
        Console.Write("Write in sm -> ")
        Num = Console.ReadLine()

        one(Num)
        ten(Num)
        hundred(Num)
        thous(Num)
    End Sub
    Sub Main()

        Console.Write("каждый ")
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.Write("охотник ")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("желает ")
        Console.ForegroundColor = ConsoleColor.Green
        Console.Write("знать, ")
        Console.ForegroundColor = ConsoleColor.Blue
        Console.Write("где ")
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.Write("сидит")
        Console.Read()
    End Sub
End Module
