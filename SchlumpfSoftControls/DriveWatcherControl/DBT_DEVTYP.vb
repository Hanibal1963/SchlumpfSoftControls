'
'****************************************************************************************************************
'DBT_DEVTYP.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Namespace DriveWatcherControl


	''' <summary>
	''' Das sind die Konstanten der Gerätetypen
	''' </summary>
	''' <remarks>
	''' Vorsicht die Gerätetypen Variablen in den Strukturen sind vom Typ Integer.
	''' IntelliSense kann das nicht auflösen.
	''' </remarks>
	Friend Enum DBT_DEVTYP

		''' <summary>
		''' OEM- oder IHV-definiert
		''' </summary>
		OEM = 0

		''' <summary>
		''' Devnode-Nummer
		''' </summary>
		DEVNODE = 1

		''' <summary>
		''' Logisches Volumen
		''' </summary>
		VOLUME = 2

		''' <summary>
		''' Port (seriell oder parallel)
		''' </summary>
		PORT = 3

		''' <summary>
		''' Netzwerkressource
		''' </summary>
		NET = 4

		''' <summary>
		''' Geräteschnittstellenklasse
		''' </summary>
		DEVICEINTERFACE = 5

		''' <summary>
		''' Dateisystem-Handle
		''' </summary>
		HANDLE = 6

	End Enum


End Namespace
