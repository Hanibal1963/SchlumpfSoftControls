' ****************************************************************************************************************
' SchlumpfSoftControlsPackage.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System
Imports System.Runtime.InteropServices
Imports System.Threading
Imports Microsoft.VisualStudio.Shell


''' <summary>
''' Dies ist die Klasse, die das von dieser Assembly bereitgestellte Paket implementiert.
''' </summary>
''' <remarks>
''' <para>
''' Die Mindestanforderung, damit eine Klasse als gültiges Paket für Visual Studio angesehen wird, 
''' ist die Implementierung der IVs-Paketschnittstelle und die Registrierung bei der Shell. 
''' Dieses Paket verwendet dazu die im Managed Package Framework (MPF) definierten Hilfsklassen: 
''' Es leitet sich von der Paketklasse ab, die die Implementierung der IVs-Paketschnittstelle bereitstellt, 
''' und verwendet die im Framework definierten Registrierungsattribute, um 
''' sich selbst und seine Komponenten bei der Shell zu registrieren. 
''' Diese Attribute teilen dem Dienstprogramm zur Erstellung von pkgdefs mit, 
''' welche Daten in die .pkgdef-Datei eingefügt werden sollen. 
''' </para>
''' <para>
''' Um in VS geladen zu werden, muss auf das Paket in der .vsixmanifest-Datei 
''' mit &lt;Asset Type="Microsoft.Visual Studio.Vs Package" ...&gt; verwiesen werden.
''' </para>
''' </remarks>
<PackageRegistration(UseManagedResourcesOnly:=True, AllowsBackgroundLoading:=True)>
<Guid(SchlumpfSoftControlsPackage.PackageGuidString)>
Public NotInheritable Class SchlumpfSoftControlsPackage


    Inherits AsyncPackage


    ''' <summary>
    ''' Package guid
    ''' </summary>
    Public Const PackageGuidString As String = "6daeed23-f0ef-4b11-8d6d-883af017e441"


#Region "Package Members"

    ''' <summary>
    ''' Initialisierung des Pakets; diese Methode wird direkt nach der Platzierung des Pakets aufgerufen. 
    ''' Dies ist also der Ort, wo Sie den gesamten Initialisierungscode einfügen können, 
    ''' der auf von Visual Studio bereitgestellten Diensten basiert.    
    ''' </summary>
    ''' <param name="cancellationToken">
    ''' Ein Abbruchtoken zur Überwachung des Initialisierungsabbruchs, 
    ''' der beim Herunterfahren von VS auftreten kann.    
    ''' </param>
    ''' <param name="progress">
    ''' Ein Anbieter für Fortschrittsaktualisierungen.
    ''' </param>
    ''' <returns>
    ''' Eine Aufgabe, die die asynchrone Arbeit der Paketinitialisierung darstellt, 
    ''' oder eine bereits abgeschlossene Aufgabe, wenn keine vorhanden ist. 
    ''' Geben Sie von dieser Methode nicht null zurück.  
    ''' </returns>
    Protected Overrides Async Function InitializeAsync(
                                       cancellationToken As CancellationToken,
                                       progress As IProgress(Of ServiceProgressData)) As Tasks.Task

        ' Bei asynchroner Initialisierung kann der aktuelle Thread an dieser Stelle ein Hintergrundthread sein. 
        ' Führen Sie alle Initialisierungen durch, die den UI-Thread erfordern, nachdem Sie zum UI-Thread gewechselt sind.
        Await Me.JoinableTaskFactory.SwitchToMainThreadAsync()

    End Function

#End Region


End Class
