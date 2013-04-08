Public Class LihatHasil

    Private Sub BindingNavigatorPositionItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorPositionItem.Click

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPoto.Click
    End Sub
    Public Sub potonya()
        FotoTextBox_TextChanged(Nothing, Nothing)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub


    Private Sub Fasilitas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Fasilitas.Click

    End Sub

    

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picPoto.Paint
        picPoto.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.RefreshItems
        ' FotoTextBox_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(SitusTextBox.Text)
    End Sub

    Private Sub Nm_kantorTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nm_kantorTextBox.TextChanged

    End Sub

    Private Sub AlamatTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlamatTextBox.TextChanged

    End Sub

    Private Sub FotoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If FotoTextBox.Text <> "" Then
            'MessageBox.Show("hai")
            picPoto.Load(FotoTextBox.Text)
            picPoto.SizeMode = PictureBoxSizeMode.Zoom
        Else
            picPoto.Load("C:\empty.jpg")
        End If
    End Sub

    Private Sub LihatHasil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class