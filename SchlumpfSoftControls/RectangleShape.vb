'
'****************************************************************************************************************
'RectangleChape.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms


''' <summary>
''' Control zum darstellen eines Rechtecks.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum darstellen eines Rechtecks.")>
<ToolboxItem(True)>
Public Class RectangleShape : Inherits Control


	Private _fillColor1 As Color = Color.White
	Private _fillColor2 As Color = Color.Black
	Private _fillStyle As FillStyles = FillStyles.None
	Private _borderlineWidth As Integer = 1
	Private _borderlineColor As Color = Color.Black



#Region "Aufzählungen"

	''' <summary>
	''' Gibt den Füllstyle an.
	''' </summary>
	Public Enum FillStyles

		''' <summary>
		''' keine Füllung
		''' </summary>
		None = 0

		''' <summary>
		''' Einfarbige Füllung
		''' </summary>
		Solid = 1

		'weitere Literatur:
		'https://learn.microsoft.com/de-de/dotnet/api/system.drawing.drawing2d.lineargradientmode?view=netframework-4.7.2

		''' <summary>
		''' Horizontaler Farbverlauf von links nach rechts. 
		''' </summary>
		Horizontal = 2

		''' <summary>
		''' Vertikaler Farbverlauf von oben nach unten.
		''' </summary>
		Vertical = 3

		''' <summary>
		''' Diagonaler Farbverlauf von oben links nach unten rechts.
		''' </summary>
		ForwardDiagonal = 4

		''' <summary>
		''' Diagonaler Farbverlauf von oben rechts nach unten links.
		''' </summary>
		BackwardDiagonal = 5

	End Enum

#End Region


	Public Sub New()

		'Stil und Verhalten des Steuerelements festlegen
		InitializeStyles()
		MyBase.BackColor = Color.Transparent

	End Sub


	Private Sub InitializeStyles()

		'weitere Literatur:
		'http://dotmad.blogspot.com/2007/11/five-steps-for-creating-transparent.html
		'https://www.codeguru.com/dotnet/creating-a-net-transparent-panel/

		SetStyle(ControlStyles.UserPaint, True)
		SetStyle(ControlStyles.AllPaintingInWmPaint, True)
		SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
		SetStyle(ControlStyles.SupportsTransparentBackColor, True)

	End Sub


#Region "Eigenschaften"


	''' <summary>
	''' Legt die Füllfarbe 1 fest oder gibt diese zurück.
	''' </summary>
	''' <value>
	''' Füllfarbe.
	''' </value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Browsable(True)>
	<Category("Appearance")>
	<Description("Legt die Füllfarbe 1 fest oder gibt diese zurück.")>
	Public Property FillColor1() As Color
		Get
			Return _fillColor1
		End Get
		Set(value As Color)
			_fillColor1 = value
			Invalidate()
		End Set
	End Property


	''' <summary>
	''' Legt die Füllfarbe 2 für den Farbverlauf fest oder gibt diese zurück.
	''' </summary>
	''' <value>
	''' Füllfarbe.
	''' </value>
	''' <returns></returns>
	''' <remarks></remarks>
	<Browsable(True)>
	<Category("Appearance")>
	<Description("Legt die Füllfarbe 2 für den Farbverlauf fest oder gibt diese zurück.")>
	Public Property FillColor2() As Color
		Get
			Return _fillColor2
		End Get
		Set(value As Color)
			_fillColor2 = value
			Invalidate()
		End Set
	End Property


	''' <summary>
	''' Legt den Füllstyle fest oder gibt diesen zurück.
	''' </summary>
	''' <value>
	''' True für ausgefüllt ansonsten False.
	''' </value>
	''' <returns></returns>
	''' <remarks>
	''' Standard ist False.
	''' </remarks>
	<Browsable(True)>
	<Category("Appearance")>
	<Description("Legt den Füllstyle fest oder gibt diesen zurück.")>
	Public Property FillStyle() As FillStyles
		Get
			Return _fillStyle
		End Get
		Set(value As FillStyles)
			_fillStyle = value
			Invalidate()
		End Set
	End Property


	''' <summary>
	''' Gibt die Breite der Rahmenlinie zurück oder legt diese fest.
	''' </summary>
	''' <value>
	''' Breite der Linie.
	''' </value>
	''' <returns></returns>
	''' <remarks>
	''' Die Breite ist in Pixeln angegeben.
	''' </remarks>
	<Browsable(True)>
	<Category("Appearance")>
	<Description("Legt die Breite der Rahmenlinie fest oder gibt diese zurück.")>
	Public Property BorderLineWidth() As Integer
		Get
			Return _borderlineWidth
		End Get
		Set(value As Integer)
			_borderlineWidth = value
			Invalidate()
		End Set
	End Property


	''' <summary>
	''' Gibt die Farbe der Rahmenlinie zurück oder legt diese fest.
	''' </summary>
	''' <value>
	''' Farbe der Linie.
	''' </value>
	<Browsable(True)>
	<Category("Appearance")>
	<Description("Legt die Farbe der Rahmenlinie fest oder gibt diese zurück.")>
	Public Property BorderLineColor() As Color
		Get
			Return _borderlineColor
		End Get
		Set(value As Color)
			_borderlineColor = value
			Invalidate()
		End Set
	End Property


#End Region


#Region "ausgeblendete Eigenschaften"


	''' <summary>
	''' Ruft die Hintergrundfarbe für das Steuerelement ab oder legt diese fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
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
	''' Ruft das im Steuerelement angezeigte Hintergrundbild ab oder legt dieses fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
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
	''' Ruft ab oder legt fest, welches Hintergrundbildlayout gemäß der Definition in
	'''	der System.Windows.Forms.ImageLayout-Enumeration verwendet wird.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
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
	''' Ruft einen Wert ab, der angibt, ob das Steuerelement Daten annehmen kann, die
	''' vom Benutzer darauf gezogen wurden, oder legt diesen fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
	<Browsable(False)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Overrides Property AllowDrop As Boolean
		Get
			Return MyBase.AllowDrop
		End Get
		Set(value As Boolean)
			MyBase.AllowDrop = value
		End Set
	End Property


	''' <summary>
	''' Ruft das dem Steuerelement zugeordnete Kontextmenü ab oder legt dieses fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
	<Browsable(False)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Overrides Property ContextMenu As ContextMenu
		Get
			Return MyBase.ContextMenu
		End Get
		Set(value As ContextMenu)
			MyBase.ContextMenu = value
		End Set
	End Property


	''' <summary>
	''' Ruft die diesem Steuerelement zugeordnete System.Windows.Forms.ContextMenuStrip-Klasse
	'''	ab oder legt diese fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
	<Browsable(False)>
	<EditorBrowsable(EditorBrowsableState.Never)>
	Public Overrides Property ContextMenuStrip As ContextMenuStrip
		Get
			Return MyBase.ContextMenuStrip
		End Get
		Set(value As ContextMenuStrip)
			MyBase.ContextMenuStrip = value
		End Set
	End Property


	''' <summary>
	''' Ruft die Schriftart für die Anzeige von Text im Steuerelement ab oder legt diese fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
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
	''' Ruft die Vordergrundfarbe des Steuerelements ab oder legt diese fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
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
	''' Ruft die Größe ab, die die Obergrenze bildet, 
	''' die System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)
	'''	angeben kann, oder legt diese fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
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


	''' <summary>
	''' Ruft die Größe ab, die die Untergrenze bildet, 
	''' die System.Windows.Forms.Control.GetPreferredSize(System.Drawing.Size)
	'''	angeben kann, oder legt diese fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
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


	''' <summary>
	''' Ruft einen Wert ab, der angibt, ob Elemente des Steuerelements für die Unterstützung
	'''	von Gebietsschemas ausgerichtet sind, die von rechts nach links geschriebene
	'''	Schriftarten verwenden, oder legt diesen fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
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
	''' Ruft den diesem Steuerelement zugeordneten Text ab oder legt diesen fest.
	''' </summary>
	''' <returns></returns>
	''' <remarks>Ausgeblendet da nicht relevant.</remarks>
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


#Region "überschriebene Methoden"

	Protected Overrides Sub OnPaint(e As PaintEventArgs)

		'weitere Literatur:
		'https://learn.microsoft.com/de-de/dotnet/api/system.drawing.drawing2d.lineargradientbrush?source=recommendations&view=dotnet-plat-ext-7.0

		MyBase.OnPaint(e)

		'Zeichenfläche festlegen
		Dim g As Graphics = e.Graphics
		Dim rect As New Rectangle(1, 1, Width - 2, Height - 2)

		'Verzweigung für Füllstyle
		Select Case _fillStyle

			'keine Füllung
			Case FillStyles.None
				Exit Select

			'Einfarbige Füllung
			Case FillStyles.Solid
				g.FillRectangle(New SolidBrush(_fillColor1), 1, 1, Width - 2, Height - 2)
				Exit Select

			'Farbverlaufsfüllung von oben nach unten
			Case FillStyles.Vertical
				g.FillRectangle(New LinearGradientBrush(rect, _fillColor1, _fillColor2, LinearGradientMode.Vertical), rect)
				Exit Select

			'Farbverlaufsfüllung von links nach rechts
			Case FillStyles.Horizontal
				g.FillRectangle(New LinearGradientBrush(rect, _fillColor1, _fillColor2, LinearGradientMode.Horizontal), rect)
				Exit Select

			'Farbverlaufsfüllung von oben links nach unten rechts
			Case FillStyles.ForwardDiagonal
				g.FillRectangle(New LinearGradientBrush(rect, _fillColor1, _fillColor2, LinearGradientMode.ForwardDiagonal), rect)
				Exit Select

			'Farbverlaufsfüllung von oben rechts nach unten links
			Case FillStyles.BackwardDiagonal
				g.FillRectangle(New LinearGradientBrush(rect, _fillColor1, _fillColor2, LinearGradientMode.BackwardDiagonal), rect)
				Exit Select

		End Select

		'Umrandung zeichnen
		g.DrawRectangle(New Pen(New SolidBrush(_borderlineColor), _borderlineWidth), rect)

	End Sub

#End Region


End Class
