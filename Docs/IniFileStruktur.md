# Struktur einer INI-Datei

**Abschnitte (Sections):**

   -	Abschnitte werden durch eckige Klammern <font color="red">[  ]</font> gekennzeichnet.
   -	Sie dienen dazu, verwandte Einstellungen zu gruppieren.
   
   Beispiel:

```ini
[Datenbank]
```
---

**Schlüssel-Wert-Paare (Key-Value Pairs):**

   -	Innerhalb eines Abschnitts werden Einstellungen als Schlüssel-Wert-Paare definiert.
   -	Der Schlüssel und der Wert werden durch ein Gleichheitszeichen = getrennt.
   
   Beispiel:

```ini
Benutzername=admin
Passwort=geheim
```
 ---

**Kommentare:**

   - Kommentare beginnen mit einem Semikolon <font color="red">;</font> oder einem Hashtag <font color="red">#</font>.
   - Sie werden ignoriert und dienen nur zur Dokumentation.
   
   Beispiel:

```ini
; Dies ist ein Kommentar
# Dies ist auch ein Kommentar
```
---

**Beispiel einer vollständigen INI-Datei:**

```ini
; Dies ist eine Beispiel-INI-Datei

[Allgemein]
; Allgemeine Einstellungen
AppName=MeineApp
Version=1.0.0

[Datenbank]
; Einstellungen zur Datenbank
Server=localhost
Port=3306
Benutzername=admin
Passwort=geheim

[Logging]
LogLevel=DEBUG
LogDatei=logs/app.log
```
---

**Erklärung des Beispiels:**

:memo: **Kommentare:** 

> &rarr; Die ersten beiden Zeilen sind Kommentare, die ignoriert werden.

:memo: **Abschnitt "Allgemein":**

>   &rarr;	**AppName=MeineApp**: Definiert den Namen der Anwendung.
>
>   &rarr;	**Version=1.0.0**: Gibt die Version der Anwendung an.

:memo: **Abschnitt "Datenbank":**

>   &rarr;	**Server=localhost**: Gibt den Datenbankserver an.
>
>   &rarr;	**Port=3306**: Gibt den Port an, auf dem die Datenbank läuft.
>
>   &rarr;	**Benutzername=admin**: Der Benutzername für die Datenbank.
>
>   &rarr;	**Passwort=geheim**: Das Passwort für die Datenbank.

:memo:	**Abschnitt "Logging":**

>   &rarr;	**LogLevel=DEBUG**: Definiert das Log-Level.
>
>   &rarr;	**LogDatei=logs/app.log**: Gibt den Pfad zur Log-Datei an.

---

:memo: **Wichtige Hinweise:**

>   &rarr;	**Leerzeichen**: Leerzeichen um das Gleichheitszeichen werden ignoriert.
>
>   &rarr;	**Groß-/Kleinschreibung**: In der Regel sind Schlüssel und Abschnittsnamen nicht case-sensitive, aber das kann je nach Implementierung variieren.
>
>   &rarr;	**Mehrere Abschnitte**: Eine INI-Datei kann mehrere Abschnitte enthalten, und jeder Abschnitt kann mehrere Schlüssel-Wert-Paare haben.

---

:bulb: INI-Dateien sind aufgrund ihrer Einfachheit und Lesbarkeit weit verbreitet, insbesondere für kleinere Anwendungen und Konfigurationsdateien, die von Menschen bearbeitet werden sollen.
