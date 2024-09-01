Imports DevExpress.XtraGrid.Views.Base
Imports System


Public Class frmFinishFabricIssueReceive
    Private _IsGMT As Boolean
    Public Property IsGMT() As Boolean
        Get
            Return _IsGMT
        End Get
        Set(ByVal value As Boolean)
            _IsGMT = value
        End Set
    End Property

    Private Sub FinishFabricReceiveIssueBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FinishFabricReceiveIssueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinishFabricReceiveIssueDataSet)

    End Sub

    Private Sub frmFinishFabricIssueReceive_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CompositionTableAdapter.Fill(Me.CompositionDataSet.Composition)
        Me.KnittingTypeTableAdapter.Fill(Me.KnittingTypeDataSet.KnittingType)
        Me.GarmentsPartTableAdapter.Fill(Me.GarmentsPartDataSet.GarmentsPart)

        Me.FinishFabricLookupNewTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricLookupNew)

        If IsGMT = True Then
            Label2.Text = "Finish Fabric Receive Issue [Apparel]"
        Else
            Label2.Text = "Finish Fabric Receive Issue [Dyeing]"
        End If

        Me.FinishFabricOrderLookupTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricOrderLookup)
        Me.CompanyTableAdapter.Fill(Me.CompanyDataSet.Company)
        Me.BatchLookupTableAdapter.FillByIsReady(Me.BatchLookupDataSet.BatchLookup, True)
        'Me.FinishFabricLookupTableAdapter.Fill(Me.FinishFabricOrderLookupDataSet.FinishFabricLookup)
        Me.BranchTableAdapter.Fill(Me.BranchDataSet.Branch)
        Me.IssueReceiveTypeTableAdapter.Fill(Me.IssueReceiveTypeDataSet.IssueReceiveType)
        Me.SupplierTableAdapter.Fill(Me.SupplierDataSet.Supplier)
        Me.FinishFabricReceiveIssueTableAdapter.Fill(Me.FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssue, Me.IsGMT)

        Me.FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssue.IsGMTStoreColumn.DefaultValue = Me.IsGMT

        DisableFromControl(Me)

        

    End Sub

    'Private Sub ExportLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ExportLinkLabel.LinkClicked

    '    'Dim View As DevExpress.XtraGrid.Views.Grid.GridView = CType(GridControl1.MainView, DevExpress.XtraGrid.Views.Grid.GridView)

    '    'If Not View Is Nothing Then
    '    '    View.OptionsPrint.ExpandAllDetails = True
    '    '    View.ExportToXls("MainViewData.xls")
    '    'End If


    'End Sub

    

    Private Sub ReceiveQuantitySpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveQuantitySpinEdit.EditValueChanged

        If ReceiveQuantitySpinEdit.Value > 0 Then
            IssueQuantitySpinEdit.Value = 0
            'IssueQuantity_CuttingSpinEdit.Value = 0
        End If


    End Sub

    Private Sub IssueQuantitySpinEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueQuantitySpinEdit.EditValueChanged

        If IssueQuantitySpinEdit.Value > 0 Then
            ReceiveQuantitySpinEdit.Value = 0
            'IssueQuantity_CuttingSpinEdit.Value = 0
        End If

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MessageBox.Show("Under Build")

    End Sub


    Private Sub AddToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        On Error Resume Next

        If CopyCheckEdit.Checked Then

            Dim row As FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow
            row = CType(CType(Me.FinishFabricReceiveIssueBindingSource.Current, DataRowView).Row, FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow)

            Dim newRow As FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow = Me.FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssue.NewRow()

            newRow.ChallanNo = row.ChallanNo
            newRow.ChallanDate = row.ChallanDate
            newRow.FinishFabricBookingDetailsId = Nothing
            newRow.ReceiveQuantity = 0
            newRow.IssueQuantity = 0
            newRow.BatchNo = row.BatchNo
            newRow.DyeingDate = row.DyeingDate
            newRow.Remarks = row.Remarks
            newRow.SupplierId = row.SupplierId
            newRow.IssueReceiveTypeId = row.IssueReceiveTypeId
            newRow.LocationReference = row.LocationReference
            newRow.IsImported = row.IsImported
            newRow.LCNo = row.LCNo
            newRow.LCDate = row.LCDate
            newRow.BranchId = row.BranchId
            newRow.RollQuantity = 0
            newRow.GatePassNo = row.GatePassNo
            newRow.VehicleNo = row.VehicleNo

            Me.FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssue.Rows.Add(newRow)

            Me.FinishFabricReceiveIssueBindingSource.MoveLast()


        Else

            Me.FinishFabricReceiveIssueBindingSource.AddNew()

        End If



    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click

        If NewButton.Text = "&Add" Then


            On Error Resume Next


            If CopyCheckEdit.Checked Then

                Dim row As FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow
                row = CType(CType(Me.FinishFabricReceiveIssueBindingSource.Current, DataRowView).Row, FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow)

                Dim newRow As FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow = Me.FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssue.NewRow()

                newRow.ChallanNo = row.ChallanNo
                newRow.ChallanDate = row.ChallanDate
                newRow.FinishFabricBookingDetailsId = Nothing
                newRow.ReceiveQuantity = 0
                newRow.IssueQuantity = 0
                newRow.BatchNo = row.BatchNo
                newRow.DyeingDate = row.DyeingDate
                newRow.Remarks = row.Remarks
                newRow.SupplierId = row.SupplierId
                newRow.IssueReceiveTypeId = row.IssueReceiveTypeId
                newRow.LocationReference = row.LocationReference
                newRow.IsImported = row.IsImported
                newRow.LCNo = row.LCNo
                newRow.LCDate = row.LCDate
                newRow.BranchId = row.BranchId
                newRow.RollQuantity = 0
                newRow.GatePassNo = row.GatePassNo
                newRow.VehicleNo = row.VehicleNo

                Me.FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssue.Rows.Add(newRow)

                Me.FinishFabricReceiveIssueBindingSource.MoveLast()
                Me.BatchNoTextEdit.Focus()


            Else

                Me.FinishFabricReceiveIssueBindingSource.AddNew()
                Me.ChallanNoTextEdit.Focus()

            End If



            NewButton.Text = "&Save"
            NewButton.Image = KSoft_Inventory.My.Resources.Resources.Save
            SaveButton.Enabled = False
            EnableFormControl(Me)

            If CopyCheckEdit.Checked Then
                BatchInformationIdGridLookUpEdit.Focus()

            Else
                ChallanNoTextEdit.Focus()

            End If

        Else



            Me.Validate()
            Me.FinishFabricReceiveIssueBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FinishFabricReceiveIssueDataSet)
            'ExecuteQuery("Update FinishFabricReceiveIssue Set IsClose=" & IsCloseCheckEdit.CheckState & "Where FinishFabricBookingDetailsId=" & FinishFabricBookingDetailsIdGridLookUpEdit.EditValue, cnn)
            'If OrderNoGridLookUpEdit.Visible = True Then
            '    OrderNoGridLookUpEdit.Focus()
            'Else
            '    ProgramNoTextBox.Focus()
            'End If
            NewButton.Text = "&Add"
            SaveButton.Image = KSoft_Inventory.My.Resources.Resources.AddIcon
            SaveButton.Enabled = True
            DisableFromControl(Me)
            MessageBox.Show("Saved Successfully")

        End If

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If SaveButton.Text = "&Edit" Then

            SaveButton.Text = "&Save"
            SaveButton.Image = KSoft_Inventory.My.Resources.Resources.Save
            NewButton.Enabled = False
            EnableFormControl(Me)
            ReceiveQuantitySpinEdit.Focus()


        Else

            Try

                Me.Validate()
                Me.FinishFabricReceiveIssueBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FinishFabricReceiveIssueDataSet)
                'If OrderNoGridLookUpEdit.Visible = True Then
                '    OrderNoGridLookUpEdit.Focus()
                'Else
                '    ProgramNoTextBox.Focus()

                'End If
                'ExecuteQuery("Update FinishFabricReceiveIssue Set IsClose=" & IsCloseCheckEdit.CheckState & "Where FinishFabricBookingDetailsId=" & FinishFabricBookingDetailsIdGridLookUpEdit.EditValue, cnn)

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try


            SaveButton.Text = "&Edit"
            SaveButton.Image = KSoft_Inventory.My.Resources.Resources.Edit
            NewButton.Enabled = True
            DisableFromControl(Me)

        End If

    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click

        If FinishFabricReceiveIssueBindingSource.Position > -1 Then


            MessageBox.Show("Are you sure you want to delete the booking?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If MsgBoxResult.Yes Then

                FinishFabricReceiveIssueBindingSource.RemoveCurrent()

            Else

                Exit Sub

            End If

        Else

            MessageBox.Show("You should delete details of the booking.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' FinishFabricReceiveIssueGridControl.MainView.ExportToXls("C:\Finish Fabric Issue Receive -" & Today() & ".xls")
        PrintableComponentLink1.CreateDocument()
        PrintableComponentLink1.ShowPreview()


    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Me.BatchLookupBindingSource.Position > -1 Then

            Dim BatchInformationId As Integer = ReadIntegerData("Select BatchInformationId From BatchInformation Where BatchNo='" & BatchInformationIdGridLookUpEdit.Text & "'", cnn)

            'MessageBox.Show(ReadStringData("Select BatchNo From BatchInformation where BatchinformationId=" & BatchInformationId, cnn))

            frmFinishFabricLookupbyBatch.BatchInformationId = BatchInformationId
            ShowMaster(frmFinishFabricLookupbyBatch)

            If frmFinishFabricLookupbyBatch.DialogResult = System.Windows.Forms.DialogResult.OK Then

                If FinishFabricReceiveIssueBindingSource.Position > -1 Then

                    Dim row2 As FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow
                    row2 = CType(CType(Me.FinishFabricReceiveIssueBindingSource.Current, DataRowView).Row, FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow)

                    If DBNull.Value.Equals(frmFinishFabricLookupbyBatch.FinishFabricBookingDetailsId) = False Then

                        row2.FinishFabricBookingDetailsId = frmFinishFabricLookupbyBatch.FFBD_ID
                        row2.BatchNo = ReadStringData("Select BatchNo From BatchInformation Where BatchInformationId=" & frmFinishFabricLookupbyBatch.BatchInformationId, cnn)

                        FinishFabricReceiveIssueBindingSource.ResetBindings(True)
                        FinishFabricBookingDetailsIdGridLookUpEdit.Refresh()
                        Me.ReceiveQuantitySpinEdit.Focus()

                    End If

                End If


            End If

        End If


    End Sub


    Private Sub ByProgramNoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ByProgramNoButton.Click

        If FinishFabricReceiveIssueBindingSource.Position > -1 Then

            Dim row As FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow
            row = CType(CType(Me.FinishFabricReceiveIssueBindingSource.Current, DataRowView).Row, FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssueRow)

            If DBNull.Value.Equals(frmFinishFabricLookupbyBatch.FinishFabricBookingDetailsId) = False Then

                row.FinishFabricBookingDetailsId = FinishFabricGridLookUpEdit.EditValue

                FinishFabricReceiveIssueBindingSource.ResetBindings(True)
                FinishFabricBookingDetailsIdGridLookUpEdit.Refresh()

            End If

        End If

    End Sub

    
    'Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click

    '    If SplitContainer1.Panel1Collapsed = True Then

    '        SplitContainer1.Panel1Collapsed = False

    '        Me.FinishFabricBookingDetailsTableAdapter.FillByBookingId(Me.FinishFabricBookingDataSet.FinishFabricBookingDetails, FinishFabricOrderLookupGridLookUpEdit.EditValue)

    '    End If


    'End Sub

   
    Private Sub SelectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)




        If Me.FinishFabricBookingDetailsBindingSource.Position > -1 Then

            For Each drv As DataRowView In Me.FinishFabricBookingDetailsBindingSource.List

                Dim vFFDSelect As Integer

                If drv!FFDSelect = True Then
                    vFFDSelect = 1
                ElseIf drv!FFDSelect = False Then
                    vFFDSelect = 0
                Else
                    vFFDSelect = 0
                End If

                ExecuteQuery("Update FinishFabricReceiveIssue Set IsClose= " & vFFDSelect & " Where FinishFabricBookingDetailsId=" & drv!FinishFabricBookingDetailsId, cnn)
            Next

        End If

        Me.FinishFabricReceiveIssueTableAdapter.Fill(Me.FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssue, Me.IsGMT)
        MessageBox.Show("Updated Successfully", "Close Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub InvertButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For Each drv As DataRowView In Me.FinishFabricBookingDetailsBindingSource.List

            If drv!FFDSelect = True Then
                drv!FFDSelect = False
            ElseIf drv!FFDSelect = False Then
                drv!FFDSelect = True
            End If

        Next

        Me.FinishFabricBookingDetailsBindingSource.ResetBindings(True)

    End Sub

    
    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
        Me.FinishFabricReceiveIssueTableAdapter.FillByProgramNo(Me.FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssue, Me.IsGMT, GridLookUpEdit1.EditValue)
    End Sub

    Private Sub ShowAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowAllButton.Click
        Me.FinishFabricReceiveIssueTableAdapter.Fill(Me.FinishFabricReceiveIssueDataSet.FinishFabricReceiveIssue, Me.IsGMT)
    End Sub
End Class