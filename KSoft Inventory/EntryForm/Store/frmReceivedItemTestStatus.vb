Public Class frmReceivedItemTestStatus

    Private Sub frmReceivedItemTestStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.IssueReceiveTypeTableAdapter.Fill(Me.IssueReceiveTypeDataSet.IssueReceiveType)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)


        If CheckUserRights("Received Item Test Status").CanEdit = False Then

            'Commented during Migration
            CmdSave.Enabled = False

        End If



    End Sub

    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click

        'Saving
        Me.Validate()
        Me.ReceiveBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReceiveDataSet)

        MessageBox.Show("Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    
    Private Sub ItemGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemGridLookUpEdit.EditValueChanged

        'Only DepartmentId 25 show or filtering two department (Dyeing Chamical Store and LAB), Imrul Kaesh, 10-07-2013  
        'If DepartmentId = 25 Then
        '    Me.ReceiveTableAdapter.FillByDepartment25And16(Me.ReceiveDataSet.Receive, 15, ItemGridLookUpEdit.EditValue, 25)

        'Else
        '    'Item Wise Filter
        '    Me.ReceiveTableAdapter.FillByItemId(Me.ReceiveDataSet.Receive, ItemGridLookUpEdit.EditValue, DepartmentId)

        'End If
        ''End Imrul

    End Sub

    Private Sub DepartmentGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentGridLookUpEdit.EditValueChanged

        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentGridLookUpEdit.EditValue)
        Me.LCListTableAdapter.Fill(Me.OpeningLCDataSet.LCList, DepartmentId)
        Me.PIListTableAdapter.FillByDepartmentId(Me.OpeningLCDataSet.PIList, DepartmentGridLookUpEdit.EditValue)
        Me.ReceiveTableAdapter.FillByDepartmentId(Me.ReceiveDataSet.Receive, DepartmentGridLookUpEdit.EditValue)

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click

        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.IssueReceiveTypeTableAdapter.Fill(Me.IssueReceiveTypeDataSet.IssueReceiveType)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)

        'Me.ReceiveTableAdapter.FillByItemId(Me.ReceiveDataSet.Receive, ItemGridLookUpEdit.EditValue)


    End Sub

    
    Private Sub ExportToExcel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ExportToExcel.LinkClicked
        'Exporting this Grid any Data, 04-07-2013
        Dim objSaveFileDialog As New SaveFileDialog

        'Set the Save dialog properties
        With objSaveFileDialog
            .DefaultExt = "xls"
            .FileName = "Received Item Test Status-" & Today
            .Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File Dialog"

        End With

        'Show the Save dialog and if the user clicks the Save button,
        If objSaveFileDialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Try
                ReceiveItemTestStatusGridControl.MainView.ExportToXls(objSaveFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show(ex.Message & vbNewLine & "The mentioned file is already open. Plz,Close it", "Open file", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

        'End Imrul Kaesh
    End Sub

End Class