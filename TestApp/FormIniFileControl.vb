' ****************************************************************************************************************
' FormIniFileControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Public Class FormIniFileControl

    Private Sub FileCommentEdit_CommentChanged(
                sender As Object,
                e As EventArgs)

        'Kommentar holen
        Dim comment() As String = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit).Comment

        'geänderten Dateikommentar übenehmen
        Me.IniFile1.SetFileComment(comment)

    End Sub


    Private Sub SectionCommentEdit_CommentChanged(
                sender As Object, e As EventArgs)

        'Wenn kein Abschnitt ausgewählt -> Ende
        If Me.SectionsListEdit.SelectedItem = $"" Then Exit Sub

        'Kommentar holen
        Dim comment() As String = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit).Comment

        'geänderten Abschnittskommentar übernehmen
        Me.IniFile1.SetSectionComment(
            Me.SectionsListEdit.SelectedItem,
            comment)

    End Sub


    Private Sub EntryValueEdit_ValueChanged(
                sender As Object,
                e As EventArgs)

        'Abschnittsname holen
        Dim sectionname As String = Me.SectionsListEdit.SelectedItem

        'Eintragsname holen
        Dim entryname As String = Me.EntrysListEdit.SelectedItem

        'Eintragswert holen
        Dim entryvalue As String = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFileEntryValueEdit).Value

        If sectionname = $"" Or entryname = $"" Then 'wenn Kein Abschnitt oder Eintrag ausgewählt ist ->

            'Abbruch
            Exit Sub

        Else 'ansonsten ->

            'Eintrag ändern
            Me.IniFile1.SetEntryValue(
                sectionname,
                entryname,
                entryvalue)

        End If

    End Sub


    Private Sub SectionsListEdit_ItemAdd(
                sender As Object,
                e As EventArgs) 

        'neuen Abschnittsname abfragen
        Dim newsection As String = InputBox(
        $"Geben Sie den neuen Abschnittsname ein",
        $"Abschnitt hinzufügen",
        $"neuer Abschnitt")

        'Abschnitt hinzufügen
        Me.IniFile1.AddSection(newsection)

    End Sub


    Private Sub SectionsListEdit_ItemRename(
                sender As Object,
                e As EventArgs) 

        'Abschnittsname holen
        Dim sectionname As String = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFileListEdit).SelectedItem

        If String.IsNullOrEmpty(sectionname) Then 'wenn kein Abschnitt ausgewählt ->

            Exit Sub 'Abbruch

        Else 'ansonsten ->


            'neuen Name abfragen
            Dim newsection As String = InputBox(
          $"Geben Sie den neuen Abschnittsname für ""{sectionname}"" ein.",
          $"Abschnitt umbenennen",
          $"neuer Abschnitt")

            'Eingabe testen
            If String.IsNullOrEmpty(newsection) Then 'wenn abgebrochen ->

                Exit Sub 'Abbruch

            End If

            'Abschnitt umbenennen
            Me.IniFile1.RenameSection(
                sectionname,
                newsection)

        End If

    End Sub


    Private Sub SectionsListEdit_ItemRemove(
                sender As Object,
                e As EventArgs) 

        'Abschnittsname holen
        Dim sectionname As String = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFileListEdit).SelectedItem

        'Abfage anzeigen und Ergebnis holen
        Dim result As DialogResult = MessageBox.Show(
        Me,
        $"Wollen Sie den Abschnitt ""{sectionname}"" wirklich löschen",
        $"Abschnitt löschen",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        'Abschnitt löschen wenn Abfrage Ja
        If result = DialogResult.Yes Then Me.IniFile1.DeleteSection(sectionname)

    End Sub


    Private Sub SectionsListEdit_SelectedItemChanged(
                sender As Object,
                e As EventArgs) 

        'Abschnittsname holen
        Dim sectionname As String = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFileListEdit).SelectedItem

        If sectionname = $"" Then 'wenn keinAbschnitt ausgewählt ->

            'Kommentar leeren
            Me.SectionsCommentEdit.Comment = Nothing

            'Eintragsliste leeren
            Me.EntrysListEdit.Items = Nothing

            'Eintragswert löschen
            Me.EntryValueEdit.Value = $""

        Else 'ansonsten ->

            'Kommentar anzeigen
            Me.SectionsCommentEdit.Comment = Me.IniFile1.GetSectionComment(sectionname)

            'Eintragsliste füllen
            Me.EntrysListEdit.Items = Me.IniFile1.GetEntryNames(sectionname)

        End If

    End Sub


    Private Sub EntrysListEdit_ItemAdd(
                sender As Object,
                e As EventArgs) 

        'Abschnittsname holen
        Dim sectionname As String = Me.SectionsListEdit.SelectedItem

        If sectionname = $"" Then 'wenn keinAbschnitt ausgewählt ->

            'Abbruch
            Exit Sub

        Else 'ansonsten ->

            'neuen Namen abfragen
            Dim newentry As String = InputBox(
          $"Geben Sie den neuen Eintragsname ein",
          $"Eintrag hinzufügen",
          $"neuer Eintrag")

            'Eintrag hinzufügen
            Me.IniFile1.AddEntry(
                sectionname,
                newentry)

        End If

    End Sub


    Private Sub EntrysListEdit_ItemRename(
                sender As Object,
                e As EventArgs) 

        'Abschnittsname holen
        Dim sectionname As String = Me.SectionsListEdit.SelectedItem

        'Eintragsname holen
        Dim entryname As String = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFileListEdit).SelectedItem

        'neuen Eintragsname abfragen
        Dim newentry As String = InputBox(
        $"Geben Sie den neuen Eintragsname für ""{entryname}"" ein.",
        $"Eintrag umbenennen",
        $"neuer Eintrag")

        'Eingabe testen
        If String.IsNullOrEmpty(newentry) Then 'wenn abgebrochen ->

            Exit Sub 'Abbruch

        End If

        'Eintrag umbenennen
        Me.IniFile1.RenameEntry(
            sectionname,
            entryname,
            newentry)

    End Sub


    Private Sub EntrysListEdit_ItemRemove(
                sender As Object,
                e As EventArgs) 

        'Abschnittsname holen
        Dim sectionname As String = Me.SectionsListEdit.SelectedItem

        'Eintragsname holen
        Dim entryname As String = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFileListEdit).SelectedItem

        'Abfage anzeigen und Ergebnis holen
        Dim result As DialogResult = MessageBox.Show(
        Me,
        $"Wollen Sie den Eintrag ""{entryname}"" aus dem Abschnitt ""{sectionname}"" wirklich löschen",
        $"Eintrag löschen",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        'Eintrag löschen wenn Abfrage Ja
        If result = DialogResult.Yes Then Me.IniFile1.DeleteEntry(
            sectionname,
            entryname)

    End Sub


    Private Sub EntrysListEdit_SelectedItemChanged(
                sender As Object,
                e As EventArgs) 

        'Abschnittsname holen
        Dim sectionname As String = Me.SectionsListEdit.SelectedItem

        'Eintragsname holen
        Dim entryname As String = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFileListEdit).SelectedItem

        If entryname = $"" Then 'wenn kein Eintrag ausgewählt ->

            'Eintragswert löschen
            Me.EntryValueEdit.Value = $""

        Else 'ansonsten ->

            'Eintragswert setzen
            Me.EntryValueEdit.Value = Me.IniFile1.GetEntryValue(
                sectionname,
                entryname)

        End If

    End Sub


    Private Sub IniFile1_FileContentChanged(
                sender As Object,
                e As EventArgs) 

        'Dateiinhalt anzeigen
        Me.IniFileContentView.Lines = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFile).GetFileContent()

        'Dateikommentar laden
        Me.FileCommentEdit.Comment = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFile).GetFileComment()

        'Abschnittsliste laden
        Me.SectionsListEdit.Items = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFile).GetSectionNames()

    End Sub


    Private Sub IniFile1_FileCommentChanged(
                sender As Object,
                e As EventArgs) 

        'geänderten Dateikommentar übenehmen
        Me.FileCommentEdit.Comment = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFile).GetFileComment

    End Sub


    Private Sub IniFile1_SectionsChanged(
            sender As Object,
            e As EventArgs) 

        'Abschnittsliste neu füllen
        Me.SectionsListEdit.Items = CType(
                sender,
                SchlumpfSoft.Controls.IniFileControl.IniFile).GetSectionNames

    End Sub


    Private Sub IniFile1_SectionNameExist(
                sender As Object,
                e As EventArgs) 

        Dim unused = MessageBox.Show(
        Me,
        $"Der Abschnitt existiert bereits.",
        $"Ein Fehler ist aufgetreten",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error)

    End Sub


    Private Sub IniFile1_SectionCommentChanged(
                sender As Object,
                e As EventArgs) 

        'Abschnittsname holen
        Dim sectionname As String = Me.SectionsListEdit.SelectedItem

        'geänderten Abschnittskommentar übernehmen
        Me.SectionsCommentEdit.Comment = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFile).GetSectionComment(sectionname)

    End Sub


    Private Sub IniFile1_EntrynameExist(
                sender As Object,
                e As EventArgs) 

        Dim unused = MessageBox.Show(
        Me,
        $"Der Eintrag existiert bereits.",
        $"Ein Fehler ist aufgetreten",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error)

    End Sub


    Private Sub IniFile1_EntrysChanged(
                sender As Object,
                e As EventArgs) 

        'Eintragsliste neu befüllen
        Me.EntrysListEdit.Items = CType(
            sender,
            SchlumpfSoft.Controls.IniFileControl.IniFile).GetEntryNames(
            Me.SectionsListEdit.SelectedItem)

    End Sub


    Private Sub ToolStripMenuItem_Oeffnen_Click(
                sender As Object,
                e As EventArgs) Handles _
                ToolStripMenuItem_Oeffnen.Click

        'Datei öffnen
        Dim ofd As New OpenFileDialog With {
        .Title = $"INI - Datei öffnen",
        .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
        .Filter = $"INI-Dateien (*.ini)|*.ini",
        .AddExtension = True,
        .CheckFileExists = True,
        .Multiselect = False,
        .ShowHelp = False}

        Dim result As DialogResult = ofd.ShowDialog(Me)
        If Not result = DialogResult.OK Then Exit Sub
        Me.IniFile1.LoadFile(ofd.FileName)

    End Sub


    Private Sub ToolStripMenuItem_Speichern_Click(
                sender As Object,
                e As EventArgs) Handles _
                ToolStripMenuItem_Speichern.Click

        'Datei speichern
        Me.IniFile1.SaveFile()

    End Sub


    Private Sub ToolStripMenuItem_SpeichernUnter_Click(
                sender As Object,
                e As EventArgs) Handles _
                ToolStripMenuItem_SpeichernUnter.Click

        'Datei speichern unter ...
        Dim sfd As New SaveFileDialog With {
        .Title = $"INI - Datei speichern unter",
        .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
        .Filter = $"INI-Dateien (*.ini)|*.ini",
        .AddExtension = True,
        .CheckFileExists = False,
        .ShowHelp = False}

        Dim result As DialogResult = sfd.ShowDialog(Me)
        If Not result = DialogResult.OK Then Exit Sub
        Me.IniFile1.SaveFile(sfd.FileName)

    End Sub


    Private Sub ToolStripMenuItem_Beenden_Click(
                sender As Object,
                e As EventArgs) Handles _
                ToolStripMenuItem_Beenden.Click

        'Programm beenden
        Me.Close()

    End Sub


End Class