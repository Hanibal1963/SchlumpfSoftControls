' ****************************************************************************************************************
' IniFileEntryValueEdit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing


''' <summary>
''' Steuerelement zum Anzeigen und Bearbeiten der Einträge eines Abschnitts einer INI - Datei.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<MyDescription("ClassDescriptionEntryValueEdit")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(IniFileEntryValueEdit), "IniFileEntryValueEdit.bmp")>
Public Class IniFileEntryValueEdit


    Inherits UserControl


    Private _TitelText As String


#Region "Definition der Ereignisse"


    ''' <summary>
    ''' Wird ausgelöst wenn sich der Wert geändert hat.
    ''' </summary>
    <MyDescription("ValueEditValueChanged")>
    Public Event ValueChanged(sender As Object, e As System.EventArgs)


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
    ''' Eintragswert
    ''' </summary>
    <MyDescription("ValueDescription")>
    Public Property Value As String
        Get
            Return Me.TextBox.Text
        End Get
        Set
            'Me.TextBox.Text = Value
            'Me.Button.Enabled = False
            If Me.TextBox.Text <> Value Then
                Me.TextBox.Text = Value
                Me.Button.Enabled = False
            End If
        End Set
    End Property

#End Region


#Region "Definition der internen Ereignisbehandlungen"


    Private Sub Button_Click(sender As Object, e As System.EventArgs) Handles _
        Button.Click

        'Ereignis auslösen
        RaiseEvent ValueChanged(Me, System.EventArgs.Empty)

    End Sub


    Private Sub TextBox_TextChanged(sender As Object, e As System.EventArgs) Handles _
        TextBox.TextChanged

        'Button aktivieren
        Me.Button.Enabled = True

    End Sub

    Private Sub IniFileCommentEdit_TitelTextChanged() Handles _
        Me.TitelTextChanged

        Me.GroupBox.Text = Me._TitelText

    End Sub


#End Region


End Class
