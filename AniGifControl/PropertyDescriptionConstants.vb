' ****************************************************************************************************************
' PropertyDescriptionConstants.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


''' <summary>
''' Definiert die Beschreibungen der Eigenschaften
''' </summary>
Friend Class PropertyDescriptionConstants


    Public Const AutoPlay_Description =
        "Legt fest ob die Animation sofort nach dem laden gestartet wird."

    Public Const Gif_Description =
        "Gibt die animierte Gif-Grafik zurück oder legt diese fest."

    Public Const GifSizeMode_Description =
        "Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest."

    Public Const CustomDisplaySpeed_Description =
        "Legt fest ob die benutzerdefinierte Anzeigegeschwindigkeit oder 
        die in der Datei festgelegte Geschwindigkeit benutzt wird."

    Public Const FramesPerSecond_Description =
        "Legt die benutzerdefinierte Anzeigegeschwindigkeit in Bildern/Sekunde fest 
        wenn CustomDisplaySpeed auf True festgelegt ist."

    Public Const ZoomFactor_Description =
        "Legt den Zoomfaktor fest wenn GifSizeMode auf Zoom festgelegt ist."


End Class
