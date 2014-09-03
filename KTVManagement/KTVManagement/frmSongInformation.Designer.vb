Imports DataLayer

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSongInformation
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveAll = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.dgvSongerLists = New System.Windows.Forms.DataGridView()
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Album = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Language = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSinger = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dgvSingerLists = New System.Windows.Forms.DataGridView()
        Me.Singer = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.cboProduction = New System.Windows.Forms.ComboBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.openSongs = New System.Windows.Forms.OpenFileDialog()
        Me.ClsSingerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSongerLists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSingerLists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsSingerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1166, 759)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveAll)
        Me.GroupBox2.Controls.Add(Me.btnBrowse)
        Me.GroupBox2.Controls.Add(Me.dgvSongerLists)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.btnUpdate)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1144, 444)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Song Lists"
        '
        'btnSaveAll
        '
        Me.btnSaveAll.Location = New System.Drawing.Point(730, 401)
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Size = New System.Drawing.Size(130, 39)
        Me.btnSaveAll.TabIndex = 28
        Me.btnSaveAll.Text = "Save All"
        Me.btnSaveAll.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(1002, 18)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(130, 39)
        Me.btnBrowse.TabIndex = 31
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'dgvSongerLists
        '
        Me.dgvSongerLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSongerLists.BackgroundColor = System.Drawing.Color.White
        Me.dgvSongerLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSongerLists.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Album, Me.Category, Me.Language, Me.cSinger})
        Me.dgvSongerLists.Location = New System.Drawing.Point(14, 63)
        Me.dgvSongerLists.Name = "dgvSongerLists"
        Me.dgvSongerLists.RowTemplate.Height = 30
        Me.dgvSongerLists.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSongerLists.Size = New System.Drawing.Size(1118, 332)
        Me.dgvSongerLists.TabIndex = 29
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
        'cSinger
        '
        Me.cSinger.HeaderText = "Singer"
        Me.cSinger.Name = "cSinger"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(866, 401)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 39)
        Me.btnDelete.TabIndex = 29
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1002, 401)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 39)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.dgvSingerLists)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboLanguage)
        Me.GroupBox1.Controls.Add(Me.txtAlbum)
        Me.GroupBox1.Controls.Add(Me.cboProduction)
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1144, 216)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Song Information Details"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1002, 30)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(130, 39)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dgvSingerLists
        '
        Me.dgvSingerLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSingerLists.BackgroundColor = System.Drawing.Color.White
        Me.dgvSingerLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSingerLists.ColumnHeadersVisible = False
        Me.dgvSingerLists.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Singer})
        Me.dgvSingerLists.Location = New System.Drawing.Point(719, 108)
        Me.dgvSingerLists.Name = "dgvSingerLists"
        Me.dgvSingerLists.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSingerLists.RowHeadersVisible = False
        Me.dgvSingerLists.RowTemplate.Height = 30
        Me.dgvSingerLists.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSingerLists.Size = New System.Drawing.Size(240, 81)
        Me.dgvSingerLists.TabIndex = 24
        '
        'Singer
        '
        Me.Singer.HeaderText = "Singer"
        Me.Singer.Items.AddRange(New Object() {"Preap Sovath", "Sokun Nisa", "Pich Sophea", "Chhay Virakyuth"})
        Me.Singer.Name = "Singer"
        Me.Singer.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Singer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(138, 30)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(164, 33)
        Me.txtID.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Album:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(609, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Category:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(631, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Singer:"
        '
        'cboLanguage
        '
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Location = New System.Drawing.Point(719, 69)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(244, 33)
        Me.cboLanguage.TabIndex = 23
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(138, 114)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(244, 33)
        Me.txtAlbum.TabIndex = 20
        '
        'cboProduction
        '
        Me.cboProduction.FormattingEnabled = True
        Me.cboProduction.Location = New System.Drawing.Point(138, 156)
        Me.cboProduction.Name = "cboProduction"
        Me.cboProduction.Size = New System.Drawing.Size(244, 33)
        Me.cboProduction.TabIndex = 21
        '
        'cboCategory
        '
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Location = New System.Drawing.Point(719, 30)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(244, 33)
        Me.cboCategory.TabIndex = 22
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(138, 72)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(365, 33)
        Me.txtTitle.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(602, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Language:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Title:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Production:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(396, -61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 65)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Song Information "
        '
        'openSongs
        '
        Me.openSongs.FileName = "OpenFileDialog1"
        Me.openSongs.Multiselect = True
        '
        'ClsSingerBindingSource
        '
        Me.ClsSingerBindingSource.DataSource = GetType(DataLayer.ClsSinger)
        '
        'frmSongInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 700)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmSongInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSongInformation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvSongerLists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSingerLists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsSingerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents cboCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cboProduction As System.Windows.Forms.ComboBox
    Friend WithEvents txtAlbum As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSongerLists As System.Windows.Forms.DataGridView
    Friend WithEvents dgvSingerLists As System.Windows.Forms.DataGridView
    Friend WithEvents btnSaveAll As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents ClsSingerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents openSongs As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Singer As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Album As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Language As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cSinger As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
