Imports System.Data.SqlClient

Public Class frmAccessoriesMapping

    Private Sub AccessoriesMappingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccessoriesMappingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AccessoriesMappingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AccessoriesMappingDataSet)

    End Sub

    Private Sub frmAccessoriesMapping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AccessoriesListDataSet.AccessoriesListLookup' table. You can move, or remove it, as needed.
        Me.AccessoriesListLookupTableAdapter.Fill(Me.AccessoriesListDataSet.AccessoriesListLookup)
        Me.ItemListLookupTableAdapter.Fill(Me.ItemListDataSet.ItemListLookup, DepartmentId)

        Me.AccessoriesMappingTableAdapter.FillbyDepartment(Me.AccessoriesMappingDataSet.AccessoriesMapping, DepartmentId)
        LoadMenu()

    End Sub
    Private Sub LoadMenu()

        Dim sqlstring As String = "Select AccessoriesId From AccessoriesList"
        Dim connection As New SqlConnection(cnn)
        connection.Open()
        Dim cmd As SqlCommand = New SqlCommand(sqlstring, connection)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        'Dim list As New AutoCompleteStringCollection

        While reader.Read
            'If reader.IsDBNull( = False Then
            '    'list.Add(reader.GetString(0))
            'End If

            'MessageBox.Show(reader("Menu_Id"))

            'Dim row As AccessoriesMappingDataSet.AccessoriesMappingRow
            'row = CType(CType(Me.AccessoriesMappingBindingSource.Current, DataRowView).Row, AccessoriesMappingDataSet.AccessoriesMappingRow)


            Dim CheckExistMenuId As Integer = ReadIntegerData("Select AccessoriesId From AccessoriesMapping Where DepartmentId=" & DepartmentId & "and AccessoriesId=" & Val(reader("AccessoriesId").ToString), cnn)



            'MessageBox.Show(CheckExistMenuId.ToString)

            If CheckExistMenuId = 0 Then

                'MessageBox.Show(CheckExistMenuId.ToString)
                Dim newRow As AccessoriesMappingDataSet.AccessoriesMappingRow = Me.AccessoriesMappingDataSet.AccessoriesMapping.NewRow()

                newRow.DepartmentId = DepartmentId
                newRow.AccessoriesId = reader("AccessoriesId")
                newRow.Remarks = "-"
                newRow.ItemId = Nothing


                Me.AccessoriesMappingDataSet.AccessoriesMapping.Rows.Add(newRow)

                'Else

                '    ExecuteQuery("Update UserRights Set Parent_Id=" & reader("Parent_Id") & " Where User_Id=" & row.USER_ID & "and Menu_Id=" & Val(reader("Menu_Id").ToString), cnn)

            End If


        End While

        reader.Close()

        connection.Close()

    End Sub
End Class