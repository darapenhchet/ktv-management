Imports DataLayer

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSongInformation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSongInformation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveAll = New System.Windows.Forms.Button()
        Me.dgvSongerLists = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Album = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Production = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Language = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSinger = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddSingerToList = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.lstSingers = New System.Windows.Forms.ListBox()
        Me.cboSinger = New System.Windows.Forms.ComboBox()
        Me.vlc = New AxAXVLC.AxVLCPlugin2()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSongLocation = New System.Windows.Forms.TextBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.cboProduction = New System.Windows.Forms.ComboBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.openSongs = New System.Windows.Forms.OpenFileDialog()
        Me.ClsSingerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSongerLists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsSingerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 738)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveAll)
        Me.GroupBox2.Controls.Add(Me.dgvSongerLists)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1144, 383)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Song Lists"
        '
        'btnSaveAll
        '
        Me.btnSaveAll.Location = New System.Drawing.Point(728, 336)
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Size = New System.Drawing.Size(130, 39)
        Me.btnSaveAll.TabIndex = 28
        Me.btnSaveAll.Text = "Save All"
        Me.btnSaveAll.UseVisualStyleBackColor = True
        '
        'dgvSongerLists
        '
        Me.dgvSongerLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSongerLists.BackgroundColor = System.Drawing.Color.White
        Me.dgvSongerLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSongerLists.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Album, Me.Production, Me.Category, Me.Language, Me.cSinger})
        Me.dgvSongerLists.Location = New System.Drawing.Point(14, 63)
        Me.dgvSongerLists.Name = "dgvSongerLists"
        Me.dgvSongerLists.RowTemplate.Height = 30
        Me.dgvSongerLists.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSongerLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSongerLists.Size = New System.Drawing.Size(1118, 267)
        Me.dgvSongerLists.TabIndex = 29
        '
        'Title
        '
        Me.Title.FillWeight = 116.9543!
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        '
        'Album
        '
        Me.Album.FillWeight = 116.9543!
        Me.Album.HeaderText = "Album"
        Me.Album.Name = "Album"
        '
        'Production
        '
        Me.Production.HeaderText = "Production"
        Me.Production.Name = "Production"
        '
        'Category
        '
        Me.Category.FillWeight = 116.9543!
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        '
        'Language
        '
        Me.Language.FillWeight = 116.9543!
        Me.Language.HeaderText = "Language"
        Me.Language.Name = "Language"
        '
        'cSinger
        '
        Me.cSinger.FillWeight = 116.9543!
        Me.cSinger.HeaderText = "Singer"
        Me.cSinger.Name = "cSinger"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(864, 336)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 39)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(1002, 18)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(130, 39)
        Me.btnBrowse.TabIndex = 31
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1000, 336)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 39)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddSingerToList)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Controls.Add(Me.lstSingers)
        Me.GroupBox1.Controls.Add(Me.cboSinger)
        Me.GroupBox1.Controls.Add(Me.vlc)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSongLocation)
        Me.GroupBox1.Controls.Add(Me.btSave)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboLanguage)
        Me.GroupBox1.Controls.Add(Me.txtAlbum)
        Me.GroupBox1.Controls.Add(Me.cboProduction)
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1144, 324)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Song Information Details"
        '
        'btnAddSingerToList
        '
        Me.btnAddSingerToList.Location = New System.Drawing.Point(568, 70)
        Me.btnAddSingerToList.Name = "btnAddSingerToList"
        Me.btnAddSingerToList.Size = New System.Drawing.Size(108, 36)
        Me.btnAddSingerToList.TabIndex = 39
        Me.btnAddSingerToList.Text = "Add"
        Me.btnAddSingerToList.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(682, 69)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(108, 36)
        Me.btnRemove.TabIndex = 38
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'lstSingers
        '
        Me.lstSingers.FormattingEnabled = True
        Me.lstSingers.ItemHeight = 25
        Me.lstSingers.Location = New System.Drawing.Point(558, 111)
        Me.lstSingers.Name = "lstSingers"
        Me.lstSingers.Size = New System.Drawing.Size(244, 154)
        Me.lstSingers.TabIndex = 37
        '
        'cboSinger
        '
        Me.cboSinger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSinger.FormattingEnabled = True
        Me.cboSinger.Location = New System.Drawing.Point(558, 33)
        Me.cboSinger.Name = "cboSinger"
        Me.cboSinger.Size = New System.Drawing.Size(244, 33)
        Me.cboSinger.Sorted = True
        Me.cboSinger.TabIndex = 35
        '
        'vlc
        '
        Me.vlc.Enabled = True
        Me.vlc.Location = New System.Drawing.Point(818, 16)
        Me.vlc.Name = "vlc"
        Me.vlc.OcxState = CType(resources.GetObject("vlc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlc.Size = New System.Drawing.Size(320, 288)
        Me.vlc.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Song Location:"
        '
        'txtSongLocation
        '
        Me.txtSongLocation.Location = New System.Drawing.Point(165, 271)
        Me.txtSongLocation.Name = "txtSongLocation"
        Me.txtSongLocation.ReadOnly = True
        Me.txtSongLocation.Size = New System.Drawing.Size(244, 33)
        Me.txtSongLocation.TabIndex = 32
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(672, 268)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(130, 36)
        Me.btSave.TabIndex = 27
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(165, 39)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(164, 33)
        Me.txtID.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(113, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Album:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Category:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(470, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Singer:"
        '
        'cboLanguage
        '
        Me.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Location = New System.Drawing.Point(165, 232)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(244, 33)
        Me.cboLanguage.TabIndex = 23
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(165, 115)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(244, 33)
        Me.txtAlbum.TabIndex = 20
        '
        'cboProduction
        '
        Me.cboProduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProduction.FormattingEnabled = True
        Me.cboProduction.Location = New System.Drawing.Point(165, 154)
        Me.cboProduction.Name = "cboProduction"
        Me.cboProduction.Size = New System.Drawing.Size(244, 33)
        Me.cboProduction.TabIndex = 21
        '
        'cboCategory
        '
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(165, 193)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(244, 33)
        Me.cboCategory.TabIndex = 22
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(165, 78)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(244, 33)
        Me.txtTitle.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Language:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Title:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Production:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(396, -61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 65)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Song Information "
        '
        'openSongs
        '
        Me.openSongs.FileName = "OpenFileDialog1"
        Me.openSongs.Multiselect = True
        '
        'ClsSingerBindingSource
        '
        Me.ClsSingerBindingSource.DataSource = GetType(DataLayer.ClsSinger)
        '
        'frmSongInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmSongInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSongInformation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvSongerLists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsSingerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduction As System.Windows.Forms.ComboBox
    Friend WithEvents txtAlbum As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSongerLists As System.Windows.Forms.DataGridView
    Friend WithEvents btnSaveAll As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents ClsSingerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents openSongs As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSongLocation As System.Windows.Forms.TextBox
    Friend WithEvents vlc As AxAXVLC.AxVLCPlugin2
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Album As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Production As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Language As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSinger As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lstSingers As System.Windows.Forms.ListBox
    Friend WithEvents cboSinger As System.Windows.Forms.ComboBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAddSingerToList As System.Windows.Forms.Button
End Class
