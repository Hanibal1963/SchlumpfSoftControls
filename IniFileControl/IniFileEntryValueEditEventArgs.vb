' ****************************************************************************************************************
' IniFileEntryValueEditEventArgs.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System

Public Class IniFileEntryValueEditEventArgs : Inherits EventArgs

    Private _SelectedEntry As String
    Private _OldValue As String
    Private _NewValue As String


    Public Property SelectedEntry As String
        Get
            Return Me._SelectedEntry
        End Get
        Set
            Me._SelectedEntry = Value
        End Set
    End Property


    Public Property OldValue As String
        Get
            Return Me._OldValue
        End Get
        Set
            Me._OldValue = Value
        End Set
    End Property


    Public Property NewValue As String
        Get
            Return Me._NewValue
        End Get
        Set
            Me._NewValue = Value
        End Set
    End Property

    Public Sub New(SelectedEntry As String, OldValue As String, NewValue As String)

        Me._SelectedEntry = SelectedEntry
        Me._OldValue = OldValue
        Me._NewValue = NewValue

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function

End Class
