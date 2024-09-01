Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmReorderReport

    Dim filterstring As String = ""

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        filterstring = "{Department.DepartmentId} = " & DepartmentId

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReorderReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

End Class