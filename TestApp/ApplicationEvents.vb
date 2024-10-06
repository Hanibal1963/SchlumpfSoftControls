' ****************************************************************************************************************
' ApplicationEvents.vb
' © 2024 by Andreas Sauer
'
' Für MyApplication sind folgende Ereignisse verfügbar:
' Startup, Shutdown, UnhandledException, StartupNextInstance, NetworkAvailabilityChanged 
'
' ****************************************************************************************************************
'

Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.Devices

Namespace My

    Partial Friend Class MyApplication

        ''' <summary>
        ''' Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
        ''' </summary>
        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As NetworkAvailableEventArgs) Handles _
                    Me.NetworkAvailabilityChanged

        End Sub

        ''' <summary>
        ''' Wird nach dem Schließen aller Anwendungsformulare ausgelöst.  
        ''' </summary>
        ''' <remarks>
        ''' Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung mit einem Fehler beendet wird.
        ''' </remarks>
        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles _
                    Me.Shutdown

        End Sub

        ''' <summary>
        ''' Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
        ''' </summary>
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles _
                    Me.Startup

            ' Sprache festlegen wenn noch nicht geschehen.
            If String.IsNullOrWhiteSpace(Settings.LangCode) Then
                Settings.LangCode = $"de-DE"
            End If
            ' Standardkommentarzeichen festlegen wenn noch nicht geschehen.
            If String.IsNullOrWhiteSpace(Settings.IniFile_CommentPrefix) Then
                Settings.IniFile_CommentPrefix = $";"
            End If
            ' Standardoption für automatisches speichern setzen wenn noch nicht geschehen.
            If Settings.IniFile_FileAutoSave = Nothing Then
                Settings.IniFile_FileAutoSave = False
            End If
            ' Standardverzeichnis für speichern und laden setzen wenn noch nicht geschehen.
            If String.IsNullOrWhiteSpace(Settings.IniFile_DefaultFolder) Then
                Settings.IniFile_DefaultFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            End If

        End Sub

        ''' <summary>
        ''' Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn die Anwendung bereits aktiv ist.
        ''' </summary>
        Private Sub MyApplication_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles _
                    Me.StartupNextInstance

        End Sub

        ''' <summary>
        ''' Wird bei einem Ausnahmefehler ausgelöst.
        ''' </summary>
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles _
                    Me.UnhandledException

        End Sub

    End Class

End Namespace
