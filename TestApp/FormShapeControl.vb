﻿' ****************************************************************************************************************
' FormShapeControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.Globalization
Imports System.Threading
Imports SchlumpfSoft.Controls.ShapeControl

Public Class FormShapeControl

    Private ReadOnly _ShapeModusItems() As String = {
        My.Resources.Shape_ModusItem1,
        My.Resources.Shape_ModusItem2,
        My.Resources.Shape_ModusItem3,
        My.Resources.Shape_ModusItem4,
        My.Resources.Shape_ModusItem5,
        My.Resources.Shape_ModusItem6,
        My.Resources.Shape_ModusItem7}

    Private ReadOnly _LineModusItems() As String = {
        My.Resources.Shape_LineModusItem1,
        My.Resources.Shape_LineModusItem2}

    Public Sub New()

        'Zuletzt verwendete Sprache einstellen
        Thread.CurrentThread.CurrentCulture = New CultureInfo(My.Settings.LangCode)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.LangCode)

        'Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        'Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.NumericUpDown_LineWidth.Minimum = 0
        Me.NumericUpDown_LineWidth.Maximum = 20
        Me.NumericUpDown_LineWidth.Value = CDec(Me.Shape1.LineWidth)
        Me.ComboBox_ShapeModus.Items.AddRange(Me._ShapeModusItems)
        Me.ComboBox_ShapeModus.SelectedIndex = Me.Shape1.ShapeModus
        Me.ComboBox_LineModus.Items.AddRange(Me._LineModusItems)
        Me.ComboBox_LineModus.SelectedIndex = Me.Shape1.DiagonalLineModus
        Me.ComboBox_LineModus.Enabled = False
        Me.Button_FillColor.Enabled = False

    End Sub

    Private Sub Button_Click(
                sender As Object,
                e As EventArgs) Handles _
                Button_LineColor.Click,
                Button_FillColor.Click

        Dim result As DialogResult

        Select Case True

            Case sender Is Me.Button_LineColor

                'Linienfarbe wählen
                With Me.ColorDialog
                    .Color = Me.Shape1.LineColor
                    result = .ShowDialog(Me)
                    If result = DialogResult.OK Then Me.Shape1.LineColor = .Color
                End With

            Case sender Is Me.Button_FillColor

                'Füllfarbe wählen
                With Me.ColorDialog
                    .Color = Me.Shape1.FillColor
                    result = .ShowDialog(Me)
                    If result = DialogResult.OK Then Me.Shape1.FillColor = .Color
                End With

        End Select

    End Sub

    Private Sub NumericUpDown_LineWidth_ValueChanged(
                sender As Object,
                e As EventArgs) Handles _
                NumericUpDown_LineWidth.ValueChanged

        'Breite der Linie oder des Rahmens schalten
        Dim selvalue As Decimal = CType(sender, NumericUpDown).Value
        Me.Shape1.LineWidth = selvalue

    End Sub

    Private Sub ComboBox_LineModus_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) Handles _
                ComboBox_LineModus.SelectedIndexChanged

        'Verlauf der diagonalen Linie schalten
        Dim selindex As Integer = CType(sender, ComboBox).SelectedIndex

        Me.Shape1.DiagonalLineModus = CType(selindex, DiagonalLineModes)

    End Sub

    Private Sub ComboBox_ShapeModus_SelectedIndexChanged(
                sender As Object,
                e As EventArgs) Handles _
                ComboBox_ShapeModus.SelectedIndexChanged

        'ausgewählte Form merken
        Dim selindex As Integer = CType(
            sender,
            ComboBox).SelectedIndex

        'Auswahlbox für Modus der diagonalen Linie schalten 
        Select Case selindex

            Case 2
                Me.ComboBox_LineModus.Enabled = True

            Case 0, 1, 3 To 6
                Me.ComboBox_LineModus.Enabled = False

        End Select

        'Auswahlbutton für die Füllfarbe schalten
        Select Case selindex

            Case 4, 6
                Me.Button_FillColor.Enabled = True

            Case 0 To 3, 5
                Me.Button_FillColor.Enabled = False

        End Select

        'ausgewählte Form umschalten
        Me.Shape1.ShapeModus = CType(selindex, ShapeModes)

    End Sub

End Class