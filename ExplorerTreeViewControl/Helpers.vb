﻿' ****************************************************************************************************************
' Helpers.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.Windows.Forms

Friend Module Helpers

    ''' <summary>
    ''' Füllt das TreeView mit den Standardbildern und Knoten.
    ''' </summary>
    Friend Sub FillTreeView(ByRef TV As TreeView)

        ' Erstellt einen neuen Knoten für den Computer.
        Dim node As New ComputerNode

        ' Löscht alle vorhandenen Knoten im TreeView.
        TV.Nodes.Clear()

        ' Fügt den neuen Computerknoten zum TreeView hinzu.
        Dim unused = TV.Nodes.Add(node)

        ' Erweitert den Computerknoten, um seine Unterknoten anzuzeigen.
        node.Expand()

    End Sub

    ''' <summary>
    ''' Füllt die ImageList mit den Standardbildern für Computer, Laufwerke, Ordner und Spezialordner.
    ''' </summary>
    Friend Sub FillImageList(ByRef Images As ImageList)

        ' Fügt die Bilder zu der ImageList hinzu, die im TreeView verwendet werden.
        Images.Images.Add($"Computer", My.Resources.ImgComputer)

        Images.Images.Add($"DesktopFolder", My.Resources.ImgDesktopFolder)

        Images.Images.Add($"DocumentsFolder", My.Resources.ImgDocumentsFolder)

        Images.Images.Add($"DownloadsFolder", My.Resources.ImgDownloadsFolder)

        Images.Images.Add($"Folder", My.Resources.ImgFolder)

        Images.Images.Add($"HardDrive", My.Resources.ImgHardDrive)

        Images.Images.Add($"MusicFolder", My.Resources.ImgMusicFolder)

        Images.Images.Add($"Network", My.Resources.ImgNetwork)

        Images.Images.Add($"NetworkDrive", My.Resources.ImgNetworkDrive)

        Images.Images.Add($"NetworkFolder", My.Resources.ImgNetworkFolder)

        Images.Images.Add($"OpticalDrive", My.Resources.ImgOpticalDrive)

        Images.Images.Add($"PicturesFolder", My.Resources.ImgPicturesFolder)

        Images.Images.Add($"SystemDrive", My.Resources.ImgSystemDrive)

        Images.Images.Add($"VideoFolder", My.Resources.ImgVideosFolder)

    End Sub

End Module
