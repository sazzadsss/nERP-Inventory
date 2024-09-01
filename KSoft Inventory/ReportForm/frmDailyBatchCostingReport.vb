Public Class frmDailyBatchCostingReport
    Dim filterstring As String = ""

    Private Sub frmDailyBatchCostingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BatchLookupTableAdapter.Fill(Me.BatchLookupDataSet.BatchLookup)
        Me.DyeingBuyerListTableAdapter.Fill(Me.DyeingBuyerDataSet.DyeingBuyerList)

        'Me.DyeingBuyerTableAdapter.Fill(Me.DyeingBuyerDataSet.DyeingBuyer)
        'Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)

        Me.FinishFabricColorLookupTableAdapter.FillByFinishFabricBookingId(Me.FinishFabricOrderLookupDataSet.FinishFabricColorLookup, Me.ProgramNoGridLookUpEdit.EditValue)
        Me.FinishFabricOrderLookupTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricOrderLookup)

        'Me.BatchSearchTableAdapter.Fill(Me.BatchLookupDataSet.BatchSearch)
        'Me.BatchInformationTableAdapter.FillByAll(Me.BatchInformationDataSet.BatchInformation)

        Me.ItemListTableAdapter.Fill(Me.ItemListLookupDataSet.ItemList, 7)

    End Sub

    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click

        Dim DyeingDate As Date = DyeingDateTimePicker.Text
        Dim ToDate As Date = ToDateTimePicker.Text

        'filterstring = "{Issueto.ProductionDate} = DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00)"

        filterstring = "{DyeingProduction_Final.DyeingDate} in DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00) to DateTime (" & ToDate.Year & "," & ToDate.Month & "," & ToDate.Day & ", 00, 00, 00)"

        '{Department.DepartmentName} = "Dyeing Chemical Store" and
        '{DyeingProduction_Final.DyeingDate} in DateTime (2011, 05, 02, 00, 00, 00) to DateTime (2011, 05, 22, 00, 00, 00)
        '{Department.DepartmentName} = "Dyeing Chemical Store" and
        '{DyeingProduction_Final.DyeingDate} = DateTime (2011, 01, 24, 00, 00, 00)

        'Dim DayCount As Integer = DateDiff(DateInterval.Day, DyeingDate, ToDate)

        'If DayCount > 1 Then

        '    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DailyBatchProductionReport_New
        '    ShowReport(MyReport, filterstring, CrystalReportViewer1)

        'Else

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Daily_Batch_Production_Report
        ShowReport(MyReport, filterstring, CrystalReportViewer1)



        'End If


    End Sub

   
    Private Sub ShowBatchButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowBatchButton.Click



        'Dim row As BatchLookupDataSet.BatchSearchRow
        'row = CType(CType(Me.BatchSearchBindingSource.Current, DataRowView).Row, BatchLookupDataSet.BatchSearchRow)

        'DyeingDateTimePicker.Text = row.IssuetoDate


        Dim DyeingDate As Date = DyeingDateTimePicker.Text

        filterstring = "{Department.DepartmentId} = " & DCStore & " and {BatchInformation.BatchInformationId} = " & GridLookUpEdit1.EditValue  ' and {Issueto.IssuetoDate} = DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00)"

        '{Issueto.IssuetoDate} = DateTime (2011, 01, 17, 00, 00, 00) and {Department.DepartmentName} = "Dyeing Chemical Store" and {BatchInformation.BatchNo} = "610072"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Batch_Report

        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim row As ItemListLookupDataSet.ItemListRow
        row = CType(CType(Me.ItemListBindingSource.Current, DataRowView).Row, ItemListLookupDataSet.ItemListRow)



        Dim DyeingDate As Date = DyeingDateTimePicker.Text
        Dim ToDate As Date = ToDateTimePicker.Text


        filterstring = "{ItemList.ItemName} = '" & GridLookUpEdit2.Text & "' and {Issueto.IssuetoDate} in DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00) to DateTime (" & ToDate.Year & "," & ToDate.Month & "," & ToDate.Day & ", 00, 00, 00)"


        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New IssueDetailsForParticularItem

        ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.BatchSearchTableAdapter.Fill(Me.BatchLookupDataSet.BatchSearch)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        filterstring = "{BatchInformation.FinishFabricBookingId} =" & ProgramNoGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BatchCostingReportProgramwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)


    End Sub

   
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        filterstring = "{BatchInformation.FinishFabricBookingId} =" & ProgramNoGridLookUpEdit.EditValue & " And {BatchInformation.FabricColorName} = '" & Me.ColorGridLookUpEdit.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New BatchCostingReportProgramwise
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub ProgramNoGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgramNoGridLookUpEdit.EditValueChanged

        Me.FinishFabricColorLookupTableAdapter.FillByFinishFabricBookingId(Me.FinishFabricOrderLookupDataSet.FinishFabricColorLookup, Me.ProgramNoGridLookUpEdit.EditValue)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim DyeingDate As Date = DyeingDateTimePicker.Text
        Dim ToDate As Date = ToDateTimePicker.Text

        '{Department.DepartmentName} = "Dyeing Chemical Store" and
        '{PrintingMedia.MediaName} = "FINISHING" and
        '{Issueto.IssuetoDate} in DateTime (2012, 11, 02, 00, 00, 00) to DateTime (2012, 11, 22, 00, 00, 00)

        filterstring = "{Department.DepartmentId} = " & DCStore & " and {PrintingMedia.MediaName} = 'FINISHING' and {Issueto.IssuetoDate} in DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00) to DateTime (" & ToDate.Year & "," & ToDate.Month & "," & ToDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New DyeingFinishingCostingReport
        ShowReport(MyReport, filterstring, CrystalReportViewer1)



        'End If
    End Sub

    Private Sub ShowByBuyerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowByBuyerButton.Click

        Dim DyeingDate As Date = DyeingDateTimePicker.Text
        Dim ToDate As Date = ToDateTimePicker.Text

        'filterstring = "{Issueto.ProductionDate} = DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00)"

        filterstring = "{DyeingProduction_Final.DyeingDate} in DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00) to DateTime (" & ToDate.Year & "," & ToDate.Month & "," & ToDate.Day & ", 00, 00, 00) And {FinishFabricBooking.BuyerName}='" & BuyerGridLookUpEdit.EditValue & "'"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Daily_Batch_Production_Report
        ShowReport(MyReport, filterstring, CrystalReportViewer1)



    End Sub

    Private Sub ShadeDepthButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShadeDepthButton.Click

        Dim DyeingDate As Date = DyeingDateTimePicker.Text
        Dim ToDate As Date = ToDateTimePicker.Text

        filterstring = "{DyeingProduction_Final.DyeingDate} in DateTime (" & DyeingDate.Year & "," & DyeingDate.Month & "," & DyeingDate.Day & ", 00, 00, 00) to DateTime (" & ToDate.Year & "," & ToDate.Month & "," & ToDate.Day & ", 00, 00, 00)"

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New Shade_Depth_wise_Chemical_And_Dyes_Cost
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
       
    End Sub
End Class