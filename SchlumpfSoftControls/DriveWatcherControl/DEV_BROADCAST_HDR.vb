'
'****************************************************************************************************************
'DEV_BROADCAST_HDR.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Namespace DriveWatcherControl


	''' <summary>
	''' Die Struktur für den Header.
	''' </summary>
	''' <remarks>
	''' https://learn.microsoft.com/de-de/windows/win32/api/dbt/ns-dbt-dev_broadcast_hdr
	''' </remarks>
	Public Structure DEV_BROADCAST_HDR

		Dim dbch_size As Integer
		Dim dbch_devicetype As Integer
		Dim dbch_reserved As Integer

	End Structure


End Namespace