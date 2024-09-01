
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Threading

Public Class frmMasterStoreBalanceReport
    Dim t As Thread
    Dim CancelFlag As Boolean = False
    Dim RecordCount As Decimal = 0
    Dim cnn As String = My.Settings.KSoft_InventoryConnectionString
    Dim varDepartmentId As Integer
    Dim VR1Flag As Boolean = False
    Dim VR2Flag As Boolean = False
    Dim filterstring As String = ""


    'Start MainstoreWithValue And Qty report-Babu/IMRUL-21-06-2013

    Private Sub frmMasterStoreBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.Company' table. You can move, or remove it, as needed.
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)

        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        Dim Index As Integer
        Index = DepartmentBindingSource.Find("DepartmentId", DepartmentId)
        DepartmentBindingSource.Position = Index

        If UserLevel = 1 Then
            DepartmentComboBox.Enabled = True
        End If


        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateDateTimePicker.Value = StartMonth
        ToDateDateTimePicker.Value = EndMonth


    End Sub

    Private Sub btnStartProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartProcess.Click

        ' Get ready.
        varDepartmentId = DepartmentComboBox.SelectedValue



        GeneratingLabel.Text = "Please wait, the report is being shown..."
        'btnStartProcess.Enabled = False

        ExecuteQuery("Update Issueto Set Auto=0 Where Auto is null", cnn)
        ExecuteQuery("Execute dbo.MasterStoreBalance @DepartmentId=" & varDepartmentId & ",@FromDate='" & FromDateDateTimePicker.Text & "',@ToDate='" & ToDateDateTimePicker.Text & "'", cnn)

        filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue}"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterStoreBalance
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Me.GeneratingLabel.Text = "Completed"


    End Sub

    Private Sub btnStartProcessbyvalue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartProcessbyvalue.Click
        varDepartmentId = DepartmentComboBox.SelectedValue

        GeneratingLabel.Text = "Please wait, the report is being shown..."

        ExecuteQuery("Execute dbo.MasterStoreBalanceValue @DepartmentId=" & varDepartmentId & ",@FromDate='" & FromDateDateTimePicker.Text & "',@ToDate='" & ToDateDateTimePicker.Text & "'", cnn)


        If Template1RadioButton.Checked = True Then

            filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue}"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterStoreBalanceValue

            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

        Me.GeneratingLabel.Text = "Completed"


    End Sub

    Private Sub CmdByQTYAndValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdByQTYAndValue.Click
        varDepartmentId = DepartmentComboBox.SelectedValue

        GeneratingLabel.Text = "Please wait, the report is being shown..."

        ExecuteQuery("Execute dbo.MasterStoreBalancebyQtyAndValue @DepartmentId=" & varDepartmentId & ",@FromDate='" & FromDateDateTimePicker.Text & "',@ToDate='" & ToDateDateTimePicker.Text & "'", cnn)


        If Template1RadioButton.Checked = True Then

            filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue} And {TempMasterStoreBalancebyQtyAndValue.ClosingQty} > 0.00"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterBalanceReportQtyAndValue

            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

        Me.GeneratingLabel.Text = "Completed"

    End Sub
    'End Babu/IMRUL

    Private Sub Template2RadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Template2RadioButton.CheckedChanged
        If Template2RadioButton.Checked Then
            Template1RadioButton.Checked = True
            Template2RadioButton.Checked = False
            MsgBox("This system is under Construction..........", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get ready.
        varDepartmentId = DepartmentComboBox.SelectedValue



        GeneratingLabel.Text = "Please wait, the report is being shown..."
        'Button1.Enabled = False

        ExecuteQuery("Update Issueto Set Auto=0 Where Auto is null", cnn)
        ExecuteQuery("Execute dbo.MasterStoreBalance @DepartmentId=" & varDepartmentId & ",@FromDate='" & FromDateDateTimePicker.Text & "',@ToDate='" & ToDateDateTimePicker.Text & "'", cnn)

        filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue} And {TempMasterStoreBalance.ClosingBalance} > 0.00"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterStoreBalance
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Me.GeneratingLabel.Text = "Completed"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        varDepartmentId = DepartmentComboBox.SelectedValue

        GeneratingLabel.Text = "Please wait, the report is being shown..."

        ExecuteQuery("Execute dbo.MasterStoreBalanceValue @DepartmentId=" & varDepartmentId & ",@FromDate='" & FromDateDateTimePicker.Text & "',@ToDate='" & ToDateDateTimePicker.Text & "'", cnn)


        If Template1RadioButton.Checked = True Then

            filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue} And {TempMasterStoreBalanceValue.ClosingBalanceValue} > 0.00"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterStoreBalanceValue

            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

        Me.GeneratingLabel.Text = "Completed"
    End Sub


End Class