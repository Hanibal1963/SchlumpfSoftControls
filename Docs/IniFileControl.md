# IniFile Control

Eine Komponente zum Verwalten von INI - Dateien.

---

## Einführung

Diese Komponente ist von mir ursprünglich als Hilfsklasse für ein 
anderes Projekt von mir entwickelt worden.

Es entstand die Idee eine Windows-Forms-Komponente aus 
dieser Hilfsklasse zu machen und diese anderen zur Verfügung zu stellen.

Inzwischen habe ich weitere Komponenten hinzugefügt welche die Benutzung der
Komponente IniFile weiter vereinfachen. 
Es sind nur noch wenige Zeilen Code erforderlich um die volle Funktionalität zu erreichen.

Die Bibliothek IniFileControl umfasst folgende Komponenten:

- **IniFile** - Das Verwaltungscontrol.
- **IniFileCommentEdit** - Control zum Bearbeiten des Dateikommentars.
- **IniFileListEdit** - Control zum Bearbeiten der Abschnitts- oder Eintragsnamen. 
- **IniFileEntryValueEdit** - Control zum Bearbeiten der Eintragswerte.
- **IniFileContentView** - Control zum Anzeigen des gesamten Dateiinhaltes.

---

## Eigenschaften, Funktionen und Ereignisse für IniFile

<details>
<summary>Eigenschaften</summary>

- **AutoSave** - Legt das Speicherverhalten der Klasse fest.
  (True legt fest das Änderungen automatisch gespeichert werden.)
- **CommentPrefix** - Gibt das Prefixzeichen für Kommentare zurück oder legt dieses fest.
- **FilePath** - Gibt den Pfad und den Name zur INI-Datei zurück oder legt diesen fest.

</details>

<details> 
<summary>Funktionen</summary>

- **AddEntry** - Fügt einen neuen Eintrag in die Liste der Eintragnamen ein.
- **AddSection** - Fügt einen neuen Abschnitt hinzu.
- **DeleteEntry** - Löscht einen Eintrag aus einem Abschnitt.
- **DeleteSection** - Löscht einen Abschnitt.
- **GetEntrynames** - Gibt die Namen der Einträge eines Abschnitts zurück.
- **GetEntryValue** - Gibt den Wert eines Eintrags aus einem Abschnitt zurück.
- **GetFileComment** - Gibt den Dateikommentar zurück.
- **GetFileContent** - Gibt den Dateiinhalt zurück.
- **GetSectionComment** - Gibt die Kommentarzeilen für einen Abschnitt zurück.
- **GetSectionNames** - Ruft die Abschnittsnamen ab.
- **LoadFile** - Lädt die Datei die in FilePath angegeben wurde.
- **RenameEntry** - Benennt einen Eintrag in einem Abschnitt um.
- **RenameSection** - Benennt einen Abschnitt um.
- **SaveFile** - Speichert die in FilePath angegebene Datei.
- **SetEntryValue** - Setzt den Wert eines Eintrags in einem Abschnitt. 
- **SetFileComment** - Setzt den Dateikommentar.
- **SetSectionComment** - Setzt den Kommentar für einen Abschnitt.

</details>

<details> 
<summary>Ereignisse</summary>

- **EntryNameExist** - Wird ausgelöst wenn beim anlegen eines neuen Eintrags oder umbenennen eines Eintrags der Name bereits vorhanden ist.
- **EntrysChanged** - Wird ausgelöst wenn sich die Liste der Einträge geändert hat.
- **EntryValueChanged** - Wird ausgelöst wenn sich der Wert eines Eintrags in einem Abschnitt geändert hat.
- **FileCommentChanged** - Wird ausgelöst wenn sich der Dateikommentar geändert hat.
- **FileContentChanged** - Wird ausgelöst wenn sich der Dateiinhalt geändert hat.
- **SectionCommentChanged** - Wird ausgelöst wenn sich der Abschnittskommentar geändert hat.
- **SectionNameExist** - Wird ausgelöst wenn beim anlegen eines neuen Abschnitts oder umbenennen eines Abschnitts der Name bereits vorhanden ist.
- **SectionsChanged** - Wird ausgelöst wenn sich die Liste der Abschnitte geändert hat.

</details>

---

## Eigenschaften, Funktionen und Ereignisse für IniFileCommentEdit

<details> 
<summary>Eigenschaften</summary>

- **Comment** - Gibt den Kommentartext zurück oder legt diesen fest.

</details>

<details> 
<summary>Ereignisse</summary>

- **CommentChanged** - Wird ausgelöst wenn sich der Kommentartext geändert hat.

</details>

---

## Eigenschaften, Funktionen und Ereignisse für IniFileListEdit

