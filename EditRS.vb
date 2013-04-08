Public Class EditRS

    Private Sub RSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiGEDataSet4)

    End Sub

    Private Sub EditRS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiGEDataSet4.RS' table. You can move, or remove it, as needed.
        Me.RSTableAdapter.Fill(Me.SiGEDataSet4.RS)

    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub PotoRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picPoto.Click
        'FormFoto.ShowDialog(Me.FotoTextBox.Text)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .ShowDialog()
            If .FileName <> "" Then
                picPoto.Load(.FileName)
                FotoTextBox.Text = .FileName
            End If
        End With
    End Sub
End Class