# WizardControl

Ein Steuerelement zum Erstellen eines benutzerdefinierten Assistenten.

---

## Einf�hrung

Dieses Steuerelement wurde von mir in Anlehnung an den [Wizard](https://marketplace.visualstudio.com/items?itemName=vs-publisher-106990.RuWizard) von 
[Klaus Rutkowski](https://marketplace.visualstudio.com/publishers/vs-publisher-106990) entwickelt.

Sinn dieses Projekts ist f�r mich der Lerneffekt sowie eventuelle Anpassungen
vornehmen zu k�nnen.

---

## Eigenschaften Ereignisse und Funktionen

<details>
<summary>Eigenschaften</summary>

- **ImageHeader** - Ruft das in der Kopfzeile der Standardseiten angezeigte Bild ab oder legt dieses fest.
- **HeaderFont** - Ruft die Schriftart ab, die zum Anzeigen der Beschreibung einer Standardseite verwendet wird, 
oder legt diese fest.
- **HeaderTitleFont** - Ruft die Schriftart ab, die zum Anzeigen des Titels einer Standardseite verwendet wird, 
oder legt diese fest.
- **ImageWelcome** - Ruft das auf den Begr��ungs- und Abschlussseiten angezeigte Bild ab oder legt es fest.
- **WelcomeFont** - Ruft die Schriftart ab, die zum Anzeigen der Beschreibung einer Begr��ungs- oder 
Abschlussseite verwendet wird, oder legt diese fest.
- **WelcomeTitelFont** - Ruft die Schriftart ab, die zum Anzeigen des Titels einer Begr��ungs- oder 
Abschlussseite verwendet wird, oder legt diese fest.
- **Pages** - Ruft die Auflistung der Assistentenseiten in diesem Registerkartensteuerelement ab.
- **VisibleHelp** - Ruft die Sichtbarkeit Status der Hilfeschaltfl�che ab oder legt diesen fest.

</details>

<details>
<summary>Ereignisse</summary>


- **AfterSwitchPages** - Tritt auf, nachdem die Seiten des Assistenten gewechselt wurden, 
und gibt dem Benutzer die M�glichkeit, die neue Seite einzurichten.
- **BeforeSwitchPages** - Tritt auf, bevor die Seiten des Assistenten gewechselt werden, 
um dem Benutzer die M�glichkeit zur Validierung zu geben.
- **Cancel** - Tritt auf, nachdem die Seiten des Assistenten gewechselt wurden, 
und gibt dem Benutzer die M�glichkeit, die neue Seite einzurichten.
- **Finish** - Tritt auf, wenn der Assistent abgeschlossen ist, 
und gibt dem Benutzer die M�glichkeit, zus�tzliche Aufgaben zu erledigen.
- **Help** - Tritt auf, wenn der Benutzer auf die Hilfeschaltfl�che klickt.

</details>

<details>
<summary>Funktionen</summary>

- **Next** - Entspricht einem Klick auf die Schaltfl�che "weiter".
- **Back** - Entspricht einem Klick auf die Schaltfl�che "zur�ck".

</details>

---

## geplante Erweiterungen und Funktionen

- [ ] Funktion zum verhindern des automatischen schlie�ens
des �begeordneten Fensters.

---

## weitere Literatur


---

## Versionsverlauf

**Version 2.2024.22.08**

Datum 22.08.2024

- Fehlerbereinigung

**Version 2.2024.22.07**

Datum: 22.07.2024

- Beschreibungstexte in Englisch hinzugef�gt. (Google Translate)

**Version 2.2024.30.06**

Datum: 30.06.2024

- Ver�ffentlichung im B�ndel mit anderen Controls.

**Version 2.2024.04.07**

Datum: 07.04.2024

- Problem mit der Eigenschaft f�r die Sichtbarkeit des Hilfebuttons korrigiert.

**Version 2.2024.04.05**

Datum: 05.04.2024

- �nderung des Repositorie zur besseren Verwaltung des Quellcodes.
- �nderung der Versionsnummerierung wegen Prblemen mit VisualStudio Marketplace.

**Version 1.2024.3103.00**

Datum: 31.03.2024
 
- Erste Release Version

