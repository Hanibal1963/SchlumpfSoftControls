' ****************************************************************************************************************
' ColorProgressBar.vb
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
Imports System.Windows.Forms

''' <summary>
''' Control zum Anzeigen eines farbigen Fortschrittbalkens.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum Anzeigen eines farbigen Fortschrittbalkens.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(ColorProgressBar), "ColorProgressBar.bmp")>
Public Class ColorProgressBar

    Inherits UserControl

#Region "globale Variablen"

    Private _progressunit As Integer = 20 'Der Betrag in Pixeln, um den unser Fortschrittsbalken erhöht wird.
    Private _progressvalue As Integer = 1 'Die Menge des ausgefüllten Maximalwerts.
    Private _maxvalue As Integer = 10 'Der Maximalwert des Fortschrittsbalkens.
    Private _showborder As Boolean = True 'Legt fest, ob der Rahmen auf der Fortschrittsanzeige aktiviert ist.
    Private _isglossy As Boolean = True 'Legt fest, ob der Glanz auf der Fortschrittsleiste angezeigt wird.
    Private _barcolor As Color = Color.Blue 'Die Farbe des Fortschrittsbalkens.
    Private _emptycolor As Color = Color.LightGray 'Die Farbe des leeren Fortschrittsbalkens.
    Private _bordercolor As Color = Color.Black 'Die Farbe des Rahmens.

#End Region

#Region "Ereignisdefinitionen für öffentliche Ereignisse"

    Public Shadows Event Click(sender As Object, e As EventArgs)

#End Region

#Region "neue Eigenschaften"

    ''' <summary>
    ''' Gibt den Gesamtfortschritt des Fortschrittsbalkens zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Description("Gibt den Gesamtfortschritt des Fortschrittsbalkens zurück oder legt diesen fest.")>
    <DefaultValue(1)>
    Public Property Value() As Integer
        Get
            Return Me._progressvalue
        End Get
        Set(value As Integer)
            'Nicht mehr als den Maximalwert erlauben
            Me._progressvalue = If(value <= Me._maxvalue, value, Me._maxvalue)
            Me.UpdateProgress()
        End Set
    End Property

    ''' <summary>
    ''' Gibt den Maximalwert des Fortschrittsbalkens zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Description("Gibt den Maximalwert des Fortschrittsbalkens zurück oder legt diesen fest.")>
    <DefaultValue(10)>
    Public Property ProgressMaximumValue() As Integer
        Get
            Return Me._maxvalue
        End Get
        Set(value As Integer)
            Me._maxvalue = If(value > Me.Width, Me.Width, value)
            Me.UpdateProgress()
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Farbe des Fortschrittsbalkens zurück oder legt diese fest.
    ''' </summary>
    <Browsable(True)>
    <Description("Gibt die Farbe des Fortschrittsbalkens zurück oder legt diese fest.")>
    Public Property BarColor As Color
        Get
            Return Me._barcolor
        End Get
        Set(value As Color)
            Me._barcolor = value
            Me.ProgressFull.BackColor = Me._barcolor
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Farbe des leeren Fortschrittsbalkens zurück oder legt diese fest.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True)>
    <Description("Gibt die Farbe des leeren Fortschrittsbalkens zurück oder legt diese fest.")>
    Public Property EmptyColor As Color
        Get
            Return Me._emptycolor
        End Get
        Set(value As Color)
            Me._emptycolor = value
            Me.ProgressEmpty.BackColor = Me._emptycolor
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Farbe des Rahmens zurück oder legt diese fest.
    ''' </summary>
    <Browsable(True)>
    <Description("Gibt die Farbe des Rahmens zurück oder legt diese fest.")>
    Public Property BorderColor As Color
        Get
            Return Me._bordercolor
        End Get
        Set(value As Color)
            Me._bordercolor = value
            Me.BackColor = Me._bordercolor
        End Set
    End Property

    ''' <summary>
    ''' Gibt an, ob der Rahmen auf der Fortschrittsanzeige aktiviert ist.
    ''' </summary>
    <Browsable(True)>
    <Description("Gibt an, ob der Rahmen auf der Fortschrittsanzeige aktiviert ist.")>
    <DefaultValue(True)>
    Public Property ShowBorder As Boolean
        Get
            Return Me._showborder
        End Get
        Set(value As Boolean)
            Me._showborder = value
            Me.UpdateProgress()
        End Set
    End Property

    ''' <summary>
    ''' Gibt an, ob der Glanz auf der Fortschrittsleiste angezeigt wird.
    ''' </summary>
    <Browsable(True)>
    <Description("Gibt an, ob der Glanz auf der Fortschrittsleiste angezeigt wird.")>
    <DefaultValue(True)>
    Public Property IsGlossy As Boolean
        Get
            Return Me._isglossy
        End Get
        Set(value As Boolean)
            Me._isglossy = value
            Me.UpdateProgress()
        End Set
    End Property

