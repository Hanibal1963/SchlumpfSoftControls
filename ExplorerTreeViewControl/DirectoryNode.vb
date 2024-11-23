' ****************************************************************************************************************
' DirectoryNode.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.IO

Friend Class DirectoryNode

  Inherits TreeNode

  Public Sub New(DII As DirectoryInfo)
    MyBase.New()
    Me.Name = DII.Name
    Me.Text = $"{Me.Name}"
    Me.ImageKey = "Folder"
    Me.SelectedImageKey = Me.ImageKey
    'wenn Unterverzeichnisse vorhanden sind, wird ein Dummy hinzugefügt
    If DII.GetDirectories().Any() Then
      Dim unused = Me.Nodes.Add(New TreeNode(""))
    End If
  End Sub

  Private Sub FillNodes(DII As DirectoryInfo)
    Dim node As DirectoryNode
    Me.Nodes.Clear()
    Try
      For Each d As DirectoryInfo In DII.GetDirectories
        node = New DirectoryNode(d)
        Dim unused = Me.Nodes.Add(node)
      Next
    Catch ex As UnauthorizedAccessException
    End Try
  End Sub

  ''' <summary>
  ''' Lädt die Unterverzeichnisse des aktuellen Verzeichnisses.
  ''' </summary>
  Public Sub LoadSubDirectories()
    Dim path As String = GetNodePath(Me)
    Me.FillNodes(New DirectoryInfo(path))
  End Sub

End Class
