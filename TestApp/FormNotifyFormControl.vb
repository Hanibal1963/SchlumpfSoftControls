' ****************************************************************************************************************
' FormNotifyFormControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System.Globalization
Imports System.Threading
Imports SchlumpfSoft.Controls.NotifyFormControl


Public Class FormNotifyFormControl


    Private _ComboBox_Design_Items() As String = {
        My.Resources.NotifyForm_ComboBoxDesignItem1,
        My.Resources.NotifyForm_ComboBoxDesignItem2,
        My.Resources.NotifyForm_ComboBoxDesignItem3}
    Private _ComboBox_Styles_Items() As String = {
        My.Resources.NotifyForm_ComboBoxStylesItem1,
        My.Resources.NotifyForm_ComboBoxStylesItem2,
        My.Resources.NotifyForm_ComboBoxStylesItem3,
        My.Resources.NotifyForm_ComboBoxStylesItem4}


    Public Sub New()

        'Zuletzt verwendete Sprache einstellen
        Thread.CurrentThread.CurrentCulture = New CultureInfo(My.Settings.LangCode)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.LangCode)

        'Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        'Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        'Elemente der Combobox für das Fensterdesign
        Me.ComboBox_Design.Items.AddRange(Me._ComboBox_Design_Items)
        Me.ComboBox_Design.SelectedIndex = 0

        'Elemente für die Combobox für den Fensterstyle
        Me.ComboBox_Style.Items.AddRange(Me._ComboBox_Styles_Items)
        Me.ComboBox_Style.SelectedIndex = 0

        'Startwert für Anzeigezeit
        Me.NumericUpDown_ShowTime.Value = CDec(Me.NotifyForm1.ShowTime / 1000)

        'Startwert für Titelzeile
        Me.TextBox_Title.Text = Me.NotifyForm1.Title

        'Startwert für Meldungstext
        Me.TextBox_Message.Text = Me.NotifyForm1.Message

    End Sub


    Private Sub ComboBox_SelectedindexChanged(sender As Object, e As EventArgs) Handles _
                ComboBox_Style.SelectedIndexChanged,
                ComboBox_Design.SelectedIndexChanged

        'Auswahl merken
        Dim selindex As Integer = CType(
            sender,
            ComboBox).SelectedIndex

        Select Case True

            Case sender Is Me.ComboBox_Design

                'Design ändern
                Select Case selindex

                    Case 0
                        'Helles Desing
                        Me.NotifyForm1.Design = FormDesign.Bright
                    Case 1
                        'Farbiges Desing
                        Me.NotifyForm1.Design = FormDesign.Colorful

                    Case 2
                        'Dunkles Desing
                        Me.NotifyForm1.Design = FormDesign.Dark

                End Select

            Case sender Is Me.ComboBox_Style

                'Style ändern
                Select Case selindex

                    Case 0
                        'Infosymbol
                        Me.NotifyForm1.Style = FormStyle.Information

                    Case 1
                        'Fragesymbol
                        Me.NotifyForm1.Style = FormStyle.Question

                    Case 2
                        'Fehlersymbol
                        Me.NotifyForm1.Style = FormStyle.CriticalError

                    Case 3
                        'Hinweissymbol
                        Me.NotifyForm1.Style = FormStyle.Exclamation

                End Select

        End Select

    End Sub


    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles _
                TextBox_Title.TextChanged,
                TextBox_Message.TextChanged

        Dim text As String = CType(sender, TextBox).Text

        Select Case True

            Case sender Is Me.TextBox_Title

                'Titelzeile ändern
                Me.NotifyForm1.Title = text

            Case sender Is Me.TextBox_Message

                'Mitteilungstext ändern
                Me.NotifyForm1.Message = text

        End Select

    End Sub


    Private Sub NumericUpDown_ShowTime_ValueChanged_1(sender As Object, e As EventArgs) Handles _
                NumericUpDown_ShowTime.ValueChanged

        Me.NotifyForm1.ShowTime = CInt(CType(
            sender,
            NumericUpDown).Value * 1000)

    End Sub


    Private Sub Button_Show_Click(sender As Object, e As EventArgs) Handles _
                Button_Show.Click

        Me.NotifyForm1.Show()

    End Sub


End Class