<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainProductsCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainProductsCategory))
        Me.txtcatname = New System.Windows.Forms.TextBox()
        Me.txt_cat_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cshow = New System.Windows.Forms.CheckBox()
        Me.cactive = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_summary = New System.Windows.Forms.TextBox()
        Me.txt_cat_english = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.st_bar = New System.Windows.Forms.StatusStrip()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.PCID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCNameEnglish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Summary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Showin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcatname
        '
        Me.txtcatname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtcatname.Location = New System.Drawing.Point(45, 66)
        Me.txtcatname.MaxLength = 255
        Me.txtcatname.Name = "txtcatname"
        Me.txtcatname.Size = New System.Drawing.Size(215, 21)
        Me.txtcatname.TabIndex = 6
        '
        'txt_cat_id
        '
        Me.txt_cat_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cat_id.Enabled = False
        Me.txt_cat_id.Location = New System.Drawing.Point(6, 66)
        Me.txt_cat_id.Name = "txt_cat_id"
        Me.txt_cat_id.Size = New System.Drawing.Size(38, 21)
        Me.txt_cat_id.TabIndex = 5
        Me.txt_cat_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Category Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cshow)
        Me.GroupBox2.Controls.Add(Me.cactive)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_summary)
        Me.GroupBox2.Controls.Add(Me.txt_cat_english)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtcatname)
        Me.GroupBox2.Controls.Add(Me.txt_cat_id)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(267, 290)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sales Category"
        '
        'cshow
        '
        Me.cshow.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cshow.AutoSize = True
        Me.cshow.Location = New System.Drawing.Point(7, 252)
        Me.cshow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cshow.Name = "cshow"
        Me.cshow.Size = New System.Drawing.Size(148, 17)
        Me.cshow.TabIndex = 21
        Me.cshow.Text = "Show in quick sale list"
        Me.cshow.UseVisualStyleBackColor = True
        '
        'cactive
        '
        Me.cactive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cactive.AutoSize = True
        Me.cactive.Location = New System.Drawing.Point(5, 231)
        Me.cactive.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cactive.Name = "cactive"
        Me.cactive.Size = New System.Drawing.Size(84, 17)
        Me.cactive.TabIndex = 20
        Me.cactive.Text = "Activation"
        Me.cactive.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Category Description"
        '
        'txt_summary
        '
        Me.txt_summary.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_summary.Location = New System.Drawing.Point(7, 168)
        Me.txt_summary.MaxLength = 500
        Me.txt_summary.Multiline = True
        Me.txt_summary.Name = "txt_summary"
        Me.txt_summary.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_summary.Size = New System.Drawing.Size(254, 58)
        Me.txt_summary.TabIndex = 18
        '
        'txt_cat_english
        '
        Me.txt_cat_english.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_cat_english.Location = New System.Drawing.Point(7, 117)
        Me.txt_cat_english.MaxLength = 255
        Me.txt_cat_english.Name = "txt_cat_english"
        Me.txt_cat_english.Size = New System.Drawing.Size(254, 21)
        Me.txt_cat_english.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Alternative category name"
        '
        'st_bar
        '
        Me.st_bar.Location = New System.Drawing.Point(0, 406)
        Me.st_bar.Name = "st_bar"
        Me.st_bar.Padding = New System.Windows.Forms.Padding(19, 0, 1, 0)
        Me.st_bar.Size = New System.Drawing.Size(958, 22)
        Me.st_bar.TabIndex = 11
        Me.st_bar.Text = "StatusStrip1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PCID, Me.PCName, Me.PCNameEnglish, Me.Summary, Me.Active, Me.Showin})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(657, 273)
        Me.DataGridView1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(283, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(663, 293)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Categories"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(88, 330)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(811, 56)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.Location = New System.Drawing.Point(290, 3)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(94, 50)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Image = CType(resources.GetObject("btn_delete.Image"), System.Drawing.Image)
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.Location = New System.Drawing.Point(425, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(94, 50)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Image = CType(resources.GetObject("btn_add.Image"), System.Drawing.Image)
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.Location = New System.Drawing.Point(20, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(94, 50)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Add New"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(155, 3)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 50)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_close.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.Location = New System.Drawing.Point(694, 3)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(97, 50)
        Me.btn_close.TabIndex = 1
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_edit.Enabled = False
        Me.btn_edit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.Image = CType(resources.GetObject("btn_edit.Image"), System.Drawing.Image)
        Me.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_edit.Location = New System.Drawing.Point(560, 3)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(94, 50)
        Me.btn_edit.TabIndex = 4
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PCID
        '
        Me.PCID.HeaderText = "Category ID"
        Me.PCID.Name = "PCID"
        Me.PCID.ReadOnly = True
        Me.PCID.Visible = False
        '
        'PCName
        '
        Me.PCName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PCName.HeaderText = "Category Name"
        Me.PCName.Name = "PCName"
        Me.PCName.ReadOnly = True
        '
        'PCNameEnglish
        '
        Me.PCNameEnglish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PCNameEnglish.HeaderText = "Category Name 2"
        Me.PCNameEnglish.Name = "PCNameEnglish"
        Me.PCNameEnglish.ReadOnly = True
        '
        'Summary
        '
        Me.Summary.HeaderText = "Description"
        Me.Summary.Name = "Summary"
        Me.Summary.ReadOnly = True
        '
        'Active
        '
        Me.Active.HeaderText = "Activation"
        Me.Active.Name = "Active"
        Me.Active.ReadOnly = True
        '
        'Showin
        '
        Me.Showin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Showin.HeaderText = "Show interface"
        Me.Showin.Name = "Showin"
        Me.Showin.ReadOnly = True
        Me.Showin.ToolTipText = "Display in quick sale interface"
        Me.Showin.Width = 87
        '
        'FrmMainProductsCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 428)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.st_bar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMainProductsCategory"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales Categories"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcatname As TextBox
    Friend WithEvents txt_cat_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents st_bar As StatusStrip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_cat_english As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_summary As TextBox
    Friend WithEvents cshow As CheckBox
    Friend WithEvents cactive As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents PCID As DataGridViewTextBoxColumn
    Friend WithEvents PCName As DataGridViewTextBoxColumn
    Friend WithEvents PCNameEnglish As DataGridViewTextBoxColumn
    Friend WithEvents Summary As DataGridViewTextBoxColumn
    Friend WithEvents Active As DataGridViewCheckBoxColumn
    Friend WithEvents Showin As DataGridViewCheckBoxColumn
End Class
