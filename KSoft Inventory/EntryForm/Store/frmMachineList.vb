Public Class frmMachineList

    Private Sub MachineListBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MachineListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MachineListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MachineListDataSet)

    End Sub

    Private Sub frmMachineList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DepartmentDataSet.Department' table. You can move, or remove it, as needed.
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)
        'TODO: This line of code loads data into the 'BranchDataSet.Branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        'TODO: This line of code loads data into the 'BrandDataSet.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.BrandDataSet.Brand)
        'TODO: This line of code loads data into the 'MachineListDataSet.MachineList' table. You can move, or remove it, as needed.
        Me.MachineListTableAdapter.Fill(Me.MachineListDataSet.MachineList)

        If CheckUserRights("Machine List").CanEdit = False Then

            MachineListBindingNavigatorSaveItem.Enabled = False

        End If
    End Sub
End Class