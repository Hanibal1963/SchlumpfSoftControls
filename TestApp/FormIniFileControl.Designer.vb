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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIniFileControl))
        Dim ToolStripContainer As System.Windows.Forms.ToolStripContainer
        Dim TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
        Dim GroupBoxOptionen As System.Windows.Forms.GroupBox
        Dim FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
        Dim LabelDefaultFolder As System.Windows.Forms.Label
        Dim ToolStripMenuItem_Datei As System.Windows.Forms.ToolStripMenuItem
        Dim ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Me.ContentView = New SchlumpfSoft.Controls.IniFileControl.IniFileContentView()
        Me.FileCommentEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit()
        Me.SectionsListEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileListEdit()
        Me.SectionCommentEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit()
        Me.EntryListEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileListEdit()
        Me.EntryValueEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileEntryValueEdit()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelCommentPrefix = New System.Windows.Forms.Label()
        Me.TextBoxCommentPrefix = New System.Windows.Forms.TextBox()
        Me.TextBoxDefaultFolder = New System.Windows.Forms.TextBox()
        Me.ButtonSelectDefaultFolder = New System.Windows.Forms.Button()
        Me.CheckBoxAutoSave = New System.Windows.Forms.CheckBox()
        Me.ToolStripMenuItem_Neu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Oeffnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Speichern = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_SpeichernUnter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Beenden = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.IniFile = New SchlumpfSoft.Controls.IniFileControl.IniFile()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        MenuStrip_HauptMenu = New System.Windows.Forms.MenuStrip()
        ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        GroupBoxOptionen = New System.Windows.Forms.GroupBox()
        FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        LabelDefaultFolder = New System.Windows.Forms.Label()
        ToolStripMenuItem_Datei = New System.Windows.Forms.ToolStripMenuItem()
        ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        MenuStrip_HauptMenu.SuspendLayout()
        ToolStripContainer.ContentPanel.SuspendLayout()
        ToolStripContainer.TopToolStripPanel.SuspendLayout()
        ToolStripContainer.SuspendLayout()
        TableLayoutPanel.SuspendLayout()
        GroupBoxOptionen.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip_HauptMenu
        '
        resources.ApplyResources(MenuStrip_HauptMenu, "MenuStrip_HauptMenu")
        MenuStrip_HauptMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {ToolStripMenuItem_Datei})
        MenuStrip_HauptMenu.Name = "MenuStrip_HauptMenu"
        '
        'ToolStripContainer
        '
        ToolStripContainer.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer.ContentPanel
        '
        ToolStripContainer.ContentPanel.Controls.Add(TableLayoutPanel)
        resources.ApplyResources(ToolStripContainer.ContentPanel, "ToolStripContainer.ContentPanel")
        resources.ApplyResources(ToolStripContainer, "ToolStripContainer")
        ToolStripContainer.LeftToolStripPanelVisible = False
        ToolStripContainer.Name = "ToolStripContainer"
        ToolStripContainer.RightToolStripPanelVisible = False
        '
        'ToolStripContainer.TopToolStripPanel
        '
        ToolStripContainer.TopToolStripPanel.Controls.Add(MenuStrip_HauptMenu)
        '
        'TableLayoutPanel
        '
        resources.ApplyResources(TableLayoutPanel, "TableLayoutPanel")
        TableLayoutPanel.Controls.Add(Me.ContentView, 0, 0)
        TableLayoutPanel.Controls.Add(Me.FileCommentEdit, 0, 1)
        TableLayoutPanel.Controls.Add(Me.SectionsListEdit, 1, 0)
        TableLayoutPanel.Controls.Add(Me.SectionCommentEdit, 1, 1)
        TableLayoutPanel.Controls.Add(Me.EntryListEdit, 2, 0)
        TableLayoutPanel.Controls.Add(Me.EntryValueEdit, 2, 1)
        TableLayoutPanel.Controls.Add(GroupBoxOptionen, 0, 2)
        TableLayoutPanel.Name = "TableLayoutPanel"
        '
        'ContentView
        '
        Me.ContentView.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.ContentView, "ContentView")
        Me.ContentView.Lines = Nothing
        Me.ContentView.Name = "ContentView"
        Me.ContentView.TitelText = "Dateiinhalt:"
        '
        'FileCommentEdit
        '
        Me.FileCommentEdit.Comment = New String() {""}
        resources.ApplyResources(Me.FileCommentEdit, "FileCommentEdit")
        Me.FileCommentEdit.Name = "FileCommentEdit"
        Me.FileCommentEdit.SectionName = Nothing
        Me.FileCommentEdit.TitelText = "Dateikommentar:"
        '
        'SectionsListEdit
        '
        resources.ApplyResources(Me.SectionsListEdit, "SectionsListEdit")
        Me.SectionsListEdit.ListItems = New String(-1) {}
        Me.SectionsListEdit.Name = "SectionsListEdit"
        Me.SectionsListEdit.SelectedSection = ""
        Me.SectionsListEdit.TitelText = "Abschnittsliste:"
        '
        'SectionCommentEdit
        '
        Me.SectionCommentEdit.Comment = New String() {""}
        resources.ApplyResources(Me.SectionCommentEdit, "SectionCommentEdit")
        Me.SectionCommentEdit.Name = "SectionCommentEdit"
        Me.SectionCommentEdit.SectionName = Nothing
        Me.SectionCommentEdit.TitelText = "Abschnittskommentar:"
        '
        'EntryListEdit
        '
        resources.ApplyResources(Me.EntryListEdit, "EntryListEdit")
        Me.EntryListEdit.ListItems = New String() {""}
        Me.EntryListEdit.Name = "EntryListEdit"
        Me.EntryListEdit.SelectedSection = ""
        Me.EntryListEdit.TitelText = "Eintragsliste:"
        '
        'EntryValueEdit
        '
        resources.ApplyResources(Me.EntryValueEdit, "EntryValueEdit")
        Me.EntryValueEdit.Name = "EntryValueEdit"
        Me.EntryValueEdit.SelectedEntry = Nothing
        Me.EntryValueEdit.SelectedSection = ""
        Me.EntryValueEdit.TitelText = "Eintrag:"
        Me.EntryValueEdit.Value = ""
        '
        'GroupBoxOptionen
        '
        TableLayoutPanel.SetColumnSpan(GroupBoxOptionen, 3)
        GroupBoxOptionen.Controls.Add(Me.FlowLayoutPanel2)
        GroupBoxOptionen.Controls.Add(FlowLayoutPanel1)
        GroupBoxOptionen.Controls.Add(Me.CheckBoxAutoSave)
        resources.ApplyResources(GroupBoxOptionen, "GroupBoxOptionen")
        GroupBoxOptionen.Name = "GroupBoxOptionen"
        GroupBoxOptionen.TabStop = False
        '
        'FlowLayoutPanel2
        '
        resources.ApplyResources(Me.FlowLayoutPanel2, "FlowLayoutPanel2")
        Me.FlowLayoutPanel2.Controls.Add(Me.LabelCommentPrefix)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBoxCommentPrefix)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        '
        'LabelCommentPrefix
        '
        resources.ApplyResources(Me.LabelCommentPrefix, "LabelCommentPrefix")
        Me.LabelCommentPrefix.Name = "LabelCommentPrefix"
        '
        'TextBoxCommentPrefix
        '
        Me.TextBoxCommentPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.TextBoxCommentPrefix, "TextBoxCommentPrefix")
        Me.TextBoxCommentPrefix.Name = "TextBoxCommentPrefix"
        '
        'FlowLayoutPanel1
        '
        resources.ApplyResources(FlowLayoutPanel1, "FlowLayoutPanel1")
        FlowLayoutPanel1.Controls.Add(LabelDefaultFolder)
        FlowLayoutPanel1.Controls.Add(Me.TextBoxDefaultFolder)
        FlowLayoutPanel1.Controls.Add(Me.ButtonSelectDefaultFolder)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'LabelDefaultFolder
        '
        resources.ApplyResources(LabelDefaultFolder, "LabelDefaultFolder")
        LabelDefaultFolder.Name = "LabelDefaultFolder"
        '
        'TextBoxDefaultFolder
        '
        Me.TextBoxDefaultFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxDefaultFolder.HideSelection = False
        resources.ApplyResources(Me.TextBoxDefaultFolder, "TextBoxDefaultFolder")
        Me.TextBoxDefaultFolder.Name = "TextBoxDefaultFolder"
        Me.TextBoxDefaultFolder.ReadOnly = True
        '
        'ButtonSelectDefaultFolder
        '
        resources.ApplyResources(Me.ButtonSelectDefaultFolder, "ButtonSelectDefaultFolder")
        Me.ButtonSelectDefaultFolder.Name = "ButtonSelectDefaultFolder"
        Me.ButtonSelectDefaultFolder.UseVisualStyleBackColor = True
        '
        'CheckBoxAutoSave
        '
        resources.ApplyResources(Me.CheckBoxAutoSave, "CheckBoxAutoSave")
        Me.CheckBoxAutoSave.Name = "CheckBoxAutoSave"
        Me.CheckBoxAutoSave.UseVisualStyleBackColor = True
        '
        'ToolStripMenuItem_Datei
        '
        ToolStripMenuItem_Datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_Neu, ToolStripSeparator3, Me.ToolStripMenuItem_Oeffnen, ToolStripSeparator1, Me.ToolStripMenuItem_Speichern, Me.ToolStripMenuItem_SpeichernUnter, ToolStripSeparator2, Me.ToolStripMenuItem_Beenden})
        ToolStripMenuItem_Datei.Name = "ToolStripMenuItem_Datei"
        resources.ApplyResources(ToolStripMenuItem_Datei, "ToolStripMenuItem_Datei")
        '
        'ToolStripMenuItem_Neu
        '
        Me.ToolStripMenuItem_Neu.Name = "ToolStripMenuItem_Neu"
        resources.ApplyResources(Me.ToolStripMenuItem_Neu, "ToolStripMenuItem_Neu")
        '
        'ToolStripSeparator3
        '
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(ToolStripSeparator3, "ToolStripSeparator3")
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
        'OpenFileDialog
        '
        Me.OpenFileDialog.DefaultExt = "ini"
        resources.ApplyResources(Me.OpenFileDialog, "OpenFileDialog")
        Me.OpenFileDialog.FilterIndex = 0
        Me.OpenFileDialog.RestoreDirectory = True
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.CheckFileExists = True
        Me.SaveFileDialog.DefaultExt = "ini"
        resources.ApplyResources(Me.SaveFileDialog, "SaveFileDialog")
        Me.SaveFileDialog.FilterIndex = 0
        Me.SaveFileDialog.RestoreDirectory = True
        '
        'IniFile
        '
        Me.IniFile.AutoSave = False
        Me.IniFile.CommentPrefix = Global.Microsoft.VisualBasic.ChrW(59)
        Me.IniFile.FilePath = ""
        '
        'FolderBrowserDialog
        '
        Me.FolderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'FormIniFileControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(ToolStripContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormIniFileControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        MenuStrip_HauptMenu.ResumeLayout(False)
        MenuStrip_HauptMenu.PerformLayout()
        ToolStripContainer.ContentPanel.ResumeLayout(False)
        ToolStripContainer.TopToolStripPanel.ResumeLayout(False)
        ToolStripContainer.TopToolStripPanel.PerformLayout()
        ToolStripContainer.ResumeLayout(False)
        ToolStripContainer.PerformLayout()
        TableLayoutPanel.ResumeLayout(False)
        GroupBoxOptionen.ResumeLayout(False)
        GroupBoxOptionen.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ToolStripMenuItem_Oeffnen As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem_Speichern As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem_SpeichernUnter As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem_Beenden As ToolStripMenuItem
    Private WithEvents OpenFileDialog As OpenFileDialog
    Private WithEvents SaveFileDialog As SaveFileDialog
    Private WithEvents IniFile As SchlumpfSoft.Controls.IniFileControl.IniFile
    Private WithEvents ContentView As SchlumpfSoft.Controls.IniFileControl.IniFileContentView
    Private WithEvents FileCommentEdit As SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit
    Private WithEvents SectionsListEdit As SchlumpfSoft.Controls.IniFileControl.IniFileListEdit
    Private WithEvents SectionCommentEdit As SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit
    Private WithEvents EntryListEdit As SchlumpfSoft.Controls.IniFileControl.IniFileListEdit
    Private WithEvents EntryValueEdit As SchlumpfSoft.Controls.IniFileControl.IniFileEntryValueEdit
    Private WithEvents ToolStripMenuItem_Neu As ToolStripMenuItem
    Private WithEvents LabelCommentPrefix As Label
    Private WithEvents TextBoxCommentPrefix As TextBox
    Private WithEvents CheckBoxAutoSave As CheckBox
    Private WithEvents TextBoxDefaultFolder As TextBox
    Private WithEvents ButtonSelectDefaultFolder As Button
    Private WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Private WithEvents FolderBrowserDialog As FolderBrowserDialog
End Class
