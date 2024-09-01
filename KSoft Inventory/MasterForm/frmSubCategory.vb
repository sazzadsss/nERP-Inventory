Public Class frmSubCategory

    Private Sub frmSubCategory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CategoryDataSet.Category' table. You can move, or remove it, as needed.

        If Me.ItemListForm = False Then
            Me.SubCategoryTableAdapter.Fill(Me.SubCategoryDataSet.SubCategory, DepartmentId)
            Me.ItemListForm = False
        Else
            Me.SubCategoryTableAdapter.FillByCategoryId(Me.SubCategoryDataSet.SubCategory, varCategoryId)
            Me.ItemListForm = False

        End If

        Me.CategoryTableAdapter1.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentId)
        Me.SubCategoryDataGridView.ReadOnly = True

        Me.SubCategoryDataSet.SubCategory.DepartmentIdColumn.DefaultValue = DepartmentId
        If CheckUserRights("Sub Category").CanEdit = False Then

            NewLinkLabel.Enabled = False
            EditLinkLabel.Enabled = False
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = False

        ElseIf CheckUserRights("Sub Category").CanDelete = False Then
            NewLinkLabel.Enabled = True
            EditLinkLabel.Enabled = True
            DeleteLinkLabel.Enabled = False
            CancelLinkLabel.Enabled = True

        End If
    End Sub
    Private Sub NewLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewLinkLabel.LinkClicked

        If NewLinkLabel.Text = "Add" Then

            SubCategoryBindingSource.AddNew()
            SubCategoryDataGridView.ReadOnly = False
            NewLinkLabel.Text = "Save"

        Else
            Try
                Me.Validate()
                Me.SubCategoryBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.SubCategoryDataSet)
                SubCategoryDataGridView.ReadOnly = True
                NewLinkLabel.Text = "Add"
            Catch ex As Exception
                'MsgBox("Data has already been used !!!" & vbCrLf & ex.Message)
                MsgBox("Data has already been used !!!" & vbCrLf & "You have to delete used data first...")
            End Try
        End If


    End Sub

    Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchTextBox.TextChanged
        On Error Resume Next
        Me.SubCategoryTableAdapter.FillBySubCategory(Me.SubCategoryDataSet.SubCategory, SearchTextBox.Text, DepartmentId)
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked

        If SubCategoryBindingSource.Position > -1 Then
            SubCategoryBindingSource.RemoveCurrent()
            NewLinkLabel.Text = "Save"
        End If

    End Sub

    Private Sub CancelLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles CancelLinkLabel.LinkClicked
        Me.SubCategoryTableAdapter.Fill(Me.SubCategoryDataSet.SubCategory, DepartmentId)
        NewLinkLabel.Text = "Add"
        EditLinkLabel.Text = "Edit"
    End Sub

    Private Sub SubCategoryDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub EditLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles EditLinkLabel.LinkClicked
        If EditLinkLabel.Text = "Edit" Then
            SubCategoryDataGridView.ReadOnly = False
            EditLinkLabel.Text = "Update"
        Else

            Me.Validate()
            Me.SubCategoryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.SubCategoryDataSet)
            SubCategoryDataGridView.ReadOnly = True
            NewLinkLabel.Text = "Add"
            SubCategoryDataGridView.ReadOnly = True
            EditLinkLabel.Text = "Edit"
        End If
    End Sub


    Private Sub SubCategoryDataGridView_RowHeaderMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles SubCategoryDataGridView.RowHeaderMouseDoubleClick

        Dim row As SubCategoryDataSet.SubCategoryRow
        row = CType(CType(Me.SubCategoryBindingSource.Current, DataRowView).Row, SubCategoryDataSet.SubCategoryRow)

        Me.SubCategoryId = row.SubCategoryId

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()



    End Sub


    Private _SubCategoryid As Integer
    Public Property SubCategoryId() As Integer
        Get
            Return _SubCategoryid
        End Get
        Set(ByVal value As Integer)
            _SubCategoryid = value
        End Set
    End Property

    Private _varCategoryId As Integer
    Public Property varCategoryId() As Integer
        Get
            Return _varCategoryId
        End Get
        Set(ByVal value As Integer)
            _varCategoryId = value
        End Set
    End Property
    Private _ItemListForm As Boolean
    Public Property ItemListForm() As Boolean
        Get
            Return _ItemListForm
        End Get
        Set(ByVal value As Boolean)
            _ItemListForm = value
        End Set
    End Property

End Class