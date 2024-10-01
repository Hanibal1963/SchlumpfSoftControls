<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniFileRenameItemDialog
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniFileRenameItemDialog))
        Me.ButtonYes = New System.Windows.Forms.Button()
        Me.ButtonNo = New System.Windows.Forms.Button()
        Me.LabelFrage = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        resources.ApplyResources(TableLayoutPanel, "TableLayoutPanel")
        TableLayoutPanel.Controls.Add(Me.ButtonYes, 0, 0)
        TableLayoutPanel.Controls.Add(Me.ButtonNo, 1, 0)
        TableLayoutPanel.Name = "TableLayoutPanel"
        '
        'ButtonYes
        '
        resources.ApplyResources(Me.ButtonYes, "ButtonYes")
        Me.ButtonYes.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.ButtonYes.Name = "ButtonYes"
        '
        'ButtonNo
        '
        resources.ApplyResources(Me.ButtonNo, "ButtonNo")
        Me.ButtonNo.DialogResult = System.Windows.Forms.DialogResult.No
        Me.ButtonNo.Name = "ButtonNo"
        '
        'LabelFrage
        '
        resources.ApplyResources(Me.LabelFrage, "LabelFrage")
        Me.LabelFrage.Name = "LabelFrage"
        '
        'TextBox
        '
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TextBox, "TextBox")
        Me.TextBox.Name = "TextBox"
        '
        'IniFileRenameItemDialog
        '
        Me.AcceptButton = Me.ButtonYes
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonNo
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.LabelFrage)
        Me.Controls.Add(TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IniFileRenameItemDialog"
        Me.ShowInTaskbar = False
        TableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ButtonYes As System.Windows.Forms.Button
    Private WithEvents ButtonNo As System.Windows.Forms.Button
    Private WithEvents LabelFrage As System.Windows.Forms.Label
    Private WithEvents TextBox As System.Windows.Forms.TextBox
End Class
