Module Module1
    'brooks keller
    '1/8/24
    'ex1
    Private filename As String = "keller-ex1.csv"
    Private Const separator As String = ","
    Sub main()
        Dim input As String
        Do
            Console.Write("Enter r to read in a file, w to write to file or q to quit -> ")
            input = Console.ReadLine.Trim.ToLower
            If input = "r" Then
                ReadInFile()
            ElseIf input = "w" Then
                WriteToFile()
            End If
        Loop While input <> "q"
    End Sub
    Sub ReadInFile()
        If Not IO.File.Exists(filename) Then
            Console.WriteLine($"{filename} does not exist")
            Return
        End If

        Dim infile As New IO.StreamReader(filename)
        While infile.Peek <> -1
            'employeenum is 0, name is is 1, sales is 2
            Dim line() As String = infile.ReadLine.Split(separator)
            Console.WriteLine($"{line(0)}       {line(1)}       {line(2)}")
            '{line(0)}
        End While
        infile.Close()
    End Sub
    Sub WriteToFile()
        Dim name, employeenum, sales As String
        Console.Write("Enter the employee's last name >> ")
        name = Console.ReadLine.Trim
        Console.Write($"Enter {name}'s employee number >> ")
        employeenum = Console.ReadLine.Trim
        Console.Write($"Enter {name}'s sales >> ")
        sales = Console.ReadLine.Trim
        Dim file As New IO.StreamWriter(filename, True)
        file.WriteLine($"{employeenum}{separator}{name}{separator}{sales}")
    End Sub
End Module