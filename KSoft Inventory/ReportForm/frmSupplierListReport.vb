Public Class frmSupplierListReport

    Private Sub frmSupplierList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SupplierDataSet.SupplierLookup' table. You can move, or remove it, as needed.
        Me.DataLookupTableAdapter.Fill(Me.SupplierDataSet.SupplierLookup)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SupplierList
        ShowReport(MyReport, "", CrystalReportViewer1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filterstring As String = "{Supplier.SupplierId}=" & SupplierLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SupplierList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SupplierList
        ShowReport(MyReport, "", CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filterstring As String = "{SupplierType.SupplierType} ='" & ComboBox1.Text & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SupplierList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class