' ****************************************************************************************************************
' SevSegSingleDigit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'
' weitere Infos:
' <Browsable> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.browsableattribute?view=netframework-4.7.2
' <Category> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.categoryattribute?view=netframework-4.7.2
' <Description> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.descriptionattribute?view=netframework-4.7.2

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports SchlumpfSoft.Controls.Attribute

''' <summary>
''' Dieses Steuerelement stellt ein einzelnes Siebensegment-LED-Display dar,<br/> 
''' das eine Ziffer oder einen Buchstaben anzeigt.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Dieses Steuerelement stellt ein einzelnes Siebensegment-LED-Display dar, das eine Ziffer oder einen Buchstaben anzeigt.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(SevSegSingleDigit), "SevSegSingleDigit.bmp")>
Public Class SevSegSingleDigit

    Inherits Control

#Region "Eigenschaftsvariablen"

    Private ReadOnly _segmentPoints As Point()()
    Private ReadOnly _digitHeight As Integer = 80
    Private ReadOnly _digitWidth As Integer = 48
    Private _segmentWidth As Integer = 10
    Private _italicFactor As Single = -0.1F
    Private _backgroundColor As Color = Color.LightGray
    Private _inactiveColor As Color = Color.DarkGray
    Private _foreColor As Color = Color.DarkGreen
    Private _digitValue As String = Nothing
    Private _showDecimalPoint As Boolean = True
    Private _decimalPointActive As Boolean = False
    Private _showColon As Boolean = False
    Private _colonActive As Boolean = False
    Private _customBitPattern As Integer = 0

#End Region

    ''' <summary>
    ''' Wird ausgeführt wenn eine neue Instanz dieses Controls erstellt wird.
    ''' </summary>
    Public Sub New()

        Me.SuspendLayout()
        Me.Name = "SevSegSingleDigit"
        Me.Size = New Size(32, 64)
        Me.ResumeLayout(False)
        Me.TabStop = False
        Me.Padding = New Padding(10, 4, 10, 4)
        MyBase.DoubleBuffered = True
        Me._segmentPoints = New Point(6)() {}
        For i = 0 To 6
            Me._segmentPoints(i) = New Point(5) {}
        Next
        CalculatePoints(
            Me._segmentPoints,
            Me._digitHeight,
            Me._digitWidth,
            Me._segmentWidth)

    End Sub

