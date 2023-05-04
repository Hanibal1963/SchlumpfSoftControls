'
'****************************************************************************************************************
'DriveWatcher.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'


Imports System.ComponentModel

''' <summary>
''' Steuerelement um die Laufwerke zu überwachen.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Steuerelement um die Laufwerke zu überwachen.")>
<ToolboxItem(True)>
Public Class DriveWatcher


		Private WithEvents _Form As New NativeForm


#Region "Eventdefinitionen"

		''' <summary>
		''' Wird ausgelöst wenn ein Laufwerk hinzugefügt wurde.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e">
		''' Enthält die Eigenschaften zum hinzugefügten Laufwerk. (<see cref="DriveAddedEventArgs"/>)
		''' </param>
		Public Event DriveAdded(sender As Object, e As DriveAddedEventArgs)

		''' <summary>
		''' Wird ausgelöst wenn ein Laufwerk entfernt wurde.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e">
		''' Enthält die eigenschaften zum entfernten Laufwerk. (<see cref="DriveRemovedEventArgs"/>)
		''' </param>
		Public Event DriveRemoved(sender As Object, e As DriveRemovedEventArgs)

#End Region


#Region "interne Methoden"

		''' <summary>
		''' wird ausgeführt wenn ein Laufwerk hinzugefügt wurde.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e">
		''' Enthält Informationen über das Laufwerk.
		''' </param>
		Private Sub _Form_DriveAdded(sender As Object, e As System.IO.DriveInfo) Handles _Form.DriveAdded

			Dim arg As New DriveAddedEventArgs With {
			.DriveName = e.Name, .VolumeLabel = e.VolumeLabel, .AvailableFreeSpace = e.AvailableFreeSpace,
			.TotalFreeSpace = e.TotalFreeSpace, .TotalSize = e.TotalSize, .DriveFormat = e.DriveFormat,
			.DriveType = e.DriveType, .IsReady = e.IsReady}
			RaiseEvent DriveAdded(Me, arg)

		End Sub


		''' <summary>
		''' wird ausgeführt wenn ein Laufwerk entfernt wurde.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e">
		''' Enthält Informationen über das Laufwerk.
		''' </param>
		Private Sub _Form_DriveRemoved(sender As Object, e As System.IO.DriveInfo) Handles _Form.DriveRemoved

			Dim arg As New DriveRemovedEventArgs With {.DriveName = e.Name}
			RaiseEvent DriveRemoved(Me, arg)

		End Sub

#End Region


