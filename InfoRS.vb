Public Class InfoRS

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Nm_RSTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RSDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub RSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiGEDataSet4)

    End Sub

    Private Sub InfoRS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiGEDataSet4.RS' table. You can move, or remove it, as needed.
        Me.RSTableAdapter.Fill(Me.SiGEDataSet4.RS)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start(SitusTextBox.Text)
    End Sub

    Private Sub FotoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FotoTextBox.TextChanged

        If FotoTextBox.Text <> "" Then
            'MessageBox.Show("hai")
            picPoto.Load(FotoTextBox.Text)
            picPoto.SizeMode = PictureBoxSizeMode.Zoom
        Else
            picPoto.Load("C:\empty.jpg")
        End If
    End Sub

    Private Sub HTMLTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLTextBox.TextChanged
        If HTMLTextBox.Text = "" Then
            WebBrowser1.Navigate("C:\nodata.html")
        Else
            WebBrowser1.Navigate(HTMLTextBox.Text)
        End If
    End Sub
End Class