' ****************************************************************************************************************
' FormDriveWatcherControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System.Globalization
Imports System.Threading

Public Class FormDriveWatcherControl


    Public Sub New()

        'Zuletzt verwendete Sprache einstellen
        Thread.CurrentThread.CurrentCulture = New CultureInfo(My.Settings.LangCode)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.LangCode)

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub


    Private Sub DriveAdded(
                sender As Object,
                e As SchlumpfSoft.Controls.DriveWatcherControl.DriveAddedEventArgs) Handles _
                DriveWatcher1.DriveAdded

        Me.Label_result.Text = String.Format(
            My.Resources.DriveWatcherMsgLine1, e.DriveName)
        Me.Label_result.Text &= vbCrLf & String.Format(
            My.Resources.DriveWatcherMsgLine2, e.VolumeLabel, e.DriveType)
        Me.Label_result.Text &= vbCrLf & String.Format(
            My.Resources.DriveWatcherMsgLine3, e.DriveFormat, e.TotalSize)

        If e.IsReady Then

            Me.Label_result.Text &= vbCrLf & String.Format(
                My.Resources.DriveWatcherMsgLine4, e.TotalFreeSpace)

        Else

            Me.Label_result.Text &= vbCrLf & String.Format(My.Resources.DriveWatcherMsgLine5)

        End If

    End Sub


    Private Sub DriveRemoved(
                sender As Object,
                e As SchlumpfSoft.Controls.DriveWatcherControl.DriveRemovedEventArgs) Handles _
                DriveWatcher1.DriveRemoved

        Me.Label_result.Text = String.Format(My.Resources.DriveWatcherMsgLine6, e.DriveName)

    End Sub


End Class