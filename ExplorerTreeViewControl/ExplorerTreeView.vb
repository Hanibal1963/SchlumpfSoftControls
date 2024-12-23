' ****************************************************************************************************************
' ExpTreeControl.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'
' weitere Infos:
' <Browsable> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.browsableattribute?view=netframework-4.7.2
' <Cathegory> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.categoryattribute?view=netframework-4.7.2
' <Description> - https://learn.microsoft.com/de-de/dotnet/api/system.componentmodel.descriptionattribute?view=netframework-4.7.2

#Region "Importe"

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports SchlumpfSoft.Attribute

#End Region

''' <summary>
''' Stellt ein benutzerdefiniertes Steuerelement bereit, die ein TreeView-Steuerelement enthält, 
''' das die Verzeichnisstruktur des Computers anzeigt.
''' </summary>
<ProvideToolboxControl("SchlumpfSoft Controls", False)>
<Description("Control zum Anzeigen der Laufwerke und Ordner eines Computers")>
<ToolboxItem(True)>
<ToolboxBitmap(GetType(ExplorerTreeView), "ExplorerTreeView.bmp")>
Public Class ExplorerTreeView : Inherits UserControl

#Region "Ereignisdefinitionen für öffentliche Ereignisse"

    ''' <summary>
    ''' Wird ausgelöst, wenn sich der ausgewählte Pfad geändert hat.
    ''' </summary>
    <Category("Behavior")>
    <Description("Wird ausgelöst, wenn sich der ausgewählte Pfad geändert hat.")>
    Public Event SelectedPathChanged(sender As Object, e As EventArgs)

#End Region

#Region "Ereignisdefinitionen für interne Ereignisse"

#End Region

#Region "neue Eigenschaften"

    ''' <summary>
    ''' Gibt den vollständigen Pfad des ausgewähten Knotens zurück.
    ''' </summary>
    <Browsable(False)>
    <Description("Gibt den vollständigen Pfad des ausgewählten Knotens zurück.")>
    Public ReadOnly Property SelectedPath As String
        Get
            ' Holt den aktuell ausgewählten Knoten im TreeView.
            Dim node As TreeNode = Me.Tv1.SelectedNode
            ' Wenn ein Knoten ausgewählt ist, gibt den Pfad des Knotens zurück.
            If node IsNot Nothing Then
                Return GetNodePath(node)
            Else
                ' Wenn kein Knoten ausgewählt ist, gibt einen leeren String zurück.
                Return String.Empty
            End If
        End Get
    End Property

    ''' <summary>
    ''' Legt die Farbe der Linien die, die Knoten miteinander verbinden fest oder gibt diese zurück.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt die Farbe der Linien die, die Knoten miteinander verbinden fest oder gibt diese zurück.")>
    Public Property LineColor As Color
        Get
            Return Me.Tv1.LineColor
        End Get
        Set(value As Color)
            Me.Tv1.LineColor = value
        End Set
    End Property

    ''' <summary>
    ''' Legt fest ob Linien zwischen Strukturknoten gezeichnet werden.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt fest ob Linien zwischen Strukturknoten gezeichnet werden.")>
    Public Property ShowLines As Boolean
        Get
            Return Me.Tv1.ShowLines
        End Get
        Set(value As Boolean)
            Me.Tv1.ShowLines = value
        End Set
    End Property

    ''' <summary>
    ''' Legt fest ob die Plus- und Minuszeichen zum Anzeigen von Unterknoten angezeigt werden.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt fest ob die Plus- und Minuszeichen zum Anzeigen von Unterknoten angezeigt werden.")>
    Public Property ShowPlusMinus As Boolean
        Get
            Return Me.Tv1.ShowPlusMinus
        End Get
        Set(value As Boolean)
            Me.Tv1.ShowPlusMinus = value
        End Set
    End Property

    ''' <summary>
    ''' Legt fest ob die Linien zwischen den Stammknoten angezeigt werden.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Legt fest ob die Linien zwischen den Stammknoten angezeigt werden.")>
    Public Property ShowRootLines As Boolean
        Get
            Return Me.Tv1.ShowRootLines
        End Get
        Set(value As Boolean)
            Me.Tv1.ShowRootLines = value
        End Set
    End Property

    ''' <summary>
    ''' Ruft die Höhe des jeweiligen Strukturknotens im Strukturansicht-Steuerelement ab 
    ''' oder legt diese fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Ruft die Höhe des jeweiligen Strukturknotens im Strukturansicht-Steuerelement ab oder legt diese fest.")>
    Public Property ItemHight As Integer
        Get
            Return Me.Tv1.ItemHeight
        End Get
        Set(value As Integer)
            Me.Tv1.ItemHeight = value
        End Set
    End Property

    ''' <summary>
    ''' Ruft den Abstand für das Einrücken der einzelnen Ebenen von untergeordneten Strukturknoten ab oder legt diesen fest.
    ''' </summary>
    <Browsable(True)>
    <Category("Behavior")>
    <Description("Ruft den Abstand für das Einrücken der einzelnen Ebenen von untergeordneten Strukturknoten ab oder legt diesen fest.")>
    Public Property Intent As Integer
        Get
            Return Me.Tv1.Indent
        End Get
        Set(value As Integer)
            Me.Tv1.Indent = value
        End Set
    End Property

