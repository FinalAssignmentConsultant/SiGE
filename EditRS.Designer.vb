<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditRS
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
        Dim CoordinatesLabel As System.Windows.Forms.Label
        Dim No_telpLabel As System.Windows.Forms.Label
        Dim No_faxLabel As System.Windows.Forms.Label
        Dim MotoLabel As System.Windows.Forms.Label
        Dim SitusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditRS))
        Dim HTMLLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Me.RSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Nm_RSTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SitusTextBox = New System.Windows.Forms.TextBox
        Me.MotoTextBox = New System.Windows.Forms.TextBox
        Me.No_faxTextBox = New System.Windows.Forms.TextBox
        Me.No_telpTextBox = New System.Windows.Forms.TextBox
        Me.AlamatTextBox = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PelayananTextBox = New System.Windows.Forms.TextBox
        Me.FasilitasTextBox = New System.Windows.Forms.TextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.picPoto = New System.Windows.Forms.PictureBox
        Me.CoordinatesTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.HTMLTextBox = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.RSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiGEDataSet4 = New SIGE2.SiGEDataSet4
        Me.RSTableAdapter = New SIGE2.SiGEDataSet4TableAdapters.RSTableAdapter
        Me.TableAdapterManager = New SIGE2.SiGEDataSet4TableAdapters.TableAdapterManager
        Me.FotoTextBox = New System.Windows.Forms.TextBox
        AlamatLabel = New System.Windows.Forms.Label
        CoordinatesLabel = New System.Windows.Forms.Label
        No_telpLabel = New System.Windows.Forms.Label
        No_faxLabel = New System.Windows.Forms.Label
        MotoLabel = New System.Windows.Forms.Label
        SitusLabel = New System.Windows.Forms.Label
        HTMLLabel = New System.Windows.Forms.Label
        FotoLabel = New System.Windows.Forms.Label
        CType(Me.RSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RSBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.picPoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiGEDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(26, 14)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 0
        AlamatLabel.Text = "Alamat:"
        '
        'CoordinatesLabel
        '
        CoordinatesLabel.AutoSize = True
        CoordinatesLabel.Location = New System.Drawing.Point(62, 368)
        CoordinatesLabel.Name = "CoordinatesLabel"
        CoordinatesLabel.Size = New System.Drawing.Size(166, 13)
        CoordinatesLabel.TabIndex = 2
        CoordinatesLabel.Text = "Tentukan Koordinat Titik (X,Y,Z) :"
        '
        'No_telpLabel
        '
        No_telpLabel.AutoSize = True
        No_telpLabel.Location = New System.Drawing.Point(26, 56)
        No_telpLabel.Name = "No_telpLabel"
        No_telpLabel.Size = New System.Drawing.Size(44, 13)
        No_telpLabel.TabIndex = 4
        No_telpLabel.Text = "No telp:"
        '
        'No_faxLabel
        '
        No_faxLabel.AutoSize = True
        No_faxLabel.Location = New System.Drawing.Point(26, 97)
        No_faxLabel.Name = "No_faxLabel"
        No_faxLabel.Size = New System.Drawing.Size(41, 13)
        No_faxLabel.TabIndex = 5
        No_faxLabel.Text = "No fax:"
        '
        'MotoLabel
        '
        MotoLabel.AutoSize = True
        MotoLabel.Location = New System.Drawing.Point(26, 138)
        MotoLabel.Name = "MotoLabel"
        MotoLabel.Size = New System.Drawing.Size(34, 13)
        MotoLabel.TabIndex = 6
        MotoLabel.Text = "Moto:"
        '
        'SitusLabel
        '
        SitusLabel.AutoSize = True
        SitusLabel.Location = New System.Drawing.Point(26, 183)
        SitusLabel.Name = "SitusLabel"
        SitusLabel.Size = New System.Drawing.Size(33, 13)
        SitusLabel.TabIndex = 8
        SitusLabel.Text = "Situs:"
        '
        'RSBindingNavigator
        '
        Me.RSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RSBindingNavigator.BindingSource = Me.RSBindingSource
        Me.RSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RSBindingNavigatorSaveItem})
        Me.RSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RSBindingNavigator.Name = "RSBindingNavigator"
        Me.RSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RSBindingNavigator.Size = New System.Drawing.Size(996, 25)
        Me.RSBindingNavigator.TabIndex = 0
        Me.RSBindingNavigator.Text = "BindingNavigator1"
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
        'RSBindingNavigatorSaveItem
        '
        Me.RSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RSBindingNavigatorSaveItem.Image = CType(resources.GetObject("RSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RSBindingNavigatorSaveItem.Name = "RSBindingNavigatorSaveItem"
        Me.RSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Nm_RSTextBox
        '
        Me.Nm_RSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Nm_RS", True))
        Me.Nm_RSTextBox.Location = New System.Drawing.Point(12, 42)
        Me.Nm_RSTextBox.Name = "Nm_RSTextBox"
        Me.Nm_RSTextBox.Size = New System.Drawing.Size(252, 20)
        Me.Nm_RSTextBox.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(291, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(693, 513)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(SitusLabel)
        Me.TabPage1.Controls.Add(Me.SitusTextBox)
        Me.TabPage1.Controls.Add(MotoLabel)
        Me.TabPage1.Controls.Add(Me.MotoTextBox)
        Me.TabPage1.Controls.Add(No_faxLabel)
        Me.TabPage1.Controls.Add(Me.No_faxTextBox)
        Me.TabPage1.Controls.Add(No_telpLabel)
        Me.TabPage1.Controls.Add(Me.No_telpTextBox)
        Me.TabPage1.Controls.Add(AlamatLabel)
        Me.TabPage1.Controls.Add(Me.AlamatTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(685, 487)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SitusTextBox
        '
        Me.SitusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Situs", True))
        Me.SitusTextBox.Location = New System.Drawing.Point(86, 180)
        Me.SitusTextBox.Name = "SitusTextBox"
        Me.SitusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SitusTextBox.TabIndex = 9
        '
        'MotoTextBox
        '
        Me.MotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Moto", True))
        Me.MotoTextBox.Location = New System.Drawing.Point(86, 135)
        Me.MotoTextBox.Name = "MotoTextBox"
        Me.MotoTextBox.Size = New System.Drawing.Size(263, 20)
        Me.MotoTextBox.TabIndex = 7
        '
        'No_faxTextBox
        '
        Me.No_faxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "No_fax", True))
        Me.No_faxTextBox.Location = New System.Drawing.Point(86, 94)
        Me.No_faxTextBox.Name = "No_faxTextBox"
        Me.No_faxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_faxTextBox.TabIndex = 6
        '
        'No_telpTextBox
        '
        Me.No_telpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "No_telp", True))
        Me.No_telpTextBox.Location = New System.Drawing.Point(86, 53)
        Me.No_telpTextBox.Name = "No_telpTextBox"
        Me.No_telpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_telpTextBox.TabIndex = 5
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(86, 11)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(397, 20)
        Me.AlamatTextBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(HTMLLabel)
        Me.TabPage2.Controls.Add(Me.HTMLTextBox)
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(685, 487)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pelayanan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(6, 69)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(673, 412)
        Me.TabControl2.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PelayananTextBox)
        Me.TabPage3.Controls.Add(Me.FasilitasTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(665, 386)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Teks"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PelayananTextBox
        '
        Me.PelayananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Pelayanan", True))
        Me.PelayananTextBox.Location = New System.Drawing.Point(6, 6)
        Me.PelayananTextBox.Multiline = True
        Me.PelayananTextBox.Name = "PelayananTextBox"
        Me.PelayananTextBox.Size = New System.Drawing.Size(643, 259)
        Me.PelayananTextBox.TabIndex = 1
        '
        'FasilitasTextBox
        '
        Me.FasilitasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Fasilitas", True))
        Me.FasilitasTextBox.Location = New System.Drawing.Point(91, 328)
        Me.FasilitasTextBox.Multiline = True
        Me.FasilitasTextBox.Name = "FasilitasTextBox"
        Me.FasilitasTextBox.Size = New System.Drawing.Size(385, 80)
        Me.FasilitasTextBox.TabIndex = 3
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.WebBrowser1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(665, 386)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "HTML"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(659, 380)
        Me.WebBrowser1.TabIndex = 0
        '
        'picPoto
        '
        Me.picPoto.Location = New System.Drawing.Point(12, 78)
        Me.picPoto.Name = "picPoto"
        Me.picPoto.Size = New System.Drawing.Size(252, 315)
        Me.picPoto.TabIndex = 5
        Me.picPoto.TabStop = False
        '
        'CoordinatesTextBox
        '
        Me.CoordinatesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Coordinates", True))
        Me.CoordinatesTextBox.Location = New System.Drawing.Point(30, 394)
        Me.CoordinatesTextBox.Name = "CoordinatesTextBox"
        Me.CoordinatesTextBox.Size = New System.Drawing.Size(234, 20)
        Me.CoordinatesTextBox.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Pilih Gambar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HTMLLabel
        '
        HTMLLabel.AutoSize = True
        HTMLLabel.Location = New System.Drawing.Point(7, 14)
        HTMLLabel.Name = "HTMLLabel"
        HTMLLabel.Size = New System.Drawing.Size(40, 13)
        HTMLLabel.TabIndex = 4
        HTMLLabel.Text = "HTML:"
        '
        'HTMLTextBox
        '
        Me.HTMLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "HTML", True))
        Me.HTMLTextBox.Location = New System.Drawing.Point(53, 11)
        Me.HTMLTextBox.Name = "HTMLTextBox"
        Me.HTMLTextBox.Size = New System.Drawing.Size(298, 20)
        Me.HTMLTextBox.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 11)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Cari"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RSBindingSource
        '
        Me.RSBindingSource.DataMember = "RS"
        Me.RSBindingSource.DataSource = Me.SiGEDataSet4
        '
        'SiGEDataSet4
        '
        Me.SiGEDataSet4.DataSetName = "SiGEDataSet4"
        Me.SiGEDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RSTableAdapter
        '
        Me.RSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RSTableAdapter = Me.RSTableAdapter
        Me.TableAdapterManager.UpdateOrder = SIGE2.SiGEDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Location = New System.Drawing.Point(116, 452)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(31, 13)
        FotoLabel.TabIndex = 10
        FotoLabel.Text = "Foto:"
        '
        'FotoTextBox
        '
        Me.FotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Foto", True))
        Me.FotoTextBox.Location = New System.Drawing.Point(153, 449)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FotoTextBox.TabIndex = 11
        '
        'EditRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 567)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(Me.FotoTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.picPoto)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CoordinatesTextBox)
        Me.Controls.Add(CoordinatesLabel)
        Me.Controls.Add(Me.Nm_RSTextBox)
        Me.Controls.Add(Me.RSBindingNavigator)
        Me.Name = "EditRS"
        Me.Text = "EditRS"
        CType(Me.RSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RSBindingNavigator.ResumeLayout(False)
        Me.RSBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.picPoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiGEDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SiGEDataSet4 As SIGE2.SiGEDataSet4
    Friend WithEvents RSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RSTableAdapter As SIGE2.SiGEDataSet4TableAdapters.RSTableAdapter
    Friend WithEvents TableAdapterManager As SIGE2.SiGEDataSet4TableAdapters.TableAdapterManager
    Friend WithEvents RSBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RSBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Nm_RSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SitusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_faxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PelayananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FasilitasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents picPoto As System.Windows.Forms.PictureBox
    Friend WithEvents CoordinatesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents HTMLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FotoTextBox As System.Windows.Forms.TextBox
End Class
