' ****************************************************************************************************************
' IniFileRenameDialog.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Friend Class IniFileRenameDialog

    Private _OldItemValue As String = $""
    Private _NewItemValue As String = $""

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        ' Button deaktivieren
        Me.Button_Yes.Enabled = False

    End Sub

    ''' <summary>
    ''' Gibt den alten Wert zurück oder legt ihn fest.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True)>
    Public Property OldItemValue As String
        Get
            Return Me._OldItemValue
        End Get
        Set
            Me._OldItemValue = Value
        End Set
    End Property

    ''' <summary>
    ''' Gibt den neuen Wert zurück oder legt ihn fest.
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True)>
    Public Property NewItemValue As String
        Get
            Return Me._NewItemValue
        End Get
        Set
            Me._NewItemValue = Value
        End Set
    End Property

    Private Sub Button_Click(sender As Object, e As System.EventArgs) Handles _
       Button_Yes.Click,
       Button_No.Click

        ' welcher Button wurde geklickt?
        If sender Is Me.Button_Yes Then
            ' neuen Wert setzen
            Me.SetNewItemValue()
            ' Ergebnis setzen
            Me.DialogResult = DialogResult.Yes

        ElseIf sender Is Me.Button_No Then
            ' Ergebnis setzen
            Me.DialogResult = DialogResult.No
        End If

        ' Dialog schließen
        Me.Close()

    End Sub

    ''' <summary>
    ''' Übernimmt den neuen Wert.
    ''' </summary>
    Private Sub SetNewItemValue()

        Me._NewItemValue = Me.TextBoxNewValue.Text

    End Sub

    ''' <summary>
    ''' Wird aufgerufen wenn sich der Text im Textfeld ändert.
    ''' </summary>
    Private Sub TextBoxNewValue_TextChanged(sender As Object, e As EventArgs) Handles _
        TextBoxNewValue.TextChanged

        ' Textbox leer oder nur Leerzeichen?
        If String.IsNullOrWhiteSpace(CType(sender, TextBox).Text) Then
            ' Button deaktivieren wenn Textbox leer oder nur Leerzeichen enthält
            Me.Button_Yes.Enabled = False

        Else
            ' ansonsten Button aktivieren
            Me.Button_Yes.Enabled = True

        End If

    End Sub

End Class
