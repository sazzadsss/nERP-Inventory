Public Class frmYarnType
    Private _YarnTypeId As Integer
    Public Property YarnTypeId() As Integer
        Get
            Return _YarnTypeId
        End Get
        Set(ByVal value As Integer)
            _YarnTypeId = value
        End Set
    End Property

    Private Sub YarnTypeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YarnTypeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.YarnTypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.YarnTypeDataSet)

    End Sub

    Private Sub frmYarnType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YarnTypeDataSet.YarnType' table. You can move, or remove it, as needed.
        Me.YarnTypeTableAdapter.Fill(Me.YarnTypeDataSet.YarnType)

        If CheckUserRights("Yarn Type").CanEdit = False Then

            BindingNavigatorAddNewItem.Enabled = False
            YarnTypeBindingNavigatorSaveItem.Enabled = False
 

        End If
    End Sub

    Private Sub YarnTypeDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles YarnTypeDataGridView.CellContentClick

    End Sub

    Private Sub YarnTypeDataGridView_RowHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles YarnTypeDataGridView.RowHeaderMouseDoubleClick

        Dim row As YarnTypeDataSet.YarnTypeRow
        row = CType(CType(Me.YarnTypeBindingSource.Current, DataRowView).Row, YarnTypeDataSet.YarnTypeRow)

        Me.YarnTypeId = row.YarnTypeId

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()


    End Sub
End Class