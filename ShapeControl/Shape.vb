' ****************************************************************************************************************
' Shape.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


''' <summary>
''' Steuerelement zum Darstellen einer Linie, eines Rechtecks oder einer Ellipse.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<MyDescription("ClassDescription")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(Shape), "Shape.bmp")>
Public Class Shape


    Inherits Control


#Region "Definition der Variablen"

    ''' <summary>Wird vom Steuerelement-Designer benötigt.</summary>
    Private components As IContainer

    ''' <summary>Speichert die Art der Form die gezeichnet wird.</summary>
    Private _ShapeModus As ShapeModes

    ''' <summary>Speichert die Breite der Linien.</summary>
    Private _LineWidth As Single

    ''' <summary>Speichert die Linienfarbe.</summary>
    Private _LineColor As Color

    ''' <summary>Speichert die Füllfarbe.</summary>
    Private _FillColor As Color

    ''' <summary>Speichert die Art wie eine diagonale Linie gezeichnet wird.</summary>
    Private _DiagonalLineModus As DiagonalLineModes

#End Region


    Public Sub New()

        'Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        'Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.InitializeVariables()
        Me.InitializeStyles()

    End Sub


#Region "neue Eigenschaften"


    ''' <summary>
    ''' Legt die anzuzeigende Form fest oder gibt diese zurück.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("ShapeModusDescription")>
    Public Property ShapeModus() As ShapeModes
        Get
            Return Me._ShapeModus
        End Get
        Set(value As ShapeModes)
            Me._ShapeModus = value
            Me.RecreateHandle()
        End Set
    End Property


    ''' <summary>
    ''' Legt die Breite der Linie oder Rahmenlinie fest oder gibt diese zurück.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("LineWidthDescription")>
    Public Property LineWidth() As Single
        Get
            Return Me._LineWidth
        End Get
        Set(value As Single)
            Me._LineWidth = value
            Me.RecreateHandle()
        End Set
    End Property


    ''' <summary>
    ''' Legt die Farbe der Linie oder Rahmenlinie fest oder gibt diese zurück.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("LineColorDescription")>
    Public Property LineColor() As Color
        Get
            Return Me._LineColor
        End Get
        Set(value As Color)
            Me._LineColor = value
            Me.RecreateHandle()
        End Set
    End Property


    ''' <summary>
    ''' Legt die Füllfarbe für die Form fest oder gibt diese zurück.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("FillColorDescription")>
    Public Property FillColor() As Color
        Get
            Return Me._FillColor
        End Get
        Set(value As Color)
            Me._FillColor = value
            Me.RecreateHandle()
        End Set
    End Property


    ''' <summary>
    ''' Legt fest ob eine diagonale Linie von links oben nach rechts unten oder 
    ''' umgekehrt verläuft oder gibt dieses zurück.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("DiagonalLineModusDescription")>
    Public Property DiagonalLineModus() As DiagonalLineModes
        Get
            Return Me._DiagonalLineModus
        End Get
        Set(value As DiagonalLineModes)
            Me._DiagonalLineModus = value
            Me.RecreateHandle()
        End Set
    End Property


#End Region


#Region "überschriebene Eigenschften"

    ''' <summary>
    ''' Legt spezielle Parameter für das ShapeControl fest
    ''' </summary>
    ''' <remarks>
    ''' https://stackoverflow.com/questions/511320/transparent-control-backgrounds-on-a-vb-net-gradient-filled-form
    ''' </remarks>
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            'WS EX TRANSPARENT aktivieren
            'https://learn.microsoft.com/en-us/windows/win32/winmsg/extended-window-styles
            cp.ExStyle = cp.ExStyle Or &H20
            Return cp
        End Get
    End Property

#End Region


#Region "ausgeblendete Eigenschaften"


    ''' <summary>
    ''' Hintergrundfarbe (nicht relevant für dieses Control)
    ''' </summary>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
        End Set
    End Property


    ''' <summary>
    ''' Hintergrundbild (nicht relevant für dieses Control)
    ''' </summary>
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
    ''' Layout Hintergrundbild (nicht relevant für dieses Control)
    ''' </summary>
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
    ''' Schriftart (nicht relevant für dieses Control)
    ''' </summary>
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
    ''' Vordergrundfarbe (nicht relevant für dieses Control)
    ''' </summary>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(value As Color)
            MyBase.ForeColor = value
        End Set
    End Property


    ''' <summary>
    ''' Rechts - Links Schreibweise (nicht relevant für dieses Control)
    ''' </summary>
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


    ''' <summary>
    ''' Text (nicht relevant für dieses Control)
    ''' </summary>
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


#End Region


    ''' <summary>
    ''' zeichnet das ShapeControl neu
    ''' </summary>
    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)

        Dim g As Graphics = Me.CreateGraphics

        'Benutzerdefinierten Zeichnungscode hier einfügen
        Select Case Me._ShapeModus

            Case ShapeModes.HorizontalLine
                'horizontale Linie zeichnen (mittig im Rahmen des Controls)
                g.DrawLine(New Pen(Me._LineColor, Me._LineWidth),
                           0,
                           CInt(Me.Height / 2),
                           Me.Width,
                           CInt(Me.Height / 2))

            Case ShapeModes.VerticalLine
                'vertikale Linie zeichnen (mittig im Rahmen des Controls)
                g.DrawLine(New Pen(Me._LineColor, Me._LineWidth),
                           CInt(Me.Width / 2),
                           0,
                           CInt(Me.Width / 2),
                           Me.Height)

            Case ShapeModes.DiagonalLine
                'diagonale Linie zeichnen
                Select Case Me._DiagonalLineModus

                    Case DiagonalLineModes.BottomLeftToTopRight
                        'von links unten nach rechts oben
                        g.DrawLine(New Pen(Me._LineColor, Me._LineWidth),
                                   0,
                                   Me.Height,
                                   Me.Width,
                                   0)

                    Case DiagonalLineModes.TopLeftToBottomRight
                        'von links oben nach rechts unten
                        g.DrawLine(New Pen(Me._LineColor, Me._LineWidth),
                                   0,
                                   0,
                                   Me.Width,
                                   Me.Height)

                End Select

            Case ShapeModes.Rectangle
                'einfaches Rechteck zeichnen
                g.DrawRectangle(
                    New Pen(Me._LineColor, Me._LineWidth),
                    Me._LineWidth / 2,
                    Me._LineWidth / 2,
                    Me.Width - Me._LineWidth,
                    Me.Height - Me._LineWidth)

            Case ShapeModes.FilledRectangle
                'einfaches Rechteck zeichnen
                g.DrawRectangle(
                    New Pen(Me._LineColor, Me._LineWidth),
                    Me._LineWidth / 2,
                    Me._LineWidth / 2,
                    Me.Width - Me._LineWidth,
                    Me.Height - Me._LineWidth)

                'Rechteck ausfüllen
                g.FillRectangle(New SolidBrush(Me._FillColor),
                               Me._LineWidth,
                               Me._LineWidth,
                               Me.Width - (2 * Me._LineWidth),
                               Me.Height - (2 * Me._LineWidth))

            Case ShapeModes.Elypse
                'einfache Ellipse zeichnen
                g.DrawEllipse(
                    New Pen(Me._LineColor, Me._LineWidth),
                    Me._LineWidth / 2,
                    Me._LineWidth / 2,
                    Me.Width - Me._LineWidth,
                    Me.Height - Me._LineWidth)

            Case ShapeModes.FilledElypse
                'einfache Ellipe zeichnen
                g.DrawEllipse(
                    New Pen(Me._LineColor, Me._LineWidth),
                    Me._LineWidth / 2,
                    Me._LineWidth / 2,
                    Me.Width - Me._LineWidth,
                    Me.Height - Me._LineWidth)

                'Ellipse ausfüllen
                g.FillEllipse(New SolidBrush(Me._FillColor),
                              Me._LineWidth,
                              Me._LineWidth,
                              Me.Width - (2 * Me._LineWidth),
                              Me.Height - (2 * Me._LineWidth))

        End Select

    End Sub


    ''' <summary>
    ''' Das Steuerelement überschreibt den Löschvorgang zum Bereinigen der Komponentenliste.
    ''' </summary>
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso Me.components IsNot Nothing Then
                Me.components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    ''' <summary>
    ''' Initialisiert die Standardwerte für das ShapeControl
    ''' </summary>
    Private Sub InitializeVariables()

        'Horizontale Linie
        Me._ShapeModus = ShapeModes.HorizontalLine

        'diagonale Linie von links oben nach rechts unten
        Me._DiagonalLineModus = DiagonalLineModes.TopLeftToBottomRight

        'schwarze Linie für Linie und Rahmenlinie bei Ellipse und Rechteck
        Me._LineColor = Color.Black

        'Breite der Linie
        Me._LineWidth = 2

        'Füllfarbe für Ellipse und Rechteck
        Me._FillColor = Color.Gray

    End Sub


    ''' <summary>
    ''' Initialisiert die Styles für das ShapeControl
    ''' </summary>
    Private Sub InitializeStyles()

        Me.SetStyle(ControlStyles.Opaque, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, False)

    End Sub


    ''' <summary>
    ''' Hinweis: Die folgende Prozedur ist für den Komponenten-Designer erforderlich.
    ''' Sie kann mit dem Komponenten-Designer geändert werden.
    ''' Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    ''' </summary>
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
    End Sub


End Class