#End Region

#Region "überschriebene Eigenschaften"

    ''' <summary>
    ''' Legt die Vordergrundfarbe für das Anzeigen von Text fest oder gibt diese zurück.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt die Vordergrundfarbe für das Anzeigen von Text fest oder gibt diese zurück.")>
    Public Overrides Property ForeColor As Color
        Get
            Return Me.Tv1.ForeColor
        End Get
        Set(value As Color)
            Me.Tv1.ForeColor = value
        End Set
    End Property

    ''' <summary>
    ''' Legt die Hintergrundfarbe des Controls fest oder gibt diese zurück.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt die Hintergrundfarbe des Controls fest oder gibt diese zurück.")>
    Public Overrides Property BackColor As Color
        Get
            Return Me.Tv1.BackColor
        End Get
        Set(value As Color)
            Me.Tv1.BackColor = value
        End Set
    End Property


    ''' <summary>
    ''' Legt die Schriftart des Textes im Steuerelement fest oder gibt diese zurück.
    ''' </summary>
    <Browsable(True)>
    <Category("Appearance")>
    <Description("Legt die Schriftart des Textes im Steuerelement fest oder gibt diese zurück.")>
    Public Overrides Property Font As Font
        Get
            'BUG: beim auslesen der Schriftart aus Tv1 stürzt die IDE ab.
            Return MyBase.Font
            'Return Me.Tv1.Font  
        End Get
        Set(value As Font)
            MyBase.Font = value
            Me.Tv1.Font = value
        End Set
    End Property

#End Region

#Region "ausgeblendete Eigenschaften"

    ''' <summary>
    ''' ausgeblendet da  nicht Relevant
    ''' </summary>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImage As Image
        Get
            Return MyBase.BackgroundImage
        End Get
        Set(value As Image)
            MyBase.BackgroundImage = value
        End Set
    End Property

    ''' <summary>
    ''' ausgeblendet da  nicht Relevant
    ''' </summary>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property BackgroundImageLayout As ImageLayout
        Get
            Return MyBase.BackgroundImageLayout
        End Get
        Set(value As ImageLayout)
            MyBase.BackgroundImageLayout = value
        End Set
    End Property

    ''' <summary>
    ''' ausgeblendet da  nicht Relevant
    ''' </summary>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overrides Property AutoSize As Boolean
        Get
            Return MyBase.AutoSize
        End Get
        Set(value As Boolean)
            MyBase.AutoSize = value
        End Set
    End Property

    ''' <summary>
    ''' ausgeblendet da  nicht Relevant
    ''' </summary>
    <Browsable(False)>
    <EditorBrowsable(EditorBrowsableState.Never)>
    Public Overloads Property AutosizeMode As AutoSizeMode
        Get
            Return MyBase.AutoSizeMode
        End Get
        Set(value As AutoSizeMode)
            MyBase.AutoSizeMode = value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Konstruktor der ExpTreeControl-Klasse.
    ''' </summary>
    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        Me.InitializeComponent()

        ' Füllt die ImageList mit den Standardbildern.
        FillImageList(Me.ImageList)

        ' Füllt das TreeView mit den Standardbildern und Knoten.
        Me.FillTreeView()

    End Sub

