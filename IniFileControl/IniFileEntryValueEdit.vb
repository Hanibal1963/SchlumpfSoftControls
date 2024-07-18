' ****************************************************************************************************************
' IniFileEntryValueEdit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


''' <summary>
''' Steuerelement zum Anzeigen und Bearbeiten der Einträge eines Abschnitts einer INI - Datei.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description(ClassDescriptionConstants.IniFileEntryValueEdit)>
<ToolboxItem(True)>
<System.Drawing.ToolboxBitmap(GetType(IniFileEntryValueEdit), "IniFileEntryValueEdit.bmp")>
Public Class IniFileEntryValueEdit


    Inherits GroupBox


#Region "Definition der Variablen"

    Private WithEvents Button As Button
    Private WithEvents TextBox As TextBox

#End Region


#Region "Definition der Ereignisse"


    ''' <summary>
    ''' Wird ausgelöst wenn sich der Wert geändert hat.
    ''' </summary>
    <Description("Wird ausgelöst wenn sich der Wert geändert hat.")>
    Public Event ValueChanged(sender As Object, e As EventArgs)


#End Region


#Region "Definition der neuen Eigenschaften"

    ''' <summary>
    ''' Eintragswert
    ''' </summary>
    <Description("Eintragswert")>
    Public Property Value As String
        Get
            Return Me.TextBox.Text
        End Get
        Set
            Me.TextBox.Text = Value
            Me.Button.Enabled = False
        End Set
    End Property

#End Region


#Region "Definition der internen Ereignisbehandlungen"

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles _
        Button.Click

        'Ereignis auslösen
        RaiseEvent ValueChanged(Me, EventArgs.Empty)

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles _
        TextBox.TextChanged

        'Button aktivieren
        Me.Button.Enabled = True

    End Sub

#End Region


    Public Sub New()

        'Komponenten erstellen
        Me.InitializeComponent()

        'Komponenten anpassen
        Me.TextBox.Size = New System.Drawing.Size(Me.Width - 12, 20)
        Me.Button.Location = New System.Drawing.Point(Me.TextBox.Width - Me.Button.Width, Me.TextBox.Top + Me.TextBox.Height + 6)

    End Sub


    Private Sub InitializeComponent()

        Me.Button = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button
        '
        Me.Button.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        Me.Button.AutoSize = True
        Me.Button.Enabled = False
        Me.Button.Location = New System.Drawing.Point(0, 0)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(84, 24)
        Me.Button.TabIndex = 5
        Me.Button.Text = "übernehmen"
        Me.Button.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        Me.TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left _
            Or System.Windows.Forms.AnchorStyles.Right
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox.Location = New System.Drawing.Point(6, 19)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(100, 20)
        Me.TextBox.TabIndex = 0
        Me.TextBox.WordWrap = False
        '
        'IniFileEntryValueEdit
        '
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Button)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


End Class
