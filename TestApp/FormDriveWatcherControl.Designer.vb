<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDriveWatcherControl
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDriveWatcherControl))
        Me.Label_Info = New System.Windows.Forms.Label()
        Me.DriveWatcher1 = New SchlumpfSoft.Controls.DriveWatcherControl.DriveWatcher(Me.components)
        Me.Label_result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Info
        '
        Me.Label_Info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Label_Info, "Label_Info")
        Me.Label_Info.Name = "Label_Info"
        '
        'DriveWatcher1
        '
        '
        'Label_result
        '
        resources.ApplyResources(Me.Label_result, "Label_result")
        Me.Label_result.Name = "Label_result"
        '
        'FormDriveWatcherControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label_result)
        Me.Controls.Add(Me.Label_Info)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormDriveWatcherControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Label_Info As Label
    Private WithEvents DriveWatcher1 As SchlumpfSoft.Controls.DriveWatcherControl.DriveWatcher
    Private WithEvents Label_result As Label
End Class
