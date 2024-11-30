' ****************************************************************************************************************
' FormExplorerTreeViewControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.IO

Public Class FormExplorerTreeViewControl

    Private Sub ExplorerTreeView_SelectedPathChanged(sender As Object, e As EventArgs) Handles ExplorerTreeView.SelectedPathChanged

        ' aktuell ausgewählten Pfad anzeigen
        Dim selpath As String = Me.ExplorerTreeView.SelectedPath
        Dim text As String = $"{Me.TextBox.Text}{vbCrLf}aktuell ausgewählter Pfad: {selpath}"
        Me.TextBox.Text = text

        ' Liste leeren
        Me.ListView.Items.Clear()

        Try

            ' Unterverzeichnisse auslesen
            For Each dir As String In Directory.GetDirectories(selpath)
                Dim unused1 = Me.ListView.Items.Add(Me.GetName(dir))
            Next

            ' Dateien auslesen
            For Each file As String In Directory.GetFiles(selpath)
                Dim unused2 = Me.ListView.Items.Add(Me.GetName(file))
            Next

        Catch ex As IOException

        End Try

    End Sub

    Private Sub ButtonSearchPath_Click(sender As Object, e As EventArgs) Handles ButtonSearchPath.Click

        Dim result As DialogResult = Me.FolderBrowserDialog.ShowDialog(Me)
        If result = DialogResult.OK Then

            Me.LabelPath.Text = Me.FolderBrowserDialog.SelectedPath
            Me.ExplorerTreeView.ExpandPath(Me.FolderBrowserDialog.SelectedPath)

        End If

    End Sub

    Private Function GetName(FileOrDirectory As String) As String

        Return Path.GetFileName(FileOrDirectory)

    End Function

End Class