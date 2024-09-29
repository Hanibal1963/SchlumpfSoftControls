' ****************************************************************************************************************
' IniFileListEditEventArgs.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System

Public Class IniFileListEditEventArgs : Inherits EventArgs

    Private _SelectedItem As String = $""
    Private _NewItemName As String = $""

    Public Property SelectedItem As String
        Get
            Return Me._SelectedItem
        End Get
        Set
            Me._SelectedItem = Value
        End Set
    End Property

    Public Property NewItemName As String
        Get
            Return Me._NewItemName
        End Get
        Set
            Me._NewItemName = Value
        End Set
    End Property

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
