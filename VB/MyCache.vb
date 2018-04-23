Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data

Namespace WindowsApplication1
	Public Class MyCache

		Private ReadOnly _KeyFieldName As String
		Private valuesCache As New Dictionary(Of Object, Object)()

		Public Sub New(ByVal keyFieldName As String)
			_KeyFieldName = keyFieldName
		End Sub

		Public Function GetKeyByRow(ByVal row As Object) As Object
			Return (TryCast(row, DataRowView))(_KeyFieldName)
		End Function


		Public Function GetValue(ByVal row As Object) As Object
			Return GetValueByKey(GetKeyByRow(row))
		End Function

		Public Function GetValueByKey(ByVal key As Object) As Object
			Dim result As Object = Nothing
			valuesCache.TryGetValue(key, result)
			Return result
		End Function


		Public Sub SetValue(ByVal row As Object, ByVal value As Object)
			SetValueByKey(GetKeyByRow(row), value)
		End Sub

		Public Sub SetValueByKey(ByVal key As Object, ByVal value As Object)
			valuesCache(key) = value
		End Sub
	End Class
End Namespace
