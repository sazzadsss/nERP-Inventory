Public Class frmYarnStockReport

    Private Sub frmYarnStockReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.LCListTableAdapter.Fill(Me.OpeningLCDataSet.LCList, 8)
        Me.PIListTableAdapter.FillByDepartmentId(Me.OpeningLCDataSet.PIList, 8)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, YarnStoreId)
        Me.DepartmentComboBox.SelectedValue = YarnStoreId

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'only this code for get item Value filtering by department And Item Name.
        Dim filterstring As String = "{ItemList.ItemId}=" & ItemLookupGridLookUpEdit.EditValue & " And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & ""



        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub DepartmentComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentComboBox.SelectedIndexChanged

        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentComboBox.SelectedValue)
        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentComboBox.SelectedValue)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim filterstring As String = "{Company.CompanyId}=" & CompanyComboBox.SelectedValue & " And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub PhysicalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhysicalButton.Click
        '
        Dim filterstring As String = String.Empty

        If ByItemCheckBox.Checked Then

            If Val(TTLDayTextBox.Text) > 0 Then
                filterstring = "{ItemList.ItemId}=" & ItemLookupGridLookUpEdit.EditValue & " And {@InHand_Lotwise} >" & Val(PhysicalTextBox.Text) & "And {@TTLDay} >" & Val(TTLDayTextBox.Text)
            Else
                filterstring = "{ItemList.ItemId}=" & ItemLookupGridLookUpEdit.EditValue & " And {@InHand_Lotwise} >" & Val(PhysicalTextBox.Text)
            End If

        Else
            If Val(TTLDayTextBox.Text) > 0 Then
                filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & " And {@InHand_Lotwise} >" & Val(PhysicalTextBox.Text) & "And {@TTLDay} >" & Val(TTLDayTextBox.Text)
            Else
                If Val(PhysicalTextBox.Text) > 0 Then
                    filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & " And {@InHand_Lotwise} >" & Val(PhysicalTextBox.Text)
                Else
                    filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue
                End If

            End If
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub RealButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RealButton.Click

        Dim filterstring As String = String.Empty

        If Val(TTLDayTextBox.Text) > 0 Then
            filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & " And {@RealStock} >" & Val(RealTextBox.Text) & " And {@TTLDay}>" & Val(TTLDayTextBox.Text)
        Else
            If Val(RealTextBox.Text) > 0 Then
                filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & " And {@RealStock} >" & Val(RealTextBox.Text)
            Else
                filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue
            End If
        End If



        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim filterstring2 As String = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & " And  {@TTLDay} IN " & Val(TextBox2.Text) & " TO " & Val(TextBox1.Text)

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnReceiveReport_Datewise
        ShowReport(MyReport, filterstring2, CrystalReportViewer1)

    End Sub

    Private Sub ShowByDateButton_Click(sender As Object, e As EventArgs) Handles ShowByDateButton.Click
        Dim filterstring As String = String.Empty


        filterstring = "{ItemReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate_Datewise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim filterstring As String = String.Empty


        filterstring = "{ItemReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) And {Company.CompanyId}=" & CompanyComboBox.SelectedValue & " And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate_Datewise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim filterstring As String = "{LCList.LCId}=" & LCIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate_LC_Wise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim filterstring As String = "{PIList.PIId}=" & PIGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate_LC_Wise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim filterstring As String = "{LCList.SupplierId}=" & SupplierIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate_LC_Wise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate_LC_Wise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub CategoryCheckBox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SubCategoryCheckBox_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CategoryComboBox.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click

        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & " and {Category.CategoryId} = " & CategoryComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub SubCategoryCheckBox_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SubCategoryComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim filterstring As String = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & " and {Category.CategoryId} = " & CategoryComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate_LC_Wise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim filterstring As String = "{ItemList.ItemId}=" & ItemLookupGridLookUpEdit.EditValue & " And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & ""



        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate_LC_Wise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim filterstring As String = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepotwithoutLCLOT
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim filterstring As String = "{YarnStock.ItemId}=" & ItemLookupGridLookUpEdit.EditValue & " And {Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & ""

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepotwithoutLCLOT
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        Dim filterstring As String = "{@InHand_Lotwise} > 0.00 And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnStockRepot_WithAllocate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class