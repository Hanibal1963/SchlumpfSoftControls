' ****************************************************************************************************************
' IniFile.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing


''' <summary>
''' Steuerelement zum Verwalten von INI - Dateien
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<MyDescription("ClassDescriptionIniFile")>
<ToolboxBitmap(GetType(IniFile), "IniFile.bmp")>
<ToolboxItem(True)>
Public Class IniFile


    Inherits Component


#Region "Definition der Variablen"

    Private _FilePath As String
    Private _CommentPrefix As Char
    Private _FileContent() As String
    Private _AutoSave As Boolean
    Private _FileComment As List(Of String)
    Private _Sections As Dictionary(Of String, Dictionary(Of String, String))
    Private _SectionsComments As Dictionary(Of String, List(Of String))
    Private _CurrentSectionName As String

#End Region


#Region "Definition der Ereignisse"


    ''' <summary>
    ''' Wird ausgelöst wenn sich der Dateiinhalt geändert hat.
    ''' </summary>
    <MyDescription("FileContentChangedDescription")>
    Public Event FileContentChanged(sender As Object, e As EventArgs)


    ''' <summary>
    ''' Wird ausgelöst wenn sich der Dateikommentar geändert hat.
    ''' </summary>
    <MyDescription("FileCommentChangedDescription")>
    Public Event FileCommentChanged(sender As Object, e As EventArgs)


    ''' <summary>
    ''' Wird ausgelöst wenn sich die Liste der Abschnitte geändert hat.
    ''' </summary>
    <MyDescription("SectionsChangedDescription")>
    Public Event SectionsChanged(sender As Object, e As EventArgs)


    ''' <summary>
    ''' Wird ausgelöst wenn beim anlegen eines neuen Abschnitts oder 
    ''' umbnennen eines Abschnitts der Name bereits vorhanden ist.
    ''' </summary>
    <MyDescription("SectionNameExistDescription")>
    Public Event SectionNameExist(sender As Object, e As EventArgs)


    ''' <summary>
    ''' Wird ausgelöst wenn sich der Abschnittskommentar geändert hat.
    ''' </summary>
    <MyDescription("SectionCommentChangedDescription")>
    Public Event SectionCommentChanged(sender As Object, e As EventArgs)


    ''' <summary>
    ''' Wird ausgelöst wenn beim anlegen eines neuen Eintrags oder 
    ''' umbenennen eines Eintrags der Name bereitsvorhanden ist.
    ''' </summary>
    <MyDescription("EntrynameExistDescription")>
    Public Event EntrynameExist(sender As Object, e As EventArgs)


    ''' <summary>
    ''' wird ausgelöst wenn sich die Liste der Einträge geändert hat.
    ''' </summary>
    <MyDescription("EntrysChangedDescription")>
    Public Event EntrysChanged(sender As Object, e As EventArgs)


    ''' <summary>
    ''' Wird ausgelöst wenn sich der Wert eines Eintrags in einem Abschnitt geändert hat.
    ''' </summary>
    <MyDescription("EntryValueChangedDescription")>
    Public Event EntryValueChanged(sender As Object, e As EventArgs)


#End Region


#Region "Definition neuer Eigenschaften"


    ''' <summary>
    ''' Gibt das Prefixzeichen für Kommentare zurück oder legt dieses fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Design")>
    <MyDescription("CommentPrefixDescription")>
    Public Property CommentPrefix As Char
        Get
            Return Me._CommentPrefix
        End Get
        Set
            Me._CommentPrefix = Value
        End Set
    End Property


    ''' <summary>
    ''' Gibt den Pfad und den Name zur INI-Datei zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Design")>
    <MyDescription("FilePathDescription")>
    Public Property FilePath As String
        Get
            Return Me._FilePath
        End Get
        Set
            Me._FilePath = Value
        End Set
    End Property


    ''' <summary>
    ''' Legt das Speicherverhalten der Klasse fest.
    ''' </summary>
    ''' <remarks>
    ''' True legt fest das Änderungen automatisch gespeichert werden.
    ''' </remarks>
    <Browsable(True)>
    <Category("Design")>
    <MyDescription("AutoSaveDescription")>
    Public Property AutoSave As Boolean
        Get
            Return Me._AutoSave
        End Get
        Set
            Me._AutoSave = Value
        End Set
    End Property


