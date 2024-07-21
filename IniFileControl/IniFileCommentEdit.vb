' ****************************************************************************************************************
' IniFileCommentEdit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

'TODO: Beschreibungstexte in Ressource eintragen und auf Englisch übersetzen.

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports Newtonsoft.Json.Linq


''' <summary>
''' Steuerelement zum Anzeigen und Bearbeiten des Datei- oder Abschnitts- Kommentars einer INI - Datei.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<MyDescription("ClassDescription")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(IniFileCommentEdit), "IniFileCommentEdit.bmp")>
Public Class IniFileCommentEdit


    Inherits GroupBox


#Region "Definition der Variablen"

    Private WithEvents Button As Button
    Private WithEvents TextBox As TextBox
    Private _Lines As String()

#End Region


#Region "Definition der Ereignisse"


    ''' <summary>
    ''' Wird ausgelöst wenn sich der Kommentartext geändert hat.
    ''' </summary>
    <Description("Wird ausgelöst wenn sich der Kommentartext geändert hat.")>
    Public Event CommentChanged(sender As Object, e As EventArgs)


    Private Event PropCommentChanged()


#End Region


#Region "Definition der neuen Eigenschaften"

    ''' <summary>
    ''' Gibt den Kommentartext zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Category(CategoryDesciptionConstants.Appearance)>
    <Description("Gibt den Kommentartext zurück oder legt diesen fest.")>
    Public Property Comment As String()
        Get
            Return Me._Lines
        End Get
        Set
            Me._Lines = Value
            RaiseEvent PropCommentChanged()
        End Set
    End Property

#End Region


#Region "Definition der internen Ereignisbehandlungen"

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles _
        Button.Click

        Me._Lines = Me.TextBox.Lines

        'Ereignis auslösen
        RaiseEvent CommentChanged(Me, EventArgs.Empty)

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles _
        TextBox.TextChanged

        'Button zum übernehmen der Dateikommentaränderungen aktivieren
        Me.Button.Enabled = True

    End Sub

    Private Sub IniFileCommentEdit_PropCommentChanged() Handles _
        Me.PropCommentChanged

        Me.TextBox.Lines = Me._Lines
        Me.Button.Enabled = False

    End Sub


#End Region


    Public Sub New()

        'Komponenten erstellen
        Me.InitializeComponent()

        'Komponenten anpassen
        Me.TextBox.Size = New System.Drawing.Size(Me.Width - 16, Me.Height - Me.Button.Height - 44)
        Me.Button.Location = New System.Drawing.Point(Me.TextBox.Width - Me.Button.Width, Me.TextBox.Height + 28)

    End Sub


    Private Sub InitializeComponent()

        Me.Button = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button
        '
        Me.Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom _
            Or System.Windows.Forms.AnchorStyles.Right
        Me.Button.AutoSize = True
        Me.Button.Enabled = False
        Me.Button.Location = New System.Drawing.Point(0, 0)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(84, 24)
        Me.Button.TabIndex = 1
        Me.Button.Text = "übernehmen"
        Me.Button.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        Me.TextBox.Anchor = System.Windows.Forms.AnchorStyles.Top _
            Or System.Windows.Forms.AnchorStyles.Bottom _
            Or System.Windows.Forms.AnchorStyles.Left _
            Or System.Windows.Forms.AnchorStyles.Right
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox.Location = New System.Drawing.Point(8, 20)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox.Size = New System.Drawing.Size(100, 20)
        Me.TextBox.TabIndex = 0
        Me.TextBox.WordWrap = False
        '
        'IniFileCommentEdit
        '
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Button)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


End Class
