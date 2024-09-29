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
Public Class IniFileCommentEdit : Inherits UserControl

#Region "Definition der internen Eigenschaftsvariablen"

    Private _Lines As String() = {""}
    Private _TitelText As String

#End Region

#Region "Definition der öffentlichenEreignisse"

    ''' <summary>
    ''' Wird ausgelöst wenn sich der Kommentartext geändert hat.
    ''' </summary>
    <MyDescription("CommentChangedDescription")>
    Public Event CommentChanged(sender As Object, e As EventArgs)

#End Region

#Region "Definition der internen Ereignisse"

    ''' <summary>
    ''' Wir ausgelöst wenn sich die Eigenschaft Comment geändert hat.
    ''' </summary>
    Private Event PropCommentChanged()

    ''' <summary>
    ''' Wird ausgelöst wenn sich die Eigenschaft TitelText geändert hat.
    ''' </summary>
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
            ' hat sich der Wert geändert?
            If Me._TitelText <> value Then
                ' Wert setzen
                Me._TitelText = value
                ' Ereignis auslösen
                RaiseEvent TitelTextChanged()
            End If
        End Set
        Get
            ' Wert zurückgeben
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
            ' Wert zurückgeben
            Return Me._Lines
        End Get
        Set
            ' hat sich der Wert geändert?
            If Not Me._Lines.SequenceEqual(Value) Then
                ' Wert setzen
                Me._Lines = Value
                ' Ereignis auslösen
                RaiseEvent PropCommentChanged()
            End If
        End Set
    End Property


#End Region

#Region "Definition der internen Ereignisbehandlungen"

    ''' <summary>
    ''' Wird ausgelöst wenn der Button geklickt wird.
    ''' </summary>
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles _
        Button.Click

        ' geänderten Kommentar übernehmen
        Me._Lines = Me.TextBox.Lines
        ' Button deaktivieren
        Me.Button.Enabled = False
        ' Ereignis auslösen
        RaiseEvent CommentChanged(Me, EventArgs.Empty)

    End Sub

    ''' <summary>
    ''' Wird ausgelöst wenn sich der Text in der Textbox geändert hat.
    ''' </summary>
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles _
        TextBox.TextChanged

        'Button zum übernehmen der Dateikommentaränderungen aktivieren
        Me.Button.Enabled = True

    End Sub

    ''' <summary>
    ''' Wird ausgelöst wenn sich die Eigenschaft Comment geändert hat.
    ''' </summary>
    Private Sub IniFileCommentEdit_PropCommentChanged() Handles _
        Me.PropCommentChanged

        ' Kommentarzeilen in die Textbox eintragen
        Me.TextBox.Lines = Me._Lines
        ' Button deaktivieren
        Me.Button.Enabled = False

    End Sub

    ''' <summary>
    '''  Wird ausgelöst wenn sich die Eigenschaft TitelText geändert hat.
    ''' </summary>
    Private Sub IniFileCommentEdit_TitelTextChanged() Handles _
        Me.TitelTextChanged

        ' Titeltext setzen
        Me.GroupBox.Text = Me._TitelText

    End Sub

#End Region

End Class
