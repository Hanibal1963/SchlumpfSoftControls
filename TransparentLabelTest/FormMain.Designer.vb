<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TransparentLabel1 = New SchlumpfSoft.TransparentLabelControl.TransparentLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.SchlumpfSoft.My.Resources.Resources.Papa_Schlumpf_08
        Me.PictureBox1.Location = New System.Drawing.Point(12, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TransparentLabel1
        '
        Me.TransparentLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.TransparentLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TransparentLabel1.Location = New System.Drawing.Point(73, 9)
        Me.TransparentLabel1.Name = "TransparentLabel1"
        Me.TransparentLabel1.Size = New System.Drawing.Size(266, 143)
        Me.TransparentLabel1.TabIndex = 3
        Me.TransparentLabel1.Text = resources.GetString("TransparentLabel1.Text")
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 263)
        Me.Controls.Add(Me.TransparentLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.Text = "TransparentLabel Test"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents TransparentLabel1 As TransparentLabelControl.TransparentLabel
End Class
