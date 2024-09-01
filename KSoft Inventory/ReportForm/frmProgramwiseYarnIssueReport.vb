Public Class frmProgramwiseYarnIssueReport

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        'Dim filterstring As String = "{Issue.ProgramNo}='" & FinishFabricBookingIdGridLookUpEdit.EditValue & "' And {ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue
        Dim filterstring As String = "{FinishFabricBooking.ProgramNo}='" & FinishFabricBookingIdGridLookUpEdit.EditValue & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramwiseYarnIssueReport_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmProgramwiseYarnIssueReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SupplierDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.FinishFabricBookingLookUpTableAdapter.Fill(Me.FFBLookupDataSet.FinishFabricBookingLookUp)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.IssueProgramLookupTableAdapter.Fill(Me.IssueProgramLookupDataSet.IssueProgramLookup, DepartmentId)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)

    End Sub

   
    Private Sub btnShowByItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowByItem.Click

        Dim filterstring As String = "{ItemList.ItemId}=" & ItemLookupGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramwiseYarnIssueReport_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim FromDate As Date = DyeingDateTimePicker.Text
        Dim ToDate As Date = ToDateTimePicker.Text

        'filterstring = "{Issueto.ProductionDate} = DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00)"
        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue & "And {Issue.IssueDate} in DateTime (" & FromDate.Year & "," & FromDate.Month & "," & FromDate.Day & ", 00, 00, 00) to DateTime (" & ToDate.Year & "," & ToDate.Month & "," & ToDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthlyYarnIssueReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim FromDate As Date = DyeingDateTimePicker.Text
        Dim ToDate As Date = ToDateTimePicker.Text

        'filterstring = "{Issueto.ProductionDate} = DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00)"
        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue & "And {Issue.IssueDate} in DateTime (" & FromDate.Year & "," & FromDate.Month & "," & FromDate.Day & ", 00, 00, 00) to DateTime (" & ToDate.Year & "," & ToDate.Month & "," & ToDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MonthlyYarnIssueReportDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub DepartmentGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentGridLookUpEdit.EditValueChanged

        'Department Wise Filtering,  Imrul Kaesh, 29-06-2013

        Me.IssueProgramLookupTableAdapter.Fill(Me.IssueProgramLookupDataSet.IssueProgramLookup, DepartmentGridLookUpEdit.EditValue)

        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentGridLookUpEdit.EditValue)
        'End Imrul Kaesh
    End Sub

   
    Private Sub ShowByDepartmentButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByDepartmentButton.Click
        'Dim filterstring As String = "{Issue.ProgramNo}='" & FinishFabricBookingIdGridLookUpEdit.EditValue & "' And {ItemList.DepartmentId}=" & DepartmentId & ""

        Dim filterstring As String = "not {@IsClose} And " & _
                                     "not {@IsGreigeClose} And {ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramwiseYarnIssueReport_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentGridLookUpEdit.EditValue & "And {Supplier.SupplierId}=" & SupplierLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ProgramwiseYarnIssueReport_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DyeingDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DyeingDateTimePicker.ValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class