<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoResto
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
        Dim TEMPATLabel As System.Windows.Forms.Label
        Dim NO_TELPLabel As System.Windows.Forms.Label
        Dim JENIS_MASALabel As System.Windows.Forms.Label
        Dim KAPASITASLabel As System.Windows.Forms.Label
        Dim FASILITAS_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoResto))
        Me.SiGEDataSet = New SIGE2.SiGEDataSet
        Me.RSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RSTableAdapter = New SIGE2.SiGEDataSetTableAdapters.RSTableAdapter
        Me.TableAdapterManager = New SIGE2.SiGEDataSetTableAdapters.TableAdapterManager
        Me.RestoTableAdapter1 = New SIGE2.SiGEDataSetTableAdapters.restoTableAdapter
        Me.RSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Fasilitas = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.FASILITAS_TextBox = New System.Windows.Forms.TextBox
        Me.RestoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KAPASITASTextBox = New System.Windows.Forms.TextBox
        Me.JENIS_MASATextBox = New System.Windows.Forms.TextBox
        Me.NO_TELPTextBox = New System.Windows.Forms.TextBox
        Me.TEMPATTextBox = New System.Windows.Forms.TextBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.RestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiGEDataSet1 = New SIGE2.SiGEDataSet1
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.RestoTableAdapter = New SIGE2.SiGEDataSet1TableAdapters.restoTableAdapter
        Me.TableAdapterManager1 = New SIGE2.SiGEDataSet1TableAdapters.TableAdapterManager
        Me.Button3 = New System.Windows.Forms.Button
        Me.NAMA_RESTOTextBox = New System.Windows.Forms.TextBox
        TEMPATLabel = New System.Windows.Forms.Label
        NO_TELPLabel = New System.Windows.Forms.Label
        JENIS_MASALabel = New System.Windows.Forms.Label
        KAPASITASLabel = New System.Windows.Forms.Label
        FASILITAS_Label = New System.Windows.Forms.Label
        CType(Me.SiGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RSBindingNavigator.SuspendLayout()
        Me.Fasilitas.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.RestoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.RestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiGEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TEMPATLabel
        '
        TEMPATLabel.AutoSize = True
        TEMPATLabel.Location = New System.Drawing.Point(19, 12)
        TEMPATLabel.Name = "TEMPATLabel"
        TEMPATLabel.Size = New System.Drawing.Size(65, 20)
        TEMPATLabel.TabIndex = 0
        TEMPATLabel.Text = "Alamat :"
        '
        'NO_TELPLabel
        '
        NO_TELPLabel.AutoSize = True
        NO_TELPLabel.Location = New System.Drawing.Point(19, 49)
        NO_TELPLabel.Name = "NO_TELPLabel"
        NO_TELPLabel.Size = New System.Drawing.Size(69, 20)
        NO_TELPLabel.TabIndex = 2
        NO_TELPLabel.Text = "No.Telp :"
        '
        'JENIS_MASALabel
        '
        JENIS_MASALabel.AutoSize = True
        JENIS_MASALabel.Location = New System.Drawing.Point(19, 89)
        JENIS_MASALabel.Name = "JENIS_MASALabel"
        JENIS_MASALabel.Size = New System.Drawing.Size(112, 20)
        JENIS_MASALabel.TabIndex = 4
        JENIS_MASALabel.Text = "Jenis Masakan :"
        '
        'KAPASITASLabel
        '
        KAPASITASLabel.AutoSize = True
        KAPASITASLabel.Location = New System.Drawing.Point(19, 127)
        KAPASITASLabel.Name = "KAPASITASLabel"
        KAPASITASLabel.Size = New System.Drawing.Size(79, 20)
        KAPASITASLabel.TabIndex = 6
        KAPASITASLabel.Text = "Kapasitas :"
        '
        'FASILITAS_Label
        '
        FASILITAS_Label.AutoSize = True
        FASILITAS_Label.Location = New System.Drawing.Point(20, 165)
        FASILITAS_Label.Name = "FASILITAS_Label"
        FASILITAS_Label.Size = New System.Drawing.Size(68, 20)
        FASILITAS_Label.TabIndex = 8
        FASILITAS_Label.Text = "Fasilitas :"
        '
        'SiGEDataSet
        '
        Me.SiGEDataSet.DataSetName = "SiGEDataSet"
        Me.SiGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RSBindingSource
        '
        Me.RSBindingSource.DataMember = "RS"
        Me.RSBindingSource.DataSource = Me.SiGEDataSet
        '
        'RSTableAdapter
        '
        Me.RSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Nama_instansiTableAdapter = Nothing
        Me.TableAdapterManager.PendidikanTableAdapter = Nothing
        Me.TableAdapterManager.restoTableAdapter = Me.RestoTableAdapter1
        Me.TableAdapterManager.RSTableAdapter = Me.RSTableAdapter
        Me.TableAdapterManager.TransportTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SIGE2.SiGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RestoTableAdapter1
        '
        Me.RestoTableAdapter1.ClearBeforeFill = True
        '
        'RSBindingNavigator
        '
        Me.RSBindingNavigator.AddNewItem = Nothing
        Me.RSBindingNavigator.BindingSource = Me.RSBindingSource
        Me.RSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RSBindingNavigator.DeleteItem = Nothing
        Me.RSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.RSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RSBindingNavigator.Name = "RSBindingNavigator"
        Me.RSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RSBindingNavigator.Size = New System.Drawing.Size(890, 25)
        Me.RSBindingNavigator.TabIndex = 0
        Me.RSBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 22)
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
        'Fasilitas
        '
        Me.Fasilitas.Controls.Add(Me.TabPage2)
        Me.Fasilitas.Controls.Add(Me.TabPage5)
        Me.Fasilitas.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fasilitas.Location = New System.Drawing.Point(292, 28)
        Me.Fasilitas.Name = "Fasilitas"
        Me.Fasilitas.SelectedIndex = 0
        Me.Fasilitas.Size = New System.Drawing.Size(586, 458)
        Me.Fasilitas.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(FASILITAS_Label)
        Me.TabPage2.Controls.Add(Me.FASILITAS_TextBox)
        Me.TabPage2.Controls.Add(KAPASITASLabel)
        Me.TabPage2.Controls.Add(Me.KAPASITASTextBox)
        Me.TabPage2.Controls.Add(JENIS_MASALabel)
        Me.TabPage2.Controls.Add(Me.JENIS_MASATextBox)
        Me.TabPage2.Controls.Add(NO_TELPLabel)
        Me.TabPage2.Controls.Add(Me.NO_TELPTextBox)
        Me.TabPage2.Controls.Add(TEMPATLabel)
        Me.TabPage2.Controls.Add(Me.TEMPATTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(578, 432)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Resroran"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FASILITAS_TextBox
        '
        Me.FASILITAS_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource1, "FASILITAS_", True))
        Me.FASILITAS_TextBox.Location = New System.Drawing.Point(137, 162)
        Me.FASILITAS_TextBox.Multiline = True
        Me.FASILITAS_TextBox.Name = "FASILITAS_TextBox"
        Me.FASILITAS_TextBox.Size = New System.Drawing.Size(276, 38)
        Me.FASILITAS_TextBox.TabIndex = 9
        '
        'RestoBindingSource1
        '
        Me.RestoBindingSource1.DataMember = "resto"
        Me.RestoBindingSource1.DataSource = Me.SiGEDataSet
        '
        'KAPASITASTextBox
        '
        Me.KAPASITASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource1, "KAPASITAS", True))
        Me.KAPASITASTextBox.Location = New System.Drawing.Point(137, 124)
        Me.KAPASITASTextBox.Name = "KAPASITASTextBox"
        Me.KAPASITASTextBox.Size = New System.Drawing.Size(100, 28)
        Me.KAPASITASTextBox.TabIndex = 7
        '
        'JENIS_MASATextBox
        '
        Me.JENIS_MASATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource1, "JENIS_MASA", True))
        Me.JENIS_MASATextBox.Location = New System.Drawing.Point(137, 86)
        Me.JENIS_MASATextBox.Name = "JENIS_MASATextBox"
        Me.JENIS_MASATextBox.Size = New System.Drawing.Size(245, 28)
        Me.JENIS_MASATextBox.TabIndex = 5
        '
        'NO_TELPTextBox
        '
        Me.NO_TELPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource1, "NO_TELP", True))
        Me.NO_TELPTextBox.Location = New System.Drawing.Point(137, 46)
        Me.NO_TELPTextBox.Name = "NO_TELPTextBox"
        Me.NO_TELPTextBox.Size = New System.Drawing.Size(100, 28)
        Me.NO_TELPTextBox.TabIndex = 3
        '
        'TEMPATTextBox
        '
        Me.TEMPATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource1, "TEMPAT", True))
        Me.TEMPATTextBox.Location = New System.Drawing.Point(137, 9)
        Me.TEMPATTextBox.Name = "TEMPATTextBox"
        Me.TEMPATTextBox.Size = New System.Drawing.Size(415, 28)
        Me.TEMPATTextBox.TabIndex = 1
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.RichTextBox3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(578, 444)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Biaya"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(23, 21)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(469, 371)
        Me.RichTextBox3.TabIndex = 2
        Me.RichTextBox3.Text = ""
        '
        'RestoBindingSource
        '
        Me.RestoBindingSource.DataMember = "resto"
        Me.RestoBindingSource.DataSource = Me.SiGEDataSet1
        '
        'SiGEDataSet1
        '
        Me.SiGEDataSet1.DataSetName = "SiGEDataSet1"
        Me.SiGEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 231)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'RestoTableAdapter
        '
        Me.RestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.hotelTableAdapter = Nothing
        Me.TableAdapterManager1.restoTableAdapter = Me.RestoTableAdapter
        Me.TableAdapterManager1.RSTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = SIGE2.SiGEDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(110, 381)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 27)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "&Tutup"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NAMA_RESTOTextBox
        '
        Me.NAMA_RESTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource1, "NAMA_RESTO", True))
        Me.NAMA_RESTOTextBox.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAMA_RESTOTextBox.Location = New System.Drawing.Point(12, 36)
        Me.NAMA_RESTOTextBox.Name = "NAMA_RESTOTextBox"
        Me.NAMA_RESTOTextBox.Size = New System.Drawing.Size(254, 28)
        Me.NAMA_RESTOTextBox.TabIndex = 28
        '
        'InfoResto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 542)
        Me.Controls.Add(Me.NAMA_RESTOTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Fasilitas)
        Me.Controls.Add(Me.RSBindingNavigator)
        Me.Name = "InfoResto"
        Me.Text = "InfoResto"
        CType(Me.SiGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RSBindingNavigator.ResumeLayout(False)
        Me.RSBindingNavigator.PerformLayout()
        Me.Fasilitas.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.RestoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.RestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiGEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SiGEDataSet As SIGE2.SiGEDataSet
    Friend WithEvents RSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RSTableAdapter As SIGE2.SiGEDataSetTableAdapters.RSTableAdapter
    Friend WithEvents TableAdapterManager As SIGE2.SiGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RSBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Fasilitas As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SiGEDataSet1 As SIGE2.SiGEDataSet1
    Friend WithEvents RestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RestoTableAdapter As SIGE2.SiGEDataSet1TableAdapters.restoTableAdapter
    Friend WithEvents TableAdapterManager1 As SIGE2.SiGEDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents RestoTableAdapter1 As SIGE2.SiGEDataSetTableAdapters.restoTableAdapter
    Friend WithEvents RestoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FASILITAS_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents KAPASITASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JENIS_MASATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NO_TELPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TEMPATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents NAMA_RESTOTextBox As System.Windows.Forms.TextBox
End Class
