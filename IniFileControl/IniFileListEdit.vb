' ****************************************************************************************************************
' IniFileListEdit.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms


''' <summary>
''' Steuerelement zum Anzeigen und Bearbeiten der Abschnitts- oder Eintrags- Liste einer INI - Datei.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<MyDescription("ClassDescriptionListEdit")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(IniFileListEdit), "IniFileListEdit.bmp")>
Public Class IniFileListEdit


    Inherits UserControl


#Region "Definition der Variablen"

    Private _SelectedItem As String = $""
    Private _Items As String()
    Private _TitelText As String

#End Region


#Region "Definition der Ereignisse"


    ''' <summary>
    ''' Wird ausgelöst wenn ein Eintrag hinzugefügt werden soll.
    ''' </summary>
    <MyDescription("ListEditItemAddDescription")>
    <Category("ListEdit")>
    Public Event ItemAdd(sender As Object, e As EventArgs)


    ''' <summary>
    ''' Wird ausgelöst wenn ein Eintrag umbenannt werden soll.
    ''' </summary>
    <MyDescription("ListEditItemRenameDescription")>
    <Category("ListEdit")>
    Public Event ItemRename(sender As Object, e As EventArgs)


    ''' <summary>
    ''' Wird ausgelöst wenn ein Eintrag gelöscht werden soll.
    ''' </summary>
    <MyDescription("ListEditItemRemoveDescription")>
    <Category("ListEdit")>
    Public Event ItemRemove(sender As Object, e As EventArgs)


    ''' <summary>
    ''' Wird ausgelöst wenn sich der gewählte Eintrag geändert hat.
    ''' </summary>
    <MyDescription("ListEditSelectedItemChangedDescription")>
    <Category("ListEdit")>
    Public Event SelectedItemChanged(sender As Object, e As EventArgs)


    Private Event TitelTextChanged()


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
    ''' <returns></returns>
    <Browsable(True)>
    <Category("Appearance")>
    <MyDescription("TitelTextDescription")>
    Public Property TitelText As String
        Set(value As String)
            Me._TitelText = value
            RaiseEvent TitelTextChanged()
        End Set
        Get
            Return Me._TitelText
        End Get
    End Property

#End Region


#Region "ausgeblendete Eigenschaften"


    ''' <summary>
    ''' Gibt den ausgewählten Eintrag oder leer zurück.
    ''' </summary>
    <Browsable(False)>
    Public ReadOnly Property SelectedItem As String
        Get
            Return Me._SelectedItem
        End Get
    End Property


    ''' <summary>
    ''' Elemente der Listbox.
    ''' </summary>
    <Browsable(False)>
    Public WriteOnly Property Items() As String()
        Set
            Me._Items = Value
            Me.FillListbox()
        End Set
    End Property


#End Region


#Region "Definition der internen Ereignisbehandlungen"


    ''' <summary>
    ''' Setzt die Eigenschaft und schaltet die Buttons.
    ''' </summary>
    Private Sub ListBox_SelectedIndex_Changed(sender As Object, e As EventArgs) Handles _
        ListBox.SelectedIndexChanged

        'Wenn kein Eintrag ausgewählt -> Eigenschaft auf leer ansonten auf Wert setzen
        If Me.ListBox.SelectedIndex = -1 Then
            Me.ClearPropertySelectedItem()
        Else
            Me.SetPropertySelectedItem()
        End If

        'Event auslösen
        RaiseEvent SelectedItemChanged(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Löst das Ereignis zum hinzufügen eines Eintrags aus.
    ''' </summary>
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles _
        ButtonAdd.Click

        RaiseEvent ItemAdd(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Löst das Ereignis zum Umbenennen eines Eintrags aus.
    ''' </summary>
    Private Sub Button_Rename_Click(sender As Object, e As EventArgs) Handles _
        ButtonRename.Click

        RaiseEvent ItemRename(Me, EventArgs.Empty)

    End Sub


    ''' <summary>
    ''' Löst das Ereignis zum Löschen eines Eintrags aus.
    ''' </summary>
    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles _
        ButtonDelete.Click

        RaiseEvent ItemRemove(Me, EventArgs.Empty)

    End Sub


    Private Sub IniFileCommentEdit_TitelTextChanged() Handles _
        Me.TitelTextChanged

        Me.GroupBox.Text = Me._TitelText

    End Sub


#End Region


#Region "Definition der internen Funktionen"


    ''' <summary>
    ''' Setzt die Eigenschaft <see cref="SelectedItem"/> auf den Gewählten Eintrrag
    ''' </summary>
    Private Sub SetPropertySelectedItem()

        'Eigenschaft setzen
        Me._SelectedItem = CStr(Me.ListBox.SelectedItem)

        'Buttons schalten
        Me.ButtonDelete.Enabled = True
        Me.ButtonRename.Enabled = True

    End Sub


    ''' <summary>
    ''' Setzt die Eigenschaft <see cref="SelectedItem"/> auf leer.
    ''' </summary>
    Private Sub ClearPropertySelectedItem()

        'Eigenschaft leeren
        Me._SelectedItem = $""

        'Buttons schalten
        Me.ButtonDelete.Enabled = False
        Me.ButtonRename.Enabled = False

    End Sub


    ''' <summary>
    ''' Befüllt die Listbox
    ''' </summary>
    Private Sub FillListbox()

        'Listbox leeren
        Me.ListBox.Items.Clear()

        'Listbox neu befüllen
        If Me._Items IsNot Nothing Then Me.ListBox.Items.AddRange(Me._Items)

        'kein Eintrag ausgewählt
        Me.ListBox.SelectedIndex = -1

        'Eigenschaft setzen
        Me._SelectedItem = $""

        'Buttons schalten
        Me.ButtonAdd.Enabled = True
        Me.ButtonDelete.Enabled = False
        Me.ButtonRename.Enabled = False

        'Event auslösen
        RaiseEvent SelectedItemChanged(Me, EventArgs.Empty)

    End Sub


#End Region


End Class
