'
'****************************************************************************************************************
'ProvideToolboxControlAttribute.vb
'(c) 2023 by Andreas Sauer
'****************************************************************************************************************
'

Imports System
Imports System.Globalization
Imports System.Runtime.InteropServices
Imports System.Diagnostics.CodeAnalysis
Imports Microsoft.VisualStudio.Shell


''' <summary>
''' Dieses Attribut fügt einen Toolbox Controls Installer-Schlüssel für die Assembly hinzu, 
''' um Toolbox-Steuerelemente aus der Assembly zu installieren.
''' </summary>
''' <remarks>
''' Zum Beispiel
'''     [$(Rootkey)\ToolboxControlsInstaller\$FullAssemblyName$]
'''         "Codebase"="$path$"
'''         "WpfControls"="1"
''' </remarks>
<AttributeUsage(AttributeTargets.Class, AllowMultiple:=False, Inherited:=True)>
<ComVisibleAttribute(False)>
Public NotInheritable Class ProvideToolboxControlAttribute : Inherits RegistrationAttribute

    Private Const ToolboxControlsInstallerPath As String = "ToolboxControlsInstaller"

    <SuppressMessage(
        "Style", "IDE0032:Automatisch generierte Eigenschaft verwenden",
        Justification:="<Ausstehend>")>
    Private _isWpfControls As Boolean

    <SuppressMessage(
        "Style", "IDE0032:Automatisch generierte Eigenschaft verwenden",
        Justification:="<Ausstehend>")>
    Private _name As String

    ''' <summary>
    ''' Erstellt ein neues Attribut zum Bereitstellen von Toolbox-Steuerelementen, 
    ''' um die Assembly für das Installationsprogramm für Toolbox-Steuerelemente zu registrieren.
    ''' </summary>
    ''' <param name="isWpfControls">
    ''' </param>
    Public Sub New(name As String, isWpfControls As Boolean)

        If name Is Nothing Then
            Throw New ArgumentException(Nothing, NameOf(name))
        End If

        Me.Name = name
        Me.IsWpfControls = isWpfControls

    End Sub

    ''' <summary>
    ''' Ruft ab, ob die Toolbox-Steuerelemente für WPF bestimmt sind.
    ''' </summary>
    Private Property IsWpfControls As Boolean
        Get
            Return _isWpfControls
        End Get
        Set(value As Boolean)
            _isWpfControls = value
        End Set
    End Property

    ''' <summary>
    ''' Ruft den Namen für die Steuerelemente ab
    ''' </summary>
    Private Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    ''' <summary>
    ''' Wird aufgerufen, um dieses Attribut im angegebenen Kontext zu registrieren.  
    ''' Der Kontext enthält den Ort, an dem die Registrierungsinformationen platziert werden sollten.
    ''' Es enthält auch andere Informationen wie den zu registrierenden Typ und Pfadinformationen.
    ''' </summary>
    ''' <param name="context">
    ''' Gegebener Kontext für die Registrierung
    ''' </param>
    Public Overrides Sub Register(context As RegistrationContext)

        If context Is Nothing Then
            Throw New ArgumentNullException(NameOf(context))
        End If

        Using key As Key = context.CreateKey(
            String.Format(
            CultureInfo.InvariantCulture, "{0}\{1}",
            ToolboxControlsInstallerPath,
            context.ComponentType.Assembly.FullName))

            key.SetValue(String.Empty, Name)
            key.SetValue("Codebase", context.CodeBase)
            If IsWpfControls Then
                key.SetValue("WPFControls", "1")
            End If

        End Using

    End Sub


    ''' <summary>
    ''' Wird aufgerufen, um dieses Attribut im angegebenen Kontext abzumelden.
    ''' </summary>
    ''' <param name="context">
    ''' Ein Registrierungskontext, der von einem externen Registrierungstool bereitgestellt wird. 
    ''' Der Kontext kann verwendet werden, um Registrierungsschlüssel zu entfernen, 
    ''' Registrierungsaktivitäten zu protokollieren und Informationen 
    ''' über die registrierte Komponente zu erhalten.
    ''' </param>
    Public Overrides Sub Unregister(context As RegistrationContext)

        context?.RemoveKey(
            String.Format(
            CultureInfo.InvariantCulture, "{0}\{1}",
            ToolboxControlsInstallerPath,
            context.ComponentType.Assembly.FullName))

    End Sub


End Class