#Region "öffentliche Funktionen"

    ''' <summary>
    ''' Öffnet den angegebenen Pfad im TreeView-Steuerelement.
    ''' </summary>
    Public Sub ExpandPath(Path As String)

        'Pfad in einzelne Verzeichnisse aufteilen.
        Dim dirs As String() = Path.Split(
            New Char() {"\"c},
            StringSplitOptions.RemoveEmptyEntries)


        'Startet die Suche beim Wurzelknoten.
        Dim currentNode As TreeNode = Me.Tv1.Nodes(0)

        'Durchläuft die Verzeichnisse im Pfad.
        For Each dir As String In dirs

            Dim found As Boolean = False

            'Durchläuft die untergeordneten Knoten des aktuellen Knotens.
            For Each node As TreeNode In currentNode.Nodes

                'eventuell vorhandene Klammern entfernen
                Dim s As String = node.Text
                If InStr(s, "(") > 0 Then
                    s = Strings.Split(s, "(").ElementAt(1).Replace(")", "")
                End If

                'Wenn der Knoten gefunden wurde, wird er erweitert und als aktueller Knoten gesetzt.
                If String.Equals(s, dir, StringComparison.OrdinalIgnoreCase) Then
                    currentNode = node
                    currentNode.Expand()
                    found = True
                    Exit For
                End If

            Next

            ' Wenn der Knoten nicht gefunden wurde, wird die Suche abgebrochen.
            If Not found Then
                Exit Sub
            End If

        Next

        ' Wählt den letzten Knoten im Pfad aus.
        Me.Tv1.SelectedNode = currentNode

    End Sub

#End Region

#Region "interne Funktionen"

    ''' <summary>
    ''' Füllt das TreeView mit den Standardbildern und Knoten.
    ''' </summary>
    Private Sub FillTreeView()

        ' Erstellt einen neuen Knoten für den Computer.
        Dim node As New ComputerNode

        ' Löscht alle vorhandenen Knoten im TreeView.
        Me.Tv1.Nodes.Clear()

        ' Fügt den neuen Computerknoten zum TreeView hinzu.
        Dim unused = Me.Tv1.Nodes.Add(node)

        ' Erweitert den Computerknoten, um seine Unterknoten anzuzeigen.
        node.Expand()

    End Sub


    ''' <summary>
    ''' Aktualisiert die Laufwerke im TreeView-Steuerelement.
    ''' </summary>
    Private Sub UpdateDrives()

        Dim lastpath As String = Me.SelectedPath
        Me.FillTreeView()
        Me.ExpandPath(lastpath)

    End Sub

#End Region

#Region "interne Ereignisbehandlungen"

    ''' <summary>
    ''' Wird ausgelöst, bevor sich der ausgewählte Knoten ändert.
    ''' </summary>
    Private Sub Tv1_BeforeExpand(sender As Object, e As TreeViewCancelEventArgs) Handles Tv1.BeforeExpand
        ' Versucht, den Knoten in einen DirectoryNode zu konvertieren.
        Dim node As DirectoryNode = TryCast(e.Node, DirectoryNode)
        ' Wenn der Knoten ein DirectoryNode ist, lädt die Unterverzeichnisse.
        If node IsNot Nothing Then
            node.LoadSubDirectories()
        End If
    End Sub

    ''' <summary>
    ''' Wird ausgelöst, wenn sich der ausgewählte Knoten geändert hat.
    ''' </summary>
    Private Sub Tv1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles Tv1.AfterSelect
        ' Löst das SelectedPathChanged-Ereignis aus, um anzuzeigen, dass sich der ausgewählte Pfad geändert hat.
        RaiseEvent SelectedPathChanged(Me, EventArgs.Empty)
    End Sub

    ''' <summary>
    ''' Wird ausgeführt wenn ein Laufwerk hinzugefügt wurde.
    ''' </summary>
    Private Sub Dw_DriveAdded(sender As Object, e As DriveWatcherControl.DriveAddedEventArgs) Handles Dw.DriveAdded
        Me.UpdateDrives()
    End Sub

    ''' <summary>
    ''' Wird ausgeführt wenn ein Laufwerk entfernt wurde.
    ''' </summary>
    Private Sub Dw_DriveRemoved(sender As Object, e As DriveWatcherControl.DriveRemovedEventArgs) Handles Dw.DriveRemoved
        Me.UpdateDrives()
    End Sub

#End Region

End Class
