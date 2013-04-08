Public Class InfoResto

    Private Sub RSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiGEDataSet)

    End Sub

    Private Sub InfoResto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiGEDataSet.resto' table. You can move, or remove it, as needed.
        Me.RestoTableAdapter1.Fill(Me.SiGEDataSet.resto)
        'TODO: This line of code loads data into the 'SiGEDataSet1.resto' table. You can move, or remove it, as needed.
        Me.RestoTableAdapter.Fill(Me.SiGEDataSet1.resto)
        'TODO: This line of code loads data into the 'SiGEDataSet.RS' table. You can move, or remove it, as needed.
        Me.RSTableAdapter.Fill(Me.SiGEDataSet.RS)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AlamatTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NO_TELPTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub FASILITAS_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FASILITAS_TextBox.TextChanged

    End Sub

    Private Sub NAMA_RESTOTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NAMA_RESTOTextBox.TextChanged

    End Sub
End Class