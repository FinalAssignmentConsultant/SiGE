Public Class EditHotel

    Private Sub HotelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HotelBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HotelBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiGEDataSet3)

    End Sub

    Private Sub EditHotel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiGEDataSet3.hotel' table. You can move, or remove it, as needed.
        Me.HotelTableAdapter.Fill(Me.SiGEDataSet3.hotel)

    End Sub
End Class