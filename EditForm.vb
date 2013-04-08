Public Class EditForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Nama_instansiTableAdapter.Fill(Me.SiGEDataSet.Nama_instansi)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        NamaInstansiBindingSource.EndEdit()
        Nama_instansiTableAdapter.Update(SiGEDataSet)
    End Sub

    Private Sub Gambar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gambar.Click
        With OpenFileDialog1
            .ShowDialog()
            If .FileName <> "" Then
                picPoto.Load(.FileName)
                FotoTextBox.Text = .FileName
            End If
        End With
    End Sub

    Private Sub FotoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FotoTextBox.TextChanged
        If FotoTextBox.Text <> "" Then
            picPoto.Load(FotoTextBox.Text)
            picPoto.SizeMode = PictureBoxSizeMode.Zoom

        Else
            picPoto.Load("C:\empty.jpg")
        End If
    End Sub

    Private Sub picPoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPoto.Click
        'FormFoto.ShowDialog(Me.FotoTextBox.Text)
    End Sub

    Private Sub AlamatTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlamatTextBox.TextChanged

    End Sub

    Private Sub TextControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With OpenFileDialog1
            .ShowDialog()
            If .FileName <> "" Then
                WebBrowser1.Navigate(.FileName)
                HTMLTextBox.Text = .FileName
            End If
        End With
    End Sub

    Private Sub HTMLTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLTextBox.TextChanged

    End Sub

    Private Sub RSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub

    Private Sub PelayananTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelayananTextBox.TextChanged

    End Sub

    Private Sub CoordinatesTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CoordinatesTextBox.TextChanged

    End Sub

    Private Sub CoordinatesLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class