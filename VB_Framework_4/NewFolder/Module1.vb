Namespace NewFolder
    Module Module1

        Sub Main()
            Dim i As Integer
        End Sub
        Public Sub MyMethod()
            Dim myRootPath As String = Nothing ' Replace this with the actual value of myRootPath
            If myRootPath Is Nothing Then
                Console.WriteLine("myRootPath is null")
                Return
            End If
            Dim myWholeFilePath As String = $"{myRootPath}/README.md"
            ' Continue with your logic
        End Sub

    End Module
End Namespace