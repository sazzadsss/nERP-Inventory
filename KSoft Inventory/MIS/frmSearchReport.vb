Imports System.Reflection

Public Class frmSearchReport

    Private Sub ReportListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ReportListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReportListDataSet)

    End Sub

    Private Sub frmSearchReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ReportFormListTableAdapter.FillByModule(Me.ReportFormListDataSet.ReportFormList)
        Me.ReportListTableAdapter.Fill(Me.ReportListDataSet.ReportList)

    End Sub

    Private Sub ReportListGridControl_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportListGridControl.DoubleClick

        Dim row As ReportListDataSet.ReportListRow
        row = CType(CType(Me.ReportListBindingSource.Current, DataRowView).Row, ReportListDataSet.ReportListRow)

        Dim ReportPath As String = ReadStringData("Select ReportPathName from ReportFormList where ReportFormListId = " & row.ReportFormListId, cnn)

        ShowFormDynamic(ReportPath)

    End Sub

    Public Sub ShowFormDynamic(ByVal frmForm As String)
        Dim obj As Object = Activator.CreateInstance(Type.GetType("KSoft_Inventory." & frmForm))
        ShowForm(obj)
    End Sub
End Class