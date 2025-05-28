' *************************************************************************************************
' 
' Helpers.vb
' Copyright (c)2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' Dieses Modul enthält Hilfsfunktionen, die in der Ani Gif Control verwendet werden.
'
' *************************************************************************************************

Imports System.Drawing

''' <summary>
''' Dieses Modul enthält Hilfsfunktionen, die in der Ani Gif Control verwendet werden.
''' </summary>
Friend Module Helpers

    ''' <summary>
    ''' Setzt die Standardwerte für die wichtigsten Variablen der Ani Gif Control.
    ''' </summary>
    Friend Sub InitializeValues()

        Gif = My.Resources.Standard         ' Standard-GIF aus den Ressourcen laden
        Autoplay = False                   ' Animation startet nicht automatisch
        GifSizeMode = SizeMode.Normal      ' GIF wird in Originalgröße angezeigt
        CustomDisplaySpeed = False         ' Keine benutzerdefinierte Geschwindigkeit
        FramesPerSecond = 10               ' Standard: 10 Bilder pro Sekunde
        ZoomFactor = 50                    ' Standard-Zoomfaktor: 50%

    End Sub

    ''' <summary>
    ''' Prüft den Wert für Bilder/Sekunde
    ''' </summary>
    ''' <param name="Frames"></param>
    Friend Function CheckFramesPerSecondValue(Frames As Decimal) As Decimal

        ' Überprüft, ob der FPS-Wert im zulässigen Bereich liegt (1 bis 50)
        Select Case Frames

            Case Is < 1
                ' Wenn der Wert kleiner als 1 ist, auf Mindestwert 1 setzen
                Return 1
            Case Is > 50
                ' Wenn der Wert größer als 50 ist, auf Höchstwert 50 setzen
                Return 50
            Case Else
                ' Ansonsten den übergebenen Wert zurückgeben
                Return Frames

        End Select

    End Function

    ''' <summary>
    ''' Prüft, ob der übergebene Zoomfaktor im gültigen Bereich (1-100) liegt.
    ''' Werte kleiner als 1 werden auf 1 gesetzt, Werte größer als 100 auf 100.
    ''' </summary>
    ''' <param name="ZoomFactor">
    ''' Der zu prüfende Zoomfaktor.
    ''' </param>
    ''' <returns>
    ''' Den korrigierten Zoomfaktor im Bereich 1 bis 100.
    ''' </returns>
    Friend Function CheckZoomFactorValue(ZoomFactor As Decimal) As Decimal

        Select Case ZoomFactor

            Case Is < 0
                ' Wenn der Zoomfaktor kleiner als 0 ist, auf Mindestwert 1 setzen
                Return 1

            Case Is > 100
                ' Wenn der Zoomfaktor größer als 100 ist, auf Höchstwert 100 setzen
                Return 100

            Case Else
                ' Ansonsten den übergebenen Wert zurückgeben
                Return ZoomFactor

        End Select

    End Function

    ''' <summary>
    ''' Bildgröße in Abhängikeit vom Zeichenodus berechnen.
    ''' </summary>
    ''' <param name="Mode">
    ''' Anzeigemodus des Controls.
    ''' </param>
    ''' <param name="Control">
    ''' Control dessen Bildgröße berechnet werden soll.
    ''' </param>
    ''' <param name="Gif">
    ''' Bild dessen Werte verwendet werden sollen.
    ''' </param>
    ''' <param name="Zoom">
    ''' Zoomwert
    ''' </param>
    Friend Function GetRectStartSize(Mode As SizeMode, Control As AniGif, Gif As Bitmap, Zoom As Decimal) As Size

        Select Case Mode

            Case SizeMode.Normal
                ' Bild wird in Originalgröße angezeigt (keine Skalierung)
                Return New Size(Gif.Size.Width, Gif.Size.Height)

            Case SizeMode.CenterImage
                ' Bild wird ebenfalls in Originalgröße angezeigt (zentriert, aber Größe bleibt gleich)
                Return New Size(Gif.Size.Width, Gif.Size.Height)

            Case SizeMode.Zoom
                ' Bild wird proportional zum Zoomfaktor skaliert
                If Gif.Size.Width < Gif.Size.Height Then
                    ' Bild ist höher als breit:
                    ' Höhe des Controls als Basis, Breite proportional berechnen und mit Zoom multiplizieren
                    Return New Size(
                        CInt(Control.Height / CDec(Gif.Size.Height / Gif.Size.Width) * Zoom),
                        CInt(Control.Height * Zoom))
                Else
                    ' Bild ist breiter als hoch:
                    ' Breite des Controls als Basis, Höhe proportional berechnen und mit Zoom multiplizieren
                    Return New Size(
                        CInt(Control.Width * Zoom),
                        CInt(Control.Width * CDec(Gif.Size.Height / Gif.Size.Width) * Zoom))
                End If

            Case SizeMode.Fill
                ' Bild wird so skaliert, dass es das Control vollständig ausfüllt (Seitenverhältnis bleibt erhalten)
                If Gif.Size.Width < Gif.Size.Height Then
                    ' Bild ist höher als breit:
                    ' Höhe des Controls als Basis, Breite proportional berechnen
                    Return New Size(
                        CInt(Control.Height / CDec(Gif.Size.Height / Gif.Size.Width)),
                        Control.Height)
                Else
                    ' Bild ist breiter als hoch:
                    ' Breite des Controls als Basis, Höhe proportional berechnen
                    Return New Size(
                        Control.Width,
                        CInt(Control.Width * CDec(Gif.Size.Height / Gif.Size.Width)))
                End If

        End Select

    End Function

    ''' <summary>
    ''' Startpunkt der Zeichenfläche in Abhängikeit vom Zeichenodus berechnen.
    ''' </summary>
    ''' <param name="Mode">
    ''' Anzeigemodus des Controls.
    ''' </param>
    ''' <param name="Control">
    ''' Control dessen Startpunkt berechnet werden soll.
    ''' </param>
    ''' <param name="Gif">
    ''' Bild dessen werte verwendet werden sollen.
    ''' </param>
    ''' <param name="RectStartSize">
    ''' Startgröße der Zeichenfläche.
    ''' </param>
    Friend Function GetRectStartPoint(Mode As SizeMode, Control As AniGif, Gif As Bitmap, RectStartSize As Size) As Point

        ' Bestimmt den Startpunkt (linke obere Ecke) für das Zeichnen des Bildes
        Select Case Mode

            Case SizeMode.Normal
                ' Bild wird in Originalgröße oben links gezeichnet
                Return New Point(0, 0)

            Case SizeMode.CenterImage
                ' Bild wird in Originalgröße zentriert gezeichnet
                ' X-Position: Hälfte der Differenz zwischen Control-Breite und Bild-Breite
                ' Y-Position: Hälfte der Differenz zwischen Control-Höhe und Bild-Höhe
                Return New Point(CInt((Control.Width - Gif.Size.Width) / 2),
                                 CInt((Control.Height - Gif.Size.Height) / 2))

            Case SizeMode.Zoom
                ' Bild wird skaliert (gezoomt) und zentriert gezeichnet
                ' X-Position: Hälfte der Differenz zwischen Control-Breite und skalierter Bild-Breite
                ' Y-Position: Hälfte der Differenz zwischen Control-Höhe und skalierter Bild-Höhe
                Return New Point(CInt((Control.Width - RectStartSize.Width) / 2),
                                 CInt((Control.Height - RectStartSize.Height) / 2))

            Case SizeMode.Fill
                ' Bild wird so skaliert, dass es das Control ausfüllt und zentriert gezeichnet
                ' X- und Y-Position wie bei Zoom
                Return New Point(CInt((Control.Width - RectStartSize.Width) / 2),
                                 CInt((Control.Height - RectStartSize.Height) / 2))

        End Select

    End Function

End Module
