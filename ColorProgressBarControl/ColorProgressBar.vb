﻿' ****************************************************************************************************************
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
Imports SchlumpfSoft.Attribute

''' <summary>
''' Control zum Anzeigen eines farbigen Fortschrittbalkens.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum Anzeigen eines farbigen Fortschrittbalkens.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(ColorProgressBar), "ColorProgressBar.bmp")>
Public Class ColorProgressBar

    Inherits UserControl

#Region "Ereignisdefinitionen für öffentliche Ereignisse"

    Public Shadows Event Click(sender As Object, e As EventArgs)

#End Region

#Region "neue Eigenschaften"

    ''' <summary>
    ''' Gibt den Gesamtfortschritt des Fortschrittsbalkens zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Gibt den Gesamtfortschritt des Fortschrittsbalkens zurück oder legt diesen fest.")>
    <DefaultValue(1)>
    Public Property Value() As Integer
        Get
            Return ProgressValue
        End Get
        Set(value As Integer)
            'Nicht mehr als den Maximalwert erlauben
            ProgressValue = If(value <= MaxValue, value, MaxValue)
            Dim unused = Me.UpdateProgress()
        End Set
    End Property

    ''' <summary>
    ''' Gibt den Maximalwert des Fortschrittsbalkens zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Gibt den Maximalwert des Fortschrittsbalkens zurück oder legt diesen fest.")>
    <DefaultValue(10)>
    Public Property ProgressMaximumValue() As Integer
        Get
            Return MaxValue
        End Get
        Set(value As Integer)
            MaxValue = If(value > Me.Width, Me.Width, value)
            Dim unused = Me.UpdateProgress()
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Farbe des Fortschrittsbalkens zurück oder legt diese fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt die Farbe des Fortschrittsbalkens zurück oder legt diese fest.")>
    Public Property BarColor As Color
        Get
            Return VariableDefinitions.BarColor
        End Get
        Set(value As Color)
            VariableDefinitions.BarColor = value
            Me.ProgressFull.BackColor = VariableDefinitions.BarColor
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Farbe des leeren Fortschrittsbalkens zurück oder legt diese fest.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt die Farbe des leeren Fortschrittsbalkens zurück oder legt diese fest.")>
    Public Property EmptyColor As Color
        Get
            Return VariableDefinitions.EmptyColor
        End Get
        Set(value As Color)
            VariableDefinitions.EmptyColor = value
            Me.ProgressEmpty.BackColor = VariableDefinitions.EmptyColor
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Farbe des Rahmens zurück oder legt diese fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt die Farbe des Rahmens zurück oder legt diese fest.")>
    Public Property BorderColor As Color
        Get
            Return VariableDefinitions.BorderColor
        End Get
        Set(value As Color)
            VariableDefinitions.BorderColor = value
            Me.BackColor = VariableDefinitions.BorderColor
        End Set
    End Property

    ''' <summary>
    ''' Gibt an, ob der Rahmen auf der Fortschrittsanzeige aktiviert ist.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt an, ob der Rahmen auf der Fortschrittsanzeige aktiviert ist.")>
    <DefaultValue(True)>
    Public Property ShowBorder As Boolean
        Get
            Return VariableDefinitions.ShowBorder
        End Get
        Set(value As Boolean)
            VariableDefinitions.ShowBorder = value
            Dim unused = Me.UpdateProgress()
        End Set
    End Property

    ''' <summary>
    ''' Gibt an, ob der Glanz auf der Fortschrittsleiste angezeigt wird.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt an, ob der Glanz auf der Fortschrittsleiste angezeigt wird.")>
    <DefaultValue(True)>
    Public Property IsGlossy As Boolean
        Get
            Return VariableDefinitions.IsGlossy
        End Get
        Set(value As Boolean)
            VariableDefinitions.IsGlossy = value
            Dim unused = Me.UpdateProgress()
        End Set
    End Property

#End Region

#Region "ausgeblendete Eigenschaften"

    ''' <summary>
    ''' Ausgeblendet da nicht relevant.
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
    ''' Ausgeblendet da nicht relevant.
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
    ''' Ausgeblendet da nicht relevant.
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
    ''' Ausgeblendet da nicht relevant.
    ''' </summary>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Shadows Property BorderStyle As BorderStyle
        Get
            Return MyBase.BorderStyle
        End Get
        Set(value As BorderStyle)
            MyBase.BorderStyle = value
        End Set
    End Property

    ''' <summary>
    ''' Ausgeblendet da nicht relevant.
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
    ''' Ausgeblendet da nicht relevant.
    ''' </summary>
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

#End Region

    Public Sub New()

        'Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        'Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        ' Standardwerte setzen
        Me.GlossLeft.BackColor = Color.FromArgb(100, 255, 255, 255)
        Me.GlossRight.BackColor = Color.FromArgb(100, 255, 255, 255)
        Me.BackColor = VariableDefinitions.BorderColor
        Me.ProgressEmpty.BackColor = VariableDefinitions.EmptyColor
        Me.ProgressFull.BackColor = VariableDefinitions.BarColor

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
            ProgressUnit = CInt(Me.Width / MaxValue)
            Me.ProgressFull.Width = ProgressValue * ProgressUnit

            'Glanzfelder gemäß Globals ausblenden oder anzeigen
            If VariableDefinitions.IsGlossy Then

                Me.GlossLeft.Visible = True
                Me.GlossRight.Visible = True

            Else

                Me.GlossLeft.Visible = False
                Me.GlossRight.Visible = False

            End If

            'Bei Maximalwert den Fortschrittsbalken ausfüllen
            If ProgressValue = MaxValue Then

                Me.ProgressFull.Width = If(VariableDefinitions.ShowBorder, Me.Width - 2, Me.Width)

            End If

            'Ränder je nach Globalwerten ausblenden oder anzeigen
            Me.Padding = If(VariableDefinitions.ShowBorder, New Padding(1), New Padding(0))

        Catch MyException As Exception

            'Einen Fehler zurückgeben und beenden
            Return False
            Exit Function

        End Try

        Return True

    End Function

#End Region

#Region "Interne Ereignisbehandlungen"

    Private Sub ColorProgressBar_PaddingChanged(sender As Object, e As EventArgs) Handles Me.PaddingChanged

        Me.Padding = If(VariableDefinitions.ShowBorder, New Padding(1), New Padding(0))

    End Sub

    Private Sub ColorProgressBar_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        If Me.Value <= MaxValue Then

            Dim unused = Me.UpdateProgress()
            Dim unused1 = Me.UpdateGloss()

        End If

    End Sub

    Private Sub Panel_Click(sender As Object, e As EventArgs) Handles GlossLeft.Click, ProgressFull.Click, ProgressEmpty.Click, GlossRight.Click

        RaiseEvent Click(Me, e)

    End Sub

#End Region

End Class
