Public Class frmStockFaultyReport

    Private Sub frmStockFaultyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.DepartmentComboBox.SelectedValue = DepartmentId
    End Sub

    Private Sub ReceiveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveButton.Click

        Dim filterstring As String = "{Receive.DepartmentId}=" & DepartmentComboBox.SelectedValue & " And {@NotEqual} = 1.00"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StockFaultyReport_Receive
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub IssueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueButton.Click

        Dim filterstring As String = "{Receive.DepartmentId}=" & DepartmentComboBox.SelectedValue & " And {@NotEqual} = 1.00"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StockFaultyReport_Issue
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub AllocatedButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllocatedButton.Click
        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LCAndPIFaultyStockReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class