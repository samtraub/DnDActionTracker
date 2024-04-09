Imports System.IO
Imports Newtonsoft.Json

Module MainModule
    Private CharacterPath As String = Path.Combine(Application.StartupPath, "Characters")

    Public Function GetCharacterList() As String()
        Dim charList As New List(Of String)
        For Each file As String In Directory.GetFiles(CharacterPath, "*.json")
            charList.Add(Path.GetFileNameWithoutExtension(file))
        Next

        Return charList.ToArray
    End Function

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

    Public Function GetCharacterFromName(ByVal name As String) As Character
        Dim filePath As String = Path.Combine(CharacterPath, name & ".json")
        Dim character As Character
        Using sr As New StreamReader(filePath)
            character = JsonConvert.DeserializeObject(Of Character)(sr.ReadLine)
        End Using
        Return character
    End Function
End Module
