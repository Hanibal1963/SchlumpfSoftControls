<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSevenSegmentControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSevenSegmentControl))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SevSegMultiDigit1 = New SchlumpfSoft.Controls.SevenSegmentControl.SevSegMultiDigit()
        Me.SevSegSingleDigit1 = New SchlumpfSoft.Controls.SevenSegmentControl.SevSegSingleDigit()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TextBox2, "TextBox2")
        Me.TextBox2.Name = "TextBox2"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'SevSegMultiDigit1
        '
        Me.SevSegMultiDigit1.DigitCount = 1
        Me.SevSegMultiDigit1.DigitPadding = New System.Windows.Forms.Padding(10, 4, 10, 4)
        Me.SevSegMultiDigit1.InactiveColor = System.Drawing.Color.DarkGray
        Me.SevSegMultiDigit1.ItalicFactor = -0.1!
        resources.ApplyResources(Me.SevSegMultiDigit1, "SevSegMultiDigit1")
        Me.SevSegMultiDigit1.Name = "SevSegMultiDigit1"
        Me.SevSegMultiDigit1.SegmentWidth = 10
        Me.SevSegMultiDigit1.ShowDecimalPoint = True
        Me.SevSegMultiDigit1.TabStop = False
        Me.SevSegMultiDigit1.Value = Nothing
        '
        'SevSegSingleDigit1
        '
        Me.SevSegSingleDigit1.ColonActive = False
        Me.SevSegSingleDigit1.CustomBitPattern = 0
        Me.SevSegSingleDigit1.DecimalPointActive = False
        Me.SevSegSingleDigit1.DigitValue = ""
        Me.SevSegSingleDigit1.InactiveColor = System.Drawing.Color.DarkGray
        Me.SevSegSingleDigit1.ItalicFactor = -0.1!
        resources.ApplyResources(Me.SevSegSingleDigit1, "SevSegSingleDigit1")
        Me.SevSegSingleDigit1.Name = "SevSegSingleDigit1"
        Me.SevSegSingleDigit1.SegmentWidth = 10
        Me.SevSegSingleDigit1.ShowColon = False
        Me.SevSegSingleDigit1.ShowDecimalPoint = True
        Me.SevSegSingleDigit1.TabStop = False
        '
        'FormSevenSegmentControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SevSegMultiDigit1)
        Me.Controls.Add(Me.SevSegSingleDigit1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSevenSegmentControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label1 As Label
    Private WithEvents TextBox2 As TextBox
    Private WithEvents TextBox1 As TextBox
    Private WithEvents SevSegMultiDigit1 As SchlumpfSoft.Controls.SevenSegmentControl.SevSegMultiDigit
    Private WithEvents SevSegSingleDigit1 As SchlumpfSoft.Controls.SevenSegmentControl.SevSegSingleDigit
    Private WithEvents Label2 As Label
End Class
