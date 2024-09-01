Public Class frmFinishFabricStoreReport

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim filterstring As String = "{GreyFabricReceiveIssue.ChallanDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricStoreStatusDateRange
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ShowMoreDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMoreDetailsButton.Click
        If Me.MultipleProgramTextBox2.Text <> String.Empty Then


            Dim s As String = ""
            Dim s1 As String = ""

            s = MultipleProgramTextBox2.Text

            s1 = s.Replace(", ", "','") 'You should use one space after first comma
            s1 = Trim(s1)

            'Me.PlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"
            'Me.SewingPlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"

            'MessageBox.Show(s1)


            Dim filterstring As String = "{FinishFabricBooking.ProgramNo}  like ['" & s1 & "']"


            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricStoreStatusDateRange
            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        End If
    End Sub


    Private Sub frmFinishFabricStoreReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FinishFabricOrderLookupTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricOrderLookup)
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.MultipleProgramTextBox2.Text = String.Empty Then
            Me.MultipleProgramTextBox2.Text = Me.GridLookUpEdit1.Text
        Else
            Me.MultipleProgramTextBox2.Text = Me.MultipleProgramTextBox2.Text & ", " & Me.GridLookUpEdit1.Text
        End If
    End Sub
End Class