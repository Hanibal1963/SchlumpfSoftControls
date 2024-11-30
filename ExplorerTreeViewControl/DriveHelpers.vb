' ****************************************************************************************************************
' Helpers.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.IO

''' <summary>
''' Hilfsfunktionen für den Zugriff auf Laufwerksinformationen.
''' </summary>
Friend Module DriveHelpers

    ''' <summary>
    ''' Gibt den Laufwerksbuchstaben des angegebenen Laufwerks zurück.
    ''' </summary>
    Friend Function GetDriveName(di As DriveInfo) As String

        Return di.Name.Remove(di.Name.Length - 1)

    End Function

    ''' <summary>
    ''' Gibt den Namen des angegebenen Laufwerks zurück.
    ''' </summary>
    Friend Function GetVolumeName(di As DriveInfo) As String

        Return If(di.IsReady, di.VolumeLabel, GetDriveType(di))

    End Function

    ''' <summary>
    ''' Gibt den Typ des angegebenen Laufwerks zurück.
    ''' </summary>
    Friend Function GetDriveType(di As DriveInfo) As String

        Dim result As String = $""

        Select Case True

            Case di.DriveType = DriveType.Fixed
                result = "Lokaler Datenträger"

            Case di.DriveType = DriveType.CDRom
                result = "CD-Laufwerk"

        End Select

        Return result

    End Function

    ''' <summary>
    ''' Gibt den Schlüssel des Laufwerksbilds des angegebenen Laufwerks zurück.
    ''' </summary>
    Friend Function GetDriveImageKey(di As DriveInfo) As String

        Dim result As String = $""

        Select Case True
            Case di.DriveType = DriveType.Fixed
                result = If(di.Name.Equals(
                  Path.GetPathRoot(Environment.SystemDirectory),
                  StringComparison.OrdinalIgnoreCase), "SystemDrive", "HardDrive")

            Case di.DriveType = DriveType.CDRom
                result = "OpticalDrive"

            Case di.DriveType = DriveType.Network
                result = "NetworkDrive"

            Case di.DriveType = DriveType.Removable
                result = "HardDrive"

            Case di.DriveType = DriveType.Ram
                result = "HardDrive"

            Case di.DriveType = DriveType.Unknown
                result = "HardDrive"

        End Select

        Return result

    End Function

End Module
