' ****************************************************************************************************************
' VariableDefinitions.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.Drawing
Imports System.Drawing.Imaging

''' <summary>
''' Dieses Modul enthält die Definitionen der im Ani Gif Control-Projekt verwendeten Variablen.
''' </summary>
Friend Module VariableDefinitions

    Friend Gif As Bitmap
    Friend GifSizeMode As SizeMode
    Friend CustomDisplaySpeed As Boolean
    Friend FramesPerSecond As Decimal
    Friend Dimension As FrameDimension
    Friend Frame As Integer
    Friend MaxFrame As Integer
    Friend Autoplay As Boolean
    Friend ZoomFactor As Decimal

End Module
