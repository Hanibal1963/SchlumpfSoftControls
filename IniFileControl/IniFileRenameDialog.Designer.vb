<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniFileRenameDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniFileRenameDialog))
        Me.Button_Yes = New System.Windows.Forms.Button()
        Me.Button_No = New System.Windows.Forms.Button()
        Me.LabelFrage = New System.Windows.Forms.Label()
        Me.TextBoxNewValue = New System.Windows.Forms.TextBox()
        TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        resources.ApplyResources(TableLayoutPanel, "TableLayoutPanel")
        TableLayoutPanel.Controls.Add(Me.Button_Yes, 0, 0)
        TableLayoutPanel.Controls.Add(Me.Button_No, 1, 0)
        TableLayoutPanel.Name = "TableLayoutPanel"
        '
        'Button_Yes
        '
        resources.ApplyResources(Me.Button_Yes, "Button_Yes")
        Me.Button_Yes.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Button_Yes.Name = "Button_Yes"
        '
        'Button_No
        '
        resources.ApplyResources(Me.Button_No, "Button_No")
        Me.Button_No.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Button_No.Name = "Button_No"
        '
        'LabelFrage
        '
        resources.ApplyResources(Me.LabelFrage, "LabelFrage")
        Me.LabelFrage.Name = "LabelFrage"
        '
        'TextBoxNewValue
        '
        Me.TextBoxNewValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TextBoxNewValue, "TextBoxNewValue")
        Me.TextBoxNewValue.Name = "TextBoxNewValue"
        '
        'IniFileRenameDialog
        '
        Me.AcceptButton = Me.Button_Yes
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button_No
        Me.ControlBox = False
        Me.Controls.Add(Me.TextBoxNewValue)
        Me.Controls.Add(Me.LabelFrage)
        Me.Controls.Add(TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IniFileRenameDialog"
        Me.ShowInTaskbar = False
        TableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Button_Yes As System.Windows.Forms.Button
    Private WithEvents Button_No As System.Windows.Forms.Button
    Private WithEvents LabelFrage As System.Windows.Forms.Label
    Private WithEvents TextBoxNewValue As System.Windows.Forms.TextBox
End Class
