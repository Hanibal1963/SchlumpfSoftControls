' ****************************************************************************************************************
' IniFileAddItemDialog.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'
Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class IniFileAddItemDialog

    Private _NewItemValue As String = $""

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

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        ' Button deaktivieren
        Me.ButtonOK.Enabled = False

    End Sub

    Private Sub Button_Click(sender As Object, e As System.EventArgs) Handles _
        ButtonOK.Click,
        ButtonCancel.Click

        ' Welcher Button wurde geklickt
        If sender Is Me.ButtonOK Then
            ' Neuen Wert setzen
            Me.SetNewItemValue
            ' Ergebnis setzen
            Me.DialogResult = DialogResult.OK

        ElseIf sender Is Me.ButtonCancel Then
            ' Ergebnis setzen
            Me.DialogResult = DialogResult.Cancel

        End If

        ' Dialog schließen
        Me.Close()

    End Sub

    ''' <summary>
    ''' Übernimmt den neuen Wert.
    ''' </summary>
    Private Sub SetNewItemValue()

        Me._NewItemValue = Me.TextBox.Text

    End Sub

    ''' <summary>
    ''' Wird aufgerufen wenn sich der Text im Textfeld ändert.
    ''' </summary>
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles _
        TextBox.TextChanged

        ' Textbox leer oder nur Leerzeichen?
        If String.IsNullOrWhiteSpace(CType(sender, TextBox).Text) Then
            ' Button deaktivieren wenn Textbox leer oder nur Leerzeichen enthält
            Me.ButtonOK.Enabled = False

        Else
            ' ansonsten Button aktivieren
            Me.ButtonOK.Enabled = True

        End If

    End Sub

End Class
