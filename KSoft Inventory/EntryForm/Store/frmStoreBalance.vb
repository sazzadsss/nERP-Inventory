Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data
Imports System.Threading

Public Class frmStoreBalance
    Dim t As Thread
    Dim CancelFlag As Boolean = False
    Dim RecordCount As Decimal = 0
    Dim cnn As String = My.Settings.KSoft_InventoryConnectionString
    Dim varDepartmentId As Integer
    Dim VR1Flag As Boolean = False
    Dim VR2Flag As Boolean = False
    Dim filterstring As String = ""

    Private Sub frmStoreBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CategoryDataSet.Category' table. You can move, or remove it, as needed.

        'Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentComboBox.SelectedValue)

        Me.DepartmentTableAdapter.Fill(Me.DepartmentDataSet.Department)

        Dim Index As Integer
        Index = DepartmentBindingSource.Find("DepartmentId", DepartmentId)
        DepartmentBindingSource.Position = Index

        If UserLevel = 1 Then
            DepartmentComboBox.Enabled = True
        End If

       
        Dim StartMonth As Date = DateSerial(Year(Today), Month(Today), 1)
        Dim EndMonth As Date = DateSerial(Year(Today), Month(Today) + 1, 0)

        FromDateDateTimePicker.Value = StartMonth
        ToDateDateTimePicker.Value = EndMonth


        'Load Issued Date


        'Dim connection As New SqlConnection(cnn)
        'connection.Open()
        'Dim cmd As SqlCommand = New SqlCommand("Select ItemName From ItemList", connection)
        'Dim reader As SqlDataReader = cmd.ExecuteReader()
        'Dim list As New AutoCompleteStringCollection

        'While reader.Read
        '    list.Add(reader.Item("ItemName"))
        'End While

        'SearchTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'SearchTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        'SearchTextBox.AutoCompleteCustomSource = list



        '========================



    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartProcess.Click



    '    Me.Generate()


    '    't = New Thread(AddressOf Me.Generate)
    '    't.Start()

    'End Sub

    '===================================
    'QueryDB("SELECT * FROM main WHERE MAC = '" & 11:22:33:44:55:66& "'", conn))

    'Function QueryDB(ByVal sql As String, ByVal conn As SqlConnection)
    '    QueryDB = 0
    '    Dim cmd As SqlCommand = Nothing
    '    Dim dr As SqlDataReader = Nothing
    '    cmd = New SqlCommand(sql, conn)
    '    dr = cmd.ExecuteReader(CommandBehavior.SingleResult)
    '    dr.Read() ' Read one row from the table
    '    QueryDB = dr(0)
    'End Function
    '====================================


    Function ReadBalanceValue(ByVal queryString As String, ByVal connectionString As String) As Decimal
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryString, connection)
            Dim BalanceValue As Decimal
            command.Connection.Open()
            command.ExecuteNonQuery()

            Dim reader As SqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                'Do While reader.Read()
                '    Console.WriteLine(reader.GetInt32(0) _
                '      & vbTab & reader.GetString(1))
                'Loop

                If reader.IsDBNull(0) Then
                    BalanceValue = 0

                Else
                    BalanceValue = reader.GetDecimal(0)
                End If



                'Else
                '    PreviousReceived = 0

                '    MessageBox.Show("No rows found.")
            End If

            reader.Close()

            Return BalanceValue

        End Using

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Get ready.
        varDepartmentId = DepartmentComboBox.SelectedValue
        ExecuteQuery("Update Issueto Set Auto=0 Where Auto is null", cnn)

        '
        GeneratingLabel.Text = "Working..."
        '

        'btnStartProcess.Enabled = False

        btnCancel.Enabled = True
        PrgLongProcess.Value = 0

        ' Start the worker.

        bgrLongProcess.WorkerReportsProgress = True
        bgrLongProcess.WorkerSupportsCancellation = True
        bgrLongProcess.RunWorkerAsync()


    End Sub

    'Private Sub BalanceViewDataGridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Me.BalanceViewDataGridView.CurrentRow.Selected = True
    'End Sub



    'Private Sub ItemListComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemListComboBox.SelectedIndexChanged

    '    On Error Resume Next

    '    Dim Index As Integer

    '    Index = BalanceViewBindingSource.Find("ItemName", ItemListComboBox.Text)

    '    If Index > -1 Then

    '        BalanceViewBindingSource.Position = Index
    '        BalanceViewDataGridView.CurrentRow.Selected = True
    '        ErrorProvider1.Clear()

    '    Else

    '        ErrorProvider1.SetError(ItemListComboBox, "Data Not Found")

    '    End If
    'End Sub

    Private Sub BalanceViewDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    'Private Sub BalanceViewDataGridView_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)

    '    If BalanceViewDataGridView.CurrentCell IsNot Nothing Then
    '        If e.RowIndex = BalanceViewDataGridView.CurrentCell.RowIndex And e.ColumnIndex = BalanceViewDataGridView.CurrentCell.ColumnIndex Then
    '            e.CellStyle.SelectionBackColor = Color.Chocolate
    '        Else
    '            e.CellStyle.SelectionBackColor = BalanceViewDataGridView.DefaultCellStyle.SelectionBackColor
    '        End If
    '    End If

    'End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    'Private Sub SearchTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    On Error Resume Next

    '    Dim Index As Integer

    '    Index = BalanceViewBindingSource.Find("ItemName", SearchTextBox.Text)

    '    If Index > -1 Then

    '        BalanceViewBindingSource.Position = Index
    '        BalanceViewDataGridView.CurrentRow.Selected = True
    '        ErrorProvider1.Clear()

    '    Else

    '        ErrorProvider1.SetError(SearchTextBox, "Data Not Found")

    '    End If
    'End Sub

    Private Sub DepartmentComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentComboBox.SelectedIndexChanged
        On Error Resume Next
        Me.BalanceDataSet.Balance.DepartmentIdColumn.DefaultValue = DepartmentComboBox.SelectedValue
        Me.BalanceViewTableAdapter.FillByDepartmentId(Me.BalanceViewDataSet.BalanceView, DepartmentComboBox.SelectedValue)
        Me.ItemListTableAdapter.FillByDepartmentAndDiscontinue(Me.ItemListDataSet.ItemList, DepartmentComboBox.SelectedValue, False)
        Me.CategoryTableAdapter.FillByDepatmentId(Me.CategoryDataSet.Category, DepartmentComboBox.SelectedValue)

    End Sub

    'Private Sub BalanceViewDataGridView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    '    If e.KeyCode = Keys.Return Then
    '        Dim cur_cell As DataGridViewCell = _
    '            BalanceViewDataGridView.CurrentCell
    '        Dim col As Integer = cur_cell.ColumnIndex
    '        col = (col + 1) Mod BalanceViewDataGridView.Columns.Count
    '        cur_cell = BalanceViewDataGridView.CurrentRow.Cells(col)
    '        BalanceViewDataGridView.CurrentCell = cur_cell

    '        e.Handled = True
    '    End If

    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Get ready.
        varDepartmentId = DepartmentComboBox.SelectedValue
        ExecuteQuery("Update Issueto Set Auto=0 Where Auto is null", cnn)


        GeneratingLabel.Text = "Working..."
        


        btnStartProcess.Enabled = False

        btnCancel.Enabled = True
        PrgLongProcess.Value = 0

        ' Start the worker.

        bgrLongProcess.WorkerReportsProgress = True
        bgrLongProcess.WorkerSupportsCancellation = True
        bgrLongProcess.RunWorkerAsync()

    End Sub

    'Private Sub CancelProcessButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

    '    't.Abort()

    '    'CancelFlag = True

    'End Sub


    Private Sub OldGenerate()
        'Set Variable
        Dim GenNo As Integer = 0 'GenNo=Generation No


        'Delete All record 

        'PrgLongProcess.Visible = True
        '' '' ''PrgLongProcess.Value = 0
        '' '' ''PrgLongProcess.Maximum = CInt(ItemListBindingSource.Count)
        '' '' ''PrgLongProcess.Step = 1

        'frmMain.ToolStripProgressBar1.Value = 0
        'frmMain.ToolStripProgressBar1.Maximum = ItemListBindingSource.Count
        'frmMain.ToolStripProgressBar1.Step = 1

        'Me.ItemListTableAdapter.FillByDepartmentAndDiscontinue(Me.ItemListDataSet.ItemList, DepartmentComboBox.SelectedValue, False)

        Dim i As Integer = CInt(ItemListBindingSource.Count)

        If Me.ItemListBindingSource.Position > -1 Then

            For Each dr As DataRowView In ItemListBindingSource.List

                'For Opening Balance Main Store

                Dim PreviouslnReceived As Decimal = 0
                Dim PreviouslclReceived As Decimal = 0
                Dim PreviousImReceived As Decimal = 0
                Dim PreviousReceived As Decimal = 0  'PreviouslnReceived+PreiviouslclReceived+PreviousImReceived
                Dim PreviousIssued As Decimal = 0
                Dim PreviousIssuetokg As Decimal = 0
                'Dim PreviousIssuetogrm As Decimal = 0
                Dim PreviouslnIssuedKg As Decimal = 0

                Dim OpeningBalance As Decimal = 0 'PreviousReceived-PreviousIssued
                Dim OpeningBalanceSub As Decimal = 0 'PreviousIssued-PreviousIssuedto

                Dim ImReceived As Decimal = 0
                Dim lclReceived As Decimal = 0
                Dim lnReceived As Decimal = 0
                Dim ReceivedQuantity As Decimal = 0
                Dim IssuedQuantity As Decimal = 0
                Dim IssuedPrice As Decimal = 0


                Dim IssuedtoQuantityKg As Decimal = 0
                'Dim IssuedtoQuantitygrm As Decimal = 0
                Dim lnIssuedKg As Decimal = 0
                'Dim lnIssuedgrm As Decimal = 0
                Dim rtnIssuedto As Decimal = 0

                Dim IssuetoPriceKg As Decimal = 0
                'Dim IssuetoPricegrm As Decimal = 0
                Dim rtnIssuetoPrice As Decimal = 0
                Dim lnIssuetoPrice As Decimal = 0


                Dim ClosingBalance As Decimal = 0 'OpeningBalance + ReceivedQuantity - IssuedQuantity
                Dim CloseingBalanceSub As Decimal = 0 ' OpeningBalanceSub-IssuedtoQuantityKg
                Dim QueryString As String = ""
                Dim TotalProduction As Decimal = 0


                'Total Production
                QueryString = "SELECT SUM(DyeingQuantity) AS TotalProduction FROM DyeingProduction_Final WHERE (DyeingDate >= '" & FromDateDateTimePicker.Text & "' AND DyeingDate <= '" & ToDateDateTimePicker.Text & "')"
                TotalProduction = ReadData(QueryString, cnn)


                'RecordCount = 0
                QueryString = "SELECT SUM(ReceiveQuantity) AS TotalReceive FROM Receive WHERE (ReceiveDate < '" & FromDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")"
                PreviousReceived = ReadBalanceValue(QueryString, cnn)

                'TotalIssue
                QueryString = "SELECT SUM(IssueQuantity) AS TotalIssue FROM Issue WHERE (IssueDate < '" & FromDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")"
                PreviousIssued = ReadBalanceValue(QueryString, cnn)


                OpeningBalance = PreviousReceived - PreviousIssued


                'TotalIssueTO


                QueryString = "SELECT SUM(IssuetoQuantity) AS TotalIssueto FROM Issueto WHERE (IssuetoDate < '" & FromDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & "AND Auto=0 And UnitId is Null)"
                PreviousIssuetokg = ReadBalanceValue(QueryString, cnn)

                'QueryString = "SELECT SUM(IssuetoQuantity) AS TotalIssueto FROM Issueto WHERE (IssuetoDate < '" & FromDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & "AND Auto=0 And UnitId=12)"
                'PreviousIssuetogrm = ReadBalanceValue(QueryString, cnn) / 1000


                OpeningBalanceSub = PreviousIssued - PreviousIssuetokg '- PreviousIssuetogrm


                QueryString = "SELECT SUM(ReceiveQuantity) AS TotalReceive FROM Receive WHERE (Imported=1 AND ReceiveDate >= '" & FromDateDateTimePicker.Text & "')AND (ReceiveDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")"
                ImReceived = ReadBalanceValue(QueryString, cnn)

                QueryString = "SELECT SUM(ReceiveQuantity) AS TotalReceive FROM Receive WHERE (IssueReceiveTypeId=1 AND ReceiveDate >= '" & FromDateDateTimePicker.Text & "')AND (ReceiveDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")"
                lclReceived = ReadBalanceValue(QueryString, cnn) - ImReceived

                QueryString = "SELECT SUM(ReceiveQuantity) AS TotalReceive FROM Receive WHERE (IssueReceiveTypeId=2 AND ReceiveDate >= '" & FromDateDateTimePicker.Text & "')AND (ReceiveDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")"
                lnReceived = ReadBalanceValue(QueryString, cnn)

                QueryString = "SELECT SUM(ReceiveQuantity) AS TotalReceive FROM Receive WHERE (ReceiveDate >= '" & FromDateDateTimePicker.Text & "')AND (ReceiveDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")"
                ReceivedQuantity = ReadBalanceValue(QueryString, cnn)


                QueryString = "SELECT SUM(IssueQuantity) AS TotalIssue FROM Issue WHERE (IssueDate >= '" & FromDateDateTimePicker.Text & "')AND (IssueDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")"
                IssuedQuantity = ReadBalanceValue(QueryString, cnn)

                QueryString = "SELECT SUM(TTLPRICE) AS TotalIssuedPrice FROM IssuedPrice WHERE (IssueDate >= '" & FromDateDateTimePicker.Text & "')AND (IssueDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & ")"
                IssuedPrice = ReadBalanceValue(QueryString, cnn)



                QueryString = "SELECT SUM(IssuetoQuantity) AS TotalIssueto FROM Issueto WHERE (IssueReceiveTypeId=2 AND IssuetoDate >= '" & FromDateDateTimePicker.Text & "')AND (IssuetoDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & " AND Auto=0)"
                lnIssuedKg = ReadBalanceValue(QueryString, cnn)

                'QueryString = "SELECT SUM(IssuetoQuantity) AS TotalIssueto FROM Issueto WHERE (IssueReceiveTypeId=2 AND IssuetoDate >= '" & FromDateDateTimePicker.Text & "')AND (IssuetoDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & " AND Auto=0 And UnitId=12)"
                'lnIssuedgrm = ReadBalanceValue(QueryString, cnn) / 1000

                QueryString = "SELECT SUM(IssuetoQuantity) AS TotalIssueto FROM Issueto WHERE (IssueReceiveTypeId=4 AND IssuetoDate >= '" & FromDateDateTimePicker.Text & "')AND (IssuetoDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & " AND Auto=0)"
                rtnIssuedto = ReadBalanceValue(QueryString, cnn)


                QueryString = "SELECT SUM(IssuetoQuantity) AS TotalIssueto FROM Issueto WHERE (IssuetoDate >= '" & FromDateDateTimePicker.Text & "')AND (IssuetoDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & " AND Auto=0 )"
                IssuedtoQuantityKg = ReadBalanceValue(QueryString, cnn)

                'QueryString = "SELECT SUM(IssuetoQuantity) AS TotalIssueto FROM Issueto WHERE (IssuetoDate >= '" & FromDateDateTimePicker.Text & "')AND (IssuetoDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & " AND Auto=0 And UnitId=12)"
                'IssuedtoQuantitygrm = ReadBalanceValue(QueryString, cnn) / 1000


                QueryString = "SELECT SUM(IssuetoPrice) AS TotalIssueto FROM IssuetoPrice WHERE (IssuetoDate >= '" & FromDateDateTimePicker.Text & "')AND (IssuetoDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & " AND Auto=0 )"
                IssuetoPriceKg = ReadBalanceValue(QueryString, cnn)

                'QueryString = "SELECT SUM(IssuetoPrice) AS TotalIssueto FROM IssuetoPrice_grm WHERE (IssuetoDate >= '" & FromDateDateTimePicker.Text & "')AND (IssuetoDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & " AND Auto=0 And UnitId=12)"
                'IssuetoPricegrm = ReadBalanceValue(QueryString, cnn)

                QueryString = "SELECT SUM(IssuetoPrice) AS TotalIssueto FROM IssuetoPrice WHERE (IssueReceiveTypeId=4 AND IssuetoDate >= '" & FromDateDateTimePicker.Text & "')AND (IssuetoDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & " AND Auto=0 )"
                rtnIssuetoPrice = ReadBalanceValue(QueryString, cnn)

                QueryString = "SELECT SUM(IssuetoPrice) AS TotalIssueto FROM IssuetoPrice WHERE (IssueReceiveTypeId=2 AND IssuetoDate >= '" & FromDateDateTimePicker.Text & "')AND (IssuetoDate <= '" & ToDateDateTimePicker.Text & "') AND (ItemId = " & dr!ItemId & " AND Auto=0 )"
                lnIssuetoPrice = ReadBalanceValue(QueryString, cnn)


                ClosingBalance = OpeningBalance + ReceivedQuantity - IssuedQuantity
                CloseingBalanceSub = OpeningBalanceSub + IssuedQuantity - IssuedtoQuantityKg - rtnIssuedto '- IssuedtoQuantitygrm 


                'Insert the generated data in balance table

                Dim balance As BalanceDataSet.BalanceRow = Me.BalanceDataSet.Balance.NewRow()

                balance.ItemId = CType(dr!ItemId, Integer)
                balance.OpeningBalance = OpeningBalance
                balance.OpeningBalanceSub = OpeningBalanceSub
                balance.ImReceived = ImReceived
                balance.lclReceived = lclReceived
                balance.lnReceived = lnReceived
                balance.Received = ReceivedQuantity
                balance.Issued = IssuedQuantity
                balance.IssuedPrice = IssuedPrice
                balance.IssuedtoQuantity = IssuedtoQuantityKg - rtnIssuedto '+ IssuedtoQuantitygrm
                balance.lnIssued = lnIssuedKg '+ lnIssuedgrm
                balance.rtnIssuedto = rtnIssuedto
                balance.ClosingBalance = ClosingBalance
                balance.ClosingBalanceSub = CloseingBalanceSub
                balance.FromDate = FromDateDateTimePicker.Text
                balance.ToDate = ToDateDateTimePicker.Text
                balance.TotalProduction = TotalProduction
                balance.IssuetoPrice = IssuetoPriceKg - rtnIssuetoPrice - lnIssuetoPrice 'IssuetoPricegrm +'Consumption Price




                Me.BalanceDataSet.Balance.Rows.Add(balance)

                'frmMain.ToolStripProgressBar1.PerformStep()
                'PrgLongProcess.PerformStep()
                'MessageBox.Show(dr!ItemId)
                GenNo = GenNo + 1
                'MessageBox.Show(GenNo)
                '=== Thread Related
                If bgrLongProcess.CancellationPending Then Exit Sub
                bgrLongProcess.ReportProgress(CInt(100 * GenNo / i))

            Next

        End If



        'PrgLongProcess.Visible = False
        'frmMain.ToolStripProgressBar1.Value = 0

    End Sub
