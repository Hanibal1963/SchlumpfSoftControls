' ****************************************************************************************************************
' AniGif.vb
' © 2023 - 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Windows.Forms

''' <summary>
''' Control zum anzeigen von animierten Grafiken.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum Anzeigen von animierten Grafiken.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(AniGif), "AniGif.bmp")>
Public Class AniGif : Inherits UserControl

    Implements IDisposable

#Region "Definition der Variablen"

    Private WithEvents Timer As Timer
    Private components As IContainer
    Private _Gif As Bitmap
    Private _GifSizeMode As SizeMode
    Private _CustomDisplaySpeed As Boolean
    Private _FramesPerSecond As Decimal
    Private _Dimension As FrameDimension
    Private _Frame As Integer
    Private _MaxFrame As Integer
    Private _Autoplay As Boolean
    Private _ZoomFactor As Decimal

#End Region

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
            Return Me._Autoplay
        End Get
        Set(value As Boolean)
            Me._Autoplay = value
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
            Return Me._Gif
        End Get
        Set(value As Bitmap)
            Me._Gif = If(value, My.Resources.Standard) 'Standardanimation verwenden wenn keine Auswahl erfolgte
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
            Return Me._GifSizeMode
        End Get
        Set(value As SizeMode)
            Me._GifSizeMode = value
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
            Return Me._CustomDisplaySpeed
        End Get
        Set(value As Boolean)
            Me._CustomDisplaySpeed = value
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
            Return Me._FramesPerSecond
        End Get
        Set(value As Decimal)
            Me._FramesPerSecond = Me.CheckFramesPerSecondValue(value)
            Me.Timer.Interval = CInt(1000 / Me._FramesPerSecond)
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
            Return Me._ZoomFactor
        End Get
        Set(value As Decimal)
            Me._ZoomFactor = Me.CheckZoomFactorValue(value)
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
        Me.InitializeStyles() 'Stil und Verhalten des Steuerelements festlegen
        Me.InitializeValues() 'Standardwerte laden

    End Sub

    Protected Overloads Overrides Sub InitLayout()

        MyBase.InitLayout()
        ' Animation starten wenn nicht im Desigmodus und AutoPlay auf True
        If Not Me.DesignMode And ImageAnimator.CanAnimate(Me._Gif) Then
            ImageAnimator.Animate(Me._Gif, AddressOf Me.OnNextFrame)
        End If

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)
        'Variable für Zeichenfläche
        Dim g As Graphics = e.Graphics
        'Größe der Zeichenfläche berechnen
        Dim rectstartsize As Size = Me.GetRectStartSize(
            Me._GifSizeMode, Me, Me._Gif, Me._ZoomFactor / 100)
        'Startpunkt der Zeichenfläche berechnen
        Dim rectstartpoint As Point = Me.GetRectStartPoint(
            Me._GifSizeMode, Me, Me._Gif, rectstartsize)
        'Zeichenfläche festlegen und Bild zeichnen
        g.DrawImage(Me._Gif, New Rectangle(rectstartpoint, rectstartsize))
        'Bild animieren wenn AutoPlay aktiv und Benutzerdefinierte Geschwindigkeit deaktiviert
        If Not Me.DesignMode And Me.AutoPlay And Not Me.CustomDisplaySpeed Then
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
            If Me._Gif IsNot Nothing Then
                Me._Gif.Dispose()
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
        If ImageAnimator.CanAnimate(Me._Gif) = False And Me.AutoPlay = True Then
            'Timer stoppen und Anzahl der Frames auf 0 setzen (für nicht animiertes bild)
            Me.Timer.Stop()
            Me._MaxFrame = 0
            'Ereignis auslösen
            RaiseEvent NoAnimation(Me, EventArgs.Empty)

        Else
            'Werte für Benutzerdefinierte Geschwindigkeit speichern
            Me._Dimension = New FrameDimension(Me._Gif.FrameDimensionsList(0))
            Me._MaxFrame = Me._Gif.GetFrameCount(Me._Dimension) - 1
            Me._Frame = 0
            'Timer starten
            If Me._CustomDisplaySpeed Then Me.Timer.Start()

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

        Me.Timer.Enabled = Me._CustomDisplaySpeed
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
            If Me._MaxFrame = 0 Then Exit Sub
            'Bildzähler zurücksetzen wenn maximale Anzahl überschritten
            If Me._Frame > Me._MaxFrame Then Me._Frame = 0
            'nächstes Bild auswählen
            Dim unused = Me._Gif.SelectActiveFrame(Me._Dimension, Me._Frame)
            'Bildzähler weiterschalten
            Me._Frame += 1
            'neu zeichnen
            Me.Invalidate()

        End If

    End Sub

#End Region

#Region "interne Funktionen"

    ''' <summary>
    ''' Initialisiert die Komponenten dieser Klasse
    ''' </summary>
    Private Sub InitializeComponent()

        Me.components = New Container()
        Me.Timer = New Timer(Me.components)
        Me.SuspendLayout()
        'Timer
        Me.Timer.Interval = 200
        'AniGif
        Me.Name = "AniGif"
        Me.ResumeLayout(False)

    End Sub

    ''' <summary>
    ''' Initialisiert die Controlstyles dieses Controls
    ''' </summary>
    Private Sub InitializeStyles()

        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

    End Sub

    ''' <summary>
    ''' Stellt die Variablen mit den Startbedingungen ein.
    ''' </summary>
    Private Sub InitializeValues()

        Me._Gif = My.Resources.Standard 'Standardanimation laden
        Me._Autoplay = False 'Standardeinstellung für AutoPlay
        Me._GifSizeMode = SizeMode.Normal 'Standarddarstellung für Grafik
        Me._CustomDisplaySpeed = False
        Me._FramesPerSecond = 10
        Me._ZoomFactor = 50  'Standardeinstellung für Zoomfaktor

    End Sub

    ''' <summary>
    ''' Prüft den Wert für Bilder/Sekunde
    ''' </summary>
    ''' <param name="Frames"></param>
    Private Function CheckFramesPerSecondValue(Frames As Decimal) As Decimal

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
    Private Function CheckZoomFactorValue(ZoomFactor As Decimal) As Decimal

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
    Private Function GetRectStartSize(
                     Mode As SizeMode,
                     Control As AniGif,
                     Gif As Bitmap,
                     Zoom As Decimal) As Size

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
    Private Function GetRectStartPoint(
                     Mode As SizeMode,
                     Control As AniGif,
                     Gif As Bitmap,
                     RectStartSize As Size) As Point

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

#End Region

End Class

