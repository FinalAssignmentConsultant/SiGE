<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoRS
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
        Dim SitusLabel As System.Windows.Forms.Label
        Dim MotoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoRS))
        Me.SiGEDataSet4 = New SIGE2.SiGEDataSet4
        Me.RSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RSTableAdapter = New SIGE2.SiGEDataSet4TableAdapters.RSTableAdapter
        Me.TableAdapterManager = New SIGE2.SiGEDataSet4TableAdapters.TableAdapterManager
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
        Me.Nm_RSTextBox = New System.Windows.Forms.TextBox
        Me.AlamatTextBox = New System.Windows.Forms.TextBox
        Me.No_telpTextBox = New System.Windows.Forms.TextBox
        Me.No_faxTextBox = New System.Windows.Forms.TextBox
        Me.SitusTextBox = New System.Windows.Forms.TextBox
        Me.MotoTextBox = New System.Windows.Forms.TextBox
        Me.picPoto = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button2 = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.HTMLTextBox = New System.Windows.Forms.TextBox
        Me.FotoTextBox = New System.Windows.Forms.TextBox
        AlamatLabel = New System.Windows.Forms.Label
        No_telpLabel = New System.Windows.Forms.Label
        No_faxLabel = New System.Windows.Forms.Label
        SitusLabel = New System.Windows.Forms.Label
        MotoLabel = New System.Windows.Forms.Label
        CType(Me.SiGEDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RSBindingNavigator.SuspendLayout()
        CType(Me.picPoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(20, 21)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(61, 20)
        AlamatLabel.TabIndex = 3
        AlamatLabel.Text = "Alamat:"
        '
        'No_telpLabel
        '
        No_telpLabel.AutoSize = True
        No_telpLabel.Location = New System.Drawing.Point(18, 61)
        No_telpLabel.Name = "No_telpLabel"
        No_telpLabel.Size = New System.Drawing.Size(62, 20)
        No_telpLabel.TabIndex = 5
        No_telpLabel.Text = "No telp:"
        '
        'No_faxLabel
        '
        No_faxLabel.AutoSize = True
        No_faxLabel.Location = New System.Drawing.Point(20, 101)
        No_faxLabel.Name = "No_faxLabel"
        No_faxLabel.Size = New System.Drawing.Size(57, 20)
        No_faxLabel.TabIndex = 7
        No_faxLabel.Text = "No fax:"
        '
        'SitusLabel
        '
        SitusLabel.AutoSize = True
        SitusLabel.Location = New System.Drawing.Point(21, 183)
        SitusLabel.Name = "SitusLabel"
        SitusLabel.Size = New System.Drawing.Size(46, 20)
        SitusLabel.TabIndex = 9
        SitusLabel.Text = "Situs:"
        '
        'MotoLabel
        '
        MotoLabel.AutoSize = True
        MotoLabel.Location = New System.Drawing.Point(20, 140)
        MotoLabel.Name = "MotoLabel"
        MotoLabel.Size = New System.Drawing.Size(49, 20)
        MotoLabel.TabIndex = 11
        MotoLabel.Text = "Moto:"
        '
        'SiGEDataSet4
        '
        Me.SiGEDataSet4.DataSetName = "SiGEDataSet4"
        Me.SiGEDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RSBindingSource
        '
        Me.RSBindingSource.DataMember = "RS"
        Me.RSBindingSource.DataSource = Me.SiGEDataSet4
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
        Me.RSBindingNavigator.Size = New System.Drawing.Size(999, 25)
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
        'Nm_RSTextBox
        '
        Me.Nm_RSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Nm_RS", True))
        Me.Nm_RSTextBox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nm_RSTextBox.Location = New System.Drawing.Point(26, 38)
        Me.Nm_RSTextBox.Name = "Nm_RSTextBox"
        Me.Nm_RSTextBox.Size = New System.Drawing.Size(348, 25)
        Me.Nm_RSTextBox.TabIndex = 2
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(101, 18)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(406, 28)
        Me.AlamatTextBox.TabIndex = 4
        '
        'No_telpTextBox
        '
        Me.No_telpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "No_telp", True))
        Me.No_telpTextBox.Location = New System.Drawing.Point(101, 58)
        Me.No_telpTextBox.Name = "No_telpTextBox"
        Me.No_telpTextBox.Size = New System.Drawing.Size(187, 28)
        Me.No_telpTextBox.TabIndex = 6
        '
        'No_faxTextBox
        '
        Me.No_faxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "No_fax", True))
        Me.No_faxTextBox.Location = New System.Drawing.Point(101, 101)
        Me.No_faxTextBox.Name = "No_faxTextBox"
        Me.No_faxTextBox.Size = New System.Drawing.Size(187, 28)
        Me.No_faxTextBox.TabIndex = 8
        '
        'SitusTextBox
        '
        Me.SitusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Situs", True))
        Me.SitusTextBox.Location = New System.Drawing.Point(101, 180)
        Me.SitusTextBox.Name = "SitusTextBox"
        Me.SitusTextBox.Size = New System.Drawing.Size(187, 28)
        Me.SitusTextBox.TabIndex = 10
        '
        'MotoTextBox
        '
        Me.MotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Moto", True))
        Me.MotoTextBox.Location = New System.Drawing.Point(101, 137)
        Me.MotoTextBox.Name = "MotoTextBox"
        Me.MotoTextBox.Size = New System.Drawing.Size(398, 28)
        Me.MotoTextBox.TabIndex = 12
        '
        'picPoto
        '
        Me.picPoto.Location = New System.Drawing.Point(26, 101)
        Me.picPoto.Name = "picPoto"
        Me.picPoto.Size = New System.Drawing.Size(348, 263)
        Me.picPoto.TabIndex = 17
        Me.picPoto.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 34)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "&Tutup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TabControl1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(447, 25)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(552, 491)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.No_telpTextBox)
        Me.TabPage1.Controls.Add(Me.AlamatTextBox)
        Me.TabPage1.Controls.Add(AlamatLabel)
        Me.TabPage1.Controls.Add(No_telpLabel)
        Me.TabPage1.Controls.Add(Me.No_faxTextBox)
        Me.TabPage1.Controls.Add(No_faxLabel)
        Me.TabPage1.Controls.Add(Me.SitusTextBox)
        Me.TabPage1.Controls.Add(MotoLabel)
        Me.TabPage1.Controls.Add(SitusLabel)
        Me.TabPage1.Controls.Add(Me.MotoTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(544, 465)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(339, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 31)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Go !!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 465)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pelayanan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(538, 459)
        Me.WebBrowser1.TabIndex = 0
        '
        'HTMLTextBox
        '
        Me.HTMLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "HTML", True))
        Me.HTMLTextBox.Location = New System.Drawing.Point(212, 344)
        Me.HTMLTextBox.Name = "HTMLTextBox"
        Me.HTMLTextBox.Size = New System.Drawing.Size(56, 20)
        Me.HTMLTextBox.TabIndex = 20
        '
        'FotoTextBox
        '
        Me.FotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Foto", True))
        Me.FotoTextBox.Location = New System.Drawing.Point(274, 344)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(81, 20)
        Me.FotoTextBox.TabIndex = 21
        '
        'InfoRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 516)
        Me.Controls.Add(Me.picPoto)
        Me.Controls.Add(Me.FotoTextBox)
        Me.Controls.Add(Me.HTMLTextBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Nm_RSTextBox)
        Me.Controls.Add(Me.RSBindingNavigator)
        Me.Name = "InfoRS"
        Me.Text = "InfoRS"
        CType(Me.SiGEDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RSBindingNavigator.ResumeLayout(False)
        Me.RSBindingNavigator.PerformLayout()
        CType(Me.picPoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SiGEDataSet4 As SIGE2.SiGEDataSet4
    Friend WithEvents RSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RSTableAdapter As SIGE2.SiGEDataSet4TableAdapters.RSTableAdapter
    Friend WithEvents TableAdapterManager As SIGE2.SiGEDataSet4TableAdapters.TableAdapterManager
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
    Friend WithEvents Nm_RSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_faxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SitusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents picPoto As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents HTMLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FotoTextBox As System.Windows.Forms.TextBox
End Class
