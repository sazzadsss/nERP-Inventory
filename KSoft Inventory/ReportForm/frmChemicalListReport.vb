Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmChemicalListReport
    Dim filterstring As String = ""


    Private Sub frmChemicalList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PrintingMediaTableAdapter.Fill(Me.MediaDataSet.PrintingMedia, DepartmentId)
        Me.BrandTableAdapter.FillByDepartmentId(Me.BrandDataSet.Brand, DepartmentId)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        Dim index As Integer = Me.DepartmentBindingSource.Find("DepartmentId", DepartmentId)
        Me.DepartmentBindingSource.Position = index

        filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MaterialList
        MyReport.Refresh()
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CategoryCheckBox.Checked = False AndAlso SubCategoryCheckBox.Checked = False Then
            filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue
        ElseIf CategoryCheckBox.Checked = True AndAlso SubCategoryCheckBox.Checked = False Then
            filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & " And {ItemList.CategoryId}=" & CategoryComboBox.SelectedValue
        ElseIf CategoryCheckBox.Checked = False AndAlso SubCategoryCheckBox.Checked = True Then
            filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue & " And {ItemList.SubCategoryId}=" & SubCategoryComboBox.SelectedValue
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MaterialList
        MyReport.Refresh()
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub CategoryCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryCheckBox.CheckedChanged

        If CategoryCheckBox.Checked Then

            CategoryComboBox.Enabled = True
            SubCategoryCheckBox.Checked = False

        Else

            CategoryComboBox.Enabled = False
            SubCategoryCheckBox.Checked = True

        End If

    End Sub

    Private Sub SubCategoryCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubCategoryCheckBox.CheckedChanged

        If SubCategoryCheckBox.Checked Then
            SubCategoryComboBox.Enabled = True
            CategoryCheckBox.Checked = False
        Else
            SubCategoryComboBox.Enabled = False
            CategoryCheckBox.Checked = True

        End If

    End Sub

    Private Sub DepartmentComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentComboBox.SelectedIndexChanged

        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentComboBox.SelectedValue)

    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        Me.SubCategoryTableAdapter.FillByCategoryId(Me.SubCategoryDataSet.SubCategory, Me.CategoryComboBox.SelectedValue)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrandComboBox.SelectedIndexChanged

        filterstring = "{ItemList.BrandId}=" & Me.BrandComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MaterialList
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub SubStoreWiseShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubStoreWiseShow.Click
        ''SubStore Wise Issue Report by (Date range+SubStoreWiseComboBox), Imrul Kaesh, 20/06/2013
        Dim FDate As Date = CType(Me.DateTimePicker1.Text.ToString, Date)
        Dim TDate As Date = CType(Me.DateTimePicker2.Text.ToString, Date)

        filterstring = "{SubStoreWiseIssueReport.MediaName} = '" & SubStoreWiseComboBox.Text & "' and {SubStoreWiseIssueReport.IssueDate} in DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SubStoreWiseIssueReport
        ShowReport(MyReport, filterstring, CrystalReportViewer2)
        'End Imrul

    End Sub

    Private Sub CmdShowSummery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdShowSummery.Click
        ''SubStore Wise Issue Report by (Date range+SubStoreWiseComboBox), Imrul Kaesh, 22/06/2013
        Dim FDate As Date = CType(Me.DateTimePicker1.Text.ToString, Date)
        Dim TDate As Date = CType(Me.DateTimePicker2.Text.ToString, Date)

        filterstring = "{SubStoreWiseIssueReport.MediaName} = '" & SubStoreWiseComboBox.Text & "' and {SubStoreWiseIssueReport.IssueDate} in DateTime (" & FDate.Year & "," & FDate.Month & "," & FDate.Day & ", 00, 00, 00) to DateTime (" & TDate.Year & "," & TDate.Month & "," & TDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New SubStoreWiseIssueReportSummery
        ShowReport(MyReport, filterstring, CrystalReportViewer2)
        'End Imrul
    End Sub

End Class