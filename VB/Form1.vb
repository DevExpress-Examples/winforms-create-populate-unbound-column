Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Private _KeyField As DataColumn
		Private _Tbl As DataTable
		Private _Cache As New MyCache("ID")
		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			_Tbl = New DataTable()
			_KeyField = _Tbl.Columns.Add("ID", GetType(Integer))
			_KeyField.ReadOnly = True
			_KeyField.AutoIncrement = True
			_Tbl.Columns.Add("Name", GetType(String))
			_Tbl.Columns.Add("Number", GetType(Integer))
			_Tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				_Tbl.Rows.Add(New Object() { Nothing, String.Format("Name{0}", i), 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return _Tbl
		End Function

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = CreateTable(20)
			CreateUnboundColumn()
		End Sub
		Private Sub CreateUnboundColumn()
			Dim col As GridColumn = gridView1.Columns.AddVisible("Unbound", "Unbound column")
			col.UnboundType = DevExpress.Data.UnboundColumnType.String
		End Sub



		Private Sub gridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles gridView1.CustomUnboundColumnData
			If e.IsGetData Then
				e.Value = _Cache.GetValue(e.Row)
			End If
			If e.IsSetData Then
				_Cache.SetValue(e.Row, e.Value)
			End If
		End Sub
	End Class
End Namespace