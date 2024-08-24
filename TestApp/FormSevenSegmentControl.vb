' ****************************************************************************************************************
' FormSevenSegmentControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System.Globalization
Imports System.Threading


Public Class FormSevenSegmentControl


    Public Sub New()

        'Zuletzt verwendete Sprache einstellen
        Thread.CurrentThread.CurrentCulture = New CultureInfo(My.Settings.LangCode)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.LangCode)

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        'Anzahl der eingebaren Zeichen der textboxen begrenzen
        Me.TextBox1.MaxLength = 1
        Me.TextBox2.MaxLength = 7

    End Sub


    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles _
                TextBox2.TextChanged,
                TextBox1.TextChanged

        Dim text As String = CType(sender, TextBox).Text

        Select Case True

            Case sender Is Me.TextBox1
                Me.SevSegSingleDigit1.DigitValue = text

            Case sender Is Me.TextBox2

                'Anzeige auf die Anzahl der eingegebenen Zeichen (min = 1, max = 7) anpassen
                Select Case text.Length

                    Case < 1
                        'kein oder ein zeichen
                        Me.SevSegMultiDigit1.DigitCount = 1
                        Me.SevSegMultiDigit1.Size = New Size With {
                            .Height = Me.SevSegMultiDigit1.Size.Height,
                            .Width = 60}

                    Case Else
                        'zwei oder mehr Zeichen
                        Me.SevSegMultiDigit1.DigitCount = text.Length
                        Me.SevSegMultiDigit1.Size = New Size With {
                            .Height = Me.SevSegMultiDigit1.Size.Height,
                            .Width = 60 * text.Length}

                End Select

                Me.SevSegMultiDigit1.Value = text

        End Select

    End Sub


End Class