' ****************************************************************************************************************
' IniFileCommentEdit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports Newtonsoft.Json.Linq

''' <summary>
''' Steuerelement zum Anzeigen und Bearbeiten des Datei- oder Abschnitts- Kommentars einer INI - Datei.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Steuerelement zum Anzeigen und Bearbeiten des Datei- oder Abschnitts- Kommentars einer INI - Datei.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(IniFileCommentEdit), "IniFileCommentEdit.bmp")>
Public Class IniFileCommentEdit : Inherits GroupBox


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
    <Category("Appearance")>
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

        'interne Controls initialisieren
        Me.InitializeComponent()

    End Sub


    Private Sub InitializeComponent()
        Me.Button = New Button()
        Me.TextBox = New TextBox()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.TextBox.BorderStyle = BorderStyle.FixedSingle
        Me.TextBox.Location = New Point(8, 20)
        Me.TextBox.Multiline = True
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ScrollBars = ScrollBars.Both
        Me.TextBox.Size = New Size(Me.Width - 15, Me.Height - 64)
        Me.TextBox.TabIndex = 0
        Me.TextBox.WordWrap = False
        '
        'Button
        '
        Me.Button.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Me.Button.Enabled = False
        Me.Button.Location = New Point(Me.Width - 90, Me.Height - 34)
        Me.Button.Name = "Button"
        Me.Button.Size = New Size(84, 24)
        Me.Button.TabIndex = 1
        Me.Button.Text = "übernehmen"
        Me.Button.UseVisualStyleBackColor = True
        '
        'IniFileCommentEdit
        '
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Button)
        Me.ResumeLayout(False)
    End Sub


End Class
