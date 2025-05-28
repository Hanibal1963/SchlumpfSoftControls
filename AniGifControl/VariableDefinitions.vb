' *************************************************************************************************
' 
' VariableDefinitions.vb
' Copyright (c) 2024-2025 by Andreas Sauer 
'
' Kurzbeschreibung:
' 
' Dieses Modul enthält die Definitionen der im Ani Gif Control-Projekt verwendeten Variablen.
'
' *************************************************************************************************

Imports System.Drawing
Imports System.Drawing.Imaging

''' <summary>
''' Dieses Modul enthält die Definitionen der im Ani Gif Control-Projekt verwendeten Variablen.
''' </summary>
Friend Module VariableDefinitions

    ' Das aktuell geladene GIF-Bild
    Friend Gif As Bitmap

    ' Gibt an, wie das GIF im Steuerelement skaliert/angezeigt wird (z.B. gestreckt, zentriert)
    Friend GifSizeMode As SizeMode

    ' Bestimmt, ob eine benutzerdefinierte Anzeigegeschwindigkeit verwendet wird
    Friend CustomDisplaySpeed As Boolean

    ' Bildwiederholrate (Frames pro Sekunde) für die Animation
    Friend FramesPerSecond As Decimal

    ' Die Dimension (z.B. Zeit) der animierten Frames im GIF
    Friend Dimension As FrameDimension

    ' Der aktuelle Frame-Index, der angezeigt wird
    Friend Frame As Integer

    ' Die maximale Anzahl der Frames im GIF
    Friend MaxFrame As Integer

    ' Gibt an, ob die Animation automatisch abgespielt wird
    Friend Autoplay As Boolean

    ' Zoomfaktor für die Anzeige des GIFs
    Friend ZoomFactor As Decimal

End Module
