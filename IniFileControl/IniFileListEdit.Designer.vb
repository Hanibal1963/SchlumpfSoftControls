<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniFileListEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IniFileListEdit))
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonRename = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ListBox, 0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'TableLayoutPanel2
        '
        resources.ApplyResources(Me.TableLayoutPanel2, "TableLayoutPanel2")
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonAdd, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonRename, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonDelete, 2, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        '
        'ButtonAdd
        '
        resources.ApplyResources(Me.ButtonAdd, "ButtonAdd")
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonRename
        '
        resources.ApplyResources(Me.ButtonRename, "ButtonRename")
        Me.ButtonRename.Name = "ButtonRename"
        Me.ButtonRename.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        resources.ApplyResources(Me.ButtonDelete, "ButtonDelete")
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ListBox
        '
        resources.ApplyResources(Me.ListBox, "ListBox")
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Name = "ListBox"
        '
        'IniFileListEdit
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "IniFileListEdit"
        Me.GroupBox.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ButtonDelete As System.Windows.Forms.Button
    Private WithEvents ButtonRename As System.Windows.Forms.Button
    Private WithEvents ButtonAdd As System.Windows.Forms.Button
    Private WithEvents ListBox As System.Windows.Forms.ListBox
    Private WithEvents GroupBox As System.Windows.Forms.GroupBox
    Private WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
