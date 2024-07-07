<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWizardControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormWizardControl))
        Me.PageWelcome = New SchlumpfSoft.Controls.WizardControl.PageWelcome()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Wizard1 = New SchlumpfSoft.Controls.WizardControl.Wizard()
        Me.PageFinish = New SchlumpfSoft.Controls.WizardControl.PageFinish()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.PageStandard = New SchlumpfSoft.Controls.WizardControl.PageStandard()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PageCustom = New SchlumpfSoft.Controls.WizardControl.PageCustom()
        Me.PageWelcome.SuspendLayout()
        Me.Wizard1.SuspendLayout()
        Me.PageFinish.SuspendLayout()
        Me.PageStandard.SuspendLayout()
        Me.SuspendLayout()
        '
        'PageWelcome
        '
        Me.PageWelcome.Controls.Add(Me.Label1)
        Me.PageWelcome.Description = "Willkommensseite"
        Me.PageWelcome.Location = New System.Drawing.Point(0, 0)
        Me.PageWelcome.Name = "PageWelcome"
        Me.PageWelcome.Size = New System.Drawing.Size(529, 278)
        Me.PageWelcome.TabIndex = 10
        Me.PageWelcome.Title = "Willkommen"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(175, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 172)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beschreibung für diese Seite." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ende der Beschreibung"
        '
        'Wizard1
        '
        Me.Wizard1.Controls.Add(Me.PageWelcome)
        Me.Wizard1.Controls.Add(Me.PageStandard)
        Me.Wizard1.Controls.Add(Me.PageCustom)
        Me.Wizard1.Controls.Add(Me.PageFinish)
        Me.Wizard1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.HeaderTitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Wizard1.ImageHeader = CType(resources.GetObject("Wizard1.ImageHeader"), System.Drawing.Image)
        Me.Wizard1.ImageWelcome = CType(resources.GetObject("Wizard1.ImageWelcome"), System.Drawing.Image)
        Me.Wizard1.Location = New System.Drawing.Point(0, 0)
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Pages.AddRange(New SchlumpfSoft.Controls.WizardControl.WizardPage() {Me.PageWelcome, Me.PageStandard, Me.PageCustom, Me.PageFinish})
        Me.Wizard1.Size = New System.Drawing.Size(529, 326)
        Me.Wizard1.TabIndex = 1
        Me.Wizard1.WelcomeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.WelcomeTitleFont = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Bold)
        '
        'PageFinish
        '
        Me.PageFinish.Controls.Add(Me.MonthCalendar1)
        Me.PageFinish.Description = "Abschlußseite"
        Me.PageFinish.Location = New System.Drawing.Point(0, 0)
        Me.PageFinish.Name = "PageFinish"
        Me.PageFinish.Size = New System.Drawing.Size(529, 278)
        Me.PageFinish.TabIndex = 13
        Me.PageFinish.Title = "letzte Seite"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(235, 81)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'PageStandard
        '
        Me.PageStandard.Controls.Add(Me.DateTimePicker)
        Me.PageStandard.Description = "Standardseite"
        Me.PageStandard.Location = New System.Drawing.Point(0, 0)
        Me.PageStandard.Name = "PageStandard"
        Me.PageStandard.Size = New System.Drawing.Size(529, 278)
        Me.PageStandard.TabIndex = 11
        Me.PageStandard.Title = "Seite 1"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(63, 103)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(257, 20)
        Me.DateTimePicker.TabIndex = 0
        '
        'PageCustom
        '
        Me.PageCustom.Description = "keine Beschreibung"
        Me.PageCustom.Location = New System.Drawing.Point(0, 0)
        Me.PageCustom.Name = "PageCustom"
        Me.PageCustom.Size = New System.Drawing.Size(529, 278)
        Me.PageCustom.TabIndex = 12
        Me.PageCustom.Title = "kein Titel"
        '
        'FormWizardControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 326)
        Me.Controls.Add(Me.Wizard1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormWizardControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Wizard - Control - Test"
        Me.PageWelcome.ResumeLayout(False)
        Me.Wizard1.ResumeLayout(False)
        Me.PageFinish.ResumeLayout(False)
        Me.PageStandard.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents PageWelcome As SchlumpfSoft.Controls.WizardControl.PageWelcome
    Private WithEvents Label1 As Label
    Private WithEvents Wizard1 As SchlumpfSoft.Controls.WizardControl.Wizard
    Private WithEvents PageFinish As SchlumpfSoft.Controls.WizardControl.PageFinish
    Private WithEvents MonthCalendar1 As MonthCalendar
    Private WithEvents PageStandard As SchlumpfSoft.Controls.WizardControl.PageStandard
    Private WithEvents DateTimePicker As DateTimePicker
    Private WithEvents PageCustom As SchlumpfSoft.Controls.WizardControl.PageCustom
End Class
