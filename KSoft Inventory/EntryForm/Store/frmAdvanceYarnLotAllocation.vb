Imports System

Public Class frmAdvanceYarnLotAllocation
    Private Sub Save()
        Me.Validate()
        Me.AdvanceYarnLotAllocationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AdvanceYarnLotAllocationDataSet)
    End Sub

    Private Sub AdvanceYarnLotAllocationBindingNavigatorSaveItem_Click(sender As Object, e As System.EventArgs) Handles AdvanceYarnLotAllocationBindingNavigatorSaveItem.Click
        Save()
    End Sub

    Private Sub frmAdvanceYarnLotAllocation_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        'Me.LCNoLookUpFromPIIdTableAdapter.FillByPIId(Me.PILookUpDataSet.LCNoLookUpFromPIId)
        Me.PILookUpTableAdapter.FillByDeparmentId(Me.PILookUpDataSet.PILookUp, YarnStoreId)
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, YarnStoreId)
        Me.FinishFabricOrderLookupTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricOrderLookup)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)

    End Sub

    Private Sub AddButton_Click(sender As Object, e As System.EventArgs) Handles AddButton.Click


        Dim newRow = CType(Me.AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocation.NewRow(), AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocationRow)
        newRow.ItemId = ItemIdLookUpEdit.EditValue
        newRow.LotNo = LotNoGridLookUpEdit.Text
        newRow.PIId = PIIdGridLookUpEdit.EditValue
        Dim SupId As Integer = ReadIntegerData("Select SupplierId From LCList Where LCId=(Select LCId From PIList Where PIId=" & PIIdGridLookUpEdit.EditValue & ")", cnn)
        newRow.SupplierId = SupId
        newRow.FinishFabricBookingId = ProgramNoLookUpEdit.EditValue
        newRow.AllocateQty = Val(AllocateQuantityTextEdit.Text)
        Me.AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocation.Rows.Add(newRow)


        Me.AdvanceYarnLotAllocationBindingSource.MoveLast()


    End Sub

    Private Sub ShowButton_Click(sender As Object, e As System.EventArgs) Handles ShowButton.Click

        Try

            If String.IsNullOrEmpty(ItemIdLookUpEdit.Text) And String.IsNullOrEmpty(LotNoGridLookUpEdit.Text) Then
                Me.AdvanceYarnLotAllocationTableAdapter.FillByItemId(Me.AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocation, ItemIdLookUpEdit.EditValue)
            ElseIf String.IsNullOrEmpty(LotNoGridLookUpEdit.Text) Then
                Me.AdvanceYarnLotAllocationTableAdapter.FillByItemIdAndPIId(Me.AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocation, ItemIdLookUpEdit.EditValue, PIIdGridLookUpEdit.EditValue)
            Else
                Me.AdvanceYarnLotAllocationTableAdapter.FillByItemIdAndPIIdAndLotNo(Me.AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocation, ItemIdLookUpEdit.EditValue, LotNoGridLookUpEdit.EditValue, PIIdGridLookUpEdit.EditValue)
            End If

            Dim TTLRcvQty As Integer = ReadData("Select Sum(ReceiveQuantity) From Receive Where PIId=" & PIIdGridLookUpEdit.EditValue, cnn)
            Dim TTLIssueQty As Integer = ReadData("Select Sum(IssueQuantity) From Issue Where PIId=" & PIIdGridLookUpEdit.EditValue, cnn)
            Dim TTLAllocateQty As Integer = ReadData("Select Sum(AllocateQty) From AdvanceYarnLotAllocation Where PIId=" & PIIdGridLookUpEdit.EditValue, cnn)

            ReceiveQtyLabel.Text = TTLRcvQty.ToString()
            IssueQtyLabel.Text = TTLIssueQty.ToString()
            TTLAllocateLabel.Text = TTLAllocateQty

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub ShowAllButton_Click(sender As Object, e As EventArgs) Handles ShowAllButton.Click
        Me.AdvanceYarnLotAllocationTableAdapter.Fill(Me.AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocation)
    End Sub

    Private Sub TransferButton_Click(sender As Object, e As EventArgs) Handles TransferButton.Click

        'Dim row As AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocationRow
        'row = CType(CType(Me.AdvanceYarnLotAllocationBindingSource.Current, DataRowView).Row, AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocationRow)
        'row.ItemId = TransYarnNameLookUpEdit.EditValue
        'row.LotNo = TransLotNoTextEdit.Text
        'row.SupplierId = TransBrandLookUpEdit.EditValue

        'Save()
        'AdvanceYarnLotAllocationBindingSource.ResetCurrentItem()

        'Me.AdvanceYarnLotAllocationTableAdapter.FillByItemIdAndSupplierIdAndLotNo(Me.AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocation, row.ItemId, TransBrandLookUpEdit.EditValue, TransLotNoTextEdit.Text)

    End Sub

    Private Sub TransShowButton_Click(sender As Object, e As EventArgs) Handles TransShowButton.Click
        Try
            Me.AdvanceYarnLotAllocationTableAdapter.FillByItemIdAndPIIdAndLotNo(Me.AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocation, TransYarnNameLookUpEdit.EditValue, TransBrandLookUpEdit.EditValue, TransLotNoTextEdit.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AdvanceYarnLotAllocationBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles AdvanceYarnLotAllocationBindingSource.CurrentChanged
        On Error Resume Next
        Dim row As AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocationRow
        row = CType(CType(Me.AdvanceYarnLotAllocationBindingSource.Current, DataRowView).Row, AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocationRow)

        Me.TransYarnNameLookUpEdit.EditValue = row.ItemId
    End Sub

    Private Sub YarnNameLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles ItemIdLookUpEdit.EditValueChanged

        On Error Resume Next

        Me.LotAndItemwiseBalanceTableAdapter.Fill(Me.LotAndItemBalanceDataSet.LotAndItemwiseBalance, ItemIdLookUpEdit.EditValue)
        Me.PIAndItemwiseBalanceTableAdapter.Fill(Me.PIAnditemwiseBalanceDataSet.PIAndItemwiseBalance, ItemIdLookUpEdit.EditValue, LotNoGridLookUpEdit.EditValue, YarnStoreId)

    End Sub

    Private Sub LotNoGridLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles LotNoGridLookUpEdit.EditValueChanged

        On Error Resume Next

        Me.PIAndItemwiseBalanceTableAdapter.Fill(Me.PIAnditemwiseBalanceDataSet.PIAndItemwiseBalance, ItemIdLookUpEdit.EditValue, LotNoGridLookUpEdit.EditValue, YarnStoreId)

    End Sub

    Private Sub ShowUpButton_Click(sender As Object, e As EventArgs) Handles ShowUpButton.Click

        If AdvanceYarnLotAllocationBindingSource.Position > -1 Then

            Dim row As AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocationRow
            row = CType(CType(Me.AdvanceYarnLotAllocationBindingSource.Current, DataRowView).Row, AdvanceYarnLotAllocationDataSet.AdvanceYarnLotAllocationRow)

            ItemIdLookUpEdit.EditValue = row.ItemId
            LotNoGridLookUpEdit.EditValue = row.LotNo
            PIIdGridLookUpEdit.EditValue = row.PIId
            ProgramNoLookUpEdit.EditValue = row.FinishFabricBookingId
            AllocateQuantityTextEdit.Text = row.AllocateQty


            Dim TTLRcvQty As Integer = ReadData("Select Sum(ReceiveQuantity) From Receive Where PIId=" & PIIdGridLookUpEdit.EditValue, cnn)
            Dim TTLIssueQty As Integer = ReadData("Select Sum(IssueQuantity) From Issue Where PIId=" & PIIdGridLookUpEdit.EditValue, cnn)
            Dim TTLAllocateQty As Integer = ReadData("Select Sum(AllocateQty) From AdvanceYarnLotAllocation Where PIId=" & PIIdGridLookUpEdit.EditValue, cnn)

            ReceiveQtyLabel.Text = TTLRcvQty.ToString()
            IssueQtyLabel.Text = TTLIssueQty.ToString()
            TTLAllocateLabel.Text = TTLAllocateQty



        End If


    End Sub
End Class