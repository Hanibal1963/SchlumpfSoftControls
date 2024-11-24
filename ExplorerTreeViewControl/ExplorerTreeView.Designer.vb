Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExplorerTreeView
    Inherits System.Windows.Forms.UserControl

    'UserControl1 überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExplorerTreeView))
        Me.Tv1 = New System.Windows.Forms.TreeView()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.StateImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'Tv1
        '
        resources.ApplyResources(Me.Tv1, "Tv1")
        Me.Tv1.ImageList = Me.ImageList
        Me.Tv1.Name = "Tv1"
        Me.Tv1.StateImageList = Me.StateImageList
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        resources.ApplyResources(Me.ImageList, "ImageList")
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'StateImageList
        '
        Me.StateImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        resources.ApplyResources(Me.StateImageList, "StateImageList")
        Me.StateImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ExplorerTreeView
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Tv1)
        Me.Name = "ExplorerTreeView"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Tv1 As TreeView
    Private WithEvents StateImageList As ImageList
    Private WithEvents ImageList As ImageList
End Class
