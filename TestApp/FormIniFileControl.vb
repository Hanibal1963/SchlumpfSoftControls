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
    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _
        ToolStripMenuItem_Neu.Click,
        ToolStripMenuItem_Oeffnen.Click,
        ToolStripMenuItem_Speichern.Click,
        ToolStripMenuItem_SpeichernUnter.Click,
        ToolStripMenuItem_Options.Click,
        ToolStripMenuItem_Beenden.Click

        ' welcher Menüeintrag wurde geklickt?
        If sender Is Me.ToolStripMenuItem_Neu Then
            ' neue Datei erstellen
            Me.CreateNewFile()

        ElseIf sender Is Me.ToolStripMenuItem_Oeffnen Then
            ' Datei öffnen
            Me.FileOpen()

        ElseIf sender Is Me.ToolStripMenuItem_Speichern Then
            ' Datei speichern
            Me.FileSave()

        ElseIf sender Is Me.ToolStripMenuItem_SpeichernUnter Then
            ' Datei unter anderem Namen speichern
            Me.FileSaveAs()

        ElseIf sender Is Me.ToolStripMenuItem_Options Then
            ' Dialog für Optionen anzeigen
            Me.ShowOptionsDialog()

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
            ' Datei speichern
            Me.IniFile.SaveFile(Me.filename)

        End If

    End Sub

    Private Sub FileSave()

        ' Dateiname abrufen wenn noch nicht gesetzt
        If Me.filename Is Nothing Then
            Me.FileSaveAs()
        End If
        ' Datei speichern
        Me.IniFile.SaveFile(Me.filename)

    End Sub

    Private Sub FileOpen()

        Dim result As DialogResult = Me.OpenFileDialog.ShowDialog(Me)
        If result = DialogResult.OK Then

            ' Dateiname abrufen
            Me.filename = Me.OpenFileDialog.FileName
            ' Datei öffnen
            Me.IniFile.LoadFile(Me.filename)

        End If

    End Sub

#End Region

