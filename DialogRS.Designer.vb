<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogRS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogRS))
        Dim IDLabel As System.Windows.Forms.Label
        Dim Nm_RSLabel As System.Windows.Forms.Label
        Dim CoordinatesLabel As System.Windows.Forms.Label
        Dim AlamatLabel As System.Windows.Forms.Label
        Dim No_telpLabel As System.Windows.Forms.Label
        Dim No_faxLabel As System.Windows.Forms.Label
        Dim SitusLabel As System.Windows.Forms.Label
        Dim MotoLabel As System.Windows.Forms.Label
        Dim PelayananLabel As System.Windows.Forms.Label
        Dim FasilitasLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.SiGEDataSet4 = New SIGE2.SiGEDataSet4
        Me.RSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RSTableAdapter = New SIGE2.SiGEDataSet4TableAdapters.RSTableAdapter
        Me.TableAdapterManager = New SIGE2.SiGEDataSet4TableAdapters.TableAdapterManager
        Me.RSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.RSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.IDTextBox = New System.Windows.Forms.TextBox
        Me.Nm_RSTextBox = New System.Windows.Forms.TextBox
        Me.CoordinatesTextBox = New System.Windows.Forms.TextBox
        Me.AlamatTextBox = New System.Windows.Forms.TextBox
        Me.No_telpTextBox = New System.Windows.Forms.TextBox
        Me.No_faxTextBox = New System.Windows.Forms.TextBox
        Me.SitusTextBox = New System.Windows.Forms.TextBox
        Me.MotoTextBox = New System.Windows.Forms.TextBox
        Me.PelayananTextBox = New System.Windows.Forms.TextBox
        Me.FasilitasTextBox = New System.Windows.Forms.TextBox
        IDLabel = New System.Windows.Forms.Label
        Nm_RSLabel = New System.Windows.Forms.Label
        CoordinatesLabel = New System.Windows.Forms.Label
        AlamatLabel = New System.Windows.Forms.Label
        No_telpLabel = New System.Windows.Forms.Label
        No_faxLabel = New System.Windows.Forms.Label
        SitusLabel = New System.Windows.Forms.Label
        MotoLabel = New System.Windows.Forms.Label
        PelayananLabel = New System.Windows.Forms.Label
        FasilitasLabel = New System.Windows.Forms.Label
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SiGEDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RSBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(533, 523)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
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
        Me.RSBindingNavigator.Size = New System.Drawing.Size(691, 25)
        Me.RSBindingNavigator.TabIndex = 1
        Me.RSBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'RSBindingNavigatorSaveItem
        '
        Me.RSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RSBindingNavigatorSaveItem.Image = CType(resources.GetObject("RSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RSBindingNavigatorSaveItem.Name = "RSBindingNavigatorSaveItem"
        Me.RSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.RSBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(347, 119)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 2
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(419, 116)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 3
        '
        'Nm_RSLabel
        '
        Nm_RSLabel.AutoSize = True
        Nm_RSLabel.Location = New System.Drawing.Point(347, 145)
        Nm_RSLabel.Name = "Nm_RSLabel"
        Nm_RSLabel.Size = New System.Drawing.Size(44, 13)
        Nm_RSLabel.TabIndex = 4
        Nm_RSLabel.Text = "Nm RS:"
        '
        'Nm_RSTextBox
        '
        Me.Nm_RSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Nm_RS", True))
        Me.Nm_RSTextBox.Location = New System.Drawing.Point(419, 142)
        Me.Nm_RSTextBox.Name = "Nm_RSTextBox"
        Me.Nm_RSTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nm_RSTextBox.TabIndex = 5
        '
        'CoordinatesLabel
        '
        CoordinatesLabel.AutoSize = True
        CoordinatesLabel.Location = New System.Drawing.Point(347, 171)
        CoordinatesLabel.Name = "CoordinatesLabel"
        CoordinatesLabel.Size = New System.Drawing.Size(66, 13)
        CoordinatesLabel.TabIndex = 6
        CoordinatesLabel.Text = "Coordinates:"
        '
        'CoordinatesTextBox
        '
        Me.CoordinatesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Coordinates", True))
        Me.CoordinatesTextBox.Location = New System.Drawing.Point(419, 168)
        Me.CoordinatesTextBox.Name = "CoordinatesTextBox"
        Me.CoordinatesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CoordinatesTextBox.TabIndex = 7
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(347, 197)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(42, 13)
        AlamatLabel.TabIndex = 8
        AlamatLabel.Text = "Alamat:"
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Alamat", True))
        Me.AlamatTextBox.Location = New System.Drawing.Point(419, 194)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlamatTextBox.TabIndex = 9
        '
        'No_telpLabel
        '
        No_telpLabel.AutoSize = True
        No_telpLabel.Location = New System.Drawing.Point(347, 223)
        No_telpLabel.Name = "No_telpLabel"
        No_telpLabel.Size = New System.Drawing.Size(44, 13)
        No_telpLabel.TabIndex = 10
        No_telpLabel.Text = "No telp:"
        '
        'No_telpTextBox
        '
        Me.No_telpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "No_telp", True))
        Me.No_telpTextBox.Location = New System.Drawing.Point(419, 220)
        Me.No_telpTextBox.Name = "No_telpTextBox"
        Me.No_telpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_telpTextBox.TabIndex = 11
        '
        'No_faxLabel
        '
        No_faxLabel.AutoSize = True
        No_faxLabel.Location = New System.Drawing.Point(347, 249)
        No_faxLabel.Name = "No_faxLabel"
        No_faxLabel.Size = New System.Drawing.Size(41, 13)
        No_faxLabel.TabIndex = 12
        No_faxLabel.Text = "No fax:"
        '
        'No_faxTextBox
        '
        Me.No_faxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "No_fax", True))
        Me.No_faxTextBox.Location = New System.Drawing.Point(419, 246)
        Me.No_faxTextBox.Name = "No_faxTextBox"
        Me.No_faxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_faxTextBox.TabIndex = 13
        '
        'SitusLabel
        '
        SitusLabel.AutoSize = True
        SitusLabel.Location = New System.Drawing.Point(347, 275)
        SitusLabel.Name = "SitusLabel"
        SitusLabel.Size = New System.Drawing.Size(33, 13)
        SitusLabel.TabIndex = 14
        SitusLabel.Text = "Situs:"
        '
        'SitusTextBox
        '
        Me.SitusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Situs", True))
        Me.SitusTextBox.Location = New System.Drawing.Point(419, 272)
        Me.SitusTextBox.Name = "SitusTextBox"
        Me.SitusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SitusTextBox.TabIndex = 15
        '
        'MotoLabel
        '
        MotoLabel.AutoSize = True
        MotoLabel.Location = New System.Drawing.Point(347, 301)
        MotoLabel.Name = "MotoLabel"
        MotoLabel.Size = New System.Drawing.Size(34, 13)
        MotoLabel.TabIndex = 16
        MotoLabel.Text = "Moto:"
        '
        'MotoTextBox
        '
        Me.MotoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Moto", True))
        Me.MotoTextBox.Location = New System.Drawing.Point(419, 298)
        Me.MotoTextBox.Name = "MotoTextBox"
        Me.MotoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MotoTextBox.TabIndex = 17
        '
        'PelayananLabel
        '
        PelayananLabel.AutoSize = True
        PelayananLabel.Location = New System.Drawing.Point(347, 327)
        PelayananLabel.Name = "PelayananLabel"
        PelayananLabel.Size = New System.Drawing.Size(60, 13)
        PelayananLabel.TabIndex = 18
        PelayananLabel.Text = "Pelayanan:"
        '
        'PelayananTextBox
        '
        Me.PelayananTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Pelayanan", True))
        Me.PelayananTextBox.Location = New System.Drawing.Point(419, 324)
        Me.PelayananTextBox.Name = "PelayananTextBox"
        Me.PelayananTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PelayananTextBox.TabIndex = 19
        '
        'FasilitasLabel
        '
        FasilitasLabel.AutoSize = True
        FasilitasLabel.Location = New System.Drawing.Point(347, 353)
        FasilitasLabel.Name = "FasilitasLabel"
        FasilitasLabel.Size = New System.Drawing.Size(47, 13)
        FasilitasLabel.TabIndex = 20
        FasilitasLabel.Text = "Fasilitas:"
        '
        'FasilitasTextBox
        '
        Me.FasilitasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RSBindingSource, "Fasilitas", True))
        Me.FasilitasTextBox.Location = New System.Drawing.Point(419, 350)
        Me.FasilitasTextBox.Name = "FasilitasTextBox"
        Me.FasilitasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FasilitasTextBox.TabIndex = 21
        '
        'DialogRS
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(691, 564)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Nm_RSLabel)
        Me.Controls.Add(Me.Nm_RSTextBox)
        Me.Controls.Add(CoordinatesLabel)
        Me.Controls.Add(Me.CoordinatesTextBox)
        Me.Controls.Add(AlamatLabel)
        Me.Controls.Add(Me.AlamatTextBox)
        Me.Controls.Add(No_telpLabel)
        Me.Controls.Add(Me.No_telpTextBox)
        Me.Controls.Add(No_faxLabel)
        Me.Controls.Add(Me.No_faxTextBox)
        Me.Controls.Add(SitusLabel)
        Me.Controls.Add(Me.SitusTextBox)
        Me.Controls.Add(MotoLabel)
        Me.Controls.Add(Me.MotoTextBox)
        Me.Controls.Add(PelayananLabel)
        Me.Controls.Add(Me.PelayananTextBox)
        Me.Controls.Add(FasilitasLabel)
        Me.Controls.Add(Me.FasilitasTextBox)
        Me.Controls.Add(Me.RSBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogRS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DialogRS"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.SiGEDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RSBindingNavigator.ResumeLayout(False)
        Me.RSBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
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
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nm_RSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CoordinatesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_faxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SitusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PelayananTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FasilitasTextBox As System.Windows.Forms.TextBox

End Class
