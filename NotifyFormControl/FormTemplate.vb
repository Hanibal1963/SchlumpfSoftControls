﻿' ****************************************************************************************************************
' FormTemplate.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms


''' <summary>
''' Vorlage für das Benachrichtigungsfenster
''' </summary>
Friend Class FormTemplate


    Inherits Form


    Private CloseThread As Thread


    'Eigenschaften
    Public Shared BackgroundColor As Color
    Public Shared FontColor As Color
    Public Shared Image As Image
    Public Shared Message As String
    Public Shared ShowTime As Integer
    Public Shared TextFieldColor As Color
    Public Shared Title As String
    Public Shared TitleBarColor As Color


    'Controls
    Private ReadOnly LabelClose As New Label
    Private ReadOnly LabelTitle As New Label
    Private ReadOnly PanelSpacer As New Panel
    Private ReadOnly PanelTitle As New Panel
    Private ReadOnly PictureBoxImage As New PictureBox
    Private ReadOnly RichTextBoxMessage As New RichTextBox


    Private Sub CloseForm()

        If Me.InvokeRequired Then
            Dim unused = Me.Invoke(New MethodInvoker(AddressOf Me.CloseForm))
        Else
            Me.Close()
        End If

    End Sub


    Public Sub Initialize()

        With Me
            .MaximizeBox = False
            .MinimizeBox = False
            .BackColor = BackgroundColor
            .ForeColor = FontColor
            .Size = New Size(504, 138)
            .FormBorderStyle = FormBorderStyle.None
            .StartPosition = FormStartPosition.Manual
        End With
        Me.Show()

    End Sub


    Protected Overrides Sub Dispose(disposing As Boolean)

        'Bereinigung durchführen
        With Me
            .LabelClose.Dispose()
            .LabelTitle.Dispose()
            .PanelSpacer.Dispose()
            .PanelTitle.Dispose()
            .PictureBoxImage.Dispose()
            .RichTextBoxMessage.Dispose()
        End With
        MyBase.Dispose(disposing)

    End Sub


    Private Sub AddControls()

        With Me.Controls
            .Add(Me.LabelTitle)
            .Add(Me.LabelClose)
            .Add(Me.PanelSpacer)
            .Add(Me.PanelTitle)
            .Add(Me.RichTextBoxMessage)
            .Add(Me.PictureBoxImage)
        End With

    End Sub


    Private Sub AutoClose()

        'Fenster nur automatisch schließen wenn Zeit > 0 ist.
        If ShowTime > 0 Then
            Thread.Sleep(ShowTime)
            Me.CloseForm()
        End If

    End Sub


    Private Sub Form_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing

        Thread.Sleep(150)
        For iCount As Integer = 90 To 10 Step -15
            Me.Opacity = iCount / 110
            Me.Refresh()
            Thread.Sleep(60)
        Next

    End Sub


    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        With Me
            .Opacity = 0.1
            .SetPropertys_Lbl_Close()
            .SetPropertys_Panel_Spacer()
            .SetPropertys_Pb_Image()
            .SetPropertys_Panel_Title()
            .SetPropertys_Lbl_Title()
            .SetPropertys_Txt_Msg()
            .AddControls()
            .ActiveControl = .Controls.Item(1)
        End With

        'Ändern Sie die Position in die untere rechte Ecke
        Dim x As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim y As Integer = Screen.PrimaryScreen.WorkingArea.Height - Me.Height - 50

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x -= 1
            Me.Location = New Point(x, y)
        Loop

        AddHandler Me.LabelClose.Click, AddressOf Me.Lbl_Close_Click

        Me.FormFadeIn()
        'Starte Thread für Autoclose-Popup.
        Me.CloseThread = New Thread(AddressOf Me.AutoClose) With {.IsBackground = True}
        Me.CloseThread.Start()

    End Sub


    Private Sub FormFadeIn()

        For iCount As Integer = 10 To 100 Step +15
            Me.Opacity = iCount / 100
            Me.Refresh()
            Thread.Sleep(60)
        Next

    End Sub


    Private Sub Lbl_Close_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub


    Private Sub SetPropertys_Lbl_Close()

        With Me.LabelClose
            .AutoSize = True
            .BackColor = TitleBarColor
            .ForeColor = FontColor
            .Location = New Point(478, 9)
            .Name = "LblClose"
            .Size = New Size(14, 13)
            .TabIndex = 1
            .Text = "X"
        End With

    End Sub


    Private Sub SetPropertys_Lbl_Title()

        With Me.LabelTitle
            .AutoSize = True
            .BackColor = TitleBarColor
            .ForeColor = FontColor
            .Location = New Point(11, 9)
            .Name = "LblTitle"
            .Size = New Size(27, 13)
            .TabIndex = 0
            .Text = Title
        End With

    End Sub


    Private Sub SetPropertys_Panel_Spacer()

        With Me.PanelSpacer
            .BackColor = TitleBarColor
            .Location = New Point(119, 36)
            .Name = "PanelSpacer"
            .Size = New Size(1, 92)
            .TabIndex = 2
        End With

    End Sub


    Private Sub SetPropertys_Panel_Title()

        With Me.PanelTitle
            .BackColor = TitleBarColor
            .Controls.Add(Me.LabelClose)
            .Controls.Add(Me.LabelTitle)
            .Location = New Point(0, -1)
            .Name = "PanelTitle"
            .Size = New Size(505, 29)
            .TabIndex = 0
        End With

    End Sub


    Private Sub SetPropertys_Pb_Image()

        With Me.PictureBoxImage
            .BackColor = Color.Transparent
            .Location = New Point(12, 36)
            .Name = "PicBoxImage"
            .Size = New Size(92, 92)
            .TabIndex = 1
            .TabStop = False
            .Image = Image
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Refresh()
        End With

    End Sub


    Private Sub SetPropertys_Txt_Msg()

        With Me.RichTextBoxMessage
            .BackColor = TextFieldColor
            .ForeColor = FontColor
            .BorderStyle = BorderStyle.None
            .Location = New Point(133, 37)
            .Multiline = True
            .Name = "RiTxtMsg"
            .Size = New Size(361, 90)
            .TabIndex = 3
            .ReadOnly = True
            .Text = Message
            .SelectionProtected = True
            .Cursor = Cursors.Arrow
        End With

    End Sub


    Protected Overrides Sub Finalize()

        MyBase.Finalize()

    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTemplate))
        Me.SuspendLayout()
        '
        'FormTemplate
        '
        resources.ApplyResources(Me, "$this")
        Me.Name = "FormTemplate"
        Me.ResumeLayout(False)

    End Sub
End Class

