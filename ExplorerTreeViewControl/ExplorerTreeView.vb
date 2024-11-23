﻿' ****************************************************************************************************************
' ExpTreeControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Stellt eine benutzerdefinierte Steuerung bereit, die ein TreeView-Steuerelement enthält, 
''' das die Verzeichnisstruktur des Computers anzeigt.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum Anzeigen der Laufwerke und Ordner eines Computers")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(ExplorerTreeView), "ExplorerTreeView.bmp")>
Public Class ExplorerTreeView : Inherits UserControl

    ''' <summary>
    ''' Wird ausgelöst, wenn sich der ausgewählte Pfad ändert.
    ''' </summary>
    Public Event SelectedPathChanged(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Gibt den vollständigen Pfad des ausgewähten Knotens zurück.
    ''' </summary>
    Public ReadOnly Property SelectedPath As String
        Get
            ' Holt den aktuell ausgewählten Knoten im TreeView.
            Dim node As TreeNode = Me.Tv1.SelectedNode
            ' Wenn ein Knoten ausgewählt ist, gibt den Pfad des Knotens zurück.
            If node IsNot Nothing Then
                Return GetNodePath(node)
            Else
                ' Wenn kein Knoten ausgewählt ist, gibt einen leeren String zurück.
                Return String.Empty
            End If
        End Get
    End Property

    ''' <summary>
    ''' Konstruktor der ExpTreeControl-Klasse.
    ''' </summary>
    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()
        ' Initialisiert die Steuerung.
        Me.IntitializeControl()
    End Sub

    ''' <summary>
    ''' Initialisiert die Steuerung.
    ''' </summary>
    Private Sub IntitializeControl()
        ' Füllt die ImageList mit den Standardbildern.
        Me.FillImageList()
        ' Füllt das TreeView mit den Standardbildern und Knoten.
        Me.FillTreeView()
    End Sub

    ''' <summary>
    ''' Füllt das TreeView mit den Standardbildern und Knoten.
    ''' </summary>
    Private Sub FillTreeView()
        ' Erstellt einen neuen Knoten für den Computer.
        Dim node As New ComputerNode
        ' Löscht alle vorhandenen Knoten im TreeView.
        Me.Tv1.Nodes.Clear()
        ' Fügt den neuen Computerknoten zum TreeView hinzu.
        Dim unused = Me.Tv1.Nodes.Add(node)
        ' Erweitert den Computerknoten, um seine Unterknoten anzuzeigen.
        node.Expand()
    End Sub

    ''' <summary>
    ''' Füllt die ImageList mit den Standardbildern für Computer, Laufwerke, Ordner und Spezialordner.
    ''' </summary>
    Private Sub FillImageList()
        ' Fügt die Bilder zu der ImageList hinzu, die im TreeView verwendet werden.
        Me.ImageList.Images.Add(
      $"Computer", My.Resources.ImgComputer)
        Me.ImageList.Images.Add(
      $"DesktopFolder", My.Resources.ImgDesktopFolder)
        Me.ImageList.Images.Add(
      $"DocumentsFolder", My.Resources.ImgDocumentsFolder)
        Me.ImageList.Images.Add(
      $"DownloadsFolder", My.Resources.ImgDownloadsFolder)
        Me.ImageList.Images.Add(
      $"Folder", My.Resources.ImgFolder)
        Me.ImageList.Images.Add(
      $"HardDrive", My.Resources.ImgHardDrive)
        Me.ImageList.Images.Add(
      $"MusicFolder", My.Resources.ImgMusicFolder)
        Me.ImageList.Images.Add(
      $"Network", My.Resources.ImgNetwork)
        Me.ImageList.Images.Add(
      $"NetworkDrive", My.Resources.ImgNetworkDrive)
        Me.ImageList.Images.Add(
      $"NetworkFolder", My.Resources.ImgNetworkFolder)
        Me.ImageList.Images.Add(
      $"OpticalDrive", My.Resources.ImgOpticalDrive)
        Me.ImageList.Images.Add(
      $"PicturesFolder", My.Resources.ImgPicturesFolder)
        Me.ImageList.Images.Add(
      $"SystemDrive", My.Resources.ImgSystemDrive)
        Me.ImageList.Images.Add(
      $"VideoFolder", My.Resources.ImgVideosFolder)
    End Sub

    ''' <summary>
    ''' Wird ausgelöst, bevor sich der ausgewählte Knoten ändert.
    ''' </summary>
    Private Sub Tv1_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles Tv1.BeforeExpand
        ' Versucht, den Knoten in einen DirectoryNode zu konvertieren.
        Dim node As DirectoryNode = TryCast(e.Node, DirectoryNode)
        ' Wenn der Knoten ein DirectoryNode ist, lädt die Unterverzeichnisse.
        If node IsNot Nothing Then
            node.LoadSubDirectories()
        End If
    End Sub

    ''' <summary>
    ''' Wird ausgelöst, wenn sich der ausgewählte Knoten geändert hat.
    ''' </summary>
    Private Sub Tv1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Tv1.AfterSelect
        ' Löst das SelectedPathChanged-Ereignis aus, um anzuzeigen, dass sich der ausgewählte Pfad geändert hat.
        RaiseEvent SelectedPathChanged(Me, EventArgs.Empty)
    End Sub

End Class