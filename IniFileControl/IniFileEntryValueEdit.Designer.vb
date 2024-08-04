<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniFileEntryValueEdit
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniFileEntryValueEdit))
        Me.Button = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button
        '
        resources.ApplyResources(Me.Button, "Button")
        Me.Button.Name = "Button"
        Me.Button.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        resources.ApplyResources(Me.TextBox, "TextBox")
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox.Name = "TextBox"
        '
        'GroupBox
        '
        resources.ApplyResources(Me.GroupBox, "GroupBox")
        Me.GroupBox.Controls.Add(Me.TextBox)
        Me.GroupBox.Controls.Add(Me.Button)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.TabStop = False
        '
        'IniFileEntryValueEdit
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "IniFileEntryValueEdit"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Button As System.Windows.Forms.Button
    Private WithEvents TextBox As System.Windows.Forms.TextBox
    Private WithEvents GroupBox As System.Windows.Forms.GroupBox
End Class
