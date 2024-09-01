Public Class frmSupportComplain
    Private Sub FrmSupportComplain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.MaintenanceComplainTableAdapter.Fill(Me.MaintenanceComplainDataSet.MaintenanceComplain)
    End Sub

    Private Sub ShowButton_Click(sender As Object, e As EventArgs) Handles ShowButton.Click

        Dim filterstring As String = "{MaintenanceComplain.ComplainDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Support_Complain
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SDate As Date = Me.DateTimePicker1.Text
        Dim SDate2 As Date = Me.DateTimePicker2.Text
        Dim filterstring As String = "{MaintenanceComplain.ComplainDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Department.DepartmentId} =" & Me.ItemDepartmentIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Support_Complain
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class