<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim SitusLabel As System.Windows.Forms.Label
        Dim MotoLabel As System.Windows.Forms.Label
        Dim Jam_bukaLabel As System.Windows.Forms.Label
        Dim No_faxLabel As System.Windows.Forms.Label
        Dim No_telpLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim CoordinatesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditForm))
        Me.Fasilitas = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SitusTextBox = New System.Windows.Forms.TextBox
        Me.NamaInstansiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiGEDataSet = New SIGE2.SiGEDataSet
        Me.MotoTextBox = New System.Windows.Forms.TextBox
        Me.Jam_bukaTextBox = New System.Windows.Forms.TextBox
        Me.No_faxTextBox = New System.Windows.Forms.TextBox
        Me.No_telpTextBox = New System.Windows.Forms.TextBox
        Me.AlamatTextBox = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.PelayananTextBox = New System.Windows.Forms.TextBox
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Button3 = New System.Windows.Forms.Button
        Me.HTMLTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Button7 = New System.Windows.Forms.Button
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabControl4 = New System.Windows.Forms.TabControl
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TabPage14 = New System.Windows.Forms.TabPage
        Me.WebBrowser4 = New System.Windows.Forms.WebBrowser
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.FasilitasTextBox = New System.Windows.Forms.TextBox
        Me.picPoto = New System.Windows.Forms.PictureBox
        Me.Nm_kantorTextBox = New System.Windows.Forms.TextBox
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.Gambar = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FotoTextBox = New System.Windows.Forms.TextBox
        Me.Nama_instansiTableAdapter = New SIGE2.SiGEDataSetTableAdapters.Nama_instansiTableAdapter
        Me.KMLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamaInstansiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KMLTableAdapter = New SIGE2.SiGEDataSetTableAdapters.KMLTableAdapter
        Me.TableAdapterManager = New SIGE2.SiGEDataSetTableAdapters.TableAdapterManager
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TabPage11 = New System.Windows.Forms.TabPage
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser
        Me.Button5 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.TabPage12 = New System.Windows.Forms.TabPage
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TabPage13 = New System.Windows.Forms.TabPage
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser
        Me.Button6 = New System.Windows.Forms.Button
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CoordinatesTextBox = New System.Windows.Forms.TextBox
        SitusLabel = New System.Windows.Forms.Label
        MotoLabel = New System.Windows.Forms.Label
        Jam_bukaLabel = New System.Windows.Forms.Label
        No_faxLabel = New System.Windows.Forms.Label
        No_telpLabel = New System.Windows.Forms.Label
        AlamatLabel = New System.Windows.Forms.Label
        FotoLabel = New System.Windows.Forms.Label
        CoordinatesLabel = New System.Windows.Forms.Label
        Me.Fasilitas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.NamaInstansiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabControl4.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.picPoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.KMLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamaInstansiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.TabPage11.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.SuspendLayout()
        '
        'SitusLabel
        '
        SitusLabel.AutoSize = True
        SitusLabel.Location = New System.Drawing.Point(6, 255)
        SitusLabel.Name = "SitusLabel"
        SitusLabel.Size = New System.Drawing.Size(41, 18)
        SitusLabel.TabIndex = 13
        SitusLabel.Text = "Situs:"
        '
        'MotoLabel
        '
        MotoLabel.AutoSize = True
        MotoLabel.Location = New System.Drawing.Point(6, 187)
        MotoLabel.Name = "MotoLabel"
        MotoLabel.Size = New System.Drawing.Size(73, 18)
        MotoLabel.TabIndex = 12
        MotoLabel.Text = "Moto/Visi :"
        '
        'Jam_bukaLabel
        '
        Jam_bukaLabel.AutoSize = True
        Jam_bukaLabel.Location = New System.Drawing.Point(8, 142)
        Jam_bukaLabel.Name = "Jam_bukaLabel"
        Jam_bukaLabel.Size = New System.Drawing.Size(67, 18)
        Jam_bukaLabel.TabIndex = 11
        Jam_bukaLabel.Text = "Jam buka:"
        '
        'No_faxLabel
        '
        No_faxLabel.AutoSize = True
        No_faxLabel.Location = New System.Drawing.Point(6, 101)
        No_faxLabel.Name = "No_faxLabel"
        No_faxLabel.Size = New System.Drawing.Size(50, 18)
        No_faxLabel.TabIndex = 10
        No_faxLabel.Text = "No fax:"
        '
        'No_telpLabel
        '
        No_telpLabel.AutoSize = True
        No_telpLabel.Location = New System.Drawing.Point(6, 59)
        No_telpLabel.Name = "No_telpLabel"
        No_telpLabel.Size = New System.Drawing.Size(55, 18)
        No_telpLabel.TabIndex = 9
        No_telpLabel.Text = "No telp:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(10, 12)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(56, 18)
        AlamatLabel.TabIndex = 8
        AlamatLabel.Text = "Alamat:"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Location = New System.Drawing.Point(14, 298)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(31, 13)
        FotoLabel.TabIndex = 31
        FotoLabel.Text = "Foto:"
        FotoLabel.Visible = False
        '
        'CoordinatesLabel
        '
        CoordinatesLabel.AutoSize = True
        CoordinatesLabel.Location = New System.Drawing.Point(106, 416)
        CoordinatesLabel.Name = "CoordinatesLabel"
        CoordinatesLabel.Size = New System.Drawing.Size(129, 13)
        CoordinatesLabel.TabIndex = 33
        CoordinatesLabel.Text = "Tentukan Lokasi (X,Y,Z) :"
        AddHandler CoordinatesLabel.Click, AddressOf Me.CoordinatesLabel_Click
        '
        'Fasilitas
        '
        Me.Fasilitas.Controls.Add(Me.TabPage1)
        Me.Fasilitas.Controls.Add(Me.TabPage2)
        Me.Fasilitas.Controls.Add(Me.TabPage3)
        Me.Fasilitas.Controls.Add(Me.TabPage5)
        Me.Fasilitas.Controls.Add(Me.TabPage6)
        Me.Fasilitas.Controls.Add(Me.TabPage4)
        Me.Fasilitas.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fasilitas.Location = New System.Drawing.Point(372, 40)
        Me.Fasilitas.Name = "Fasilitas"
        Me.Fasilitas.SelectedIndex = 0
        Me.Fasilitas.Size = New System.Drawing.Size(591, 444)
        Me.Fasilitas.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(SitusLabel)
        Me.TabPage1.Controls.Add(Me.SitusTextBox)
        Me.TabPage1.Controls.Add(MotoLabel)
        Me.TabPage1.Controls.Add(Me.MotoTextBox)
        Me.TabPage1.Controls.Add(Jam_bukaLabel)
        Me.TabPage1.Controls.Add(Me.Jam_bukaTextBox)
        Me.TabPage1.Controls.Add(No_faxLabel)
        Me.TabPage1.Controls.Add(Me.No_faxTextBox)
        Me.TabPage1.Controls.Add(No_telpLabel)
        Me.TabPage1.Controls.Add(Me.No_telpTextBox)
        Me.TabPage1.Controls.Add(AlamatLabel)
        Me.TabPage1.Controls.Add(Me.AlamatTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(583, 418)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SitusTextBox
        '
        Me.SitusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Situs", True))
        Me.SitusTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SitusTextBox.Location = New System.Drawing.Point(81, 251)
        Me.SitusTextBox.Name = "SitusTextBox"
        Me.SitusTextBox.Size = New System.Drawing.Size(218, 26)
        Me.SitusTextBox.TabIndex = 14
        '
        'NamaInstansiBindingSource
        '
        Me.NamaInstansiBindingSource.DataMember = "Nama instansi"
        Me.NamaInstansiBindingSource.DataSource = Me.SiGEDataSet
        '
        'SiGEDataSet
        '
        Me.SiGEDataSet.DataSetName = "SiGEDataSet"
        Me.SiGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MotoTextBox
        '
        Me.MotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Moto", True))
        Me.MotoTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotoTextBox.Location = New System.Drawing.Point(81, 181)
        Me.MotoTextBox.Multiline = True
        Me.MotoTextBox.Name = "MotoTextBox"
        Me.MotoTextBox.Size = New System.Drawing.Size(392, 51)
        Me.MotoTextBox.TabIndex = 13
        '
        'Jam_bukaTextBox
        '
        Me.Jam_bukaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Jam buka", True))
        Me.Jam_bukaTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jam_bukaTextBox.Location = New System.Drawing.Point(81, 138)
        Me.Jam_bukaTextBox.Name = "Jam_bukaTextBox"
        Me.Jam_bukaTextBox.Size = New System.Drawing.Size(220, 26)
        Me.Jam_bukaTextBox.TabIndex = 12
        '
        'No_faxTextBox
        '
        Me.No_faxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "No_fax", True))
        Me.No_faxTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_faxTextBox.Location = New System.Drawing.Point(81, 97)
        Me.No_faxTextBox.Name = "No_faxTextBox"
        Me.No_faxTextBox.Size = New System.Drawing.Size(220, 26)
        Me.No_faxTextBox.TabIndex = 11
        '
        'No_telpTextBox
        '
        Me.No_telpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "No_telp", True))
        Me.No_telpTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_telpTextBox.Location = New System.Drawing.Point(81, 55)
        Me.No_telpTextBox.Name = "No_telpTextBox"
        Me.No_telpTextBox.Size = New System.Drawing.Size(220, 26)
        Me.No_telpTextBox.TabIndex = 10
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Alamat", True))
        Me.AlamatTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatTextBox.Location = New System.Drawing.Point(81, 8)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(444, 26)
        Me.AlamatTextBox.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.TabControl1)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.HTMLTextBox)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(583, 418)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pelayanan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Location = New System.Drawing.Point(10, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(495, 391)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.PelayananTextBox)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(487, 365)
        Me.TabPage7.TabIndex = 0
        Me.TabPage7.Text = "Content"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'PelayananTextBox
        '
        Me.PelayananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Pelayanan", True))
        Me.PelayananTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PelayananTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PelayananTextBox.Location = New System.Drawing.Point(3, 3)
        Me.PelayananTextBox.Multiline = True
        Me.PelayananTextBox.Name = "PelayananTextBox"
        Me.PelayananTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PelayananTextBox.Size = New System.Drawing.Size(481, 359)
        Me.PelayananTextBox.TabIndex = 3
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.WebBrowser1)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(487, 365)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "HTML"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(481, 359)
        Me.WebBrowser1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(423, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Cari"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HTMLTextBox
        '
        Me.HTMLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "HTML", True))
        Me.HTMLTextBox.Location = New System.Drawing.Point(172, 5)
        Me.HTMLTextBox.Name = "HTMLTextBox"
        Me.HTMLTextBox.Size = New System.Drawing.Size(245, 25)
        Me.HTMLTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "File HTML"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(583, 418)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Prosedur"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(15, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(482, 400)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button7)
        Me.TabPage5.Controls.Add(Me.TextBox6)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Controls.Add(Me.TabControl4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(583, 418)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Biaya"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(429, 6)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Cari"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "HTML", True))
        Me.TextBox6.Location = New System.Drawing.Point(178, 6)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(245, 25)
        Me.TextBox6.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(116, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "File HTML"
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabPage9)
        Me.TabControl4.Controls.Add(Me.TabPage14)
        Me.TabControl4.Location = New System.Drawing.Point(16, 31)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(495, 391)
        Me.TabControl4.TabIndex = 8
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.TextBox5)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(487, 365)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "Content"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Pelayanan", True))
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(3, 3)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox5.Size = New System.Drawing.Size(481, 359)
        Me.TextBox5.TabIndex = 3
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.WebBrowser4)
        Me.TabPage14.Location = New System.Drawing.Point(4, 22)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(487, 365)
        Me.TabPage14.TabIndex = 1
        Me.TabPage14.Text = "HTML"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'WebBrowser4
        '
        Me.WebBrowser4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser4.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser4.Name = "WebBrowser4"
        Me.WebBrowser4.Size = New System.Drawing.Size(481, 359)
        Me.WebBrowser4.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.RichTextBox2)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(583, 418)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Info Lain"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Info lain", True))
        Me.RichTextBox2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.Location = New System.Drawing.Point(19, 39)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(473, 353)
        Me.RichTextBox2.TabIndex = 2
        Me.RichTextBox2.Text = ""
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.FasilitasTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(583, 418)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Fasilitas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'FasilitasTextBox
        '
        Me.FasilitasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Fasilitas", True))
        Me.FasilitasTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FasilitasTextBox.Location = New System.Drawing.Point(31, 22)
        Me.FasilitasTextBox.Multiline = True
        Me.FasilitasTextBox.Name = "FasilitasTextBox"
        Me.FasilitasTextBox.Size = New System.Drawing.Size(446, 256)
        Me.FasilitasTextBox.TabIndex = 1
        '
        'picPoto
        '
        Me.picPoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picPoto.Location = New System.Drawing.Point(12, 82)
        Me.picPoto.Name = "picPoto"
        Me.picPoto.Size = New System.Drawing.Size(346, 233)
        Me.picPoto.TabIndex = 12
        Me.picPoto.TabStop = False
        '
        'Nm_kantorTextBox
        '
        Me.Nm_kantorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Nm_kantor", True))
        Me.Nm_kantorTextBox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nm_kantorTextBox.Location = New System.Drawing.Point(12, 40)
        Me.Nm_kantorTextBox.Name = "Nm_kantorTextBox"
        Me.Nm_kantorTextBox.Size = New System.Drawing.Size(346, 25)
        Me.Nm_kantorTextBox.TabIndex = 17
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.NamaInstansiBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(975, 25)
        Me.BindingNavigator1.TabIndex = 18
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 25)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton1.Text = "Simpan"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripButton2.Text = "Batal"
        '
        'Gambar
        '
        Me.Gambar.Location = New System.Drawing.Point(135, 336)
        Me.Gambar.Name = "Gambar"
        Me.Gambar.Size = New System.Drawing.Size(82, 37)
        Me.Gambar.TabIndex = 28
        Me.Gambar.Text = "Pilih Gambar"
        Me.Gambar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.jpg"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "All Files|*.*|JPG|*.jpg|JPEG|*.jpeg|Bitmap|*.bmp|GIF|*.gif"
        '
        'FotoTextBox
        '
        Me.FotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Foto", True))
        Me.FotoTextBox.Location = New System.Drawing.Point(51, 295)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FotoTextBox.TabIndex = 32
        '
        'Nama_instansiTableAdapter
        '
        Me.Nama_instansiTableAdapter.ClearBeforeFill = True
        '
        'KMLBindingSource
        '
        Me.KMLBindingSource.DataMember = "KML"
        Me.KMLBindingSource.DataSource = Me.SiGEDataSet
        '
        'NamaInstansiBindingSource1
        '
        Me.NamaInstansiBindingSource1.DataMember = "Nama instansi"
        Me.NamaInstansiBindingSource1.DataSource = Me.SiGEDataSet
        '
        'KMLTableAdapter
        '
        Me.KMLTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.hotelTableAdapter = Nothing
        Me.TableAdapterManager.infopentingTableAdapter = Nothing
        Me.TableAdapterManager.JalanTableAdapter = Nothing
        Me.TableAdapterManager.Jenis_FasilitasTableAdapter = Nothing
        Me.TableAdapterManager.KategoriTableAdapter = Nothing
        Me.TableAdapterManager.KMLTableAdapter = Me.KMLTableAdapter
        Me.TableAdapterManager.Nama_instansiTableAdapter = Me.Nama_instansiTableAdapter
        Me.TableAdapterManager.PendidikanTableAdapter = Nothing
        Me.TableAdapterManager.restoTableAdapter = Nothing
        Me.TableAdapterManager.RSTableAdapter = Nothing
        Me.TableAdapterManager.TransportTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGE2.SiGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage10)
        Me.TabControl2.Controls.Add(Me.TabPage11)
        Me.TabControl2.Location = New System.Drawing.Point(10, 33)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(495, 391)
        Me.TabControl2.TabIndex = 7
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.TextBox1)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(487, 365)
        Me.TabPage10.TabIndex = 0
        Me.TabPage10.Text = "Content"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Pelayanan", True))
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(481, 359)
        Me.TextBox1.TabIndex = 3
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.WebBrowser2)
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(487, 365)
        Me.TabPage11.TabIndex = 1
        Me.TabPage11.Text = "HTML"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(481, 359)
        Me.WebBrowser2.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(321, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "HTML", True))
        Me.TextBox2.Location = New System.Drawing.Point(69, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(245, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "File HTML"
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage12)
        Me.TabControl3.Controls.Add(Me.TabPage13)
        Me.TabControl3.Location = New System.Drawing.Point(10, 33)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(495, 391)
        Me.TabControl3.TabIndex = 7
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.TextBox3)
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(487, 365)
        Me.TabPage12.TabIndex = 0
        Me.TabPage12.Text = "Content"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Pelayanan", True))
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(3, 3)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox3.Size = New System.Drawing.Size(481, 359)
        Me.TextBox3.TabIndex = 3
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.WebBrowser3)
        Me.TabPage13.Location = New System.Drawing.Point(4, 22)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(487, 365)
        Me.TabPage13.TabIndex = 1
        Me.TabPage13.Text = "HTML"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser3.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.Size = New System.Drawing.Size(481, 359)
        Me.WebBrowser3.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(321, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Cari"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "HTML", True))
        Me.TextBox4.Location = New System.Drawing.Point(69, 5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(245, 20)
        Me.TextBox4.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "File HTML"
        '
        'CoordinatesTextBox
        '
        Me.CoordinatesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NamaInstansiBindingSource, "Coordinates", True))
        Me.CoordinatesTextBox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoordinatesTextBox.Location = New System.Drawing.Point(51, 446)
        Me.CoordinatesTextBox.Name = "CoordinatesTextBox"
        Me.CoordinatesTextBox.Size = New System.Drawing.Size(253, 25)
        Me.CoordinatesTextBox.TabIndex = 34
        '
        'EditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 517)
        Me.Controls.Add(CoordinatesLabel)
        Me.Controls.Add(Me.CoordinatesTextBox)
        Me.Controls.Add(Me.picPoto)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(Me.FotoTextBox)
        Me.Controls.Add(Me.Gambar)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Nm_kantorTextBox)
        Me.Controls.Add(Me.Fasilitas)
        Me.Name = "EditForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Editing"
        Me.Fasilitas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.NamaInstansiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage9.PerformLayout()
        Me.TabPage14.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.picPoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.KMLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamaInstansiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.TabPage11.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        Me.TabPage13.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fasilitas As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SitusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jam_bukaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_faxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents FasilitasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents picPoto As System.Windows.Forms.PictureBox
    Friend WithEvents Nm_kantorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Gambar As System.Windows.Forms.Button
    Friend WithEvents SiGEDataSet As SIGE2.SiGEDataSet
    Friend WithEvents NamaInstansiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nama_instansiTableAdapter As SIGE2.SiGEDataSetTableAdapters.Nama_instansiTableAdapter
    Friend WithEvents NamaInstansiBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KMLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KMLTableAdapter As SIGE2.SiGEDataSetTableAdapters.KMLTableAdapter
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TableAdapterManager As SIGE2.SiGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PelayananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents HTMLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage14 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser4 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser3 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CoordinatesTextBox As System.Windows.Forms.TextBox
End Class
