Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient

Public Class frmRequisitionReport
    Dim querystring As String = ""

    Private _RqId As Integer
    Public Property RqId() As Integer
        Get
            Return _RqId
        End Get
        Set(ByVal value As Integer)
            _RqId = value
        End Set
    End Property

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load


        'If OLDRadioButton.Checked = True Then
        '    ConfigureRequisition()
        'ElseIf othersRadioButton.Checked = True Then
        '    ConfigureRequisitionAzad()
        'Else
        '    ConfigureRequisitionNew()
        'End If


    End Sub
    Private Sub ConfigureRequisition()
        Dim MyReport As New Requisition

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog



        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If

        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = querystring
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub ConfigureRequisitionNew()
        Dim MyReport As New RequisitionNew

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table


        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog




        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If

        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = querystring
        CrystalReportViewer1.Refresh()
    End Sub


    Private Sub frmRequisitionPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Dim Index As Integer
        Index = DepartmentBindingSource.Find("DepartmentId", DepartmentId)
        DepartmentBindingSource.Position = Index
        Me.GridLookUpEdit1.EditValue = Me.RqId
        DepartmentComboBox.Enabled = True


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Requisition_Monthly_Potrait
        Dim filterstring As String = "{Requisition.RequisitionId}=" & GridLookUpEdit1.EditValue
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.GridLookUpEdit1.Text, True))
        MyReport.SetParameterValue("PType", "Report")
        ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub



    Private Sub ConfigureRequisitionProject()

        Dim MyReport As New RequisitionProject

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog



        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If

        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = querystring
        CrystalReportViewer1.Refresh()

    End Sub
    Private Sub ConfigureRequisitionAzad()

        Dim MyReport As New RequisitionAzad

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog


        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable

        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If



        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = querystring
        CrystalReportViewer1.Refresh()

    End Sub

    Private Sub DepartmentComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentComboBox.SelectedIndexChanged


        Me.RequisitionLookupTableAdapter.Fill(Me.RequisitionDataSet.RequisitionLookup, DepartmentComboBox.SelectedValue)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentComboBox.SelectedValue)


    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged


        querystring = "{Requisition.RequisitionId}=" & GridLookUpEdit1.EditValue

        'If OLDRadioButton.Checked = True Then
        '    ConfigureRequisition()
        'ElseIf NewRadioButton.Checked = True Then
        '    ConfigureRequisitionNew()
        'ElseIf othersRadioButton.Checked = True Then
        '    ConfigureRequisitionAzad()
        'ElseIf GarmentsRadioButton.Checked = True Then
        '    ConfigureRequisitionGarments()
        'ElseIf AdminRadioButton.Checked = True Then

        '    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionView
        '    ShowReport(MyReport, querystring, CrystalReportViewer1)
        'Else
        '    ConfigureRequisitionProject()
        'End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'querystring = "{Requisition.RequisitionId}=" & GridLookUpEdit1.EditValue

        'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Requisition_RegularNew
        'ShowReport(MyReport, querystring, CrystalReportViewer1)

        If PrintCount(Me.GridLookUpEdit1.Text, True) > 0 Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed Purchase Requisition", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Requisition_Monthly_Potrait
        Dim filterstring As String = "{Requisition.RequisitionId}=" & GridLookUpEdit1.EditValue

        If MessageBox.Show("Are you sure you want to print this Purchase Requisition?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then


            Dim PrintCountNo As Integer = PrintCount(Me.GridLookUpEdit1.Text, False)

            'For Single Page Print

            Dim i As Integer = 0

            PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Purchase", PrintCountNo, PrintDialog1)

            i = i + 0

            MessageBox.Show("Purchase Requisition Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        '    'For Double Page Print

        '    Dim i As Integer = 0

        '    Do While i <= 1

        '        If i = 0 Then

        '            PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

        '        ElseIf i = 1 Then

        '            PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Store", PrintCountNo, PrintDialog1)



        '        End If

        '        i = i + 1

        '    Loop

        '    MessageBox.Show("Purchase Requisition Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If


    End Sub

    Private Sub ConfigureRequisitionGarments()

        Dim MyReport As New RequisitionGarments

        Dim myLogonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Dim myTable As Table

        Dim builder As New SqlConnectionStringBuilder(cnn)
        Dim user As String = builder.UserID
        Dim pass As String = builder.Password
        Dim server As String = builder.DataSource
        Dim db As String = builder.InitialCatalog



        For Each myTable In MyReport.Database.Tables
            myLogonInfo = myTable.LogOnInfo
            'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
            myLogonInfo.ConnectionInfo.ServerName = server
            myLogonInfo.ConnectionInfo.DatabaseName = db
            myLogonInfo.ConnectionInfo.UserID = user
            myLogonInfo.ConnectionInfo.Password = pass
            myTable.ApplyLogOnInfo(myLogonInfo)
        Next myTable


        If MyReport.Subreports.Count > 0 Then
            For Each rpt As ReportDocument In MyReport.Subreports
                For Each myTable In rpt.Database.Tables
                    myLogonInfo = myTable.LogOnInfo
                    'myLogonInfo.ConnectionInfo.ServerName = Application.StartupPath & "\" & "data.mdb"
                    myLogonInfo.ConnectionInfo.ServerName = server
                    myLogonInfo.ConnectionInfo.DatabaseName = db
                    myLogonInfo.ConnectionInfo.UserID = user
                    myLogonInfo.ConnectionInfo.Password = pass
                    myTable.ApplyLogOnInfo(myLogonInfo)
                Next myTable
            Next
        End If

        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.SelectionFormula = querystring
        CrystalReportViewer1.Refresh()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Requisition_Monthly_Potrait
        Dim filterstring As String = "{Requisition.RequisitionId}=" & GridLookUpEdit1.EditValue
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.GridLookUpEdit1.Text, True))
        MyReport.SetParameterValue("PType", "Report")
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{Requisition.RequisitionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Department.DepartmentId} = " & Me.ItemDepartmentIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Requisition_Monthly_Daterange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{Requisition.RequisitionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Requisition_Monthly_Daterange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim filterstring As String = "{RequisitionView.RequisitionId}=" & GridLookUpEdit1.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionStatusByPR
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{Requisition.RequisitionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Requisition_Monthly_DaterangeDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{Requisition.RequisitionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Department.DepartmentId} = " & Me.ItemDepartmentIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Requisition_Monthly_DaterangeDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub



    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        querystring = "{RequisitionView.RequisitionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {ItemList.ItemId}=" & Me.ItemLookupGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionStatusByItemName
        ShowReport(MyReport, querystring, CrystalReportViewer1)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        querystring = "{ItemList.ItemId}=" & Me.ItemLookupGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionStatusByItemName
        ShowReport(MyReport, querystring, CrystalReportViewer1)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        querystring = "{RequisitionView.RequisitionDate}  in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) And {Department.DepartmentId} = " & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionStatus
        ShowReport(MyReport, querystring, CrystalReportViewer1)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        querystring = "{@Balance} > 0.00 And not {RequisitionView.ReceivingClosed} and {Department.DepartmentId} = " & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New RequisitionStatus
        ShowReport(MyReport, querystring, CrystalReportViewer1)
    End Sub
End Class