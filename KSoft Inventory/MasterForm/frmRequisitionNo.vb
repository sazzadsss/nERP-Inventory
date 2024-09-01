Public Class frmRequisitionNo

    Private _RqNo As String
    Public Property RqNo() As String
        Get
            Return _RqNo
        End Get
        Set(ByVal value As String)
            _RqNo = value
        End Set
    End Property

    Private Sub RequisitionFloorLookupBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Validate()
        Me.RequisitionFloorLookupBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RequisitionFloorLookupDataSet)

    End Sub

    Private Sub frmRequisitionNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'YarnRequsitionDataSet.YarnRequisition' table. You can move, or remove it, as needed.
        Me.YarnRequisitionTableAdapter.Fill(Me.YarnRequsitionDataSet.YarnRequisition)

        If DepartmentId = YarnStoreId Then
            Me.RequisitionFloorLookupGridControl.Hide()
            Me.YarnRequisitionGridControl.Show()
            Me.YarnRequisitionTableAdapter.Fill(Me.YarnRequsitionDataSet.YarnRequisition)
        Else
            Me.YarnRequisitionGridControl.Hide()
            Me.RequisitionFloorLookupGridControl.Show()
            Me.RequisitionFloorLookupTableAdapter.FillByItemDepartmentId(Me.RequisitionFloorLookupDataSet.RequisitionFloorLookup, DepartmentId)
        End If

    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        If DepartmentId = YarnStoreId Then
            Dim row As YarnRequsitionDataSet.YarnRequisitionRow
            row = CType(CType(Me.YarnRequisitionBindingSource.Current, DataRowView).Row, YarnRequsitionDataSet.YarnRequisitionRow)
            Me.RqNo = row.YarnRequisitionNo
        Else
            Dim row As RequisitionFloorLookupDataSet.RequisitionFloorLookupRow
            row = CType(CType(Me.RequisitionFloorLookupBindingSource.Current, DataRowView).Row, RequisitionFloorLookupDataSet.RequisitionFloorLookupRow)
            Me.RqNo = row.RequisitionNo
        End If

    End Sub
End Class