#Region "Background Process"



    ' Start the long process.


    ' Cancel the long process.
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        bgrLongProcess.CancelAsync()

        'btnStartProcess.Enabled = True
        'btnCancel.Enabled = False

    End Sub

    ' Display the progress.
    Private Sub bgrLongProcess_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgrLongProcess.ProgressChanged
        PrgLongProcess.Value = e.ProgressPercentage
    End Sub

    ' The worker is done.
    Private Sub bgrLongProcess_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgrLongProcess.RunWorkerCompleted

        btnStartProcess.Enabled = True
        btnCancel.Enabled = False
        PrgLongProcess.Visible = False
        Me.GeneratingLabel.Text = "Completed"

        'Me.Validate()
        'Me.BalanceBindingSource.EndEdit()
        'Me.TableAdapterManager1.UpdateAll(Me.BalanceDataSet)

        'Me.BalanceViewTableAdapter.FillByDepartmentId(Me.BalanceViewDataSet.BalanceView, DepartmentComboBox.SelectedValue)
        'BalanceViewDataGridView.Enabled = True

        If Template1RadioButton.Checked = True Then
            'If WithCerCheckBox.Checked Then

            '    filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue}And  {ItemList.IsCertify}"

            'Else

            filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue}"
            'End If

            'Start Babu 23-05-2013 option button to genetrate New And Old Report MainstoreBalance(With out sub store)
            If RadioButtonNew.Checked Then
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterStoreBalance
                ShowReport(MyReport, filterstring, CrystalReportViewer1)
            ElseIf RadioButtonOld.Checked Then
                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MainStoreBalanceOld
                ShowReport(MyReport, filterstring, CrystalReportViewer1)
            End If
            'End Babu

        ElseIf Template3RadioButton.Checked = True Then

            filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue}"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew2
            ShowReport(MyReport, filterstring, CrystalReportViewer1)


        Else

            If WithCerCheckBox.Checked Then
                filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue} And  {ItemList.IsCertify}"
            Else
                filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue}"
            End If


            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If


    End Sub

    Private Sub bgrLongProcess_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgrLongProcess.DoWork

        'For i As Integer = 1 To 10000

        '    For j As Integer = 1 To 10000

        '    Next j
        '    If bgrLongProcess.CancellationPending Then Exit Sub

        '    bgrLongProcess.ReportProgress(CInt(100 * i / 10000))
        'Next i

        


        NewGenerate()



    End Sub


