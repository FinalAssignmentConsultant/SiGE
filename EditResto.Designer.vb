<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditResto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditResto))
        Dim TEMPATLabel As System.Windows.Forms.Label
        Dim NO_TELPLabel As System.Windows.Forms.Label
        Dim JENIS_MASALabel As System.Windows.Forms.Label
        Dim KAPASITASLabel As System.Windows.Forms.Label
        Dim FASILITAS_Label As System.Windows.Forms.Label
        Me.SiGEDataSet3 = New SIGE2.SiGEDataSet3
        Me.RestoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestoTableAdapter = New SIGE2.SiGEDataSet3TableAdapters.restoTableAdapter
        Me.TableAdapterManager = New SIGE2.SiGEDataSet3TableAdapters.TableAdapterManager
        Me.RestoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RestoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.NAMA_RESTOTextBox = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TEMPATTextBox = New System.Windows.Forms.TextBox
        Me.NO_TELPTextBox = New System.Windows.Forms.TextBox
        Me.JENIS_MASATextBox = New System.Windows.Forms.TextBox
        Me.KAPASITASTextBox = New System.Windows.Forms.TextBox
        Me.FASILITAS_TextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        TEMPATLabel = New System.Windows.Forms.Label
        NO_TELPLabel = New System.Windows.Forms.Label
        JENIS_MASALabel = New System.Windows.Forms.Label
        KAPASITASLabel = New System.Windows.Forms.Label
        FASILITAS_Label = New System.Windows.Forms.Label
        CType(Me.SiGEDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RestoBindingNavigator.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiGEDataSet3
        '
        Me.SiGEDataSet3.DataSetName = "SiGEDataSet3"
        Me.SiGEDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RestoBindingSource
        '
        Me.RestoBindingSource.DataMember = "resto"
        Me.RestoBindingSource.DataSource = Me.SiGEDataSet3
        '
        'RestoTableAdapter
        '
        Me.RestoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.hotelTableAdapter = Nothing
        Me.TableAdapterManager.restoTableAdapter = Me.RestoTableAdapter
        Me.TableAdapterManager.UpdateOrder = SIGE2.SiGEDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RestoBindingNavigator
        '
        Me.RestoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RestoBindingNavigator.BindingSource = Me.RestoBindingSource
        Me.RestoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RestoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RestoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RestoBindingNavigatorSaveItem})
        Me.RestoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RestoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RestoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RestoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RestoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RestoBindingNavigator.Name = "RestoBindingNavigator"
        Me.RestoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RestoBindingNavigator.Size = New System.Drawing.Size(910, 25)
        Me.RestoBindingNavigator.TabIndex = 0
        Me.RestoBindingNavigator.Text = "BindingNavigator1"
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
        'RestoBindingNavigatorSaveItem
        '
        Me.RestoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RestoBindingNavigatorSaveItem.Image = CType(resources.GetObject("RestoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RestoBindingNavigatorSaveItem.Name = "RestoBindingNavigatorSaveItem"
        Me.RestoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RestoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NAMA_RESTOTextBox
        '
        Me.NAMA_RESTOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "NAMA_RESTO", True))
        Me.NAMA_RESTOTextBox.Location = New System.Drawing.Point(24, 53)
        Me.NAMA_RESTOTextBox.Name = "NAMA_RESTOTextBox"
        Me.NAMA_RESTOTextBox.Size = New System.Drawing.Size(278, 20)
        Me.NAMA_RESTOTextBox.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(344, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(475, 398)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(FASILITAS_Label)
        Me.TabPage1.Controls.Add(Me.FASILITAS_TextBox)
        Me.TabPage1.Controls.Add(KAPASITASLabel)
        Me.TabPage1.Controls.Add(Me.KAPASITASTextBox)
        Me.TabPage1.Controls.Add(JENIS_MASALabel)
        Me.TabPage1.Controls.Add(Me.JENIS_MASATextBox)
        Me.TabPage1.Controls.Add(NO_TELPLabel)
        Me.TabPage1.Controls.Add(Me.NO_TELPTextBox)
        Me.TabPage1.Controls.Add(TEMPATLabel)
        Me.TabPage1.Controls.Add(Me.TEMPATTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(467, 372)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(425, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TEMPATLabel
        '
        TEMPATLabel.AutoSize = True
        TEMPATLabel.Location = New System.Drawing.Point(19, 34)
        TEMPATLabel.Name = "TEMPATLabel"
        TEMPATLabel.Size = New System.Drawing.Size(54, 13)
        TEMPATLabel.TabIndex = 0
        TEMPATLabel.Text = "TEMPAT:"
        '
        'TEMPATTextBox
        '
        Me.TEMPATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "TEMPAT", True))
        Me.TEMPATTextBox.Location = New System.Drawing.Point(103, 31)
        Me.TEMPATTextBox.Name = "TEMPATTextBox"
        Me.TEMPATTextBox.Size = New System.Drawing.Size(288, 20)
        Me.TEMPATTextBox.TabIndex = 1
        '
        'NO_TELPLabel
        '
        NO_TELPLabel.AutoSize = True
        NO_TELPLabel.Location = New System.Drawing.Point(19, 72)
        NO_TELPLabel.Name = "NO_TELPLabel"
        NO_TELPLabel.Size = New System.Drawing.Size(56, 13)
        NO_TELPLabel.TabIndex = 2
        NO_TELPLabel.Text = "NO TELP:"
        '
        'NO_TELPTextBox
        '
        Me.NO_TELPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "NO_TELP", True))
        Me.NO_TELPTextBox.Location = New System.Drawing.Point(103, 69)
        Me.NO_TELPTextBox.Name = "NO_TELPTextBox"
        Me.NO_TELPTextBox.Size = New System.Drawing.Size(153, 20)
        Me.NO_TELPTextBox.TabIndex = 3
        '
        'JENIS_MASALabel
        '
        JENIS_MASALabel.AutoSize = True
        JENIS_MASALabel.Location = New System.Drawing.Point(19, 110)
        JENIS_MASALabel.Name = "JENIS_MASALabel"
        JENIS_MASALabel.Size = New System.Drawing.Size(73, 13)
        JENIS_MASALabel.TabIndex = 4
        JENIS_MASALabel.Text = "JENIS MASA:"
        '
        'JENIS_MASATextBox
        '
        Me.JENIS_MASATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "JENIS_MASA", True))
        Me.JENIS_MASATextBox.Location = New System.Drawing.Point(103, 107)
        Me.JENIS_MASATextBox.Name = "JENIS_MASATextBox"
        Me.JENIS_MASATextBox.Size = New System.Drawing.Size(153, 20)
        Me.JENIS_MASATextBox.TabIndex = 5
        '
        'KAPASITASLabel
        '
        KAPASITASLabel.AutoSize = True
        KAPASITASLabel.Location = New System.Drawing.Point(19, 152)
        KAPASITASLabel.Name = "KAPASITASLabel"
        KAPASITASLabel.Size = New System.Drawing.Size(69, 13)
        KAPASITASLabel.TabIndex = 6
        KAPASITASLabel.Text = "KAPASITAS:"
        '
        'KAPASITASTextBox
        '
        Me.KAPASITASTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "KAPASITAS", True))
        Me.KAPASITASTextBox.Location = New System.Drawing.Point(103, 149)
        Me.KAPASITASTextBox.Name = "KAPASITASTextBox"
        Me.KAPASITASTextBox.Size = New System.Drawing.Size(100, 20)
        Me.KAPASITASTextBox.TabIndex = 7
        '
        'FASILITAS_Label
        '
        FASILITAS_Label.AutoSize = True
        FASILITAS_Label.Location = New System.Drawing.Point(22, 187)
        FASILITAS_Label.Name = "FASILITAS_Label"
        FASILITAS_Label.Size = New System.Drawing.Size(66, 13)
        FASILITAS_Label.TabIndex = 8
        FASILITAS_Label.Text = "FASILITAS :"
        '
        'FASILITAS_TextBox
        '
        Me.FASILITAS_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RestoBindingSource, "FASILITAS_", True))
        Me.FASILITAS_TextBox.Location = New System.Drawing.Point(103, 184)
        Me.FASILITAS_TextBox.Name = "FASILITAS_TextBox"
        Me.FASILITAS_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.FASILITAS_TextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "&Pilih Gambar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(24, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 165)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'EditResto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 568)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.NAMA_RESTOTextBox)
        Me.Controls.Add(Me.RestoBindingNavigator)
        Me.Name = "EditResto"
        Me.Text = "EditResto"
        CType(Me.SiGEDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RestoBindingNavigator.ResumeLayout(False)
        Me.RestoBindingNavigator.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SiGEDataSet3 As SIGE2.SiGEDataSet3
    Friend WithEvents RestoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RestoTableAdapter As SIGE2.SiGEDataSet3TableAdapters.restoTableAdapter
    Friend WithEvents TableAdapterManager As SIGE2.SiGEDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents RestoBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RestoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NAMA_RESTOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents FASILITAS_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents KAPASITASTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JENIS_MASATextBox As System.Windows.Forms.TextBox
    Friend WithEvents NO_TELPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TEMPATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
