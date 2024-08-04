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
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonRename = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox
        '
        resources.ApplyResources(Me.GroupBox, "GroupBox")
        Me.GroupBox.Controls.Add(Me.ButtonDelete)
        Me.GroupBox.Controls.Add(Me.ButtonRename)
        Me.GroupBox.Controls.Add(Me.ButtonAdd)
        Me.GroupBox.Controls.Add(Me.ListBox)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.TabStop = False
        '
        'ButtonDelete
        '
        resources.ApplyResources(Me.ButtonDelete, "ButtonDelete")
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonRename
        '
        resources.ApplyResources(Me.ButtonRename, "ButtonRename")
        Me.ButtonRename.Name = "ButtonRename"
        Me.ButtonRename.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        resources.ApplyResources(Me.ButtonAdd, "ButtonAdd")
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.UseVisualStyleBackColor = True
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
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ButtonDelete As System.Windows.Forms.Button
    Private WithEvents ButtonRename As System.Windows.Forms.Button
    Private WithEvents ButtonAdd As System.Windows.Forms.Button
    Private WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
End Class
