<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormColorProgressBarControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormColorProgressBarControl))
        Me.ColorProgressBar = New SchlumpfSoft.Controls.ColorProgressBarControl.ColorProgressBar()
        Me.CheckBoxShowBorder = New System.Windows.Forms.CheckBox()
        Me.CheckBoxShowGliss = New System.Windows.Forms.CheckBox()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ButtonBarColor = New System.Windows.Forms.Button()
        Me.ButtonEmptyColor = New System.Windows.Forms.Button()
        Me.ButtonBorderColor = New System.Windows.Forms.Button()
        Me.NumericUpDownProgressValue = New System.Windows.Forms.NumericUpDown()
        CType(Me.NumericUpDownProgressValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColorProgressBar
        '
        Me.ColorProgressBar.BackColor = System.Drawing.Color.Black
        Me.ColorProgressBar.BarColor = System.Drawing.Color.Blue
        Me.ColorProgressBar.BorderColor = System.Drawing.Color.Black
        Me.ColorProgressBar.EmptyColor = System.Drawing.Color.LightGray
        resources.ApplyResources(Me.ColorProgressBar, "ColorProgressBar")
        Me.ColorProgressBar.Name = "ColorProgressBar"
        '
        'CheckBoxShowBorder
        '
        resources.ApplyResources(Me.CheckBoxShowBorder, "CheckBoxShowBorder")
        Me.CheckBoxShowBorder.Checked = True
        Me.CheckBoxShowBorder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxShowBorder.Name = "CheckBoxShowBorder"
        Me.CheckBoxShowBorder.UseVisualStyleBackColor = True
        '
        'CheckBoxShowGliss
        '
        resources.ApplyResources(Me.CheckBoxShowGliss, "CheckBoxShowGliss")
        Me.CheckBoxShowGliss.Checked = True
        Me.CheckBoxShowGliss.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxShowGliss.Name = "CheckBoxShowGliss"
        Me.CheckBoxShowGliss.UseVisualStyleBackColor = True
        '
        'ButtonBarColor
        '
        resources.ApplyResources(Me.ButtonBarColor, "ButtonBarColor")
        Me.ButtonBarColor.Name = "ButtonBarColor"
        Me.ButtonBarColor.UseVisualStyleBackColor = True
        '
        'ButtonEmptyColor
        '
        resources.ApplyResources(Me.ButtonEmptyColor, "ButtonEmptyColor")
        Me.ButtonEmptyColor.Name = "ButtonEmptyColor"
        Me.ButtonEmptyColor.UseVisualStyleBackColor = True
        '
        'ButtonBorderColor
        '
        resources.ApplyResources(Me.ButtonBorderColor, "ButtonBorderColor")
        Me.ButtonBorderColor.Name = "ButtonBorderColor"
        Me.ButtonBorderColor.UseVisualStyleBackColor = True
        '
        'NumericUpDownProgressValue
        '
        resources.ApplyResources(Me.NumericUpDownProgressValue, "NumericUpDownProgressValue")
        Me.NumericUpDownProgressValue.Name = "NumericUpDownProgressValue"
        '
        'FormColorProgressBarControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NumericUpDownProgressValue)
        Me.Controls.Add(Me.ButtonBorderColor)
        Me.Controls.Add(Me.ButtonEmptyColor)
        Me.Controls.Add(Me.ButtonBarColor)
        Me.Controls.Add(Me.CheckBoxShowGliss)
        Me.Controls.Add(Me.CheckBoxShowBorder)
        Me.Controls.Add(Me.ColorProgressBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormColorProgressBarControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.NumericUpDownProgressValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ColorProgressBar As SchlumpfSoft.Controls.ColorProgressBarControl.ColorProgressBar
    Private WithEvents CheckBoxShowBorder As CheckBox
    Private WithEvents CheckBoxShowGliss As CheckBox
    Private WithEvents ColorDialog As ColorDialog
    Private WithEvents ButtonBarColor As Button
    Private WithEvents ButtonEmptyColor As Button
    Private WithEvents ButtonBorderColor As Button
    Private WithEvents NumericUpDownProgressValue As NumericUpDown
End Class
