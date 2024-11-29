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
Imports System.Windows.Forms
Imports System.Windows.Forms.Layout

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
    Public Property ShowPluMinus As Boolean
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

    'BUG: beim auslesen der Schriftart aus Tv1 stürzt die IDE ab.
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
            'Return Me.Tv1.Font  
        End Get
        Set(value As Font)
            MyBase.Font = value
            Me.Tv1.Font = value
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
        Me.FillImageList()
        ' Füllt das TreeView mit den Standardbildern und Knoten.
        Me.FillTreeView()
    End Sub

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
    ''' Füllt die ImageList mit den Standardbildern für Computer, Laufwerke, Ordner und Spezialordner.
    ''' </summary>
    Private Sub FillImageList()

        ' Fügt die Bilder zu der ImageList hinzu, die im TreeView verwendet werden.
        Me.ImageList.Images.Add(
      $"Computer", My.Resources.ImgComputer)

        Me.ImageList.Images.Add(
      $"DesktopFolder", My.Resources.ImgDesktopFolder)

        Me.ImageList.Images.Add(
      $"DocumentsFolder", My.Resources.ImgDocumentsFolder)

        Me.ImageList.Images.Add(
      $"DownloadsFolder", My.Resources.ImgDownloadsFolder)

        Me.ImageList.Images.Add(
      $"Folder", My.Resources.ImgFolder)

        Me.ImageList.Images.Add(
      $"HardDrive", My.Resources.ImgHardDrive)

        Me.ImageList.Images.Add(
      $"MusicFolder", My.Resources.ImgMusicFolder)

        Me.ImageList.Images.Add(
      $"Network", My.Resources.ImgNetwork)

        Me.ImageList.Images.Add(
      $"NetworkDrive", My.Resources.ImgNetworkDrive)

        Me.ImageList.Images.Add(
      $"NetworkFolder", My.Resources.ImgNetworkFolder)

        Me.ImageList.Images.Add(
      $"OpticalDrive", My.Resources.ImgOpticalDrive)

        Me.ImageList.Images.Add(
      $"PicturesFolder", My.Resources.ImgPicturesFolder)

        Me.ImageList.Images.Add(
      $"SystemDrive", My.Resources.ImgSystemDrive)

        Me.ImageList.Images.Add(
      $"VideoFolder", My.Resources.ImgVideosFolder)

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

#End Region

End Class
