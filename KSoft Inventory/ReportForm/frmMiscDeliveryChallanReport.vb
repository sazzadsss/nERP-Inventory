Public Class frmMiscDeliveryChallanReport
    Dim SDate As Date
    Dim SDate2 As Date
    Dim filterstring As String = String.Empty
    Private _MDID As Integer

    Public Property MDID() As Integer
        Get
            Return _MDID
        End Get
        Set(ByVal value As Integer)
            _MDID = value
        End Set
    End Property

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim filterstring As String = ""
        filterstring = "{MiscDelivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "' And {MiscDelivery.DepartmentId}=" & DepartmentComboBox.SelectedValue
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint
        MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
        MyReport.SetParameterValue("PType", "Report")
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmMiscDeliveryChallanPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UserTableAdapter.Fill(Me.UserDataSet.User)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.MiscChallanLookupTableAdapter.FillByDepartmentId(MiscChallanLookupDataSet.MiscChallanLookup, DepartmentId)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.DepartmentComboBox.SelectedValue = 41



        If Me.MDID > 0 Then

            Me.ChallanGridLookUpEdit.EditValue = Me.MDID

            Dim filterstring As String = ""
            filterstring = "{MiscDelivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "' And {MiscDelivery.DepartmentId}=" & DepartmentComboBox.SelectedValue

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint
            MyReport.SetParameterValue("PrintCount", PrintCount(Me.ChallanGridLookUpEdit.Text, True))
            MyReport.SetParameterValue("PType", "Report")
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If



    End Sub

    Private Sub DepartmentComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentComboBox.SelectedIndexChanged
        On Error Resume Next
        Me.MiscChallanLookupTableAdapter.FillByDepartmentId(Me.MiscChallanLookupDataSet.MiscChallanLookup, DepartmentComboBox.SelectedValue)
    End Sub

    Private Sub ShowByChallanDateButton_Click(sender As Object, e As EventArgs) Handles ShowByChallanDateButton.Click

        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        filterstring = "{MiscDelivery.ChallanDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00)  And {MiscDelivery.DepartmentId} =" & Me.DepartmentComboBox.SelectedValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint_DateRangeCompact
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        Dim CN As Integer = ReadIntData("Select Count(GatePassNo) From GeneralGatepass Where ChallanNo='" & Me.ChallanGridLookUpEdit.Text & "'", cnn)

        If CN = 0 Then
            MessageBox.Show("Not allowed to print without Gatepass.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If PrintCount(Me.ChallanGridLookUpEdit.Text, True) > 0 Then
            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint
        filterstring = "{MiscDelivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "' And {MiscDelivery.DepartmentId}=" & DepartmentComboBox.SelectedValue


        If MessageBox.Show("Are you sure you want to print this challan ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then



            Dim PrintCountNo As Int32 = PrintCount(Me.ChallanGridLookUpEdit.Text, False)
            Dim i As Integer = 0

            Do While i <= 4

                If i = 0 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Store", PrintCountNo, PrintDialog1)

                ElseIf i = 1 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

                ElseIf i = 2 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Accounts", PrintCountNo, PrintDialog1)

                ElseIf i = 3 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Gate", PrintCountNo, PrintDialog1)

                ElseIf i = 4 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Office", PrintCountNo, PrintDialog1)

                End If

                i = i + 1

            Loop

            MessageBox.Show("Challan Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub PrintInButton_Click(sender As Object, e As EventArgs) Handles PrintInButton.Click
        If PrintCount(Me.ChallanGridLookUpEdit.Text, True) > 0 Then

            Dim UL As Integer = ReadIntData("Select User_Level From [User] Where User_Id = " & UserId, cnn)
            If UL <> 1 Then
                MessageBox.Show("Not allowed to print a already printed challan", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                GoTo Line1
            End If

        End If

Line1:


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint
        filterstring = "{MiscDelivery.ChallanNo}='" & Me.ChallanGridLookUpEdit.Text & "' And {MiscDelivery.DepartmentId}=" & DepartmentComboBox.SelectedValue

        If MessageBox.Show("Are you sure you want to print this challan ?.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then


            Dim PrintCountNo As Integer = PrintCount(Me.ChallanGridLookUpEdit.Text, False)


            Dim i As Integer = 0

            Do While i <= 2

                If i = 0 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Store", PrintCountNo, PrintDialog1)

                ElseIf i = 1 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Receiver", PrintCountNo, PrintDialog1)

                ElseIf i = 2 Then

                    PrintChallan(MyReport, filterstring, CrystalReportViewer1, "Office", PrintCountNo, PrintDialog1)



                End If

                i = i + 1

            Loop

            MessageBox.Show("Challan Print has been done.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        filterstring = "{MiscDelivery.ChallanDate} in DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) And {MiscDelivery.DepartmentId} =" & Me.DepartmentComboBox.SelectedValue & " And {Supplier.SupplierId} = " & SupplierGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint_DateRangeCompact
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        filterstring = "{MiscDelivery.ChallanDate} in DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) And {MiscDelivery.DepartmentId} =" & Me.DepartmentComboBox.SelectedValue & " And {User.User_Id} = " & UserGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint_DateRangeCompact
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        filterstring = "{MiscDelivery.ChallanDate} in DateTime(" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00)  And {MiscDelivery.DepartmentId} =" & Me.DepartmentComboBox.SelectedValue


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint_DateRangeDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        filterstring = "{MiscDelivery.ChallanDate} in DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) And {MiscDelivery.DepartmentId} =" & Me.DepartmentComboBox.SelectedValue & " And {Supplier.SupplierId} = " & SupplierGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint_DateRangeDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SDate = Me.FromDateTimePicker.Text
        SDate2 = Me.ToDateTimePicker.Text

        filterstring = "{MiscDelivery.ChallanDate} in DateTime (" & SDate.Year & "," & SDate.Month & "," & SDate.Day & ",00,00,00) to DateTime (" & SDate2.Year & "," & SDate2.Month & "," & SDate2.Day & ", 00, 00, 00) And {MiscDelivery.DepartmentId} =" & Me.DepartmentComboBox.SelectedValue & " And {User.User_Id} = " & UserGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MiscDeliveryChallanPrint_DateRangeDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class