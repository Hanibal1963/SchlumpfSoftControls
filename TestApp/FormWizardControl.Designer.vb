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
        Me.PageCustom = New SchlumpfSoft.Controls.WizardControl.PageCustom()
        Me.PageStandard = New SchlumpfSoft.Controls.WizardControl.PageStandard()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
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
        resources.ApplyResources(Me.PageWelcome, "PageWelcome")
        Me.PageWelcome.Name = "PageWelcome"
        Me.PageWelcome.Title = "Willkommen"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Wizard1
        '
        Me.Wizard1.Controls.Add(Me.PageWelcome)
        Me.Wizard1.Controls.Add(Me.PageStandard)
        Me.Wizard1.Controls.Add(Me.PageFinish)
        Me.Wizard1.Controls.Add(Me.PageCustom)
        Me.Wizard1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.HeaderTitleFont = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Wizard1.ImageHeader = CType(resources.GetObject("Wizard1.ImageHeader"), System.Drawing.Image)
        Me.Wizard1.ImageWelcome = CType(resources.GetObject("Wizard1.ImageWelcome"), System.Drawing.Image)
        resources.ApplyResources(Me.Wizard1, "Wizard1")
        Me.Wizard1.Name = "Wizard1"
        Me.Wizard1.Pages.AddRange(New SchlumpfSoft.Controls.WizardControl.WizardPage() {Me.PageWelcome, Me.PageStandard, Me.PageCustom, Me.PageFinish})
        Me.Wizard1.WelcomeFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wizard1.WelcomeTitleFont = New System.Drawing.Font("Microsoft Sans Serif", 18.25!, System.Drawing.FontStyle.Bold)
        '
        'PageFinish
        '
        Me.PageFinish.Controls.Add(Me.MonthCalendar1)
        Me.PageFinish.Description = "Abschlußseite"
        resources.ApplyResources(Me.PageFinish, "PageFinish")
        Me.PageFinish.Name = "PageFinish"
        Me.PageFinish.Title = "letzte Seite"
        '
        'MonthCalendar1
        '
        resources.ApplyResources(Me.MonthCalendar1, "MonthCalendar1")
        Me.MonthCalendar1.Name = "MonthCalendar1"
        '
        'PageCustom
        '
        Me.PageCustom.Description = "keine Beschreibung"
        resources.ApplyResources(Me.PageCustom, "PageCustom")
        Me.PageCustom.Name = "PageCustom"
        Me.PageCustom.Title = "kein Titel"
        '
        'PageStandard
        '
        Me.PageStandard.Controls.Add(Me.DateTimePicker)
        Me.PageStandard.Description = "Standardseite"
        resources.ApplyResources(Me.PageStandard, "PageStandard")
        Me.PageStandard.Name = "PageStandard"
        Me.PageStandard.Title = "Seite 1"
        '
        'DateTimePicker
        '
        resources.ApplyResources(Me.DateTimePicker, "DateTimePicker")
        Me.DateTimePicker.Name = "DateTimePicker"
        '
        'FormWizardControl
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Wizard1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormWizardControl"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
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