#Region "Ereignisbehandlungen von IniFile"

    ''' <summary>
    ''' Wird ausgelöst wenn sich der Dateiinhalt geändert hat.
    ''' </summary>
    Private Sub IniFile_FileContentChanged(sender As Object, e As EventArgs) Handles _
        IniFile.FileContentChanged

        ' Dateiinhalt anzeigen
        Me.ContentView.Lines = Me.IniFile.GetFileContent
        ' Dateikommentar anzeigen
        Me.FileCommentEdit.SectionName = $""
        Me.FileCommentEdit.Comment = Me.IniFile.GetFileComment
        ' Abschnittsliste anzeigen
        Me.SectionsListEdit.ListItems = Me.IniFile.GetSectionNames

    End Sub

    Private Sub IniFile_SectionNameExist(sender As Object, e As EventArgs) Handles _
        IniFile.SectionNameExist

        Dim unused = MsgBox(
            My.Resources.ErrorMsgSectionNameExist,
            MsgBoxStyle.Critical And MsgBoxStyle.ApplicationModal,
            My.Resources.MsgBoxTitleError)

    End Sub

    Private Sub IniFile_EntrynameExist(sender As Object, e As EventArgs) Handles _
        IniFile.EntryNameExist

        Dim unused = MsgBox(
            My.Resources.ErrorMsgEntryNameExist,
            MsgBoxStyle.Critical And MsgBoxStyle.ApplicationModal,
            My.Resources.MsgBoxTitleError)
    End Sub
    Private Sub ShowOptionsDialog()



    End Sub

    Private Sub CreateNewFile()



    End Sub

#End Region

#Region "Ereignisbehandlungen von FileCommentEdit"

    ''' <summary>
    ''' Wird aufgerufen wenn sich der Dateikommentar geändert hat.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FileCommentEdit_CommentChanged(sender As Object, e As IniFileCommentEditEventArgs) Handles _
        FileCommentEdit.CommentChanged

        ' Dateikommentar speichern
        Me.IniFile.SetFileComment(e.Comment)

    End Sub

#End Region

#Region "Ereignisbehandlungen von SectionsListEdit"

    ''' <summary>
    ''' Wird aufgerufen wenn ein Abschnitt hinzugefügt werden soll.
    ''' </summary>
    Private Sub SectionsListEdit_ItemAdd(sender As Object, e As IniFileListEditEventArgs) Handles _
        SectionsListEdit.ItemAdd

        ' Abschnitt hinzufügen
        Me.IniFile.AddSection(e.NewItemName)

    End Sub

    ''' <summary>
    ''' Wird aufgerufen wenn ein Abschnitt gelöscht werden soll.
    ''' </summary>
    Private Sub SectionsListEdit_ItemRemove(sender As Object, e As IniFileListEditEventArgs) Handles _
        SectionsListEdit.ItemRemove

        ' Abschnitt löschen
        Me.IniFile.DeleteSection(e.SelectedItem)

    End Sub

    ''' <summary>
    ''' Wird aufgerufen wenn ein Abschnitt umbenannt werden soll.
    ''' </summary>
    Private Sub SectionsListEdit_ItemRename(sender As Object, e As IniFileListEditEventArgs) Handles _
        SectionsListEdit.ItemRename

        ' Abschnitt umbenennen
        Me.IniFile.RenameSection(e.SelectedItem, e.NewItemName)

    End Sub

    ''' <summary>
    ''' wird aufgerufen wenn sich der gewählte Abschnitt geändert hat.
    ''' </summary>
    Private Sub SectionsListEdit_SelectedItemChanged(sender As Object, e As IniFileListEditEventArgs) Handles _
        SectionsListEdit.SelectedItemChanged

        ' Wenn Null oder nur Leerzeichen ->
        ' Werte der abhängigen Controls löschen ansonsten neue Werte laden
        If String.IsNullOrEmpty(e.SelectedItem) Then
            ' Werte für SectionCommentEdit löschen
            Me.SectionCommentEdit.SectionName = $""
            Me.SectionCommentEdit.Comment = {$""}
            ' Werte für EntryListEdit löschen
            Me.EntryListEdit.ListItems = {$""}

        Else
            ' Werte für den Abschnitt in SectionCommentEdit laden
            Me.SectionCommentEdit.SectionName = e.SelectedItem
            Me.SectionCommentEdit.Comment = Me.IniFile.GetSectionComment(e.SelectedItem)
            ' Werte für den Abschnitt in EntryListEdit laden
            Me.EntryListEdit.ListItems = Me.IniFile.GetEntryNames(e.SelectedItem)
            Me.EntryListEdit.SelectedSection = e.SelectedItem

        End If

    End Sub

#End Region

#Region "Ereignisbehandlungen von SectionCommentEdit"

    Private Sub SectionCommentEdit_CommentChanged(sender As Object, e As IniFileCommentEditEventArgs) Handles _
        SectionCommentEdit.CommentChanged

        Me.IniFile.SetSectionComment(e.Section, e.Comment)

    End Sub

#End Region

#Region "Ereignisbehandlungen für EntryListEdit"

    Private Sub EntryListEdit_ItemAdd(sender As Object, e As IniFileListEditEventArgs) Handles _
        EntryListEdit.ItemAdd

        Me.IniFile.AddEntry(e.SelectedSection, e.NewItemName)

    End Sub

    Private Sub EntryListEdit_ItemRemove(sender As Object, e As IniFileListEditEventArgs) Handles _
        EntryListEdit.ItemRemove

        Me.IniFile.DeleteEntry(e.SelectedSection, e.SelectedItem)

    End Sub

    Private Sub EntryListEdit_ItemRename(sender As Object, e As IniFileListEditEventArgs) Handles _
        EntryListEdit.ItemRename

        Me.IniFile.RenameEntry(e.SelectedSection, e.SelectedItem, e.NewItemName)

    End Sub

    Private Sub EntryListEdit_SelectedItemChanged(sender As Object, e As IniFileListEditEventArgs) Handles _
        EntryListEdit.SelectedItemChanged

        With Me.EntryValueEdit
            .SelectedSection = e.SelectedSection
            .SelectedEntry = e.SelectedItem
            .Value = Me.IniFile.GetEntryValue(e.SelectedSection, e.SelectedItem)
        End With

    End Sub

#End Region

#Region "Ereignisbehandlungen von EntryValueEdit"

    Private Sub EntryValueEdit_ValueChanged(sender As Object, e As IniFileEntryValueEditEventArgs) Handles _
        EntryValueEdit.ValueChanged

        Me.IniFile.SetEntryValue(e.SelectedSection, e.SelectedEntry, e.NewValue)

    End Sub

#End Region

End Class