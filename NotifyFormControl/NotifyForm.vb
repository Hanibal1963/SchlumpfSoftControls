' ****************************************************************************************************************
' NotifyForm.vb
' © 2023 - 2024 by Andreas Sauer
' ****************************************************************************************************************
'
' weitere Infos:
' <Browsable> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.browsableattribute?view=netframework-4.7.2
' <Category> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.categoryattribute?view=netframework-4.7.2
' <Description> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.descriptionattribute?view=netframework-4.7.2

Imports System.ComponentModel
Imports System.Drawing
Imports SchlumpfSoft.Attribute

''' <summary>
''' Control zum anzeigen von Benachrichtigungsfenstern.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum anzeigen von Benachrichtigungsfenstern.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(NotifyForm), "NotifyForm.bmp")>
Public Class NotifyForm

    Inherits Component

    Public Sub New()
        NotifyFormVariableDefs.Title = String.Format(My.Resources.StandardTitle)
        NotifyFormVariableDefs.Message = String.Format(My.Resources.StandardMessage)
        NotifyFormVariableDefs.Design = FormDesign.Bright
        NotifyFormVariableDefs.Style = FormStyle.Information
        NotifyFormVariableDefs.ShowTime = 5000

    End Sub

    ''' <summary>
    ''' Legt das Aussehen des Benachrichtigungsfensters fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt das Aussehen des Benachrichtigungsfensters fest.")>
    Public Property Design As FormDesign
        Get
            Return NotifyFormVariableDefs.Design
        End Get
        Set
            NotifyFormVariableDefs.Design = Value
        End Set
    End Property

    ''' <summary>
    ''' Legt den Benachrichtigungstext fest der angezeigt werden soll.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt den Benachrichtigungstext fest der angezeigt werden soll.")>
    Public Property Message As String
        Get
            Return NotifyFormVariableDefs.Message
        End Get
        Set
            NotifyFormVariableDefs.Message = Value
        End Set
    End Property

    ''' <summary>
    ''' Legt die Anzeigedauer des Benachrichtigungsfensters in ms fest.
    ''' </summary>
    ''' <remarks>
    ''' Der Wert 0 bewirkt das kein automatisches schließen des Fensters erfolgt.
    ''' </remarks>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt die Anzeigedauer des Benachrichtigungsfensters in ms fest.")>
    Public Property ShowTime As Integer
        Get
            Return NotifyFormVariableDefs.ShowTime
        End Get
        Set
            NotifyFormVariableDefs.ShowTime = Value
        End Set
    End Property

    ''' <summary>
    ''' Legt das anzuzeigende Symbol im Benachrichtigungsfensters fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt das anzuzeigende Symbol im Benachrichtigungsfensters fest.")>
    Public Property Style As FormStyle
        Get
            Return NotifyFormVariableDefs.Style
        End Get
        Set
            NotifyFormVariableDefs.Style = Value
        End Set
    End Property

    ''' <summary>
    ''' Legt den Text der Titelzeile des Benachrichtigungsfensters fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt den Text der Titelzeile des Benachrichtigungsfensters fest.")>
    Public Property Title As String
        Get
            Return NotifyFormVariableDefs.Title
        End Get
        Set
            NotifyFormVariableDefs.Title = Value
        End Set
    End Property

    ''' <summary>
    ''' Zeigt das Meldungsfenster an.
    ''' </summary>
    Public Sub Show()

        FormTemplate.Image = NotifyFormHelpers.SetFormImage()
        FormTemplate.Title = NotifyFormVariableDefs.Title
        FormTemplate.Message = NotifyFormVariableDefs.Message
        FormTemplate.ShowTime = NotifyFormVariableDefs.ShowTime
        NotifyFormHelpers.SetFormDesign()

    End Sub

End Class
