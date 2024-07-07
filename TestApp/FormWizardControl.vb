' ****************************************************************************************************************
' FormWizardControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Public Class FormWizardControl


    Private Sub Wizard1_BeforeSwitchPages(
                sender As Object,
                e As SchlumpfSoft.Controls.WizardControl.BeforeSwitchPagesEventArgs) Handles _
                Wizard1.BeforeSwitchPages

        Dim unused = MessageBox.Show(
        Me,
        $"neuer Index: {e.NewIndex} / alter Index: {e.OldIndex}",
        $"Vor dem Seitenwechsel",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub


    Private Sub Wizard1_AfterSwitchPages(
                sender As Object,
                e As SchlumpfSoft.Controls.WizardControl.AfterSwitchPagesEventArgs) Handles _
                Wizard1.AfterSwitchPages

        Dim unused = MessageBox.Show(
        Me,
        $"neuer Index: {e.NewIndex} / alter Index: {e.OldIndex}",
        $"Nach dem Seitenwechsel",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub


    Private Sub Wizard1_Cancel(
                sender As Object,
                e As System.ComponentModel.CancelEventArgs) Handles _
                Wizard1.Cancel

        Debug.Print($"CancelEventArgs: {e.Cancel}")

        Dim unused = MessageBox.Show(
        Me,
        $"Sie haben den Assistenten abgebrochen.",
        $"Aktion abgebrochen",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub


    Private Sub Wizard1_Finish(
                sender As Object,
                e As EventArgs) Handles _
                Wizard1.Finish

        Dim unused = MessageBox.Show(
        Me,
        $"Sie haben den Assistente abgeschlossen.",
        $"Aktion abgeschlossen",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information)

    End Sub


    Private Sub Wizard1_Help(
                sender As Object,
                e As EventArgs) Handles _
                Wizard1.Help

        Dim pageindex As Integer = CType(
            sender,
            SchlumpfSoft.Controls.WizardControl.Wizard).Pages.IndexOf(
            CType(
            sender,
            SchlumpfSoft.Controls.WizardControl.Wizard).SelectedPage) + 1

        Dim unused = MessageBox.Show(
        Me,
        $"Die Hilfe für die Seite {pageindex} des Assistenten.",
        $"Hilfe",
        MessageBoxButtons.OK,
        MessageBoxIcon.Question)

    End Sub


End Class