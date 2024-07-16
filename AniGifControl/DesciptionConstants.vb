' ****************************************************************************************************************
' DesciptionConstants.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Friend Module DesciptionConstants


#Region "Konstanten für Kategorinamen"

    Friend Const Category_Appearance = "Appearance"
    Friend Const Category_Behavior = "Behavior"

#End Region


#Region "Konstanten für Beschreibungstexte"

    'Klassenbeschreibungen
    Friend Const AniGif_Description = "Control zum Anzeigen von animierten Grafiken."

    'Eventbeschreibungen
    Friend Const NoAnimation_Description = "Wird ausgelöst wenn die Grafik nicht animiert werden kann."

    'Eigenschaftsbeschreibungen
    Friend Const AutoPlay_Description = "Legt fest ob die Animation sofort nach dem laden gestartet wird."
    Friend Const Gif_Description = "Gibt die animierte Gif-Grafik zurück oder legt diese fest."
    Friend Const GifSizeMode_Description = "Gibt die Art wie die Grafik angezeigt wird zurück oder legt diese fest."
    Friend Const CustomDisplaySpeed_Description = "Legt fest ob die benutzerdefinierte Anzeigegeschwindigkeit oder die in der Datei festgelegte Geschwindigkeit benutzt wird."
    Friend Const FramesPerSecond_Description = "Legt die benutzerdefinierte Anzeigegeschwindigkeit in Bildern/Sekunde fest wenn CustomDisplaySpeed auf True festgelegt ist."
    Friend Const ZoomFactor_Description = "Legt den Zoomfaktor fest wenn GifSizeMode auf Zoom festgelegt ist."

#End Region


End Module
