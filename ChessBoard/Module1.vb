Module Module1
    Sub collorChange(Col As String)
        Select Case Col
            Case = "green"
                Console.ForegroundColor = ConsoleColor.Green
            Case = "yellow"
                Console.ForegroundColor = ConsoleColor.Yellow
            Case = "blue"
                Console.ForegroundColor = ConsoleColor.Blue
        End Select
    End Sub
    Sub sqware(posX As Byte, posY As Byte, lenght As Byte, height As Byte, symb As String, Col As String)
        Console.SetCursorPosition(posX, posY)
        collorChange(Col)
        For i As Byte = 1 To height
            For r As Byte = 1 To lenght
                Console.Write(symb)
            Next
            Console.SetCursorPosition(posX, posY + i)
        Next
    End Sub
    'Взял легаси с консольной графики

    Sub ChessSqware(posX As Byte, posY As Byte, lenghtTile As Byte, symbFrame As String, symbBlack As String, symbWhite As String)
        'делаем рамку, кол-во клеток + 2 дял рамки, т.к. буквы имеют соотношение 1/2 у делаем в 2 раза меньше
        sqware(posX + lenghtTile, posY + lenghtTile / 2, lenghtTile * 10, lenghtTile * 5, symbFrame, "green")
        'делаем черные клеточки, смещаем координаты внитрь поля
        sqware(posX + 2 * lenghtTile, posY + lenghtTile, lenghtTile * 8, lenghtTile * 4, symbWhite, "blue")
        'переменные для удобства
        Dim twoLen As Byte = lenghtTile * 2
        Dim halfLen As Byte = lenghtTile / 2
        For i As Byte = 1 To 4
            For e As Byte = 1 To 4
                'делаем через 1 клеточку т.к. они чередуются, логично, правда?
                Dim x As Byte = e * twoLen + posX
                Dim y As Byte = i * lenghtTile + posY
                sqware(x, y, lenghtTile, halfLen, symbBlack, "yellow")
                'другой ряд клеток
                sqware(x + lenghtTile, y + halfLen, lenghtTile, halfLen, symbBlack, "yellow")
            Next
        Next
    End Sub
    Sub Main()
        'вбиваем переменные
        'отступ не должен быть меньше размера клеток (первые 2 пееременные)
        'резмер клеток определяется 3-й переменной, черные клетки - 4-й, белые - 5-й

        ChessSqware(10, 10, 10, "I", "u", "0")
        Console.Read()
    End Sub

End Module
