Public Class frmFinishFabricLookupbyBatch

    Private _BatchInformationId As Integer
    Public Property BatchInformationId() As Integer
        Get
            Return _BatchInformationId
        End Get
        Set(ByVal value As Integer)
            _BatchInformationId = value
        End Set
    End Property

    Private _FFBD_ID As Integer
    Public Property FFBD_ID() As Integer
        Get
            Return _FFBD_ID
        End Get
        Set(ByVal value As Integer)
            _FFBD_ID = value
        End Set
    End Property
    Private _BDID As Integer
    Public Property BDId() As Integer
        Get
            Return _BDID
        End Get
        Set(ByVal value As Integer)
            _BDID = value
        End Set
    End Property


    Private Sub frmFinishFabricLookupbyBatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.FinishFabricLookupbyBatchTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricLookupByBatch, Me.BatchInformationId)

    End Sub

    Private Sub FinishFabricLookupByBatchDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles FinishFabricLookupByBatchDataGridView.RowHeaderMouseDoubleClick

        Dim row As FinishFabricOrderLookupDataSet.FinishFabricLookupByBatchRow
        row = CType(CType(Me.FinishFabricLookupByBatchBindingSource.Current, DataRowView).Row, FinishFabricOrderLookupDataSet.FinishFabricLookupByBatchRow)

        Me.FFBD_ID = row.FinishFabricBookingDetailsId
        Me.BDId = row.BatchInformationDetailsId
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()


    End Sub
End Class