# Struktur einer INI-Datei

### Abschnitte (Sections):
   -	Abschnitte werden durch eckige Klammern [] gekennzeichnet.
   -	Sie dienen dazu, verwandte Einstellungen zu gruppieren.
   -	Beispiel:
```ini
[Datenbank]
```

### Schlüssel-Wert-Paare (Key-Value Pairs):
   -	Innerhalb eines Abschnitts werden Einstellungen als Schlüssel-Wert-Paare definiert.
   -	Der Schlüssel und der Wert werden durch ein Gleichheitszeichen = getrennt.
   -	Beispiel:
```ini
Benutzername=admin
Passwort=geheim
```

### Kommentare:
   - Kommentare beginnen mit einem Semikolon ; oder einem Hashtag #.
   - Sie werden ignoriert und dienen nur zur Dokumentation.
   - Beispiel:

```ini
; Dies ist ein Kommentar
# Dies ist auch ein Kommentar
```

### Beispiel einer vollständigen INI-Datei:

```ini
; Dies ist eine Beispiel-INI-Datei

[Allgemein]
AppName=MeineApp
Version=1.0.0

[Datenbank]
Server=localhost
Port=3306
Benutzername=admin
Passwort=geheim

[Logging]
LogLevel=DEBUG
LogDatei=logs/app.log
```

### Erklärung des Beispiels:

#### Kommentare: 
> Die ersten beiden Zeilen sind Kommentare, die ignoriert werden.

#### Abschnitt "Allgemein":
>   -	AppName=MeineApp: Definiert den Namen der Anwendung.
>   -	Version=1.0.0: Gibt die Version der Anwendung an.

####	Abschnitt "Datenbank":
>   -	Server=localhost: Gibt den Datenbankserver an.
>   -	Port=3306: Gibt den Port an, auf dem die Datenbank läuft.
>   -	Benutzername=admin: Der Benutzername für die Datenbank.
>   -	Passwort=geheim: Das Passwort für die Datenbank.

####	Abschnitt "Logging":
>   -	LogLevel=DEBUG: Definiert das Log-Level.
>   -	LogDatei=logs/app.log: Gibt den Pfad zur Log-Datei an.

#### Wichtige Hinweise:
>   -	Leerzeichen: Leerzeichen um das Gleichheitszeichen werden ignoriert.
>   -	Groß-/Kleinschreibung: In der Regel sind Schlüssel und Abschnittsnamen nicht case-sensitive, aber das kann je nach Implementierung variieren.
>   -	Mehrere Abschnitte: Eine INI-Datei kann mehrere Abschnitte enthalten, und jeder Abschnitt kann mehrere Schlüssel-Wert-Paare haben.

INI-Dateien sind aufgrund ihrer Einfachheit und Lesbarkeit weit verbreitet, insbesondere für kleinere Anwendungen und Konfigurationsdateien, die von Menschen bearbeitet werden sollen.
