Imports System.Data
Imports System.Data.SqlClient

Module GetData

    Function GetLotWiseBalance() As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable
        ' Create four typed columns in the DataTable.
        table.Columns.Add("ItemId", GetType(Integer))
        table.Columns.Add("ItemName", GetType(String))
        table.Columns.Add("CompanyId", GetType(Integer))
        table.Columns.Add("CompanyName", GetType(String))
        table.Columns.Add("SupplierId", GetType(Integer))
        table.Columns.Add("SupplierName", GetType(String))
        table.Columns.Add("TTLReceived", GetType(Integer))
        table.Columns.Add("TTLIssued", GetType(String))


        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand("Select ItemId,ItemName,CompanyId,CompanyName,TTLReceived,TTLIssued From LotWiseReceivedIssued Order TTLBalanced>0", connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Dim list As New AutoCompleteStringCollection

        While reader.Read
            If reader.IsDBNull(0) = False Then
                table.Rows.Add(reader("ItemId"), reader("ItemId").ToString)
                table.Rows.Add(reader("ItemName"), reader("ItemName").ToString)
                table.Rows.Add(reader("CompanyId"), reader("CompanyId").ToString)
                table.Rows.Add(reader("CompanyName"), reader("CompanyName").ToString)
                table.Rows.Add(reader("SupplierId"), reader("SupplierId").ToString)
                table.Rows.Add(reader("SupplierName"), reader("SupplierName").ToString)
                table.Rows.Add(reader("TTLReceived"), reader("TTLReceived").ToString)
                table.Rows.Add(reader("TTLReceived"), reader("TTLReceived").ToString)
            End If
        End While

        reader.Close()
        connection.Close()

        Return table

    End Function
End Module
