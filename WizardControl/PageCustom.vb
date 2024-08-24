' ****************************************************************************************************************
' PageCustom.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System.ComponentModel


''' <summary>
''' Definiert eine Benutzerdefinierte Seite
''' </summary>
<ToolboxItem(False)>
Public Class PageCustom


    Inherits WizardPage


    Private _Style As PageStyle = PageStyle.Custom


    <DefaultValue(PageStyle.Custom)>
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

