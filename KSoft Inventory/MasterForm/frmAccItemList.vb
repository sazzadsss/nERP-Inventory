Public Class frmAccItemList

    Private _ItemID As Integer
    Public Property ItemID() As Integer
        Get
            Return _ItemID
        End Get
        Set(ByVal value As Integer)
            _ItemID = value
        End Set
    End Property

    Private _UnitId As Integer
    Public Property UnitId() As Integer
        Get
            Return _UnitId
        End Get
        Set(ByVal value As Integer)
            _UnitId = value
        End Set
    End Property
    Private _UnitPrice As Double
    Public Property UnitPrice() As Double
        Get
            Return _UnitPrice
        End Get
        Set(ByVal value As Double)
            _UnitPrice = value
        End Set
    End Property



    Private Sub frmAccItemList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BuyerTableAdapter.Fill(Me.BuyerDataSet.Buyer)
        Me.UnitTableAdapter.Fill(Me.UnitDataSet.Unit)
        Me.ItemListTableAdapter.FillByDepartmentId(Me.ItemListDataSet.ItemList, My.Settings.AccDepartmentId)
        Me.ItemListDataSet.ItemList.DepartmentIdColumn.DefaultValue = Val(My.Settings.AccDepartmentId)


    End Sub

    'Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, CType(DepartmentIdToolStripTextBox.Text, Long))
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub AccItemNameTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccItemNameTextEdit.EditValueChanged

        Me.ItemListLookupTableAdapter.FillByAccName(Me.ItemListDataSet.ItemListLookup, My.Settings.AccDepartmentId, AccItemNameTextEdit.Text)
        GenerateFullAccName()
    End Sub

    Private Sub AccItemStyleTextEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccItemStyleTextEdit.EditValueChanged
        Me.ItemListLookupTableAdapter.FillByAccNameAndStyle(Me.ItemListDataSet.ItemListLookup, My.Settings.AccDepartmentId, AccItemNameTextEdit.Text, AccItemStyleTextEdit.Text)
        GenerateFullAccName()
    End Sub

    
    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click


        If ItemListLookupBindingSource.Position > -1 Then

            Dim row As ItemListDataSet.ItemListLookupRow
            row = CType(CType(Me.ItemListLookupBindingSource.Current, DataRowView).Row, ItemListDataSet.ItemListLookupRow)
            Me.ItemID = row.ItemId
            Me.UnitId = row.UnitId
            Me.UnitPrice = row.CurrentPrice

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()

        End If

    End Sub

    Private Sub CnclButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CnclButton.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        Try

            Dim ItemCount As Integer = ReadIntData("Select Count(*) From ItemList Where ItemName='" & ItemNameTextEdit.Text & "'", cnn)

            If AccItemNameTextEdit.Text = String.Empty Then
                MessageBox.Show("Accessories Name is Require")
                Exit Sub
            ElseIf UnitIdGridLookUpEdit.Text = String.Empty Then
                MessageBox.Show("Unit is Require")
                Exit Sub
            ElseIf ItemCount > 0 Then
                MessageBox.Show("[ " & ItemNameTextEdit.Text & " ]  is already exists in Material List", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub

            End If

            'ExecuteQuery("Insert into ItemList(ItemName,AccItemName,AccItemStyle,CurrentPrice,DepartmentId,AccBuyerId,UnitId)values('" & ItemName & "','" & Me.AccItemNameTextEdit.Text & "','" & Me.AccItemStyleTextEdit.Text & "'," & Me.CurrentPriceSpinEdit.Value & "," & My.Settings.AccDepartmentId & "," & Me.AccBuyerIdGridLookUpEdit.EditValue & "," & Me.UnitIdGridLookUpEdit.EditValue & ")", cnn)

            Dim newRow As ItemListDataSet.ItemListRow = Me.ItemListDataSet.ItemList.NewRow()

            newRow.ItemName = ItemNameTextEdit.Text
            newRow.AccItemName = AccItemNameTextEdit.Text
            newRow.AccItemStyle = AccItemStyleTextEdit.Text
            newRow.AccBuyerId = AccBuyerIdGridLookUpEdit.EditValue
            newRow.UnitId = UnitIdGridLookUpEdit.EditValue
            newRow.CurrentPrice = CurrentPriceSpinEdit.EditValue


            Me.ItemListDataSet.ItemList.Rows.Add(newRow)


            Me.Validate()
            Me.ItemListBindingSource.EndEdit()
            Me.ItemListTableAdapter.Update(Me.ItemListDataSet.ItemList)

            'Saveing ..

            If AccItemStyleTextEdit.Text = String.Empty Then
                Me.ItemListLookupTableAdapter.FillByAccName(Me.ItemListDataSet.ItemListLookup, My.Settings.AccDepartmentId, AccItemNameTextEdit.Text)
            Else
                Me.ItemListLookupTableAdapter.FillByAccNameAndStyle(Me.ItemListDataSet.ItemListLookup, My.Settings.AccDepartmentId, AccItemNameTextEdit.Text, AccItemStyleTextEdit.Text)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

       
    End Sub



    Private Sub GenerateFullAccName()

        On Error Resume Next
        Dim ItemName As String = "{0}{1}{2}"
        Dim BCode As String = ReadStringData("Select BuyerCode From Buyer Where BuyerId=" & AccBuyerIdGridLookUpEdit.EditValue, cnn)
        Dim AccName As String = Me.AccItemNameTextEdit.Text
        Dim AccStyle As String = ""

        If Me.AccItemStyleTextEdit.Text <> String.Empty Then
            AccStyle = "\" & Me.AccItemStyleTextEdit.Text
        End If

        If Me.AccBuyerIdGridLookUpEdit.Text <> String.Empty Then
            BCode = "\" & BCode.ToString()
        End If

        ItemName = System.String.Format(ItemName, AccName, AccStyle, BCode)
        ItemNameTextEdit.Text = ItemName

    End Sub

    Private Sub AccBuyerIdGridLookUpEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccBuyerIdGridLookUpEdit.EditValueChanged
        GenerateFullAccName()
    End Sub

    Private Sub AddNewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ItemListBindingSource.AddNew()
    End Sub
End Class