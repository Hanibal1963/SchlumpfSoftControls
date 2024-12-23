' ****************************************************************************************************************
' AniGif.vb
' © 2023 - 2024 by Andreas Sauer
' ****************************************************************************************************************
'
' weitere Infos:
' <Browsable> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.browsableattribute?view=netframework-4.7.2
' <Category> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.categoryattribute?view=netframework-4.7.2
' <Description> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.descriptionattribute?view=netframework-4.7.2

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports SchlumpfSoft.Attribute

''' <summary>
''' Control zum anzeigen von animierten Grafiken.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum Anzeigen von animierten Grafiken.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(AniGif), "AniGif.bmp")>
Public Class AniGif

    Inherits UserControl

    Implements IDisposable
    Private WithEvents Timer As Timer
    Private components As IContainer

#Region "Ereignisdefinitionen"

    ''' <summary>
    ''' Wird ausgelöst wenn die Grafik nicht animiert werden kann.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Wird ausgelöst wenn die Grafik nicht animiert werden kann.")>
    Public Event NoAnimation(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Wird ausgelöst wenn sich das Bild geändert hat.
    ''' </summary>
    Private Event GifChanged()

    ''' <summary>
    ''' Wird ausgelöst wenn sich die Anzeigegeschwindigkeit geändert hat.
    ''' </summary>
    Private Event CustomDisplaySpeedChanged()

#End Region

#Region "neue Eigenschaften"

    ''' <summary>
    ''' Legt fest ob die Animation sofort nach dem laden gestartet wird.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt fest ob die Animation sofort nach dem laden gestartet wird.")>
    Public Property AutoPlay() As Boolean
        Get
            Return VariableDefinitions.Autoplay
        End Get
        Set(value As Boolean)
            VariableDefinitions.Autoplay = value
        End Set
    End Property

    ''' <summary>
    ''' Gibt die animierte Gif-Grafik zurück oder legt diese fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt die animierte Gif-Grafik zurück oder legt diese fest.")>
    Public Property Gif() As Bitmap
        Get
            Return VariableDefinitions.Gif
        End Get
        Set(value As Bitmap)
            VariableDefinitions.Gif = If(value, My.Resources.Standard) 'Standardanimation verwenden wenn keine Auswahl erfolgte
            RaiseEvent GifChanged()
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.")>
    Public Property GifSizeMode() As SizeMode
        Get
            Return VariableDefinitions.GifSizeMode
        End Get
        Set(value As SizeMode)
            VariableDefinitions.GifSizeMode = value
            Me.Invalidate()
        End Set
    End Property

    ''' <summary>
    ''' Legt fest ob die benutzerdefinierte Anzeigegeschwindigkeit oder <br/> 
    ''' die in der Datei festgelegte Geschwindigkeit benutzt wird.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt fest ob die benutzerdefinierte Anzeigegeschwindigkeit oder die in der Datei festgelegte Geschwindigkeit benutzt wird.")>
    Public Property CustomDisplaySpeed As Boolean
        Get
            Return VariableDefinitions.CustomDisplaySpeed
        End Get
        Set(value As Boolean)
            VariableDefinitions.CustomDisplaySpeed = value
            RaiseEvent CustomDisplaySpeedChanged()
        End Set
    End Property

    ''' <summary>
    ''' Legt die benutzerdefinierte Anzeigegeschwindigkeit in Bildern/Sekunde fest.
    ''' </summary>
    ''' <remarks>
    ''' Bewirkt nur eine Änderung wenn <seealso cref="CustomDisplaySpeed"/> auf True festgelegt ist.
    ''' </remarks>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt die benutzerdefinierte Anzeigegeschwindigkeit in Bildern/Sekunde fest wenn CustomDisplaySpeed auf True festgelegt ist.")>
    Public Property FramesPerSecond As Decimal
        Get
            Return VariableDefinitions.FramesPerSecond
        End Get
        Set(value As Decimal)
            VariableDefinitions.FramesPerSecond = CheckFramesPerSecondValue(value)
            Me.Timer.Interval = CInt(1000 / VariableDefinitions.FramesPerSecond)
        End Set
    End Property

    ''' <summary>
    ''' Legt den Zoomfaktor fest. 
    ''' </summary>
    ''' <remarks>
    ''' Bewirkt nur eine Änderung wenn <seealso cref="GifSizeMode"/> auf <seealso cref="SizeMode.Zoom"/> festgelegt ist.
    ''' </remarks>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt den Zoomfaktor fest wenn GifSizeMode auf Zoom festgelegt ist.")>
    Public Property ZoomFactor As Decimal
        Get
            Return VariableDefinitions.ZoomFactor
        End Get
        Set(value As Decimal)
            VariableDefinitions.ZoomFactor = CheckZoomFactorValue(value)
            Me.Invalidate() 'neu zeichnen
        End Set
    End Property

#End Region

#Region "ausgeblendete Eigenschaften"

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property MaximumSize As Size
        Get
            Return MyBase.MaximumSize
        End Get
        Set(value As Size)
            MyBase.MaximumSize = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property MinimumSize As Size
        Get
            Return MyBase.MinimumSize
        End Get
        Set(value As Size)
            MyBase.MinimumSize = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overloads Property Padding As Padding
        Get
            Return MyBase.Padding
        End Get
        Set(value As Padding)
            MyBase.Padding = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property RightToLeft() As RightToLeft
        Get
            Return MyBase.RightToLeft
        End Get
        Set(value As RightToLeft)
            MyBase.RightToLeft = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property Text() As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            MyBase.Text = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property AllowDrop() As Boolean
        Get
            Return MyBase.AllowDrop
        End Get
        Set(value As Boolean)
            MyBase.AllowDrop = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property AutoScrollOffset As Point
        Get
            Return MyBase.AutoScrollOffset
        End Get
        Set(value As Point)
            MyBase.AutoScrollOffset = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(value As Boolean)
            MyBase.AutoSize = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImage() As Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Set(value As Image)
            MyBase.BackgroundImage = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImageLayout() As ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(value As ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property ContextMenuStrip() As ContextMenuStrip
        Get
            Return MyBase.ContextMenuStrip
        End Get
        Set(value As ContextMenuStrip)
            MyBase.ContextMenuStrip = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property Dock() As DockStyle
        Get
            Return MyBase.Dock
        End Get
        Set(value As DockStyle)
            MyBase.Dock = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property Font() As Font
        Get
            Return MyBase.Font
        End Get
        Set(value As Font)
            MyBase.Font = value
        End Set
    End Property

    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property ForeColor() As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
        End Set
    End Property

#End Region

    Public Sub New()

        Me.InitializeComponent()
        InitializeValues() 'Standardwerte laden

    End Sub

    Private Sub InitializeComponent()

        Me.components = New Container()
        Me.Timer = New Timer(Me.components)
        Me.SuspendLayout()
        'Timer
        Me.Timer.Interval = 200
        'AniGif
        Me.Name = "AniGif"
        Me.ResumeLayout(False)
        ' Initialisiert die Controlstyles dieses Controls
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

    End Sub

    Protected Overloads Overrides Sub InitLayout()

        MyBase.InitLayout()
        ' Animation starten wenn nicht im Desigmodus und AutoPlay auf True
        If Not Me.DesignMode And ImageAnimator.CanAnimate(VariableDefinitions.Gif) Then
            ImageAnimator.Animate(VariableDefinitions.Gif, AddressOf Me.OnNextFrame)
        End If

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)

        'Variable für Zeichenfläche
        Dim g As Graphics = e.Graphics

        'Größe der Zeichenfläche berechnen
        Dim rectstartsize As Size = GetRectStartSize(
            VariableDefinitions.GifSizeMode, Me, VariableDefinitions.Gif, VariableDefinitions.ZoomFactor / 100)

        'Startpunkt der Zeichenfläche berechnen
        Dim rectstartpoint As Point = GetRectStartPoint(
            VariableDefinitions.GifSizeMode, Me, VariableDefinitions.Gif, rectstartsize)

        'Zeichenfläche festlegen und Bild zeichnen
        g.DrawImage(VariableDefinitions.Gif, New Rectangle(rectstartpoint, rectstartsize))

        'Bild animieren wenn AutoPlay aktiv und Benutzerdefinierte Geschwindigkeit deaktiviert
        If Not Me.DesignMode And VariableDefinitions.Autoplay And Not VariableDefinitions.CustomDisplaySpeed Then

            'im Bild gespeicherte Geschwindigkeit verwenden
            ImageAnimator.UpdateFrames()

        End If

    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)

        If disposing Then

            If Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If

            If Me.Timer IsNot Nothing Then
                Me.Timer.Dispose()
            End If

            If VariableDefinitions.Gif IsNot Nothing Then
                VariableDefinitions.Gif.Dispose()
            End If

        End If

        MyBase.Dispose(disposing)

    End Sub

#Region "interne Ereignisbehandlungen"

    ''' <summary>
    ''' Wird ausgeführt wenn das Bild gewechselt wurde.
    ''' </summary>
    Private Sub AniGif_GifChange() Handles Me.GifChanged

        'überprüfen ob das Bild animiert werden kann wenn Autoplay auf True gesetzt ist
        If ImageAnimator.CanAnimate(VariableDefinitions.Gif) = False And VariableDefinitions.Autoplay = True Then
            'Timer stoppen und Anzahl der Frames auf 0 setzen (für nicht animiertes bild)
            Me.Timer.Stop()
            MaxFrame = 0
            'Ereignis auslösen
            RaiseEvent NoAnimation(Me, EventArgs.Empty)

        Else
            'Werte für Benutzerdefinierte Geschwindigkeit speichern
            Dimension = New FrameDimension(VariableDefinitions.Gif.FrameDimensionsList(0))
            MaxFrame = VariableDefinitions.Gif.GetFrameCount(Dimension) - 1
            Frame = 0
            'Timer starten
            If VariableDefinitions.CustomDisplaySpeed Then Me.Timer.Start()

        End If

        'neu zeichnen
        Me.Invalidate()

        'Animation starten
        Me.InitLayout()

    End Sub

    ''' <summary>
    ''' Wird ausgeführt wenn die benutzerdefinierte Anzeigegeschwindigkeit ein oder ausgeschaltet wurde
    ''' </summary>
    Private Sub AniGif_CustomDisplaySpeedChanged() Handles Me.CustomDisplaySpeedChanged

        Me.Timer.Enabled = VariableDefinitions.CustomDisplaySpeed
        If Me.Timer.Enabled Then
            Me.Timer.Start()
        Else
            Me.Timer.Stop()
        End If

    End Sub

    ''' <summary>
    ''' Wird ausgeführt wenn das nächste Teilbild angezeigt werden soll.
    ''' </summary>
    Private Sub OnNextFrame(o As Object, e As EventArgs)

        If Me.AutoPlay AndAlso Not Me.DesignMode Then
            Me.Invalidate() 'neu zeichnen
        End If

    End Sub

    ''' <summary>
    ''' wird ausgeführt wenn die Anzeigezeit abgelaufen ist.
    ''' </summary>
    Private Sub Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        'Bild animieren wenn AutoPlay und Benutzerdefinierte Geschwindigkeit aktiv
        If Not Me.DesignMode AndAlso Me.AutoPlay Then

            'wenn Frames = 0 ist das Bild nicht animiert -> Ende
            If MaxFrame = 0 Then Exit Sub

            'Bildzähler zurücksetzen wenn maximale Anzahl überschritten
            If Frame > MaxFrame Then Frame = 0

            'nächstes Bild auswählen
            Dim unused = VariableDefinitions.Gif.SelectActiveFrame(Dimension, Frame)

            'Bildzähler weiterschalten
            Frame += 1

            'neu zeichnen
            Me.Invalidate()

        End If

    End Sub

#End Region

End Class

