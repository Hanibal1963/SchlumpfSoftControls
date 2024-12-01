' ****************************************************************************************************************
' FormMain.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.Globalization
Imports System.Threading

Public Class FormMain


    Public Sub New()

        'Zuletzt verwendete Sprache einstellen
        Thread.CurrentThread.CurrentCulture = New CultureInfo(My.Settings.LangCode)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.LangCode)

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles _
        ButtonDriveWatcher.Click,
        ButtonAniGif.Click,
        ButtonSevenSegmentControl.Click,
        ButtonNotifyFormControl.Click,
        ButtonIniFilecontrol.Click,
        ButtonWizardControl.Click,
        ButtonTransparentLabelControl.Click,
        ButtonShapeControl.Click,
        ButtonExplorerTreeView.Click, ButtonColorProgressBar.Click

        Dim result As DialogResult = DialogResult.None

        Try

            ' welcher Button wurde geklickt?
            If sender Is Me.ButtonAniGif Then
                result = My.Forms.FormAniGifControl.ShowDialog(Me)

            ElseIf sender Is Me.ButtonDriveWatcher Then
                result = My.Forms.FormDriveWatcherControl.ShowDialog(Me)

            ElseIf sender Is Me.ButtonIniFilecontrol Then
                result = My.Forms.FormIniFileControl.ShowDialog(Me)

            ElseIf sender Is Me.ButtonNotifyFormControl Then
                result = My.Forms.FormNotifyFormControl.ShowDialog(Me)

            ElseIf sender Is Me.ButtonSevenSegmentControl Then
                result = My.Forms.FormSevenSegmentControl.ShowDialog(Me)

            ElseIf sender Is Me.ButtonShapeControl Then
                result = My.Forms.FormShapeControl.ShowDialog(Me)

            ElseIf sender Is Me.ButtonTransparentLabelControl Then
                result = My.Forms.FormTransparentLabelControl.ShowDialog(Me)

            ElseIf sender Is Me.ButtonWizardControl Then
                result = My.Forms.FormWizardControl.ShowDialog(Me)

            ElseIf sender Is Me.ButtonExplorerTreeView Then
                result = My.Forms.FormExplorerTreeViewControl.ShowDialog(Me)

            ElseIf sender Is Me.ButtonColorProgressBar Then
                result = My.Forms.FormColorProgressBarControl.ShowDialog(Me)

            End If

        Catch ex As Exception

            Dim unused = MessageBox.Show($"Fehler: {ex.Message}",
                            $"Fehler",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles _
                Me.Load

        ' Titelzeile anpassen
        Me.Text = $"{My.Application.Info.Title} V{My.Application.Info.Version}"

    End Sub


    Private Sub ToolStripMenuItemLang_Click(sender As Object, e As EventArgs) Handles _
                ToolStripMenuItemDeutsch.Click,
                ToolStripMenuItemEnglisch.Click

        Try

            If sender Is Me.ToolStripMenuItemDeutsch Then
                ' Oberfläche auf Deutsch einstellen
                My.Settings.LangCode = "de-DE"

            ElseIf sender Is Me.ToolStripMenuItemEnglisch Then
                ' Oberfläche auf Enlisch einstellen
                My.Settings.LangCode = "en-US"

            End If

            ' Anwendung neu starten
            Application.Restart()

        Catch ex As Exception

            Dim unused = MessageBox.Show($"Fehler beim Sprachwechsel: {ex.Message}",
                            $"Fehler",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub


End Class
