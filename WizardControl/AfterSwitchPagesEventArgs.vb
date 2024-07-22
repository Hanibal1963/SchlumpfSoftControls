' ****************************************************************************************************************
' AfterSwitchPagesEventArgs.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'


Imports System


''' <summary>
''' Enthält die Indexwerte der Seiten nachdem die Seiten gewechselt wurden.
''' </summary>
Public Class AfterSwitchPagesEventArgs


    Inherits EventArgs


    Protected _NewIndex As Integer
    Private ReadOnly _OldIndex As Integer


    ''' <summary>
    ''' Index der alten Seite
    ''' </summary>
    Public ReadOnly Property OldIndex As Integer
        Get
            Return Me._OldIndex
        End Get
    End Property


    ''' <summary>
    ''' Index der neuen Seite
    ''' </summary>
    Public ReadOnly Property NewIndex As Integer
        Get
            Return Me._NewIndex
        End Get
    End Property


    Friend Sub New(OldIndex As Integer, NewIndex As Integer)
        Me._OldIndex = OldIndex
        Me._NewIndex = NewIndex

    End Sub


End Class