#End Region

    Private Sub NewGenerate()

     

        ExecuteQuery("Execute dbo.StoreBalance @DepartmentId=" & varDepartmentId & ",@OpeningDate='" & FromDateDateTimePicker.Text & "',@ClosingDate='" & ToDateDateTimePicker.Text & "'", cnn)
        ExecuteQuery("Execute dbo.StoreBalanceValue @DepartmentId=" & varDepartmentId & ",@OpeningDate='" & FromDateDateTimePicker.Text & "',@ClosingDate='" & ToDateDateTimePicker.Text & "'", cnn)
        ExecuteQuery("Execute dbo.MasterStoreBalance @DepartmentId=" & varDepartmentId & ",@FromDate='" & FromDateDateTimePicker.Text & "',@ToDate='" & ToDateDateTimePicker.Text & "'", cnn)


        '=======================================================
        'Generating IssueReceive
        '=======================================================

        ExecuteQuery("Delete  ReceiveIssue Where DepartmentId=" & varDepartmentId, cnn)

        ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId)Select IssueDate as ReceiveIssueDate,IssueQuantity,ItemId,DepartmentId,IssueId,SupplierId From Issue where IssueReceiveTypeId=2 AND DepartmentId=" & varDepartmentId, cnn)
        ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId)Select ReceiveDate as ReceiveIssueDate,ReceiveQuantity,ItemId,DepartmentId,ReceiveId,SupplierId From Receive Where IssueReceiveTypeId=2 AND DepartmentId=" & varDepartmentId, cnn)
        ExecuteQuery("Insert Into ReceiveIssue (ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId)Select IssuetoDate as ReceiveIssueDate,IssuetoQuantity,ItemId,DepartmentId,IssuetoId,SupplierId From Issueto where IssueReceiveTypeId=2 AND DepartmentId=" & varDepartmentId, cnn)
        '=======================================================
        'End Generating IssueReceive
        '=======================================================

        If bgrLongProcess.CancellationPending Then Exit Sub

        'bgrLongProcess.ReportProgress(CInt(100 * GenNo / i))
        bgrLongProcess.WorkerReportsProgress = True

        'Next

        'Me.BalanceViewTableAdapter.FillByDepartmentId(Me.BalanceViewDataSet.BalanceView, varDepartmentId)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      



        If SubCategoryCheckBox.Checked = True Then


            If Template1RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And {SubCategory.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {ItemList.Discontinue} And {ItemList.IsCertify}"
                Else
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And {SubCategory.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {ItemList.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MainStoreBalance_SubCategory
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            ElseIf Template3RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Category.CategoryId} = " & CategoryComboBox.SelectedValue & " And {SubCategory.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & " And not {ItemList.Discontinue} And {ItemList.IsCertify}"
                Else
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Category.CategoryId} = " & CategoryComboBox.SelectedValue & " And {SubCategory.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & " And not {ItemList.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew2
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else

                If WithCerCheckBox.Checked Then
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And {SubCategory.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & " And not {ItemList.Discontinue} And {ItemList.IsCertify}"
                Else
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & " And {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And {SubCategory.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & " And not {ItemList.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew_SubCat
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            End If


        Else


            If Template1RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {ItemList.Discontinue} And {ItemList.IsCertify}"
                Else
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {ItemList.Discontinue}"
                End If

                If RadioButtonOld.Checked Then
                    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MainStoreBalanceOld
                    ShowReport(MyReport, filterstring, CrystalReportViewer1)
                ElseIf RadioButtonNew.Checked Then
                    Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MainStoreBalance
                    ShowReport(MyReport, filterstring, CrystalReportViewer1)
                End If

            ElseIf Template3RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {ItemList.Discontinue} And {ItemList.IsCertify}"
                Else
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {ItemList.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew2
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else

                If WithCerCheckBox.Checked Then
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {ItemList.Discontinue} And {ItemList.IsCertify}"
                Else
                    filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {Category.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {ItemList.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew_Cat
                ShowReport(MyReport, filterstring, CrystalReportViewer1)


            End If

            End If



    End Sub


    Private Sub ShowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartProcess.Click

        ' Get ready.
        varDepartmentId = DepartmentComboBox.SelectedValue
        'Start Babu get value in Mainstore report-Babu-22-05-2013
        

        'End Babu
        ExecuteQuery("Update Issueto Set Auto=0 Where Auto is null", cnn)


        GeneratingLabel.Text = "Please wait, the report is being shown..."


        btnStartProcess.Enabled = False
        btnCancel.Enabled = True
        PrgLongProcess.Value = 0

        ' Start the worker.

        bgrLongProcess.WorkerReportsProgress = True
        bgrLongProcess.WorkerSupportsCancellation = True
        bgrLongProcess.RunWorkerAsync()


    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryComboBox.SelectedIndexChanged

        Me.SubCategoryLookupTableAdapter.Fill(Me.SubCategoryDataSet.SubCategoryLookup, DepartmentComboBox.SelectedValue, CategoryComboBox.SelectedValue)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovefilterButton.Click

        'Start Babu ////'Creted by: Babu, Created on 14.5.2013
        'only this code for get Balance Master in for remove Filter

        If Template1RadioButton.Checked = True Then

            If WithCerCheckBox.Checked Then
                filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue} And  {ItemList.IsCertify}"
            Else
                filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue}"
            End If


            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MainStoreBalance
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else

            If WithCerCheckBox.Checked Then
                filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue} And  {ItemList.IsCertify}"
            Else
                filterstring = "{Department.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue}"
            End If


            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If


        'Stop babu
    End Sub

    
    
    
    Private Sub filterButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterButton2.Click
        'Start Babu ////'Creted by: Babu, Created on 14.5.2013
        'only this code for get Balance Master in Valuation And in Qty With iltering with Total Closing Balance.
        Dim filterstring As String = "{Balance.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And {@TTLClosingBalance} < " & NumericUpDown1.Value & "And not {ItemList.Discontinue}"
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew
        ShowReport(MyReport, filterstring, CrystalReportViewer1)

        'Stop Babu
    End Sub

    Private Sub btnStartProcessbyvalue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartProcessbyvalue.Click
        'Start Babu ////'Creted by: Babu, Created on 14.5.2013
        'only this code for get Balance Master in Valuation(With Sub store and without sub store)
        varDepartmentId = DepartmentComboBox.SelectedValue

        GeneratingLabel.Text = "Please wait, the report is being shown..."

        'Set store procedure MasterStoreBalanceValue unde value button and remove from runworkprocess-04-07-2013 
        ExecuteQuery("Execute dbo.MasterStoreBalanceValue @DepartmentId=" & varDepartmentId & ",@FromDate='" & FromDateDateTimePicker.Text & "',@ToDate='" & ToDateDateTimePicker.Text & "'", cnn)


        If Template1RadioButton.Checked = True Then

            filterstring = "{Department.DepartmentId}=" & DepartmentComboBox.SelectedValue & "And not {ItemList.Discontinue}"

            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MasterStoreBalanceValue

            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        Else
            filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
            Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNewValue
            ShowReport(MyReport, filterstring, CrystalReportViewer1)

        End If

        PrgLongProcess.Value = 0

        Me.GeneratingLabel.Text = "Completed"
        'Stop babu--To Stop Run Background Process---04-07-2013

        'need to stop
        'btnStartProcess.Enabled = False

        'btnCancel.Enabled = True

        '' Start the worker.

        'bgrLongProcess.WorkerReportsProgress = True
        'bgrLongProcess.WorkerSupportsCancellation = True
        'bgrLongProcess.RunWorkerAsync()

        'End Babu
    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'varDepartmentId = DepartmentComboBox.SelectedValue
        ''ExecuteQuery("Update Issueto Set Auto=0 Where Auto is null", cnn)
        'ExecuteQuery("Execute dbo.StoreBalanceValue @DepartmentId=" & varDepartmentId & ",@OpeningDate='" & FromDateDateTimePicker.Text & "',@ClosingDate='" & ToDateDateTimePicker.Text & "'", cnn)


        GeneratingLabel.Text = "Please wait, the report is being shown..."



        If SubCategoryCheckBox.Checked = True Then


            If Template1RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If



            ElseIf Template3RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If




            Else

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If




            End If


        Else


            If Template1RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If





            ElseIf Template3RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If




            Else

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If





            End If

        End If
        Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNewValue
        ShowReport(MyReport, filterstring, CrystalReportViewer1)
        Me.GeneratingLabel.Text = "Completed"
    End Sub


    Private Sub btnFilterByValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilterByValue.Click
        'Start Babu ////'Creted by: Babu, Created on 14.5.2013
        'only this code for get Balance Master in Valuation And in Qty With Variuos Filter

        GeneratingLabel.Text = "Please wait, the report is being shown..."




        If SubCategoryCheckBox.Checked = True Then


            If Template1RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MainStoreBalanceValue
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            ElseIf Template3RadioButton.Checked = True Then

                'If WithCerCheckBox.Checked Then
                '    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                'Else
                '    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                'End If


                'Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew2
                'ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And {StoreBalanceReportNewValue.SubCategoryId}=" & SubCategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNewValue
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            End If


        Else


            If Template1RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New MainStoreBalanceValue
                ShowReport(MyReport, filterstring, CrystalReportViewer1)


            ElseIf Template3RadioButton.Checked = True Then

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNew2
                ShowReport(MyReport, filterstring, CrystalReportViewer1)

            Else

                If WithCerCheckBox.Checked Then
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue} And {StoreBalanceReportNewValue.IsCertify}"
                Else
                    filterstring = "{StoreBalanceReportNewValue.DepartmentId} = " & DepartmentComboBox.SelectedValue & "and {StoreBalanceReportNewValue.CategoryId} = " & CategoryComboBox.SelectedValue & "And not {StoreBalanceReportNewValue.Discontinue}"
                End If


                Dim MyReport As CrystalDecisions.CrystalReports.Engine.ReportDocument = New StoreBalanceReportNewValue
                ShowReport(MyReport, filterstring, CrystalReportViewer1)


            End If

        End If
        Me.GeneratingLabel.Text = "Completed"

        'Stop Babu
    End Sub

    Private Sub Template1RadioButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Template1RadioButton.Click
        'For Stop Filtering by Value Report with Catagory And Sub catagory 
        btnFilterByValue.Enabled = False

    End Sub

    Private Sub Template2RadioButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Template2RadioButton.Click
        'For geting Filter by both Qty and Value Report with Catagory And Sub catagory 
        btnFilterByValue.Enabled = True
    End Sub

    Private Sub SubCategoryComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubCategoryComboBox.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub SubCategoryCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SubCategoryCheckBox.CheckedChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class