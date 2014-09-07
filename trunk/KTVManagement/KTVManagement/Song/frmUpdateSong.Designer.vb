<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateSong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateSong))
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
        Me.btnSingerOff = New System.Windows.Forms.Button()
        Me.btnFullScreen = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.vlc = New AxAXVLC.AxVLCPlugin2()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lstSingers = New System.Windows.Forms.ListBox()
        Me.cboSinger = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.cboProduction = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAlbum = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.Panel1.TabIndex = 3
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
        Me.btnUpdateSong.BackColor = System.Drawing.Color.White
        Me.btnUpdateSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateSong.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUpdateSong.FlatAppearance.BorderSize = 0
        Me.btnUpdateSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateSong.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
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
        Me.btnAddSong.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddSong.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddSong.FlatAppearance.BorderSize = 0
        Me.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSong.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSong.ForeColor = System.Drawing.Color.White
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
        Me.Panel4.Controls.Add(Me.btnSingerOff)
        Me.Panel4.Controls.Add(Me.btnFullScreen)
        Me.Panel4.Controls.Add(Me.btnPlay)
        Me.Panel4.Controls.Add(Me.vlc)
        Me.Panel4.Controls.Add(Me.btnBrowse)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.TextBox1)
        Me.Panel4.Controls.Add(Me.lstSingers)
        Me.Panel4.Controls.Add(Me.cboSinger)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.cboCategory)
        Me.Panel4.Controls.Add(Me.cboProduction)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtAlbum)
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
        Me.Panel4.Size = New System.Drawing.Size(1007, 490)
        Me.Panel4.TabIndex = 4
        '
        'btnSingerOff
        '
        Me.btnSingerOff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSingerOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSingerOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSingerOff.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSingerOff.FlatAppearance.BorderSize = 0
        Me.btnSingerOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSingerOff.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSingerOff.ForeColor = System.Drawing.Color.White
        Me.btnSingerOff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSingerOff.Location = New System.Drawing.Point(902, 318)
        Me.btnSingerOff.Name = "btnSingerOff"
        Me.btnSingerOff.Size = New System.Drawing.Size(100, 30)
        Me.btnSingerOff.TabIndex = 25
        Me.btnSingerOff.Text = "Singer Off"
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
        Me.btnFullScreen.Location = New System.Drawing.Point(796, 318)
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
        Me.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnPlay.FlatAppearance.BorderSize = 0
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlay.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.ForeColor = System.Drawing.Color.White
        Me.btnPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPlay.Location = New System.Drawing.Point(690, 318)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(100, 30)
        Me.btnPlay.TabIndex = 23
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'vlc
        '
        Me.vlc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.vlc.Enabled = True
        Me.vlc.Location = New System.Drawing.Point(486, 57)
        Me.vlc.Name = "vlc"
        Me.vlc.OcxState = CType(resources.GetObject("vlc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlc.Size = New System.Drawing.Size(516, 252)
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
        Me.btnBrowse.Location = New System.Drawing.Point(902, 359)
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
        Me.Label9.Location = New System.Drawing.Point(484, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Path:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(537, 361)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(359, 27)
        Me.TextBox1.TabIndex = 19
        '
        'lstSingers
        '
        Me.lstSingers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSingers.FormattingEnabled = True
        Me.lstSingers.ItemHeight = 21
        Me.lstSingers.Location = New System.Drawing.Point(130, 389)
        Me.lstSingers.Name = "lstSingers"
        Me.lstSingers.Size = New System.Drawing.Size(300, 88)
        Me.lstSingers.TabIndex = 18
        '
        'cboSinger
        '
        Me.cboSinger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSinger.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSinger.FormattingEnabled = True
        Me.cboSinger.Items.AddRange(New Object() {"Normal", "VIP"})
        Me.cboSinger.Location = New System.Drawing.Point(130, 361)
        Me.cboSinger.Name = "cboSinger"
        Me.cboSinger.Size = New System.Drawing.Size(300, 29)
        Me.cboSinger.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(60, 365)
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
        Me.cboCategory.Location = New System.Drawing.Point(130, 320)
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
        Me.cboProduction.Location = New System.Drawing.Point(130, 280)
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
        Me.btnSave.Location = New System.Drawing.Point(902, 447)
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
        Me.Label7.Location = New System.Drawing.Point(38, 91)
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
        Me.Label6.Location = New System.Drawing.Point(36, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Category:"
        '
        'txtAlbum
        '
        Me.txtAlbum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAlbum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlbum.FormattingEnabled = True
        Me.txtAlbum.Items.AddRange(New Object() {"Normal", "VIP"})
        Me.txtAlbum.Location = New System.Drawing.Point(130, 240)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(300, 29)
        Me.txtAlbum.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(25, 284)
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
        Me.Label4.Location = New System.Drawing.Point(55, 244)
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
        Me.Label3.Location = New System.Drawing.Point(79, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(130, 198)
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
        Me.Label2.Location = New System.Drawing.Point(93, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(130, 155)
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(1007, 490)
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
        Me.LineShape1.Y1 = 46
        Me.LineShape1.Y2 = 46
        '
        'frmUpdateSong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateSong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpdateSong"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAlbum As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents btnSingerOff As System.Windows.Forms.Button
    Friend WithEvents btnFullScreen As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents vlc As AxAXVLC.AxVLCPlugin2
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lstSingers As System.Windows.Forms.ListBox
    Friend WithEvents cboSinger As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduction As System.Windows.Forms.ComboBox
End Class
