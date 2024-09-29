' ****************************************************************************************************************
' FormIniFileControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.Globalization
Imports System.Threading
Imports SchlumpfSoft.Controls.IniFileControl

''' <summary>
''' Formular zum Anzeigen und Bearbeiten einer INI-Datei.
''' </summary>
Public Class FormIniFileControl

#Region "Definition der internen Variablen"

    ''' <summary>
    ''' Speichert den Dateinamen der geöffneten oder gespeicherten Datei.
    ''' </summary>
    Private filename As String = Nothing

#End Region

    Public Sub New()

        ' gespeicherte Sprache einstellen
        Thread.CurrentThread.CurrentCulture = New CultureInfo(My.Settings.LangCode)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.LangCode)

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        Me.SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    End Sub

#Region "Interne Ereignisbehandlungen"

    ''' <summary>
    ''' Wird aufgerufen wenn ein Menüeintrag geklickt wurde.
    ''' </summary>
    ''' <param name="sender">
    ''' Name des Menüeintrags der geklickt wurde.
    ''' </param>
    ''' <param name="e">
    ''' übergibt die Ereignisdaten.
    ''' </param>
    Private Sub ToolStripMenuItem_Oeffnen_Click(sender As Object, e As EventArgs) Handles _
        ToolStripMenuItem_Oeffnen.Click,
        ToolStripMenuItem_Speichern.Click,
        ToolStripMenuItem_SpeichernUnter.Click,
        ToolStripMenuItem_Beenden.Click

        ' welcher Menüeintrag wurde geklickt?
        If sender Is Me.ToolStripMenuItem_Oeffnen Then
            ' Datei öffnen
            Me.FileOpen()

        ElseIf sender Is Me.ToolStripMenuItem_Speichern Then
            ' Datei speichern
            Me.FileSave()

        ElseIf sender Is Me.ToolStripMenuItem_SpeichernUnter Then
            ' Datei unter anderem Namen speichern
            Me.FileSaveAs()

        ElseIf sender Is Me.ToolStripMenuItem_Beenden Then
            ' Programm beenden
            Me.Close()

        End If

    End Sub

#End Region

#Region "interne Methoden"

    Private Sub FileSaveAs()

        Dim result As DialogResult = Me.SaveFileDialog.ShowDialog(Me)
        If result = DialogResult.OK Then

            ' Dateiname abrufen
            Me.filename = Me.SaveFileDialog.FileName

#If DEBUG Then
            Debug.Print($"FileSaveAs: Datei speichern unter: {Me.filename}")
#End If

            ' Datei speichern
            Me.IniFile.SaveFile(Me.filename)

        End If

    End Sub

    Private Sub FileSave()

        ' Dateiname abrufen wenn noch nicht gesetzt
        If Me.filename Is Nothing Then
            Me.FileSaveAs()
        End If

#If DEBUG Then
        Debug.Print($"FileSave: Datei speichern unter: {Me.filename}")
#End If

        ' Datei speichern
        Me.IniFile.SaveFile(Me.filename)

    End Sub

    Private Sub FileOpen()

        Dim result As DialogResult = Me.OpenFileDialog.ShowDialog(Me)
        If result = DialogResult.OK Then

            ' Dateiname abrufen
            Me.filename = Me.OpenFileDialog.FileName

#If DEBUG Then
            Debug.Print($"FileOpen: Datei öffnen: {Me.filename}")
#End If

            ' Datei öffnen
            Me.IniFile.LoadFile(Me.filename)

        End If

    End Sub

#End Region

#Region "Ereignisse von IniFile"

    ''' <summary>
    ''' Wird ausgelöst wenn sich der Dateiinhalt geändert hat.
    ''' </summary>
    Private Sub IniFile_FileContentChanged(sender As Object, e As EventArgs) Handles _
        IniFile.FileContentChanged

#If DEBUG Then
        Debug.Print($"IniFile_FileContentChanged: Dateiinhalt geändert")