#Region "neue Eigenschaften"

    ''' <summary>
    ''' Legt die Farbe inaktiver Segmente fest oder gibt diese zurück.
    ''' </summary>
    <Category("Appearance")>
    <Description("Legt die Farbe inaktiver Segmente fest oder gibt diese zurück.")>
    Public Property InactiveColor As Color
        Get
            Return Me._inactiveColor
        End Get
        Set(value As Color)
            Me._inactiveColor = value
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Legt die Breite der LED-Segmente fest oder gibt diese zurück.
    ''' </summary>
    <Category("Appearance")>
    <Description("Legt die Breite der LED-Segmente fest oder gibt diese zurück.")>
    Public Property SegmentWidth As Integer
        Get
            Return Me._segmentWidth
        End Get
        Set(value As Integer)
            Me._segmentWidth = value
            CalculatePoints(
            Me._segmentPoints,
            Me._digitHeight,
            Me._digitWidth,
            Me._segmentWidth)
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Scherkoeffizient für die Kursivschrift der Anzeige.
    ''' </summary>
    ''' <remarks>
    ''' Standarwert ist -0,1.
    ''' </remarks>
    <Category("Appearance")>
    <Description("Scherkoeffizient für die Kursivschrift der Anzeige.")>
    Public Property ItalicFactor As Single
        Get
            Return Me._italicFactor
        End Get
        Set(value As Single)
            Me._italicFactor = value
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Legt das anzuzeigende Zeichen fest oder gibt dieses zurück.
    ''' </summary>
    ''' <remarks>
    ''' Unterstützte Zeichen sind Ziffern und die meisten Buchstaben.
    ''' </remarks>
    <Category("Appearance")>
    <Description("Legt das anzuzeigende Zeichen fest oder gibt dieses zurück.")>
    Public Property DigitValue As String
        Get
            Return Me._digitValue
        End Get
        Set(value As String)

            Me._customBitPattern = 0
            Me._digitValue = value
            Me.Invalidate()

            If Equals(value, Nothing) OrElse value.Length = 0 Then
                Return
            End If

            Dim tempValue As Integer
            If Integer.TryParse(value, tempValue) Then

                If tempValue > 9 Then tempValue = 9
                If tempValue < 0 Then tempValue = 0

                'ist es eine ganze Zahl?
                Select Case tempValue
                    Case 0
                        Me._customBitPattern = CharacterPattern.Zero
                    Case 1
                        Me._customBitPattern = CharacterPattern.One
                    Case 2
                        Me._customBitPattern = CharacterPattern.Two
                    Case 3
                        Me._customBitPattern = CharacterPattern.Three
                    Case 4
                        Me._customBitPattern = CharacterPattern.Four
                    Case 5
                        Me._customBitPattern = CharacterPattern.Five
                    Case 6
                        Me._customBitPattern = CharacterPattern.Six
                    Case 7
                        Me._customBitPattern = CharacterPattern.Seven
                    Case 8
                        Me._customBitPattern = CharacterPattern.Eight
                    Case 9
                        Me._customBitPattern = CharacterPattern.Nine
                End Select

            Else

                'ist es ein Buchstabe?
                Select Case value(0)
                    Case "A"c, "a"c
                        Me._customBitPattern = CharacterPattern.A
                    Case "B"c, "b"c
                        Me._customBitPattern = CharacterPattern.B
                    Case "C"c
                        Me._customBitPattern = CharacterPattern.C
                    Case "c"c
                        Me._customBitPattern = CharacterPattern.cField
                    Case "D"c, "d"c
                        Me._customBitPattern = CharacterPattern.D
                    Case "E"c, "e"c
                        Me._customBitPattern = CharacterPattern.E
                    Case "F"c, "f"c
                        Me._customBitPattern = CharacterPattern.F
                    Case "G"c, "g"c
                        Me._customBitPattern = CharacterPattern.G
                    Case "H"c
                        Me._customBitPattern = CharacterPattern.H
                    Case "h"c
                        Me._customBitPattern = CharacterPattern.hField
                    Case "I"c
                        Me._customBitPattern = CharacterPattern.One
                    Case "i"c
                        Me._customBitPattern = CharacterPattern.i
                    Case "J"c, "j"c
                        Me._customBitPattern = CharacterPattern.J
                    Case "L"c, "l"c
                        Me._customBitPattern = CharacterPattern.L
                    Case "N"c, "n"c
                        Me._customBitPattern = CharacterPattern.N
                    Case "O"c
                        Me._customBitPattern = CharacterPattern.Zero
                    Case "o"c
                        Me._customBitPattern = CharacterPattern.o
                    Case "P"c, "p"c
                        Me._customBitPattern = CharacterPattern.P
                    Case "Q"c, "q"c
                        Me._customBitPattern = CharacterPattern.Q
                    Case "R"c, "r"c
                        Me._customBitPattern = CharacterPattern.R
                    Case "S"c, "s"c
                        Me._customBitPattern = CharacterPattern.Five
                    Case "T"c, "t"c
                        Me._customBitPattern = CharacterPattern.T
                    Case "U"c
                        Me._customBitPattern = CharacterPattern.U
                    Case "u"c, "µ"c, "μ"c
                        Me._customBitPattern = CharacterPattern.uField
                    Case "Y"c, "y"c
                        Me._customBitPattern = CharacterPattern.Y
                    Case "-"c
                        Me._customBitPattern = CharacterPattern.Dash
                    Case "="c
                        Me._customBitPattern = CharacterPattern.Equals
                    Case "°"c
                        Me._customBitPattern = CharacterPattern.Degrees
                    Case "'"c
                        Me._customBitPattern = CharacterPattern.Apostrophe
                    Case """"c
                        Me._customBitPattern = CharacterPattern.Quote
                    Case "["c, "{"c
                        Me._customBitPattern = CharacterPattern.C
                    Case "]"c, "}"c
                        Me._customBitPattern = CharacterPattern.RBracket
                    Case "_"c
                        Me._customBitPattern = CharacterPattern.Underscore
                    Case "≡"c
                        Me._customBitPattern = CharacterPattern.Identical
                    Case "¬"c
                        Me._customBitPattern = CharacterPattern.Not
                End Select

            End If

        End Set
    End Property

    ''' <summary>
    ''' Legt ein benutzerdefiniertes Bitmuster fest, das in den sieben Segmenten angezeigt werden soll.<br/> 
    ''' Dies ist ein ganzzahliger Wert, bei dem die Bits 0 bis 6 den jeweiligen LED-Segmenten entsprechen.
    ''' </summary>
    <Category("Appearance")>
    <Description("Legt ein benutzerdefiniertes Bitmuster fest, das in den sieben Segmenten angezeigt werden soll.")>
    Public Property CustomBitPattern As Integer
        Get
            Return Me._customBitPattern
        End Get
        Set(value As Integer)
            Me._customBitPattern = value
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Gibt an, ob die Dezimalpunkt-LED angezeigt wird.
    ''' </summary>
    <Category("Appearance")>
    <Description("Gibt an, ob die Dezimalpunkt-LED angezeigt wird.")>
    Public Property ShowDecimalPoint As Boolean
        Get
            Return Me._showDecimalPoint
        End Get
        Set(value As Boolean)
            Me._showDecimalPoint = value
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Gibt an, ob die Dezimalpunkt-LED aktiv ist.
    ''' </summary>
    <Category("Appearance")>
    <Description("Gibt an, ob die Dezimalpunkt-LED aktiv ist.")>
    Public Property DecimalPointActive As Boolean
        Get
            Return Me._decimalPointActive
        End Get
        Set(value As Boolean)
            Me._decimalPointActive = value
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Gibt an, ob die Doppelpunkt-LEDs angezeigt werden.
    ''' </summary>
    <Category("Appearance")>
    <Description("Gibt an, ob die Doppelpunkt-LEDs angezeigt werden.")>
    Public Property ShowColon As Boolean
        Get
            Return Me._showColon
        End Get
        Set(value As Boolean)
            Me._showColon = value
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Gibt an, ob die Doppelpunkt-LEDs aktiv sind.
    ''' </summary>
    <Category("Appearance")>
    <Description("Gibt an, ob die Doppelpunkt-LEDs aktiv sind.")>
    Public Property ColonActive As Boolean
        Get
            Return Me._colonActive
        End Get
        Set(value As Boolean)
            Me._colonActive = value
            Me.Invalidate()
        End Set
    End Property

#End Region

#Region "geänderte Eigenschaften"

    ''' <summary>
    ''' Legt die Hintergrundfarbe des Controls fest oder gibt diese zurück.
    ''' </summary>
    ''' <returns></returns>
    <Category("Appearance")>
    <Description("Legt die Hintergrundfarbe des Controls fest oder gibt diese zurück.")>
    Public Overrides Property BackColor As Color
        Get
            Return Me._backgroundColor
        End Get
        Set(value As Color)
            Me._backgroundColor = value
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Legt die Vordergrundfarbe der Segmente des Controls fest oder gibt diese zurück.
    ''' </summary>
    ''' <returns></returns>
    <Category("Appearance")>
    <Description("Legt die Vordergrundfarbe der Segmente des Controls fest oder gibt diese zurück.")>
    Public Overrides Property ForeColor As Color
        Get
            Return Me._foreColor
        End Get
        Set(value As Color)
            Me._foreColor = value
            Me.Invalidate()
        End Set
    End Property

#End Region

#Region "Ausgeblendete Eigenschaften"

    ''' <summary>
    ''' Ausgeblendet da nicht relevant.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImage As Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Set(value As Image)
            MyBase.BackgroundImage = value
        End Set
    End Property

    ''' <summary>
    ''' Ausgeblendet da nicht relevant.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImageLayout As ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(value As ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set
    End Property

    ''' <summary>
    ''' Ausgeblendet da nicht relevant.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
        End Set
    End Property

    ''' <summary>
    ''' Ausgeblendet da nicht relevant.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
        End Set
    End Property

    ''' <summary>
    ''' Ausgeblendet da nicht relevant.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property RightToLeft As RightToLeft
        Get
            Return MyBase.RightToLeft
        End Get
        Set(value As RightToLeft)
            MyBase.RightToLeft = value
        End Set
    End Property

#End Region

#Region "interne Ereignisbehandlung"

    ''' <summary>
    ''' Tritt ein, wenn das Steuerelement neu gezeichnet wird.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SevSegsingleDigit_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim useValue = Me._customBitPattern
        Dim brushLight As Brush = New SolidBrush(Me._foreColor)
        Dim brushDark As Brush = New SolidBrush(Me._inactiveColor)

        'Definiert die Transformation für den Container ...
        Dim srcRect As RectangleF
        Dim colonWidth As Integer = CInt(Me._digitWidth / 4)

        srcRect = If(Me._showColon,
            New RectangleF(0.0F, 0.0F, Me._digitWidth + colonWidth, Me._digitHeight),
            New RectangleF(0.0F, 0.0F, Me._digitWidth, Me._digitHeight))

        Dim destRect As New RectangleF(
            Me.Padding.Left,
            Me.Padding.Top,
            Me.Width - Me.Padding.Left - Me.Padding.Right,
            Me.Height - Me.Padding.Top - Me.Padding.Bottom)

        'Grafikcontainer, der die Koordinaten neu zuordnet
        Dim containerState = e.Graphics.BeginContainer(destRect, srcRect, GraphicsUnit.Pixel)
        Dim trans As New Matrix()
        trans.Shear(Me._italicFactor, 0.0F)
        e.Graphics.Transform = trans
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.PixelOffsetMode = PixelOffsetMode.Default

        'Segmente zeichnen
        Me.PaintSegments(e, useValue, brushLight, brushDark, Me._segmentPoints)

        If Me._showDecimalPoint Then

            e.Graphics.FillEllipse(
                If(Me._decimalPointActive, brushLight, brushDark),
                Me._digitWidth - 1,
                Me._digitHeight - Me._segmentWidth + 1,
                Me._segmentWidth, Me._segmentWidth)

        End If

        If Me._showColon Then

            e.Graphics.FillEllipse(
                If(Me._colonActive, brushLight, brushDark),
                Me._digitWidth + colonWidth - 4,
                CInt((Me._digitHeight / 4) - Me._segmentWidth + 8),
                Me._segmentWidth, Me._segmentWidth)

            e.Graphics.FillEllipse(
                If(Me._colonActive, brushLight, brushDark),
                Me._digitWidth + colonWidth - 4,
                CInt((Me._digitHeight * 3 / 4) - Me._segmentWidth + 4),
                Me._segmentWidth, Me._segmentWidth)

        End If
        e.Graphics.EndContainer(containerState)

    End Sub

    ''' <summary>
    ''' Zeichnet die Segmente basierend darauf, ob das entsprechende Bit hoch ist
    ''' </summary>
    ''' <param name="e">
    ''' 
    ''' </param>
    ''' <param name="BitPattern">
    ''' Bitmuster
    ''' </param>
    ''' <param name="BrushLight">
    ''' Pinsel für aktives Segment
    ''' </param>
    ''' <param name="BrushDark">
    ''' Pinsel für inaktives Segment
    ''' </param>
    ''' <param name="SegmentPoints">
    ''' Eckpunkte der segmente
    ''' </param>
    Private Sub PaintSegments(
                             e As PaintEventArgs,
                             BitPattern As Integer,
                             BrushLight As Brush,
                             BrushDark As Brush,
                             ByRef SegmentPoints As Point()())

        e.Graphics.FillPolygon(
            If((BitPattern And &H1) = &H1, BrushLight, BrushDark),
            SegmentPoints(0))

        e.Graphics.FillPolygon(
            If((BitPattern And &H2) = &H2, BrushLight, BrushDark),
            SegmentPoints(1))

        e.Graphics.FillPolygon(
            If((BitPattern And &H4) = &H4, BrushLight, BrushDark),
            SegmentPoints(2))

        e.Graphics.FillPolygon(
            If((BitPattern And &H8) = &H8, BrushLight, BrushDark),
            SegmentPoints(3))

        e.Graphics.FillPolygon(
            If((BitPattern And &H10) = &H10, BrushLight, BrushDark),
            SegmentPoints(4))

        e.Graphics.FillPolygon(
            If((BitPattern And &H20) = &H20, BrushLight, BrushDark),
            SegmentPoints(5))

        e.Graphics.FillPolygon(
            If((BitPattern And &H40) = &H40, BrushLight, BrushDark),
            SegmentPoints(6))

    End Sub

    ''' <summary>
    ''' Tritt beim Ändern der Größe des Steuerelements ein.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SevSegSingleDigit_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Me.Invalidate()

    End Sub


#End Region

#Region "geänderte Methoden"

    ''' <summary>
    ''' Löst das PaddingChanged-Ereignis aus.
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnPaddingChanged(e As EventArgs)
        MyBase.OnPaddingChanged(e)
        Me.Invalidate()
    End Sub

    ''' <summary>
    ''' Zeichnet den Hintergrund des Steuerelements.
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        'MyBase.OnPaintBackground(e)
        e.Graphics.Clear(Me._backgroundColor)
    End Sub

    ''' <summary>
    ''' Gibt nicht verwaltete Ressourcen frei und führt andere Bereinigungsvorgänge durch, 
    ''' bevor die Component durch die Garbage Collection wieder zugänglich gemacht wird.
    ''' </summary>
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

#End Region

End Class
