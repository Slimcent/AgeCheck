Module Module1

    Sub Main()
        Try
            'Dim age As Integer
            Dim age As String

            Console.WriteLine("Enter Age")
            age = Console.ReadLine()
            While String.IsNullOrEmpty(age) Or IsNumeric(age) = False
                Console.WriteLine("Age is Invalid")
                age = Console.ReadLine()
            End While

            If age >= 18 Then
                Console.WriteLine(" Congrats, You are Eligible to Vote")
            Else
                Console.WriteLine("Sorry! You are not Eligible to Vote")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

End Module
