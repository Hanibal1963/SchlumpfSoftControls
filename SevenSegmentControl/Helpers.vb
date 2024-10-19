' ****************************************************************************************************************
' Helpers.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.Drawing

''' <summary>
''' Modul mit Hilfsfunktionen
''' </summary>
Friend Module Helpers

    ''' <summary>
    ''' Berechnet die Punkte, die die Polygone der sieben Segmente darstellen, 
    ''' unabhängig davon, ob initialisiert oder die Segmentbreite geändert wird.
    ''' </summary>
    ''' <param name="SegmentCornerPoints">
    ''' Segmenteckpunkte die berechnet werden sollen.
    ''' </param>
    ''' <param name="DigitHeight">
    ''' Höhe des Digits
    ''' </param>
    ''' <param name="DigitWidth">
    ''' Breite des Digits
    ''' </param>
    ''' <param name="SegmentWidth">
    ''' Breite der Segmente des Digits
    ''' </param>
    Friend Sub CalculatePoints(
                              ByRef SegmentCornerPoints As Point()(),
                              DigitHeight As Integer,
                              DigitWidth As Integer,
                              SegmentWidth As Integer)

        Dim halfHeight As Integer = CInt(DigitHeight / 2)
        Dim halfWidth As Integer = CInt(SegmentWidth / 2)

        Dim p = 0
        SegmentCornerPoints(p)(0).X = SegmentWidth + 1
        SegmentCornerPoints(p)(0).Y = 0
        SegmentCornerPoints(p)(1).X = DigitWidth - SegmentWidth - 1
        SegmentCornerPoints(p)(1).Y = 0
        SegmentCornerPoints(p)(2).X = DigitWidth - halfWidth - 1
        SegmentCornerPoints(p)(2).Y = halfWidth
        SegmentCornerPoints(p)(3).X = DigitWidth - SegmentWidth - 1
        SegmentCornerPoints(p)(3).Y = SegmentWidth
        SegmentCornerPoints(p)(4).X = SegmentWidth + 1
        SegmentCornerPoints(p)(4).Y = SegmentWidth
        SegmentCornerPoints(p)(5).X = halfWidth + 1
        SegmentCornerPoints(p)(5).Y = halfWidth

        p += 1
        SegmentCornerPoints(p)(0).X = 0
        SegmentCornerPoints(p)(0).Y = SegmentWidth + 1
        SegmentCornerPoints(p)(1).X = halfWidth
        SegmentCornerPoints(p)(1).Y = halfWidth + 1
        SegmentCornerPoints(p)(2).X = SegmentWidth
        SegmentCornerPoints(p)(2).Y = SegmentWidth + 1
        SegmentCornerPoints(p)(3).X = SegmentWidth
        SegmentCornerPoints(p)(3).Y = halfHeight - halfWidth - 1
        SegmentCornerPoints(p)(4).X = 4
        SegmentCornerPoints(p)(4).Y = halfHeight - 1
        SegmentCornerPoints(p)(5).X = 0
        SegmentCornerPoints(p)(5).Y = halfHeight - 1

        p += 1
        SegmentCornerPoints(p)(0).X = DigitWidth - SegmentWidth
        SegmentCornerPoints(p)(0).Y = SegmentWidth + 1
        SegmentCornerPoints(p)(1).X = DigitWidth - halfWidth
        SegmentCornerPoints(p)(1).Y = halfWidth + 1
        SegmentCornerPoints(p)(2).X = DigitWidth
        SegmentCornerPoints(p)(2).Y = SegmentWidth + 1
        SegmentCornerPoints(p)(3).X = DigitWidth
        SegmentCornerPoints(p)(3).Y = halfHeight - 1
        SegmentCornerPoints(p)(4).X = DigitWidth - 4
        SegmentCornerPoints(p)(4).Y = halfHeight - 1
        SegmentCornerPoints(p)(5).X = DigitWidth - SegmentWidth
        SegmentCornerPoints(p)(5).Y = halfHeight - halfWidth - 1

        p += 1
        SegmentCornerPoints(p)(0).X = SegmentWidth + 1
        SegmentCornerPoints(p)(0).Y = halfHeight - halfWidth
        SegmentCornerPoints(p)(1).X = DigitWidth - SegmentWidth - 1
        SegmentCornerPoints(p)(1).Y = halfHeight - halfWidth
        SegmentCornerPoints(p)(2).X = DigitWidth - 5
        SegmentCornerPoints(p)(2).Y = halfHeight
        SegmentCornerPoints(p)(3).X = DigitWidth - SegmentWidth - 1
        SegmentCornerPoints(p)(3).Y = halfHeight + halfWidth
        SegmentCornerPoints(p)(4).X = SegmentWidth + 1
        SegmentCornerPoints(p)(4).Y = halfHeight + halfWidth
        SegmentCornerPoints(p)(5).X = 5
        SegmentCornerPoints(p)(5).Y = halfHeight

        p += 1
        SegmentCornerPoints(p)(0).X = 0
        SegmentCornerPoints(p)(0).Y = halfHeight + 1
        SegmentCornerPoints(p)(1).X = 4
        SegmentCornerPoints(p)(1).Y = halfHeight + 1
        SegmentCornerPoints(p)(2).X = SegmentWidth
        SegmentCornerPoints(p)(2).Y = halfHeight + halfWidth + 1
        SegmentCornerPoints(p)(3).X = SegmentWidth
        SegmentCornerPoints(p)(3).Y = DigitHeight - SegmentWidth - 1
        SegmentCornerPoints(p)(4).X = halfWidth
        SegmentCornerPoints(p)(4).Y = DigitHeight - halfWidth - 1
        SegmentCornerPoints(p)(5).X = 0
        SegmentCornerPoints(p)(5).Y = DigitHeight - SegmentWidth - 1

        p += 1
        SegmentCornerPoints(p)(0).X = DigitWidth - SegmentWidth
        SegmentCornerPoints(p)(0).Y = halfHeight + halfWidth + 1
        SegmentCornerPoints(p)(1).X = DigitWidth - 4
        SegmentCornerPoints(p)(1).Y = halfHeight + 1
        SegmentCornerPoints(p)(2).X = DigitWidth
        SegmentCornerPoints(p)(2).Y = halfHeight + 1
        SegmentCornerPoints(p)(3).X = DigitWidth
        SegmentCornerPoints(p)(3).Y = DigitHeight - SegmentWidth - 1
        SegmentCornerPoints(p)(4).X = DigitWidth - halfWidth
        SegmentCornerPoints(p)(4).Y = DigitHeight - halfWidth - 1
        SegmentCornerPoints(p)(5).X = DigitWidth - SegmentWidth
        SegmentCornerPoints(p)(5).Y = DigitHeight - SegmentWidth - 1

        p += 1
        SegmentCornerPoints(p)(0).X = SegmentWidth + 1
        SegmentCornerPoints(p)(0).Y = DigitHeight - SegmentWidth
        SegmentCornerPoints(p)(1).X = DigitWidth - SegmentWidth - 1
        SegmentCornerPoints(p)(1).Y = DigitHeight - SegmentWidth
        SegmentCornerPoints(p)(2).X = DigitWidth - halfWidth - 1
        SegmentCornerPoints(p)(2).Y = DigitHeight - halfWidth
        SegmentCornerPoints(p)(3).X = DigitWidth - SegmentWidth - 1
        SegmentCornerPoints(p)(3).Y = DigitHeight
        SegmentCornerPoints(p)(4).X = SegmentWidth + 1
        SegmentCornerPoints(p)(4).Y = DigitHeight
        SegmentCornerPoints(p)(5).X = halfWidth + 1
        SegmentCornerPoints(p)(5).Y = DigitHeight - halfWidth

    End Sub

End Module
