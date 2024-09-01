Public Class frmFinishFabricReceiveIssueReport
    Dim filterstring As String = ""

    Private Sub frmFinishFabricReceiveIssueReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.ExMonthAndYearTableAdapter.Fill(Me.ExMonthAndYearDataSet.ExMonthAndYearTable)
        Me.FinishFabricOrderLookupTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricOrderLookup)

    End Sub

    Private Sub ShowByAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseProgramButton.Click


        If GMTRadioButton.Checked = True Then

            If BulkRadioButton.Checked = True Then
                'filterstring = "{FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='BULK' And {FinishFabricReceiveIssue.IsClose}"
                filterstring = "{@Close} = 1.00 and not {FinishFabricStoreStatus.IsDevelopment}"
            ElseIf BulkRadioButton.Checked = False Then
                filterstring = "{@Close} = 1.00 and {FinishFabricStoreStatus.IsDevelopment}"
            End If

        Else

            If BulkRadioButton.Checked = True Then
                'filterstring = "not {FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='BULK' And {FinishFabricReceiveIssue.IsClose}"
                filterstring = "{@Close} = 1.00 and not {FinishFabricStoreStatus.IsDevelopment}"
            ElseIf BulkRadioButton.Checked = False Then
                filterstring = "{@Close} = 1.00 and {FinishFabricStoreStatus.IsDevelopment}"
            End If

        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssue
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub ShowByPrgButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByPrgButton.Click


        '===============
        If Me.MultipleProgramTextBox2.Text <> String.Empty Then


            Dim s As String = ""
            Dim s1 As String = ""

            s = MultipleProgramTextBox2.Text

            s1 = s.Replace(", ", "','") 'You should use one space after first comma
            s1 = Trim(s1)

            'Me.PlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"
            'Me.SewingPlanningViewBindingSource.Filter = "Line IN ('" & s1 & "')"

            'MessageBox.Show(s1)

            filterstring = "{FinishFabricBooking.ProgramNo}  like ['" & s1 & "']"

            '===============


            'If GMTRadioButton.Checked = True Then
            '    '{@Store} like ["Pending", "Dyeing"] and {FinishFabricBooking.ProgramNo} = "E1873"
            '    filterstring = "{FinishFabricStoreStatus.ProgramNo} like ['" & s1 & "']" ' and {@Store} like ['Pending', 'Garments']"
            'Else
            '    filterstring = "{FinishFabricStoreStatus.ProgramNo} like ['" & s1 & "']" ' and {@Store} like ['Pending', 'Dyeing']"
            'End If


           

            If GMTRadioButton.Checked = True Then
                '{@Store} like ["Pending", "Dyeing"] and {FinishFabricBooking.ProgramNo} = "E1873"
                filterstring = "{FinishFabricStoreStatus.ProgramNo} like ['" & s1 & "']" ' and {@Store} like ['Pending', 'Garments']"
            Else
                filterstring = "{FinishFabricStoreStatus.ProgramNo} like ['" & s1 & "']" ' and {@Store} like ['Pending', 'Dyeing']"
            End If


            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssue 'FinishFabricReceiveIssue_Programwise
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

       
        End If

    End Sub

    
    Private Sub ShowMoreDetailsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowMoreDetailsButton.Click

        If GMTRadioButton.Checked = True Then
            '{@Store} like ["Pending", "Dyeing"] and {FinishFabricBooking.ProgramNo} = "E1873"
            filterstring = "{FinishFabricBooking.ProgramNo} = '" & GridLookUpEdit1.Text & "' and {@Store} like ['Pending', 'Garments']"
        Else
            filterstring = "{FinishFabricBooking.ProgramNo} = '" & GridLookUpEdit1.Text & "' and {@Store} like ['Pending', 'Dyeing']"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssue_Programwise_Details
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Me.GridLookUpEdit2.EditValue.ToString.Length < 7 Then
            filterstring = "not {FinishFabricBooking.IsDevelopment} and {@MonthAndYear} = '0" & Me.GridLookUpEdit2.EditValue.ToString & "' and {@Store} like ['Dyeing', 'Pending']"
        Else
            filterstring = "not {FinishFabricBooking.IsDevelopment} and {@MonthAndYear} = '" & Me.GridLookUpEdit2.EditValue.ToString & "' and {@Store} like ['Dyeing', 'Pending']"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssue_ExMonth_Compact
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Me.GridLookUpEdit2.EditValue.ToString.Length < 7 Then
            filterstring = "not {FinishFabricBooking.IsDevelopment} and {@MonthAndYear} = '0" & Me.GridLookUpEdit2.EditValue.ToString & "' and {@Store} like ['Dyeing', 'Pending']"
        Else
            filterstring = "not {FinishFabricBooking.IsDevelopment} and {@MonthAndYear} = '" & Me.GridLookUpEdit2.EditValue.ToString & "' and {@Store} like ['Dyeing', 'Pending']"
        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssue_ExMonth_Compact_OnlyRcvBalance
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunningProgramButton.Click

        If GMTRadioButton.Checked = True Then

            If BulkRadioButton.Checked = True Then
                'filterstring = "{FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='BULK' And {FinishFabricReceiveIssue.IsClose}"
                filterstring = "{@Close} <> 1.00 and not {FinishFabricStoreStatus.IsDevelopment}"
            ElseIf BulkRadioButton.Checked = False Then
                filterstring = "{@Close} <> 1.00 and {FinishFabricStoreStatus.IsDevelopment}"
            End If

        Else

            If BulkRadioButton.Checked = True Then
                'filterstring = "not {FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='BULK' And {FinishFabricReceiveIssue.IsClose}"
                filterstring = "{@Close} <> 1.00 and not {FinishFabricStoreStatus.IsDevelopment}"
            ElseIf BulkRadioButton.Checked = False Then
                filterstring = "{@Close} <> 1.00 and {FinishFabricStoreStatus.IsDevelopment}"
            End If

        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssue
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllProgramButton.Click

        If GMTRadioButton.Checked = True Then

            If BulkRadioButton.Checked = True Then
                filterstring = "{FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='BULK'"
            ElseIf BulkRadioButton.Checked = False Then
                filterstring = "{FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='SAMPLE'"
            End If

        Else

            If BulkRadioButton.Checked = True Then
                filterstring = "not {FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='BULK'"
            ElseIf BulkRadioButton.Checked = False Then
                filterstring = "not {FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='SAMPLE'"
            End If

        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssue
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub GridLookUpEdit1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.TextChanged
       
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.MultipleProgramTextBox2.Text = String.Empty Then
            Me.MultipleProgramTextBox2.Text = Me.GridLookUpEdit1.Text
        Else
            Me.MultipleProgramTextBox2.Text = Me.MultipleProgramTextBox2.Text & ", " & Me.GridLookUpEdit1.Text
        End If
    End Sub

    
    Private Sub ShowCompactButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowCompactButton.Click

        If Me.MultipleProgramTextBox2.Text <> String.Empty Then


            Dim s As String = ""
            Dim s1 As String = ""

            s = MultipleProgramTextBox2.Text

            s1 = s.Replace(", ", "','") 'You should use one space after first comma
            s1 = Trim(s1)

            filterstring = "{FinishFabricBooking.ProgramNo}  like ['" & s1 & "']"


            If GMTRadioButton.Checked = True Then
                '{@Store} like ["Pending", "Dyeing"] and {FinishFabricBooking.ProgramNo} = "E1873"
                filterstring = "{FinishFabricStoreStatus.ProgramNo} like ['" & s1 & "']" ' and {@Store} like ['Pending', 'Garments']"
            Else
                filterstring = "{FinishFabricStoreStatus.ProgramNo} like ['" & s1 & "']" ' and {@Store} like ['Pending', 'Dyeing']"
            End If


            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssue_Compact
            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        End If

    End Sub

    Private Sub ShowCompact2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowCompact2Button.Click

        If GMTRadioButton.Checked = True Then

            If BulkRadioButton.Checked = True Then
                'filterstring = "{FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='BULK' And {FinishFabricReceiveIssue.IsClose}"
                filterstring = "{@Close} <> 1.00 and not {FinishFabricStoreStatus.IsDevelopment}"
            ElseIf BulkRadioButton.Checked = False Then
                filterstring = "{@Close} <> 1.00 and {FinishFabricStoreStatus.IsDevelopment}"
            End If

        Else

            If BulkRadioButton.Checked = True Then
                'filterstring = "not {FinishFabricReceiveIssue.IsGMTStore} And {@IsSample}='BULK' And {FinishFabricReceiveIssue.IsClose}"
                filterstring = "{@Close} <> 1.00 and not {FinishFabricStoreStatus.IsDevelopment}"
            ElseIf BulkRadioButton.Checked = False Then
                filterstring = "{@Close} <> 1.00 and {FinishFabricStoreStatus.IsDevelopment}"
            End If

        End If

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New FinishFabricReceiveIssue_Compact
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub
End Class