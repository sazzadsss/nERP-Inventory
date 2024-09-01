Public Class frmFinishFabricBookingClosing
    Private _IsGreige As Boolean
    Public Property IsGreige() As Boolean
        Get
            Return _IsGreige
        End Get
        Set(ByVal value As Boolean)
            _IsGreige = value
        End Set
    End Property

    Private Sub FinishFabricBookingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinishFabricBookingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FinishFabricBookingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinishFabricBookingDataSet)

    End Sub

    Private Sub frmFinishFabricBookingClosing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinishFabricBookingDataSet.FinishFabricBooking' table. You can move, or remove it, as needed.
        Me.FinishFabricBookingTableAdapter.Fill(Me.FinishFabricBookingDataSet.FinishFabricBooking)
        If Me.IsGreige = True Then
            colIsGreigeClose.Visible = True
            colIsClose.Visible = False
        Else
            colIsGreigeClose.Visible = False
            colIsClose.Visible = True

        End If
    End Sub
End Class