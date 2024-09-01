Public Class frmDyesChemicalRequirementReport
    Private Sub frmDyesChemicalRequirementReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DCStore)

        Dim StartMonth As Date = DateSerial(ToMonthDateTimePicker.Value.Year, Month(ToMonthDateTimePicker.Value.AddMonths(-2)), 1)
        Dim EndMonth As Date = DateSerial(ToMonthDateTimePicker.Value.Year, ToMonthDateTimePicker.Value.Month + 1, 0)
        ToMonthDateTimePicker.Value = EndMonth


    End Sub

    Private Sub bgrLongProcess_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgrLongProcess.DoWork

        NewGenerate()

    End Sub

    Private Sub bgrLongProcess_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgrLongProcess.ProgressChanged
        'PrgLongProcess.Value = e.ProgressPercentage
    End Sub

    Private Sub bgrLongProcess_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgrLongProcess.RunWorkerCompleted

        btnStartProcess.Enabled = True
        Me.GeneratingLabel.Text = "Completed"

        Dim filterstring As String = "{Department.DepartmentId}=" & DCStore & "And not {ItemList.Discontinue} And {Category.CategoryName} = '" & CategoryComboBox.Text & "'"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DyesChemicalRequirement
        MyReport.SetParameterValue("Type", CategoryComboBox.Text)
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub NewGenerate()

        Dim StartMonth As Date = DateSerial(ToMonthDateTimePicker.Value.Year, Month(ToMonthDateTimePicker.Value.AddMonths(-2)), 1)
        Dim EndMonth As Date = DateSerial(ToMonthDateTimePicker.Value.Year, ToMonthDateTimePicker.Value.Month + 1, 0)

        ExecuteQuery("Execute dbo.StoreBalance @DepartmentId=" & DCStore & ",@OpeningDate='" & StartMonth & "',@ClosingDate='" & EndMonth & "'", cnn)

    End Sub

    Private Sub btnStartProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartProcess.Click

        ' Get ready.
        'varDepartmentId = DepartmentComboBox.SelectedValue

        ExecuteQuery("Update Issueto Set Auto=0 Where Auto is null", cnn)

        GeneratingLabel.Text = "Please wait, the report is being shown..."
        btnStartProcess.Enabled = False

        ' Start the worker.

        bgrLongProcess.WorkerReportsProgress = True
        bgrLongProcess.WorkerSupportsCancellation = True
        bgrLongProcess.RunWorkerAsync()

    End Sub

End Class