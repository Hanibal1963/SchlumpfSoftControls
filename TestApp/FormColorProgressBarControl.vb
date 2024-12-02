' ****************************************************************************************************************
' FormColorProgressBarControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports SchlumpfSoft.Controls.ColorProgressBarControl

Public Class FormColorProgressBarControl

    Public Sub New()
        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me.NumericUpDownProgressValue.Value = Me.GetProgressValue(Me.ColorProgressBar.Value)
    End Sub

    Private Function GetProgressValue(Value As Integer) As Decimal
        'TODO: Wert des Fortschrittsbalkens in Prozent zurückgeben
    End Function

    Private Function SetProgressValue(Value As Decimal) As Integer
        'TODO: Wert des Fortschrittsbalkens aus dem Prozentwert berechnen
    End Function

    ''' <summary>
    ''' Farbauswahl für den Fortschrittsbalken
    ''' </summary>
    Private Sub ButtonBarColor_Click(sender As Object, e As EventArgs) Handles ButtonBarColor.Click
        Me.ColorDialog.Color = Me.ColorProgressBar.BarColor
        If Me.ColorDialog.ShowDialog = DialogResult.OK Then
            Me.ColorProgressBar.BarColor = Me.ColorDialog.Color
        End If
    End Sub

    ''' <summary>
    ''' Farbauswahl für den Fortschrittsbalken
    ''' </summary>
    Private Sub ButtonBorderColor_Click(sender As Object, e As EventArgs) Handles ButtonBorderColor.Click
        Me.ColorDialog.Color = Me.ColorProgressBar.BorderColor
        If Me.ColorDialog.ShowDialog = DialogResult.OK Then
            Me.ColorProgressBar.BorderColor = Me.ColorDialog.Color
        End If
    End Sub

    ''' <summary>
    ''' Farbauswahl für den leeren Bereich
    ''' </summary>
    Private Sub ButtonEmptyColor_Click(sender As Object, e As EventArgs) Handles ButtonEmptyColor.Click
        Me.ColorDialog.Color = Me.ColorProgressBar.EmptyColor
        If Me.ColorDialog.ShowDialog = DialogResult.OK Then
            Me.ColorProgressBar.EmptyColor = Me.ColorDialog.Color
        End If
    End Sub

    ''' <summary>
    ''' Rahmen anzeigen oder nicht
    ''' </summary>
    Private Sub CheckBoxShowBorder_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxShowBorder.CheckStateChanged
        Select Case CType(sender, CheckBox).CheckState
            Case CheckState.Checked
                Me.ColorProgressBar.ShowBorder = True
            Case CheckState.Unchecked
                Me.ColorProgressBar.ShowBorder = False
        End Select
    End Sub

    ''' <summary>
    ''' Gliss-Effekt anzeigen oder nicht
    ''' </summary>
    Private Sub CheckBoxShowGliss_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxShowGliss.CheckStateChanged
        Select Case CType(sender, CheckBox).CheckState
            Case CheckState.Checked
                Me.ColorProgressBar.IsGlossy = True
            Case CheckState.Unchecked
                Me.ColorProgressBar.IsGlossy = False
        End Select
    End Sub

    Private Sub NumericUpDownProgressValue_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownProgressValue.ValueChanged
        'TODO: Wert des Fortschrittsbalkens berechnen
        Me.ColorProgressBar.Value = Me.SetProgressValue(Me.NumericUpDownProgressValue.Value)
    End Sub

End Class