Public Class frmMaintenanceComplainSystem
    Private _ForAll As Boolean
    Dim _RequestFor As String
    Public Property ForAll() As Boolean
        Get
            Return _ForAll
        End Get
        Set(ByVal value As Boolean)
            _ForAll = value
        End Set
    End Property
    Public Property RequestFor() As String
        Get
            Return _RequestFor
        End Get
        Set(ByVal value As String)
            _RequestFor = value
        End Set
    End Property

    Private Sub MaintenanceComplainBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaintenanceComplainBindingNavigatorSaveItem.Click

        Try

            Me.Validate()
            Me.MaintenanceComplainBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MaintenanceComplainDataSet)
            MessageBox.Show("Saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

       

    End Sub

    Private Sub frmMaintenanceComplainSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        If ForAll = True Then

            If Me.RequestForLabel.Text = "Maimtenence" Then
                Me.MaintenanceComplainTableAdapter.FillByRequest(Me.MaintenanceComplainDataSet.MaintenanceComplain, Me.RequestForLabel.Text)


                If CheckUserRights("Maintenance Request [All]").CanEdit = False Then

                    BindingNavigatorAddNewItem.Enabled = False
                    MaintenanceComplainBindingNavigatorSaveItem.Enabled = False
                    DeleteToolStripButton.Enabled = False

                ElseIf CheckUserRights("Maintenance Request [All]").CanDelete = False Then
                    BindingNavigatorAddNewItem.Enabled = True
                    MaintenanceComplainBindingNavigatorSaveItem.Enabled = True
                    DeleteToolStripButton.Enabled = False

                End If

            Else
                Me.MaintenanceComplainTableAdapter.FillByRequest(Me.MaintenanceComplainDataSet.MaintenanceComplain, Me.RequestForLabel.Text)


                If CheckUserRights("IT Request [All]").CanEdit = False Then

                    BindingNavigatorAddNewItem.Enabled = False
                    MaintenanceComplainBindingNavigatorSaveItem.Enabled = False
                    DeleteToolStripButton.Enabled = False

                ElseIf CheckUserRights("IT Request [All]").CanDelete = False Then
                    BindingNavigatorAddNewItem.Enabled = True
                    MaintenanceComplainBindingNavigatorSaveItem.Enabled = True
                    DeleteToolStripButton.Enabled = False

                End If
            End If

            Dim flag As Boolean = True

            With GridView1

                .Columns("ExpectedResolvedDate").OptionsColumn.AllowEdit = flag
                .Columns("ActualResolvedDate").OptionsColumn.AllowEdit = flag
                .Columns("ResponsiblePerson").OptionsColumn.AllowEdit = flag

                .Columns("Status").OptionsColumn.AllowEdit = flag
                .Columns("CauseOfDelay").OptionsColumn.AllowEdit = flag
                .Columns("ComplainDrop").OptionsColumn.AllowEdit = flag
                .Columns("CauseOfDrop").OptionsColumn.AllowEdit = flag


                .Columns("DepartmentId").OptionsColumn.AllowEdit = Not flag
                .Columns("Location").OptionsColumn.AllowEdit = Not flag
                .Columns("Category").OptionsColumn.AllowEdit = Not flag
                .Columns("Description").OptionsColumn.AllowEdit = Not flag
                .Columns("Machine").OptionsColumn.AllowEdit = Not flag
                .Columns("ComplainDate").OptionsColumn.AllowEdit = Not flag
                .Columns("CommentsOnStatus").OptionsColumn.AllowEdit = Not flag
                .Columns("Priority").OptionsColumn.AllowEdit = Not flag

            End With

            DeleteToolStripButton.Enabled = False




        Else
            If Me.RequestForLabel.Text = "Maimtenence" Then
                Me.MaintenanceComplainTableAdapter.FillByRequestAndDepartmentId(Me.MaintenanceComplainDataSet.MaintenanceComplain, DepartmentId, Me.RequestForLabel.Text)

                If CheckUserRights("Maintenance Request [Department]").CanEdit = False Then

                    BindingNavigatorAddNewItem.Enabled = False
                    MaintenanceComplainBindingNavigatorSaveItem.Enabled = False
                    DeleteToolStripButton.Enabled = False

                ElseIf CheckUserRights("Maintenance Request [Department]").CanDelete = False Then
                    BindingNavigatorAddNewItem.Enabled = True
                    MaintenanceComplainBindingNavigatorSaveItem.Enabled = True
                    DeleteToolStripButton.Enabled = False

                End If

            Else
                Me.MaintenanceComplainTableAdapter.FillByRequestAndDepartmentId(Me.MaintenanceComplainDataSet.MaintenanceComplain, DepartmentId, Me.RequestForLabel.Text)

                If CheckUserRights("IT Request [Department]").CanEdit = False Then

                    BindingNavigatorAddNewItem.Enabled = False
                    MaintenanceComplainBindingNavigatorSaveItem.Enabled = False
                    DeleteToolStripButton.Enabled = False

                ElseIf CheckUserRights("IT Request [Department]").CanDelete = False Then
                    BindingNavigatorAddNewItem.Enabled = True
                    MaintenanceComplainBindingNavigatorSaveItem.Enabled = True
                    DeleteToolStripButton.Enabled = False

                End If
            End If
           
            Dim flag As Boolean = False

            With GridView1

                .Columns("ExpectedResolvedDate").OptionsColumn.AllowEdit = flag
                .Columns("ActualResolvedDate").OptionsColumn.AllowEdit = flag
                .Columns("ResponsiblePerson").OptionsColumn.AllowEdit = flag
                .Columns("Status").OptionsColumn.AllowEdit = flag
                .Columns("CauseOfDelay").OptionsColumn.AllowEdit = flag
                .Columns("ComplainDrop").OptionsColumn.AllowEdit = flag
                .Columns("CauseOfDrop").OptionsColumn.AllowEdit = flag

                .Columns("DepartmentId").OptionsColumn.AllowEdit = Not flag
                .Columns("Location").OptionsColumn.AllowEdit = Not flag
                .Columns("Category").OptionsColumn.AllowEdit = Not flag
                .Columns("Description").OptionsColumn.AllowEdit = Not flag
                .Columns("Machine").OptionsColumn.AllowEdit = Not flag
                .Columns("ComplainDate").OptionsColumn.AllowEdit = Not flag
                .Columns("CommentsOnStatus").OptionsColumn.AllowEdit = Not flag
                .Columns("Priority").OptionsColumn.AllowEdit = Not flag


            End With

            DeleteToolStripButton.Enabled = True


        End If

        Me.MaintenanceComplainDataSet.MaintenanceComplain.DepartmentIdColumn.DefaultValue = DepartmentId
        Me.MaintenanceComplainDataSet.MaintenanceComplain.UserIdColumn.DefaultValue = UserId
        Me.MaintenanceComplainDataSet.MaintenanceComplain.ModifiedDateColumn.DefaultValue = Now
        Me.MaintenanceComplainDataSet.MaintenanceComplain.RequestForColumn.DefaultValue = RequestForLabel.Text


    End Sub

    Private Sub GridView1_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView1.RowCellStyle

        

        If e.Column.Caption = "Status" Then

            If DBNull.Value.Equals(e.CellValue) = False Then

                If e.CellValue = "Running" Then
                    e.Appearance.BackColor = Color.LightGreen
                    e.Appearance.ForeColor = Color.Black
                ElseIf e.CellValue = "Completed" Then
                    e.Appearance.BackColor = Color.LightCyan
                    e.Appearance.ForeColor = Color.Black
                ElseIf e.CellValue = "Pending" Then
                    e.Appearance.BackColor = Color.LightYellow
                    e.Appearance.ForeColor = Color.Black
                End If

            End If

        End If

    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged

        If MaintenanceComplainBindingSource.Position > -1 Then

            Dim row As MaintenanceComplainDataSet.MaintenanceComplainRow
            row = CType(CType(Me.MaintenanceComplainBindingSource.Current, DataRowView).Row, MaintenanceComplainDataSet.MaintenanceComplainRow)

            'row.UserId = UserId
            'row.ModifiedOn = Now

            If e.Column.Caption = "Actual Resolved Date" Then

                If e.Value.ToString <> String.Empty AndAlso row.IsExpectedResolvedDateNull = False Then

                    row.Status = "Completed"

                    Dim MailSubject As String = "Maintenance Complain ID : " & row.ComplainId.ToString & " has been resolved."
                    Dim MailBody As String = "Machine : " & row.Machine & "\*\ Description : " & row.Description & "\*\ Actual Resolved Date: " & row.ActualResolvedDate
                    Dim MailAddress As String = ReadStringData("Select EmailAddress From Department Where DepartmentId=" & DepartmentId, cnn)

                    SendSMTP("rokonuzzaman@echotexbd.com", "Maintenance Department", "mahmud@echotexbd.com", "mahmud", "rokonuzzaman@echotexbd.com", "Maintenance Department", MailSubject, MailBody, "", "")
                    SendSMTP("rokonuzzaman@echotexbd.com", "Maintenance Department", MailAddress, "mahmud", "rokonuzzaman@echotexbd.com", "Maintenance Department", MailSubject, MailBody, "", "")


                ElseIf e.Value.ToString = String.Empty Or row.IsExpectedResolvedDateNull Then

                    row.Status = "Pending"

                End If

                ' ElseIf e.Column.Caption = "Complain Date" Then


            End If

        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        PrintableComponentLink2.CreateDocument()
        PrintableComponentLink2.ShowPreview()

    End Sub

    

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged

        Select Case ToolStripComboBox1.Text

            Case "--ALL--"
                Me.MaintenanceComplainBindingSource.Filter = ""
            Case "Pending"
                Me.MaintenanceComplainBindingSource.Filter = "Status='Pending'"
            Case "Running"
                Me.MaintenanceComplainBindingSource.Filter = "Status='Running'"
            Case "Completed"
                Me.MaintenanceComplainBindingSource.Filter = "Status='Completed'"

        End Select
    End Sub

    Private Sub DeleteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripButton.Click

        If MaintenanceComplainBindingSource.Position > -1 Then

            Dim row As MaintenanceComplainDataSet.MaintenanceComplainRow
            row = CType(CType(Me.MaintenanceComplainBindingSource.Current, DataRowView).Row, MaintenanceComplainDataSet.MaintenanceComplainRow)

            If row.IsExpectedResolvedDateNull Then

                Me.MaintenanceComplainBindingSource.RemoveCurrent()

                MessageBox.Show("To remove finally you have to save", "Removing", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                MessageBox.Show("You can't remove , you have to remove EXPECTED RESOLVED DATE.", "Removing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If


        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ShowForm(frmSupportComplain)
    End Sub
End Class