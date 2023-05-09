'
'****************************************************************************************************************
'LineShape.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Imports System
Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Drawing
Imports System.Windows.Forms


''' <summary>
''' Control zum darstellen einer Linie.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum darstellen einer Linie.")>
<ToolboxItem(True)>
Public Class LineShape : Inherits Control


	Private _lineWidth As Integer = 1
	Private _lineColor As Color = Color.Black


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
	''' Gibt die Breite der Linie zurück oder legt diese fest.
	''' </summary>
	''' <value>
	''' Breite der Linie in Pixel
	''' </value>
	<Browsable(True)>
	<Category("Appearance")>
	<Description("Gibt die Breite der Linie zurück oder legt diese fest.")>
	Public Property LineWidth() As Integer
		Get
			Return _lineWidth
		End Get
		Set(value As Integer)
			_lineWidth = value
			Invalidate()
		End Set
	End Property


	''' <summary>
	''' Gibt die Farbe der Linie zurück oder legt diese fest.
	''' </summary>
	''' <value>
	''' Farbe der Linie.
	''' </value>
	<Browsable(True)>
	<Category("Appearance")>
	<Description("Gibt die Farbe der Linie zurück oder legt diese fest.")>
	Public Property LineColor() As Color
		Get
			Return _lineColor
		End Get
		Set(value As Color)
			_lineColor = value
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

		'TODO: Code zum zeichnen einfügen





	End Sub

#End Region


End Class
