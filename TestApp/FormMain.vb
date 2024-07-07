' ****************************************************************************************************************
' Form1.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Public Class FormMain

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles _
        ButtonDriveWatcher.Click,
        ButtonAniGif.Click,
        ButtonSevenSegmentControl.Click,
        ButtonNotifyFormControl.Click,
        ButtonIniFilecontrol.Click,
        ButtonWizardControl.Click,
        ButtonTransparentLabelControl.Click,
        ButtonShapeControl.Click

        Dim result As DialogResult

        'welcher Button wurde geklickt?
        Select Case True

            Case sender Is Me.ButtonAniGif
                result = My.Forms.FormAniGifControl.ShowDialog(Me)

            Case sender Is Me.ButtonDriveWatcher
                result = My.Forms.FormDriveWatcherControl.ShowDialog(Me)

            Case sender Is Me.ButtonIniFilecontrol
                result = My.Forms.FormIniFileControl.ShowDialog(Me)

            Case sender Is Me.ButtonNotifyFormControl
                result = My.Forms.FormNotifyFormControl.ShowDialog(Me)

            Case sender Is Me.ButtonSevenSegmentControl
                result = My.Forms.FormSevenSegmentControl.ShowDialog(Me)

            Case sender Is Me.ButtonShapeControl
                result = My.Forms.FormShapeControl.ShowDialog(Me)

            Case sender Is Me.ButtonTransparentLabelControl
                result = My.Forms.FormTransparentLabelControl.ShowDialog(Me)

            Case sender Is Me.ButtonWizardControl


        End Select


    End Sub


    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles _
        Me.Load

        'Titelzeile anpassen
        Me.Text = $"{My.Application.Info.Title} V{My.Application.Info.Version}"

    End Sub

End Class