<details> 
<summary>Eigenschaften</summary>

- **SelectedItem** - Gibt den ausgewählten Eintrag oder leer zurück.
- **Items** - Elemente der Listbox.

</details>

<details> 
<summary>Ereignisse</summary>

- **ItemAdd** - Wird ausgelöst wenn ein Eintrag hinzugefügt werden soll.
- **ItemRename** - Wird ausgelöst wenn ein Eintrag umbenannt werden soll.
- **ItemRemove** - Wird ausgelöst wenn ein Eintrag gelöscht werden soll.
- **SelectedItemChanged** - Wird ausgelöst wenn sich der gewählte Eintrag geändert hat.

</details>

---

## Eigenschaften, Funktionen und Ereignisse für IniFileEntryValueEdit

<details> 
<summary>Eigenschaften</summary>

- **Value** - Eintragswert.

</details>

<details> 
<summary>Ereignisse</summary>

- **ValueChanged** - Wird ausgelöst wenn sich der Wert geändert hat.

</details>

---

## Eigenschaften, Funktionen und Ereignisse für IniFilecontentView

<details>
<summary>Eigenschaften</summary>

- **Lines** - Dateiinhalt

</details>

---

## Weitere Literatur

- [Erstellen eines Windows Forms-Toolbox-Steuerelements](https://docs.microsoft.com/de-de/visualstudio/extensibility/creating-a-windows-forms-toolbox-control?view=vs-2022)
- [Infos zur ControlStyles Enumeration](https://learn.microsoft.com/de-de/dotnet/api/system.windows.forms.controlstyles?redirectedfrom=MSDN&view=netframework-4.7.2)
- [Control-Techniken: Eigenes Toolboxicon für Steuerelement](https://www.vb-paradise.de/index.php/Thread/123746-Control-Techniken-Eigenes-Toolboxicon-f%C3%BCr-Steuerelement/)
- [ToolboxBitmapAttribute Konstruktoren](https://learn.microsoft.com/de-de/dotnet/api/system.drawing.toolboxbitmapattribute.-ctor?view=dotnet-plat-ext-7.0#system-drawing-toolboxbitmapattribute-ctor(system-type-system-string))
- [Entwickeln benutzerdefinierter Windows Forms-Steuerelemente mit .NET Framework](https://learn.microsoft.com/de-de/dotnet/desktop/winforms/controls/developing-custom-windows-forms-controls?view=netframeworkdesktop-4.8)
- [Initialisierungsdatei](https://de.wikipedia.org/wiki/Initialisierungsdatei#:~:text=Initialisierungsdateien%20werden%20typischerweise%20von%20Microsoft,durch%20die%20WinAPI%20unterst%C3%BCtzt%20wurde.)
- [Übersicht über Attribute (Visual Basic)](https://learn.microsoft.com/de-de/dotnet/visual-basic/programming-guide/concepts/attributes/)

---

## Versionsverlauf

**Version 2.2024.04.08**

Datum: 04.08.2024

- Layoutfehler beseitigt und Texte in Englisch hinzugefügt.

**Version 2.2024.16.07**

Datum: 16.07.2024

- Layoutfehler in **IniFileCommentEdit**, **IniFileEntryValueEdit** und **IniFileListEdit** beseitigt.

**Version 2.2024.30.06**

Datum: 30.06.2024

- Veröffentlichung im Bündel mit anderen Controls.

**Version 2.2024.06.03**

Datum: 03.06.2024

- Fehlerhafte Links in der Beschreibung korrigiert.

**Version 2.2024.05.01**

Datum: 01.05.2024

- Steuerelement zum Anzeigen des Dateiinhaltes hinzugefügt.

**Version 2.2024.04.14**

Datum: 14.04.2024

- Steuerelement zum Anzeigen und Bearbeiten der Abschnitts- oder Eintrags- Liste einer INI-Datei hinzugefügt.
- Steuerelement zum Anzeigen und Bearbeiten des Eintragswertes einer INI-Datei hinzugefügt.

**Version 2.2024.04.12**

Datum: 12.04.2024

- Steuerelement zum Anzeigen und Bearbeiten des Datei- oder Abschnitts- Kommentars einer INI-Datei hinzugefügt.

**Version 2.2024.04.06**

Datum: 06.04.2024

- Änderung der Versionsnummerierung wegen Problemen mit dem VisualStudio Marketplace.

**Version 1.2024.0404.00**

Datum: 04.04.2024

- Änderung des Repositorie zur besseren Verwaltung des Quellcodes.

**Version 1.2024.0303.0**

Datum 03.03.2024
 
- Erstveröffentlichung

