<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSong
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSong))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnUpdateSong = New System.Windows.Forms.Button()
        Me.btnAddSong = New System.Windows.Forms.Button()
        Me.btnSongList = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvSongList = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Album = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Production = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Language = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Singer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddSinger = New System.Windows.Forms.Button()
        Me.btnSingerOff = New System.Windows.Forms.Button()
        Me.btnFullScreen = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.vlc = New AxAXVLC.AxVLCPlugin2()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lstSingers = New System.Windows.Forms.ListBox()
        Me.cboSinger = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.cboProduction = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OpenSong = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvSongList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 600)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(0, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1024, 60)
        Me.Panel2.TabIndex = 2
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.BackgroundImage = Global.KTVManagement.My.Resources.Resources.arrow3
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Location = New System.Drawing.Point(6, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(50, 50)
        Me.btnBack.TabIndex = 1
        Me.btnBack.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage Song"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1024, 5)
        Me.Panel3.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnUpdateSong)
        Me.Panel5.Controls.Add(Me.btnAddSong)
        Me.Panel5.Controls.Add(Me.btnSongList)
        Me.Panel5.Location = New System.Drawing.Point(9, 104)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1007, 30)
        Me.Panel5.TabIndex = 3
        '
        'btnUpdateSong
        '
        Me.btnUpdateSong.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateSong.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUpdateSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateSong.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUpdateSong.FlatAppearance.BorderSize = 0
        Me.btnUpdateSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSong.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSong.ForeColor = System.Drawing.Color.White
        Me.btnUpdateSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateSong.Location = New System.Drawing.Point(260, 0)
        Me.btnUpdateSong.Name = "btnUpdateSong"
        Me.btnUpdateSong.Size = New System.Drawing.Size(130, 30)
        Me.btnUpdateSong.TabIndex = 3
        Me.btnUpdateSong.Text = "&Update Song"
        Me.btnUpdateSong.UseVisualStyleBackColor = False
        '
        'btnAddSong
        '
        Me.btnAddSong.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddSong.BackColor = System.Drawing.Color.White
        Me.btnAddSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddSong.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddSong.FlatAppearance.BorderSize = 0
        Me.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSong.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnAddSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSong.Location = New System.Drawing.Point(130, 0)
        Me.btnAddSong.Name = "btnAddSong"
        Me.btnAddSong.Size = New System.Drawing.Size(130, 30)
        Me.btnAddSong.TabIndex = 2
        Me.btnAddSong.Text = "&Add Song"
        Me.btnAddSong.UseVisualStyleBackColor = False
        '
        'btnSongList
        '
        Me.btnSongList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSongList.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSongList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSongList.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSongList.FlatAppearance.BorderSize = 0
        Me.btnSongList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSongList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSongList.ForeColor = System.Drawing.Color.White
        Me.btnSongList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSongList.Location = New System.Drawing.Point(0, 0)
        Me.btnSongList.Name = "btnSongList"
        Me.btnSongList.Size = New System.Drawing.Size(130, 30)
        Me.btnSongList.TabIndex = 1
        Me.btnSongList.Text = "Song &List"
        Me.btnSongList.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.Controls.Add(Me.txtAlbum)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.cboLanguage)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.btnAdd)
        Me.Panel4.Controls.Add(Me.dgvSongList)
        Me.Panel4.Controls.Add(Me.btnAddSinger)
        Me.Panel4.Controls.Add(Me.btnSingerOff)
        Me.Panel4.Controls.Add(Me.btnFullScreen)
        Me.Panel4.Controls.Add(Me.btnPlay)
        Me.Panel4.Controls.Add(Me.vlc)
        Me.Panel4.Controls.Add(Me.btnBrowse)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.txtPath)
        Me.Panel4.Controls.Add(Me.lstSingers)
        Me.Panel4.Controls.Add(Me.cboSinger)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.cboCategory)
        Me.Panel4.Controls.Add(Me.cboProduction)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtTitle)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.ShapeContainer1)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(9, 104)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1007, 493)
        Me.Panel4.TabIndex = 4
        '
        'txtAlbum
        '
        Me.txtAlbum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAlbum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlbum.Location = New System.Drawing.Point(130, 184)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(300, 27)
        Me.txtAlbum.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(571, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 30)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cboLanguage
        '
        Me.cboLanguage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboLanguage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Items.AddRange(New Object() {"Normal", "VIP"})
        Me.cboLanguage.Location = New System.Drawing.Point(130, 289)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(300, 29)
        Me.cboLanguage.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(27, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 19)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Language:"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(792, 326)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 28
        Me.btnAdd.Text = "Add "
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'dgvSongList
        '
        Me.dgvSongList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvSongList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSongList.BackgroundColor = System.Drawing.Color.White
        Me.dgvSongList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSongList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSongList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Album, Me.Production, Me.Category, Me.Language, Me.Singer, Me.CPath})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSongList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSongList.Location = New System.Drawing.Point(7, 362)
        Me.dgvSongList.Name = "dgvSongList"
        Me.dgvSongList.RowHeadersVisible = False
        Me.dgvSongList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSongList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgvSongList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.dgvSongList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSongList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSongList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSongList.Size = New System.Drawing.Size(990, 122)
        Me.dgvSongList.TabIndex = 27
        '
        'Title
        '
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        '
        'Album
        '
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
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        '
        'Language
        '
        Me.Language.HeaderText = "Language"
        Me.Language.Name = "Language"
        '
        'Singer
        '
        Me.Singer.HeaderText = "Singer"
        Me.Singer.Name = "Singer"
        '
        'CPath
        '
        Me.CPath.HeaderText = "Path"
        Me.CPath.Name = "CPath"
        '
        'btnAddSinger
        '
        Me.btnAddSinger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddSinger.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddSinger.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddSinger.FlatAppearance.BorderSize = 0
        Me.btnAddSinger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSinger.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSinger.ForeColor = System.Drawing.Color.White
        Me.btnAddSinger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddSinger.Location = New System.Drawing.Point(671, 79)
        Me.btnAddSinger.Name = "btnAddSinger"
        Me.btnAddSinger.Size = New System.Drawing.Size(94, 30)
        Me.btnAddSinger.TabIndex = 26
        Me.btnAddSinger.Text = "Add"
        Me.btnAddSinger.UseVisualStyleBackColor = False
        '
        'btnSingerOff
        '
        Me.btnSingerOff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSingerOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSingerOff.BackgroundImage = Global.KTVManagement.My.Resources.Resources.microphone52__1_
        Me.btnSingerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSingerOff.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSingerOff.FlatAppearance.BorderSize = 0
        Me.btnSingerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSingerOff.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSingerOff.ForeColor = System.Drawing.Color.White
        Me.btnSingerOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSingerOff.Location = New System.Drawing.Point(963, 242)
        Me.btnSingerOff.Name = "btnSingerOff"
        Me.btnSingerOff.Size = New System.Drawing.Size(35, 30)
        Me.btnSingerOff.TabIndex = 25
        Me.btnSingerOff.UseVisualStyleBackColor = False
        '
        'btnFullScreen
        '
        Me.btnFullScreen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnFullScreen.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnFullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFullScreen.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnFullScreen.FlatAppearance.BorderSize = 0
        Me.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFullScreen.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullScreen.ForeColor = System.Drawing.Color.White
        Me.btnFullScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFullScreen.Location = New System.Drawing.Point(840, 242)
        Me.btnFullScreen.Name = "btnFullScreen"
        Me.btnFullScreen.Size = New System.Drawing.Size(100, 30)
        Me.btnFullScreen.TabIndex = 24
        Me.btnFullScreen.Text = "Full Screen"
        Me.btnFullScreen.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPlay.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnPlay.BackgroundImage = Global.KTVManagement.My.Resources.Resources.rounded3
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlay.Location = New System.Drawing.Point(771, 242)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(40, 30)
        Me.btnPlay.TabIndex = 23
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'vlc
        '
        Me.vlc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.vlc.Enabled = True
        Me.vlc.Location = New System.Drawing.Point(771, 59)
        Me.vlc.Name = "vlc"
        Me.vlc.OcxState = CType(resources.GetObject("vlc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlc.Size = New System.Drawing.Size(227, 173)
        Me.vlc.TabIndex = 22
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBrowse.Location = New System.Drawing.Point(898, 287)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 30)
        Me.btnBrowse.TabIndex = 21
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(447, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Path:"
        '
        'txtPath
        '
        Me.txtPath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPath.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(500, 289)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(392, 27)
        Me.txtPath.TabIndex = 19
        '
        'lstSingers
        '
        Me.lstSingers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstSingers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSingers.FormattingEnabled = True
        Me.lstSingers.ItemHeight = 21
        Me.lstSingers.Location = New System.Drawing.Point(521, 143)
        Me.lstSingers.Name = "lstSingers"
        Me.lstSingers.Size = New System.Drawing.Size(244, 88)
        Me.lstSingers.TabIndex = 18
        '
        'cboSinger
        '
        Me.cboSinger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSinger.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSinger.FormattingEnabled = True
        Me.cboSinger.Items.AddRange(New Object() {"Normal", "VIP"})
        Me.cboSinger.Location = New System.Drawing.Point(521, 115)
        Me.cboSinger.Name = "cboSinger"
        Me.cboSinger.Size = New System.Drawing.Size(244, 29)
        Me.cboSinger.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(451, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Singer:"
        '
        'cboCategory
        '
        Me.cboCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboCategory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Normal", "VIP"})
        Me.cboCategory.Location = New System.Drawing.Point(130, 254)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(300, 29)
        Me.cboCategory.TabIndex = 15
        '
        'cboProduction
        '
        Me.cboProduction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboProduction.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProduction.FormattingEnabled = True
        Me.cboProduction.Items.AddRange(New Object() {"Normal", "VIP"})
        Me.cboProduction.Location = New System.Drawing.Point(130, 219)
        Me.cboProduction.Name = "cboProduction"
        Me.cboProduction.Size = New System.Drawing.Size(300, 29)
        Me.cboProduction.TabIndex = 14
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(898, 326)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(36, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(244, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Update Song Information:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(36, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Category:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(25, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Production:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(55, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Album:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(79, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(130, 151)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(300, 27)
        Me.txtTitle.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(93, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(130, 118)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(300, 27)
        Me.txtID.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1007, 493)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LineShape1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 6
        Me.LineShape1.X2 = 1001
        Me.LineShape1.Y1 = 48
        Me.LineShape1.Y2 = 48
        '
        'OpenSong
        '
        Me.OpenSong.FileName = "OpenFileDialog1"
        '
        'frmAddSong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddSong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAddSong"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvSongList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdateSong As System.Windows.Forms.Button
    Friend WithEvents btnAddSong As System.Windows.Forms.Button
    Friend WithEvents btnSongList As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSingerOff As System.Windows.Forms.Button
    Friend WithEvents btnFullScreen As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents lstSingers As System.Windows.Forms.ListBox
    Friend WithEvents cboSinger As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduction As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnAddSinger As System.Windows.Forms.Button
    Friend WithEvents dgvSongList As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents OpenSong As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cboLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Album As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Production As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Language As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Singer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vlc As AxAXVLC.AxVLCPlugin2
    Friend WithEvents txtAlbum As System.Windows.Forms.TextBox
End Class
