
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Wizard

    Inherits System.Windows.Forms.UserControl

    'Die Benutzersteuerung überschreibt dispose, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try

    End Sub

    'Erforderlich für den Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'HINWEIS: Das folgende Verfahren ist für den Windows Form Designer erforderlich
    'Es kann mit dem Windows Form Designer geändert werden.
    'Ändern Sie es nicht mit dem Code-Editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wizard))
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonHelp
        '
        resources.ApplyResources(Me.ButtonHelp, "ButtonHelp")
        Me.ButtonHelp.Name = "ButtonHelp"
        '
        'ButtonBack
        '
        resources.ApplyResources(Me.ButtonBack, "ButtonBack")
        Me.ButtonBack.Name = "ButtonBack"
        '
        'ButtonNext
        '
        resources.ApplyResources(Me.ButtonNext, "ButtonNext")
        Me.ButtonNext.Name = "ButtonNext"
        '
        'ButtonCancel
        '
        resources.ApplyResources(Me.ButtonCancel, "ButtonCancel")
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Name = "ButtonCancel"
        '
        'Wizard
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Name = "Wizard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonHelp As System.Windows.Forms.Button
    Friend WithEvents ButtonBack As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
