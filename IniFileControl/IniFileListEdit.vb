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
<Description("Steuerelement zum Anzeigen und Bearbeiten der Abschnitts- oder Eintrags- Liste einer INI - Datei.")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(IniFileListEdit), "IniFileListEdit.bmp")>
Public NotInheritable Class IniFileListEdit : Inherits GroupBox


#Region "Definition der Variablen"

    Private WithEvents Button_Delete As Button
    Private WithEvents Button_Rename As Button
    Private WithEvents Button_Add As Button
    Private WithEvents ListBox As ListBox
    Private _SelectedItem As String = $""
    Private _Items As String()

#End Region


#Region "Definition der Ereignisse"

    ''' <summary>
    ''' Wird ausgelöst wenn ein Eintrag hinzugefügt werden soll.
    ''' </summary>
    <Description("Wird ausgelöst wenn ein Eintrag hinzugefügt werden soll.")>
    <Category("ListEdit")>
    Public Event ItemAdd(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Wird ausgelöst wenn ein Eintrag umbenannt werden soll.
    ''' </summary>
    <Description("Wird ausgelöst wenn ein Eintrag umbenannt werden soll.")>
    <Category("ListEdit")>
    Public Event ItemRename(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Wird ausgelöst wenn ein Eintrag gelöscht werden soll.
    ''' </summary>
    <Description("Wird ausgelöst wenn ein Eintrag gelöscht werden soll.")>
    <Category("ListEdit")>
    Public Event ItemRemove(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Wird ausgelöst wenn sich der gewählte Eintrag geändert hat.
    ''' </summary>
    <Description("Wird ausgelöst wenn sich der gewählte Eintrag geändert hat.")>
    <Category("ListEdit")>
    Public Event SelectedItemChanged(sender As Object, e As EventArgs)

#End Region


    ''' <summary>
    ''' Erstellt eine neue Instanz dieser Klasse
    ''' </summary>
    Public Sub New()

        'interne Controls initialisieren
        Me.InitializeControls()

    End Sub


    ''' <summary>
    ''' Gibt den ausgewählten Eintrag oder leer zurück.
    ''' </summary>
    <Description("Gibt den ausgewählten Eintrag oder leer zurück.")>
    <Browsable(False)>
    Public ReadOnly Property SelectedItem As String
        Get
            Return Me._SelectedItem
        End Get
    End Property


    ''' <summary>
    ''' Elemente der Listbox.
    ''' </summary>
    <Description("Elemente der Listbox.")>
    <Browsable(False)>
    Public WriteOnly Property Items() As String()
        Set
            Me._Items = Value
            Me.FillListbox()
        End Set
    End Property


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
        Button_Add.Click

        RaiseEvent ItemAdd(Me, EventArgs.Empty)

    End Sub

    ''' <summary>
    ''' Löst das Ereignis zum Umbenennen eines Eintrags aus.
    ''' </summary>
    Private Sub Button_Rename_Click(sender As Object, e As EventArgs) Handles _
        Button_Rename.Click

        RaiseEvent ItemRename(Me, EventArgs.Empty)

    End Sub

    ''' <summary>
    ''' Löst das Ereignis zum Löschen eines Eintrags aus.
    ''' </summary>
    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles _
        Button_Delete.Click

        RaiseEvent ItemRemove(Me, EventArgs.Empty)

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
        Me.Button_Delete.Enabled = True
        Me.Button_Rename.Enabled = True

    End Sub

    ''' <summary>
    ''' Setzt die Eigenschaft <see cref="SelectedItem"/> auf leer.
    ''' </summary>
    Private Sub ClearPropertySelectedItem()

        'Eigenschaft leeren
        Me._SelectedItem = $""

        'Buttons schalten
        Me.Button_Delete.Enabled = False
        Me.Button_Rename.Enabled = False

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
        Me.Button_Add.Enabled = True
        Me.Button_Delete.Enabled = False
        Me.Button_Rename.Enabled = False

        'Event auslösen
        RaiseEvent SelectedItemChanged(Me, EventArgs.Empty)

    End Sub

    ''' <summary>
    ''' Initialisiert die untergeordneten Controls.
    ''' </summary>
    Private Sub InitializeControls()

        'Variablen für interne Controls aktivieren
        Me.SetControls()
        Me.SuspendLayout()

        'Löschbutton initialisieren
        Me.InitButtonDelete()

        'Umbennenbutton initialisieren
        Me.InitButtoRename()

        'Hinzufügenbutton initialisieren
        Me.InitButtonAdd()

        'Listbox initialisieren
        Me.InitListBox()

        'intene Controls hinzufügen
        Me.AddControls()
        Me.ResumeLayout(False)

    End Sub

    ''' <summary>
    ''' intene Controls hinzufügen
    ''' </summary>
    Private Sub AddControls()

        With Me.Controls
            .Add(Me.ListBox)
            .Add(Me.Button_Delete)
            .Add(Me.Button_Rename)
            .Add(Me.Button_Add)
        End With

    End Sub

    ''' <summary>
    ''' Listbox initialisieren
    ''' </summary>
    Private Sub InitListBox()

        With Me.ListBox
            .Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            .FormattingEnabled = True
            .Location = New Point(8, 20)
            .Name = "ListBox"
            .Size = New Size(Me.Width - 20, Me.Height - 60)
            .TabIndex = 0
        End With

    End Sub

    ''' <summary>
    ''' Hinzufügenbutton initialisieren
    ''' </summary>
    Private Sub InitButtonAdd()

        With Me.Button_Add
            .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            .Enabled = False
            .Location = New Point(Me.Width - 312, Me.Height - 32)
            .Name = "Button_Add"
            .Size = New Size(96, 24)
            .TabIndex = 1
            .Text = "hinzufügen"
            .UseVisualStyleBackColor = True
        End With

    End Sub

    ''' <summary>
    ''' Umbenennenbutton initialisieren
    ''' </summary>
    Private Sub InitButtoRename()

        With Me.Button_Rename
            .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            .Enabled = False
            .Location = New Point(Me.Width - 210, Me.Height - 32)
            .Name = "Button_Rename"
            .Size = New Size(96, 24)
            .TabIndex = 2
            .Text = "umbenennen"
            .UseVisualStyleBackColor = True
        End With

    End Sub

    ''' <summary>
    ''' Initialisiert den Löschbutton
    ''' </summary>
    Private Sub InitButtonDelete()

        With Me.Button_Delete
            .Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            .Enabled = False
            .Location = New Point(Me.Width - 110, Me.Height - 32)
            .Name = "Button_Delete"
            .Size = New Size(96, 24)
            .TabIndex = 3
            .Text = "löschen"
            .UseVisualStyleBackColor = True
        End With

    End Sub

    ''' <summary>
    ''' aktiviert die Variablen für die intenen Controls
    ''' </summary>
    Private Sub SetControls()

        Me.Button_Delete = New Button()
        Me.Button_Rename = New Button()
        Me.Button_Add = New Button()
        Me.ListBox = New ListBox()

    End Sub

#End Region


End Class
