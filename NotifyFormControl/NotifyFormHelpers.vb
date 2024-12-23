
' ****************************************************************************************************************
' NotifyFormHelpers.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'
' weitere Infos:
' <Browsable> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.browsableattribute?view=netframework-4.7.2
' <Category> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.categoryattribute?view=netframework-4.7.2
' <Description> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.descriptionattribute?view=netframework-4.7.2

Imports System.ComponentModel

' ****************************************************************************************************************
' NotifyFormHelpers.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'
' weitere Infos:
' <Browsable> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.browsableattribute?view=netframework-4.7.2
' <Category> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.categoryattribute?view=netframework-4.7.2
' <Description> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.descriptionattribute?view=netframework-4.7.2

Imports System.Drawing
Imports SchlumpfSoft.Attribute
Imports SchlumpfSoft.Controls.NotifyFormControl

Friend Class NotifyFormHelpers

    ''' <summary>
    ''' Setzt das Design des Fensters
    ''' </summary>
    Public Shared Sub SetFormDesign()

        Select Case NotifyFormVariableDefs.Design

            Case FormDesign.Bright
                SetFormDesignBright()

            Case FormDesign.Colorful
                SetFormDesignColorful()

            Case FormDesign.Dark
                SetFormDesignDark()

        End Select

    End Sub


    ''' <summary>
    ''' Setzt das helle Design
    ''' </summary>
    Private Shared Sub SetFormDesignBright()

        FormTemplate.BackgroundColor = Color.White
        FormTemplate.TextFieldColor = Color.White
        FormTemplate.TitleBarColor = Color.Gray
        FormTemplate.FontColor = Color.Black
        Dim ini As New FormTemplate
        ini.Initialize()

    End Sub

    ''' <summary>
    ''' Setz das farbige Design
    ''' </summary>
    Private Shared Sub SetFormDesignColorful()

        FormTemplate.BackgroundColor = Color.LightBlue
        FormTemplate.TextFieldColor = Color.LightBlue
        FormTemplate.TitleBarColor = Color.LightSeaGreen
        FormTemplate.FontColor = Color.White
        Dim ini As New FormTemplate
        ini.Initialize()

    End Sub

    ''' <summary>
    ''' Setzt das dunkle Design
    ''' </summary>
    Private Shared Sub SetFormDesignDark()

        FormTemplate.BackgroundColor = Color.FromArgb(83, 79, 75)
        FormTemplate.TextFieldColor = Color.FromArgb(83, 79, 75)
        FormTemplate.TitleBarColor = Color.FromArgb(60, 57, 54)
        FormTemplate.FontColor = Color.White
        Dim ini As New FormTemplate
        ini.Initialize()

    End Sub


    ''' <summary>
    ''' Setzt das Symbol des Fensters
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function SetFormImage() As Image

        Dim result As Bitmap = Nothing

        Select Case NotifyFormVariableDefs.Style

            Case FormStyle.CriticalError
                result = My.Resources.CriticalError

            Case FormStyle.Exclamation
                result = My.Resources.Warning

            Case FormStyle.Information
                result = My.Resources.Information

            Case FormStyle.Question
                result = My.Resources.Question

        End Select

        Return result

    End Function
End Class
