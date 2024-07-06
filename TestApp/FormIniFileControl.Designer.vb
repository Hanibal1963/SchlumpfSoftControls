<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIniFileControl
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
        Dim MenuStrip_HauptMenu As System.Windows.Forms.MenuStrip
        Dim ToolStripMenuItem_Datei As System.Windows.Forms.ToolStripMenuItem
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Me.IniFileContentView = New SchlumpfSoft.Controls.IniFileControl.IniFileContentView()
        Me.EntryValueEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileEntryValueEdit()
        Me.EntrysListEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileListEdit()
        Me.SectionsListEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileListEdit()
        Me.SectionsCommentEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit()
        Me.FileCommentEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit()
        Me.IniFile1 = New SchlumpfSoft.Controls.IniFileControl.IniFile()
        Me.ToolStripMenuItem_Oeffnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Speichern = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_SpeichernUnter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Beenden = New System.Windows.Forms.ToolStripMenuItem()
        MenuStrip_HauptMenu = New System.Windows.Forms.MenuStrip()
        ToolStripMenuItem_Datei = New System.Windows.Forms.ToolStripMenuItem()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        MenuStrip_HauptMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'IniFileContentView
        '
        Me.IniFileContentView.Lines = Nothing
        Me.IniFileContentView.Location = New System.Drawing.Point(664, 38)
        Me.IniFileContentView.Name = "IniFileContentView"
        Me.IniFileContentView.Size = New System.Drawing.Size(264, 297)
        Me.IniFileContentView.TabIndex = 19
        Me.IniFileContentView.TabStop = False
        Me.IniFileContentView.Text = "Dateiinhalt"
        '
        'EntryValueEdit
        '
        Me.EntryValueEdit.Location = New System.Drawing.Point(664, 341)
        Me.EntryValueEdit.Name = "EntryValueEdit"
        Me.EntryValueEdit.Size = New System.Drawing.Size(264, 77)
        Me.EntryValueEdit.TabIndex = 18
        Me.EntryValueEdit.TabStop = False
        Me.EntryValueEdit.Text = "Eintragswert"
        Me.EntryValueEdit.Value = ""
        '
        'EntrysListEdit
        '
        Me.EntrysListEdit.Location = New System.Drawing.Point(339, 217)
        Me.EntrysListEdit.Name = "EntrysListEdit"
        Me.EntrysListEdit.Size = New System.Drawing.Size(316, 201)
        Me.EntrysListEdit.TabIndex = 17
        Me.EntrysListEdit.TabStop = False
        Me.EntrysListEdit.Text = "Eintragsliste"
        '
        'SectionsListEdit
        '
        Me.SectionsListEdit.Location = New System.Drawing.Point(12, 217)
        Me.SectionsListEdit.Name = "SectionsListEdit"
        Me.SectionsListEdit.Size = New System.Drawing.Size(321, 201)
        Me.SectionsListEdit.TabIndex = 16
        Me.SectionsListEdit.TabStop = False
        Me.SectionsListEdit.Text = "Abschnittsliste"
        '
        'SectionsCommentEdit
        '
        Me.SectionsCommentEdit.Comment = New String(-1) {}
        Me.SectionsCommentEdit.Location = New System.Drawing.Point(339, 38)
        Me.SectionsCommentEdit.Name = "SectionsCommentEdit"
        Me.SectionsCommentEdit.Size = New System.Drawing.Size(316, 164)
        Me.SectionsCommentEdit.TabIndex = 15
        Me.SectionsCommentEdit.TabStop = False
        Me.SectionsCommentEdit.Text = "Abschnittskommentar"
        '
        'FileCommentEdit
        '
        Me.FileCommentEdit.Comment = New String(-1) {}
        Me.FileCommentEdit.Location = New System.Drawing.Point(12, 38)
        Me.FileCommentEdit.Name = "FileCommentEdit"
        Me.FileCommentEdit.Size = New System.Drawing.Size(321, 164)
        Me.FileCommentEdit.TabIndex = 14
        Me.FileCommentEdit.TabStop = False
        Me.FileCommentEdit.Text = "Dateikommentar"
        '
        'IniFile1
        '
        Me.IniFile1.AutoSave = True
        Me.IniFile1.CommentPrefix = Global.Microsoft.VisualBasic.ChrW(59)
        Me.IniFile1.FilePath = "D:\Dokumente\NeueDatei.ini"
        '
        'MenuStrip_HauptMenu
        '
        MenuStrip_HauptMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {ToolStripMenuItem_Datei})
        MenuStrip_HauptMenu.Location = New System.Drawing.Point(0, 0)
        MenuStrip_HauptMenu.Name = "MenuStrip_HauptMenu"
        MenuStrip_HauptMenu.Size = New System.Drawing.Size(939, 24)
        MenuStrip_HauptMenu.TabIndex = 13
        '
        'ToolStripMenuItem_Datei
        '
        ToolStripMenuItem_Datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Oeffnen, ToolStripSeparator1, Me.ToolStripMenuItem_Speichern, Me.ToolStripMenuItem_SpeichernUnter, ToolStripSeparator2, Me.ToolStripMenuItem_Beenden})
        ToolStripMenuItem_Datei.Name = "ToolStripMenuItem_Datei"
        ToolStripMenuItem_Datei.Size = New System.Drawing.Size(46, 20)
        ToolStripMenuItem_Datei.Text = "Datei"
        '
        'ToolStripMenuItem_Oeffnen
        '
        Me.ToolStripMenuItem_Oeffnen.Name = "ToolStripMenuItem_Oeffnen"
        Me.ToolStripMenuItem_Oeffnen.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem_Oeffnen.Text = "Öffnen ..."
        '
        'ToolStripSeparator1
        '
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New System.Drawing.Size(166, 6)
        '
        'ToolStripMenuItem_Speichern
        '
        Me.ToolStripMenuItem_Speichern.Name = "ToolStripMenuItem_Speichern"
        Me.ToolStripMenuItem_Speichern.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem_Speichern.Text = "Speichern"
        '
        'ToolStripMenuItem_SpeichernUnter
        '
        Me.ToolStripMenuItem_SpeichernUnter.Name = "ToolStripMenuItem_SpeichernUnter"
        Me.ToolStripMenuItem_SpeichernUnter.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem_SpeichernUnter.Text = "Speichern unter ..."
        '
        'ToolStripSeparator2
        '
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New System.Drawing.Size(166, 6)
        '
        'ToolStripMenuItem_Beenden
        '
        Me.ToolStripMenuItem_Beenden.Name = "ToolStripMenuItem_Beenden"
        Me.ToolStripMenuItem_Beenden.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem_Beenden.Text = "Beenden"
        '
        'FormIniFileControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 431)
        Me.Controls.Add(Me.IniFileContentView)
        Me.Controls.Add(Me.EntryValueEdit)
        Me.Controls.Add(Me.EntrysListEdit)
        Me.Controls.Add(Me.SectionsListEdit)
        Me.Controls.Add(Me.SectionsCommentEdit)
        Me.Controls.Add(Me.FileCommentEdit)
        Me.Controls.Add(MenuStrip_HauptMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIniFileControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "IniFile - Control - Test"
        MenuStrip_HauptMenu.ResumeLayout(False)
        MenuStrip_HauptMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents IniFileContentView As SchlumpfSoft.Controls.IniFileControl.IniFileContentView
    Private WithEvents EntryValueEdit As SchlumpfSoft.Controls.IniFileControl.IniFileEntryValueEdit
    Private WithEvents EntrysListEdit As SchlumpfSoft.Controls.IniFileControl.IniFileListEdit
    Private WithEvents SectionsListEdit As SchlumpfSoft.Controls.IniFileControl.IniFileListEdit
    Friend WithEvents SectionsCommentEdit As SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit
    Friend WithEvents FileCommentEdit As SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit
    Private WithEvents IniFile1 As SchlumpfSoft.Controls.IniFileControl.IniFile
    Private WithEvents ToolStripMenuItem_Oeffnen As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem_Speichern As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem_SpeichernUnter As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem_Beenden As ToolStripMenuItem
End Class
