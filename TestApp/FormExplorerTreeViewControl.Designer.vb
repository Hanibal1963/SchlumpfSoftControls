<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExplorerTreeViewControl
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
        Dim SplitContainer1 As System.Windows.Forms.SplitContainer
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExplorerTreeViewControl))
        Dim SplitContainer2 As System.Windows.Forms.SplitContainer
        Me.ExplorerTreeView = New SchlumpfSoft.Controls.ExplorerTreeViewControl.ExplorerTreeView()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ButtonSearchPath = New System.Windows.Forms.Button()
        Me.LabelPath = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        SplitContainer1 = New System.Windows.Forms.SplitContainer()
        SplitContainer2 = New System.Windows.Forms.SplitContainer()
        CType(SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        resources.ApplyResources(SplitContainer1, "SplitContainer1")
        SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        SplitContainer1.Panel1.Controls.Add(Me.ExplorerTreeView)
        '
        'SplitContainer1.Panel2
        '
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        '
        'ExplorerTreeView
        '
        resources.ApplyResources(Me.ExplorerTreeView, "ExplorerTreeView")
        Me.ExplorerTreeView.Intent = 23
        Me.ExplorerTreeView.ItemHight = 20
        Me.ExplorerTreeView.LineColor = System.Drawing.Color.Black
        Me.ExplorerTreeView.Name = "ExplorerTreeView"
        Me.ExplorerTreeView.ShowLines = True
        Me.ExplorerTreeView.ShowPlusMinus = True
        Me.ExplorerTreeView.ShowRootLines = True
        '
        'SplitContainer2
        '
        resources.ApplyResources(SplitContainer2, "SplitContainer2")
        SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        SplitContainer2.Panel1.Controls.Add(Me.TextBox)
        '
        'SplitContainer2.Panel2
        '
        SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel)
        '
        'TextBox
        '
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TextBox, "TextBox")
        Me.TextBox.Name = "TextBox"
        '
        'TableLayoutPanel
        '
        resources.ApplyResources(Me.TableLayoutPanel, "TableLayoutPanel")
        Me.TableLayoutPanel.Controls.Add(Me.ListView, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.ButtonSearchPath, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.LabelPath, 0, 1)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        '
        'ListView
        '
        Me.TableLayoutPanel.SetColumnSpan(Me.ListView, 2)
        resources.ApplyResources(Me.ListView, "ListView")
        Me.ListView.HideSelection = False
        Me.ListView.MultiSelect = False
        Me.ListView.Name = "ListView"
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.List
        '
        'ButtonSearchPath
        '
        resources.ApplyResources(Me.ButtonSearchPath, "ButtonSearchPath")
        Me.ButtonSearchPath.Name = "ButtonSearchPath"
        Me.ButtonSearchPath.UseVisualStyleBackColor = True
        '
        'LabelPath
        '
        resources.ApplyResources(Me.LabelPath, "LabelPath")
        Me.LabelPath.Name = "LabelPath"
        '
        'FolderBrowserDialog
        '
        resources.ApplyResources(Me.FolderBrowserDialog, "FolderBrowserDialog")
        Me.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderBrowserDialog.ShowNewFolderButton = False
        '
        'FormExplorerTreeViewControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormExplorerTreeViewControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents TextBox As TextBox
  Private WithEvents ListView As ListView
    Private WithEvents ExplorerTreeView As SchlumpfSoft.Controls.ExplorerTreeViewControl.ExplorerTreeView
    Private WithEvents TableLayoutPanel As TableLayoutPanel
    Private WithEvents ButtonSearchPath As Button
    Private WithEvents LabelPath As Label
    Private WithEvents FolderBrowserDialog As FolderBrowserDialog
End Class
