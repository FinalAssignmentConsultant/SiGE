Imports SIGE2.SiGEDataSetTableAdapters
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Xml
Imports System.IO

Public Class FormUnggulan
    Private cari As String
    Private tampilkanInfo As Boolean
    Private Sub AxGEPluginX1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKelurahan.CheckedChanged
        managerLayer(cboKelurahan.Checked, "kelurahan", "c:\kelurahan.kml")

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboJalan.CheckedChanged
        managerLayer(cboJalan.Checked, "jalan jogja", "c:\jln.kml")
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        managerLayer(cboInstansi.Checked, "instansi", "c:\instansi.kml")

    End Sub

    Private Function cariFitur(ByVal f As FeatureGE, ByVal fitur As String) As Integer
        Dim c As FeatureCollectionGE
        Dim i As Integer

        c = f.GetChildren()
        For i = 1 To c.Count

            If c(i).Name = fitur Then

                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub managerLayer(ByVal Checked As Boolean, ByVal layerName As String, ByVal kmlName As String)
        Dim ifitur As Integer
        If Checked Then
            ifitur = cariFitur(AxGEPluginX1.ApplicationGE.GetTemporaryPlaces(), layerName)
            If ifitur = -1 Then
                AxGEPluginX1.ApplicationGE.OpenKmlFile(kmlName, 1)
            Else

                AxGEPluginX1.ApplicationGE.GetTemporaryPlaces().GetChildren(ifitur).Visibility = True
                AxGEPluginX1.ApplicationGE.GetTemporaryPlaces().GetChildren(ifitur).Highlight()
            End If

        Else

            ifitur = cariFitur(AxGEPluginX1.ApplicationGE.GetTemporaryPlaces(), layerName)
            AxGEPluginX1.ApplicationGE.GetTemporaryPlaces().GetChildren(ifitur).Visibility = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'AxGEPluginX1.ApplicationGE.GetTemporaryPlaces().Visibility = False

        cboHalteTrans.Checked = False
        cboJalan.Checked = False
        cboKecamatan.Checked = False
        cboKelurahan.Checked = False
        CheckBox26.Checked = False
        CheckBox19.Checked = False
        cboInstansi.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox22.Checked = False
        cboRumahSakit.Checked = False
        CheckBox8.Checked = False
        CheckBox23.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox24.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox7.Checked = False
        CheckBox12.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox1.Checked = False











    End Sub

    Private Sub TambahToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TambahToolStripMenuItem.Click
        EditForm.ShowDialog()
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateLogin()
        loadKML()

        'AxGEPluginX1.

    End Sub
    Private Sub loadKML()
        Dim xml_doc As New XmlDocument
        '       xml_doc.Load("c:\jln.kml")
        '        xml_doc.DocumentElement()
    End Sub
    Private Sub updateLogin()
        If Not UserInfo.isLogin Then
            mnuLogin.Text = "Login"
            mnuData.Enabled = False
        Else
            mnuLogin.Text = "Logout"
            mnuData.Enabled = True
        End If
    End Sub

    Private Sub mnuLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogin.Click
        If mnuLogin.Text = "Login" Then
            Login.ShowDialog()
        Else
            If MessageBox.Show("Apakah anda yakin akan logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                UserInfo.isLogin = False
            End If
        End If
        updateLogin()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' AxGEPluginX1.ApplicationGE.
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged

    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        cari = "instansi"
        'FormHasilPencarian.Show()
        lstHasilCari.Text = ""

        Dim sqlConnection1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SiGE.accdb")
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim i As Integer
        Dim recordData As String = ""
        Dim recordCount As Integer = 0

        cmd.CommandText = "SELECT     Nm_kantor FROM         [Nama instansi] WHERE     (Pelayanan LIKE '%" & txtCari.Text & "%')"
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        lstHasilCari.Items.Clear()
        While reader.Read()

            lstHasilCari.Items.Add(reader(i).ToString & lstHasilCari.Text)
        End While

        sqlConnection1.Close()



    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboKecamatan.CheckedChanged
        managerLayer(cboKecamatan.Checked, "kecamatan", "c:\kecamatan.kml")
    End Sub

    Private Sub KMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormKML.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tampilkanInfo = True
        lstHasilCari_MouseDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub lstHasilCari_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstHasilCari.MouseDoubleClick
        Dim sqlConnection1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SiGE.accdb")
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim i As Integer
        Dim recordData As String = ""
        Dim recordCount As Integer = 0
        Dim flyTo As String

        If lstHasilCari.Text = "" Then Exit Sub
        If cari = "jalan" Then
            cmd.CommandText = "SELECT nama_jalan,coordinates FROM jalan WHERE    nama_jalan='" & lstHasilCari.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()
            reader = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.
            reader.Read()
            flyTo = "<kml xmlns=""http://earth.google.com/kml/2.1""><Document><name>" & IIf(IsDBNull(reader.GetValue(0)), "", reader.GetValue(0)) & "</name><Placemark><name>" & IIf(IsDBNull(reader.GetValue(0)), "", reader.GetValue(0)) & "</name><Point><coordinates>" & IIf(IsDBNull(reader.GetValue(1)), "", reader.GetValue(1)) & "</coordinates></Point></Placemark></Document></kml>"
            SaveTextToFile(flyTo, "C:\tmp.kml")
            AxGEPluginX1.openFile("C:\tmp.kml")
        ElseIf cari = "instansi" Then
            cmd.CommandText = "SELECT nm_kantor,[alamat],[moto],[no_telp],[no_fax],[situs],[fasilitas],[jam buka],[info lain],[pelayanan],coordinates,html,foto FROM [Nama instansi] WHERE    Nm_kantor='" & lstHasilCari.Text & "'"
            cmd.CommandType = CommandType.Text
            cmd.Connection = sqlConnection1
            sqlConnection1.Open()

            reader = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.


            reader.Read()
            flyTo = "<kml xmlns=""http://earth.google.com/kml/2.1""><Document><name>" & IIf(IsDBNull(reader.GetValue(0)), "", reader.GetValue(0)) & "</name><Placemark><name>" & IIf(IsDBNull(reader.GetValue(0)), "", reader.GetValue(0)) & "</name><Style id=""style""><IconStyle><scale>1.06364</scale><Icon><href>http://maps.google.com/mapfiles/kml/pal2/icon2.png</href></Icon></IconStyle><LabelStyle><color>ff00ffff</color><scale>0.9</scale></LabelStyle></Style><styleUrl>#style</styleUrl><Point><coordinates>" & IIf(IsDBNull(reader.GetValue(10)), "", reader.GetValue(10)) & "</coordinates></Point></Placemark></Document></kml>"
            SaveTextToFile(flyTo, "C:\tmp.kml")
            AxGEPluginX1.openFile("C:\tmp.kml")
            LihatHasil.Nm_kantorTextBox.Text = IIf(IsDBNull(reader.GetValue(0)), "", reader.GetValue(0))
            LihatHasil.AlamatTextBox.Text = IIf(IsDBNull(reader.GetValue(1)), "", reader.GetValue(1))
            LihatHasil.MotoTextBox.Text = IIf(IsDBNull(reader.GetValue(2)), "", reader.GetValue(2)) ' reader.GetString(2)
            LihatHasil.No_telpTextBox.Text = IIf(IsDBNull(reader.GetValue(3)), "", reader.GetValue(3))
            LihatHasil.No_faxTextBox.Text = IIf(IsDBNull(reader.GetValue(4)), "", reader.GetValue(4))
            LihatHasil.SitusTextBox.Text = IIf(IsDBNull(reader.GetValue(5)), "", reader.GetValue(5))
            LihatHasil.FasilitasTextBox.Text = IIf(IsDBNull(reader.GetValue(6)), "", reader.GetValue(6))
            LihatHasil.Jam_bukaTextBox.Text = IIf(IsDBNull(reader.GetValue(7)), "", reader.GetValue(7))
            LihatHasil.InfoLainTextBox.Text = IIf(IsDBNull(reader.GetValue(8)), "", reader.GetValue(8))
            LihatHasil.FotoTextBox.Text = IIf(IsDBNull(reader.GetValue(12)), "", reader.GetValue(12))
            LihatHasil.potonya()
            'LihatHasil.PelayananTextBox.Text = IIf(IsDBNull(reader.GetValue(9)), "", reader.GetValue(9)) 
            'yg 10 koordinate

            If tampilkanInfo Then
                tampilkanInfo = False
                If IsDBNull(reader.GetValue(11)) Then
                    LihatHasil.WebBrowser1.Navigate("C:\nodata.html")
                Else
                    LihatHasil.WebBrowser1.Navigate(reader.GetValue(11))
                End If
                LihatHasil.Show()
            End If
            sqlConnection1.Close()
        End If
    End Sub
    Public Function SaveTextToFile(ByVal strData As String, _
  ByVal FullPath As String, _
    Optional ByVal ErrInfo As String = "") As Boolean

        Dim Contents As String
        Dim bAns As Boolean = False
        Dim objReader As StreamWriter
        Try


            objReader = New StreamWriter(FullPath)
            objReader.Write(strData)
            objReader.Close()
            bAns = True
        Catch Ex As Exception
            ErrInfo = Ex.Message

        End Try
        Return bAns
    End Function
    Private Sub lstHasilCari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstHasilCari.SelectedIndexChanged

    End Sub

    Private Sub mnuData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuData.Click

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCariJalan.Click
        cari = "jalan"
        'FormHasilPencarian.Show()
        lstHasilCari.Text = ""

        Dim sqlConnection1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SiGE.accdb")
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim i As Integer
        Dim recordData As String = ""
        Dim recordCount As Integer = 0

        cmd.CommandText = "SELECT     nama_jalan FROM         [jalan] WHERE     (nama_jalan LIKE '%" & TextBoxCariJalan.Text & "%')"
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        lstHasilCari.Items.Clear()
        While reader.Read()

            lstHasilCari.Items.Add(reader(i).ToString & lstHasilCari.Text)
        End While

        sqlConnection1.Close()
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxCariJalan.TextChanged

    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowDialog()
    End Sub

    Private Sub RSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RSToolStripMenuItem.Click
        InfoRS.ShowDialog()

    End Sub

    Private Sub KantorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KantorToolStripMenuItem.Click
        InfoKantor.ShowDialog()

    End Sub

    Private Sub HotelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HotelToolStripMenuItem.Click
        InfoHotel.ShowDialog()

    End Sub

    Private Sub KantorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KantorToolStripMenuItem1.Click
        EditForm.ShowDialog()

    End Sub

    Private Sub RumahSakitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RumahSakitToolStripMenuItem.Click
        EditRS.ShowDialog()

    End Sub

    Private Sub FasilitasLainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FasilitasLainToolStripMenuItem.Click
        EditResto.ShowDialog()

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        managerLayer(CheckBox1.Checked, "1A.kml", "c:\1A.kml")
        AxGEPluginX1.ApplicationGE.SetCameraParams(100, 100, 100, AltitudeModeGE.RelativeToGroundAltitudeGE, 100, 10, 10, 10)
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRumahSakit.CheckedChanged
        managerLayer(cboRumahSakit.Checked, "RS.kml", "c:\RS.kml")
    End Sub

    Private Sub CheckBox4_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        managerLayer(CheckBox4.Checked, "2B.kml", "c:\2B.kml")
    End Sub

    Private Sub CheckBox5_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        managerLayer(CheckBox5.Checked, "3A.kml", "c:\3A.kml")
    End Sub

    Private Sub CheckBox26_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox26.CheckedChanged
        managerLayer(CheckBox26.Checked, "bangunan.kml", "c:\bangunan.kml")
    End Sub

    Private Sub CheckBox20_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox20.CheckedChanged
        managerLayer(CheckBox20.Checked, "kantorkelurahan.kml", "c:\kantorkelurahan.kml")
    End Sub

    Private Sub CheckBox22_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox22.CheckedChanged
        managerLayer(CheckBox22.Checked, "polisi.kml", "c:\polisi.kml")
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        managerLayer(CheckBox8.Checked, "puskesmas.kml", "c:\puskesmas.kml")
    End Sub

    Private Sub CheckBox23_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox23.CheckedChanged
        managerLayer(CheckBox23.Checked, "apotek.kml", "c:\apotek.kml")
    End Sub

    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        managerLayer(CheckBox14.Checked, "SMP.kml", "c:\smp.kml")
    End Sub

    Private Sub CheckBox15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox15.CheckedChanged
        managerLayer(CheckBox15.Checked, "SMU.kml", "c:\smu.kml")
    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        managerLayer(CheckBox13.Checked, "perpus.kml", "c:\perpus.kml")
    End Sub

    Private Sub CheckBox24_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox24.CheckedChanged
        managerLayer(CheckBox24.Checked, "PT.kml", "c:\PT.kml")
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        managerLayer(CheckBox16.Checked, "hotel", "c:\hotel.kml")
    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged
        managerLayer(CheckBox17.Checked, "resto.kml", "c:\resto.kml")
    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged
        managerLayer(CheckBox18.Checked, "mall.kml", "c:\mall.kml")
    End Sub

    Private Sub cboHalteTrans_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboHalteTrans.CheckedChanged
        managerLayer(cboHalteTrans.Checked, "halte.kml", "c:\halte.kml")
    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        managerLayer(CheckBox10.Checked, "term.kml", "c:\term,kml")
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        managerLayer(CheckBox11.Checked, "stasiun.kml", "c:\stasiun.kml")
    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        managerLayer(CheckBox9.Checked, "bandara.kml", "c:\bandara.kml")
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        managerLayer(CheckBox12.Checked, "operator.kml", "c:\operator.kml")
    End Sub

    Private Sub CheckBox2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        managerLayer(CheckBox2.Checked, "1B.kml", "c:\1B.kml")
    End Sub

    Private Sub CheckBox3_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        managerLayer(CheckBox3.Checked, "2A.kml", "c:\2A.kml")
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        managerLayer(CheckBox6.Checked, "3B.kml", "c:\3B.kml")
    End Sub

    Private Sub CheckBox7_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        managerLayer(CheckBox7.Checked, "mc.kml", "c:\mc.kml")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

   

    Private Sub ButtonInfoRingkas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonInfoRingkas.Click
        cari = "info singkat"
        'FormHasilPencarian.Show()
        lstHasilCari.Text = ""

        Dim sqlConnection1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\SiGE.accdb")
        Dim cmd As New OleDbCommand
        Dim reader As OleDbDataReader
        Dim i As Integer
        Dim recordData As String = ""
        Dim recordCount As Integer = 0
        Dim info As String

        '== nama instansi
        cmd.CommandText = "SELECT nm_kantor,alamat,no_telp FROM [nama instansi] WHERE (nm_kantor LIKE '%" & TextBoxInfoRingkas.Text & "%')"
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        lstHasilCari.Items.Clear()
        While reader.Read()
            info = reader(0).ToString & "-" & reader(2).ToString & "-" & reader(1).ToString
            lstHasilCari.Items.Add(info & lstHasilCari.Text)
        End While

        reader.Close()

        ' ==== hotel
        cmd.CommandText = "SELECT nama_hotel,alamat,no_telp FROM [hotel] WHERE (nama_hotel LIKE '%" & TextBoxInfoRingkas.Text & "%')"
        cmd.CommandType = CommandType.Text
        cmd.Connection = sqlConnection1

        reader = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        While reader.Read()
            info = reader(0).ToString & "-" & reader(2).ToString & "-" & reader(1).ToString
            lstHasilCari.Items.Add(info & lstHasilCari.Text)
        End While

        reader.Close()
        '==

        sqlConnection1.Close()
    End Sub
End Class