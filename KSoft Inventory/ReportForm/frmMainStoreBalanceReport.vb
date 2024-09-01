Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmMainStoreBalanceReport
    Dim filterstring As String = ""
    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        filterstring = "{Balance.DepartmentId}=" & frmStoreBalance.DepartmentComboBox.SelectedValue & ""

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MainStoreBalance
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

End Class