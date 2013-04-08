Imports System.Windows.Forms

Public Class FormKML

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub KMLBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KMLBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.KMLBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiGEDataSet)

    End Sub

    Private Sub FormKML_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiGEDataSet.KML' table. You can move, or remove it, as needed.
        Me.KMLTableAdapter.Fill(Me.SiGEDataSet.KML)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With OpenFileDialog1
            .ShowDialog()
            KMLTextBox.Text = .FileName
        End With

    End Sub
End Class
