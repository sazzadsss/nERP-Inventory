Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmNeedleIssueReport
    Dim filterstring As String = ""
    Private Sub frmNeedleIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        DateTimePicker1.Value = StartMonth
        DateTimePicker2.Value = Today()

        Dim Index As Integer
        Index = DepartmentBindingSource.Find("DepartmentName", "Knitting")
        DepartmentBindingSource.Position = Index


    End Sub



    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        '{Category.CategoryName} = "NEEDLE" and {Issueto.IssuetoDate} = DateTime (2010, 01, 22, 00, 00, 00)
        filterstring = "{Department.DepartmentId}=" & ComboBox1.SelectedValue & "AND {Issueto.IssuetoDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) "         'AND {Issueto.DepartmentId} = " & DepartmentId


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyNeedleIssueReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


End Class