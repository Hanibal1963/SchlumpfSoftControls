﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.ComboBox_Ansicht = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown_FramesPerSecound = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown_ZoomFactor = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox_AutoPlay = New System.Windows.Forms.CheckBox()
        Me.Button_Back = New System.Windows.Forms.Button()
        Me.Button_Forward = New System.Windows.Forms.Button()
        Me.Label_Ani = New System.Windows.Forms.Label()
        Me.Label_Ansicht = New System.Windows.Forms.Label()
        Me.CheckBox_CustomDisplaySpeed = New System.Windows.Forms.CheckBox()
        Me.Label_FramesPerSecound = New System.Windows.Forms.Label()
        Me.Label_ZoomFactor = New System.Windows.Forms.Label()
        Me.AniGif1 = New SchlumpfSoft.Controls.AniGifControl.AniGif()
        CType(Me.NumericUpDown_FramesPerSecound, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_ZoomFactor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox_Ansicht
        '
        Me.ComboBox_Ansicht.FormattingEnabled = True
        Me.ComboBox_Ansicht.Location = New System.Drawing.Point(337, 9)
        Me.ComboBox_Ansicht.Name = "ComboBox_Ansicht"
        Me.ComboBox_Ansicht.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Ansicht.TabIndex = 1
        '
        'NumericUpDown_FramesPerSecound
        '
        Me.NumericUpDown_FramesPerSecound.Location = New System.Drawing.Point(408, 105)
        Me.NumericUpDown_FramesPerSecound.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown_FramesPerSecound.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_FramesPerSecound.Name = "NumericUpDown_FramesPerSecound"
        Me.NumericUpDown_FramesPerSecound.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDown_FramesPerSecound.TabIndex = 2
        Me.NumericUpDown_FramesPerSecound.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'NumericUpDown_ZoomFactor
        '
        Me.NumericUpDown_ZoomFactor.Location = New System.Drawing.Point(408, 140)
        Me.NumericUpDown_ZoomFactor.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_ZoomFactor.Name = "NumericUpDown_ZoomFactor"
        Me.NumericUpDown_ZoomFactor.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDown_ZoomFactor.TabIndex = 3
        Me.NumericUpDown_ZoomFactor.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'CheckBox_AutoPlay
        '
        Me.CheckBox_AutoPlay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox_AutoPlay.Location = New System.Drawing.Point(218, 41)
        Me.CheckBox_AutoPlay.Name = "CheckBox_AutoPlay"
        Me.CheckBox_AutoPlay.Size = New System.Drawing.Size(240, 25)
        Me.CheckBox_AutoPlay.TabIndex = 4
        Me.CheckBox_AutoPlay.Text = "Autostart:"
        Me.CheckBox_AutoPlay.UseVisualStyleBackColor = True
        '
        'Button_Back
        '
        Me.Button_Back.Location = New System.Drawing.Point(12, 238)
        Me.Button_Back.Name = "Button_Back"
        Me.Button_Back.Size = New System.Drawing.Size(92, 23)
        Me.Button_Back.TabIndex = 5
        Me.Button_Back.Text = "< zurück"
        Me.Button_Back.UseVisualStyleBackColor = True
        '
        'Button_Forward
        '
        Me.Button_Forward.Location = New System.Drawing.Point(120, 238)
        Me.Button_Forward.Name = "Button_Forward"
        Me.Button_Forward.Size = New System.Drawing.Size(92, 23)
        Me.Button_Forward.TabIndex = 6
        Me.Button_Forward.Text = "vorwärts >"
        Me.Button_Forward.UseVisualStyleBackColor = True
        '
        'Label_Ani
        '
        Me.Label_Ani.Location = New System.Drawing.Point(9, 206)
        Me.Label_Ani.Name = "Label_Ani"
        Me.Label_Ani.Size = New System.Drawing.Size(203, 15)
        Me.Label_Ani.TabIndex = 7
        Me.Label_Ani.Text = "Standard"
        '
        'Label_Ansicht
        '
        Me.Label_Ansicht.AutoSize = True
        Me.Label_Ansicht.Location = New System.Drawing.Point(218, 12)
        Me.Label_Ansicht.Name = "Label_Ansicht"
        Me.Label_Ansicht.Size = New System.Drawing.Size(79, 13)
        Me.Label_Ansicht.TabIndex = 8
        Me.Label_Ansicht.Text = "Anzeigemodus:"
        '
        'CheckBox_CustomDisplaySpeed
        '
        Me.CheckBox_CustomDisplaySpeed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox_CustomDisplaySpeed.Location = New System.Drawing.Point(218, 72)
        Me.CheckBox_CustomDisplaySpeed.Name = "CheckBox_CustomDisplaySpeed"
        Me.CheckBox_CustomDisplaySpeed.Size = New System.Drawing.Size(240, 18)
        Me.CheckBox_CustomDisplaySpeed.TabIndex = 9
        Me.CheckBox_CustomDisplaySpeed.Text = "Benutzerdefinierte Anzeigegeschwindigkeit:"
        Me.CheckBox_CustomDisplaySpeed.UseVisualStyleBackColor = True
        '
        'Label_FramesPerSecound
        '
        Me.Label_FramesPerSecound.AutoSize = True
        Me.Label_FramesPerSecound.Location = New System.Drawing.Point(218, 105)
        Me.Label_FramesPerSecound.Name = "Label_FramesPerSecound"
        Me.Label_FramesPerSecound.Size = New System.Drawing.Size(124, 13)
        Me.Label_FramesPerSecound.TabIndex = 10
        Me.Label_FramesPerSecound.Text = "Anzeigegeschwindigkeit:"
        '
        'Label_ZoomFactor
        '
        Me.Label_ZoomFactor.AutoSize = True
        Me.Label_ZoomFactor.Location = New System.Drawing.Point(218, 142)
        Me.Label_ZoomFactor.Name = "Label_ZoomFactor"
        Me.Label_ZoomFactor.Size = New System.Drawing.Size(64, 13)
        Me.Label_ZoomFactor.TabIndex = 11
        Me.Label_ZoomFactor.Text = "Zoomfaktor:"
        '
        'AniGif1
        '
        Me.AniGif1.AutoPlay = False
        Me.AniGif1.CustomDisplaySpeed = False
        Me.AniGif1.FramesPerSecond = New Decimal(New Integer() {10, 0, 0, 0})
        Me.AniGif1.Gif = CType(resources.GetObject("AniGif1.Gif"), System.Drawing.Bitmap)
        Me.AniGif1.GifSizeMode = SchlumpfSoft.Controls.AniGifControl.SizeMode.Normal
        Me.AniGif1.Location = New System.Drawing.Point(12, 9)
        Me.AniGif1.Name = "AniGif1"
        Me.AniGif1.Size = New System.Drawing.Size(200, 184)
        Me.AniGif1.TabIndex = 12
        Me.AniGif1.ZoomFactor = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 271)
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
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AniGif Test"
        CType(Me.NumericUpDown_FramesPerSecound, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_ZoomFactor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ComboBox_Ansicht As ComboBox
    Private WithEvents NumericUpDown_FramesPerSecound As NumericUpDown
    Private WithEvents NumericUpDown_ZoomFactor As NumericUpDown
    Private WithEvents CheckBox_AutoPlay As CheckBox
    Private WithEvents Button_Back As Button
    Private WithEvents Button_Forward As Button
    Private WithEvents Label_Ani As Label
    Private WithEvents Label_Ansicht As Label
    Private WithEvents CheckBox_CustomDisplaySpeed As CheckBox
    Private WithEvents Label_FramesPerSecound As Label
    Private WithEvents Label_ZoomFactor As Label
    Private WithEvents AniGif1 As Controls.AniGifControl.AniGif
End Class
