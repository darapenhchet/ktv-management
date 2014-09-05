<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSongLists
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSongLists))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.vlc = New AxAXVLC.AxVLCPlugin2()
        Me.btnPlayPuase = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnTurnOff = New System.Windows.Forms.Button()
        Me.btnSeek = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 372)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1257, 289)
        Me.DataGridView1.TabIndex = 0
        '
        'vlc
        '
        Me.vlc.Enabled = True
        Me.vlc.Location = New System.Drawing.Point(857, 1)
        Me.vlc.Name = "vlc"
        Me.vlc.OcxState = CType(resources.GetObject("vlc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlc.Size = New System.Drawing.Size(399, 294)
        Me.vlc.TabIndex = 1
        '
        'btnPlayPuase
        '
        Me.btnPlayPuase.Location = New System.Drawing.Point(857, 301)
        Me.btnPlayPuase.Name = "btnPlayPuase"
        Me.btnPlayPuase.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayPuase.TabIndex = 2
        Me.btnPlayPuase.Text = "Play"
        Me.btnPlayPuase.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(938, 301)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(1019, 301)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 4
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnTurnOff
        '
        Me.btnTurnOff.Location = New System.Drawing.Point(1100, 301)
        Me.btnTurnOff.Name = "btnTurnOff"
        Me.btnTurnOff.Size = New System.Drawing.Size(75, 23)
        Me.btnTurnOff.TabIndex = 5
        Me.btnTurnOff.Text = "Turn off Singer"
        Me.btnTurnOff.UseVisualStyleBackColor = True
        '
        'btnSeek
        '
        Me.btnSeek.Location = New System.Drawing.Point(1181, 301)
        Me.btnSeek.Name = "btnSeek"
        Me.btnSeek.Size = New System.Drawing.Size(75, 23)
        Me.btnSeek.TabIndex = 6
        Me.btnSeek.Text = "Seek"
        Me.btnSeek.UseVisualStyleBackColor = True
        '
        'frmSongLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 661)
        Me.Controls.Add(Me.btnSeek)
        Me.Controls.Add(Me.btnTurnOff)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPlayPuase)
        Me.Controls.Add(Me.vlc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmSongLists"
        Me.Text = "frmSongLists"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents vlc As AxAXVLC.AxVLCPlugin2
    Friend WithEvents btnPlayPuase As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnTurnOff As System.Windows.Forms.Button
    Friend WithEvents btnSeek As System.Windows.Forms.Button
End Class
