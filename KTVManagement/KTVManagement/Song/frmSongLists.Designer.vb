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
        Me.vlc = New AxAXVLC.AxVLCPlugin2()
        Me.btnPlayPuase = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnTurnOff = New System.Windows.Forms.Button()
        Me.btnSeek = New System.Windows.Forms.Button()
        Me.dgvSongLists = New System.Windows.Forms.DataGridView()
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSongLists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vlc
        '
        Me.vlc.Enabled = True
        Me.vlc.Location = New System.Drawing.Point(857, 1)
        Me.vlc.Margin = New System.Windows.Forms.Padding(6)
        Me.vlc.Name = "vlc"
        Me.vlc.OcxState = CType(resources.GetObject("vlc.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vlc.Size = New System.Drawing.Size(399, 294)
        Me.vlc.TabIndex = 1
        '
        'btnPlayPuase
        '
        Me.btnPlayPuase.Location = New System.Drawing.Point(857, 307)
        Me.btnPlayPuase.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPlayPuase.Name = "btnPlayPuase"
        Me.btnPlayPuase.Size = New System.Drawing.Size(100, 30)
        Me.btnPlayPuase.TabIndex = 2
        Me.btnPlayPuase.Text = "Play"
        Me.btnPlayPuase.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(969, 307)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(6)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(100, 30)
        Me.btnNext.TabIndex = 3
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(1146, 391)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(100, 30)
        Me.btnPrevious.TabIndex = 4
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnTurnOff
        '
        Me.btnTurnOff.Location = New System.Drawing.Point(1146, 433)
        Me.btnTurnOff.Margin = New System.Windows.Forms.Padding(6)
        Me.btnTurnOff.Name = "btnTurnOff"
        Me.btnTurnOff.Size = New System.Drawing.Size(100, 30)
        Me.btnTurnOff.TabIndex = 5
        Me.btnTurnOff.Text = "Turn off Singer"
        Me.btnTurnOff.UseVisualStyleBackColor = True
        '
        'btnSeek
        '
        Me.btnSeek.Location = New System.Drawing.Point(1146, 475)
        Me.btnSeek.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSeek.Name = "btnSeek"
        Me.btnSeek.Size = New System.Drawing.Size(100, 30)
        Me.btnSeek.TabIndex = 6
        Me.btnSeek.Text = "Seek"
        Me.btnSeek.UseVisualStyleBackColor = True
        '
        'dgvSongLists
        '
        Me.dgvSongLists.BackgroundColor = System.Drawing.Color.White
        Me.dgvSongLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSongLists.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvSongLists.Location = New System.Drawing.Point(0, 148)
        Me.dgvSongLists.Name = "dgvSongLists"
        Me.dgvSongLists.RowTemplate.Height = 30
        Me.dgvSongLists.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSongLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSongLists.ShowRowErrors = False
        Me.dgvSongLists.Size = New System.Drawing.Size(831, 513)
        Me.dgvSongLists.TabIndex = 7
        '
        'frmSongLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 661)
        Me.Controls.Add(Me.dgvSongLists)
        Me.Controls.Add(Me.btnSeek)
        Me.Controls.Add(Me.btnTurnOff)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPlayPuase)
        Me.Controls.Add(Me.vlc)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmSongLists"
        Me.Text = "frmSongLists"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.vlc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSongLists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vlc As AxAXVLC.AxVLCPlugin2
    Friend WithEvents btnPlayPuase As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnTurnOff As System.Windows.Forms.Button
    Friend WithEvents btnSeek As System.Windows.Forms.Button
    Friend WithEvents dgvSongLists As System.Windows.Forms.DataGridView
End Class
