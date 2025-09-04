<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmusersManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmusersManagement))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.st_bar = New System.Windows.Forms.StatusStrip()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.userid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enableded = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Print = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AddNew = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.cactive = New System.Windows.Forms.CheckBox()
        Me.Cadd = New System.Windows.Forms.CheckBox()
        Me.cprint = New System.Windows.Forms.CheckBox()
        Me.cedit = New System.Windows.Forms.CheckBox()
        Me.caddusers = New System.Windows.Forms.CheckBox()
        Me.cdelete = New System.Windows.Forms.CheckBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_full_name = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_user_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.CmbRole = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'st_bar
        '
        Me.st_bar.Location = New System.Drawing.Point(0, 380)
        Me.st_bar.Name = "st_bar"
        Me.st_bar.Padding = New System.Windows.Forms.Padding(14, 0, 1, 0)
        Me.st_bar.Size = New System.Drawing.Size(643, 22)
        Me.st_bar.TabIndex = 7
        Me.st_bar.Text = "StatusStrip1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cancel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delete, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_add, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_close, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_edit, 4, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 332)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(619, 41)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.Location = New System.Drawing.Point(325, 4)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(73, 33)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.Location = New System.Drawing.Point(222, 4)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(73, 33)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.Location = New System.Drawing.Point(531, 4)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(73, 33)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Add"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(418, 4)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 33)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_close.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.Location = New System.Drawing.Point(14, 4)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(77, 33)
        Me.btn_close.TabIndex = 1
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.Location = New System.Drawing.Point(119, 4)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(73, 33)
        Me.btn_edit.TabIndex = 4
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(634, 155)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Users List"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.userid, Me.Column4, Me.Username, Me.Password, Me.Enableded, Me.Print, Me.AddNew, Me.Column3, Me.Column2, Me.Column1, Me.Column5})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 17)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(628, 136)
        Me.DataGridView1.TabIndex = 2
        '
        'userid
        '
        Me.userid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.userid.HeaderText = "ID"
        Me.userid.Name = "userid"
        Me.userid.ReadOnly = True
        Me.userid.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "Name"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'Username
        '
        Me.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Username.FillWeight = 150.0!
        Me.Username.HeaderText = "Username"
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        Me.Username.Width = 96
        '
        'Password
        '
        Me.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Format = "***********"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Password.DefaultCellStyle = DataGridViewCellStyle2
        Me.Password.FillWeight = 150.0!
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        Me.Password.Visible = False
        '
        'Enableded
        '
        Me.Enableded.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Enableded.FillWeight = 160.0!
        Me.Enableded.HeaderText = "Active/Inactive"
        Me.Enableded.Name = "Enableded"
        Me.Enableded.ReadOnly = True
        Me.Enableded.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Enableded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Enableded.Width = 125
        '
        'Print
        '
        Me.Print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Print.HeaderText = "Print"
        Me.Print.Name = "Print"
        Me.Print.ReadOnly = True
        Me.Print.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Print.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'AddNew
        '
        Me.AddNew.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AddNew.HeaderText = "Add"
        Me.AddNew.Name = "AddNew"
        Me.AddNew.ReadOnly = True
        Me.AddNew.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AddNew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Delete"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Users"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Edit"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Column5
        '
        Me.Column5.HeaderText = "Role"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Controls.Add(Me.cactive, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Cadd, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cprint, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cedit, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.caddusers, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cdelete, 5, 0)
        Me.TableLayoutPanel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(11, 297)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(578, 28)
        Me.TableLayoutPanel2.TabIndex = 30
        '
        'cactive
        '
        Me.cactive.AutoSize = True
        Me.cactive.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cactive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cactive.Location = New System.Drawing.Point(513, 2)
        Me.cactive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cactive.Name = "cactive"
        Me.cactive.Size = New System.Drawing.Size(62, 17)
        Me.cactive.TabIndex = 9
        Me.cactive.Text = "Active"
        Me.cactive.UseVisualStyleBackColor = False
        '
        'Cadd
        '
        Me.Cadd.AutoSize = True
        Me.Cadd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Cadd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Cadd.Location = New System.Drawing.Point(431, 2)
        Me.Cadd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cadd.Name = "Cadd"
        Me.Cadd.Size = New System.Drawing.Size(48, 17)
        Me.Cadd.TabIndex = 11
        Me.Cadd.Text = "Add"
        Me.Cadd.UseVisualStyleBackColor = False
        '
        'cprint
        '
        Me.cprint.AutoSize = True
        Me.cprint.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cprint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cprint.Location = New System.Drawing.Point(330, 2)
        Me.cprint.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cprint.Name = "cprint"
        Me.cprint.Size = New System.Drawing.Size(53, 17)
        Me.cprint.TabIndex = 10
        Me.cprint.Text = "Print"
        Me.cprint.UseVisualStyleBackColor = False
        '
        'cedit
        '
        Me.cedit.AutoSize = True
        Me.cedit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cedit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cedit.Location = New System.Drawing.Point(240, 2)
        Me.cedit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cedit.Name = "cedit"
        Me.cedit.Size = New System.Drawing.Size(47, 17)
        Me.cedit.TabIndex = 14
        Me.cedit.Text = "Edit"
        Me.cedit.UseVisualStyleBackColor = False
        '
        'caddusers
        '
        Me.caddusers.AutoSize = True
        Me.caddusers.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.caddusers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.caddusers.Location = New System.Drawing.Point(120, 2)
        Me.caddusers.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.caddusers.Name = "caddusers"
        Me.caddusers.Size = New System.Drawing.Size(71, 17)
        Me.caddusers.TabIndex = 13
        Me.caddusers.Text = "Manage"
        Me.caddusers.UseVisualStyleBackColor = False
        '
        'cdelete
        '
        Me.cdelete.AutoSize = True
        Me.cdelete.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cdelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cdelete.Location = New System.Drawing.Point(32, 2)
        Me.cdelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(63, 17)
        Me.cdelete.TabIndex = 12
        Me.cdelete.Text = "Delete"
        Me.cdelete.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.Location = New System.Drawing.Point(65, 52)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_password.MaxLength = 32
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txt_password.Size = New System.Drawing.Size(169, 21)
        Me.txt_password.TabIndex = 8
        '
        'txt_full_name
        '
        Me.txt_full_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_full_name.Location = New System.Drawing.Point(65, 6)
        Me.txt_full_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_full_name.MaxLength = 32
        Me.txt_full_name.Name = "txt_full_name"
        Me.txt_full_name.Size = New System.Drawing.Size(169, 21)
        Me.txt_full_name.TabIndex = 6
        '
        'txt_username
        '
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_username.Location = New System.Drawing.Point(65, 29)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_username.MaxLength = 100
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(169, 21)
        Me.txt_username.TabIndex = 7
        '
        'txt_user_id
        '
        Me.txt_user_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_user_id.Location = New System.Drawing.Point(7, 6)
        Me.txt_user_id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_user_id.Name = "txt_user_id"
        Me.txt_user_id.Size = New System.Drawing.Size(52, 21)
        Me.txt_user_id.TabIndex = 5
        Me.txt_user_id.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(239, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Full Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Username"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(239, 52)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.81203!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.18797!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_password, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_user_id, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_username, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.CmbRole, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txt_full_name, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(144, 177)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.42619!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.42618!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.14763!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(331, 98)
        Me.TableLayoutPanel3.TabIndex = 21
        '
        'CmbRole
        '
        Me.CmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmbRole.FormattingEnabled = True
        Me.CmbRole.Location = New System.Drawing.Point(65, 74)
        Me.CmbRole.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbRole.Name = "CmbRole"
        Me.CmbRole.Size = New System.Drawing.Size(169, 21)
        Me.CmbRole.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Role"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmusersManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 402)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.st_bar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmusersManagement"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Users"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents st_bar As StatusStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_full_name As TextBox
    Friend WithEvents txt_user_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cactive As CheckBox
    Friend WithEvents Cadd As CheckBox
    Friend WithEvents cprint As CheckBox
    Friend WithEvents cedit As CheckBox
    Friend WithEvents caddusers As CheckBox
    Friend WithEvents cdelete As CheckBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents CmbRole As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents userid As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
    Friend WithEvents Enableded As DataGridViewCheckBoxColumn
    Friend WithEvents Print As DataGridViewCheckBoxColumn
    Friend WithEvents AddNew As DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
