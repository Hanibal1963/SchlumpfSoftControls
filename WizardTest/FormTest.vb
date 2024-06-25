' ****************************************************************************************************************
' FormTest.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.ComponentModel
Imports SchlumpfSoft.Controls.WizardControl

Public Class FormTest

    Private Sub Wizard1_Cancel(sender As Object, e As CancelEventArgs) Handles _
        Wizard1.Cancel

        Debug.Print($"CancelEventArgs: {e.Cancel}")

        Dim unused = MessageBox.Show(
            Me,
            $"Sie haben den Assistenten abgebrochen.",
            $"Aktion abgebrochen",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    Private Sub Wizard1_AfterSwitchPages(sender As Object, e As AfterSwitchPagesEventArgs) Handles _
        Wizard1.AfterSwitchPages

        Dim unused = MessageBox.Show(
            Me,
            $"neuer Index: {e.NewIndex} / alter Index: {e.OldIndex}",
            $"Nach dem Seitenwechsel",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    Private Sub Wizard1_BeforeSwitchPages(sender As Object, e As BeforeSwitchPagesEventArgs) Handles _
        Wizard1.BeforeSwitchPages

        Dim unused = MessageBox.Show(
            Me,
            $"neuer Index: {e.NewIndex} / alter Index: {e.OldIndex}",
            $"Vor dem Seitenwechsel",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    Private Sub Wizard1_Finish(sender As Object, e As EventArgs) Handles _
        Wizard1.Finish

        Dim unused = MessageBox.Show(
            Me,
            $"Sie haben den Assistente abgeschlossen.",
            $"Aktion abgeschlossen",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)

    End Sub

    Private Sub Wizard1_Help(sender As Object, e As EventArgs) Handles _
        Wizard1.Help

        Dim pageindex As Integer = CType(sender, Wizard).Pages.IndexOf(CType(sender, Wizard).SelectedPage) + 1

        Dim unused = MessageBox.Show(
            Me,
            $"Die Hilfe für die Seite {pageindex} des Assistenten.",
            $"Hilfe",
            MessageBoxButtons.OK,
            MessageBoxIcon.Question)

    End Sub

End Class
