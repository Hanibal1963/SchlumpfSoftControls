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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNotifyFormControl))
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
        resources.ApplyResources(Me.Label_ShowTime, "Label_ShowTime")
        Me.Label_ShowTime.Name = "Label_ShowTime"
        '
        'Label_Message
        '
        resources.ApplyResources(Me.Label_Message, "Label_Message")
        Me.Label_Message.Name = "Label_Message"
        '
        'Label_Title
        '
        resources.ApplyResources(Me.Label_Title, "Label_Title")
        Me.Label_Title.Name = "Label_Title"
        '
        'Label_Style
        '
        resources.ApplyResources(Me.Label_Style, "Label_Style")
        Me.Label_Style.Name = "Label_Style"
        '
        'Label_Design
        '
        resources.ApplyResources(Me.Label_Design, "Label_Design")
        Me.Label_Design.Name = "Label_Design"
        '
        'Button_Show
        '
        resources.ApplyResources(Me.Button_Show, "Button_Show")
        Me.Button_Show.Name = "Button_Show"
        Me.Button_Show.UseVisualStyleBackColor = True
        '
        'NumericUpDown_ShowTime
        '
        resources.ApplyResources(Me.NumericUpDown_ShowTime, "NumericUpDown_ShowTime")
        Me.NumericUpDown_ShowTime.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown_ShowTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown_ShowTime.Name = "NumericUpDown_ShowTime"
        Me.NumericUpDown_ShowTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TextBox_Message
        '
        Me.TextBox_Message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TextBox_Message, "TextBox_Message")
        Me.TextBox_Message.Name = "TextBox_Message"
        '
        'TextBox_Title
        '
        Me.TextBox_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TextBox_Title, "TextBox_Title")
        Me.TextBox_Title.Name = "TextBox_Title"
        '
        'ComboBox_Style
        '
        Me.ComboBox_Style.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox_Style, "ComboBox_Style")
        Me.ComboBox_Style.Name = "ComboBox_Style"
        '
        'ComboBox_Design
        '
        Me.ComboBox_Design.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox_Design, "ComboBox_Design")
        Me.ComboBox_Design.Name = "ComboBox_Design"
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
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
