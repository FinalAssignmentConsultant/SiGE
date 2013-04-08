<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LihatHasil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LihatHasil))
        Me.Button3 = New System.Windows.Forms.Button
        Me.Nm_kantorTextBox = New System.Windows.Forms.TextBox
        Me.picPoto = New System.Windows.Forms.PictureBox
        Me.Fasilitas = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.SitusTextBox = New System.Windows.Forms.TextBox
        Me.MotoTextBox = New System.Windows.Forms.TextBox
        Me.Jam_bukaTextBox = New System.Windows.Forms.TextBox
        Me.No_faxTextBox = New System.Windows.Forms.TextBox
        Me.No_telpTextBox = New System.Windows.Forms.TextBox
        Me.AlamatTextBox = New System.Windows.Forms.TextBox
        Me.Pelayanan = New System.Windows.Forms.TabPage
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.BiayaTextBox = New System.Windows.Forms.RichTextBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.InfoLainTextBox = New System.Windows.Forms.RichTextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.FasilitasTextBox = New System.Windows.Forms.TextBox
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.FotoTextBox = New System.Windows.Forms.TextBox
        SitusLabel = New System.Windows.Forms.Label
        MotoLabel = New System.Windows.Forms.Label
        Jam_bukaLabel = New System.Windows.Forms.Label
        No_faxLabel = New System.Windows.Forms.Label
        No_telpLabel = New System.Windows.Forms.Label
        AlamatLabel = New System.Windows.Forms.Label
        CType(Me.picPoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fasilitas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Pelayanan.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SitusLabel
        '
        SitusLabel.AutoSize = True
        SitusLabel.Location = New System.Drawing.Point(10, 255)
        SitusLabel.Name = "SitusLabel"
        SitusLabel.Size = New System.Drawing.Size(47, 22)
        SitusLabel.TabIndex = 13
        SitusLabel.Text = "Situs:"
        '
        'MotoLabel
        '
        MotoLabel.AutoSize = True
        MotoLabel.Location = New System.Drawing.Point(10, 187)
        MotoLabel.Name = "MotoLabel"
        MotoLabel.Size = New System.Drawing.Size(84, 22)
        MotoLabel.TabIndex = 12
        MotoLabel.Text = "Moto/Visi :"
        '
        'Jam_bukaLabel
        '
        Jam_bukaLabel.AutoSize = True
        Jam_bukaLabel.Location = New System.Drawing.Point(8, 142)
        Jam_bukaLabel.Name = "Jam_bukaLabel"
        Jam_bukaLabel.Size = New System.Drawing.Size(80, 22)
        Jam_bukaLabel.TabIndex = 11
        Jam_bukaLabel.Text = "Jam buka:"
        '
        'No_faxLabel
        '
        No_faxLabel.AutoSize = True
        No_faxLabel.Location = New System.Drawing.Point(10, 101)
        No_faxLabel.Name = "No_faxLabel"
        No_faxLabel.Size = New System.Drawing.Size(60, 22)
        No_faxLabel.TabIndex = 10
        No_faxLabel.Text = "No fax:"
        '
        'No_telpLabel
        '
        No_telpLabel.AutoSize = True
        No_telpLabel.Location = New System.Drawing.Point(10, 59)
        No_telpLabel.Name = "No_telpLabel"
        No_telpLabel.Size = New System.Drawing.Size(64, 22)
        No_telpLabel.TabIndex = 9
        No_telpLabel.Text = "No telp:"
        '
        'AlamatLabel
        '
        AlamatLabel.AutoSize = True
        AlamatLabel.Location = New System.Drawing.Point(10, 12)
        AlamatLabel.Name = "AlamatLabel"
        AlamatLabel.Size = New System.Drawing.Size(64, 22)
        AlamatLabel.TabIndex = 8
        AlamatLabel.Text = "Alamat:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(135, 386)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 27)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "&Tutup"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Nm_kantorTextBox
        '
        Me.Nm_kantorTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nm_kantorTextBox.Location = New System.Drawing.Point(12, 28)
        Me.Nm_kantorTextBox.Name = "Nm_kantorTextBox"
        Me.Nm_kantorTextBox.Size = New System.Drawing.Size(376, 29)
        Me.Nm_kantorTextBox.TabIndex = 25
        '
        'picPoto
        '
        Me.picPoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPoto.Location = New System.Drawing.Point(12, 57)
        Me.picPoto.Name = "picPoto"
        Me.picPoto.Size = New System.Drawing.Size(376, 254)
        Me.picPoto.TabIndex = 24
        Me.picPoto.TabStop = False
        '
        'Fasilitas
        '
        Me.Fasilitas.Controls.Add(Me.TabPage1)
        Me.Fasilitas.Controls.Add(Me.Pelayanan)
        Me.Fasilitas.Controls.Add(Me.TabPage3)
        Me.Fasilitas.Controls.Add(Me.TabPage5)
        Me.Fasilitas.Controls.Add(Me.TabPage6)
        Me.Fasilitas.Controls.Add(Me.TabPage4)
        Me.Fasilitas.Dock = System.Windows.Forms.DockStyle.Right
        Me.Fasilitas.Location = New System.Drawing.Point(394, 0)
        Me.Fasilitas.Name = "Fasilitas"
        Me.Fasilitas.SelectedIndex = 0
        Me.Fasilitas.Size = New System.Drawing.Size(619, 620)
        Me.Fasilitas.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
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
        Me.TabPage1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(611, 594)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Profil"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(417, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Go !!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SitusTextBox
        '
        Me.SitusTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SitusTextBox.Location = New System.Drawing.Point(100, 252)
        Me.SitusTextBox.Name = "SitusTextBox"
        Me.SitusTextBox.Size = New System.Drawing.Size(218, 29)
        Me.SitusTextBox.TabIndex = 14
        '
        'MotoTextBox
        '
        Me.MotoTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotoTextBox.Location = New System.Drawing.Point(100, 184)
        Me.MotoTextBox.Multiline = True
        Me.MotoTextBox.Name = "MotoTextBox"
        Me.MotoTextBox.Size = New System.Drawing.Size(392, 51)
        Me.MotoTextBox.TabIndex = 13
        '
        'Jam_bukaTextBox
        '
        Me.Jam_bukaTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jam_bukaTextBox.Location = New System.Drawing.Point(100, 139)
        Me.Jam_bukaTextBox.Name = "Jam_bukaTextBox"
        Me.Jam_bukaTextBox.Size = New System.Drawing.Size(381, 29)
        Me.Jam_bukaTextBox.TabIndex = 12
        '
        'No_faxTextBox
        '
        Me.No_faxTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_faxTextBox.Location = New System.Drawing.Point(100, 98)
        Me.No_faxTextBox.Name = "No_faxTextBox"
        Me.No_faxTextBox.Size = New System.Drawing.Size(381, 29)
        Me.No_faxTextBox.TabIndex = 11
        '
        'No_telpTextBox
        '
        Me.No_telpTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_telpTextBox.Location = New System.Drawing.Point(100, 56)
        Me.No_telpTextBox.Name = "No_telpTextBox"
        Me.No_telpTextBox.Size = New System.Drawing.Size(381, 29)
        Me.No_telpTextBox.TabIndex = 10
        '
        'AlamatTextBox
        '
        Me.AlamatTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlamatTextBox.Location = New System.Drawing.Point(100, 9)
        Me.AlamatTextBox.Name = "AlamatTextBox"
        Me.AlamatTextBox.Size = New System.Drawing.Size(492, 29)
        Me.AlamatTextBox.TabIndex = 9
        '
        'Pelayanan
        '
        Me.Pelayanan.AutoScroll = True
        Me.Pelayanan.Controls.Add(Me.WebBrowser1)
        Me.Pelayanan.Location = New System.Drawing.Point(4, 22)
        Me.Pelayanan.Name = "Pelayanan"
        Me.Pelayanan.Padding = New System.Windows.Forms.Padding(3)
        Me.Pelayanan.Size = New System.Drawing.Size(611, 594)
        Me.Pelayanan.TabIndex = 1
        Me.Pelayanan.Text = "Pelayanan"
        Me.Pelayanan.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(605, 588)
        Me.WebBrowser1.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(611, 594)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Prosedur"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(15, 15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(482, 401)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.BiayaTextBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(611, 594)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Biaya"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'BiayaTextBox
        '
        Me.BiayaTextBox.Location = New System.Drawing.Point(19, 39)
        Me.BiayaTextBox.Name = "BiayaTextBox"
        Me.BiayaTextBox.Size = New System.Drawing.Size(473, 353)
        Me.BiayaTextBox.TabIndex = 2
        Me.BiayaTextBox.Text = ""
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.InfoLainTextBox)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(611, 594)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Info Lain"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'InfoLainTextBox
        '
        Me.InfoLainTextBox.Location = New System.Drawing.Point(19, 39)
        Me.InfoLainTextBox.Name = "InfoLainTextBox"
        Me.InfoLainTextBox.Size = New System.Drawing.Size(473, 353)
        Me.InfoLainTextBox.TabIndex = 2
        Me.InfoLainTextBox.Text = ""
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.FasilitasTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(611, 594)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Fasilitas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'FasilitasTextBox
        '
        Me.FasilitasTextBox.Location = New System.Drawing.Point(34, 25)
        Me.FasilitasTextBox.Multiline = True
        Me.FasilitasTextBox.Name = "FasilitasTextBox"
        Me.FasilitasTextBox.Size = New System.Drawing.Size(443, 277)
        Me.FasilitasTextBox.TabIndex = 1
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(394, 28)
        Me.BindingNavigator1.TabIndex = 27
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 28)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 28)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 25)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'FotoTextBox
        '
        Me.FotoTextBox.Location = New System.Drawing.Point(114, 333)
        Me.FotoTextBox.Name = "FotoTextBox"
        Me.FotoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FotoTextBox.TabIndex = 28
        Me.FotoTextBox.Visible = False
        '
        'LihatHasil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 620)
        Me.Controls.Add(Me.FotoTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Nm_kantorTextBox)
        Me.Controls.Add(Me.picPoto)
        Me.Controls.Add(Me.Fasilitas)
        Me.MaximizeBox = False
        Me.Name = "LihatHasil"
        Me.Text = "Hasil"
        CType(Me.picPoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fasilitas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Pelayanan.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Nm_kantorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents picPoto As System.Windows.Forms.PictureBox
    Friend WithEvents Fasilitas As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SitusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jam_bukaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_faxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents No_telpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AlamatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pelayanan As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents BiayaTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents InfoLainTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents FasilitasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FotoTextBox As System.Windows.Forms.TextBox
End Class
