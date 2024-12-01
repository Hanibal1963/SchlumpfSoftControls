' ****************************************************************************************************************
' FormColorProgressBarControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

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

    Private Sub ButtonBarColor_Click(sender As Object, e As EventArgs) Handles ButtonBarColor.Click
        'TODO: Farbauswahl für den Fortschrittsbalken ändern
    End Sub

    Private Sub ButtonBorderColor_Click(sender As Object, e As EventArgs) Handles ButtonBorderColor.Click
        'TODO: Farbauswahl für den Rahmen ändern
    End Sub

    Private Sub ButtonEmptyColor_Click(sender As Object, e As EventArgs) Handles ButtonEmptyColor.Click
        'TODO: Farbauswahl für den leeren Bereich ändern
    End Sub

    Private Sub CheckBoxShowBorder_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxShowBorder.CheckStateChanged
        'TODO: Rahmen anzeigen oder nicht
    End Sub

    Private Sub CheckBoxShowGliss_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBoxShowGliss.CheckStateChanged
        'TODO: Gliss-Effekt anzeigen oder nicht
    End Sub

    Private Sub NumericUpDownProgressValue_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownProgressValue.ValueChanged
        'TODO: Wert des Fortschrittsbalkens berechnen
        Me.ColorProgressBar.Value = Me.SetProgressValue(Me.NumericUpDownProgressValue.Value)
    End Sub

End Class