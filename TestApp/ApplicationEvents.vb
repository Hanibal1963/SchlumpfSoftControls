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
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MyApplication_NetworkAvailabilityChanged(
                    sender As Object,
                    e As NetworkAvailableEventArgs) Handles _
                    Me.NetworkAvailabilityChanged

        End Sub

        ''' <summary>
        ''' Wird nach dem Schließen aller Anwendungsformulare ausgelöst.  
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks>
        ''' Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung mit einem Fehler beendet wird.
        ''' </remarks>
        Private Sub MyApplication_Shutdown(
                    sender As Object,
                    e As EventArgs) Handles _
                    Me.Shutdown

        End Sub

        ''' <summary>
        ''' Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MyApplication_Startup(
                    sender As Object,
                    e As StartupEventArgs) Handles _
                    Me.Startup

            ' Sprache festlegen wenn noch nicht geschehen
            If String.IsNullOrWhiteSpace(My.Settings.LangCode) Then

                My.Settings.LangCode = $"de-DE"

            End If

        End Sub

        ''' <summary>
        ''' Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn die Anwendung bereits aktiv ist.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MyApplication_StartupNextInstance(
                    sender As Object,
                    e As StartupNextInstanceEventArgs) Handles _
                    Me.StartupNextInstance

        End Sub

        ''' <summary>
        ''' Wird bei einem Ausnahmefehler ausgelöst.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub MyApplication_UnhandledException(
                    sender As Object,
                    e As UnhandledExceptionEventArgs) Handles _
                    Me.UnhandledException

        End Sub

    End Class

End Namespace
