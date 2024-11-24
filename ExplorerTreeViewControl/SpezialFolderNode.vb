' ****************************************************************************************************************
' SpezialFolderNode.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.Windows.Forms

Friend Class SpezialFolderNode : Inherits TreeNode

    Public Sub New(Folder As Environment.SpecialFolder)

        MyBase.New()
        Me.Name = GetSpezialFolderName(Folder)
        Me.Text = $"{Me.Name}"
        Me.ImageKey = GetSpezialFolderImageKey(Folder)
        Me.SelectedImageKey = Me.ImageKey

    End Sub

End Class
