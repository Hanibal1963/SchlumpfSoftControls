<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ButtonAniGif = New System.Windows.Forms.Button()
        Me.ButtonDriveWatcher = New System.Windows.Forms.Button()
        Me.ButtonIniFilecontrol = New System.Windows.Forms.Button()
        Me.ButtonNotifyFormControl = New System.Windows.Forms.Button()
        Me.ButtonSevenSegmentControl = New System.Windows.Forms.Button()
        Me.ButtonShapeControl = New System.Windows.Forms.Button()
        Me.ButtonTransparentLabelControl = New System.Windows.Forms.Button()
        Me.ButtonWizardControl = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.AutoScroll = True
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonAniGif)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonDriveWatcher)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonIniFilecontrol)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonNotifyFormControl)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonSevenSegmentControl)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonShapeControl)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonTransparentLabelControl)
        Me.FlowLayoutPanel.Controls.Add(Me.ButtonWizardControl)
        Me.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(260, 244)
        Me.FlowLayoutPanel.TabIndex = 0
        '
        'ButtonAniGif
        '
        Me.ButtonAniGif.Location = New System.Drawing.Point(3, 3)
        Me.ButtonAniGif.Name = "ButtonAniGif"
        Me.ButtonAniGif.Size = New System.Drawing.Size(245, 23)
        Me.ButtonAniGif.TabIndex = 0
        Me.ButtonAniGif.Text = "AniGif Control"
        Me.ButtonAniGif.UseVisualStyleBackColor = True
        '
        'ButtonDriveWatcher
        '
        Me.ButtonDriveWatcher.Location = New System.Drawing.Point(3, 32)
        Me.ButtonDriveWatcher.Name = "ButtonDriveWatcher"
        Me.ButtonDriveWatcher.Size = New System.Drawing.Size(245, 23)
        Me.ButtonDriveWatcher.TabIndex = 1
        Me.ButtonDriveWatcher.Text = "DriveWatcher Control"
        Me.ButtonDriveWatcher.UseVisualStyleBackColor = True
        '
        'ButtonIniFilecontrol
        '
        Me.ButtonIniFilecontrol.Location = New System.Drawing.Point(3, 61)
        Me.ButtonIniFilecontrol.Name = "ButtonIniFilecontrol"
        Me.ButtonIniFilecontrol.Size = New System.Drawing.Size(245, 23)
        Me.ButtonIniFilecontrol.TabIndex = 2
        Me.ButtonIniFilecontrol.Text = "IniFile Control"
        Me.ButtonIniFilecontrol.UseVisualStyleBackColor = True
        '
        'ButtonNotifyFormControl
        '
        Me.ButtonNotifyFormControl.Location = New System.Drawing.Point(3, 90)
        Me.ButtonNotifyFormControl.Name = "ButtonNotifyFormControl"
        Me.ButtonNotifyFormControl.Size = New System.Drawing.Size(245, 23)
        Me.ButtonNotifyFormControl.TabIndex = 3
        Me.ButtonNotifyFormControl.Text = "NotifyForm Control"
        Me.ButtonNotifyFormControl.UseVisualStyleBackColor = True
        '
        'ButtonSevenSegmentControl
        '
        Me.ButtonSevenSegmentControl.Location = New System.Drawing.Point(3, 119)
        Me.ButtonSevenSegmentControl.Name = "ButtonSevenSegmentControl"
        Me.ButtonSevenSegmentControl.Size = New System.Drawing.Size(245, 23)
        Me.ButtonSevenSegmentControl.TabIndex = 4
        Me.ButtonSevenSegmentControl.Text = "SevenSegment Control"
        Me.ButtonSevenSegmentControl.UseVisualStyleBackColor = True
        '
        'ButtonShapeControl
        '
        Me.ButtonShapeControl.Location = New System.Drawing.Point(3, 148)
        Me.ButtonShapeControl.Name = "ButtonShapeControl"
        Me.ButtonShapeControl.Size = New System.Drawing.Size(245, 23)
        Me.ButtonShapeControl.TabIndex = 5
        Me.ButtonShapeControl.Text = "Shape Control"
        Me.ButtonShapeControl.UseVisualStyleBackColor = True
        '
        'ButtonTransparentLabelControl
        '
        Me.ButtonTransparentLabelControl.Location = New System.Drawing.Point(3, 177)
        Me.ButtonTransparentLabelControl.Name = "ButtonTransparentLabelControl"
        Me.ButtonTransparentLabelControl.Size = New System.Drawing.Size(245, 23)
        Me.ButtonTransparentLabelControl.TabIndex = 6
        Me.ButtonTransparentLabelControl.Text = "TransparentLabel Control"
        Me.ButtonTransparentLabelControl.UseVisualStyleBackColor = True
        '
        'ButtonWizardControl
        '
        Me.ButtonWizardControl.Location = New System.Drawing.Point(3, 206)
        Me.ButtonWizardControl.Name = "ButtonWizardControl"
        Me.ButtonWizardControl.Size = New System.Drawing.Size(245, 23)
        Me.ButtonWizardControl.TabIndex = 7
        Me.ButtonWizardControl.Text = "Wizard Control"
        Me.ButtonWizardControl.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 244)
        Me.Controls.Add(Me.FlowLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMain"
        Me.FlowLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

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
End Class
