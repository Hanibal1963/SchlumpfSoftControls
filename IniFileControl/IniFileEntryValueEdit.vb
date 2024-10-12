' ****************************************************************************************************************
' IniFileEntryValueEdit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

''' <summary>
''' Steuerelement zum Anzeigen und Bearbeiten der Einträge eines Abschnitts einer INI - Datei.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Steuerelement zum Anzeigen und Bearbeiten der Einträge eines Abschnitts einer INI - Datei.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(IniFileEntryValueEdit), "IniFileEntryValueEdit.bmp")>
Public Class IniFileEntryValueEdit : Inherits UserControl

    Private _TitelText As String
    Private _Value As String = String.Empty
    Private _SelectedSection As String = String.Empty
    Private _SelectedEntry As String

#Region "Definition der Ereignisse"

    ''' <summary>
    ''' Wird ausgelöst wenn sich der Wert geändert hat.
    ''' </summary>
    <Description("Wird ausgelöst wenn sich der Wert geändert hat.")>
    Public Event ValueChanged(sender As Object, e As IniFileEntryValueEditEventArgs)

    Private Event TitelTextChanged()
    Private Event PropertyValueChanged()

#End Region

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.
        Me._TitelText = Me.GroupBox.Text

    End Sub

#Region "Definition der neuen Eigenschaften"

    ''' <summary>
    ''' Gibt den Text der Titelzeile zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt den Text der Titelzeile zurück oder legt diesen fest.")>
    Public Property TitelText As String
        Set(value As String)
            If Me._TitelText <> value Then
                Me._TitelText = value
                RaiseEvent TitelTextChanged()
            End If
        End Set
        Get
            Return Me._TitelText
        End Get
    End Property

    ''' <summary>
    ''' Gibt den aktuell ausgewählten Abschnitt zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt den aktuell ausgewählten Abschnitt zurück oder legt diesen fest.")>
    Public Property SelectedSection As String
        Get
            Return Me._SelectedSection
        End Get
        Set
            Me._SelectedSection = Value
        End Set
    End Property

    ''' <summary>
    ''' Gibt den aktuell ausgewählten Eintrag zurück oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Gibt den aktuell ausgewählten Eintrag zurück oder legt diesen fest.")>
    Public Property SelectedEntry As String
        Get
            Return Me._SelectedEntry
        End Get
        Set
            Me._SelectedEntry = Value
        End Set
    End Property

    ''' <summary>
    ''' Gibt den Eintragswert zurück oder legt diesen fest.
    ''' </summary>
    <Description("Gibt den Eintragswert zurück oder legt diesen fest.")>
    Public Property Value As String
        Get
            Return Me._value
        End Get
        Set
            If Me._value <> Value Then
                Me._value = Value
                RaiseEvent PropertyValueChanged()
            End If
        End Set
    End Property

#End Region

#Region "Definition der internen Ereignisbehandlungen"

    Private Sub Button_Click(sender As Object, e As System.EventArgs) Handles Button.Click

        'Ereignis auslösen
        RaiseEvent ValueChanged(Me, New IniFileEntryValueEditEventArgs(
                                Me._SelectedSection,
                                Me._SelectedEntry,
                                Me._Value))

        Me.Button.Enabled = False

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox.TextChanged

        ' Prüfung ob sich der Wert geändert hat
        If Me._Value <> Me.TextBox.Text Then
            Me.Button.Enabled = True
            Me._Value = Me.TextBox.Text
        Else
            Me.Button.Enabled = False
        End If

    End Sub

    Private Sub IniFileCommentEdit_TitelTextChanged() Handles Me.TitelTextChanged

        ' Titeltext setzen
        Me.GroupBox.Text = Me._TitelText

    End Sub

    Private Sub IniFileEntryValueEdit_PropertyValueChanged() Handles Me.PropertyValueChanged

        Me.TextBox.Text = Me._Value
        Me.Button.Enabled = False

    End Sub

#End Region

End Class
