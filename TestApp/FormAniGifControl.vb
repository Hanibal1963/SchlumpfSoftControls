﻿' ****************************************************************************************************************
' FormAniGifControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'



Imports SchlumpfSoft.Controls.AniGifControl

Public Class FormAniGifControl


    Private _Ani As Integer = 0
    Private _ComboBox_Ansicht_Items() As String = {$"Normal", $"Zentriert", $"Zoom", $"Gefüllt"}

    Public Sub New()

        'Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        'Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

        'Elemente der ComboBox für die Ansicht
        Me.ComboBox_Ansicht.Items.AddRange(Me._ComboBox_Ansicht_Items)

        'Standardanimation
        Me.ComboBox_Ansicht.SelectedIndex = 0

        'Standardwert für benutzerdefinierte Anzeigegeschwindigkeit 
        Me.NumericUpDown_FramesPerSecound.Value = Me.AniGif1.FramesPerSecond

        'Standardwert für Zoom
        Me.NumericUpDown_ZoomFactor.Value = Me.AniGif1.ZoomFactor

        'kein automatischer Start
        Me.CheckBox_AutoPlay.Checked = Me.AniGif1.AutoPlay

        Me.Button_Back.Enabled = False
        Me.ChangeAni()

    End Sub

    Private Sub ComboBoxAnsicht_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _
        ComboBox_Ansicht.SelectedIndexChanged

        'Anzeigemodus umschalten
        Select Case CType(sender, ComboBox).SelectedIndex

            Case 0

                Me.AniGif1.GifSizeMode = SchlumpfSoft.Controls.AniGifControl.SizeMode.Normal

            Case 1

                Me.AniGif1.GifSizeMode = SchlumpfSoft.Controls.AniGifControl.SizeMode.CenterImage

            Case 2

                Me.AniGif1.GifSizeMode = SchlumpfSoft.Controls.AniGifControl.SizeMode.Zoom

            Case 3

                Me.AniGif1.GifSizeMode = SchlumpfSoft.Controls.AniGifControl.SizeMode.Fill

        End Select

    End Sub


    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles _
        CheckBox_CustomDisplaySpeed.CheckStateChanged,
        CheckBox_AutoPlay.CheckedChanged

        Dim checkstate As Boolean = CType(sender, CheckBox).Checked

        Select Case True

            Case sender Is Me.CheckBox_AutoPlay

                'Autoplay umschalten
                Me.AniGif1.AutoPlay = checkstate

            Case sender Is Me.CheckBox_CustomDisplaySpeed

                'Benutzerdefinierte Geschwindigkeit umschalten
                Me.AniGif1.CustomDisplaySpeed = checkstate

        End Select

    End Sub


    Private Sub NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles _
        NumericUpDown_ZoomFactor.ValueChanged,
        NumericUpDown_FramesPerSecound.ValueChanged

        Dim numericupdownvalue As Integer = CInt(CType(sender, NumericUpDown).Value)

        Select Case True

            Case sender Is Me.NumericUpDown_FramesPerSecound

                'benutzerdefinierte Anzeigegeschwindigkeit einstellen
                Me.AniGif1.FramesPerSecond = numericupdownvalue

            Case sender Is Me.NumericUpDown_ZoomFactor

                'Zoom ändern
                Me.AniGif1.ZoomFactor = numericupdownvalue

        End Select

    End Sub


    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles _
        Button_Forward.Click,
        Button_Back.Click

        Select Case True

            Case sender Is Me.Button_Back

                'Animationsnummer verringern solange > 0
                If Me._Ani > 0 Then Me._Ani -= 1

                'Vor-Button aktivieren
                Me.Button_Forward.Enabled = True

                'Zurück-Button deaktivieren wenn Animationsnummer = 0
                If Me._Ani = 0 Then Me.Button_Back.Enabled = False


            Case sender Is Me.Button_Forward

                'Animationsnummer erhöhen solange < 20
                If Me._Ani < 20 Then Me._Ani += 1

                'Zurück-Button aktivieren
                Me.Button_Back.Enabled = True

                'Vor-Button deaktivieren wenn Animationsnummer = 20
                If Me._Ani = 20 Then Me.Button_Forward.Enabled = False

        End Select

        'Animation umschalten
        Me.ChangeAni()

    End Sub


    Private Sub AniGif1_NoAnimation(sender As Object, e As NoAnimationEventArgs) Handles _
        AniGif1.NoAnimation

        Dim prompt As String = $"Das Bild kann nicht animiert werden."
        Dim title As String = $"Keine Animation"
        Dim unused = MsgBox(prompt,, title)

    End Sub


    Private Sub ChangeAni()

        'Animationsnummer anzeigen
        Select Case Me._Ani

            Case Is <> 0 : Me.Label_Ani.Text = String.Format("Animation Nr.: {0}", Me._Ani.ToString)
            Case Else : Me.Label_Ani.Text = $"Standardanimation"

        End Select

        'Animation schalten
        Select Case Me._Ani

            Case Is <> 0 : Me.AniGif1.Gif = CType(My.Resources.ResourceManager.GetObject("Anim" & CStr(100 + Me._Ani - 1)), Bitmap)
            Case Else : Me.AniGif1.Gif = Nothing

        End Select

    End Sub


End Class