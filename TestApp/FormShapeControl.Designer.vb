<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormShapeControl
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
        Dim Label_FillColor As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormShapeControl))
        Dim Label_LineColor As System.Windows.Forms.Label
        Dim Label_LineWidth As System.Windows.Forms.Label
        Dim Label_LineModus As System.Windows.Forms.Label
        Dim Label_ShapeModus As System.Windows.Forms.Label
        Dim PictureBox1 As System.Windows.Forms.PictureBox
        Me.Shape1 = New SchlumpfSoft.Controls.ShapeControl.Shape()
        Me.Button_FillColor = New System.Windows.Forms.Button()
        Me.Button_LineColor = New System.Windows.Forms.Button()
        Me.NumericUpDown_LineWidth = New System.Windows.Forms.NumericUpDown()
        Me.ComboBox_LineModus = New System.Windows.Forms.ComboBox()
        Me.ComboBox_ShapeModus = New System.Windows.Forms.ComboBox()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Label_FillColor = New System.Windows.Forms.Label()
        Label_LineColor = New System.Windows.Forms.Label()
        Label_LineWidth = New System.Windows.Forms.Label()
        Label_LineModus = New System.Windows.Forms.Label()
        Label_ShapeModus = New System.Windows.Forms.Label()
        PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown_LineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_FillColor
        '
        resources.ApplyResources(Label_FillColor, "Label_FillColor")
        Label_FillColor.Name = "Label_FillColor"
        '
        'Label_LineColor
        '
        resources.ApplyResources(Label_LineColor, "Label_LineColor")
        Label_LineColor.Name = "Label_LineColor"
        '
        'Label_LineWidth
        '
        resources.ApplyResources(Label_LineWidth, "Label_LineWidth")
        Label_LineWidth.Name = "Label_LineWidth"
        '
        'Label_LineModus
        '
        resources.ApplyResources(Label_LineModus, "Label_LineModus")
        Label_LineModus.Name = "Label_LineModus"
        '
        'Label_ShapeModus
        '
        resources.ApplyResources(Label_ShapeModus, "Label_ShapeModus")
        Label_ShapeModus.Name = "Label_ShapeModus"
        '
        'PictureBox1
        '
        PictureBox1.Image = Global.TestApp.My.Resources.Resources.Papa_Schlumpf_08
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        '
        'Shape1
        '
        Me.Shape1.DiagonalLineModus = SchlumpfSoft.Controls.ShapeControl.DiagonalLineModes.TopLeftToBottomRight
        Me.Shape1.FillColor = System.Drawing.Color.Gray
        Me.Shape1.LineColor = System.Drawing.Color.Black
        Me.Shape1.LineWidth = 2.0!
        resources.ApplyResources(Me.Shape1, "Shape1")
        Me.Shape1.Name = "Shape1"
        Me.Shape1.ShapeModus = SchlumpfSoft.Controls.ShapeControl.ShapeModes.HorizontalLine
        '
        'Button_FillColor
        '
        resources.ApplyResources(Me.Button_FillColor, "Button_FillColor")
        Me.Button_FillColor.Name = "Button_FillColor"
        Me.Button_FillColor.UseVisualStyleBackColor = True
        '
        'Button_LineColor
        '
        resources.ApplyResources(Me.Button_LineColor, "Button_LineColor")
        Me.Button_LineColor.Name = "Button_LineColor"
        Me.Button_LineColor.UseVisualStyleBackColor = True
        '
        'NumericUpDown_LineWidth
        '
        resources.ApplyResources(Me.NumericUpDown_LineWidth, "NumericUpDown_LineWidth")
        Me.NumericUpDown_LineWidth.Name = "NumericUpDown_LineWidth"
        Me.NumericUpDown_LineWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ComboBox_LineModus
        '
        Me.ComboBox_LineModus.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox_LineModus, "ComboBox_LineModus")
        Me.ComboBox_LineModus.Name = "ComboBox_LineModus"
        '
        'ComboBox_ShapeModus
        '
        Me.ComboBox_ShapeModus.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBox_ShapeModus, "ComboBox_ShapeModus")
        Me.ComboBox_ShapeModus.Name = "ComboBox_ShapeModus"
        '
        'FormShapeControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Name = "FormShapeControl"
        CType(PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown_LineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Shape1 As SchlumpfSoft.Controls.ShapeControl.Shape
    Private WithEvents Button_FillColor As Button
    Private WithEvents Button_LineColor As Button
    Private WithEvents NumericUpDown_LineWidth As NumericUpDown
    Private WithEvents ComboBox_LineModus As ComboBox
    Private WithEvents ComboBox_ShapeModus As ComboBox
    Private WithEvents ColorDialog As ColorDialog
End Class
