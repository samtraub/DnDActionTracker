Imports System.IO
Imports Newtonsoft.Json

Module MainModule
    Private CharacterPath As String = Path.Combine(Application.StartupPath, "Characters")

    Public Sub SaveCharacter(ByVal name As String, ByVal actions As List(Of Action))
        Dim character As New Character(name, actions)
        If Not Directory.Exists(CharacterPath) Then
            Directory.CreateDirectory(CharacterPath)
        End If

        Dim output As String = JsonConvert.SerializeObject(character)
        Using sw As New StreamWriter(Path.Combine(CharacterPath, name & ".json"))
            sw.WriteLine(output)
        End Using
    End Sub
End Module
