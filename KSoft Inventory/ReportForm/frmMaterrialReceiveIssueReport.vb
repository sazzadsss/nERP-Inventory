Public Class frmMaterrialReceiveIssueReport
    Dim filterstring As String = ""
    Dim recordcount As Integer = 0
    Private Sub frmMaterrialReceiveIssueReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MRRLookupTableAdapter.Fill(Me.MRRLookupDataSet.MRRLookup, DepartmentComboBox.SelectedValue)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        Dim Index As Integer
        Index = DepartmentBindingSource.Find("DepartmentId", DepartmentId)
        DepartmentBindingSource.Position = Index
    End Sub

    Private Sub ReceiveButton_Click(sender As Object, e As EventArgs) Handles ReceiveButton.Click

        filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue & " And {Receive.ReceiveDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub IssueButton_Click(sender As Object, e As EventArgs) Handles IssueButton.Click

        filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue & " And {Issue.IssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub AllButton_Click(sender As Object, e As EventArgs) Handles AllButton.Click

        'Deleting 
        ExecuteQuery("Delete  ReceiveIssue Where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)

            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId From Issue where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId From Receive Where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId From Issueto where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)

            filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue & " And {ReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ItemRegister
            ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Issue.IssueDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) AND {Branch.BranchId} = " & BranchComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub DepartmentComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepartmentComboBox.SelectedIndexChanged
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentComboBox.SelectedValue)
        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentComboBox.SelectedValue)
        Me.MRRLookupTableAdapter.Fill(Me.MRRLookupDataSet.MRRLookup, DepartmentComboBox.SelectedValue)
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        Me.SubCategoryLookupTableAdapter.Fill(Me.SubCategoryDataSet.SubCategoryLookup, DepartmentComboBox.SelectedValue, CategoryComboBox.SelectedValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Receive.ReceiveDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) And {Category.CategoryId} = " & CategoryComboBox.SelectedValue & " And {SubCategory.SubCategoryId} = " & SubCategoryComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetailsCategorySubCategoryByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Receive.ReceiveDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) And {Category.CategoryId} = " & CategoryComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetailsCategoryByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Issue.IssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) And {Category.CategoryId} = " & CategoryComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsCategoryByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Issue.IssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) And {Category.CategoryId} = " & CategoryComboBox.SelectedValue & " And {SubCategory.SubCategoryId} = " & SubCategoryComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsCategorySubCategoryByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
End Class