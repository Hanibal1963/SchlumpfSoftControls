'
'****************************************************************************************************************
'AniGifSizeMode.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Namespace AniGifControl


	''' <summary>
	''' Auflistung der Anzeigemodi
	''' </summary>
	Public Enum GifSizeMode

		''' <summary>
		''' Die Grafik wird in Originalgröße angezeigt.
		''' </summary>
		''' <remarks>
		''' Ausrichtung oben links.
		''' </remarks>
		Normal = 0

		''' <summary>
		''' Die Grafik wird in Originalgröße angezeigt.
		''' </summary>
		''' <remarks>
		''' zentrierte Ausrichtung.
		''' </remarks>
		CenterImage = 1

		''' <summary>
		''' Die Grafik wird an die Größe des Controls angepasst.
		''' </summary>
		''' <remarks>
		''' zentrierte Ausrichtung
		''' </remarks>
		Zoom = 2

	End Enum


End Namespace
