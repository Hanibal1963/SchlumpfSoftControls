<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniFileCommentEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniFileCommentEdit))
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.Button = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.TableLayoutPanel1)
        resources.ApplyResources(Me.GroupBox, "GroupBox")
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.TabStop = False
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button, 0, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'TextBox
        '
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TextBox, "TextBox")
        Me.TextBox.Name = "TextBox"
        '
        'Button
        '
        resources.ApplyResources(Me.Button, "Button")
        Me.Button.Name = "Button"
        Me.Button.UseVisualStyleBackColor = True
        '
        'IniFileCommentEdit
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "IniFileCommentEdit"
        Me.GroupBox.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents GroupBox As System.Windows.Forms.GroupBox
    Private WithEvents Button As System.Windows.Forms.Button
    Private WithEvents TextBox As System.Windows.Forms.TextBox
    Private WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
