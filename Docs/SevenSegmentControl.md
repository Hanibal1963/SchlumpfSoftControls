# SevenSegmentControl

Zwei Controls zum Anzeigen von Zeichen als 7-Segmentanzeige.

---

## Einf�hrung

Ich habe f�r ein anderes Projekt versucht eine 7-Segmentanzeige zu programmieren.
Nach einigen Fehlversuchen und einer intensive Internetrecherche, bin ich auf GitHub f�ndig geworden.
([SevenSegment von Dimitry Brant](https://github.com/dbrant/SevenSegment))

Ich habe mich entschlossen den Code in VisualBasic neu zu erstellen da ich mit C# keinerlei Erfahrung habe. 

Die Bibliothek SevenSegmentControl umfasst folgende Komponenten:

- **SevSegSingleDigit** - Control zum Anzeigen eines einzelnen Zeichens.
- **SevSegMultiDigit** - Control zum Anzeigen einer Zeichenfolge.

---

## Eigenschaften, Funktionen und Ereignisse f�r SevSegSingleDigit

<details>
<summary>Eigenschaften</summary>

- **InactiveColor** - Legt die Farbe inaktiver Segmente fest oder gibt diese zur�ck.
- **SegmentWidth** - Legt die Breite der LED-Segmente fest oder gibt diese zur�ck.
- **ItalicFactor** - Scherkoeffizient f�r die Kursivschrift der Anzeige.
- **DigitValue** - Legt das anzuzeigende Zeichen fest oder gibt dieses zur�ck.
  (Unterst�tzte Zeichen sind Ziffern und die meisten Buchstaben.)
- **CustomBitPattern** - Legt ein benutzerdefiniertes Bitmuster fest, das in den sieben Segmenten angezeigt werden soll.
  (Dies ist ein ganzzahliger Wert, bei dem die Bits 0 bis 6 den jeweiligen LED-Segmenten entsprechen.)
- **ShowDecimalPoint** - Gibt an, ob die Dezimalpunkt-LED aktiv ist.
- **DecimalPointActive** - Gibt an, ob die Dezimalpunkt-LED aktiv ist.
- **ShowColon** - Gibt an, ob die Doppelpunkt-LEDs angezeigt werden.
- **ColonActive** - Gibt an, ob die Doppelpunkt-LEDs aktiv sind.
- **BackColor** - Legt die Hintergrundfarbe des Controls fest oder gibt diese zur�ck.
- **ForeColor** - Legt die Vordergrundfarbe der Segmente des Controls fest oder gibt diese zur�ck.

</details>

<details> 
<summary>Funktionen</summary>

</details>

<details> 
<summary>Ereignisse</summary>

</details>

---

## Eigenschaften, Funktionen und Ereignisse f�r SevSegMultiDigit

<details>
<summary>Eigenschaften</summary>

- **InactiveColor** - Legt die Farbe inaktiver Segmente fest oder gibt diese zur�ck.
- **SegmentWidth** - Legt die Breite der LED-Segmente fest oder gibt diese zur�ck.
- **ItalicFactor** - Scherkoeffizient f�r die Kursivschrift der Anzeige.
- **ShowDecimalPoint** - Gibt an, ob die Dezimalpunkt-LED angezeigt wird.
- **DigitCount** - Anzahl der Digits in diesem Control.
- **DigitPadding** - Auff�llung, die f�r jedes Digit im Control gilt.
    (Passen Sie diese Zahlen an, um das perfekte Erscheinungsbild f�r das Control Ihrer Gr��e zu erhalten.)
- **Value** - Der auf dem Control anzuzeigende Wert. 
    (Kann Zahlen, bestimmte Buchstaben und Dezimalpunkte enthalten.)
- **BackColor** - Legt die Hintergrundfarbe des Controls fest oder gibt diese zur�ck.
- **ForeColor** - Legt die Vordergrundfarbe der Segmente des Controls fest oder gibt diese zur�ck.

</details>

<details> 
<summary>Funktionen</summary>

</details>

<details> 
<summary>Ereignisse</summary>

</details>

---

## geplante �nderungen und Funktionen

- Eine M�glichkeit die Breite des Multi Digit automatisch 
  an die Anzahl der Digits anzupassen.

---

## Weitere Literatur

- [Erstellen eines Windows Forms-Toolbox-Steuerelements](https://docs.microsoft.com/de-de/visualstudio/extensibility/creating-a-windows-forms-toolbox-control?view=vs-2022)
- [ToolboxBitmapAttribute Konstruktoren](https://learn.microsoft.com/de-de/dotnet/api/system.drawing.toolboxbitmapattribute.-ctor?view=dotnet-plat-ext-7.0#system-drawing-toolboxbitmapattribute-ctor(system-type-system-string))
- [Entwickeln benutzerdefinierter Windows Forms-Steuerelemente mit .NET Framework](https://learn.microsoft.com/de-de/dotnet/desktop/winforms/controls/developing-custom-windows-forms-controls?view=netframeworkdesktop-4.8)
- [Control-Techniken: Eigenes Toolboxicon f�r Steuerelement](https://www.vb-paradise.de/index.php/Thread/123746-Control-Techniken-Eigenes-Toolboxicon-f%C3%BCr-Steuerelement/)

---

## Versionsverlauf

Version 2.2024.30.06

Datum: 30.06.2024

- Ver�ffentlichung im B�ndel mit anderen Controls.

Version 1.2024.06.04

Datum 04.06.2024

- Erstver�ffentlichung