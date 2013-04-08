<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoKantor
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
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim No_telpLabel As System.Windows.Forms.Label
        Dim No_faxLabel As System.Windows.Forms.Label
        Dim Jam_bukaLabel As System.Windows.Forms.Label
        Dim SitusLabel As System.Windows.Forms.Label
        Dim MotoLabel As System.Windows.Forms.Label
        Dim Info_LainLabel As System.Windows.Forms.Label
        Dim HTMLLabel As System.Windows.Forms.Label
        Dim FasilitasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoKantor))
        Me.Nama_instansiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Nama_instansiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiGEDataSet = New SIGE2.SiGEDataSet
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Nm_kantorTextBox = New System.Windows.Forms.TextBox
        Me.AlamatTextBox = New System.Windows.Forms.TextBox
        Me.No_telpTextBox = New System.Windows.Forms.TextBox
        Me.No_faxTextBox = New System.Windows.Forms.TextBox
        Me.Jam_bukaTextBox = New System.Windows.Forms.TextBox
        Me.SitusTextBox = New System.Windows.Forms.TextBox
        Me.MotoTextBox = New System.Windows.Forms.TextBox
        Me.FotoTextBox = New System.Windows.Forms.TextBox
        Me.Info_LainTextBox = New System.Windows.Forms.TextBox
        Me.HTMLTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.FasilitasTextBox = New System.Windows.Forms.TextBox
        Me.Nama_instansiTableAdapter = New SIGE2.SiGEDataSetTableAdapters.Nama_instansiTableAdapter
        Me.TableAdapterManager = New SIGE2.SiGEDataSetTableAdapters.TableAdapterManager
        Me.HTMLTextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        AlamatLabel = New System.Windows.Forms.Label
        No_telpLabel = New System.Windows.Forms.Label
        No_faxLabel = New System.Windows.Forms.Label
        Jam_bukaLabel = New System.Windows.Forms.Label
        SitusLabel = New System.Windows.Forms.Label
        MotoLabel = New System.Windows.Forms.Label
        Info_LainLabel = New System.Windows.Forms.Label
        HTMLLabel = New System.Windows.Forms.Label
        FasilitasLabel = New System.Windows.Forms.Label
        CType(Me.Nama_instansiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Nama_instansiBindingNavigator.SuspendLayout()
        CType(Me.Nama_instansiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(21, 22)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(64, 22)
        AlamatLabel.TabIndex = 7
        AlamatLabel.Text = "Alamat:"
        '
        'No_telpLabel
        '
        No_telpLabel.AutoSize = True
        No_telpLabel.Location = New System.Drawing.Point(21, 67)
        No_telpLabel.Name = "No_telpLabel"
        No_telpLabel.Size = New System.Drawing.Size(64, 22)
        No_telpLabel.TabIndex = 9
        No_telpLabel.Text = "No telp:"
        '
        'No_faxLabel
        '
        No_faxLabel.AutoSize = True
        No_faxLabel.Location = New System.Drawing.Point(22, 111)
        No_faxLabel.Name = "No_faxLabel"
        No_faxLabel.Size = New System.Drawing.Size(60, 22)
        No_faxLabel.TabIndex = 11
        No_faxLabel.Text = "No fax:"
        '
        'Jam_bukaLabel
        '
        Jam_bukaLabel.AutoSize = True
        Jam_bukaLabel.Location = New System.Drawing.Point(22, 158)
        Jam_bukaLabel.Name = "Jam_bukaLabel"
        Jam_bukaLabel.Size = New System.Drawing.Size(80, 22)
        Jam_bukaLabel.TabIndex = 13
        Jam_bukaLabel.Text = "Jam buka:"
        '
        'SitusLabel
        '
        SitusLabel.AutoSize = True
        SitusLabel.Location = New System.Drawing.Point(22, 269)
        SitusLabel.Name = "SitusLabel"
        SitusLabel.Size = New System.Drawing.Size(47, 22)
        SitusLabel.TabIndex = 15
        SitusLabel.Text = "Situs:"
        '
        'MotoLabel
        '
        MotoLabel.AutoSize = True
        MotoLabel.Location = New System.Drawing.Point(22, 203)
        MotoLabel.Name = "MotoLabel"
        MotoLabel.Size = New System.Drawing.Size(50, 22)
        MotoLabel.TabIndex = 17
        MotoLabel.Text = "Moto:"
        '
        'Info_LainLabel
        '
        Info_LainLabel.AutoSize = True
        Info_LainLabel.Location = New System.Drawing.Point(274, 590)
        Info_LainLabel.Name = "Info_LainLabel"
        Info_LainLabel.Size = New System.Drawing.Size(51, 13)
        Info_LainLabel.TabIndex = 31
        Info_LainLabel.Text = "Info Lain:"
        Info_LainLabel.Visible = False
        '
        'HTMLLabel
        '
        HTMLLabel.AutoSize = True
        HTMLLabel.Location = New System.Drawing.Point(285, 652)
        HTMLLabel.Name = "HTMLLabel"
        HTMLLabel.Size = New System.Drawing.Size(40, 13)
        HTMLLabel.TabIndex = 37
        HTMLLabel.Text = "HTML:"
        HTMLLabel.Visible = False
        '
        'FasilitasLabel
        '
        FasilitasLabel.AutoSize = True
        FasilitasLabel.Location = New System.Drawing.Point(16, 372)
        FasilitasLabel.Name = "FasilitasLabel"
        FasilitasLabel.Size = New System.Drawing.Size(68, 22)
        FasilitasLabel.TabIndex = 23
        FasilitasLabel.Text = "Fasilitas:"
        '
        'Nama_instansiBindingNavigator
        '
        Me.Nama_instansiBindingNavigator.AddNewItem = Nothing
        Me.Nama_instansiBindingNavigator.BindingSource = Me.Nama_instansiBindingSource
        Me.Nama_instansiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Nama_instansiBindingNavigator.DeleteItem = Nothing
        Me.Nama_instansiBindingNavigator.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama_instansiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Nama_instansiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Nama_instansiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Nama_instansiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Nama_instansiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Nama_instansiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Nama_instansiBindingNavigator.Name = "Nama_instansiBindingNavigator"
        Me.Nama_instansiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Nama_instansiBindingNavigator.Size = New System.Drawing.Size(985, 25)
        Me.Nama_instansiBindingNavigator.TabIndex = 0
        Me.Nama_instansiBindingNavigator.Text = "BindingNavigator1"
        '
        'Nama_instansiBindingSource
        '
        Me.Nama_instansiBindingSource.DataMember = "Nama instansi"
        Me.Nama_instansiBindingSource.DataSource = Me.SiGEDataSet
        '
        'SiGEDataSet
        '
        Me.SiGEDataSet.DataSetName = "SiGEDataSet"
        Me.SiGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
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
        'Nm_kantorTextBox
        '
        Me.Nm_kantorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "Nm_kantor", True))
        Me.Nm_kantorTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nm_kantorTextBox.Location = New System.Drawing.Point(20, 43)
        Me.Nm_kantorTextBox.Name = "Nm_kantorTextBox"
        Me.Nm_kantorTextBox.Size = New System.Drawing.Size(332, 29)
        Me.Nm_kantorTextBox.TabIndex = 4
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "Alamat", True))
        Me.AlamatTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatTextBox.Location = New System.Drawing.Point(101, 19)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(485, 29)
        Me.AlamatTextBox.TabIndex = 8
        '
        'No_telpTextBox
        '
        Me.No_telpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "No_telp", True))
        Me.No_telpTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_telpTextBox.Location = New System.Drawing.Point(101, 64)
        Me.No_telpTextBox.Name = "No_telpTextBox"
        Me.No_telpTextBox.Size = New System.Drawing.Size(295, 29)
        Me.No_telpTextBox.TabIndex = 10
        '
        'No_faxTextBox
        '
        Me.No_faxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "No_fax", True))
        Me.No_faxTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_faxTextBox.Location = New System.Drawing.Point(102, 108)
        Me.No_faxTextBox.Name = "No_faxTextBox"
        Me.No_faxTextBox.Size = New System.Drawing.Size(294, 29)
        Me.No_faxTextBox.TabIndex = 12
        '
        'Jam_bukaTextBox
        '
        Me.Jam_bukaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "Jam buka", True))
        Me.Jam_bukaTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jam_bukaTextBox.Location = New System.Drawing.Point(102, 155)
        Me.Jam_bukaTextBox.Name = "Jam_bukaTextBox"
        Me.Jam_bukaTextBox.Size = New System.Drawing.Size(294, 29)
        Me.Jam_bukaTextBox.TabIndex = 14
        '
        'SitusTextBox
        '
        Me.SitusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "Situs", True))
        Me.SitusTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SitusTextBox.Location = New System.Drawing.Point(102, 266)
        Me.SitusTextBox.Name = "SitusTextBox"
        Me.SitusTextBox.Size = New System.Drawing.Size(294, 29)
        Me.SitusTextBox.TabIndex = 16
        '
        'MotoTextBox
        '
        Me.MotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "Moto", True))
        Me.MotoTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotoTextBox.Location = New System.Drawing.Point(102, 200)
        Me.MotoTextBox.Multiline = True
        Me.MotoTextBox.Name = "MotoTextBox"
        Me.MotoTextBox.Size = New System.Drawing.Size(294, 45)
        Me.MotoTextBox.TabIndex = 18
        '
        'FotoTextBox
        '
        Me.FotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "Foto", True))
        Me.FotoTextBox.Location = New System.Drawing.Point(225, 315)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FotoTextBox.TabIndex = 26
        '
        'Info_LainTextBox
        '
        Me.Info_LainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "Info Lain", True))
        Me.Info_LainTextBox.Location = New System.Drawing.Point(354, 587)
        Me.Info_LainTextBox.Name = "Info_LainTextBox"
        Me.Info_LainTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Info_LainTextBox.TabIndex = 32
        Me.Info_LainTextBox.Visible = False
        '
        'HTMLTextBox
        '
        Me.HTMLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "HTML", True))
        Me.HTMLTextBox.Location = New System.Drawing.Point(354, 645)
        Me.HTMLTextBox.Name = "HTMLTextBox"
        Me.HTMLTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HTMLTextBox.TabIndex = 38
        Me.HTMLTextBox.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(20, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 266)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(358, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(607, 521)
        Me.TabControl1.TabIndex = 40
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.AlamatTextBox)
        Me.TabPage1.Controls.Add(AlamatLabel)
        Me.TabPage1.Controls.Add(No_telpLabel)
        Me.TabPage1.Controls.Add(Me.No_telpTextBox)
        Me.TabPage1.Controls.Add(No_faxLabel)
        Me.TabPage1.Controls.Add(Me.MotoTextBox)
        Me.TabPage1.Controls.Add(MotoLabel)
        Me.TabPage1.Controls.Add(Me.No_faxTextBox)
        Me.TabPage1.Controls.Add(Me.SitusTextBox)
        Me.TabPage1.Controls.Add(Jam_bukaLabel)
        Me.TabPage1.Controls.Add(SitusLabel)
        Me.TabPage1.Controls.Add(Me.Jam_bukaTextBox)
        Me.TabPage1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(599, 495)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(434, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Go !!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser1)
        Me.TabPage2.Controls.Add(Me.FasilitasTextBox)
        Me.TabPage2.Controls.Add(FasilitasLabel)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(599, 495)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pelayanan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(19, 16)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(574, 336)
        Me.WebBrowser1.TabIndex = 25
        '
        'FasilitasTextBox
        '
        Me.FasilitasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "Fasilitas", True))
        Me.FasilitasTextBox.Location = New System.Drawing.Point(69, 372)
        Me.FasilitasTextBox.Multiline = True
        Me.FasilitasTextBox.Name = "FasilitasTextBox"
        Me.FasilitasTextBox.Size = New System.Drawing.Size(524, 107)
        Me.FasilitasTextBox.TabIndex = 24
        '
        'Nama_instansiTableAdapter
        '
        Me.Nama_instansiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.hotelTableAdapter = Nothing
        Me.TableAdapterManager.infopentingTableAdapter = Nothing
        Me.TableAdapterManager.JalanTableAdapter = Nothing
        Me.TableAdapterManager.Jenis_FasilitasTableAdapter = Nothing
        Me.TableAdapterManager.KategoriTableAdapter = Nothing
        Me.TableAdapterManager.KMLTableAdapter = Nothing
        Me.TableAdapterManager.Nama_instansiTableAdapter = Me.Nama_instansiTableAdapter
        Me.TableAdapterManager.PendidikanTableAdapter = Nothing
        Me.TableAdapterManager.restoTableAdapter = Nothing
        Me.TableAdapterManager.RSTableAdapter = Nothing
        Me.TableAdapterManager.TransportTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGE2.SiGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HTMLTextBox1
        '
        Me.HTMLTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Nama_instansiBindingSource, "HTML", True))
        Me.HTMLTextBox1.Location = New System.Drawing.Point(105, 374)
        Me.HTMLTextBox1.Name = "HTMLTextBox1"
        Me.HTMLTextBox1.Size = New System.Drawing.Size(81, 20)
        Me.HTMLTextBox1.TabIndex = 41
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "&Tutup"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'InfoKantor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 705)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.HTMLTextBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Nm_kantorTextBox)
        Me.Controls.Add(Me.FotoTextBox)
        Me.Controls.Add(Info_LainLabel)
        Me.Controls.Add(Me.Info_LainTextBox)
        Me.Controls.Add(HTMLLabel)
        Me.Controls.Add(Me.HTMLTextBox)
        Me.Controls.Add(Me.Nama_instansiBindingNavigator)
        Me.MaximizeBox = False
        Me.Name = "InfoKantor"
        Me.Text = "InfoKantor"
        CType(Me.Nama_instansiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Nama_instansiBindingNavigator.ResumeLayout(False)
        Me.Nama_instansiBindingNavigator.PerformLayout()
        CType(Me.Nama_instansiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SiGEDataSet As SIGE2.SiGEDataSet
    Friend WithEvents Nama_instansiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nama_instansiTableAdapter As SIGE2.SiGEDataSetTableAdapters.Nama_instansiTableAdapter
    Friend WithEvents TableAdapterManager As SIGE2.SiGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Nama_instansiBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Nm_kantorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_faxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jam_bukaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SitusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Info_LainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HTMLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents HTMLTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents FasilitasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
