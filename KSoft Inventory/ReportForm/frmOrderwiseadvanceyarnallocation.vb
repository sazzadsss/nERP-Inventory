Public Class frmOrderwiseadvanceyarnallocation

    Private Sub frmOrderwiseadvanceyarnallocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FFBLookupDataSet.FinishFabricBookingLookUp' table. You can move, or remove it, as needed.
        Me.FinishFabricBookingLookUpTableAdapter.Fill(Me.FFBLookupDataSet.FinishFabricBookingLookUp)
        Me.IssueProgramLookupTableAdapter.Fill(Me.IssueProgramLookupDataSet.IssueProgramLookup, 8)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, 8)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.DepartmentGridLookUpEdit.Text = 8
    End Sub

    Private Sub ShowByDepartmentButton_Click(sender As Object, e As EventArgs) Handles ShowByDepartmentButton.Click
        Dim filterstring As String = "Not {FinishFabricBooking.IsClose} And {ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ORDERWISEADVANCEYARNALLOCATIONSTATUS
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub btnShowByItem_Click(sender As Object, e As EventArgs) Handles btnShowByItem.Click
        Dim filterstring As String = "{ItemList.ItemId}=" & ItemLookupGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ORDERWISEADVANCEYARNALLOCATIONSTATUS
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue & "And {Supplier.SupplierId}=" & SupplierLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ORDERWISEADVANCEYARNALLOCATIONSTATUS
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filterstring As String = "{Company.CompanyId}=" & CompanyComboBox.SelectedValue & " And {ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ORDERWISEADVANCEYARNALLOCATIONSTATUS
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        Dim filterstring As String = "{FinishFabricBooking.ProgramNo}='" & FinishFabricBookingIdGridLookUpEdit.EditValue & "' And {ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ORDERWISEADVANCEYARNALLOCATIONSTATUS
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ORDERWISEADVANCEYARNALLOCATIONSTATUS
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class