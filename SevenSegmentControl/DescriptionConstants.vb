' ****************************************************************************************************************
' DescriptionConstants.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Friend Module DescriptionConstants

#Region "Konstanten für Kategorinamen"

    Friend Const Category_Appearance = "Appearance"

#End Region

#Region "Konstanten für Beschreibungstexte"

    'Klassenbeschreibungen
    Friend Const SevSegSingleDigit_Description = "Control zum Anzeigen einer Ziffer als 7-Segmentanzeige."
    Friend Const SevSegMultiDigit_Description = "Control zum Anzeigen einer Ziffernfolge als 7-Segmentanzeige."

    'Eigenschaftsbeschreibungen
    Friend Const InactiveColor_Description = "Legt die Farbe inaktiver Segmente fest oder gibt diese zurück."
    Friend Const SegmentWidth_Description = "Legt die Breite der LED-Segmente fest oder gibt diese zurück."
    Friend Const ItalicFactor_Description = "Scherkoeffizient für die Kursivschrift der Anzeige."
    Friend Const DigitValue_Desciption = "Legt das anzuzeigende Zeichen fest oder gibt dieses zurück."
    Friend Const CustomBitPattern_Description = "Legt ein benutzerdefiniertes Bitmuster fest, das in den _
                                                sieben Segmenten angezeigt werden soll. _
                                                Dies ist ein ganzzahliger Wert, bei dem die Bits 0 bis 6 den _
                                                jeweiligen LED-Segmenten entsprechen."
    Friend Const ShowDecimalPoint_Description = "Gibt an, ob die Dezimalpunkt-LED angezeigt wird."
    Friend Const DecimalPointActive_Description = "Gibt an, ob die Dezimalpunkt-LED aktiv ist."
    Friend Const ShowColon_Description = "Gibt an, ob die Doppelpunkt-LEDs angezeigt werden."
    Friend Const ColonActive_Description = "Gibt an, ob die Doppelpunkt-LEDs aktiv sind."
    Friend Const BackColor_Description = "Legt die Hintergrundfarbe des Controls fest oder gibt diese zurück."
    Friend Const ForeColor_Description = "Legt die Vordergrundfarbe der Segmente des Controls fest oder gibt diese zurück."
    Friend Const DigitCount_Description = "Anzahl der Digits in diesem Control."
    Friend Const DigitPadding_Description = "Auffüllung, die für jedes Digit im Control gilt."
    Friend Const Value_Description = "Der auf dem Control anzuzeigende Wert."

#End Region

End Module
