<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNotifyFormControl
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
        Me.Label_ShowTime = New System.Windows.Forms.Label()
        Me.Label_Message = New System.Windows.Forms.Label()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Label_Style = New System.Windows.Forms.Label()
        Me.Label_Design = New System.Windows.Forms.Label()
        Me.Button_Show = New System.Windows.Forms.Button()
        Me.NumericUpDown_ShowTime = New System.Windows.Forms.NumericUpDown()
        Me.TextBox_Message = New System.Windows.Forms.TextBox()
        Me.TextBox_Title = New System.Windows.Forms.TextBox()
        Me.ComboBox_Style = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Design = New System.Windows.Forms.ComboBox()
        Me.NotifyForm1 = New SchlumpfSoft.Controls.NotifyFormControl.NotifyForm()
        CType(Me.NumericUpDown_ShowTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_ShowTime
        '
        Me.Label_ShowTime.AutoSize = True
        Me.Label_ShowTime.Location = New System.Drawing.Point(14, 184)
        Me.Label_ShowTime.Name = "Label_ShowTime"
        Me.Label_ShowTime.Size = New System.Drawing.Size(64, 13)
        Me.Label_ShowTime.TabIndex = 21
        Me.Label_ShowTime.Text = "Anzeigezeit:"
        '
        'Label_Message
        '
        Me.Label_Message.AutoSize = True
        Me.Label_Message.Location = New System.Drawing.Point(14, 107)
        Me.Label_Message.Name = "Label_Message"
        Me.Label_Message.Size = New System.Drawing.Size(77, 13)
        Me.Label_Message.TabIndex = 20
        Me.Label_Message.Text = "Mitteilungstext:"
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Location = New System.Drawing.Point(14, 74)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(61, 13)
        Me.Label_Title.TabIndex = 19
        Me.Label_Title.Text = "Fenstertitel:"
        '
        'Label_Style
        '
        Me.Label_Style.AutoSize = True
        Me.Label_Style.Location = New System.Drawing.Point(14, 44)
        Me.Label_Style.Name = "Label_Style"
        Me.Label_Style.Size = New System.Drawing.Size(33, 13)
        Me.Label_Style.TabIndex = 18
        Me.Label_Style.Text = "Style:"
        '
        'Label_Design
        '
        Me.Label_Design.AutoSize = True
        Me.Label_Design.Location = New System.Drawing.Point(14, 15)
        Me.Label_Design.Name = "Label_Design"
        Me.Label_Design.Size = New System.Drawing.Size(43, 13)
        Me.Label_Design.TabIndex = 17
        Me.Label_Design.Text = "Design:"
        '
        'Button_Show
        '
        Me.Button_Show.Location = New System.Drawing.Point(157, 218)
        Me.Button_Show.Name = "Button_Show"
        Me.Button_Show.Size = New System.Drawing.Size(102, 23)
        Me.Button_Show.TabIndex = 16
        Me.Button_Show.Text = "Fenster anzeigen"
        Me.Button_Show.UseVisualStyleBackColor = True
        '
        'NumericUpDown_ShowTime
        '
        Me.NumericUpDown_ShowTime.Location = New System.Drawing.Point(199, 182)
        Me.NumericUpDown_ShowTime.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown_ShowTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_ShowTime.Name = "NumericUpDown_ShowTime"
        Me.NumericUpDown_ShowTime.Size = New System.Drawing.Size(60, 20)
        Me.NumericUpDown_ShowTime.TabIndex = 15
        Me.NumericUpDown_ShowTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TextBox_Message
        '
        Me.TextBox_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Message.Location = New System.Drawing.Point(97, 105)
        Me.TextBox_Message.Multiline = True
        Me.TextBox_Message.Name = "TextBox_Message"
        Me.TextBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Message.Size = New System.Drawing.Size(162, 71)
        Me.TextBox_Message.TabIndex = 14
        Me.TextBox_Message.WordWrap = False
        '
        'TextBox_Title
        '
        Me.TextBox_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Title.Location = New System.Drawing.Point(99, 72)
        Me.TextBox_Title.Name = "TextBox_Title"
        Me.TextBox_Title.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_Title.Size = New System.Drawing.Size(160, 20)
        Me.TextBox_Title.TabIndex = 13
        Me.TextBox_Title.WordWrap = False
        '
        'ComboBox_Style
        '
        Me.ComboBox_Style.FormattingEnabled = True
        Me.ComboBox_Style.Location = New System.Drawing.Point(99, 41)
        Me.ComboBox_Style.Name = "ComboBox_Style"
        Me.ComboBox_Style.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox_Style.TabIndex = 12
        '
        'ComboBox_Design
        '
        Me.ComboBox_Design.FormattingEnabled = True
        Me.ComboBox_Design.Location = New System.Drawing.Point(99, 12)
        Me.ComboBox_Design.Name = "ComboBox_Design"
        Me.ComboBox_Design.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox_Design.TabIndex = 11
        '
        'NotifyForm1
        '
        Me.NotifyForm1.Design = SchlumpfSoft.Controls.NotifyFormControl.FormDesign.Bright
        Me.NotifyForm1.Message = "Fensternachricht"
        Me.NotifyForm1.ShowTime = 5000
        Me.NotifyForm1.Style = SchlumpfSoft.Controls.NotifyFormControl.FormStyle.Information
        Me.NotifyForm1.Title = "Fenstertitel"
        '
        'FormNotifyFormControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 256)
        Me.Controls.Add(Me.Label_ShowTime)
        Me.Controls.Add(Me.Label_Message)
        Me.Controls.Add(Me.Label_Title)
        Me.Controls.Add(Me.Label_Style)
        Me.Controls.Add(Me.Label_Design)
        Me.Controls.Add(Me.Button_Show)
        Me.Controls.Add(Me.NumericUpDown_ShowTime)
        Me.Controls.Add(Me.TextBox_Message)
        Me.Controls.Add(Me.TextBox_Title)
        Me.Controls.Add(Me.ComboBox_Style)
        Me.Controls.Add(Me.ComboBox_Design)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormNotifyFormControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "NotifyForm - Control - Test"
        CType(Me.NumericUpDown_ShowTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label_ShowTime As Label
    Private WithEvents Label_Message As Label
    Private WithEvents Label_Title As Label
    Private WithEvents Label_Style As Label
    Private WithEvents Label_Design As Label
    Private WithEvents Button_Show As Button
    Private WithEvents NumericUpDown_ShowTime As NumericUpDown
    Private WithEvents TextBox_Message As TextBox
    Private WithEvents TextBox_Title As TextBox
    Private WithEvents ComboBox_Style As ComboBox
    Private WithEvents ComboBox_Design As ComboBox
    Private WithEvents NotifyForm1 As SchlumpfSoft.Controls.NotifyFormControl.NotifyForm
End Class
