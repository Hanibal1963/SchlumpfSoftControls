'
'****************************************************************************************************************
'SchlumpfSoftControlsPackage.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Imports System
Imports System.Runtime.InteropServices
Imports Microsoft.VisualStudio.Shell
Imports System.Threading
Imports System.Threading.Tasks


''' <summary>
''' Dies ist die Klasse, die das von dieser Assembly verfügbar gemachte Paket implementiert.
''' </summary>
''' <remarks>
''' <para>
''' Die Mindestanforderung für eine Klasse, um als gültiges Paket für Visual Studio betrachtet zu werden
''' Soll die IVs-Paketschnittstelle implementieren und sich bei der Shell registrieren.
''' Dieses Paket verwendet die im Managed Package Framework (MPF) definierten Hilfsklassen.
''' um es zu tun: Es leitet sich von der Paketklasse ab, die die Implementierung von bereitstellt
''' IVs Package Interface And verwendet die im Framework To definierten Registrierungsattribute
''' Registrieren Sie sich und seine Komponenten mit der Shell. Diese Attribute teilen die Erstellung von pkgdef mit
''' Dienstprogramm, welche Daten in die .pkgdef-Datei eingefügt werden sollen.
''' </para>
''' <para>
''' Um in VS geladen zu werden, muss das Paket von 
''' &lt;Asset Type="Microsoft.Visual Studio.Vs Package" ...&gt; 
''' in der .vsixmanifest-Datei.
''' </para>
''' </remarks>
<PackageRegistration(UseManagedResourcesOnly:=True, AllowsBackgroundLoading:=True)>
<Guid(SchlumpfSoftControlsPackage.PackageGuidString)>
Public NotInheritable Class SchlumpfSoftControlsPackage : Inherits AsyncPackage

	''' <summary>
	''' Package guid
	''' </summary>
	Public Const PackageGuidString As String = "c33ea017-d9d5-4ae0-9135-836b9f310d4a"


	''' <summary>
	''' Initialisierung des Pakets; Diese Methode wird direkt nach dem Bereitstellen des Pakets aufgerufen, 
	''' also ist dies der Ort wo Sie den gesamten Initialisierungscode einfügen können, 
	''' der sich auf die von Visual Studio bereitgestellten Dienste stützt.
	''' </summary>
	''' <param name="cancellationToken">
	''' Ein Abbruchtoken zum Überwachen des Initialisierungsabbruchs, der auftreten kann, 
	''' wenn VS heruntergefahren wird.
	''' </param>
	''' <param name="progress">
	''' Ein Anbieter für Fortschrittsaktualisierungen.
	''' </param>
	''' <returns>
	''' Eine Aufgabe, die die asynchrone Arbeit der Paketinitialisierung darstellt, 
	''' oder eine bereits abgeschlossene Aufgabe, falls keine vorhanden ist. 
	''' Geben Sie von dieser Methode nicht null zurück.
	''' </returns>
	Protected Overrides Async Function InitializeAsync(
		cancellationToken As CancellationToken,
		progress As IProgress(Of ServiceProgressData)) As Task

		' Bei asynchroner Initialisierung kann der aktuelle Thread zu diesem Zeitpunkt ein Hintergrundthread sein.
		' Führen Sie alle Initialisierungen durch, die den UI-Thread erfordern, nachdem Sie zum UI-Thread gewechselt haben.
		Await Me.JoinableTaskFactory.SwitchToMainThreadAsync()

	End Function


End Class
