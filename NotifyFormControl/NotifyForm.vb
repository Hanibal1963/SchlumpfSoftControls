' ****************************************************************************************************************
' NotifyForm.vb
' © 2023 - 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Threading
Imports System.Windows.Forms


''' <summary>
''' Control zum anzeigen von Benachrichtigungsfenstern.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum Anzeigen von Benachrichtigungsfenstern.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(NotifyForm), "NotifyForm.bmp")>
Public Class NotifyForm : Inherits Component


    ''' <summary>
    ''' Legt das Aussehen des Benachrichtigungsfensters fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt das Aussehen des Benachrichtigungsfensters fest.")>
    Public Property Design As FormDesign

    ''' <summary>
    ''' Legt den Benachrichtigungstext fest der angezeigt werden soll.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt den Benachrichtigungstext fest der angezeigt werden soll oder gibt diesen zurück.")>
    Public Property Message As String = $"Fensternachricht"

    ''' <summary>
    ''' Legt die Anzeigedauer des Benachrichtigungsfensters in ms fest.
    ''' </summary>
    ''' <remarks>
    ''' Der Wert 0 bewirkt das kein automatisches schließen des Fensters erfolgt.
    ''' </remarks>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt die Anzeigedauer des Benachrichtigungsfensters in ms fest oder gibt diese zurück. (Der Wert 0 deaktiviert das automatische schließen.)")>
    Public Property ShowTime As Integer = 5000

    ''' <summary>
    ''' Legt das anzuzeigende Symbol im Benachrichtigungsfensters fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt das anzuzeigende Symbol des Benachrichtigungsfensters fest oder gibt dieses zurück.")>
    Public Property Style As FormStyle = FormStyle.Information

    ''' <summary>
    ''' Legt den Text der Titelzeile des Benachrichtigungsfensters fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt den Text der Titelzeile des Benachrichtigungsfensters fest oder gibt diesen zurück.")>
    Public Property Title As String = $"Fenstertitel"

    ''' <summary>
    ''' Zeigt das Meldungsfenster an.
    ''' </summary>
    Public Sub Show()

        FormTemplate.Image = Me.SetFormImage
        FormTemplate.Title = Me.Title
        FormTemplate.Message = Me.Message
        FormTemplate.ShowTime = Me.ShowTime
        Me.SetFormDesign()

    End Sub

    ''' <summary>
    ''' Setzt das Design des Fensters
    ''' </summary>
    Private Sub SetFormDesign()

        Select Case Me.Design

            Case FormDesign.Bright
                SetFormDesignBright()

            Case FormDesign.Colorful
                SetFormDesignColorful()

            Case FormDesign.Dark
                SetFormDesignDark()

        End Select

    End Sub

    ''' <summary>
    ''' Setzt das helle Design
    ''' </summary>
    Private Shared Sub SetFormDesignBright()

        FormTemplate.BackgroundColor = Color.White
        FormTemplate.TextFieldColor = Color.White
        FormTemplate.TitleBarColor = Color.Gray
        FormTemplate.FontColor = Color.Black
        Dim ini As New FormTemplate
        ini.Initialize()

    End Sub

    ''' <summary>
    ''' Setz das farbige Design
    ''' </summary>
    Private Shared Sub SetFormDesignColorful()

        FormTemplate.BackgroundColor = Color.LightBlue
        FormTemplate.TextFieldColor = Color.LightBlue
        FormTemplate.TitleBarColor = Color.LightSeaGreen
        FormTemplate.FontColor = Color.White
        Dim ini As New FormTemplate
        ini.Initialize()

    End Sub

    ''' <summary>
    ''' Setzt das dunkle Design
    ''' </summary>
    Private Shared Sub SetFormDesignDark()

        FormTemplate.BackgroundColor = Color.FromArgb(83, 79, 75)
        FormTemplate.TextFieldColor = Color.FromArgb(83, 79, 75)
        FormTemplate.TitleBarColor = Color.FromArgb(60, 57, 54)
        FormTemplate.FontColor = Color.White
        Dim ini As New FormTemplate
        ini.Initialize()

    End Sub

    ''' <summary>
    ''' Setzt das Symbol des Fensters
    ''' </summary>
    ''' <returns></returns>
    Private Function SetFormImage() As Image

        Dim result As Bitmap = Nothing

        Select Case Me.Style

            Case FormStyle.CriticalError
                result = My.Resources.CriticalError

            Case FormStyle.Exclamation
                result = My.Resources.Warning

            Case FormStyle.Information
                result = My.Resources.Information

            Case FormStyle.Question
                result = My.Resources.Question

        End Select

        Return result

    End Function

    ''' <summary>
    ''' Vorlage für das Benachrichtigungsfenster
    ''' </summary>
    Private Class FormTemplate : Inherits Form

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

    End Class

End Class


''' <summary>
''' Auflistung der Deigns
''' </summary>
Public Enum FormDesign As Integer

    ''' <summary>
    ''' Helles Design
    ''' </summary>
    Bright = 0

    ''' <summary>
    ''' Farbiges Design
    ''' </summary>
    Colorful = 1

    ''' <summary>
    ''' Dunkles Design
    ''' </summary>
    Dark = 2

End Enum


''' <summary>
''' Auflistung der Styles
''' </summary>
Public Enum FormStyle As Integer

    ''' <summary>
    ''' Infosymbol
    ''' </summary>
    Information = 0

    ''' <summary>
    ''' Fragesymbol
    ''' </summary>
    Question = 1

    ''' <summary>
    ''' Fehlersymbol
    ''' </summary>
    CriticalError = 2

    ''' <summary>
    ''' Warnungssymbol
    ''' </summary>
    Exclamation = 3

End Enum
