<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateLanguage
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
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnUpdateLanguage = New System.Windows.Forms.Button()
        Me.btnAddLanguage = New System.Windows.Forms.Button()
        Me.btnLanguageList = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.pbPhoto = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLanguage = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(243, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manage Language"
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
        Me.Panel5.Controls.Add(Me.btnUpdateLanguage)
        Me.Panel5.Controls.Add(Me.btnAddLanguage)
        Me.Panel5.Controls.Add(Me.btnLanguageList)
        Me.Panel5.Location = New System.Drawing.Point(9, 104)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1007, 30)
        Me.Panel5.TabIndex = 3
        '
        'btnUpdateLanguage
        '
        Me.btnUpdateLanguage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdateLanguage.BackColor = System.Drawing.Color.White
        Me.btnUpdateLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateLanguage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUpdateLanguage.FlatAppearance.BorderSize = 0
        Me.btnUpdateLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateLanguage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateLanguage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnUpdateLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateLanguage.Location = New System.Drawing.Point(266, 0)
        Me.btnUpdateLanguage.Name = "btnUpdateLanguage"
        Me.btnUpdateLanguage.Size = New System.Drawing.Size(160, 30)
        Me.btnUpdateLanguage.TabIndex = 4
        Me.btnUpdateLanguage.Text = "&Update Language"
        Me.btnUpdateLanguage.UseVisualStyleBackColor = False
        '
        'btnAddLanguage
        '
        Me.btnAddLanguage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAddLanguage.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAddLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddLanguage.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnAddLanguage.FlatAppearance.BorderSize = 0
        Me.btnAddLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLanguage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLanguage.ForeColor = System.Drawing.Color.White
        Me.btnAddLanguage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddLanguage.Location = New System.Drawing.Point(130, 0)
        Me.btnAddLanguage.Name = "btnAddLanguage"
        Me.btnAddLanguage.Size = New System.Drawing.Size(136, 30)
        Me.btnAddLanguage.TabIndex = 2
        Me.btnAddLanguage.Text = "&Add Language"
        Me.btnAddLanguage.UseVisualStyleBackColor = False
        '
        'btnLanguageList
        '
        Me.btnLanguageList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLanguageList.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnLanguageList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLanguageList.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLanguageList.FlatAppearance.BorderSize = 0
        Me.btnLanguageList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLanguageList.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLanguageList.ForeColor = System.Drawing.Color.White
        Me.btnLanguageList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLanguageList.Location = New System.Drawing.Point(0, 0)
        Me.btnLanguageList.Name = "btnLanguageList"
        Me.btnLanguageList.Size = New System.Drawing.Size(130, 30)
        Me.btnLanguageList.TabIndex = 1
        Me.btnLanguageList.Text = "Language &List"
        Me.btnLanguageList.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.Controls.Add(Me.pbPhoto)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtLanguage)
        Me.Panel4.Controls.Add(Me.txtID)
        Me.Panel4.Controls.Add(Me.ShapeContainer1)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(9, 104)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1007, 490)
        Me.Panel4.TabIndex = 4
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
        'pbPhoto
        '
        Me.pbPhoto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbPhoto.Location = New System.Drawing.Point(782, 62)
        Me.pbPhoto.Name = "pbPhoto"
        Me.pbPhoto.Size = New System.Drawing.Size(150, 165)
        Me.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPhoto.TabIndex = 49
        Me.pbPhoto.TabStop = False
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
        Me.btnSave.Location = New System.Drawing.Point(599, 292)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 30)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(40, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(287, 23)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Update Language Information"
        '
        'txtLanguage
        '
        Me.txtLanguage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLanguage.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLanguage.Location = New System.Drawing.Point(399, 200)
        Me.txtLanguage.Name = "txtLanguage"
        Me.txtLanguage.Size = New System.Drawing.Size(300, 27)
        Me.txtLanguage.TabIndex = 47
        '
        'txtID
        '
        Me.txtID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(399, 157)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(300, 27)
        Me.txtID.TabIndex = 45
        Me.txtID.Text = "Auto Number"
        '
        'frmUpdateLanguage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 600)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUpdateLanguage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUpdateLanguage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pbPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnUpdateLanguage As System.Windows.Forms.Button
    Friend WithEvents btnAddLanguage As System.Windows.Forms.Button
    Friend WithEvents btnLanguageList As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents pbPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLanguage As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
End Class
