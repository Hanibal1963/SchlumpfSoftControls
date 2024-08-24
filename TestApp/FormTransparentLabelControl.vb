' ****************************************************************************************************************
' FormTransparentLabelControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System.Globalization
Imports System.Threading

Public Class FormTransparentLabelControl


    Public Sub New()

        'Zuletzt verwendete Sprache einstellen
        Thread.CurrentThread.CurrentCulture = New CultureInfo(My.Settings.LangCode)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(My.Settings.LangCode)

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub


End Class
