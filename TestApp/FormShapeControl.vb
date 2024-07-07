' ****************************************************************************************************************
' FormShapeControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Public Class FormShapeControl


    Private _ShapeModusItems() As String =
        {$"horizontale Linie", $"vertikale Linie", $"diagonale Linie", $"Rechteck", $"gefülltes Rechteck", $"Ellipse", $"gefüllte Ellipse"}

    Private _LineModusItems() As String =
        {$"links oben", $"links unten"}


    Public Sub New()

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
        Dim selindex As Integer = CType(
            sender,
            ComboBox).SelectedIndex

        Me.Shape1.DiagonalLineModus = CType(
            selindex,
            SchlumpfSoft.Controls.ShapeControl.DiagonalLineModes)

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
        Me.Shape1.ShapeModus = CType(
            selindex,
            SchlumpfSoft.Controls.ShapeControl.ShapeModes)

    End Sub


End Class