#End If

        ' Dateiinhalt anzeigen
        Me.ContentView.Lines = Me.IniFile.GetFileContent
        ' Dateikommentar anzeigen
        Me.FileCommentEdit.Comment = Me.IniFile.GetFileComment
        ' Abschnittsliste anzeigen
        Me.SectionsListEdit.ListItems = Me.IniFile.GetSectionNames

    End Sub


    Private Sub IniFile_SectionsChanged(sender As Object, e As EventArgs) Handles _
        IniFile.SectionsChanged

#If DEBUG Then
        Debug.Print($"IniFile_SectionsChanged: Abschnittsliste geändert")
#End If

    End Sub


    Private Sub IniFile_SectionCommentChanged(sender As Object, e As EventArgs) Handles _
        IniFile.SectionCommentChanged

#If DEBUG Then
        Debug.Print($"IniFile_SectionCommentChanged: Abschnittskommentar geänder")
#End If

    End Sub


    Private Sub IniFile_EntrysChanged(sender As Object, e As EventArgs) Handles _
        IniFile.EntrysChanged

#If DEBUG Then
        Debug.Print($"IniFile_EntrysChanged: Eintragsliste geändert")
#End If

    End Sub


    Private Sub IniFile_EntryValueChanged(sender As Object, e As EventArgs) Handles _
        IniFile.EntryValueChanged

#If DEBUG Then
        Debug.Print($"IniFile_EntryValueChanged: Eintragswert geändert")
#End If

    End Sub


    Private Sub IniFile_SectionNameExist(sender As Object, e As EventArgs) Handles _
        IniFile.SectionNameExist

#If DEBUG Then
        Debug.Print($"IniFile_SectionNameExist: Abschnitt existiert")
#End If

    End Sub


    Private Sub IniFile_EntrynameExist(sender As Object, e As EventArgs) Handles _
        IniFile.EntrynameExist

#If DEBUG Then
        Debug.Print($"IniFile_EntrynameExist: Eintrag existiert")
#End If

    End Sub

#End Region

#Region "Ereignisse von FileCommentEdit"

    ''' <summary>
    ''' Wird aufgerufen wenn sich der Dateikommentar geändert hat.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FileCommentEdit_CommentChanged(sender As Object, e As EventArgs) Handles _
        FileCommentEdit.CommentChanged

#If DEBUG Then
        Debug.Print($"FileCommentEdit_CommentChanged: Dateikommentar hat sich geändert")
#End If

        ' Dateikommentar speichern
        Me.IniFile.SetFileComment(Me.FileCommentEdit.Comment)

    End Sub

#End Region

#Region "Ereignisse von SectionsListEdit"

    Private Sub SectionsListEdit_ItemAdd(sender As Object, e As IniFileListEditEventArgs) Handles _
        SectionsListEdit.ItemAdd

#If DEBUG Then
        Debug.Print($"SectionsListEdit_ItemAdd: Der Eintrag {e.NewItemName} soll hinzugefügt werden.")
#End If

    End Sub

    Private Sub SectionsListEdit_ItemRemove(sender As Object, e As IniFileListEditEventArgs) Handles _
        SectionsListEdit.ItemRemove

#If DEBUG Then
        Debug.Print($"SectionsListEdit_ItemRemove: Der Eintrag {e.SelectedItem} soll gelöscht werden")
#End If

    End Sub

    Private Sub SectionsListEdit_ItemRename(sender As Object, e As IniFileListEditEventArgs) Handles _
        SectionsListEdit.ItemRename

#If DEBUG Then
        Debug.Print($"SectionsListEdit_ItemRename: Der Eintrag {e.SelectedItem} soll in {e.NewItemName} umbenannt werden")
#End If

        Me.IniFile.RenameSection(e.SelectedItem, e.NewItemName)




    End Sub

    Private Sub SectionsListEdit_SelectedItemChanged(sender As Object, e As IniFileListEditEventArgs) Handles _
        SectionsListEdit.SelectedItemChanged

#If DEBUG Then
        Debug.Print($"SectionsListEdit_SelectedItemChanged: Die Auswahl hat sich auf {e.SelectedItem} geändert")
#End If

    End Sub

#End Region

End Class