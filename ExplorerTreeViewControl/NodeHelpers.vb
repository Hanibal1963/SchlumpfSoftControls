' ****************************************************************************************************************
' NodeHelpers.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.IO

''' <summary>
''' Hilfsfunktionen für den Zugriff auf Knoteninformationen.
''' </summary>
Module NodeHelpers

  ''' <summary>
  ''' Gibt den vollständigen Pfad des angegebenen Knotens zurück.
  ''' </summary>
  Friend Function GetNodePath(Node As TreeNode) As String
    'feststellen des Knotentyps
    Select Case True
      Case Node.GetType.Name = GetType(ComputerNode).Name
        'Computerknoten
        Return $"{Path.DirectorySeparatorChar}"
      Case Node.GetType.Name = GetType(DriveNode).Name
        'Laufwerksknoten
        Return $"{Split(Node.FullPath, "(").Last.Replace(")", "") & "\"}"
      Case Node.GetType.Name = GetType(DirectoryNode).Name
        'Verzeichnisknoten
        Return $"{Split(Node.FullPath, "(").Last.Replace(")", "") & "\"}"
      Case Node.GetType.Name = GetType(SpezialFolderNode).Name
        'Spezialordnerknoten
        Return $"{GetSpezialFolderPath(Split(Node.FullPath, "\").Last)}"
      Case Else
        Return $"{Node.FullPath}"
    End Select
  End Function

  ''' <summary>
  ''' Gibt den vollen Pfade des speziellen Ordners zurück
  ''' </summary>
  Friend Function GetSpezialFolderPath(SpezialFolderName As String) As String
    'feststellen des speziellen Ordnername
    Select Case SpezialFolderName
      Case "Desktop"
        Return $"{Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\"}"
      Case "Dokumente"
        Return $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\"}"
      Case "Bilder"
        Return $"{Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) & "\"}"
      Case "Musik"
        Return $"{Environment.GetFolderPath(Environment.SpecialFolder.MyMusic) & "\"}"
      Case "Videos"
        Return $"{Environment.GetFolderPath(Environment.SpecialFolder.MyVideos) & "\"}"
      Case Else
        Return $"{SpezialFolderName}"
    End Select
  End Function

  ''' <summary>
  ''' Gibt den einfachen Name eines speziellen Ordners zurück
  ''' </summary>
  Friend Function GetSpezialFolderName(Folder As Environment.SpecialFolder) As String
    'feststellen des Spezialordners
    Select Case Folder
      Case Environment.SpecialFolder.DesktopDirectory
        Return $"Desktop"
      Case Environment.SpecialFolder.MyDocuments
        Return $"Dokumente"
      Case Environment.SpecialFolder.MyPictures
        Return $"Bilder"
      Case Environment.SpecialFolder.MyMusic
        Return $"Musik"
      Case Environment.SpecialFolder.MyVideos
        Return $"Videos"
      Case Else
        Return $"{Folder}"
    End Select
  End Function

  Friend Function GetSpezialFolderImageKey(Folder As Environment.SpecialFolder) As String
    'feststellen des Spezialordners
    Select Case Folder
      Case Environment.SpecialFolder.DesktopDirectory
        Return "DesktopFolder"
      Case Environment.SpecialFolder.MyDocuments
        Return "DocumentsFolder"
      Case Environment.SpecialFolder.MyPictures
        Return "PicturesFolder"
      Case Environment.SpecialFolder.MyMusic
        Return "MusicFolder"
      Case Environment.SpecialFolder.MyVideos
        Return "VideoFolder"
      Case Else
        Return Folder.ToString
    End Select
  End Function

End Module
