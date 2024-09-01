Public Class frmMRRRemarks

    Private Sub frmMRRRemarks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.MRRRemarksTableAdapter.Fill(Me.MRRRemarksDataSet.MRRRemarks, DepartmentId)
        Me.MRRLookupTableAdapter.Fill(Me.MRRLookupDataSet.MRRLookup, DepartmentId)
        Me.MRRRemarksDataSet.MRRRemarks.DepartmentIdColumn.DefaultValue = DepartmentId

        If CheckUserRights("MRRRemarks").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            MRRRemarksBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("MRRRemarks").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            MRRRemarksBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If
    End Sub

    Private Sub MRRRemarksBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MRRRemarksBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MRRRemarksBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MRRRemarksDataSet)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

   
End Class