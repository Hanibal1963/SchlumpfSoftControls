' ****************************************************************************************************************
' IniFileCommentEdit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms


''' <summary>
''' Steuerelement zum Anzeigen und Bearbeiten des Datei- oder Abschnitts- Kommentars einer INI - Datei.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<MyDescription("ClassDescriptionCommentEdit")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(IniFileCommentEdit), "IniFileCommentEdit.bmp")>
Public Class IniFileCommentEdit


    Inherits UserControl


    Private _Lines As String()


#Region "Definition der Ereignisse"


    ''' <summary>
    ''' Wird ausgelöst wenn sich der Kommentartext geändert hat.
    ''' </summary>
    <MyDescription("CommentChangedDescription")>
    Public Event CommentChanged(sender As Object, e As EventArgs)


    Private Event PropCommentChanged()


#End Region


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
    ''' Gibt den Kommentartext zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("CommentDescription")>
    Public Property Comment As String()
        Get
            Return Me._Lines
        End Get
        Set
            Me._Lines = Value
            RaiseEvent PropCommentChanged()
        End Set
    End Property


#End Region


#Region "Definition der internen Ereignisbehandlungen"


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles _
        Button.Click

        Me._Lines = Me.TextBox.Lines

        'Ereignis auslösen
        RaiseEvent CommentChanged(Me, EventArgs.Empty)

    End Sub


    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles _
        TextBox.TextChanged

        'Button zum übernehmen der Dateikommentaränderungen aktivieren
        Me.Button.Enabled = True

    End Sub


    Private Sub IniFileCommentEdit_PropCommentChanged() Handles _
        Me.PropCommentChanged

        Me.TextBox.Lines = Me._Lines
        Me.Button.Enabled = False

    End Sub


#End Region


End Class
