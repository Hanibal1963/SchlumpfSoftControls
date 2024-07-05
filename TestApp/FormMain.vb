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

        'welcher Button wurde geklickt?
        Select Case True
            Case sender Is Me.ButtonAniGif : My.Forms.FormAniGifControl.Show(Me)
            Case sender Is Me.ButtonDriveWatcher : My.Forms.FormDriveWatcherControl.Show(Me)
            Case sender Is Me.ButtonIniFilecontrol
            Case sender Is Me.ButtonNotifyFormControl
            Case sender Is Me.ButtonSevenSegmentControl
            Case sender Is Me.ButtonShapeControl
            Case sender Is Me.ButtonTransparentLabelControl
            Case sender Is Me.ButtonWizardControl
        End Select


    End Sub


    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles _
        Me.Load

        'Titelzeile anpassen
        Me.Text = $"{My.Application.Info.Title} V{My.Application.Info.Version}"

    End Sub

End Class
