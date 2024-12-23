' ****************************************************************************************************************
' VariableDefinitions.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.Drawing

''' <summary>
''' Dieses Modul enthält die Variablendefinitionen für die Farbfortschrittsbalkensteuerung.
''' </summary>
Friend Module VariableDefinitions

    ''' <summary>
    ''' Der Betrag in Pixeln, um den der Fortschrittsbalken erhöht wird.
    ''' </summary>
    Friend ProgressUnit As Integer = 20

    ''' <summary>
    ''' Die Menge des ausgefüllten Maximalwerts.
    ''' </summary>
    Friend ProgressValue As Integer = 1

    ''' <summary>
    ''' Der Maximalwert des Fortschrittsbalkens.
    ''' </summary>
    Friend MaxValue As Integer = 10

    ''' <summary>
    ''' Legt fest, ob der Rahmen auf der Fortschrittsanzeige aktiviert ist.
    ''' </summary>
    Friend ShowBorder As Boolean = True

    ''' <summary>
    ''' Legt fest, ob der Glanz auf der Fortschrittsleiste angezeigt wird.
    ''' </summary>
    Friend IsGlossy As Boolean = True

    ''' <summary>
    ''' Die Farbe des Fortschrittsbalkens.
    ''' </summary>
    Friend BarColor As Color = Color.Blue

    ''' <summary>
    ''' Die Farbe des leeren Fortschrittsbalkens.
    ''' </summary>
    Friend EmptyColor As Color = Color.LightGray

    ''' <summary>
    ''' Die Farbe des Rahmens.
    ''' </summary>
    Friend BorderColor As Color = Color.Black

End Module
