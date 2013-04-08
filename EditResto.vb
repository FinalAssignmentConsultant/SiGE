Public Class EditResto

    Private Sub RestoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RestoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiGEDataSet3)

    End Sub

    Private Sub EditResto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiGEDataSet3.resto' table. You can move, or remove it, as needed.
        Me.RestoTableAdapter.Fill(Me.SiGEDataSet3.resto)

    End Sub
End Class