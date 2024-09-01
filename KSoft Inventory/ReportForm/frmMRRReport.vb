Public Class frmMRRReport

    Private Sub MRRButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRRButton.Click

        Dim filterstring As String = ""
        filterstring = "{Receive.MRRNo}=" & Val(Me.MRRGridLookUpEdit.EditValue) & "And {Receive.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MaterialReceivingReportWithLC_Potrait
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.MRRGridLookUpEdit.Text, True))
        MyReport.SetParameterValue("PType", "Report")

        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmMRRReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

    End Sub


    Private Sub DepartmentComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DepartmentComboBox.SelectedValueChanged

        On Error Resume Next
        'LoadAutoCompleteList("Select Distinct Cast(MRRNo as varchar) As MRRNo From Receive Where MRRNo is not null And DepartmentId =" & DepartmentComboBox.SelectedValue, TextBox1)
        'TextBox1.Text = ReadIntData("Select Max(MRRNo) From Receive Where DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
        Me.MRRLookupTableAdapter.Fill(Me.MRRLookupDataSet.MRRLookup, DepartmentComboBox.SelectedValue)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{Receive.MRRDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MaterialReceivingReportWithLC_Daterange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{Receive.MRRDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Department.DepartmentId} =" & Me.ItemDepartmentIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MaterialReceivingReportWithLC_Daterange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        If PrintCount(Me.MRRGridLookUpEdit.Text, True) > 0 Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed Material Receiving Report", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:

        Dim filterstring = "{Receive.MRRNo}=" & Val(Me.MRRGridLookUpEdit.EditValue) & "And {Receive.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MaterialReceivingReportWithLC_Potrait

        If MessageBox.Show("Are you sure you want to print this Material Receiving Report?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then


            Dim PrintCountNo As Integer = PrintCount(Me.MRRGridLookUpEdit.Text, False)

            'For Single Page Print:

            Dim i As Integer = 0

            PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Head Office", PrintCountNo, PrintDialog1)

            i = i + 0

            MessageBox.Show("Material Receiving Report Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        '    'For Double Page Print:

        '    Dim i As Integer = 0

        '    Do While i <= 1

        '        If i = 0 Then

        '            PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

        '        ElseIf i = 1 Then

        '            PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Store", PrintCountNo, PrintDialog1)

        '        End If

        '        i = i + 1

        '    Loop

        '    MessageBox.Show("Material Receiving Report Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{Receive.MRRDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59)"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MaterialReceivingReportWithLC_PotraitDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SDate As Date = Me.RequisitionDateTimePicker.Text
        Dim SDate2 As Date = Me.RequisitionDateTimePicker2.Text
        Dim filterstring As String = "{Receive.MRRDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 23, 59, 59) AND {Department.DepartmentId} =" & Me.ItemDepartmentIdGridLookUpEdit.EditValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MaterialReceivingReportWithLC_PotraitDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class