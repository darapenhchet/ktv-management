<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSongMain
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSinger = New System.Windows.Forms.Button()
        Me.btnLanguage = New System.Windows.Forms.Button()
        Me.btnProduction = New System.Windows.Forms.Button()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.btnRoomList = New System.Windows.Forms.Button()
        Me.btnSong = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Song Information"
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
        Me.Panel5.Location = New System.Drawing.Point(9, 104)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1007, 30)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.Controls.Add(Me.btnSinger)
        Me.Panel4.Controls.Add(Me.btnLanguage)
        Me.Panel4.Controls.Add(Me.btnProduction)
        Me.Panel4.Controls.Add(Me.btnCategory)
        Me.Panel4.Controls.Add(Me.btnRoomList)
        Me.Panel4.Controls.Add(Me.btnSong)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(9, 104)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1007, 490)
        Me.Panel4.TabIndex = 4
        '
        'btnSinger
        '
        Me.btnSinger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSinger.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSinger.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSinger.FlatAppearance.BorderSize = 0
        Me.btnSinger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSinger.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinger.ForeColor = System.Drawing.Color.White
        Me.btnSinger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSinger.Location = New System.Drawing.Point(414, 212)
        Me.btnSinger.Name = "btnSinger"
        Me.btnSinger.Size = New System.Drawing.Size(200, 100)
        Me.btnSinger.TabIndex = 8
        Me.btnSinger.Text = "&Singer"
        Me.btnSinger.UseVisualStyleBackColor = False
        '
        'btnLanguage
        '
        Me.btnLanguage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLanguage.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLanguage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLanguage.FlatAppearance.BorderSize = 0
        Me.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLanguage.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLanguage.ForeColor = System.Drawing.Color.White
        Me.btnLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLanguage.Location = New System.Drawing.Point(722, 106)
        Me.btnLanguage.Name = "btnLanguage"
        Me.btnLanguage.Size = New System.Drawing.Size(200, 100)
        Me.btnLanguage.TabIndex = 7
        Me.btnLanguage.Text = "&Language"
        Me.btnLanguage.UseVisualStyleBackColor = False
        '
        'btnProduction
        '
        Me.btnProduction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnProduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnProduction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProduction.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnProduction.FlatAppearance.BorderSize = 0
        Me.btnProduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduction.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduction.ForeColor = System.Drawing.Color.White
        Me.btnProduction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduction.Location = New System.Drawing.Point(516, 106)
        Me.btnProduction.Name = "btnProduction"
        Me.btnProduction.Size = New System.Drawing.Size(200, 100)
        Me.btnProduction.TabIndex = 6
        Me.btnProduction.Text = "&Production"
        Me.btnProduction.UseVisualStyleBackColor = False
        '
        'btnCategory
        '
        Me.btnCategory.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCategory.FlatAppearance.BorderSize = 0
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategory.ForeColor = System.Drawing.Color.White
        Me.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategory.Location = New System.Drawing.Point(310, 106)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(200, 100)
        Me.btnCategory.TabIndex = 5
        Me.btnCategory.Text = "&Category"
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'btnRoomList
        '
        Me.btnRoomList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRoomList.BackColor = System.Drawing.Color.White
        Me.btnRoomList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRoomList.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRoomList.FlatAppearance.BorderSize = 0
        Me.btnRoomList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRoomList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRoomList.Location = New System.Drawing.Point(71, 281)
        Me.btnRoomList.Name = "btnRoomList"
        Me.btnRoomList.Size = New System.Drawing.Size(100, 30)
        Me.btnRoomList.TabIndex = 1
        Me.btnRoomList.Text = "Room &List"
        Me.btnRoomList.UseVisualStyleBackColor = False
        '
        'btnSong
        '
        Me.btnSong.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSong.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSong.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSong.FlatAppearance.BorderSize = 0
        Me.btnSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSong.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSong.ForeColor = System.Drawing.Color.White
        Me.btnSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSong.Location = New System.Drawing.Point(104, 106)
        Me.btnSong.Name = "btnSong"
        Me.btnSong.Size = New System.Drawing.Size(200, 100)
        Me.btnSong.TabIndex = 2
        Me.btnSong.Text = "&Song"
        Me.btnSong.UseVisualStyleBackColor = False
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
        'frmSongMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSongMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSongMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnSong As System.Windows.Forms.Button
    Friend WithEvents btnRoomList As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnProduction As System.Windows.Forms.Button
    Friend WithEvents btnCategory As System.Windows.Forms.Button
    Friend WithEvents btnSinger As System.Windows.Forms.Button
    Friend WithEvents btnLanguage As System.Windows.Forms.Button
End Class