#Region "Klassendefinitionen"


	Public Class DriveRemovedEventArgs


		''' <summary>
		''' Ruft den Namen eines Laufwerks ab, z.B. C:\.
		''' </summary>
		''' <returns></returns>
		Public Property DriveName As String


	End Class


	Public Class DriveAddedEventArgs


		''' <summary>
		''' Ruft den Namen eines Laufwerks ab, z.B. C:\.
		''' </summary>
		''' <returns></returns>
		Public Property DriveName As String

		''' <summary>
		''' Ruft die Volumebezeichnung eines Laufwerks ab oder legt diese fest.
		''' </summary>
		''' <returns></returns>
		Public Property VolumeLabel As String

		''' <summary>
		''' Gibt die Gesamtmenge an verfügbarem freiem Speicherplatz in Bytes an, die auf einem Laufwerk verfügbar ist.
		''' </summary>
		''' <returns></returns>
		Public Property AvailableFreeSpace As Long

		''' <summary>
		''' Ruft die Gesamtmenge an freiem Speicherplatz in Bytes ab, die auf einem Laufwerk verfügbar ist.
		''' </summary>
		''' <returns></returns>
		Public Property TotalFreeSpace As Long

		''' <summary>
		''' Ruft die Gesamtgröße des Speicherplatzes in Bytes auf einem Laufwerk ab.
		''' </summary>
		''' <returns></returns>
		Public Property TotalSize As Long

		''' <summary>
		''' Ruft den Namen des Dateisystems ab, z. B. NTFS oder FAT32.
		''' </summary>
		''' <returns></returns>
		Public Property DriveFormat As String

		''' <summary>
		''' Ruft den Laufwerkstyp ab, wie z. B. CD-ROM, Wechseldatenträger, Netzlaufwerk oder lokales Festplattenlaufwerk.
		''' </summary>
		''' <returns></returns>
		Public Property DriveType As System.IO.DriveType

		''' <summary>
		''' Ruft einen Wert ab, der angibt, ob ein Laufwerk bereit ist.
		''' </summary>
		''' <returns></returns>
		Public Property IsReady As Boolean


	End Class


	Partial Private Class NativeForm : Inherits System.Windows.Forms.NativeWindow


		'Das sind die Ereignisse aus WParam.
		'Uns interessiert nur, ob ein Laufwerk hinzugekommen ist oder entfernt wurde.
		Public Event DriveAdded(sender As Object, e As System.IO.DriveInfo)
		Public Event DriveRemoved(sender As Object, e As System.IO.DriveInfo)

		'Windowmessage DeviceChange
		Private Const WM_DEVICECHANGE As Integer = &H219

		'Die beiden Ereignisse, die für uns von Bedeutung sind.
		Private Const DBT_DEVICEARRIVAL As Integer = &H8000
		Private Const DBT_DEVICEREMOVECOMPLETE As Integer = &H8004

		'Dies ist der Dreh- und Angelpunkt der Klasse. - Hier bekommen wir die Messages mit.
		'In unserm Fall interessiert uns nur die WM_DeviceChange-Nachricht
		Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

			If m.Msg = WM_DEVICECHANGE Then
				HandleHeader(m)
			End If
			MyBase.WndProc(m)

		End Sub

		'Hier schauen wir erst mal in den Header und verzweigen dementsprechend
		Private Sub HandleHeader(ByRef m As System.Windows.Forms.Message)

			Dim header As DEV_BROADCAST_HDR
			Dim objHeader As Object = m.GetLParam(header.GetType)

			If Not Microsoft.VisualBasic.IsNothing(objHeader) Then

				Select Case header.dbch_devicetype

					Case DBT_DEVTYP.OEM : HandleOEM(m)
					Case DBT_DEVTYP.DEVNODE
					Case DBT_DEVTYP.VOLUME : HandleVolume(m)
					Case DBT_DEVTYP.PORT
					Case DBT_DEVTYP.NET
					Case DBT_DEVTYP.DEVICEINTERFACE
					Case DBT_DEVTYP.HANDLE

				End Select

			End If

		End Sub

		'Das Ereignis betrifft ein Volume
		Private Sub HandleVolume(ByRef m As System.Windows.Forms.Message)

			Dim volume As DEV_BROADCAST_VOLUME
			Dim objVolume As Object = m.GetLParam(volume.GetType)

			If Not Microsoft.VisualBasic.IsNothing(objVolume) Then

				volume = DirectCast(objVolume, DEV_BROADCAST_VOLUME)
				Dim di As New System.IO.DriveInfo(DriveFromMask(volume.dbcv_unitmask))

				Select Case CInt(m.WParam)

					Case DBT_DEVICEARRIVAL : RaiseEvent DriveAdded(Me, di)
					Case DBT_DEVICEREMOVECOMPLETE : RaiseEvent DriveRemoved(Me, di)

				End Select

			End If

		End Sub

		'OEM, und was genau?
		'Uns interesieren nur Volumes
		Private Sub HandleOEM(ByRef m As System.Windows.Forms.Message)

			Dim oem As DEV_BROADCAST_OEM
			Dim objOem As Object = m.GetLParam(oem.GetType)

			If Not Microsoft.VisualBasic.IsNothing(objOem) Then

				oem = DirectCast(objOem, DEV_BROADCAST_OEM)

				If oem.dbco_devicetype = DBT_DEVTYP.VOLUME Then
					HandleVolume(m)
				End If

			End If

		End Sub

		'Liefert den Laufwerksbuchstaben zurück
		Private Function DriveFromMask(mask As Integer) As Char

			Dim result As Char = CChar(String.Empty)

			For b As Integer = 0 To 25

				If (mask And CInt(2 ^ b)) <> 0 Then
					result = Microsoft.VisualBasic.Chr(65 + b)
					Exit For
				End If

			Next b

			Return result

		End Function

		Public Sub New()

			'eigenes Handle erstellen
			CreateHandle(New System.Windows.Forms.CreateParams)

		End Sub

		Protected Overrides Sub Finalize()

			'eigenes Handle zerstören
			DestroyHandle()
			MyBase.Finalize()

		End Sub


	End Class


#End Region


#Region "Auflistungen"

	''' <summary>
	''' Das sind die Konstanten der Gerätetypen
	''' </summary>
	''' <remarks>
	''' Vorsicht die Gerätetypen Variablen in den Strukturen sind vom Typ Integer.
	''' IntelliSense kann das nicht auflösen.
	''' </remarks>
	Private Enum DBT_DEVTYP

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

#End Region


#Region "Strukturdefinitionen"

	''' <summary>
	''' Die Struktur für OEM.
	''' </summary>
	''' <remarks>
	''' https://learn.microsoft.com/de-de/windows/win32/api/dbt/ns-dbt-dev_broadcast_oem
	''' </remarks>
	Private Structure DEV_BROADCAST_OEM

		Dim dbco_size As Integer
		Dim dbco_devicetype As Integer
		Dim dbco_reserved As Integer
		Dim dbco_identifier As Integer
		Dim dbco_suppfunc As Integer

	End Structure


	''' <summary>
	''' Die Struktur für den Header.
	''' </summary>
	''' <remarks>
	''' https://learn.microsoft.com/de-de/windows/win32/api/dbt/ns-dbt-dev_broadcast_hdr
	''' </remarks>
	Private Structure DEV_BROADCAST_HDR

		Dim dbch_size As Integer
		Dim dbch_devicetype As Integer
		Dim dbch_reserved As Integer

	End Structure


	''' <summary>
	''' Die Struktur für Volumes.
	''' </summary>
	''' <remarks>
	''' https://learn.microsoft.com/de-de/windows/win32/api/dbt/ns-dbt-dev_broadcast_volume
	''' </remarks>
	Private Structure DEV_BROADCAST_VOLUME

		Dim dbch_size As Integer
		Dim dbch_devicetype As Integer
		Dim dbch_reserved As Integer
		Dim dbcv_unitmask As Integer
		Dim dbcv_flags As Short

	End Structure

#End Region


End Class
