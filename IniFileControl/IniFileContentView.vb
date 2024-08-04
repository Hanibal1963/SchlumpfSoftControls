' ****************************************************************************************************************
' IniFileContentView.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System.ComponentModel
Imports System.Drawing


''' <summary>
''' Steuerelement zum Anzeigen des Dateiinhaltes.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<MyDescription("ClassDescriptionContentView")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(IniFileContentView), "IniFileContentView.bmp")>
Public Class IniFileContentView


    Private _Lines As String()


    Private Event PropLinesChanged()


    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub


#Region "Definition der neuen Eigenschaften"


    ''' <summary>
    ''' Gibt den Text der Titelzeile zurück oder legt diesen fest.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("TextDescription")>
    Public Overrides Property Text As String
        Set(value As String)
            Me.GroupBox.Text = value
        End Set
        Get
            Return Me.GroupBox.Text
        End Get
    End Property


    ''' <summary>
    ''' Setzt Dateiinhalt
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("LinesDescription")>
    Public Property Lines As String()
        Get
            Return Me._Lines
        End Get
        Set
            Me._Lines = Value
            RaiseEvent PropLinesChanged()
        End Set
    End Property


#End Region



    Private Sub IniFileContentView_LinesChanged() Handles _
        Me.PropLinesChanged

        Me.TextBox.Lines = Me._Lines

    End Sub


End Class
