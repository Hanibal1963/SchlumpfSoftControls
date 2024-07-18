' ****************************************************************************************************************
' BeforeSwitchPagesEventArgs.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

''' <summary>
''' Enthält die Indexwerte der Seiten bevor die Seiten gewechselt werden.
''' </summary>
Public Class BeforeSwitchPagesEventArgs

    Inherits AfterSwitchPagesEventArgs

    Private _Cancel As Boolean = False

    Public Property Cancel As Boolean
        Get
            Return Me._Cancel
        End Get
        Set(value As Boolean)
            Me._Cancel = value
        End Set
    End Property

    ''' <summary>
    ''' Index der neuen Seite
    ''' </summary>
    Public Overloads Property NewIndex As Integer
        Get
            Return Me._NewIndex
        End Get
        Set(value As Integer)
            Me._NewIndex = value
        End Set
    End Property

    Friend Sub New(OldIndex As Integer, NewIndex As Integer)
        MyBase.New(OldIndex, NewIndex)
    End Sub

End Class

