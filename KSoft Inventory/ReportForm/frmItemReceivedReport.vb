Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frmItemReceivedReport
    Dim filterstring As String = ""
    Dim recordcount As Integer = 0
    Private Sub ReceiveByDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowButton.Click
        filterstring = "{Receive.ReceiveDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Supplier.SupplierId} = " & SupplierGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

    End Sub

    Private Sub frmItemReceivedReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SupplierDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        'TODO: This line of code loads data into the 'DepartmentDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)

    End Sub

    Private Sub SupplierGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles SupplierGridLookUpEdit.EditValueChanged

    End Sub

    Private Sub DepartmentComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepartmentComboBox.SelectedIndexChanged
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentComboBox.SelectedValue)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        filterstring = "{Receive.ReceiveDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Itemlist.ItemId} = " & ItemLookupGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        filterstring = "{Receive.ReceiveDate} in DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & ",00,00,00) to DateTime (" & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23, 59, 59) AND {ItemList.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Itemlist.ItemId} = " & ItemLookupGridLookUpEdit.EditValue & " And {Supplier.SupplierId} = " & SupplierGridLookUpEdit.EditValue

        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New ReceiveDetailsByDate
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
    End Sub
End Class