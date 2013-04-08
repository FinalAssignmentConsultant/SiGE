﻿Imports System.Windows.Forms

Public Class DialogRS

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SiGEDataSet4)

    End Sub

    Private Sub DialogRS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiGEDataSet4.RS' table. You can move, or remove it, as needed.
        Me.RSTableAdapter.Fill(Me.SiGEDataSet4.RS)

    End Sub
End Class
