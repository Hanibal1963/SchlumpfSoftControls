' ****************************************************************************************************************
' Helpers.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.Drawing

''' <summary>
''' Dieses Modul enthält Hilfsfunktionen, die in der Ani Gif Control verwendet werden.
''' </summary>
Friend Module Helpers

    ''' <summary>
    ''' Stellt die Variablen mit den Startbedingungen ein.
    ''' </summary>
    Friend Sub InitializeValues()

        Gif = My.Resources.Standard 'Standardanimation laden
        Autoplay = False 'Standardeinstellung für AutoPlay
        GifSizeMode = SizeMode.Normal 'Standarddarstellung für Grafik
        CustomDisplaySpeed = False
        FramesPerSecond = 10
        ZoomFactor = 50  'Standardeinstellung für Zoomfaktor

    End Sub

    ''' <summary>
    ''' Prüft den Wert für Bilder/Sekunde
    ''' </summary>
    ''' <param name="Frames"></param>
    Friend Function CheckFramesPerSecondValue(Frames As Decimal) As Decimal

        Select Case Frames

            Case Is < 1 : Return 1
            Case Is > 50 : Return 50
            Case Else : Return Frames

        End Select

    End Function

    ''' <summary>
    ''' Püft den Zoomfaktor
    ''' </summary>
    ''' <param name="ZoomFactor"></param>
    Friend Function CheckZoomFactorValue(ZoomFactor As Decimal) As Decimal

        Select Case ZoomFactor

            Case Is < 0 : Return 1
            Case Is > 100 : Return 100
            Case Else : Return ZoomFactor

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
                'Zeichenflächengröße an Grafik anpassen
                Return New Size(Gif.Size.Width, Gif.Size.Height)

            Case SizeMode.CenterImage
                'Zeichenflächengröße an Grafik anpassen
                Return New Size(Gif.Size.Width, Gif.Size.Height)

            Case SizeMode.Zoom
                'Zeichenflächengröße laut Zoomwert anpassen
                If Gif.Size.Width < Gif.Size.Height Then
                    'Anpassung wenn Bild höher als breit
                    Return New Size(
                        CInt(Control.Height / CDec(Gif.Size.Height / Gif.Size.Width) * Zoom),
                        CInt(Control.Height * Zoom))

                Else
                    'Anpassung wenn Bild breiter als hoch
                    Return New Size(
                        CInt(Control.Width * Zoom),
                        CInt(Control.Width * CDec(Gif.Size.Height / Gif.Size.Width) * Zoom))

                End If

            Case SizeMode.Fill
                'Zeichenflächengröße auf 100% des Controls anpassen
                If Gif.Size.Width < Gif.Size.Height Then
                    'Anpassung wenn Bild höher als breit
                    Return New Size(
                        CInt(Control.Height / CDec(Gif.Size.Height / Gif.Size.Width)),
                        Control.Height)
                Else
                    'Anpassung wenn Bild breiter als hoch
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

        Select Case Mode

            Case SizeMode.Normal
                'Startpunkt ist links oben
                Return New Point(0, 0)

            Case SizeMode.CenterImage
                'Startpunkt von links ist die Hälfte der Differenz aus Controlbreite und Bildbreite
                'Startpunkt von oben ist die Hälfte der Differenz aus Controlhöhe und Bildhöhe
                Return New Point(CInt((Control.Width - Gif.Size.Width) / 2),
                                 CInt((Control.Height - Gif.Size.Height) / 2))

            Case SizeMode.Zoom
                '
                Return New Point(CInt((Control.Width - RectStartSize.Width) / 2),
                                 CInt((Control.Height - RectStartSize.Height) / 2))

            Case SizeMode.Fill
                '
                Return New Point(CInt((Control.Width - RectStartSize.Width) / 2),
                                 CInt((Control.Height - RectStartSize.Height) / 2))

        End Select

    End Function

End Module
