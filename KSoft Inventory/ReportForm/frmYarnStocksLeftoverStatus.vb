Public Class frmYarnStocksLeftoverStatus
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filterstring As String = "{Company.CompanyId}=" & CompanyComboBox.SelectedValue & " And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockLeftoverRepotCompact
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filterstring As String = "{@CHK0} > 0.00 And {Department.DepartmentId} =" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockLeftoverRepotCompact
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmYarnStocksLeftoverStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, 8)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.DepartmentComboBox.SelectedValue = 8


    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim filterstring As String = "{ItemList.ItemId}=" & ItemLookupGridLookUpEdit.EditValue & " And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & ""

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockLeftoverRepotCompact
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filterstring As String = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate_LC_Wise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim filterstring As String = "{YarnStock.DepartmentId}=" & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepotwithoutLCLOT
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class