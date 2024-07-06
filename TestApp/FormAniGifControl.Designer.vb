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
        Me.AniGif1.AutoPlay = False
        Me.AniGif1.CustomDisplaySpeed = False
        Me.AniGif1.FramesPerSecond = New Decimal(New Integer() {10, 0, 0, 0})
        Me.AniGif1.Gif = CType(resources.GetObject("AniGif1.Gif"), System.Drawing.Bitmap)
        Me.AniGif1.GifSizeMode = SchlumpfSoft.Controls.AniGifControl.SizeMode.Normal
        Me.AniGif1.Location = New System.Drawing.Point(24, 30)
        Me.AniGif1.Name = "AniGif1"
        Me.AniGif1.Size = New System.Drawing.Size(200, 184)
        Me.AniGif1.TabIndex = 24
        Me.AniGif1.ZoomFactor = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label_ZoomFactor
        '
        Me.Label_ZoomFactor.AutoSize = True
        Me.Label_ZoomFactor.Location = New System.Drawing.Point(230, 163)
        Me.Label_ZoomFactor.Name = "Label_ZoomFactor"
        Me.Label_ZoomFactor.Size = New System.Drawing.Size(64, 13)
        Me.Label_ZoomFactor.TabIndex = 23
        Me.Label_ZoomFactor.Text = "Zoomfaktor:"
        '
        'Label_FramesPerSecound
        '
        Me.Label_FramesPerSecound.AutoSize = True
        Me.Label_FramesPerSecound.Location = New System.Drawing.Point(230, 126)
        Me.Label_FramesPerSecound.Name = "Label_FramesPerSecound"
        Me.Label_FramesPerSecound.Size = New System.Drawing.Size(124, 13)
        Me.Label_FramesPerSecound.TabIndex = 22
        Me.Label_FramesPerSecound.Text = "Anzeigegeschwindigkeit:"
        '
        'CheckBox_CustomDisplaySpeed
        '
        Me.CheckBox_CustomDisplaySpeed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox_CustomDisplaySpeed.Location = New System.Drawing.Point(230, 93)
        Me.CheckBox_CustomDisplaySpeed.Name = "CheckBox_CustomDisplaySpeed"
        Me.CheckBox_CustomDisplaySpeed.Size = New System.Drawing.Size(240, 18)
        Me.CheckBox_CustomDisplaySpeed.TabIndex = 21
        Me.CheckBox_CustomDisplaySpeed.Text = "Benutzerdefinierte Anzeigegeschwindigkeit:"
        Me.CheckBox_CustomDisplaySpeed.UseVisualStyleBackColor = True
        '
        'Label_Ansicht
        '
        Me.Label_Ansicht.AutoSize = True
        Me.Label_Ansicht.Location = New System.Drawing.Point(230, 33)
        Me.Label_Ansicht.Name = "Label_Ansicht"
        Me.Label_Ansicht.Size = New System.Drawing.Size(79, 13)
        Me.Label_Ansicht.TabIndex = 20
        Me.Label_Ansicht.Text = "Anzeigemodus:"
        '
        'Label_Ani
        '
        Me.Label_Ani.Location = New System.Drawing.Point(21, 227)
        Me.Label_Ani.Name = "Label_Ani"
        Me.Label_Ani.Size = New System.Drawing.Size(203, 15)
        Me.Label_Ani.TabIndex = 19
        Me.Label_Ani.Text = "Standard"
        '
        'Button_Forward
        '
        Me.Button_Forward.Location = New System.Drawing.Point(132, 259)
        Me.Button_Forward.Name = "Button_Forward"
        Me.Button_Forward.Size = New System.Drawing.Size(92, 23)
        Me.Button_Forward.TabIndex = 18
        Me.Button_Forward.Text = "vorwärts >"
        Me.Button_Forward.UseVisualStyleBackColor = True
        '
        'Button_Back
        '
        Me.Button_Back.Location = New System.Drawing.Point(24, 259)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(92, 23)
        Me.Button_Back.TabIndex = 17
        Me.Button_Back.Text = "< zurück"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoPlay
        '
        Me.CheckBox_AutoPlay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox_AutoPlay.Location = New System.Drawing.Point(230, 62)
        Me.CheckBox_AutoPlay.Name = "CheckBox_AutoPlay"
        Me.CheckBox_AutoPlay.Size = New System.Drawing.Size(240, 25)
        Me.CheckBox_AutoPlay.TabIndex = 16
        Me.CheckBox_AutoPlay.Text = "Autostart:"
        Me.CheckBox_AutoPlay.UseVisualStyleBackColor = True
        '
        'NumericUpDown_ZoomFactor
        '
        Me.NumericUpDown_ZoomFactor.Location = New System.Drawing.Point(420, 161)
        Me.NumericUpDown_ZoomFactor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_ZoomFactor.Name = "NumericUpDown_ZoomFactor"
        Me.NumericUpDown_ZoomFactor.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDown_ZoomFactor.TabIndex = 15
        Me.NumericUpDown_ZoomFactor.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'NumericUpDown_FramesPerSecound
        '
        Me.NumericUpDown_FramesPerSecound.Location = New System.Drawing.Point(420, 126)
        Me.NumericUpDown_FramesPerSecound.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown_FramesPerSecound.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FramesPerSecound.Name = "NumericUpDown_FramesPerSecound"
        Me.NumericUpDown_FramesPerSecound.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDown_FramesPerSecound.TabIndex = 14
        Me.NumericUpDown_FramesPerSecound.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'ComboBox_Ansicht
        '
        Me.ComboBox_Ansicht.FormattingEnabled = True
        Me.ComboBox_Ansicht.Location = New System.Drawing.Point(349, 30)
        Me.ComboBox_Ansicht.Name = "ComboBox_Ansicht"
        Me.ComboBox_Ansicht.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Ansicht.TabIndex = 13
        '
        'FormAniGifControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 299)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AniGif - Control -Test"
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
