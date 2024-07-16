' ****************************************************************************************************************
' SevSegMultiDigit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description(SevSegMultiDigit_Description)>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(SevSegMultiDigit), "SevSegMultiDigit.bmp")>
Public Class SevSegMultiDigit

    Inherits Control

#Region "Eigenschaftsvariablen"

    ''' <summary>
    ''' Array von Segmentsteuerelementen, die derzeit untergeordnete Elemente dieses Steuerelements sind.
    ''' </summary>
    Private _digits As SevSegSingleDigit() = Nothing

    ''' <summary>
    ''' Breite der Segmente eines Digits
    ''' </summary>
    Private _segmentWidth As Integer = 10

    ''' <summary>
    ''' Scherkoeffizient
    ''' </summary>
    Private _italicFactor As Single = -0.1F

    ''' <summary>
    ''' Hintergrundfarbe
    ''' </summary>
    Private _backgroundColor As Color = Color.LightGray

    ''' <summary>
    ''' Farbe für inaktives Segment
    ''' </summary>
    Private _inactiveColor As Color = Color.DarkGray

    ''' <summary>
    ''' Vordergrundfarbe
    ''' </summary>
    Private _foreColor As Color = Color.DarkGreen

    ''' <summary>
    ''' Dezimalpunkt anzeigen
    ''' </summary>
    Private _showDecimalPoint As Boolean = True

    ''' <summary>
    ''' 
    ''' </summary>
    Private _digitPadding As Padding

    ''' <summary>
    ''' anzuzeigender Wert
    ''' </summary>
    Private _value As String = Nothing

#End Region

    ''' <summary>
    ''' Wird ausgeführt wenn eine neue Instanz dieses Controls erstellt wird.
    ''' </summary>
    Public Sub New()

        Me.SuspendLayout()
        Me.Name = "SevSegMultiDigit"
        Me.Size = New Size(100, 25)
        AddHandler Resize, New EventHandler(AddressOf Me.SevSegMultiDigit_Resize)
        Me.ResumeLayout(False)
        Me.TabStop = False
        Me._digitPadding = New Padding(10, 4, 10, 4)
        Me.CreateSegments(4)

    End Sub

#Region "interne Methoden"

    ''' <summary>
    ''' Ändert die Anzahl der Elemente im LED-Array. 
    ''' Dadurch werden die vorherigen Elemente zerstört und an ihrer Stelle neue erstellt, 
    ''' wobei alle aktuellen Optionen auf die neuen angewendet werden.
    ''' </summary>
    ''' <param name="count">
    ''' Anzahl der zu erstellenden Elemente.
    ''' </param>
    Private Sub CreateSegments(count As Integer)

        If Me._digits IsNot Nothing Then

            For i = 0 To Me._digits.Length - 1
                Me._digits(i).Parent = Nothing
                Me._digits(i).Dispose()
            Next

        End If

        If count <= 0 Then Return
        Me._digits = New SevSegSingleDigit(count - 1) {}

        For i = 0 To count - 1

            Me._digits(i) = New SevSegSingleDigit With {
                .Parent = Me,
                .Top = 0,
                .Height = Me.Height,
                .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom,
                .Visible = True
            }

        Next

        Me.ResizeSegments()
        Me.UpdateSegments()
        Me.Value = Me._value

    End Sub

    ''' <summary>
    ''' Richtet die Elemente des Arrays so aus, 
    ''' dass sie genau in die Breite des übergeordneten Steuerelements passen.
    ''' </summary>
    Private Sub ResizeSegments()

        Dim segWidth As Integer = CInt(Me.Width / Me._digits.Length)

        For i = 0 To Me._digits.Length - 1

            Me._digits(i).Left = CInt(Me.Width * (Me._digits.Length - 1 - i) / Me._digits.Length)
            Me._digits(i).Width = segWidth

        Next

    End Sub

    ''' <summary>
    ''' Aktualisiert die Eigenschaften jedes Elements mit den Eigenschaften
    ''' we have stored.
    ''' </summary>
    Private Sub UpdateSegments()

        For i = 0 To Me._digits.Length - 1

            Me._digits(i).BackColor = Me._backgroundColor
            Me._digits(i).InactiveColor = Me._inactiveColor
            Me._digits(i).ForeColor = Me._foreColor
            Me._digits(i).SegmentWidth = Me._segmentWidth
            Me._digits(i).ItalicFactor = Me._italicFactor
            Me._digits(i).ShowDecimalPoint = Me._showDecimalPoint
            Me._digits(i).Padding = Me._digitPadding

        Next

    End Sub

    Private Sub SevSegMultiDigit_Resize(sender As Object, e As EventArgs)
        Me.ResizeSegments()
    End Sub

#End Region

