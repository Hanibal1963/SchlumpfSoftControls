' ****************************************************************************************************************
' ComputerNode.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.IO
Imports System.Windows.Forms

Public Class ComputerNode : Inherits TreeNode

    ''' <summary>
    ''' Auflistung der speziellen Verzeichnisse
    ''' </summary>
    Private ReadOnly SpezialFolders As Environment.SpecialFolder() = {
          Environment.SpecialFolder.DesktopDirectory,
          Environment.SpecialFolder.MyDocuments,
          Environment.SpecialFolder.MyPictures,
          Environment.SpecialFolder.MyMusic,
          Environment.SpecialFolder.MyVideos}

    Public Sub New()

        MyBase.New()
        Me.Name = "Computer"
        Me.Text = $"{My.Computer.Name} (Dieser PC)"
        Me.ImageKey = "Computer"
        Me.SelectedImageKey = "Computer"
        Me.FillNodes()

    End Sub

    ''' <summary>
    ''' Füllt die Laufwerke und Verzeichnisse des Computers
    ''' </summary>
    Private Sub FillNodes()

        Dim nodes As TreeNode

        ' Alle Knoten löschen
        Me.Nodes.Clear()

        'spezielle Ordner hinzufügen
        For Each SFI As Environment.SpecialFolder In Me.SpezialFolders

            nodes = New SpezialFolderNode(SFI)
            Dim unused = Me.Nodes.Add(nodes)

        Next

        'Laufwerke hinzufügen
        For Each DRI As DriveInfo In My.Computer.FileSystem.Drives

            nodes = New DriveNode(DRI)
            Dim unused = Me.Nodes.Add(nodes)

        Next

    End Sub

End Class
