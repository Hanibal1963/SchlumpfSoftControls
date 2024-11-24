' ****************************************************************************************************************
' DriveNode.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.IO
Imports System.Windows.Forms

Friend Class DriveNode : Inherits TreeNode

    Public Sub New(DrI As DriveInfo)
        MyBase.New
        Me.Name = GetDriveName(DrI)
        Me.Text = $"{GetVolumeName(DrI)} ({Me.Name})"
        Me.ImageKey = GetDriveImageKey(DrI)
        Me.SelectedImageKey = Me.ImageKey
        Me.FillNodes(DrI)
    End Sub

    Private Sub FillNodes(DrI As DriveInfo)

        Dim node As DirectoryNode

        ' alle Knoten löschen
        Me.Nodes.Clear()

        Try

            If DrI.IsReady Then
                For Each d As DirectoryInfo In DrI.RootDirectory.GetDirectories
                    node = New DirectoryNode(d)
                    Dim unused = Me.Nodes.Add(node)
                Next
            End If

        Catch ex As UnauthorizedAccessException

        End Try

    End Sub

End Class