#Region "neue Eigenschaften"

    ''' <summary>
    ''' Legt die Farbe inaktiver Segmente fest oder gibt diese zurück.
    ''' </summary>
    <Category(Category_Appearance)>
    <Description(InactiveColor_Description)>
    Public Property InactiveColor As Color
        Get
            Return Me._inactiveColor
        End Get
        Set(value As Color)
            Me._inactiveColor = value
            Me.UpdateSegments()
        End Set
    End Property

    ''' <summary>
    ''' Legt die Breite der LED-Segmente fest oder gibt diese zurück.
    ''' </summary>
    <Category(Category_Appearance)>
    <Description(SegmentWidth_Description)>
    Public Property SegmentWidth As Integer
        Get
            Return Me._segmentWidth
        End Get
        Set(value As Integer)
            Me._segmentWidth = value
            Me.UpdateSegments()
        End Set
    End Property

    ''' <summary>
    ''' Scherkoeffizient für die Kursivschrift der Anzeige.
    ''' </summary>
    ''' <remarks>
    ''' Standardwert ist -0.1
    ''' </remarks>
    <Category(Category_Appearance)>
    <Description(ItalicFactor_Description)>
    Public Property ItalicFactor As Single
        Get
            Return Me._italicFactor
        End Get
        Set(value As Single)
            Me._italicFactor = value
            Me.UpdateSegments()
        End Set
    End Property

    ''' <summary>
    ''' Gibt an, ob die Dezimalpunkt-LED angezeigt wird.
    ''' </summary>
    <Category(Category_Appearance)>
    <Description(ShowDecimalPoint_Description)>
    Public Property ShowDecimalPoint As Boolean
        Get
            Return Me._showDecimalPoint
        End Get
        Set(value As Boolean)
            Me._showDecimalPoint = value
            Me.UpdateSegments()
        End Set
    End Property

    ''' <summary>
    ''' Anzahl der Digits in diesem Control.
    ''' </summary>
    <Category(Category_Appearance)>
    <Description(DigitCount_Description)>
    Public Property DigitCount As Integer
        Get
            Return Me._digits.Length
        End Get
        Set(value As Integer)
            If value > 0 AndAlso value <= 100 Then Me.CreateSegments(value)
        End Set
    End Property

    ''' <summary>
    ''' Auffüllung, die für jedes Digit im Control gilt. 
    ''' </summary>
    ''' <remarks>
    ''' Passen Sie diese Zahlen an, um das perfekte Erscheinungsbild für das Control Ihrer Größe zu erhalten.
    ''' </remarks>
    <Category(Category_Appearance)>
    <Description(DigitPadding_Description)>
    Public Property DigitPadding As Padding
        Get
            Return Me._digitPadding
        End Get
        Set(value As Padding)
            Me._digitPadding = value
            Me.UpdateSegments()
        End Set
    End Property

    ''' <summary>
    ''' Der auf dem Control anzuzeigende Wert. 
    ''' </summary>
    ''' <remarks>
    ''' Kann Zahlen, bestimmte Buchstaben und Dezimalpunkte enthalten.
    ''' </remarks>
    <Category(Category_Appearance)>
    <Description(Value_Description)>
    Public Property Value As String
        Get
            Return Me._value
        End Get
        Set(value As String)
            Me._value = value
            For i = 0 To Me._digits.Length - 1
                Me._digits(i).CustomBitPattern = 0
                Me._digits(i).DecimalPointActive = False
            Next
            If Not Equals(Me._value, Nothing) Then
                Dim segmentIndex = 0
                For i = Me._value.Length - 1 To 0 Step -1
                    If segmentIndex >= Me._digits.Length Then Exit For
                    If Me._value(i) = "."c Then
                        Me._digits(segmentIndex).DecimalPointActive = True
                    Else
                        Me._digits(Math.Min(Threading.Interlocked.Increment(segmentIndex), segmentIndex - 1)).DigitValue = Me._value(i).ToString()
                    End If
                Next
            End If
        End Set
    End Property

#End Region

#Region "geänderte Eigenschaften"

    ''' <summary>
    ''' Legt die Hintergrundfarbe des Controls fest oder gibt diese zurück.
    ''' </summary>
    ''' <returns></returns>
    <Category(Category_Appearance)>
    <Description(BackColor_Description)>
    Public Overrides Property BackColor As Color
        Get
            Return Me._backgroundColor
        End Get
        Set(value As Color)
            Me._backgroundColor = value
            Me.UpdateSegments()
        End Set
    End Property

    ''' <summary>
    ''' Legt die Vordergrundfarbe der Segmente des Controls fest oder gibt diese zurück.
    ''' </summary>
    ''' <returns></returns>
    <Category(Category_Appearance)>
    <Description(ForeColor_Description)>
    Public Overrides Property ForeColor As Color
        Get
            Return Me._foreColor
        End Get
        Set(value As Color)
            Me._foreColor = value
            Me.UpdateSegments()
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

#Region "geänderte Methoden"

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        e.Graphics.Clear(Me._backgroundColor)
    End Sub

#End Region

End Class
