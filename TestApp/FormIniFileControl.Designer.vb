<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormIniFileControl
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
        Dim MenuStrip_HauptMenu As System.Windows.Forms.MenuStrip
        Dim ToolStripMenuItem_Datei As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIniFileControl))
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem_Oeffnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Speichern = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_SpeichernUnter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Beenden = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntrysListEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileListEdit()
        Me.SectionsCommentEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit()
        Me.EntryValueEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileEntryValueEdit()
        Me.SectionsListEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileListEdit()
        Me.IniFileContentView = New SchlumpfSoft.Controls.IniFileControl.IniFileContentView()
        Me.FileCommentEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit()
        Me.IniFile1 = New SchlumpfSoft.Controls.IniFileControl.IniFile()
        MenuStrip_HauptMenu = New System.Windows.Forms.MenuStrip()
        ToolStripMenuItem_Datei = New System.Windows.Forms.ToolStripMenuItem()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        MenuStrip_HauptMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip_HauptMenu
        '
        MenuStrip_HauptMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {ToolStripMenuItem_Datei})
        resources.ApplyResources(MenuStrip_HauptMenu, "MenuStrip_HauptMenu")
        MenuStrip_HauptMenu.Name = "MenuStrip_HauptMenu"
        '
        'ToolStripMenuItem_Datei
        '
        ToolStripMenuItem_Datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Oeffnen, ToolStripSeparator1, Me.ToolStripMenuItem_Speichern, Me.ToolStripMenuItem_SpeichernUnter, ToolStripSeparator2, Me.ToolStripMenuItem_Beenden})
        ToolStripMenuItem_Datei.Name = "ToolStripMenuItem_Datei"
        resources.ApplyResources(ToolStripMenuItem_Datei, "ToolStripMenuItem_Datei")
        '
        'ToolStripMenuItem_Oeffnen
        '
        Me.ToolStripMenuItem_Oeffnen.Name = "ToolStripMenuItem_Oeffnen"
        resources.ApplyResources(Me.ToolStripMenuItem_Oeffnen, "ToolStripMenuItem_Oeffnen")
        '
        'ToolStripSeparator1
        '
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(ToolStripSeparator1, "ToolStripSeparator1")
        '
        'ToolStripMenuItem_Speichern
        '
        Me.ToolStripMenuItem_Speichern.Name = "ToolStripMenuItem_Speichern"
        resources.ApplyResources(Me.ToolStripMenuItem_Speichern, "ToolStripMenuItem_Speichern")
        '
        'ToolStripMenuItem_SpeichernUnter
        '
        Me.ToolStripMenuItem_SpeichernUnter.Name = "ToolStripMenuItem_SpeichernUnter"
        resources.ApplyResources(Me.ToolStripMenuItem_SpeichernUnter, "ToolStripMenuItem_SpeichernUnter")
        '
        'ToolStripSeparator2
        '
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ToolStripMenuItem_Beenden
        '
        Me.ToolStripMenuItem_Beenden.Name = "ToolStripMenuItem_Beenden"
        resources.ApplyResources(Me.ToolStripMenuItem_Beenden, "ToolStripMenuItem_Beenden")
        '
        'EntrysListEdit
        '
        resources.ApplyResources(Me.EntrysListEdit, "EntrysListEdit")
        Me.EntrysListEdit.Name = "EntrysListEdit"
        Me.EntrysListEdit.TitelText = "Eintragsliste:"
        '
        'SectionsCommentEdit
        '
        Me.SectionsCommentEdit.Comment = Nothing
        resources.ApplyResources(Me.SectionsCommentEdit, "SectionsCommentEdit")
        Me.SectionsCommentEdit.Name = "SectionsCommentEdit"
        Me.SectionsCommentEdit.TitelText = "Abschnittskommentar:"
        '
        'EntryValueEdit
        '
        resources.ApplyResources(Me.EntryValueEdit, "EntryValueEdit")
        Me.EntryValueEdit.Name = "EntryValueEdit"
        Me.EntryValueEdit.TitelText = "Eintragswert:"
        Me.EntryValueEdit.Value = ""
        '
        'SectionsListEdit
        '
        resources.ApplyResources(Me.SectionsListEdit, "SectionsListEdit")
        Me.SectionsListEdit.Name = "SectionsListEdit"
        Me.SectionsListEdit.TitelText = "Abschnittsliste:"
        '
        'IniFileContentView
        '
        Me.IniFileContentView.Lines = Nothing
        resources.ApplyResources(Me.IniFileContentView, "IniFileContentView")
        Me.IniFileContentView.Name = "IniFileContentView"
        Me.IniFileContentView.TitelText = "Dateiinhalt:"
        '
        'FileCommentEdit
        '
        Me.FileCommentEdit.Comment = Nothing
        resources.ApplyResources(Me.FileCommentEdit, "FileCommentEdit")
        Me.FileCommentEdit.Name = "FileCommentEdit"
        Me.FileCommentEdit.TitelText = "Dateikommentar:"
        '
        'IniFile1
        '
        Me.IniFile1.AutoSave = False
        Me.IniFile1.CommentPrefix = Global.Microsoft.VisualBasic.ChrW(59)
        Me.IniFile1.FilePath = "D:\Dokumente\NeueDatei.ini"
        '
        'FormIniFileControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EntrysListEdit)
        Me.Controls.Add(Me.SectionsCommentEdit)
        Me.Controls.Add(Me.EntryValueEdit)
        Me.Controls.Add(Me.SectionsListEdit)
        Me.Controls.Add(Me.IniFileContentView)
        Me.Controls.Add(Me.FileCommentEdit)
        Me.Controls.Add(MenuStrip_HauptMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIniFileControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        MenuStrip_HauptMenu.ResumeLayout(False)
        MenuStrip_HauptMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ToolStripMenuItem_Oeffnen As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem_Speichern As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem_SpeichernUnter As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem_Beenden As ToolStripMenuItem
    Private WithEvents IniFile1 As SchlumpfSoft.Controls.IniFileControl.IniFile
    Private WithEvents FileCommentEdit As SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit
    Private WithEvents IniFileContentView As SchlumpfSoft.Controls.IniFileControl.IniFileContentView
    Private WithEvents SectionsListEdit As SchlumpfSoft.Controls.IniFileControl.IniFileListEdit
    Private WithEvents EntryValueEdit As SchlumpfSoft.Controls.IniFileControl.IniFileEntryValueEdit
    Private WithEvents SectionsCommentEdit As SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit
    Private WithEvents EntrysListEdit As SchlumpfSoft.Controls.IniFileControl.IniFileListEdit
End Class
