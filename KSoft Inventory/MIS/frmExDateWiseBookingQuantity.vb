Public Class frmExDateWiseBookingQuantity

    Private Sub frmExDateWiseBookingQuantity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CriticalPathFinishFabricDataSet.CriticalPath_Main' table. You can move, or remove it, as needed.
        Me.CriticalPath_MainTableAdapter.Fill(Me.CriticalPathFinishFabricDataSet.CriticalPath_Main)

    End Sub

    Private Sub ExportButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportButton.Click
        Try

            PivotGridControl1.ExportToXls("c:\Fabric_Booking.xls")
            MessageBox.Show("Exported to ""C:\Fabric Booking.xls"" Successfully", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class