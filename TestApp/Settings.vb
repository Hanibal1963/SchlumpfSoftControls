' ****************************************************************************************************************
' Settings.vb
' © 2023 - 2024 by Andreas Sauer
'
' Diese Klasse ermöglicht die Behandlung bestimmter Ereignisse der Einstellungsklasse:
' SettingChanging, PropertyChanged, SettingsLoaded, SettingsSaving
'
' ****************************************************************************************************************
'

Imports System.ComponentModel
Imports System.Configuration

Namespace My

    Partial Friend NotInheritable Class MySettings

        ''' <summary>
        ''' Wird ausgelöst, nachdem der Wert einer Einstellung geändert wurde.
        ''' </summary>
        Private Sub MySettings_PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Handles _
                    Me.PropertyChanged

        End Sub

        ''' <summary>
        ''' Wird ausgelöst, bevor der Wert einer Einstellung geändert wird.
        ''' </summary>
        Private Sub MySettings_SettingChanging(sender As Object, e As SettingChangingEventArgs) Handles _
                    Me.SettingChanging

        End Sub

        ''' <summary>
        ''' Wird ausgelöst, nachdem die Einstellungswerte geladen wurden.
        ''' </summary>
        Private Sub MySettings_SettingsLoaded(sender As Object, e As SettingsLoadedEventArgs) Handles _
                    Me.SettingsLoaded

        End Sub

        ''' <summary>
        ''' Wird ausgelöst, bevor die Einstellungswerte gespeichert werden.
        ''' </summary>
        Private Sub MySettings_SettingsSaving(sender As Object, e As CancelEventArgs) Handles _
                    Me.SettingsSaving

        End Sub

    End Class

End Namespace
