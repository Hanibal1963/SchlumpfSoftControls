<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.SevSegSingleDigit1 = New SchlumpfSoft.Controls.SevenSegmentControl.SevSegSingleDigit()
        Me.SevSegMultiDigit1 = New SchlumpfSoft.Controls.SevenSegmentControl.SevSegMultiDigit()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SevSegSingleDigit1
        '
        Me.SevSegSingleDigit1.ColonActive = False
        Me.SevSegSingleDigit1.CustomBitPattern = 0
        Me.SevSegSingleDigit1.DecimalPointActive = False
        Me.SevSegSingleDigit1.DigitValue = Nothing
        Me.SevSegSingleDigit1.InactiveColor = System.Drawing.Color.DarkGray
        Me.SevSegSingleDigit1.ItalicFactor = -0.1!
        Me.SevSegSingleDigit1.Location = New System.Drawing.Point(176, 12)
        Me.SevSegSingleDigit1.Name = "SevSegSingleDigit1"
        Me.SevSegSingleDigit1.Padding = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.SevSegSingleDigit1.SegmentWidth = 10
        Me.SevSegSingleDigit1.ShowColon = False
        Me.SevSegSingleDigit1.ShowDecimalPoint = True
        Me.SevSegSingleDigit1.Size = New System.Drawing.Size(60, 80)
        Me.SevSegSingleDigit1.TabIndex = 0
        Me.SevSegSingleDigit1.TabStop = False
        '
        'SevSegMultiDigit1
        '
        Me.SevSegMultiDigit1.DigitCount = 2
        Me.SevSegMultiDigit1.DigitPadding = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.SevSegMultiDigit1.InactiveColor = System.Drawing.Color.DarkGray
        Me.SevSegMultiDigit1.ItalicFactor = -0.1!
        Me.SevSegMultiDigit1.Location = New System.Drawing.Point(298, 12)
        Me.SevSegMultiDigit1.Name = "SevSegMultiDigit1"
        Me.SevSegMultiDigit1.SegmentWidth = 10
        Me.SevSegMultiDigit1.ShowDecimalPoint = True
        Me.SevSegMultiDigit1.Size = New System.Drawing.Size(120, 80)
        Me.SevSegMultiDigit1.TabIndex = 1
        Me.SevSegMultiDigit1.TabStop = False
        Me.SevSegMultiDigit1.Value = Nothing
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(176, 112)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(101, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.WordWrap = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(298, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(101, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.WordWrap = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Zeichen eingeben ---------------> "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 196)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SevSegMultiDigit1)
        Me.Controls.Add(Me.SevSegSingleDigit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents SevSegSingleDigit1 As SchlumpfSoft.Controls.SevenSegmentControl.SevSegSingleDigit
    Private WithEvents SevSegMultiDigit1 As SchlumpfSoft.Controls.SevenSegmentControl.SevSegMultiDigit
    Private WithEvents TextBox1 As TextBox
    Private WithEvents TextBox2 As TextBox
    Private WithEvents Label1 As Label
End Class
