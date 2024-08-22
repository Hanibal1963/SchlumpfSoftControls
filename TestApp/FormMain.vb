' ****************************************************************************************************************
' Form1.vb
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
                result = My.Forms.FormWizardControl.ShowDialog(Me)

        End Select


    End Sub


    Private Sub FormMain_Load(
                sender As Object,
                e As EventArgs) Handles _
                Me.Load

        'Titelzeile anpassen
        Me.Text = $"{My.Application.Info.Title} V{My.Application.Info.Version}"


#If DEBUG Then

        Dim currentUICulture As CultureInfo = Thread.CurrentThread.CurrentUICulture
        Debug.Print($"Aktuelle Benutzeroberflächenkultur: {currentUICulture.Name}")

#End If

    End Sub


    Private Sub ToolStripMenuItemDeutsch_Click(
                sender As Object,
                e As EventArgs) Handles _
                ToolStripMenuItemDeutsch.Click,
                ToolStripMenuItemEnglisch.Click

        Select Case True

            Case sender Is Me.ToolStripMenuItemDeutsch

                'Oberfläche auf Deutsch einstellen
                My.Settings.LangCode = $"de-DE"

            Case sender Is Me.ToolStripMenuItemEnglisch

                'Oberfläche auf Enlisch einstellen
                My.Settings.LangCode = $"en-US"

        End Select

        'Anwendung neu starten
        Application.Restart()

    End Sub


End Class
