Public Class frmYarnDyeingReciveIssueStocks
    Private Sub frmYarnDyeingReciveIssueStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.DepartmentComboBox.SelectedValue = 19
        Me.IssueProgramLookupTableAdapter.Fill(Me.IssueProgramLookupDataSet.IssueProgramLookup, DepartmentId)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.FinishFabricBookingLookUpTableAdapter.Fill(Me.FFBLookupDataSet.FinishFabricBookingLookUp)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim filterstring As String = String.Empty

        filterstring = "{ItemReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDyeingReceiveIssue
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click
        Dim filterstring As String = "{FinishFabricBooking.ProgramNo}='" & FinishFabricBookingIdGridLookUpEdit.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDyeingReceiveIssue
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filterstring As String = String.Empty
        filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDyeingReceiveIssue
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim filterstring As String = "{FinishFabricBooking.ProgramNo}='" & FinishFabricBookingIdGridLookUpEdit.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDyeingReceiveIssueDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim filterstring As String = String.Empty

        If RunningRadioButton.Checked Then
            filterstring = "not {FinishFabricBooking.IsClose} And {Department.DepartmentId} =" & DepartmentComboBox.SelectedValue
        Else
            filterstring = "{Department.DepartmentId} =" & DepartmentComboBox.SelectedValue
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDyeingStocks
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim filterstring As String = String.Empty

        If RunningRadioButton.Checked Then
            filterstring = "not {FinishFabricBooking.IsClose} And {Department.DepartmentId} =" & DepartmentComboBox.SelectedValue
        Else
            filterstring = "{Department.DepartmentId} =" & DepartmentComboBox.SelectedValue
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDyeingStocksDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim filterstring As String = String.Empty
        filterstring = "{ItemReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) And {ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDyeingReceiveIssueDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim filterstring As String = String.Empty
        filterstring = "{ItemList.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New YarnDyeingReceiveIssueDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub DepartmentComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepartmentComboBox.SelectedIndexChanged

    End Sub
End Class