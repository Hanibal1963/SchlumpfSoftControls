



Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Drawing
Imports System.Windows.Forms


Public Class AniGif : Inherits Control


	<SuppressMessage("Style", "IDE0032:Automatisch generierte Eigenschaft verwenden",
			Justification:="<Ausstehend>")>
	Private _AutoPlay As Boolean
	Private _Gif As Bitmap
	Private _GifSizeMode As SizeMode


	Public Sub New()

		'Stil und Verhalten des Steuerelements festlegen
		InitializeStyles()

		'Standardanimation laden
		_Gif = My.Resources.AniGif_Standard

		'Standardeinstellung für AutoPlay
		_AutoPlay = False

		'Standarddarstellung für Grafik
		_GifSizeMode = SizeMode.Normal

	End Sub


#Region "Eigenschaften"

	''' <summary>
	''' Gibt die animierte Gif-Grafik zurück oder legt diese fest.
	''' </summary>
	''' <remarks>
	''' 
	''' </remarks>
	<Browsable(True)>
	<Category("Appearance")>
	<Description("Gibt die animierte Gif-Grafik zurück oder legt diese fest.")>
	Public Property Gif() As Bitmap
		Get
			Return _Gif
		End Get
		Set(value As Bitmap)
			_Gif = value
			GifChanged()
		End Set
	End Property

	''' <summary>
	''' Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.
	''' </summary>
	''' <remarks>
	''' 
	''' </remarks>
	<Browsable(True)>
	<Category("Behavior")>
	<Description("Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest.")>
	Public Property GifSizeMode() As SizeMode
		Get
			Return _GifSizeMode
		End Get
		Set(value As SizeMode)
			_GifSizeMode = value
			GifSizeModeChanged()
		End Set
	End Property

	''' <summary>
	''' Legt fest ob die Animation sofort nach dem laden gestartet wird.
	''' </summary>
	''' <remarks>
	''' </remarks>
	<Browsable(True)>
	<Category("Behavior")>
	<Description("Legt fest ob die Animation sofort nach dem laden gestartet wird.")>
	Public Property AutoPlay() As Boolean
		Get
			Return _AutoPlay
		End Get
		Set
			_AutoPlay = Value
		End Set
	End Property

#End Region


#Region "ausgeblendete Eigenschaften"

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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


	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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


	''' <summary>
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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
	''' Diese Eigenschaft ist für diese Klasse nicht relevant.
	''' </summary>
	''' <remarks>
	''' Eigenschaft ausgeblendet
	''' </remarks>
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

#End Region


#Region "überschriebene Methoden"

	Protected Overloads Overrides Sub Initlayout()

		MyBase.InitLayout()

		' Animation starten wenn nicht im Desigmodus und AutoPlay auf True
		If Not DesignMode And ImageAnimator.CanAnimate(_Gif) Then

			ImageAnimator.Animate(_Gif, AddressOf OnNextFrame)

		End If

	End Sub

	Protected Overrides Sub OnPaint(e As PaintEventArgs)

		MyBase.OnPaint(e)
		Dim g As Graphics = e.Graphics

		'Variablen zur Bildberechnung
		Dim startsize As Size
		Dim startpoint As Point
		Dim destrec As Rectangle

		'Bildgröße und Startpunkt in Abhängikeit vom Zeichenodus berechnen
		Select Case _GifSizeMode

			'Startpunkt und Größe berechnen wenn Bild unverändert angezeigt wird
			'(Bild in Originalgröße und links oben)
			Case SizeMode.Normal
				startsize = _Gif.Size
				startpoint = New Point(0, 0)

			'Startpunkt und Größe berechnen wenn Bild zentriert wird
			'(Bild in Originalgröße und zentriert)
			Case SizeMode.CenterImage
				startsize = _Gif.Size
				startpoint = New Point(CInt((Width - _Gif.Width) / 2), CInt((Height - _Gif.Height) / 2))

			'Startpunkt und Größe berechnen wenn das Bild gezoomt wird
			'(Bild angepasst und Seitenverhältnis unverändert)
			Case SizeMode.Zoom
				startsize = If(_Gif.Height > _Gif.Width,
					New Size(CInt(Height / CDec(_Gif.Height / _Gif.Width)), Height),
					New Size(Width, CInt(Width * CDec(_Gif.Height / _Gif.Width))))
				startpoint = New Point(CInt((Width - startsize.Width) / 2), CInt((Height - startsize.Height) / 2))

		End Select

		'neue Zeichenfläche festlegen
		destrec = New Rectangle(startpoint, startsize)

		'Bild zeichnen
		g.DrawImage(_Gif, destrec)

		'Bild animieren wenn AutoPlay aktiv
		If Not DesignMode And AutoPlay Then ImageAnimator.UpdateFrames()

	End Sub

#End Region


#Region "interne Methoden"

	Private Sub GifChanged()

		' Standardanimation verwenden wenn keine Auswahl erfolgte
		If _Gif Is Nothing Then

			_Gif = My.Resources.AniGif_Standard

		End If

		'neu zeichnen
		Invalidate()

		' Animation starten
		Initlayout()

	End Sub

	Private Sub InitializeStyles()

		SetStyle(ControlStyles.UserPaint, True)
		SetStyle(ControlStyles.AllPaintingInWmPaint, True)
		SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
		SetStyle(ControlStyles.SupportsTransparentBackColor, True)

	End Sub

	Private Sub OnNextFrame(o As Object, e As System.EventArgs)

		'neu zeichnen
		Invalidate()

	End Sub

	Private Sub GifSizeModeChanged()

		'neu zeichnen
		Invalidate()

	End Sub

#End Region


#Region "Auflistungen"

	''' <summary>
	''' Auflistung der Anzeigemodi
	''' </summary>
	Public Enum SizeMode

		''' <summary>
		''' Die Grafik wird in Originalgröße angezeigt.
		''' </summary>
		''' <remarks>
		''' Ausrichtung oben links.
		''' </remarks>
		Normal = 0

		''' <summary>
		''' Die Grafik wird in Originalgröße angezeigt.
		''' </summary>
		''' <remarks>
		''' zentrierte Ausrichtung.
		''' </remarks>
		CenterImage = 1

		''' <summary>
		''' Die Grafik wird an die Größe des Controls angepasst.
		''' </summary>
		''' <remarks>
		''' zentrierte Ausrichtung
		''' </remarks>
		Zoom = 2

	End Enum

#End Region


End Class
