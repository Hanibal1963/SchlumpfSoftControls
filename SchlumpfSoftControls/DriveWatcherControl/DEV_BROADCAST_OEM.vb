'
'****************************************************************************************************************
'DEV_BROADCAST_OEM.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Namespace DriveWatcherControl


	''' <summary>
	''' Die Struktur für OEM.
	''' </summary>
	''' <remarks>
	''' https://learn.microsoft.com/de-de/windows/win32/api/dbt/ns-dbt-dev_broadcast_oem
	''' </remarks>
	Friend Structure DEV_BROADCAST_OEM

		Dim dbco_size As Integer
		Dim dbco_devicetype As Integer
		Dim dbco_reserved As Integer
		Dim dbco_identifier As Integer
		Dim dbco_suppfunc As Integer

	End Structure


End Namespace
