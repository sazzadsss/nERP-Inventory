Partial Class OrderDataSet
    Partial Class OrderDetailsDataTable

        Private Sub OrderDetailsDataTable_OrderDetailsRowChanging(ByVal sender As System.Object, ByVal e As OrderDetailsRowChangeEvent) Handles Me.OrderDetailsRowChanging

        End Sub

    End Class

    Partial Class OrderTrimDataTable

        Private Sub OrderTrimDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.RemarksColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
