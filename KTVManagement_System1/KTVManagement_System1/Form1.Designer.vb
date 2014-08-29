<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsinid = New System.Windows.Forms.TextBox()
        Me.txtsinName = New System.Windows.Forms.TextBox()
        Me.cboproduction = New System.Windows.Forms.ComboBox()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.ListSinger = New System.Windows.Forms.ListBox()
        Me.cbogender = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Singer_ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Singer_Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Production"
        '
        'txtsinid
        '
        Me.txtsinid.Location = New System.Drawing.Point(127, 94)
        Me.txtsinid.Multiline = True
        Me.txtsinid.Name = "txtsinid"
        Me.txtsinid.Size = New System.Drawing.Size(196, 28)
        Me.txtsinid.TabIndex = 1
        '
        'txtsinName
        '
        Me.txtsinName.Location = New System.Drawing.Point(127, 140)
        Me.txtsinName.Multiline = True
        Me.txtsinName.Name = "txtsinName"
        Me.txtsinName.Size = New System.Drawing.Size(196, 28)
        Me.txtsinName.TabIndex = 1
        '
        'cboproduction
        '
        Me.cboproduction.FormattingEnabled = True
        Me.cboproduction.Location = New System.Drawing.Point(127, 234)
        Me.cboproduction.Name = "cboproduction"
        Me.cboproduction.Size = New System.Drawing.Size(196, 21)
        Me.cboproduction.TabIndex = 2
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(401, 94)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(108, 36)
        Me.btnnew.TabIndex = 3
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(401, 137)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(108, 36)
        Me.btnsave.TabIndex = 3
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(401, 183)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 36)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Remove"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(401, 230)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(108, 36)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'ListSinger
        '
        Me.ListSinger.FormattingEnabled = True
        Me.ListSinger.Location = New System.Drawing.Point(76, 272)
        Me.ListSinger.Name = "ListSinger"
        Me.ListSinger.Size = New System.Drawing.Size(528, 95)
        Me.ListSinger.TabIndex = 4
        '
        'cbogender
        '
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbogender.Location = New System.Drawing.Point(127, 187)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(196, 21)
        Me.cbogender.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.KTVManagement_System.My.Resources.Resources.bgsinger
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 485)
        Me.Panel1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 485)
        Me.Controls.Add(Me.ListSinger)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.cbogender)
        Me.Controls.Add(Me.cboproduction)
        Me.Controls.Add(Me.txtsinName)
        Me.Controls.Add(Me.txtsinid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsinid As System.Windows.Forms.TextBox
    Friend WithEvents txtsinName As System.Windows.Forms.TextBox
    Friend WithEvents cboproduction As System.Windows.Forms.ComboBox
    Friend WithEvents btnnew As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents ListSinger As System.Windows.Forms.ListBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
