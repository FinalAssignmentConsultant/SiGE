Imports System.Windows.Forms

Public Class FormFoto

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Overloads Sub ShowDialog(ByVal foto As String)
        On Error GoTo err1
        Me.PictureBox1.Load(foto)
        ShowDialog()
        Exit Sub
err1:
        Me.PictureBox1.Load("C:\empty.jpg")
    End Sub
End Class
