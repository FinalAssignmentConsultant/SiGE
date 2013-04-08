<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditHotel
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
        Dim CoordinatesLabel As System.Windows.Forms.Label
        Dim ALAMATLabel As System.Windows.Forms.Label
        Dim NO_TELPLabel As System.Windows.Forms.Label
        Dim KLASIFIKASLabel As System.Windows.Forms.Label
        Dim JMLH_KMARLabel As System.Windows.Forms.Label
        Dim JUMLH_TDURLabel As System.Windows.Forms.Label
        Dim STANDAR_MILabel As System.Windows.Forms.Label
        Dim STANDAR_MALabel As System.Windows.Forms.Label
        Dim SUIT_MINLabel As System.Windows.Forms.Label
        Dim SUIT_MAXLabel As System.Windows.Forms.Label
        Dim FASILITASLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditHotel))
        Me.SiGEDataSet3 = New SIGE2.SiGEDataSet3
        Me.HotelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelTableAdapter = New SIGE2.SiGEDataSet3TableAdapters.hotelTableAdapter
        Me.TableAdapterManager = New SIGE2.SiGEDataSet3TableAdapters.TableAdapterManager
        Me.HotelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HotelBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NAMA_HOTELTextBox = New System.Windows.Forms.TextBox
        Me.CoordinatesTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SUIT_MAXTextBox = New System.Windows.Forms.TextBox
        Me.SUIT_MINTextBox = New System.Windows.Forms.TextBox
        Me.STANDAR_MATextBox = New System.Windows.Forms.TextBox
        Me.STANDAR_MITextBox = New System.Windows.Forms.TextBox
        Me.JUMLH_TDURTextBox = New System.Windows.Forms.TextBox
        Me.JMLH_KMARTextBox = New System.Windows.Forms.TextBox
        Me.KLASIFIKASTextBox = New System.Windows.Forms.TextBox
        Me.NO_TELPTextBox = New System.Windows.Forms.TextBox
        Me.ALAMATTextBox = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.FASILITASTextBox = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        CoordinatesLabel = New System.Windows.Forms.Label
        ALAMATLabel = New System.Windows.Forms.Label
        NO_TELPLabel = New System.Windows.Forms.Label
        KLASIFIKASLabel = New System.Windows.Forms.Label
        JMLH_KMARLabel = New System.Windows.Forms.Label
        JUMLH_TDURLabel = New System.Windows.Forms.Label
        STANDAR_MILabel = New System.Windows.Forms.Label
        STANDAR_MALabel = New System.Windows.Forms.Label
        SUIT_MINLabel = New System.Windows.Forms.Label
        SUIT_MAXLabel = New System.Windows.Forms.Label
        FASILITASLabel = New System.Windows.Forms.Label
        CType(Me.SiGEDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HotelBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CoordinatesLabel
        '
        CoordinatesLabel.AutoSize = True
        CoordinatesLabel.Location = New System.Drawing.Point(61, 324)
        CoordinatesLabel.Name = "CoordinatesLabel"
        CoordinatesLabel.Size = New System.Drawing.Size(129, 13)
        CoordinatesLabel.TabIndex = 4
        CoordinatesLabel.Text = "Tentukan Lokasi (X,Y,Z) ;"
        '
        'ALAMATLabel
        '
        ALAMATLabel.AutoSize = True
        ALAMATLabel.Location = New System.Drawing.Point(24, 18)
        ALAMATLabel.Name = "ALAMATLabel"
        ALAMATLabel.Size = New System.Drawing.Size(53, 13)
        ALAMATLabel.TabIndex = 0
        ALAMATLabel.Text = "ALAMAT:"
        '
        'NO_TELPLabel
        '
        NO_TELPLabel.AutoSize = True
        NO_TELPLabel.Location = New System.Drawing.Point(24, 49)
        NO_TELPLabel.Name = "NO_TELPLabel"
        NO_TELPLabel.Size = New System.Drawing.Size(56, 13)
        NO_TELPLabel.TabIndex = 2
        NO_TELPLabel.Text = "NO TELP:"
        '
        'KLASIFIKASLabel
        '
        KLASIFIKASLabel.AutoSize = True
        KLASIFIKASLabel.Location = New System.Drawing.Point(24, 85)
        KLASIFIKASLabel.Name = "KLASIFIKASLabel"
        KLASIFIKASLabel.Size = New System.Drawing.Size(70, 13)
        KLASIFIKASLabel.TabIndex = 4
        KLASIFIKASLabel.Text = "KLASIFIKAS:"
        '
        'JMLH_KMARLabel
        '
        JMLH_KMARLabel.AutoSize = True
        JMLH_KMARLabel.Location = New System.Drawing.Point(24, 115)
        JMLH_KMARLabel.Name = "JMLH_KMARLabel"
        JMLH_KMARLabel.Size = New System.Drawing.Size(72, 13)
        JMLH_KMARLabel.TabIndex = 6
        JMLH_KMARLabel.Text = "JMLH KMAR:"
        '
        'JUMLH_TDURLabel
        '
        JUMLH_TDURLabel.AutoSize = True
        JUMLH_TDURLabel.Location = New System.Drawing.Point(24, 148)
        JUMLH_TDURLabel.Name = "JUMLH_TDURLabel"
        JUMLH_TDURLabel.Size = New System.Drawing.Size(80, 13)
        JUMLH_TDURLabel.TabIndex = 8
        JUMLH_TDURLabel.Text = "JUMLH TDUR:"
        '
        'STANDAR_MILabel
        '
        STANDAR_MILabel.AutoSize = True
        STANDAR_MILabel.Location = New System.Drawing.Point(24, 179)
        STANDAR_MILabel.Name = "STANDAR_MILabel"
        STANDAR_MILabel.Size = New System.Drawing.Size(77, 13)
        STANDAR_MILabel.TabIndex = 10
        STANDAR_MILabel.Text = "STANDAR MI:"
        '
        'STANDAR_MALabel
        '
        STANDAR_MALabel.AutoSize = True
        STANDAR_MALabel.Location = New System.Drawing.Point(24, 212)
        STANDAR_MALabel.Name = "STANDAR_MALabel"
        STANDAR_MALabel.Size = New System.Drawing.Size(81, 13)
        STANDAR_MALabel.TabIndex = 12
        STANDAR_MALabel.Text = "STANDAR MA:"
        '
        'SUIT_MINLabel
        '
        SUIT_MINLabel.AutoSize = True
        SUIT_MINLabel.Location = New System.Drawing.Point(24, 249)
        SUIT_MINLabel.Name = "SUIT_MINLabel"
        SUIT_MINLabel.Size = New System.Drawing.Size(58, 13)
        SUIT_MINLabel.TabIndex = 14
        SUIT_MINLabel.Text = "SUIT MIN:"
        '
        'SUIT_MAXLabel
        '
        SUIT_MAXLabel.AutoSize = True
        SUIT_MAXLabel.Location = New System.Drawing.Point(24, 285)
        SUIT_MAXLabel.Name = "SUIT_MAXLabel"
        SUIT_MAXLabel.Size = New System.Drawing.Size(61, 13)
        SUIT_MAXLabel.TabIndex = 16
        SUIT_MAXLabel.Text = "SUIT MAX:"
        '
        'FASILITASLabel
        '
        FASILITASLabel.AutoSize = True
        FASILITASLabel.Location = New System.Drawing.Point(6, 18)
        FASILITASLabel.Name = "FASILITASLabel"
        FASILITASLabel.Size = New System.Drawing.Size(63, 13)
        FASILITASLabel.TabIndex = 0
        FASILITASLabel.Text = "FASILITAS:"
        '
        'SiGEDataSet3
        '
        Me.SiGEDataSet3.DataSetName = "SiGEDataSet3"
        Me.SiGEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HotelBindingSource
        '
        Me.HotelBindingSource.DataMember = "hotel"
        Me.HotelBindingSource.DataSource = Me.SiGEDataSet3
        '
        'HotelTableAdapter
        '
        Me.HotelTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.hotelTableAdapter = Me.HotelTableAdapter
        Me.TableAdapterManager.restoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGE2.SiGEDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HotelBindingNavigator
        '
        Me.HotelBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HotelBindingNavigator.BindingSource = Me.HotelBindingSource
        Me.HotelBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HotelBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HotelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HotelBindingNavigatorSaveItem})
        Me.HotelBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HotelBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HotelBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HotelBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HotelBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HotelBindingNavigator.Name = "HotelBindingNavigator"
        Me.HotelBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HotelBindingNavigator.Size = New System.Drawing.Size(855, 25)
        Me.HotelBindingNavigator.TabIndex = 0
        Me.HotelBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
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
        'HotelBindingNavigatorSaveItem
        '
        Me.HotelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HotelBindingNavigatorSaveItem.Image = CType(resources.GetObject("HotelBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HotelBindingNavigatorSaveItem.Name = "HotelBindingNavigatorSaveItem"
        Me.HotelBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HotelBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NAMA_HOTELTextBox
        '
        Me.NAMA_HOTELTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "NAMA_HOTEL", True))
        Me.NAMA_HOTELTextBox.Location = New System.Drawing.Point(12, 37)
        Me.NAMA_HOTELTextBox.Name = "NAMA_HOTELTextBox"
        Me.NAMA_HOTELTextBox.Size = New System.Drawing.Size(224, 20)
        Me.NAMA_HOTELTextBox.TabIndex = 3
        '
        'CoordinatesTextBox
        '
        Me.CoordinatesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "coordinates", True))
        Me.CoordinatesTextBox.Location = New System.Drawing.Point(33, 352)
        Me.CoordinatesTextBox.Name = "CoordinatesTextBox"
        Me.CoordinatesTextBox.Size = New System.Drawing.Size(203, 20)
        Me.CoordinatesTextBox.TabIndex = 5
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(269, 37)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(534, 408)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(SUIT_MAXLabel)
        Me.TabPage1.Controls.Add(Me.SUIT_MAXTextBox)
        Me.TabPage1.Controls.Add(SUIT_MINLabel)
        Me.TabPage1.Controls.Add(Me.SUIT_MINTextBox)
        Me.TabPage1.Controls.Add(STANDAR_MALabel)
        Me.TabPage1.Controls.Add(Me.STANDAR_MATextBox)
        Me.TabPage1.Controls.Add(STANDAR_MILabel)
        Me.TabPage1.Controls.Add(Me.STANDAR_MITextBox)
        Me.TabPage1.Controls.Add(JUMLH_TDURLabel)
        Me.TabPage1.Controls.Add(Me.JUMLH_TDURTextBox)
        Me.TabPage1.Controls.Add(JMLH_KMARLabel)
        Me.TabPage1.Controls.Add(Me.JMLH_KMARTextBox)
        Me.TabPage1.Controls.Add(KLASIFIKASLabel)
        Me.TabPage1.Controls.Add(Me.KLASIFIKASTextBox)
        Me.TabPage1.Controls.Add(NO_TELPLabel)
        Me.TabPage1.Controls.Add(Me.NO_TELPTextBox)
        Me.TabPage1.Controls.Add(ALAMATLabel)
        Me.TabPage1.Controls.Add(Me.ALAMATTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(526, 382)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SUIT_MAXTextBox
        '
        Me.SUIT_MAXTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "SUIT_MAX", True))
        Me.SUIT_MAXTextBox.Location = New System.Drawing.Point(126, 282)
        Me.SUIT_MAXTextBox.Name = "SUIT_MAXTextBox"
        Me.SUIT_MAXTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SUIT_MAXTextBox.TabIndex = 17
        '
        'SUIT_MINTextBox
        '
        Me.SUIT_MINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "SUIT_MIN", True))
        Me.SUIT_MINTextBox.Location = New System.Drawing.Point(126, 249)
        Me.SUIT_MINTextBox.Name = "SUIT_MINTextBox"
        Me.SUIT_MINTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SUIT_MINTextBox.TabIndex = 15
        '
        'STANDAR_MATextBox
        '
        Me.STANDAR_MATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "STANDAR_MA", True))
        Me.STANDAR_MATextBox.Location = New System.Drawing.Point(126, 212)
        Me.STANDAR_MATextBox.Name = "STANDAR_MATextBox"
        Me.STANDAR_MATextBox.Size = New System.Drawing.Size(117, 20)
        Me.STANDAR_MATextBox.TabIndex = 13
        '
        'STANDAR_MITextBox
        '
        Me.STANDAR_MITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "STANDAR_MI", True))
        Me.STANDAR_MITextBox.Location = New System.Drawing.Point(126, 176)
        Me.STANDAR_MITextBox.Name = "STANDAR_MITextBox"
        Me.STANDAR_MITextBox.Size = New System.Drawing.Size(117, 20)
        Me.STANDAR_MITextBox.TabIndex = 11
        '
        'JUMLH_TDURTextBox
        '
        Me.JUMLH_TDURTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "JUMLH_TDUR", True))
        Me.JUMLH_TDURTextBox.Location = New System.Drawing.Point(126, 141)
        Me.JUMLH_TDURTextBox.Name = "JUMLH_TDURTextBox"
        Me.JUMLH_TDURTextBox.Size = New System.Drawing.Size(117, 20)
        Me.JUMLH_TDURTextBox.TabIndex = 9
        '
        'JMLH_KMARTextBox
        '
        Me.JMLH_KMARTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "JMLH_KMAR", True))
        Me.JMLH_KMARTextBox.Location = New System.Drawing.Point(126, 111)
        Me.JMLH_KMARTextBox.Name = "JMLH_KMARTextBox"
        Me.JMLH_KMARTextBox.Size = New System.Drawing.Size(117, 20)
        Me.JMLH_KMARTextBox.TabIndex = 7
        '
        'KLASIFIKASTextBox
        '
        Me.KLASIFIKASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "KLASIFIKAS", True))
        Me.KLASIFIKASTextBox.Location = New System.Drawing.Point(126, 78)
        Me.KLASIFIKASTextBox.Name = "KLASIFIKASTextBox"
        Me.KLASIFIKASTextBox.Size = New System.Drawing.Size(117, 20)
        Me.KLASIFIKASTextBox.TabIndex = 5
        '
        'NO_TELPTextBox
        '
        Me.NO_TELPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "NO_TELP", True))
        Me.NO_TELPTextBox.Location = New System.Drawing.Point(126, 49)
        Me.NO_TELPTextBox.Name = "NO_TELPTextBox"
        Me.NO_TELPTextBox.Size = New System.Drawing.Size(117, 20)
        Me.NO_TELPTextBox.TabIndex = 3
        '
        'ALAMATTextBox
        '
        Me.ALAMATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "ALAMAT", True))
        Me.ALAMATTextBox.Location = New System.Drawing.Point(126, 18)
        Me.ALAMATTextBox.Name = "ALAMATTextBox"
        Me.ALAMATTextBox.Size = New System.Drawing.Size(366, 20)
        Me.ALAMATTextBox.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(FASILITASLabel)
        Me.TabPage2.Controls.Add(Me.FASILITASTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(526, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pelayanan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FASILITASTextBox
        '
        Me.FASILITASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HotelBindingSource, "FASILITAS", True))
        Me.FASILITASTextBox.Location = New System.Drawing.Point(75, 15)
        Me.FASILITASTextBox.Multiline = True
        Me.FASILITASTextBox.Name = "FASILITASTextBox"
        Me.FASILITASTextBox.Size = New System.Drawing.Size(435, 160)
        Me.FASILITASTextBox.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 165)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 35)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Pilih Gambar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EditHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 474)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(CoordinatesLabel)
        Me.Controls.Add(Me.CoordinatesTextBox)
        Me.Controls.Add(Me.NAMA_HOTELTextBox)
        Me.Controls.Add(Me.HotelBindingNavigator)
        Me.Name = "EditHotel"
        Me.Text = "Edit Instansi"
        CType(Me.SiGEDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HotelBindingNavigator.ResumeLayout(False)
        Me.HotelBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SiGEDataSet3 As SIGE2.SiGEDataSet3
    Friend WithEvents HotelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HotelTableAdapter As SIGE2.SiGEDataSet3TableAdapters.hotelTableAdapter
    Friend WithEvents TableAdapterManager As SIGE2.SiGEDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents HotelBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HotelBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NAMA_HOTELTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CoordinatesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SUIT_MAXTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SUIT_MINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STANDAR_MATextBox As System.Windows.Forms.TextBox
    Friend WithEvents STANDAR_MITextBox As System.Windows.Forms.TextBox
    Friend WithEvents JUMLH_TDURTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JMLH_KMARTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KLASIFIKASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NO_TELPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALAMATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents FASILITASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
