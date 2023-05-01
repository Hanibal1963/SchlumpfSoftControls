'
'****************************************************************************************************************
'DEV_BROADCAST_VOLUME.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Namespace DriveWatcherControl


	''' <summary>
	''' Die Struktur für Volumes.
	''' </summary>
	''' <remarks>
	''' https://learn.microsoft.com/de-de/windows/win32/api/dbt/ns-dbt-dev_broadcast_volume
	''' </remarks>
	Friend Structure DEV_BROADCAST_VOLUME

		Dim dbch_size As Integer
		Dim dbch_devicetype As Integer
		Dim dbch_reserved As Integer
		Dim dbcv_unitmask As Integer
		Dim dbcv_flags As Short

	End Structure


End Namespace
