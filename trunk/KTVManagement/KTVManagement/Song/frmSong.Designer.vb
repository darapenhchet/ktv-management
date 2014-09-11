<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSong))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.vlc = New AxAXVLC.AxVLCPlugin2()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvSongList = New System.Windows.Forms.DataGridView()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSongList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.None
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
        Me.btnUpdateSong.Location = New System.Drawing.Point(270, 0)
        Me.btnUpdateSong.Name = "btnUpdateSong"
        Me.btnUpdateSong.Size = New System.Drawing.Size(165, 30)
        Me.btnUpdateSong.TabIndex = 4
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
        Me.btnAddSong.Size = New System.Drawing.Size(140, 30)
        Me.btnAddSong.TabIndex = 2
        Me.btnAddSong.Text = "&Add Song"
        Me.btnAddSong.UseVisualStyleBackColor = False
        '
        'btnSongList
        '
        Me.btnSongList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSongList.BackColor = System.Drawing.Color.White
        Me.btnSongList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSongList.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSongList.FlatAppearance.BorderSize = 0
        Me.btnSongList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSongList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSongList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
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
        Me.Panel4.Controls.Add(Me.vlc)
        Me.Panel4.Controls.Add(Me.btnPlay)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.txtSearch)
        Me.Panel4.Controls.Add(Me.dgvSongList)
        Me.Panel4.Controls.Add(Me.ShapeContainer1)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(9, 104)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1007, 490)
        Me.Panel4.TabIndex = 4
        '
        'vlc
        '
        Me.vlc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.vlc.Enabled = True
        Me.vlc.Location = New System.Drawing.Point(406, 55)
        Me.vlc.Name = "vlc"
        Me.vlc.OcxState = CType(resources.GetObject("vlc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlc.Size = New System.Drawing.Size(596, 160)
        Me.vlc.TabIndex = 4
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
        Me.btnPlay.Location = New System.Drawing.Point(260, 185)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(140, 30)
        Me.btnPlay.TabIndex = 5
        Me.btnPlay.Text = "&Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(100, 68)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 27)
        Me.txtSearch.TabIndex = 1
        '
        'dgvSongList
        '
        Me.dgvSongList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSongList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSongList.Location = New System.Drawing.Point(4, 221)
        Me.dgvSongList.Name = "dgvSongList"
        Me.dgvSongList.RowHeadersVisible = False
        Me.dgvSongList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSongList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgvSongList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.dgvSongList.RowTemplate.Height = 30
        Me.dgvSongList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSongList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSongList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSongList.Size = New System.Drawing.Size(1000, 265)
        Me.dgvSongList.TabIndex = 0
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
        'frmSong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSong"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSongList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvSongList As System.Windows.Forms.DataGridView
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents vlc As AxAXVLC.AxVLCPlugin2
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
