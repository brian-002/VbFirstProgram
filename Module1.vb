Module Module1
    'program that accepts students,firstname,secondname,course and marks for units.
    'must use functions to compute for sum, avarage and award students grades.
    'it should process any number of students
    'use error handling mechanisms

    Dim students As New Dictionary(Of Integer, String) From
        {{1, "brian prisely"},
         {2, "elvis read"},
          {3, "prei dep"}}

    Public Function sumall(ByVal statistics As Integer, ByVal os As Integer, ByVal physics As Integer, ByVal maths As Integer, ByVal chemistry As Integer, ByVal biology As Integer, ByVal sociology As Integer, ByVal databases As Integer) As Integer
        REM adds all the marks given and gives the output
        Dim sum As Integer
        sum = statistics + os + physics + maths + chemistry + biology + sociology + databases
        Return sum
    End Function

    Public Function avamark(ByVal statistics As Integer, ByVal os As Integer, ByVal physics As Integer, ByVal maths As Integer, ByVal chemistry As Integer, ByVal biology As Integer, ByVal sociology As Integer, ByVal databases As Integer) As Integer
        REM finds the avarage of the total marks given
        Dim sum As Integer
        Dim avarage As Integer
        sum = statistics + os + physics + maths + chemistry + biology + sociology + databases
        avarage = sum / 8
        Return avarage
    End Function

    Public Function grades(ByVal grade As Integer, ByVal statistics As Integer, ByVal os As Integer, ByVal physics As Integer, ByVal maths As Integer, ByVal chemistry As Integer, ByVal biology As Integer, ByVal sociology As Integer, ByVal databases As Integer) As String
        REM awards grades based on the avarage marks
        Dim marks As Integer
        Dim sum As Integer
        Dim avarage As Integer
        sum = statistics + os + physics + maths + chemistry + biology + sociology + databases
        avarage = sum / 8
        marks = avamark(statistics, os, physics, maths, chemistry, biology, sociology, databases)

        If marks > 100 Then
            Throw New Exception("cannot be more than 100")
        End If

        If (marks >= 70) And (marks <= 100) Then
            Console.Write("A")

        ElseIf (marks >= 60) And (marks < 70) Then
            Console.Write("B")

        ElseIf (marks >= 50) And (marks < 60) Then
            Console.Write("C")

        ElseIf (marks >= 40) And (marks < 50) Then
            Console.Write("D")
        Else
            Console.Write("F")
        End If
        Return marks

    End Function
    Sub Main()

        Dim firstname, secondname, course As String, databases As Integer
        Console.Write("enter first name: ")
        firstname = Console.ReadLine()
        Console.Write("enter second name: ")
        secondname = Console.ReadLine()
        Console.Write("enter course name: ")
        course = Console.ReadLine()



        Dim statistics, os, physics, maths, chemistry, biology, sociology, Result, Result1, Result2, grade As Integer
        Console.Write("enter statistics: ")
        statistics = Console.ReadLine()
        Console.Write("enter os: ")
        os = Console.ReadLine()
        Console.Write("enter physics: ")
        physics = Console.ReadLine()
        Console.Write("enter math: ")
        maths = Console.ReadLine()
        Console.Write("enter chemistry: ")
        chemistry = Console.ReadLine()
        Console.Write("enter biology: ")
        biology = Console.ReadLine()
        Console.Write("enter sociology: ")
        sociology = Console.ReadLine()
        Console.Write("enter databases: ")
        databases = Console.ReadLine()

        Result = sumall(statistics, os, physics, maths, chemistry, biology, sociology, databases)

            Result1 = avamark(statistics, os, physics, maths, chemistry, biology, sociology, databases)


            Console.Write("first name: {0}, second name {1}, course name: {2}, statistics: {3}, os: {4}, physics: {5}, math: {6},chemistry: {7}, biology: {8}, sociology: {9}, databases: {10}, total: {11}, avarage: {12}", firstname, secondname, course, statistics, os, physics, maths, chemistry, biology, sociology, databases, Result, Result1)
            Console.ReadKey()

    End Sub

End Module
