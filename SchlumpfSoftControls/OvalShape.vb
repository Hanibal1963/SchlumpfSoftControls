'
'****************************************************************************************************************
'OvalShape.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis
Imports System.Drawing
Imports System.Windows.Forms


''' <summary>
''' Control zum darstellen eines Kreises oder einer Elypse.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum darstellen eines Kreises oder einer Elypse.")>
<ToolboxItem(True)>
Public Class OvalShape : Inherits Control


	Private _lineWidth As Integer = 1
	Private _lineColor As Color = Color.Black


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


	Protected Overrides Sub OnPaint(e As PaintEventArgs)
		MyBase.OnPaint(e)

		'TODO: Code zum zeichnen einfügen

	End Sub


End Class
