' ****************************************************************************************************************
' FormSevenSegmentControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Public Class FormSevenSegmentControl


    Private Sub TextBox_TextChanged(
                sender As Object,
                e As EventArgs) Handles _
                TextBox2.TextChanged,
                TextBox1.TextChanged

        Select Case True

            Case sender Is Me.TextBox1
                Me.SevSegSingleDigit1.DigitValue = Me.TextBox1.Text

            Case sender Is Me.TextBox2
                Me.SevSegMultiDigit1.Value = Me.TextBox2.Text

        End Select

    End Sub


End Class