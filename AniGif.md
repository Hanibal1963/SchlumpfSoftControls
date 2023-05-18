# AniGif Control

Steuerelement zum Anzeigen animierter GIF-Grafiken.


## Einführung

Grundlage und Anregung für dieses Control stammen aus dem Buch 
**"Visual Basic 2015 - Grundlagen und Profiwissen"** von Walter Dobrenz und Thomas Gewinnus.

Der urspüngliche Quelltext wurde von mir verändert und um weitere Funktionen erweitert.

Dieser Code sollte für mich als Übung dienen und ich denke das er auch für andere Anfänger 
interessant sein dürfte.

Weitere Infos unter: 

[Autoren-Website von Walter Doberenz & Thomas Gewinnus](https://sites.google.com/site/dokobuch/home/dfsfs/vb-net-2015) 


## neue Eigenschaften

- **Gif** - Gibt die animierte Gif-Grafik zurück oder legt diese fest.
- **AutoPlay** - Legt fest ob die Animation sofort nach dem laden gestartet wird.
- **GifSizeMode** - Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.


## Anzeigemodi

Die Eigenschaft **"GifSizeMode"** kann folgende Werte annehmen:

- **Normal** - Die Grafik wird in Originalgröße angezeigt (Ausrichtung oben links)
- **CenterImage** - Die Grafik wird in Originalgröße angezeigt (zentrierte Ausrichtung)
- **Zoom** - Die Grafik wird an die Größe des Steuerelementes angepasst (Die größere Ausdehnung der Grafik wird als Anpassung verwendet, die Ausrichtung erfolgt zentriert und das Seitenverhältnis bleibt erhalten)

## geplante Änderungen und Funktionen

- [X] Anpassen des ToolBox - Symbols.
- [ ] Ereignis hinzufügen welches ausgelöst wird wenn das Bild nicht animiert ist.

## Weitere Literatur

- [Erstellen eines Windows Forms-Toolbox-Steuerelements](https://docs.microsoft.com/de-de/visualstudio/extensibility/creating-a-windows-forms-toolbox-control?view=vs-2022)
- [Infos zur ControlStyles Enumeration](https://learn.microsoft.com/de-de/dotnet/api/system.windows.forms.controlstyles?redirectedfrom=MSDN&view=netframework-4.7.2)
