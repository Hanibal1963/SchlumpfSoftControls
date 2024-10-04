' ****************************************************************************************************************
' IniFileDeleteItemDialog.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.Windows.Forms

Public Class IniFileDeleteItemDialog

    Private _itemvalue As String = $""

    Private Event PropertyItemValueChanged()

    ''' <summary>
    ''' Gibt den Wert des Elementes zurück oder legt ihn fest.
    ''' </summary>
    Public Property ItemValue As String
        Get
            Return Me._itemvalue
        End Get
        Set
            Me._itemvalue = Value
            RaiseEvent PropertyItemValueChanged()
        End Set
    End Property

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles _
        ButtonYes.Click,
        ButtonNo.Click

        ' Welcher Button wurde gedrückt?
        If sender Is Me.ButtonYes Then
            ' Ergebnis setzen 
            Me.DialogResult = DialogResult.OK

        ElseIf sender Is Me.ButtonNo Then
            ' Ergebnis setzen 
            Me.DialogResult = DialogResult.Cancel

        End If

        ' Dialog schließen
        Me.Close()

    End Sub

    Private Sub IniFileDeleteItemDialog_PropertyItemValueChanged() Handles _
        Me.PropertyItemValueChanged

        Me.Label.Text = Me.Label.Text.Replace("{0}", Me.ItemValue)

    End Sub

End Class
