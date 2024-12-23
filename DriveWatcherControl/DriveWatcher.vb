﻿'
'****************************************************************************************************************
'DriveWatcher.vb
'© 2023 - 2024 by Andreas Sauer
'****************************************************************************************************************
'
' weitere Infos:
' <Browsable> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.browsableattribute?view=netframework-4.7.2
' <Category> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.categoryattribute?view=netframework-4.7.2
' <Description> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.descriptionattribute?view=netframework-4.7.2

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports SchlumpfSoft.Attribute

''' <summary>
''' Steuerelement um die Laufwerke zu überwachen.
''' </summary>
<ProvideToolboxControl("Schlumpfsoft Controls", False)>
<ToolboxItem(True)>
<Description("Steuerelement um die Laufwerke zu überwachen.")>
<ToolboxBitmap(GetType(DriveWatcher), "DriveWatcher.bmp")>
Public Class DriveWatcher

    Inherits Component

    ' Wird vom Komponenten-Designer benötigt.
    Private ReadOnly components As IContainer

    ' Internes Formular welches die Meldungen empfängt.
    Private WithEvents NatForm As New NativeForm

    ''' <summary>
    ''' Wird ausgelöst wenn ein Laufwerk hinzugefügt wurde.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">
    ''' Enthält die Eigenschaften zum hinzugefügten Laufwerk. (<see cref="DriveAddedEventArgs"/>)
    ''' </param>
    <Description("Wird ausgelöst wenn ein Laufwerk hinzugefügt wurde.")>
    Public Event DriveAdded(sender As Object, e As DriveAddedEventArgs)

    ''' <summary>
    ''' Wird ausgelöst wenn ein Laufwerk entfernt wurde.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">
    ''' Enthält die Eigenschaften zum entfernten Laufwerk. (<see cref="DriveRemovedEventArgs"/>)
    ''' </param>
    <Description("Wird ausgelöst wenn ein Laufwerk entfernt wurde.")>
    Public Event DriveRemoved(sender As Object, e As DriveRemovedEventArgs)

    <Diagnostics.DebuggerNonUserCode()>
    Public Sub New()
        MyBase.New()
        'Dieser Aufruf ist für den Komponenten-Designer erforderlich.
        Me.InitializeComponent()
    End Sub

    ''' <summary>
    ''' Wird ausgelöst wenn ein Laufwerk hinzugefügt wurde
    ''' </summary>
    Private Sub NatForm_DriveAdded(sender As Object, e As DriveInfo) Handles NatForm.DriveAdded

        Dim arg As New DriveAddedEventArgs With {
            .DriveName = e.Name,
            .VolumeLabel = e.VolumeLabel,
            .AvailableFreeSpace = e.AvailableFreeSpace,
            .TotalFreeSpace = e.TotalFreeSpace,
            .TotalSize = e.TotalSize,
            .DriveFormat = e.DriveFormat,
            .DriveType = e.DriveType,
            .IsReady = e.IsReady}
        RaiseEvent DriveAdded(Me, arg)

    End Sub

    ''' <summary>
    ''' Wird ausgelöst wenn ein Laufwerk entfern wurde
    ''' </summary>
    Private Sub NatForm_DriveRemoved(sender As Object, e As DriveInfo) Handles NatForm.DriveRemoved

        Dim arg As New DriveRemovedEventArgs With {.DriveName = e.Name}
        RaiseEvent DriveRemoved(Me, arg)

    End Sub

    ''' <summary>
    ''' Hinweis: Die folgende Prozedur ist für den Komponenten-Designer erforderlich.
    ''' </summary>
    ''' <remarks>
    ''' Das Bearbeiten ist mit dem Komponenten-Designer möglich.<br/>
    ''' Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    ''' </remarks>
    <Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
    End Sub

    <Diagnostics.DebuggerNonUserCode()>
    Public Sub New(container As IContainer)

        MyClass.New()
        'Erforderlich für die Unterstützung des Windows.Forms-Klassenkompositions-Designers
        If container IsNot Nothing Then container.Add(Me)

    End Sub

    ''' <summary>
    ''' Die Komponente überschreibt den Löschvorgang zum Bereinigen der Komponentenliste.
    ''' </summary>
    ''' <param name="disposing"></param>
    <Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)

        Try
            If disposing Then
                If Me.components IsNot Nothing Then Me.components.Dispose()
                If Me.NatForm IsNot Nothing Then Me.NatForm.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try

    End Sub

    ''' <summary>
    ''' Definiert das Fenster welches die WindowsMessages empfängt.
    ''' </summary>
    Private Class NativeForm

        Inherits NativeWindow
        Implements IDisposable

        'Das sind die Ereignisse aus WParam.
        'Uns interessiert nur, ob ein Laufwerk hinzugekommen ist oder entfernt wurde.
        Public Event DriveAdded(sender As Object, e As DriveInfo)
        Public Event DriveRemoved(sender As Object, e As DriveInfo)

        'Windowmessage DeviceChange
        Private Const WM_DEVICECHANGE As Integer = &H219

        'Die beiden Ereignisse, die für uns von Bedeutung sind.
        Private Const DBT_DEVICEARRIVAL As Integer = &H8000
        Private Const DBT_DEVICEREMOVECOMPLETE As Integer = &H8004

        Private disposedValue As Boolean

        ''' <summary>
        ''' Das sind die Konstanten der Gerätetypen
        ''' </summary>
        ''' <remarks>
        ''' Vorsicht die Gerätetypen Variablen in den Strukturen sind vom Typ Integer.<br/>
        ''' IntelliSense kann das nicht auflösen.
        ''' </remarks>
        Private Enum DBT_DEVTYP

            ''' <summary>
            ''' OEM- oder IHV-definiert
            ''' </summary>
            OEM = 0

            ''' <summary>
            ''' Devnode-Nummer
            ''' </summary>
            DEVNODE = 1

            ''' <summary>
            ''' Logisches Volumen
            ''' </summary>
            VOLUME = 2

            ''' <summary>
            ''' Port (seriell oder parallel)
            ''' </summary>
            PORT = 3

            ''' <summary>
            ''' Netzwerkressource
            ''' </summary>
            NET = 4

            ''' <summary>
            ''' Geräteschnittstellenklasse
            ''' </summary>
            DEVICEINTERFACE = 5

            ''' <summary>
            ''' Dateisystem-Handle
            ''' </summary>
            HANDLE = 6

        End Enum

        ''' <summary>
        ''' Die Struktur für den Header.
        ''' </summary>
        ''' <remarks>
        ''' https://learn.microsoft.com/de-de/windows/win32/api/dbt/ns-dbt-dev_broadcast_hdr
        ''' </remarks>
        Private Structure DEV_BROADCAST_HDR

            Public dbch_size As Integer
            Public dbch_devicetype As Integer
            Public dbch_reserved As Integer

        End Structure

        ''' <summary>
        ''' Die Struktur für OEM.
        ''' </summary>
        ''' <remarks>
        ''' https://learn.microsoft.com/de-de/windows/win32/api/dbt/ns-dbt-dev_broadcast_oem
        ''' </remarks>
        Private Structure DEV_BROADCAST_OEM

            Public dbco_size As Integer
            Public dbco_devicetype As Integer
            Public dbco_reserved As Integer
            Public dbco_identifier As Integer
            Public dbco_suppfunc As Integer

        End Structure

        ''' <summary>
        ''' Die Struktur für Volumes.
        ''' </summary>
        ''' <remarks>
        ''' https://learn.microsoft.com/de-de/windows/win32/api/dbt/ns-dbt-dev_broadcast_volume
        ''' </remarks>
        Private Structure DEV_BROADCAST_VOLUME

            Public dbch_size As Integer
            Public dbch_devicetype As Integer
            Public dbch_reserved As Integer
            Public dbcv_unitmask As Integer
            Public dbcv_flags As Short

        End Structure

        'Dies ist der Dreh- und Angelpunkt der Klasse. - Hier bekommen wir die Messages mit.
        'In unserm Fall interessiert uns nur die WM_DeviceChange-Nachricht
        Protected Overrides Sub WndProc(ByRef m As Message)

            If m.Msg = WM_DEVICECHANGE Then Me.HandleHeader(m)
            MyBase.WndProc(m)

        End Sub

        'Hier schauen wir erst mal in den Header und verzweigen dementsprechend
        Private Sub HandleHeader(ByRef m As Message)

            Dim header As DEV_BROADCAST_HDR
            Dim objHeader As Object = m.GetLParam(header.GetType)

            If Not Microsoft.VisualBasic.IsNothing(objHeader) Then

                Select Case header.dbch_devicetype

                    Case DBT_DEVTYP.OEM
                        Me.HandleOEM(m)

                    Case DBT_DEVTYP.DEVNODE
                    Case DBT_DEVTYP.VOLUME
                        Me.HandleVolume(m)

                    Case DBT_DEVTYP.PORT
                    Case DBT_DEVTYP.NET
                    Case DBT_DEVTYP.DEVICEINTERFACE
                    Case DBT_DEVTYP.HANDLE

                End Select

            End If

        End Sub

        'Das Ereignis betrifft ein Volume
        Private Sub HandleVolume(ByRef m As Message)

            Dim volume As DEV_BROADCAST_VOLUME
            Dim objVolume As Object = m.GetLParam(volume.GetType)

            If Not Microsoft.VisualBasic.IsNothing(objVolume) Then

                volume = DirectCast(objVolume, DEV_BROADCAST_VOLUME)
                Dim di As New DriveInfo(Me.DriveFromMask(volume.dbcv_unitmask))

                Select Case CInt(m.WParam)

                    Case DBT_DEVICEARRIVAL
                        RaiseEvent DriveAdded(Me, di)

                    Case DBT_DEVICEREMOVECOMPLETE
                        RaiseEvent DriveRemoved(Me, di)

                End Select

            End If

        End Sub

        'OEM, und was genau?
        'Uns interesieren nur Volumes
        Private Sub HandleOEM(ByRef m As Message)

            Dim oem As DEV_BROADCAST_OEM
            Dim objOem As Object = m.GetLParam(oem.GetType)

            If Not Microsoft.VisualBasic.IsNothing(objOem) Then

                oem = DirectCast(objOem, DEV_BROADCAST_OEM)
                If oem.dbco_devicetype = DBT_DEVTYP.VOLUME Then Me.HandleVolume(m)

            End If

        End Sub

        'Liefert den Laufwerksbuchstaben zurück
        Private Function DriveFromMask(mask As Integer) As Char

            Dim result As Char = CChar(String.Empty)

            For b As Integer = 0 To 25

                If (mask And CInt(2 ^ b)) <> 0 Then

                    result = Microsoft.VisualBasic.Chr(65 + b)
                    Exit For

                End If

            Next b

            Return result

        End Function

        Public Sub New()

            Me.CreateHandle(New CreateParams) 'eigenes Handle erstellen

        End Sub

        Protected Overridable Sub Dispose(disposing As Boolean)

            If Not Me.disposedValue Then

                If disposing Then

                    ' Verwalteten Zustand (verwaltete Objekte) bereinigen
                    Me.DestroyHandle() 'eigenes Handle zerstören

                End If

                ' Nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer überschreiben
                ' Große Felder auf NULL setzen
                Me.disposedValue = True

            End If

        End Sub

        ' Finalizer nur überschreiben, wenn "Dispose(disposing As Boolean)"
        ' Code für die Freigabe nicht verwalteter Ressourcen enthält
        Protected Overrides Sub Finalize()

            ' Ändern Sie diesen Code nicht.
            ' Fügen Sie Bereinigungscode in der Methode "Dispose(disposing As Boolean)" ein.
            Me.Dispose(disposing:=False)
            MyBase.Finalize()

        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose

            ' Ändern Sie diesen Code nicht.
            ' Fügen Sie Bereinigungscode in der Methode "Dispose(disposing As Boolean)" ein.
            Me.Dispose(disposing:=True)
            GC.SuppressFinalize(Me)

        End Sub

    End Class

End Class
