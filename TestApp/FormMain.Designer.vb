<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ToolStripMenuItemSprache = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemDeutsch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemEnglisch = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonAniGif = New System.Windows.Forms.Button()
        Me.ButtonDriveWatcher = New System.Windows.Forms.Button()
        Me.ButtonIniFilecontrol = New System.Windows.Forms.Button()
        Me.ButtonNotifyFormControl = New System.Windows.Forms.Button()
        Me.ButtonSevenSegmentControl = New System.Windows.Forms.Button()
        Me.ButtonShapeControl = New System.Windows.Forms.Button()
        Me.ButtonTransparentLabelControl = New System.Windows.Forms.Button()
        Me.ButtonWizardControl = New System.Windows.Forms.Button()
        Me.ButtonExplorerTreeView = New System.Windows.Forms.Button()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FlowLayoutPanel.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripMenuItemSprache
        '
        Me.ToolStripMenuItemSprache.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemDeutsch, Me.ToolStripMenuItemEnglisch})
        Me.ToolStripMenuItemSprache.Name = "ToolStripMenuItemSprache"
        resources.ApplyResources(Me.ToolStripMenuItemSprache, "ToolStripMenuItemSprache")
        '
        'ToolStripMenuItemDeutsch
        '
        Me.ToolStripMenuItemDeutsch.Name = "ToolStripMenuItemDeutsch"
        resources.ApplyResources(Me.ToolStripMenuItemDeutsch, "ToolStripMenuItemDeutsch")
        '
        'ToolStripMenuItemEnglisch
        '
        Me.ToolStripMenuItemEnglisch.Name = "ToolStripMenuItemEnglisch"
        resources.ApplyResources(Me.ToolStripMenuItemEnglisch, "ToolStripMenuItemEnglisch")
        '
        'FlowLayoutPanel
        '
        resources.ApplyResources(Me.FlowLayoutPanel, "FlowLayoutPanel")
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonAniGif)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonDriveWatcher)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonIniFilecontrol)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonNotifyFormControl)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonSevenSegmentControl)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonShapeControl)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonTransparentLabelControl)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonWizardControl)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonExplorerTreeView)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        '
        'ButtonAniGif
        '
        resources.ApplyResources(Me.ButtonAniGif, "ButtonAniGif")
        Me.ButtonAniGif.Name = "ButtonAniGif"
        Me.ButtonAniGif.UseVisualStyleBackColor = True
        '
        'ButtonDriveWatcher
        '
        resources.ApplyResources(Me.ButtonDriveWatcher, "ButtonDriveWatcher")
        Me.ButtonDriveWatcher.Name = "ButtonDriveWatcher"
        Me.ButtonDriveWatcher.UseVisualStyleBackColor = True
        '
        'ButtonIniFilecontrol
        '
        resources.ApplyResources(Me.ButtonIniFilecontrol, "ButtonIniFilecontrol")
        Me.ButtonIniFilecontrol.Name = "ButtonIniFilecontrol"
        Me.ButtonIniFilecontrol.UseVisualStyleBackColor = True
        '
        'ButtonNotifyFormControl
        '
        resources.ApplyResources(Me.ButtonNotifyFormControl, "ButtonNotifyFormControl")
        Me.ButtonNotifyFormControl.Name = "ButtonNotifyFormControl"
        Me.ButtonNotifyFormControl.UseVisualStyleBackColor = True
        '
        'ButtonSevenSegmentControl
        '
        resources.ApplyResources(Me.ButtonSevenSegmentControl, "ButtonSevenSegmentControl")
        Me.ButtonSevenSegmentControl.Name = "ButtonSevenSegmentControl"
        Me.ButtonSevenSegmentControl.UseVisualStyleBackColor = True
        '
        'ButtonShapeControl
        '
        resources.ApplyResources(Me.ButtonShapeControl, "ButtonShapeControl")
        Me.ButtonShapeControl.Name = "ButtonShapeControl"
        Me.ButtonShapeControl.UseVisualStyleBackColor = True
        '
        'ButtonTransparentLabelControl
        '
        resources.ApplyResources(Me.ButtonTransparentLabelControl, "ButtonTransparentLabelControl")
        Me.ButtonTransparentLabelControl.Name = "ButtonTransparentLabelControl"
        Me.ButtonTransparentLabelControl.UseVisualStyleBackColor = True
        '
        'ButtonWizardControl
        '
        resources.ApplyResources(Me.ButtonWizardControl, "ButtonWizardControl")
        Me.ButtonWizardControl.Name = "ButtonWizardControl"
        Me.ButtonWizardControl.UseVisualStyleBackColor = True
        '
        'ButtonExplorerTreeView
        '
        resources.ApplyResources(Me.ButtonExplorerTreeView, "ButtonExplorerTreeView")
        Me.ButtonExplorerTreeView.Name = "ButtonExplorerTreeView"
        Me.ButtonExplorerTreeView.UseVisualStyleBackColor = True
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemSprache})
        resources.ApplyResources(Me.MenuStrip, "MenuStrip")
        Me.MenuStrip.Name = "MenuStrip"
        '
        'FormMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.FlowLayoutPanel.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents FlowLayoutPanel As FlowLayoutPanel
    Private WithEvents ButtonAniGif As Button
    Private WithEvents ButtonDriveWatcher As Button
    Private WithEvents ButtonIniFilecontrol As Button
    Private WithEvents ButtonNotifyFormControl As Button
    Private WithEvents ButtonSevenSegmentControl As Button
    Private WithEvents ButtonShapeControl As Button
    Private WithEvents ButtonTransparentLabelControl As Button
    Private WithEvents ButtonWizardControl As Button
    Private WithEvents MenuStrip As MenuStrip
    Private WithEvents ToolStripMenuItemDeutsch As ToolStripMenuItem
    Private WithEvents ToolStripMenuItemEnglisch As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemSprache As ToolStripMenuItem
    Private WithEvents ButtonExplorerTreeView As Button
End Class
