Public Class FormHasilPencarian

    Private Sub InfopentingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfopentingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InfopentingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiGEDataSet2)

    End Sub

    Private Sub FormHasilPencarian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiGEDataSet2.infopenting' table. You can move, or remove it, as needed.
        Me.InfopentingTableAdapter.Fill(Me.SiGEDataSet2.infopenting)

    End Sub
End Class