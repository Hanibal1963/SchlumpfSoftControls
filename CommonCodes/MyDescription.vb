' ****************************************************************************************************************
' MyDescription.vb
' © 2024 by Andreas Sauer
' ****************************************************************************************************************
'

Imports System
Imports System.Diagnostics
Imports System.Globalization
Imports System.Threading


''' <summary>
''' Definiert ein benutzerdefiniertes Beschreibungsattribut um 
''' Elementbeschreibungen aus einer Ressource abzurufen.
''' </summary>
<AttributeUsage(AttributeTargets.All)>
Friend Class MyDescription


    Inherits System.ComponentModel.DescriptionAttribute


    Public Sub New(RessorceKey As String)
        MyBase.New(GetRessourceValue(RessorceKey))
    End Sub


    Private Shared Function GetRessourceValue(RessorceKey As String) As String
        Return My.Resources.ResourceManager.GetString(
            RessorceKey, CultureInfo.CurrentUICulture)
    End Function


    Public Overrides ReadOnly Property TypeId As Object
        Get
            Return MyBase.TypeId
        End Get
    End Property


    Public Overrides ReadOnly Property Description As String
        Get
            Return MyBase.Description
        End Get
    End Property


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function


    Public Overrides Function Match(obj As Object) As Boolean
        Return MyBase.Match(obj)
    End Function


    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function


    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function


    Public Overrides Function IsDefaultAttribute() As Boolean
        Return MyBase.IsDefaultAttribute()
    End Function


End Class
