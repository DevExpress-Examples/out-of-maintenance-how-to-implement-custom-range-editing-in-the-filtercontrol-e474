Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports System.Reflection
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Filtering.Helpers

Namespace WindowsApplication197
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			InitData()
			gridControl1.DataSource = dv

			Dim columnCollection As New DevExpress.XtraGrid.FilterEditor.ViewFilterColumnCollection(gridView1)
			Dim ri As New RepositoryItemPopupContainerEdit()
			ri.PopupControl = popupContainerControl1
			ri.CloseOnOuterMouseClick = False
			AddHandler ri.QueryResultValue, AddressOf ri_QueryResultValue
			AddHandler ri.QueryPopUp, AddressOf ri_QueryPopUp
			columnCollection("Date").SetColumnEditor(ri)
			columnCollection("ID").SetColumnEditor(New RepositoryItemCalcEdit())
			filterControl1.SetFilterColumnsCollection(columnCollection)

		End Sub

		Private Sub ri_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs)
			dateEdit1.EditValue = (CType(sender, PopupContainerEdit)).EditValue
		End Sub

		Private Sub ri_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
			e.Value = dateEdit1.EditValue
			Dim [date] As DateTime = Convert.ToDateTime(e.Value)
			Dim pi As PropertyInfo = GetType(FilterControl).GetProperty("FocusInfo", BindingFlags.Instance Or BindingFlags.NonPublic)
			Dim focus As FilterControlFocusInfo = CType(pi.GetValue(filterControl1, Nothing), FilterControlFocusInfo)
			Dim cnode As ClauseNode = TryCast(focus.Node, ClauseNode)
			If cnode Is Nothing Then
				Return
			End If
			If cnode.Operation = ClauseType.Between Then
				If focus.ElementIndex = 2 Then
					PatchOperator(TryCast(cnode.AdditionalOperands(1), OperandValue), [date], comboBoxEdit1.Text, True)
				ElseIf focus.ElementIndex = 3 Then
					PatchOperator(TryCast(cnode.AdditionalOperands(0), OperandValue), [date], comboBoxEdit1.Text, False)
				End If
				cnode.RecalcLabelInfo()
			End If
		End Sub

		Private Sub PatchOperator(ByVal opr As OperandValue, ByVal [date] As DateTime, ByVal range As String, ByVal isFirst As Boolean)
			If (CObj(opr)) Is Nothing Then
				Return
			End If
			Select Case range
				Case "Day"
					If isFirst Then
						opr.Value = [date].AddDays(1)
					Else
						opr.Value = [date].AddDays(-1)
					End If
				Case "Week"
					If isFirst Then
						opr.Value = [date].AddDays(7)
					Else
						opr.Value = [date].AddDays(-7)
					End If
				Case "Month"
					If isFirst Then
						opr.Value = [date].AddMonths(1)
					Else
						opr.Value = [date].AddMonths(-1)
					End If
			End Select
		End Sub

		Private Sub InitData()
			dt = New DataTable()
			dt.Columns.Add("ID", GetType(Integer))
			dt.Columns.Add("Date", GetType(DateTime))
			Dim rnd As New Random()
			For i As Integer = 0 To 999
				dt.Rows.Add(New Object() { i, DateTime.Now.Date.AddDays(rnd.Next(100)) })
			Next i
			dv = New DataView(dt)
		End Sub

		Private dt As DataTable
		Private dv As DataView

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			filterControl1.ApplyFilter()
			gridView1.ActiveFilterCriteria = filterControl1.FilterCriteria
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

		End Sub
	End Class
End Namespace