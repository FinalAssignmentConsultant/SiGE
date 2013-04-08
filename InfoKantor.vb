Public Class InfoKantor

    Private Sub Nama_instansiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Nama_instansiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiGEDataSet)

    End Sub

    Private Sub InfoKantor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiGEDataSet.Nama_instansi' table. You can move, or remove it, as needed.
        Me.Nama_instansiTableAdapter.Fill(Me.SiGEDataSet.Nama_instansi)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub FotoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FotoTextBox.TextChanged
        If FotoTextBox.Text <> "" Then
            'MessageBox.Show(FotoTextBox.Text)
            PictureBox1.Load(FotoTextBox.Text)
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.Load("C:\empty.jpg")
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Nama_instansiBindingNavigator_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nama_instansiBindingNavigator.RefreshItems
        FotoTextBox_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub HTMLTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLTextBox1.TextChanged
        If HTMLTextBox1.Text = "" Then
            WebBrowser1.Navigate("c:\nodata.html")
        Else
            WebBrowser1.Navigate(HTMLTextBox1.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(SitusTextBox.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class