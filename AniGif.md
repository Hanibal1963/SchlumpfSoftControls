# AniGif Control

Steuerelement zum Anzeigen animierter GIF-Grafiken.


## Einf�hrung

Grundlage und Anregung f�r dieses Control stammen aus dem Buch 
**"Visual Basic 2015 - Grundlagen und Profiwissen"** von Walter Dobrenz und Thomas Gewinnus.

Der ursp�ngliche Quelltext wurde von mir ver�ndert und um weitere Funktionen erweitert.

Dieser Code sollte f�r mich als �bung dienen und ich denke das er auch f�r andere Anf�nger 
interessant sein d�rfte.

Weitere Infos unter: 

[Autoren-Website von Walter Doberenz & Thomas Gewinnus](https://sites.google.com/site/dokobuch/home/dfsfs/vb-net-2015) 


## neue Eigenschaften

- **Gif** - Gibt die animierte Gif-Grafik zur�ck oder legt diese fest.
- **AutoPlay** - Legt fest ob die Animation sofort nach dem laden gestartet wird.
- **GifSizeMode** - Gibt die Art wie die Grafik angezeigt wird zur�ck oder legt diese fest.


## Anzeigemodi

Die Eigenschaft **"GifSizeMode"** kann folgende Werte annehmen:

- **Normal** - Die Grafik wird in Originalgr��e angezeigt (Ausrichtung oben links)
- **CenterImage** - Die Grafik wird in Originalgr��e angezeigt (zentrierte Ausrichtung)
- **Zoom** - Die Grafik wird an die Gr��e des Steuerelementes angepasst (Die gr��ere Ausdehnung der Grafik wird als Anpassung verwendet, die Ausrichtung erfolgt zentriert und das Seitenverh�ltnis bleibt erhalten)

## geplante �nderungen und Funktionen

- [X] Anpassen des ToolBox - Symbols.
- [ ] Ereignis hinzuf�gen welches ausgel�st wird wenn das Bild nicht animiert ist.

## Weitere Literatur

- [Erstellen eines Windows Forms-Toolbox-Steuerelements](https://docs.microsoft.com/de-de/visualstudio/extensibility/creating-a-windows-forms-toolbox-control?view=vs-2022)
- [Infos zur ControlStyles Enumeration](https://learn.microsoft.com/de-de/dotnet/api/system.windows.forms.controlstyles?redirectedfrom=MSDN&view=netframework-4.7.2)
