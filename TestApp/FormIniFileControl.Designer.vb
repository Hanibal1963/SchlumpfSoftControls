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
        Dim ToolStripMenuItem_Datei As System.Windows.Forms.ToolStripMenuItem
        Dim ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
        Me.ContentView = New SchlumpfSoft.Controls.IniFileControl.IniFileContentView()
        Me.FileCommentEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit()
        Me.SectionsListEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileListEdit()
        Me.ToolStripMenuItem_Oeffnen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Speichern = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_SpeichernUnter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem_Beenden = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.IniFile = New SchlumpfSoft.Controls.IniFileControl.IniFile()
        Me.SectionCommentEdit = New SchlumpfSoft.Controls.IniFileControl.IniFileCommentEdit()
        MenuStrip_HauptMenu = New System.Windows.Forms.MenuStrip()
        ToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        ToolStripMenuItem_Datei = New System.Windows.Forms.ToolStripMenuItem()
        ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        MenuStrip_HauptMenu.SuspendLayout()
        ToolStripContainer.ContentPanel.SuspendLayout()
        ToolStripContainer.TopToolStripPanel.SuspendLayout()
        ToolStripContainer.SuspendLayout()
        TableLayoutPanel.SuspendLayout()
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
        TableLayoutPanel.Name = "TableLayoutPanel"
        '
        'ContentView
        '
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
        Me.FileCommentEdit.TitelText = "Dateikommentar:"
        '
        'SectionsListEdit
        '
        resources.ApplyResources(Me.SectionsListEdit, "SectionsListEdit")
        Me.SectionsListEdit.ListItems = New String(-1) {}
        Me.SectionsListEdit.Name = "SectionsListEdit"
        Me.SectionsListEdit.TitelText = "Abschnittsliste:"
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
        'SectionCommentEdit
        '
        Me.SectionCommentEdit.Comment = New String() {""}
        resources.ApplyResources(Me.SectionCommentEdit, "SectionCommentEdit")
        Me.SectionCommentEdit.Name = "SectionCommentEdit"
        Me.SectionCommentEdit.TitelText = "Abschnittskommentar:"
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
End Class
