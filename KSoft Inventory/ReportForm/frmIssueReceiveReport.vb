Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmIssueReceiveReport
    Dim filterstring As String = ""
    Dim recordcount As Integer = 0

    Private Sub frmIssueReceive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MRRLookupDataSet.Receive' table. You can move, or remove it, as needed.
        Me.MRRLookupTableAdapter.Fill(Me.MRRLookupDataSet.MRRLookup, DepartmentComboBox.SelectedValue)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        Dim Index As Integer
        Index = DepartmentBindingSource.Find("DepartmentId", DepartmentId)
        DepartmentBindingSource.Position = Index

        'If UserLevel = 1 Then
        '    DepartmentComboBox.Enabled = True
        'Else
        '    DepartmentComboBox.Enabled = False
        'End If

    End Sub


    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click


        'If IssueRadioButton.Checked = True Then


        '    If ItemNameRadioButton.Checked = True Then



        '        filterstring = "{ItemList.ItemId}=" & ItemNameGridLookUpEdit.EditValue

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetails
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)


        '    ElseIf DateRadioButton.Checked = True Then




        '        If ComboBox1.Text = "Issue" Then

        '            filterstring = "{Issue.IssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue
        '            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsByDate
        '            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '        Else

        '            filterstring = "{IssueReceiveType.IssueTypeName} = 'Normal' And not {Issueto.Auto} And {Issueto.IssuetoDate} = DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) and {Department.DepartmentId} = " & DepartmentComboBox.SelectedValue
        '            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsByDate2
        '            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '        End If



        '    End If

        'ElseIf ReceiveRadioButton.Checked = True Then


        '    If ItemNameRadioButton.Checked = True Then



        '        filterstring = "{ItemList.ItemId}=" & ItemNameGridLookUpEdit.EditValue

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetails
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)


        '    ElseIf DateRadioButton.Checked = True Then

        '        filterstring = "{Receive.ReceiveDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetailsByDate
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)



        '    End If

        'ElseIf BothRadioButton.Checked = True Then

        '    If ItemNameRadioButton.Checked = True Then

        '        'ProgressBarControl1.PerformStep()
        '        'ProgressBarControl1.Update()

        '        If ItemListBindingSource.Position > -1 Then


        '            ExecuteQuery("Delete  ReceiveIssue Where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)


        '            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId From Issue where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)
        '            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId From Receive Where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)
        '            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId From Issueto where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)

        '            '' " And {ReceiveIssue.ReceiveIssueDate}= in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) AND {ItemList.DepartmentId} = " & DepartmentId
        '            If WithDateCheckBox.Checked Then
        '                filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue & " And {ReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"
        '            Else
        '                filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue
        '            End If

        '            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ItemRegister
        '            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '        End If
        '    ElseIf DateRadioButton.Checked = True Then
        '        ' For Both Record

        '        ExecuteQuery("Delete  ReceiveIssue Where DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

        '        ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId From Issue where IssueReceiveTypeId=3 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
        '        ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId From Receive Where IssueReceiveTypeId=3 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
        '        ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId From Issueto where IssueReceiveTypeId=3 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

        '        filterstring = "{ReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"

        '        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveIssueRegisterByDate
        '        ShowReport(MyReport, filterstring, CrystalReportViewer1)
        '        'End Babu
        '    ElseIf SupplierRadioButton.Checked = True Then


        '        If SupplierBindingSource.Position > -1 Then



        '            If LoanCheckBox.Checked Then




        '                If AllCheckBox.Checked Then

        '                    ExecuteQuery("Delete  ReceiveIssue Where DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

        '                    ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId From Issue where IssueReceiveTypeId=3 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
        '                    ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId From Receive Where IssueReceiveTypeId=3 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
        '                    ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId From Issueto where IssueReceiveTypeId=3 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)




        '                    'Set Date range wise Filter, 05-07-2013, Imrul Kaesh, Babu
        '                    filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & " and {ReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"

        '                    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LoanRegisterSupplierwise_All
        '                    'Set parameter (Todate and FromDate , 05-07-2013, Imrul Kaesh, Babu
        '                    MyReport.SetParameterValue("Fromdate", DateTimePicker1.Value)
        '                    MyReport.SetParameterValue("Todate", DateTimePicker2.Value)
        '                    ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '                Else

        '                    ExecuteQuery("Delete  ReceiveIssue Where SupplierId=" & SupplierGridLookUpEdit.EditValue & "AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

        '                    ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId From Issue where IssueReceiveTypeId=3 AND DepartmentId=" & DepartmentComboBox.SelectedValue & "AND SupplierId=" & SupplierGridLookUpEdit.EditValue, cnn)
        '                    ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId From Receive Where IssueReceiveTypeId=3 AND DepartmentId=" & DepartmentComboBox.SelectedValue & "AND SupplierId=" & SupplierGridLookUpEdit.EditValue, cnn)
        '                    ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId From Issueto where IssueReceiveTypeId=3 AND DepartmentId=" & DepartmentComboBox.SelectedValue & "AND SupplierId=" & SupplierGridLookUpEdit.EditValue, cnn)


        '                    'Set Date range wise Filter, 05-07-2013, Imrul Kaesh, Babu
        '                    filterstring = "{Supplier.SupplierId}=" & SupplierGridLookUpEdit.EditValue & " AND {Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & " and {ReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"



        '                    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LoanRegisterSupplierwise
        '                    'Set parameter (Todate and FromDate , 05-07-2013, Imrul Kaesh, Babu
        '                    MyReport.SetParameterValue("Fromdate", DateTimePicker1.Value)
        '                    MyReport.SetParameterValue("Todate", DateTimePicker2.Value)
        '                    ShowReport(MyReport, filterstring, CrystalReportViewer1)

        '                End If




        '            Else



        '                ExecuteQuery("Delete  ReceiveIssue Where SupplierId=" & SupplierGridLookUpEdit.EditValue & "AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

        '                ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId From Issue where  DepartmentId=" & DepartmentComboBox.SelectedValue & "AND SupplierId=" & SupplierGridLookUpEdit.EditValue, cnn)
        '                ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId From Receive Where  DepartmentId=" & DepartmentComboBox.SelectedValue & "AND SupplierId=" & SupplierGridLookUpEdit.EditValue, cnn)
        '                ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId From Issueto where DepartmentId=" & DepartmentComboBox.SelectedValue & "AND SupplierId=" & SupplierGridLookUpEdit.EditValue, cnn)


        '                filterstring = "{Supplier.SupplierId}=" & SupplierGridLookUpEdit.EditValue & " AND {Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & " and {ReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"

        '                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueReceiveSupplierWise
        '                MyReport.SetParameterValue("Fromdate", DateTimePicker1.Value)
        '                MyReport.SetParameterValue("Todate", DateTimePicker2.Value)
        '                ShowReport(MyReport, filterstring, CrystalReportViewer1)


        '            End If


        '        End If


        '    End If

        'End If


    End Sub


    Private Sub DepartmentComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentComboBox.SelectedIndexChanged
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, DepartmentComboBox.SelectedValue)
        Me.MRRLookupTableAdapter.Fill(Me.MRRLookupDataSet.MRRLookup, DepartmentComboBox.SelectedValue)
    End Sub

    Private Sub ItemNameRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ItemListComboBox.Enabled = True
        'SupplierComboBox.Enabled = False

        ItemNameGridLookUpEdit.Enabled = True
        SupplierGridLookUpEdit.Enabled = False

    End Sub

    Private Sub DateRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'ItemListComboBox.Enabled = False
        ItemNameGridLookUpEdit.Enabled = False


    End Sub

    Private Sub SupplierRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


        ItemNameGridLookUpEdit.Enabled = False
        SupplierGridLookUpEdit.Enabled = True


    End Sub


    Private Sub ItemwiseLoanLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)




    End Sub

    Private Sub ItemIssuedtoProgramLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

        filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue & " and " & _
                       "{Issueto.IssuetoDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)" & _
                       "AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And" & _
                       "{@NoProgram} = 0.00"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ItemIssuedtoProgramRegister
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub



    Private Sub ItemIssuedtoProgramLinkLabel_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '{Issueto.IssuetoDate} = "2014-06-30" and {IssueReceiveType.IssueTypeName} = "Normal" and not {Issueto.Auto} and {Department.DepartmentId} = 7.00
        '{Issueto.IssuetoDate} in "02-Feb-17" to "02-Jun-14"
        '{Issueto.IssuetoDate} in "08-Sep-16" to "02-May-17"
        Dim SFDate As Date = DateTimePicker1.Text
        Dim STDate As Date = DateTimePicker2.Text
        filterstring = "{IssueReceiveType.IssueTypeName} = 'Normal' And not {Issueto.Auto} And {Issueto.IssuetoDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"
        'MessageBox.Show(filterstring)
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsByDate2
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub



    Private Sub SupplierwiseLoanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierwiseLoanButton.Click


        ExecuteQuery("Delete  ReceiveIssue Where SupplierId=" & SupplierGridLookUpEdit.EditValue & "AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

        ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId) Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId From Issue where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue & "AND SupplierId=" & SupplierGridLookUpEdit.EditValue, cnn)
        ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId) Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId From Receive Where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue & "AND SupplierId=" & SupplierGridLookUpEdit.EditValue, cnn)
        ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId) Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId From Issueto where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue & "AND SupplierId=" & SupplierGridLookUpEdit.EditValue, cnn)

        filterstring = "{Supplier.SupplierId}=" & SupplierGridLookUpEdit.EditValue & " AND {Department.DepartmentId}=" & DepartmentComboBox.SelectedValue '& " and {ReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LoanRegisterSupplierwise

        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

    Private Sub LoanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoanButton.Click

        If ItemListBindingSource.Position > -1 Then


            ExecuteQuery("Delete  ReceiveIssue Where DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId From Issue where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId From Receive Where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId From Issueto where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)



            filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LoanRegisterSupplierwise_All
            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        End If

    End Sub

    Private Sub IssueButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueButton.Click
        If DateCheckBox.Checked Then
            filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue & " And {Issue.IssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"
        Else
            filterstring = "{ItemList.ItemId}=" & ItemNameGridLookUpEdit.EditValue
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub ReceiveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveButton.Click

        If DateCheckBox.Checked Then
            filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue & " And {Receive.ReceiveDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"
        Else
            filterstring = "{ItemList.ItemId}=" & ItemNameGridLookUpEdit.EditValue
        End If


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub AllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllButton.Click

        If ItemListBindingSource.Position > -1 Then

            'Deleting 
            ExecuteQuery("Delete  ReceiveIssue Where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)

            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId From Issue where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId From Receive Where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId From Issueto where ItemId=" & ItemNameGridLookUpEdit.EditValue, cnn)

            If DateCheckBox.Checked Then
                filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue & " And {ReceiveIssue.ReceiveIssueDate} in DateTime (" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)"
            Else
                filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue
            End If

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ItemRegister
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

    End Sub

    Private Sub IssuedToProgramButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssuedToProgramButton.Click

        filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue & _
                      "AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And" & _
                      "{@NoProgram} = 0.00"

        '{Issueto.IssuetoDate} in "2014-03-31" to "2014-05-12"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ItemIssuedtoProgramRegister
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub


    Private Sub ReceiveByDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveByDateButton.Click

        filterstring = "{Receive.ReceiveDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub IssueByDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueByDateButton.Click
        filterstring = "{Issue.IssueDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub



    Private Sub MRRTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LoadByDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadByDateButton.Click

        If DepartmentComboBox.SelectedValue = DCStore Then

            ExecuteQuery("Delete  ReceiveIssue Where DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId From Issue where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId From Receive Where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId From Issueto where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

            filterstring = "{ReceiveIssue.ReceiveIssueDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LoanRegisterSupplierwise_All
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else
            'MessageBox.Show("Not Available For this store", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub ItemAndDateLoanButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemAndDateLoanButton.Click

        If DepartmentComboBox.SelectedValue = DCStore Then

            ExecuteQuery("Delete  ReceiveIssue Where DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId From Issue where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId From Receive Where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)
            ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId From Issueto where IssueReceiveTypeId=2 AND DepartmentId=" & DepartmentComboBox.SelectedValue, cnn)

            filterstring = "{ReceiveIssue.ReceiveIssueDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)AND {ItemList.ItemId} = " & Me.ItemNameGridLookUpEdit.EditValue
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New LoanRegisterSupplierwiseByItemAndDate
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else
            'MessageBox.Show("Not Available For this store", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{ItemList.ItemId} = " & ItemNameGridLookUpEdit.EditValue &
                     "AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And" &
                     "{@NoProgram} = 0.00"

        '{Issueto.IssuetoDate} in "2014-03-31" to "2014-05-12"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ItemIssuedtoProgramRegisterDetails
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        filterstring = "{Issue.IssueDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59)AND {Branch.BranchId} = " & BranchComboBox.SelectedValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class