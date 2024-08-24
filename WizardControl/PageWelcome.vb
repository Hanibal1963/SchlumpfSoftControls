' ****************************************************************************************************************
' PageWelcome.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System.ComponentModel


''' <summary>
''' Definiert die Willkommenseite
''' </summary>
<ToolboxItem(False)>
Public Class PageWelcome


    Inherits WizardPage


    Private _Style As PageStyle = PageStyle.Welcome


    <DefaultValue(PageStyle.Welcome)>
    <Category("Design")>
    <MyDescription("StyleDescription")>
    Public Overrides Property Style As PageStyle
        Get
            Return Me._Style
        End Get
        Set(value As PageStyle)
            Me._Style = value
        End Set
    End Property


End Class

