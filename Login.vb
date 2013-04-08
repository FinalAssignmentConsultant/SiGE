Public Class Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
         If UCase(txtNama.Text) = UCase(UserInfo.name) And UCase(txtPassword.Text) = UCase(UserInfo.password) Then
            UserInfo.isLogin = True
            MessageBox.Show("Selamat datang " & UserInfo.name, "Selamat datang", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        Else
            MessageBox.Show("Maaf, Anda tidak dikenali oleh sistem", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dispose()
    End Sub

    Private Sub Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtNama.Focus()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class