Public Class frmPhysicalInventory

    Private Sub PhysicalInventoryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhysicalInventoryBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.PhysicalInventoryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.PhysicalInventoryDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

       

    End Sub

    Private Sub frmPhysicalInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)
        Me.PhysicalInventoryDataSet.PhysicalInventory.DepartmentIdColumn.DefaultValue = DepartmentId


        If CheckUserRights("Physical Inventory").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            PhysicalInventoryBindingNavigatorSaveItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False

        ElseIf CheckUserRights("Physical Inventory").CanDelete = False Then
            BindingNavigatorAddNewItem.Enabled = True
            PhysicalInventoryBindingNavigatorSaveItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = False

        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

        Me.PhysicalInventoryTableAdapter.Fill(Me.PhysicalInventoryDataSet.PhysicalInventory, DateTimePicker1.Text, DepartmentId)
        Me.PhysicalInventoryDataSet.PhysicalInventory.InventoryDateColumn.DefaultValue = DateTimePicker1.Text

    End Sub

   
End Class