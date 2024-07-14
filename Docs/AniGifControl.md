# AniGif Control

Ein Steuerelement welches zum Anzeigen animierter Grafiken dient.

---

## Einf�hrung

Grundlage und Anregung f�r dieses Steuerelement stammen aus dem Buch 
**"Visual Basic 2015 - Grundlagen und Profiwissen"** von Walter Dobrenz und Thomas Gewinnus.

Der urspr�ngliche Quelltext wurde von mir ver�ndert und um weitere Funktionen erweitert.

Dieser Code sollte f�r mich als �bung dienen und ich denke das er auch f�r andere Anf�nger 
interessant sein d�rfte.

Weitere Infos unter: 

[HANSER Fachbuch](https://www.hanser-fachbuch.de/fachbuch/artikel/9783446446052) 

[Buchleser freigegeben auf onedrive](https://onedrive.live.com/?id=root&cid=D73E81A6F971DBA7&qt=people&personId=de18bb46da92110)

---

## Eigenschaften

-  **Gif** - Gibt die animierte Gif-Grafik zur�ck oder legt diese fest.
-  **AutoPlay** - Legt fest ob die Animation sofort nach dem laden gestartet wird.
-  **GifSizeMode** - Gibt die Art wie die Grafik angezeigt wird zur�ck oder legt diese fest.
-  **CustomDisplaySpeed** - Legt fest ob die im Bild gespeicherte Anzeigegeschwindigkeit oder die benutzerdefinierte verwendet werden soll.
-  **FramesPerSecond** - Legt die Anzahl der Bilder pro Sekunde fest (1-50) die angezeigt werden, wenn die Benutzerdefinierte Geschwindigkeit aktiv ist.
-  **ZoomFaktor** - Legt den Zoomfaktor f�r GifSizeMode "Zoom" in % (1-100) fest.

---

## Anzeigemodi

Die Eigenschaft **"GifSizeMode"** kann folgende Werte annehmen:

-  **Normal** - Die Grafik wird in Originalgr��e angezeigt (Ausrichtung oben links)
-  **CenterImage** - Die Grafik wird in Originalgr��e angezeigt (zentrierte Ausrichtung)
-  **Zoom** - Die Grafik wird an die Gr��e des Steuerelementes angepasst (Die gr��ere Ausdehnung der Grafik wird als Anpassung verwendet, die Ausrichtung erfolgt zentriert und das Seitenverh�ltnis bleibt erhalten)
-  **Fill** - Die Grafik wird in das Control eingepasst (unabh�ngig von ihrer Gr��e).

---

## Ereignisse

-  **NoAnimation** - wird ausgel�st, wenn das Bild nicht animiert werden kann.

---

## geplante �nderungen und Funktionen

- Zurzeit keine.

---

## Weitere Literatur

-  [Erstellen eines Windows Forms-Toolbox-Steuerelements](https://docs.microsoft.com/de-de/visualstudio/extensibility/creating-a-windows-forms-toolbox-control?view=vs-2022)
-  [Infos zur ControlStyles Enumeration](https://learn.microsoft.com/de-de/dotnet/api/system.windows.forms.controlstyles?redirectedfrom=MSDN&view=netframework-4.7.2)
-  [Control-Techniken: Eigenes Toolboxicon f�r Steuerelement](https://www.vb-paradise.de/index.php/Thread/123746-Control-Techniken-Eigenes-Toolboxicon-f%C3%BCr-Steuerelement/)
-  [FrameDelays von animierter GIF](https://foren.activevb.de/archiv/vb-net/thread-93030/beitrag-93069/FrameDelays-von-animierter-GIF/)

---

## Versionsverlauf

Version 2.2024.11.07

Datum: 11.07.2024

- Kleinere �nderungen am Code (Achtung! Das Ereignis "NoAnimation" weist ein ge�ndertes Verhalten auf.)


Version 2.2024.30.06

Datum: 30.06.2024

- Ver�ffentlichung im B�ndel mit anderen Controls.
