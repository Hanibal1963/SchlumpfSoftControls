' ****************************************************************************************************************
' IniFileCommentEdit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
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
    Private _TitelText As String


#Region "Definition der Ereignisse"


    ''' <summary>
    ''' Wird ausgelöst wenn sich der Kommentartext geändert hat.
    ''' </summary>
    <MyDescription("CommentChangedDescription")>
    Public Event CommentChanged(sender As Object, e As EventArgs)


    Private Event PropCommentChanged()
    Private Event TitelTextChanged()


#End Region


    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me._TitelText = Me.GroupBox.Text

    End Sub


#Region "Definition der neuen Eigenschaften"


    ''' <summary>
    ''' Gibt den Text der Titelzeile zurück oder legt diesen fest.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("TitelTextDescription")>
    Public Property TitelText As String
        Set(value As String)
            'Me._TitelText = value
            'RaiseEvent TitelTextChanged()
            If Me._TitelText <> value Then
                Me._TitelText = value
                RaiseEvent TitelTextChanged()
            End If
        End Set
        Get
            Return Me._TitelText
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
            'Me._Lines = Value
            'RaiseEvent PropCommentChanged()
            If Not Me._Lines.SequenceEqual(Value) Then
                Me._Lines = Value
                RaiseEvent PropCommentChanged()
            End If
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

    Private Sub IniFileCommentEdit_TitelTextChanged() Handles _
        Me.TitelTextChanged

        Me.GroupBox.Text = Me._TitelText

    End Sub


#End Region


End Class
