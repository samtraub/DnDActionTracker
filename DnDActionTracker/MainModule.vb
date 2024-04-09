Module MainModule
    Public Sub SaveCharacter(ByVal name As String, ByVal actions As List(Of Action))
        Dim character As New Character(name, actions)
    End Sub
End Module
