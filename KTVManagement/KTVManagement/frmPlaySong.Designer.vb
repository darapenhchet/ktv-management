<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlaySong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPlaySong))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.vlc = New AxAXVLC.AxVLCPlugin2()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.openSong = New System.Windows.Forms.OpenFileDialog()
        Me.btnTurnOffSingerSound = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.vlc)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 522)
        Me.Panel1.TabIndex = 0
        '
        'vlc
        '
        Me.vlc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vlc.Enabled = True
        Me.vlc.Location = New System.Drawing.Point(0, 0)
        Me.vlc.Name = "vlc"
        Me.vlc.OcxState = CType(resources.GetObject("vlc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlc.Size = New System.Drawing.Size(888, 522)
        Me.vlc.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnTurnOffSingerSound)
        Me.Panel2.Controls.Add(Me.btnLoad)
        Me.Panel2.Controls.Add(Me.btnPlay)
        Me.Panel2.Location = New System.Drawing.Point(0, 416)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(888, 106)
        Me.Panel2.TabIndex = 2
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(3, 80)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(3, 3)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnTurnOffSingerSound
        '
        Me.btnTurnOffSingerSound.Location = New System.Drawing.Point(120, 80)
        Me.btnTurnOffSingerSound.Name = "btnTurnOffSingerSound"
        Me.btnTurnOffSingerSound.Size = New System.Drawing.Size(180, 23)
        Me.btnTurnOffSingerSound.TabIndex = 2
        Me.btnTurnOffSingerSound.Text = "TurnOff Singer Sound"
        Me.btnTurnOffSingerSound.UseVisualStyleBackColor = True
        '
        'frmPlaySong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.ClientSize = New System.Drawing.Size(888, 522)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPlaySong"
        Me.Text = "frmPlaySong"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents vlc As AxAXVLC.AxVLCPlugin2
    Friend WithEvents openSong As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnTurnOffSingerSound As System.Windows.Forms.Button
End Class
