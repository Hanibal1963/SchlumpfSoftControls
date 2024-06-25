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
        Me.Label_Info = New System.Windows.Forms.Label()
        Me.Label_result = New System.Windows.Forms.Label()
        Me.DriveWatcher1 = New SchlumpfSoft.Controls.DriveWatcherControl.DriveWatcher()
        Me.SuspendLayout()
        '
        'Label_Info
        '
        Me.Label_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label_Info.Location = New System.Drawing.Point(12, 19)
        Me.Label_Info.Name = "Label_Info"
        Me.Label_Info.Size = New System.Drawing.Size(365, 37)
        Me.Label_Info.TabIndex = 0
        Me.Label_Info.Text = "Lege eine CD ein, stecke einen USB-Stick oder ein externes Laufwerk an" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "oder füge" &
    " ein virtuelles Laufwerk hinzu und beobachte die Reaktion."
        '
        'Label_result
        '
        Me.Label_result.Location = New System.Drawing.Point(12, 69)
        Me.Label_result.Name = "Label_result"
        Me.Label_result.Size = New System.Drawing.Size(365, 133)
        Me.Label_result.TabIndex = 1
        '
        'DriveWatcher1
        '
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 215)
        Me.Controls.Add(Me.Label_result)
        Me.Controls.Add(Me.Label_Info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DriveWatcher Test"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Label_Info As Label
    Private WithEvents Label_result As Label
    Private WithEvents DriveWatcher1 As SchlumpfSoft.Controls.DriveWatcherControl.DriveWatcher
End Class
