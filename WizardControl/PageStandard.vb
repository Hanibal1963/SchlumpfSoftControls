' ****************************************************************************************************************
' PageStandard.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System.ComponentModel


''' <summary>
''' Definiert eine Standardseite
''' </summary>
<ToolboxItem(False)>
Public Class PageStandard


    Inherits WizardPage


    Private _Style As PageStyle = PageStyle.Standard


    <DefaultValue(PageStyle.Standard)>
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