#End Region

#Region "ausgeblendete Eigenschaften"

    ''' <summary>
    ''' Ausgeblendet da nicht relevant.
    ''' </summary>
    <Browsable(False)>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Color)
            MyBase.BackColor = value
        End Set
    End Property

    ''' <summary>
    ''' Ausgeblendet da nicht relevant.
    ''' </summary>
    <Browsable(False)>
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
    <Browsable(False)>
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
    <Browsable(False)>
    Public Shadows Property BorderStyle As BorderStyle
        Get
            Return MyBase.BorderStyle
        End Get
        Set(value As BorderStyle)
            MyBase.BorderStyle = value
        End Set
    End Property

#End Region

    Public Sub New()
        'Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()
        'Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.InitDefaultColors()
    End Sub

#Region "interne Funktionen"

    Private Function UpdateGloss() As Boolean
        Try
            'Jedes Glanzfeld ausblenden
            Me.GlossLeft.Height = CInt(Me.Height / 3)
            Me.GlossRight.Height = Me.GlossLeft.Height
        Catch MyException As Exception
            'Einen Fehler zurückgeben und beenden
            Return False
            Exit Function
        End Try
        Return True
    End Function

    Private Function UpdateProgress() As Boolean
        Try
            'Globale Werte neu berechnen
            Me._progressunit = CInt(Me.Width / Me._maxvalue)
            Me.ProgressFull.Width = Me._progressvalue * Me._progressunit
            'Glanzfelder gemäß Globals ausblenden oder anzeigen
            If Me._isglossy Then
                Me.GlossLeft.Visible = True
                Me.GlossRight.Visible = True
            Else
                Me.GlossLeft.Visible = False
                Me.GlossRight.Visible = False
            End If
            'Bei Maximalwert den Fortschrittsbalken ausfüllen
            If Me._progressvalue = Me._maxvalue Then
                Me.ProgressFull.Width = If(Me._showborder, Me.Width - 2, Me.Width)
            End If
            'Ränder je nach Globalwerten ausblenden oder anzeigen
            Me.Padding = If(Me._showborder, New Padding(1), New Padding(0))
        Catch MyException As Exception
            'Einen Fehler zurückgeben und beenden
            Return False
            Exit Function
        End Try
        Return True
    End Function

    Private Sub InitDefaultColors()
        Me.GlossLeft.BackColor = Color.FromArgb(100, 255, 255, 255)
        Me.GlossRight.BackColor = Color.FromArgb(100, 255, 255, 255)
        Me.BackColor = Me._bordercolor
        Me.ProgressEmpty.BackColor = Me._emptycolor
        Me.ProgressFull.BackColor = Me._barcolor
    End Sub

#End Region

#Region "Ereignisbehandlungen"

    Private Sub ColorProgressBar_PaddingChanged(sender As Object, e As EventArgs) Handles Me.PaddingChanged
        Me.Padding = If(Me._showborder, New Padding(1), New Padding(0))
    End Sub

    Private Sub ColorProgressBar_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Value <= Me._maxvalue Then
            Me.UpdateProgress()
            Me.UpdateGloss()
        End If
    End Sub

    Private Sub Panel_Click(sender As Object, e As EventArgs) Handles GlossLeft.Click, ProgressFull.Click, ProgressEmpty.Click, GlossRight.Click
        RaiseEvent Click(Me, e)
    End Sub

#End Region

End Class
