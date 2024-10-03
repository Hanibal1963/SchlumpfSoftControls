<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniFileDeleteItemDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniFileDeleteItemDialog))
        Me.ButtonYes = New System.Windows.Forms.Button()
        Me.ButtonNo = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
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
        Me.ButtonYes.Name = "ButtonYes"
        '
        'ButtonNo
        '
        resources.ApplyResources(Me.ButtonNo, "ButtonNo")
        Me.ButtonNo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonNo.Name = "ButtonNo"
        '
        'Label
        '
        resources.ApplyResources(Me.Label, "Label")
        Me.Label.Name = "Label"
        '
        'IniFileDeleteItemDialog
        '
        Me.AcceptButton = Me.ButtonYes
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonNo
        Me.ControlBox = False
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(TableLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IniFileDeleteItemDialog"
        Me.ShowInTaskbar = False
        TableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ButtonYes As System.Windows.Forms.Button
    Private WithEvents ButtonNo As System.Windows.Forms.Button
    Private WithEvents Label As System.Windows.Forms.Label
End Class
