' ****************************************************************************************************************
' IniFileContentView.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


''' <summary>
''' Steuerelement zum Anzeigen des Dateiinhaltes.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description(ClassDescriptionConstants.IniFileContentView)>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(IniFileContentView), "IniFileContentView.bmp")>
Public Class IniFileContentView


    Inherits GroupBox


    Private WithEvents TextBox As TextBox
    Private _Lines As String()


    Private Event PropLinesChanged()


    Public Sub New()

        'interne Controls initialisieren
        Me.InitializeComponent()

    End Sub


    ''' <summary>
    ''' Setzt Dateiinhalt
    ''' </summary>
    ''' <returns></returns>
    Public Property Lines As String()
        Get
            Return Me._Lines
        End Get
        Set
            Me._Lines = Value
            RaiseEvent PropLinesChanged()
        End Set
    End Property


    Private Sub IniFileContentView_LinesChanged() Handles _
        Me.PropLinesChanged

        Me.TextBox.Lines = Me._Lines

    End Sub


    Private Sub InitializeComponent()
        Me.TextBox = New TextBox()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Me.TextBox.BorderStyle = BorderStyle.FixedSingle
        Me.TextBox.Location = New Point(6, 19)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ScrollBars = ScrollBars.Both
        'Me.TextBox.Size = New Size(Me.Width - 12, 20)
        Me.TextBox.TabIndex = 0
        Me.TextBox.WordWrap = False
        Me.TextBox.Dock = DockStyle.Fill
        Me.TextBox.Multiline = True
        Me.TextBox.ReadOnly = True
        '
        'IniFileContentView
        '
        Me.Controls.Add(Me.TextBox)
        Me.ResumeLayout(False)

    End Sub


End Class