#End Region


#Region "Definition der öffentlichen Funktionen"


    ''' <summary>
    ''' Erstellt eine neue Instanz dieser Klasse.
    ''' </summary>
    Public Sub New()

        'anfänglichen Speicherort und Name der Datei sowie Standardprefix für Kommentare festlegen
        Me.New(My.Computer.FileSystem.SpecialDirectories.MyDocuments &
                IO.Path.DirectorySeparatorChar &
                My.Resources.DefaultFileName, CChar(My.Resources.DefaultCommentPrefix))

    End Sub


    ''' <summary>
    ''' Erstellt eine neue Instanz dieser Klasse unter Angabe der Datei.
    ''' </summary>
    ''' <param name="FilePath">
    ''' Pfad und Name zur INI-Datei.
    ''' </param>
    ''' <param name="CommentPrefix">
    ''' Prefixzeichen für Kommentare.
    ''' </param>
    ''' <remarks>
    ''' Wenn kein Prefixzeichen angegeben wird, wird Standardmäßig das Semikolon verwendet.
    ''' </remarks>
    Public Sub New(FilePath As String, CommentPrefix As Char)

        MyBase.New
        Me.CreateStandardValues(FilePath, CommentPrefix) 'Standardwerte festlegen
        Me.CreateTemplate() 'anfänglichen Dateiinhalt erzeugen
        If Me._AutoSave Then Me.SaveFile() 'eventuell speichern
        Me.ParseFileContent() 'Dateiinhalt analysieren

    End Sub


    ''' <summary>
    ''' Lädt die angegebene Datei
    ''' </summary>
    ''' <param name="FilePath">
    ''' Name und Pfad der Datei die geladen werden soll.
    ''' </param>
    Public Sub LoadFile(FilePath As String)

        'Parameter überprüfen
        If String.IsNullOrWhiteSpace(FilePath) Then
            Throw New ArgumentException(
                String.Format(
                My.Resources.ErrorMsgNullOrWhitSpace,
                NameOf(FilePath)))
        End If

        'Pfad und Name der Datei merken
        Me._FilePath = FilePath
        Me.LoadFile()

    End Sub


    ''' <summary>
    ''' Lädt die Datei die in <see cref="FilePath"/> angegeben wurde.
    ''' </summary>
    Public Sub LoadFile()

        'Dateiinhalt von Datenträger lesen und analysieren
        Me._FileContent = IO.File.ReadAllLines(Me._FilePath)
        Me.ParseFileContent()
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Speichert die angegebene Datei.
    ''' </summary>
    ''' <param name="FilePath">
    ''' Name und Pfad der Datei die gespeichert werden soll.
    ''' </param>
    Public Sub SaveFile(FilePath As String)

        'Parameter überprüfen
        If String.IsNullOrWhiteSpace(FilePath) Then
            Throw New ArgumentException(
                String.Format(
                My.Resources.ErrorMsgNullOrWhitSpace,
                NameOf(FilePath)))
        End If

        'Pfad und Name der Datei merken
        Me._FilePath = FilePath
        Me.SaveFile()

    End Sub


    ''' <summary>
    ''' Speichert die in <see cref="FilePath"/> angegebene Datei.
    ''' </summary>
    Public Sub SaveFile()

        'Dateiinhalt auf Datenträger schreiben
        IO.File.WriteAllLines(Me._FilePath, Me._FileContent)

    End Sub


    ''' <summary>
    ''' Gibt den Dateiinhalt zurück
    ''' </summary>
    Public Function GetFileContent() As String()
        Return Me._FileContent
    End Function


    ''' <summary>
    ''' Gibt den Dateikommentar zurück
    ''' </summary>
    Public Function GetFileComment() As String()
        Return Me._FileComment.ToArray
    End Function


    ''' <summary>
    ''' Setzt den Dateikommentar.
    ''' </summary>
    ''' <param name="CommentLines">
    ''' Die Zeilen des Dateikommentars.
    ''' </param>
    Public Sub SetFileComment(CommentLines() As String)

        'alten Dateikommentar löschen
        Me._FileComment.Clear()

        'neuen Dateikommentar übenehmen
        Me._FileComment.AddRange(CommentLines)

        'Dateiinhalt neu erzeugen 
        Me.CreateFileContent()

        'Änderungen eventuell speichern
        If Me._AutoSave Then Me.SaveFile()

        'Ereignisse auslösen
        RaiseEvent FileCommentChanged(Me, EventArgs.Empty)
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Ruft die Abschnittsnamen ab.
    ''' </summary>
    Public Function GetSectionNames() As String()

        Dim names As New List(Of String)
        For Each name As String In Me._Sections.Keys
            names.Add(name)
        Next
        Return names.ToArray

    End Function


    ''' <summary>
    ''' Gibt die Namen der Einträge eines Abschnitts zurück
    ''' </summary>
    ''' <param name="SectionName">
    ''' Abschnittsname
    ''' </param>
    ''' <returns>
    ''' Eintragsliste oder Nothing falls <paramref name="SectionName"/> nicht existiert.
    ''' </returns>
    Public Function GetEntryNames(SectionName As String) As String()

        'Variable für Rückgabewert
        Dim result() As String = Nothing

        'wenn Abschnitt existiert -> Eintagsliste erstellen
        If Me._Sections.ContainsKey(SectionName) Then

            Dim names As New List(Of String)
            For Each name As String In Me._Sections.Item(SectionName).Keys
                names.Add(name)
            Next
            result = names.ToArray

        End If

        'Eintragsliste oder Nothing zurück
        Return result

    End Function


    ''' <summary>
    ''' Fügt einen neuen Abschnitt hinzu.
    ''' </summary>
    ''' <param name="Name">
    ''' Name des neuen Abschnitts
    ''' </param>
    Public Sub AddSection(Name As String)

        'Prüfen ob der Name vorhanden ist
        If Me._Sections.ContainsKey(Name) Then

            'Ereignis auslösen und beenden
            RaiseEvent SectionNameExist(Me, EventArgs.Empty)
            Exit Sub

        End If

        'neuen Abschnitt erstellen
        Me.AddNewSection(Name)

        'Dateiinhalt neu erzeugen 
        Me.CreateFileContent()

        'Änderungen eventuell speichern
        If Me._AutoSave Then Me.SaveFile()

        'Ereignisse auslösen
        RaiseEvent SectionsChanged(Me, EventArgs.Empty)
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Fügt einen neuen Eintrag in die Liste der Eintragsnamen ein.
    ''' </summary>
    ''' <param name="Section">
    ''' Abschnitt in den der Eintrag eingefügt werden soll.
    ''' </param>
    ''' <param name="Name">
    ''' Name des Eintrags.
    ''' </param>
    Public Sub AddEntry(Section As String, Name As String)

        'Prüfen ob der Name vorhanden ist
        If Me._Sections.Item(Section).ContainsKey(Name) Then

            'Ereignis auslösen und beenden
            RaiseEvent EntrynameExist(Me, EventArgs.Empty)
            Exit Sub

        End If

        'neuen Eintrag erstellen
        Me.AddNewEntry(Section, Name)

        'Dateiinhalt neu erzeugen 
        Me.CreateFileContent()

        'Änderungen eventuell speichern
        If Me._AutoSave Then Me.SaveFile()

        'Ereignisse auslösen
        RaiseEvent EntrysChanged(Me, EventArgs.Empty)
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Benennt einen Abschnitt um.
    ''' </summary>
    ''' <param name="OldName">
    ''' alter Name des Abschnitts
    ''' </param>
    ''' <param name="NewName">
    ''' neuer name des Abschnitts
    ''' </param>
    Public Sub RenameSection(OldName As String, NewName As String)

        'Ist der neue Name bereits vorhanden?
        If Me._Sections.ContainsKey(NewName) Then

            'Ereignis auslösen und beenden
            RaiseEvent SectionNameExist(Me, EventArgs.Empty)
            Exit Sub

        End If

        'Name-Wert-Paar des Abschnitts umbenennen
        Me.RenameSectionValue(OldName, NewName)

        'Name-Kommentar-Paar umbenennen
        Me.RenameSectionComment(OldName, NewName)

        'Dateiinhalt neu erzeugen 
        Me.CreateFileContent()

        'Änderungen eventuell speichern
        If Me._AutoSave Then Me.SaveFile()

        'Ereignisse auslösen
        RaiseEvent SectionsChanged(Me, EventArgs.Empty)
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Benennt einen Eintrag in einem Abschnitt um.
    ''' </summary>
    ''' <param name="Section">
    ''' Abschnitt der den Eintrag enthält.
    ''' </param>
    ''' <param name="NewName">
    ''' Neuer Name des Eintrags.
    ''' </param>
    Public Sub RenameEntry(Section As String, Oldname As String, NewName As String)

        'Ist der neue Name bereits vorhanden? 
        If Me._Sections.Item(Section).ContainsKey(NewName) Then

            'Ereignis auslösen und beenden
            RaiseEvent EntrynameExist(Me, EventArgs.Empty)
            Exit Sub

        End If

        'Name-Wert-Paar des Eintrags umbenennen
        Me.RenameEntryvalue(Section, Oldname, NewName)

        'Dateiinhalt neu erzeugen 
        Me.CreateFileContent()

        'Änderungen eventuell speichern
        If Me._AutoSave Then Me.SaveFile()

        'Ereignisse auslösen
        RaiseEvent EntrysChanged(Me, EventArgs.Empty)
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Löscht einen Abschnitt
    ''' </summary>
    ''' <param name="Name">
    ''' Name des Abschnittes
    ''' </param>
    Public Sub DeleteSection(Name As String)

        'Abschnitt aus den Listen für Abschnitte und Abschnittskommentare entfernen
        Dim unused = Me._Sections.Remove(Name)
        Dim unused1 = Me._SectionsComments.Remove(Name)

        'Dateiinhalt neu erzeugen 
        Me.CreateFileContent()

        'Änderungen eventuell speichern
        If Me._AutoSave Then Me.SaveFile()

        'Ereignisse auslösen
        RaiseEvent SectionsChanged(Me, EventArgs.Empty)
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Löscht einen Eintrag aus einem Abschnitt.
    ''' </summary>
    ''' <param name="Section">
    ''' Abschnitt aus dem der Eintrag gelöscht werden soll.
    ''' </param>
    ''' <param name="Entry">
    ''' Eintrag der gelöscht werden soll.
    ''' </param>
    Public Sub DeleteEntry(Section As String, Entry As String)

        'Eintrag aus der Liste der Einträge entfernen
        Dim unused = Me._Sections.Item(Section).Remove(Entry)

        'Dateiinhalt neu erzeugen 
        Me.CreateFileContent()

        'Änderungen eventuell speichern
        If Me._AutoSave Then Me.SaveFile()

        'Ereignisse auslösen
        RaiseEvent EntrysChanged(Me, EventArgs.Empty)
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Gibt die Kommentarzeilen für einen Abschnitt zurück
    ''' </summary>
    ''' <param name="SectionName">
    ''' Name des Abschnitts
    ''' </param>
    ''' <returns>
    ''' Kommentar für <paramref name="SectionName"/> oder Nothing wenn kein Kommentar existiert.
    ''' </returns>
    Public Function GetSectionComment(SectionName As String) As String()

        'Variable für Rückgabewert
        Dim result() As String = Nothing

        'wenn Abschnitt einen Kommentar enthält -> Kommentar holen 
        If Me._SectionsComments.ContainsKey(SectionName) Then
            result = Me._SectionsComments.Item(SectionName).ToArray
        End If

        'Kommentar oder Nothing zurück
        Return result

    End Function


    ''' <summary>
    ''' Gibt den Wert eines Eintrags aus einem Abschnitt zurück
    ''' </summary>
    ''' <param name="Section">
    ''' Abschnitt aus dem der Wert des Eintrags gelesen werden soll.
    ''' </param>
    ''' <param name="Entry">
    ''' Eintrag dessen Wert gelesen werden soll.
    ''' </param>
    ''' <returns>
    ''' Wert des Eintrags.
    ''' </returns>
    Public Function GetEntryValue(Section As String, Entry As String) As String
        Return Me._Sections.Item(Section).Item(Entry)
    End Function


    ''' <summary>
    ''' Setzt den Kommentar für einen Abschnitt.
    ''' </summary>
    ''' <param name="Name">
    ''' Name des Abschnitts.
    ''' </param>
    ''' <param name="CommentLines">
    ''' Kommentarzeilen
    ''' </param>
    Public Sub SetSectionComment(Name As String, CommentLines() As String)

        'geänderten Abschnittskommentar übernehmen
        Me._SectionsComments.Item(Name).Clear()
        Me._SectionsComments.Item(Name).AddRange(CommentLines)

        'Dateiinhalt neu erzeugen 
        Me.CreateFileContent()

        'eventuell Änderung speichern
        If Me._AutoSave Then Me.SaveFile()

        'ereignisse auslösen
        RaiseEvent SectionCommentChanged(Me, EventArgs.Empty)
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Setzt den Wert eines Eintrags in einem Abschnitt.
    ''' </summary>
    ''' <param name="Section">
    ''' Abschnitt in dem der Wert eines Eintrags geändert werden soll.
    ''' </param>
    ''' <param name="Entry">
    ''' Eintrag dessen Wert geändert werden soll.
    ''' </param>
    ''' <param name="Value">
    ''' Der geänderte Wert.
    ''' </param>
    Public Sub SetEntryValue(Section As String, Entry As String, Value As String)

        'geänderten Wert übenehmen
        Me._Sections.Item(Section).Item(Entry) = Value

        'Dateiinhalt neu erzeugen 
        Me.CreateFileContent()

        'eventuell Änderung speichern
        If Me._AutoSave Then Me.SaveFile()

        'Ereignisse auslösen
        RaiseEvent EntryValueChanged(Me, EventArgs.Empty)
        RaiseEvent FileContentChanged(Me, EventArgs.Empty)

    End Sub


#End Region


#Region "Definition der internen Funktionen"


    ''' <summary>
    ''' Fügt einen neuen Abschnitt hinzu.
    ''' </summary>
    ''' <param name="Name">
    ''' Name des neuen Abschnitts
    ''' </param>
    Private Sub AddNewSection(Name As String)

        'Name-Wert-Paar hinzufügen
        Me._Sections.Add(Name, New Dictionary(Of String, String))

        'Name-Kommentar-Paar hinzufügen
        Me._SectionsComments.Add(Name, New List(Of String))

    End Sub


    ''' <summary>
    ''' fügt einen neuen Eintrag in einen Abschnitt ein.
    ''' </summary>
    ''' <param name="Section">
    ''' Name des Abschnitts in den der neue Eintrag eingefügt werden soll.
    ''' </param>
    ''' <param name="Name">
    ''' Name des neuen Eintrags.
    ''' </param>
    Private Sub AddNewEntry(Section As String, Name As String)
        Me._Sections.Item(Section).Add(Name, $"")
    End Sub


    ''' <summary>
    ''' Benennt das Key-Comment-Paar eines Abschnitts um.
    ''' </summary>
    ''' <param name="oldName">
    ''' alter Name
    ''' </param>
    ''' <param name="newName">
    ''' neuer Name
    ''' </param>
    Private Sub RenameSectionComment(OldName As String, newName As String)

        'alten Kommentar speichern, Abschnitt entfernen und
        'neuen Abschnitt mit altem Kommentar erstellen
        Dim oldcomment = Me._SectionsComments.Item(OldName)
        Dim unused1 = Me._SectionsComments.Remove(OldName)
        Me._SectionsComments.Add(newName, oldcomment)

    End Sub


    ''' <summary>
    ''' Benennt das Key-Value-Paar eines Abschnitts um.
    ''' </summary>
    ''' <param name="OldName">
    ''' alter Name
    ''' </param>
    ''' <param name="NewName">
    ''' neuer Name
    ''' </param>
    Private Sub RenameSectionValue(OldName As String, NewName As String)

        'alten Wert speichern, Abschnitt entfernen und
        'neuen Abschnitt mit altem Wert erstellen
        Dim oldvalue = Me._Sections.Item(OldName)
        Dim unused = Me._Sections.Remove(OldName)
        Me._Sections.Add(NewName, oldvalue)

    End Sub


    ''' <summary>
    ''' Benennt einen Eintrag in einem Abschnitt um.
    ''' </summary>
    ''' <param name="Section">
    ''' Abschnitt in dem der Eintrag umbenannt werden soll.
    ''' </param>
    ''' <param name="OldName">
    ''' Alter Eintragsname.
    ''' </param>
    ''' <param name="NewName">
    ''' Neuer Eintragsname.
    ''' </param>
    Private Sub RenameEntryvalue(Section As String, OldName As String, NewName As String)

        'alten Wert speichern, Eintrag entfernen und
        'neuen Eintrag mit altem Wert erstellen
        Dim oldvalue = Me._Sections.Item(Section).Item(OldName)
        Dim unused = Me._Sections.Item(Section).Remove(OldName)
        Me._Sections.Item(Section).Add(NewName, oldvalue)

    End Sub


    ''' <summary>
    ''' Legt die anfänglichen Standardwerte fest
    ''' </summary>
    ''' <param name="FilePath">
    ''' Pfad und Name der Datei
    ''' </param>
    ''' <param name="CommentPrefix">
    ''' Prefixzeichen für Kommentare
    ''' </param>
    Private Sub CreateStandardValues(FilePath As String, CommentPrefix As Char)

        Me._FilePath = FilePath
        Me._CommentPrefix = CommentPrefix
        Me._AutoSave = False
        Me._FileComment = New List(Of String)

    End Sub


    ''' <summary>
    ''' Erzeugt den Dateiinhalt
    ''' </summary>
    Private Sub CreateFileContent()

        'Zeilenliste
        Dim filecontent As New List(Of String)

        'Dateikommentarzeilen anfügen
        For Each line As String In Me._FileComment
            filecontent.Add(Me._CommentPrefix & $" " & line)
        Next

        'Leerzeile anfügen
        filecontent.Add($"")

        'alle Abschnitte durchlaufen
        For Each sectionname As String In Me._Sections.Keys

            'Abschnittsname hinzufügen
            filecontent.Add($"[" & sectionname & $"]")

            'Zeilen des Abschnittskommentars durchlaufen
            For Each commentline As String In Me._SectionsComments.Item(sectionname)

                'Kommentarzeile einfügen
                filecontent.Add(Me._CommentPrefix & $" " & commentline)

            Next

            'alle Eintragszeilen durchlaufen
            Dim entryline As String
            For Each entryname As String In Me._Sections.Item(sectionname).Keys

                'Eintragszeile erzeugen und einfügen
                entryline = entryname & $" = " & Me._Sections.Item(sectionname).Item(entryname)
                filecontent.Add(entryline)

            Next

            'Leerzeile anfügen
            filecontent.Add($"")

        Next

        'Dateiinhalt erzeugen
        Me._FileContent = filecontent.ToArray

    End Sub


    ''' <summary>
    ''' Erzeugt den Beispielinhalt der Datei
    ''' </summary>
    Private Sub CreateTemplate()

        Me._FileContent = {
             Me._CommentPrefix & $" " & My.Resources.DefaultFileName,
             Me._CommentPrefix & $" erstellt von " & My.Application.Info.AssemblyName &
             $" V" & My.Application.Info.Version.ToString,
             Me._CommentPrefix & $" " & My.Application.Info.Copyright,
             $"",
             $"[Abschnitt 1]",
             Me._CommentPrefix & $"Beispielabschnitt",
             Me._CommentPrefix & $"Computername - Name des PC's",
             Me._CommentPrefix & $"Betriebssystem - welches Betriebssystem",
             Me._CommentPrefix & $"Version - Versionsnummer des Betriebssystems",
             $"Computername = " & My.Computer.Name,
             $"Betriebssystem = " & My.Computer.Info.OSFullName,
             $"Version = " & My.Computer.Info.OSVersion
        }

    End Sub


    ''' <summary>
    ''' analysiert den Dateiinhalt
    ''' </summary>
    Private Sub ParseFileContent()

        'Variablen initialisieren
        Me.InitParseVariables()

        'aktueller Abschnittsname
        Me._CurrentSectionName = $""

        'alle Zeilen des Dateiinhaltes durchlaufen
        For Each line As String In Me._FileContent

            'Leerzeichen am Anfang und Ende der Zeile entfernen
            line = line.Trim

            'aktuelle Zeile analysieren
            Me.LineAnalyse(line)
        Next

    End Sub


    ''' <summary>
    ''' Analysiert eine Zeile.
    ''' </summary>
    ''' <param name="LineContent">
    ''' Zeileninhalt
    ''' </param>
    Private Sub LineAnalyse(LineContent As String)

        If Me._CurrentSectionName Is $"" And LineContent.StartsWith(Me._CommentPrefix) Then

            'noch kein Abschnitt gefunden und Zeile startet mit Prefix
            Me.AddFileCommentLine(LineContent) 'Dateikommentar hinzufügen

        ElseIf LineContent.StartsWith($"[") And LineContent.EndsWith($"]") Then

            'Zeile enthält eckige Klammern
            Me.AddSectionNameLine(LineContent) 'Abschnittsname hinzufügen

        ElseIf Me._CurrentSectionName IsNot $"" And LineContent.StartsWith(Me._CommentPrefix) Then

            'aktueller Abschnitt und Zeile startet mit Prefix
            Me.AddSectionCommentLine(LineContent) 'Abschnittskommentar hinzufügen

        ElseIf Me._CurrentSectionName IsNot $"" And LineContent.Contains($"=") Then

            'aktueller Abschnitt und Zeile enthält Gleichheitszeichen
            Me.AddEntryLine(LineContent) 'Eintrag hinzufügen

        End If

    End Sub


    ''' <summary>
    ''' fügt einen Eintrag hinzu
    ''' </summary>
    ''' <param name="LineContent">
    ''' Zeileninhalt
    ''' </param>
    Private Sub AddEntryLine(LineContent As String)

        'Eintagszeile in Name und Wert trennen
        Dim name As String = LineContent.Split("="c)(0).Trim
        Dim value As String = LineContent.Split("="c)(1).Trim

        'Eintrag hinzufügen
        Me._Sections.Item(Me._CurrentSectionName).Add(name, value)

    End Sub


    ''' <summary>
    ''' fügt eine Abschnittskommentarzeile hinzu
    ''' </summary>
    ''' <param name="LineContent">
    ''' Zeileninhalt
    ''' </param>
    Private Sub AddSectionCommentLine(LineContent As String)

        'Prefix und eventuelle Leerzeichen am Anfang und Ende entfernen
        Dim line As String = LineContent.Substring(1, LineContent.Length - 1).Trim

        'Kommentarzeile hinzufügen
        Me._SectionsComments.Item(Me._CurrentSectionName).Add(line)

    End Sub


    ''' <summary>
    ''' fügt einen Abschnittsname hinzu
    ''' </summary>
    ''' <param name="LineContent">
    ''' Zeileninhalt
    ''' </param>
    Private Sub AddSectionNameLine(LineContent As String)

        'Klammern und eventuelle Leerzeichen am Anfang und Ende entfernen
        Dim line = LineContent.Substring(1, LineContent.Length - 2).Trim

        'Abschnittsname merken
        Me._CurrentSectionName = line

        'neuen Abschnitt erstellen
        Me._Sections.Add(Me._CurrentSectionName, New Dictionary(Of String, String))
        Me._SectionsComments.Add(Me._CurrentSectionName, New List(Of String))

    End Sub


    ''' <summary>
    ''' fügt eine Dateikommentarzeile hinzu
    ''' </summary>
    ''' <param name="LineContent">
    ''' Zeileninhalt
    ''' </param>
    Private Sub AddFileCommentLine(LineContent As String)

        'Prefix und eventuelle Leerzeichen am Anfang und Ende entfernen
        Dim line = LineContent.Substring(1, LineContent.Length - 1).Trim

        'Zeile in den Dateikommentar übernehmen
        Me._FileComment.Add(line)

    End Sub


    ''' <summary>
    ''' Initialisiert die Variablen für den Parser
    ''' </summary>
    Private Sub InitParseVariables()

        Me._FileComment = New List(Of String)
        Me._Sections = New Dictionary(Of String, Dictionary(Of String, String))
        Me._SectionsComments = New Dictionary(Of String, List(Of String))

    End Sub

    Private Sub InitializeComponent()

    End Sub


#End Region


End Class
