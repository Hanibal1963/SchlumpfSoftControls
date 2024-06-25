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
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Dim Label_ShapeModus As System.Windows.Forms.Label
        Dim Label_LineModus As System.Windows.Forms.Label
        Dim Label_LineWidth As System.Windows.Forms.Label
        Dim Label_LineColor As System.Windows.Forms.Label
        Dim Label_FillColor As System.Windows.Forms.Label
        Me.ComboBox_ShapeModus = New System.Windows.Forms.ComboBox()
        Me.ComboBox_LineModus = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown_LineWidth = New System.Windows.Forms.NumericUpDown()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.Button_LineColor = New System.Windows.Forms.Button()
        Me.Button_FillColor = New System.Windows.Forms.Button()
        Me.Shape1 = New SchlumpfSoft.Controls.ShapeControl.Shape()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        Label_ShapeModus = New System.Windows.Forms.Label()
        Label_LineModus = New System.Windows.Forms.Label()
        Label_LineWidth = New System.Windows.Forms.Label()
        Label_LineColor = New System.Windows.Forms.Label()
        Label_FillColor = New System.Windows.Forms.Label()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_LineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        PictureBox1.Image = Global.ShapeControlTest.My.Resources.Resources.Papa_Schlumpf_08
        PictureBox1.Location = New System.Drawing.Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(201, 197)
        PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        '
        'Label_ShapeModus
        '
        Label_ShapeModus.AutoSize = True
        Label_ShapeModus.Location = New System.Drawing.Point(333, 34)
        Label_ShapeModus.Name = "Label_ShapeModus"
        Label_ShapeModus.Size = New System.Drawing.Size(102, 13)
        Label_ShapeModus.TabIndex = 4
        Label_ShapeModus.Text = "anzuzeigende Form:"
        '
        'Label_LineModus
        '
        Label_LineModus.AutoSize = True
        Label_LineModus.Location = New System.Drawing.Point(333, 71)
        Label_LineModus.Name = "Label_LineModus"
        Label_LineModus.Size = New System.Drawing.Size(133, 13)
        Label_LineModus.TabIndex = 5
        Label_LineModus.Text = "Startpunkt diagonale Linie:"
        '
        'Label_LineWidth
        '
        Label_LineWidth.AutoSize = True
        Label_LineWidth.Location = New System.Drawing.Point(333, 107)
        Label_LineWidth.Name = "Label_LineWidth"
        Label_LineWidth.Size = New System.Drawing.Size(129, 13)
        Label_LineWidth.TabIndex = 6
        Label_LineWidth.Text = "Breite Linie oder Rahmen:"
        '
        'Label_LineColor
        '
        Label_LineColor.AutoSize = True
        Label_LineColor.Location = New System.Drawing.Point(333, 142)
        Label_LineColor.Name = "Label_LineColor"
        Label_LineColor.Size = New System.Drawing.Size(129, 13)
        Label_LineColor.TabIndex = 8
        Label_LineColor.Text = "Farbe Linie oder Rahmen:"
        '
        'Label_FillColor
        '
        Label_FillColor.AutoSize = True
        Label_FillColor.Location = New System.Drawing.Point(333, 177)
        Label_FillColor.Name = "Label_FillColor"
        Label_FillColor.Size = New System.Drawing.Size(157, 13)
        Label_FillColor.TabIndex = 9
        Label_FillColor.Text = "Füllfarbe Rechteck oder Ellipse:"
        '
        'ComboBox_ShapeModus
        '
        Me.ComboBox_ShapeModus.FormattingEnabled = True
        Me.ComboBox_ShapeModus.Location = New System.Drawing.Point(494, 31)
        Me.ComboBox_ShapeModus.Name = "ComboBox_ShapeModus"
        Me.ComboBox_ShapeModus.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox_ShapeModus.TabIndex = 2
        '
        'ComboBox_LineModus
        '
        Me.ComboBox_LineModus.FormattingEnabled = True
        Me.ComboBox_LineModus.Location = New System.Drawing.Point(494, 68)
        Me.ComboBox_LineModus.Name = "ComboBox_LineModus"
        Me.ComboBox_LineModus.Size = New System.Drawing.Size(128, 21)
        Me.ComboBox_LineModus.TabIndex = 3
        '
        'NumericUpDown_LineWidth
        '
        Me.NumericUpDown_LineWidth.Location = New System.Drawing.Point(494, 105)
        Me.NumericUpDown_LineWidth.Name = "NumericUpDown_LineWidth"
        Me.NumericUpDown_LineWidth.Size = New System.Drawing.Size(128, 20)
        Me.NumericUpDown_LineWidth.TabIndex = 7
        Me.NumericUpDown_LineWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button_LineColor
        '
        Me.Button_LineColor.Location = New System.Drawing.Point(494, 142)
        Me.Button_LineColor.Name = "Button_LineColor"
        Me.Button_LineColor.Size = New System.Drawing.Size(128, 20)
        Me.Button_LineColor.TabIndex = 10
        Me.Button_LineColor.Text = "Farbe wählen"
        Me.Button_LineColor.UseVisualStyleBackColor = True
        '
        'Button_FillColor
        '
        Me.Button_FillColor.Location = New System.Drawing.Point(494, 177)
        Me.Button_FillColor.Name = "Button_FillColor"
        Me.Button_FillColor.Size = New System.Drawing.Size(128, 20)
        Me.Button_FillColor.TabIndex = 11
        Me.Button_FillColor.Text = "Farbe wählen"
        Me.Button_FillColor.UseVisualStyleBackColor = True
        '
        'Shape1
        '
        Me.Shape1.DiagonalLineModus = SchlumpfSoft.Controls.ShapeControl.DiagonalLineModes.TopLeftToBottomRight
        Me.Shape1.FillColor = System.Drawing.Color.Gray
        Me.Shape1.LineColor = System.Drawing.Color.Black
        Me.Shape1.LineWidth = 2.0!
        Me.Shape1.Location = New System.Drawing.Point(125, 95)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeModus = SchlumpfSoft.Controls.ShapeControl.ShapeModes.HorizontalLine
        Me.Shape1.Size = New System.Drawing.Size(154, 147)
        Me.Shape1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 298)
        Me.Controls.Add(Me.Shape1)
        Me.Controls.Add(Me.Button_FillColor)
        Me.Controls.Add(Me.Button_LineColor)
        Me.Controls.Add(Label_FillColor)
        Me.Controls.Add(Label_LineColor)
        Me.Controls.Add(Me.NumericUpDown_LineWidth)
        Me.Controls.Add(Label_LineWidth)
        Me.Controls.Add(Label_LineModus)
        Me.Controls.Add(Label_ShapeModus)
        Me.Controls.Add(Me.ComboBox_LineModus)
        Me.Controls.Add(Me.ComboBox_ShapeModus)
        Me.Controls.Add(PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_LineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ComboBox_ShapeModus As ComboBox
    Private WithEvents ComboBox_LineModus As ComboBox
    Private WithEvents NumericUpDown_LineWidth As NumericUpDown
    Private WithEvents ColorDialog As ColorDialog
    Private WithEvents Button_LineColor As Button
    Private WithEvents Button_FillColor As Button
    Private WithEvents Shape1 As SchlumpfSoft.Controls.ShapeControl.Shape
End Class
