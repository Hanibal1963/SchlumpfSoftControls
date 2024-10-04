' ****************************************************************************************************************
' FormWizardControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.Globalization
Imports System.Threading
Imports SchlumpfSoft.Controls.WizardControl


Public Class FormWizardControl

    Public Sub New()

        'Zuletzt verwendete Sprache einstellen
        Thread.CurrentThread.CurrentCulture = New CultureInfo(My.Settings.LangCode)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.LangCode)

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub


    Private Sub Wizard1_BeforeSwitchPages(
                sender As Object,
                e As BeforeSwitchPagesEventArgs) Handles _
                Wizard1.BeforeSwitchPages

        Dim unused = MessageBox.Show(
        Me,
        String.Format(My.Resources.Wizard_NeuerIndex0AlterIndex1, e.NewIndex, e.OldIndex),
        String.Format(My.Resources.Wizard_VorDemSeitenwechsel),
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub


    Private Sub Wizard1_AfterSwitchPages(
                sender As Object,
                e As AfterSwitchPagesEventArgs) Handles _
                Wizard1.AfterSwitchPages

        Dim unused = MessageBox.Show(
        Me,
        String.Format(My.Resources.Wizard_NeuerIndex0AlterIndex1, e.NewIndex, e.OldIndex),
        String.Format(My.Resources.Wizard_NachDemSeitenwechsel),
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub


    Private Sub Wizard1_Cancel(
                sender As Object,
                e As System.ComponentModel.CancelEventArgs) Handles _
                Wizard1.Cancel

        Dim unused = MessageBox.Show(
        Me,
        String.Format(My.Resources.Wizard_AssistentenAbgebrochen),
        String.Format(My.Resources.Wizard_AktionAbgebrochen),
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub


    Private Sub Wizard1_Finish(
                sender As Object,
                e As EventArgs) Handles _
                Wizard1.Finish

        Dim unused = MessageBox.Show(
        Me,
        String.Format(My.Resources.Wizard_AssistenteAbgeschlossen),
        String.Format(My.Resources.Wizard_AktionAbgeschlossen),
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub


    Private Sub Wizard1_Help(
                sender As Object,
                e As EventArgs) Handles _
                Wizard1.Help

        Dim pageindex As Integer = CType(sender, Wizard).Pages.IndexOf(CType(sender, Wizard).SelectedPage) + 1

        Dim unused = MessageBox.Show(
        Me,
        String.Format(My.Resources.Wizard_DieHilfeFürDieSeite0DesAssistenten, pageindex),
        String.Format(My.Resources.Wizard_Hilfe),
        MessageBoxButtons.OK,
        MessageBoxIcon.Question)

    End Sub


End Class