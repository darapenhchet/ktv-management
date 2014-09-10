<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainAdmin
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
        Me.btnSongInformation = New System.Windows.Forms.Button()
        Me.btnUserInformation = New System.Windows.Forms.Button()
        Me.btnRoomInformation = New System.Windows.Forms.Button()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.btnAboutUs = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExitMain = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSongInformation
        '
        Me.btnSongInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnSongInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSongInformation.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSongInformation.ForeColor = System.Drawing.Color.White
        Me.btnSongInformation.Location = New System.Drawing.Point(66, 147)
        Me.btnSongInformation.Name = "btnSongInformation"
        Me.btnSongInformation.Size = New System.Drawing.Size(250, 100)
        Me.btnSongInformation.TabIndex = 0
        Me.btnSongInformation.Text = "Song Details"
        Me.btnSongInformation.UseVisualStyleBackColor = False
        '
        'btnUserInformation
        '
        Me.btnUserInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnUserInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserInformation.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserInformation.ForeColor = System.Drawing.Color.White
        Me.btnUserInformation.Location = New System.Drawing.Point(322, 147)
        Me.btnUserInformation.Name = "btnUserInformation"
        Me.btnUserInformation.Size = New System.Drawing.Size(250, 100)
        Me.btnUserInformation.TabIndex = 2
        Me.btnUserInformation.Text = "User Details"
        Me.btnUserInformation.UseVisualStyleBackColor = False
        '
        'btnRoomInformation
        '
        Me.btnRoomInformation.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnRoomInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomInformation.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomInformation.ForeColor = System.Drawing.Color.White
        Me.btnRoomInformation.Location = New System.Drawing.Point(578, 147)
        Me.btnRoomInformation.Name = "btnRoomInformation"
        Me.btnRoomInformation.Size = New System.Drawing.Size(250, 100)
        Me.btnRoomInformation.TabIndex = 3
        Me.btnRoomInformation.Text = "Room Details"
        Me.btnRoomInformation.UseVisualStyleBackColor = False
        '
        'btnGuest
        '
        Me.btnGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuest.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuest.ForeColor = System.Drawing.Color.White
        Me.btnGuest.Location = New System.Drawing.Point(834, 147)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(250, 100)
        Me.btnGuest.TabIndex = 4
        Me.btnGuest.Text = "Guest Details"
        Me.btnGuest.UseVisualStyleBackColor = False
        '
        'btnAboutUs
        '
        Me.btnAboutUs.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAboutUs.Font = New System.Drawing.Font("Segoe UI Symbol", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAboutUs.ForeColor = System.Drawing.Color.White
        Me.btnAboutUs.Location = New System.Drawing.Point(466, 253)
        Me.btnAboutUs.Name = "btnAboutUs"
        Me.btnAboutUs.Size = New System.Drawing.Size(250, 100)
        Me.btnAboutUs.TabIndex = 7
        Me.btnAboutUs.Text = "About Us"
        Me.btnAboutUs.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(589, 65)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "KTV Management System"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Symbol", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(919, 7)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(228, 45)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Administrator"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExitMain)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAboutUs)
        Me.Panel1.Controls.Add(Me.btnGuest)
        Me.Panel1.Controls.Add(Me.btnRoomInformation)
        Me.Panel1.Controls.Add(Me.btnUserInformation)
        Me.Panel1.Controls.Add(Me.btnSongInformation)
        Me.Panel1.Location = New System.Drawing.Point(12, -34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1158, 508)
        Me.Panel1.TabIndex = 1
        '
        'btnExitMain
        '
        Me.btnExitMain.AutoSize = True
        Me.btnExitMain.Font = New System.Drawing.Font("Segoe UI Symbol", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitMain.ForeColor = System.Drawing.Color.Black
        Me.btnExitMain.Location = New System.Drawing.Point(1073, 52)
        Me.btnExitMain.Name = "btnExitMain"
        Me.btnExitMain.Size = New System.Drawing.Size(74, 45)
        Me.btnExitMain.TabIndex = 10
        Me.btnExitMain.Text = "Exit"
        Me.btnExitMain.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmMainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 472)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "frmMainAdmin"
        Me.Text = "frmMainAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSongInformation As System.Windows.Forms.Button
    Friend WithEvents btnUserInformation As System.Windows.Forms.Button
    Friend WithEvents btnRoomInformation As System.Windows.Forms.Button
    Friend WithEvents btnGuest As System.Windows.Forms.Button
    Friend WithEvents btnAboutUs As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnExitMain As System.Windows.Forms.Label
End Class
