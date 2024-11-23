<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAniGifControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAniGifControl))
        Me.AniGif1 = New SchlumpfSoft.Controls.AniGifControl.AniGif()
        Me.Label_ZoomFactor = New System.Windows.Forms.Label()
        Me.Label_FramesPerSecound = New System.Windows.Forms.Label()
        Me.CheckBox_CustomDisplaySpeed = New System.Windows.Forms.CheckBox()
        Me.Label_Ansicht = New System.Windows.Forms.Label()
        Me.Label_Ani = New System.Windows.Forms.Label()
        Me.Button_Forward = New System.Windows.Forms.Button()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.CheckBox_AutoPlay = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown_ZoomFactor = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_FramesPerSecound = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox_Ansicht = New System.Windows.Forms.ComboBox()
        CType(Me.NumericUpDown_ZoomFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_FramesPerSecound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AniGif1
        '
        resources.ApplyResources(Me.AniGif1, "AniGif1")
        Me.AniGif1.AutoPlay = False
        Me.AniGif1.CustomDisplaySpeed = False
        Me.AniGif1.FramesPerSecond = New Decimal(New Integer() {10, 0, 0, 0})
        Me.AniGif1.Gif = CType(resources.GetObject("AniGif1.Gif"), System.Drawing.Bitmap)
        Me.AniGif1.GifSizeMode = SchlumpfSoft.Controls.AniGifControl.SizeMode.Normal
        Me.AniGif1.Name = "AniGif1"
        Me.AniGif1.ZoomFactor = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label_ZoomFactor
        '
        resources.ApplyResources(Me.Label_ZoomFactor, "Label_ZoomFactor")
        Me.Label_ZoomFactor.Name = "Label_ZoomFactor"
        '
        'Label_FramesPerSecound
        '
        resources.ApplyResources(Me.Label_FramesPerSecound, "Label_FramesPerSecound")
        Me.Label_FramesPerSecound.Name = "Label_FramesPerSecound"
        '
        'CheckBox_CustomDisplaySpeed
        '
        resources.ApplyResources(Me.CheckBox_CustomDisplaySpeed, "CheckBox_CustomDisplaySpeed")
        Me.CheckBox_CustomDisplaySpeed.Name = "CheckBox_CustomDisplaySpeed"
        Me.CheckBox_CustomDisplaySpeed.UseVisualStyleBackColor = True
        '
        'Label_Ansicht
        '
        resources.ApplyResources(Me.Label_Ansicht, "Label_Ansicht")
        Me.Label_Ansicht.Name = "Label_Ansicht"
        '
        'Label_Ani
        '
        resources.ApplyResources(Me.Label_Ani, "Label_Ani")
        Me.Label_Ani.Name = "Label_Ani"
        '
        'Button_Forward
        '
        resources.ApplyResources(Me.Button_Forward, "Button_Forward")
        Me.Button_Forward.Name = "Button_Forward"
        Me.Button_Forward.UseVisualStyleBackColor = True
        '
        'Button_Back
        '
        resources.ApplyResources(Me.Button_Back, "Button_Back")
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoPlay
        '
        resources.ApplyResources(Me.CheckBox_AutoPlay, "CheckBox_AutoPlay")
        Me.CheckBox_AutoPlay.Name = "CheckBox_AutoPlay"
        Me.CheckBox_AutoPlay.UseVisualStyleBackColor = True
        '
        'NumericUpDown_ZoomFactor
        '
        resources.ApplyResources(Me.NumericUpDown_ZoomFactor, "NumericUpDown_ZoomFactor")
        Me.NumericUpDown_ZoomFactor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_ZoomFactor.Name = "NumericUpDown_ZoomFactor"
        Me.NumericUpDown_ZoomFactor.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDown_FramesPerSecound
        '
        resources.ApplyResources(Me.NumericUpDown_FramesPerSecound, "NumericUpDown_FramesPerSecound")
        Me.NumericUpDown_FramesPerSecound.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown_FramesPerSecound.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FramesPerSecound.Name = "NumericUpDown_FramesPerSecound"
        Me.NumericUpDown_FramesPerSecound.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ComboBox_Ansicht
        '
        resources.ApplyResources(Me.ComboBox_Ansicht, "ComboBox_Ansicht")
        Me.ComboBox_Ansicht.FormattingEnabled = True
        Me.ComboBox_Ansicht.Name = "ComboBox_Ansicht"
        '
        'FormAniGifControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AniGif1)
        Me.Controls.Add(Me.Label_ZoomFactor)
        Me.Controls.Add(Me.Label_FramesPerSecound)
        Me.Controls.Add(Me.CheckBox_CustomDisplaySpeed)
        Me.Controls.Add(Me.Label_Ansicht)
        Me.Controls.Add(Me.Label_Ani)
        Me.Controls.Add(Me.Button_Forward)
        Me.Controls.Add(Me.Button_Back)
        Me.Controls.Add(Me.CheckBox_AutoPlay)
        Me.Controls.Add(Me.NumericUpDown_ZoomFactor)
        Me.Controls.Add(Me.NumericUpDown_FramesPerSecound)
        Me.Controls.Add(Me.ComboBox_Ansicht)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAniGifControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.NumericUpDown_ZoomFactor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_FramesPerSecound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents AniGif1 As SchlumpfSoft.Controls.AniGifControl.AniGif
    Private WithEvents Label_ZoomFactor As Label
    Private WithEvents Label_FramesPerSecound As Label
    Private WithEvents CheckBox_CustomDisplaySpeed As CheckBox
    Private WithEvents Label_Ansicht As Label
    Private WithEvents Label_Ani As Label
    Private WithEvents Button_Forward As Button
    Private WithEvents Button_Back As Button
    Private WithEvents CheckBox_AutoPlay As CheckBox
    Private WithEvents NumericUpDown_ZoomFactor As NumericUpDown
    Private WithEvents NumericUpDown_FramesPerSecound As NumericUpDown
    Private WithEvents ComboBox_Ansicht As ComboBox
End Class
