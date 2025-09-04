<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMPOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMPOS))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_next_invoice = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_last = New System.Windows.Forms.Label()
        Me.total_cost = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.الضريبة = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.عمليات = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.total_quantaty = New System.Windows.Forms.TextBox()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnonaccount = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_applications = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.btn_cash = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtbarcode = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.last_invoice = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_last_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_t_count = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_total_costs = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.btn_pre = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_products_count = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_current_limit = New System.Windows.Forms.Label()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_next_invoice)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(403, 2)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(697, 600)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Direct Payment"
        '
        'lbl_next_invoice
        '
        Me.lbl_next_invoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_next_invoice.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_next_invoice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_next_invoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_next_invoice.Location = New System.Drawing.Point(358, 12)
        Me.lbl_next_invoice.Name = "lbl_next_invoice"
        Me.lbl_next_invoice.Size = New System.Drawing.Size(327, 22)
        Me.lbl_next_invoice.TabIndex = 3
        Me.lbl_next_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lbl_last)
        Me.GroupBox3.Controls.Add(Me.total_cost)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.total_quantaty)
        Me.GroupBox3.Controls.Add(Me.pb)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 136)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(681, 318)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sales List"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 26)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Last issued invoice"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_last
        '
        Me.lbl_last.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_last.BackColor = System.Drawing.Color.Transparent
        Me.lbl_last.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_last.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last.Location = New System.Drawing.Point(11, 253)
        Me.lbl_last.Name = "lbl_last"
        Me.lbl_last.Size = New System.Drawing.Size(214, 37)
        Me.lbl_last.TabIndex = 32
        Me.lbl_last.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'total_cost
        '
        Me.total_cost.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.total_cost.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.total_cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total_cost.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_cost.Location = New System.Drawing.Point(224, 255)
        Me.total_cost.Name = "total_cost"
        Me.total_cost.Padding = New System.Windows.Forms.Padding(5)
        Me.total_cost.Size = New System.Drawing.Size(300, 35)
        Me.total_cost.TabIndex = 11
        Me.total_cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(300, 26)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Total Cost"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(523, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 26)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Number of purchases"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle41
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product, Me.cost, Me.quantity, Me.الضريبة, Me.Column3, Me.Column2, Me.عمليات, Me.Column1})
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle44.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle44
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(11, 21)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle45.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle45.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle45
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 33
        Me.DataGridView1.RowTemplate.Height = 40
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(663, 206)
        Me.DataGridView1.TabIndex = 0
        '
        'product
        '
        Me.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.product.FillWeight = 140.0!
        Me.product.HeaderText = "Product"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        '
        'cost
        '
        Me.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle42.NullValue = Nothing
        DataGridViewCellStyle42.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.DarkRed
        Me.cost.DefaultCellStyle = DataGridViewCellStyle42
        Me.cost.FillWeight = 28.57905!
        Me.cost.HeaderText = "Price"
        Me.cost.Name = "cost"
        Me.cost.ToolTipText = "You can modify the price directly."
        Me.cost.Width = 66
        '
        'quantity
        '
        Me.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.quantity.FillWeight = 5.647064!
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 87
        '
        'الضريبة
        '
        Me.الضريبة.FillWeight = 70.0!
        Me.الضريبة.HeaderText = "Tax"
        Me.الضريبة.Name = "الضريبة"
        Me.الضريبة.ReadOnly = True
        Me.الضريبة.Width = 70
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Discount"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle43.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle43
        Me.Column2.HeaderText = "Total"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'عمليات
        '
        Me.عمليات.FillWeight = 30.0!
        Me.عمليات.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.عمليات.HeaderText = "+"
        Me.عمليات.Name = "عمليات"
        Me.عمليات.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.عمليات.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.عمليات.Width = 50
        '
        'Column1
        '
        Me.Column1.FillWeight = 30.0!
        Me.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column1.HeaderText = "-"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 50
        '
        'total_quantaty
        '
        Me.total_quantaty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.total_quantaty.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.total_quantaty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total_quantaty.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_quantaty.ForeColor = System.Drawing.Color.Black
        Me.total_quantaty.Location = New System.Drawing.Point(523, 255)
        Me.total_quantaty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.total_quantaty.Name = "total_quantaty"
        Me.total_quantaty.ReadOnly = True
        Me.total_quantaty.Size = New System.Drawing.Size(151, 21)
        Me.total_quantaty.TabIndex = 3
        Me.total_quantaty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pb
        '
        Me.pb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pb.Location = New System.Drawing.Point(11, 289)
        Me.pb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pb.Maximum = 10
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(215, 15)
        Me.pb.TabIndex = 31
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Button4)
        Me.GroupBox4.Controls.Add(Me.btnonaccount)
        Me.GroupBox4.Controls.Add(Me.Button6)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.btn_applications)
        Me.GroupBox4.Controls.Add(Me.Btnclear)
        Me.GroupBox4.Controls.Add(Me.Button14)
        Me.GroupBox4.Controls.Add(Me.btn_cash)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 444)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(681, 140)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.BorderSize = 3
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageKey = "icons8-cancel-48 (1).png"
        Me.Button4.Location = New System.Drawing.Point(382, 86)
        Me.Button4.Margin = New System.Windows.Forms.Padding(1)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(1)
        Me.Button4.Size = New System.Drawing.Size(101, 44)
        Me.Button4.TabIndex = 37
        Me.Button4.Tag = ""
        Me.Button4.Text = "Cancel"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icons8-shutdown-32.png")
        Me.ImageList1.Images.SetKeyName(1, "icons8-settings-32.png")
        Me.ImageList1.Images.SetKeyName(2, "icons8-login-32.png")
        Me.ImageList1.Images.SetKeyName(3, "icons8-pos-64.png")
        Me.ImageList1.Images.SetKeyName(4, "icons8-pos-70.png")
        Me.ImageList1.Images.SetKeyName(5, "icons8-taxi-mobile-payment-euro-32.png")
        Me.ImageList1.Images.SetKeyName(6, "icons8-credit-card-32.png")
        Me.ImageList1.Images.SetKeyName(7, "icons8-cash-32.png")
        Me.ImageList1.Images.SetKeyName(8, "icons8-print-32.png")
        Me.ImageList1.Images.SetKeyName(9, "icons8-cancel-32.png")
        Me.ImageList1.Images.SetKeyName(10, "icons8-delete-32.png")
        Me.ImageList1.Images.SetKeyName(11, "icons8-euro-money-32.png")
        Me.ImageList1.Images.SetKeyName(12, "icons8-euro-money-50.png")
        Me.ImageList1.Images.SetKeyName(13, "icons8-delete-50.png")
        Me.ImageList1.Images.SetKeyName(14, "icons8-cancel-48 (1).png")
        Me.ImageList1.Images.SetKeyName(15, "icons8-cancel-48.png")
        Me.ImageList1.Images.SetKeyName(16, "icons8-cancel.gif")
        Me.ImageList1.Images.SetKeyName(17, "icons8-customer-32.png")
        '
        'btnonaccount
        '
        Me.btnonaccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnonaccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnonaccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnonaccount.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnonaccount.FlatAppearance.BorderSize = 3
        Me.btnonaccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnonaccount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnonaccount.ForeColor = System.Drawing.Color.White
        Me.btnonaccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnonaccount.ImageIndex = 17
        Me.btnonaccount.Location = New System.Drawing.Point(14, 17)
        Me.btnonaccount.Margin = New System.Windows.Forms.Padding(1)
        Me.btnonaccount.Name = "btnonaccount"
        Me.btnonaccount.Padding = New System.Windows.Forms.Padding(1)
        Me.btnonaccount.Size = New System.Drawing.Size(133, 67)
        Me.btnonaccount.TabIndex = 36
        Me.btnonaccount.Text = "Customer's Account"
        Me.btnonaccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnonaccount.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button6.FlatAppearance.BorderSize = 3
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.ImageKey = "(none)"
        Me.Button6.Location = New System.Drawing.Point(149, 17)
        Me.Button6.Margin = New System.Windows.Forms.Padding(1)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(1)
        Me.Button6.Size = New System.Drawing.Size(122, 67)
        Me.Button6.TabIndex = 35
        Me.Button6.Text = "Central Collection"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 3
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageKey = "icons8-mobile-payment-100.png"
        Me.Button3.Location = New System.Drawing.Point(273, 90)
        Me.Button3.Margin = New System.Windows.Forms.Padding(1)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(1)
        Me.Button3.Size = New System.Drawing.Size(104, 40)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "شيك"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 3
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageKey = "(none)"
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(560, 18)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(1)
        Me.Button2.Size = New System.Drawing.Size(114, 66)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Credit Card"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_applications
        '
        Me.btn_applications.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_applications.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_applications.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_applications.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_applications.FlatAppearance.BorderSize = 3
        Me.btn_applications.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_applications.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_applications.ForeColor = System.Drawing.Color.White
        Me.btn_applications.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_applications.ImageKey = "icons8-mobile-payment-100.png"
        Me.btn_applications.Location = New System.Drawing.Point(273, 17)
        Me.btn_applications.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_applications.Name = "btn_applications"
        Me.btn_applications.Padding = New System.Windows.Forms.Padding(1)
        Me.btn_applications.Size = New System.Drawing.Size(107, 67)
        Me.btn_applications.TabIndex = 31
        Me.btn_applications.Text = "Payment APPs"
        Me.btn_applications.UseVisualStyleBackColor = False
        '
        'Btnclear
        '
        Me.Btnclear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnclear.BackColor = System.Drawing.Color.White
        Me.Btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btnclear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btnclear.FlatAppearance.BorderSize = 3
        Me.Btnclear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Btnclear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.ForeColor = System.Drawing.Color.Black
        Me.Btnclear.Image = CType(resources.GetObject("Btnclear.Image"), System.Drawing.Image)
        Me.Btnclear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnclear.Location = New System.Drawing.Point(560, 86)
        Me.Btnclear.Margin = New System.Windows.Forms.Padding(1)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Padding = New System.Windows.Forms.Padding(1, 10, 1, 5)
        Me.Btnclear.Size = New System.Drawing.Size(114, 44)
        Me.Btnclear.TabIndex = 25
        Me.Btnclear.Text = "Delete"
        Me.Btnclear.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button14.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button14.FlatAppearance.BorderSize = 3
        Me.Button14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.Color.Black
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.ImageKey = "icons8-print-32.png"
        Me.Button14.Location = New System.Drawing.Point(485, 86)
        Me.Button14.Margin = New System.Windows.Forms.Padding(1)
        Me.Button14.Name = "Button14"
        Me.Button14.Padding = New System.Windows.Forms.Padding(1, 10, 1, 5)
        Me.Button14.Size = New System.Drawing.Size(73, 44)
        Me.Button14.TabIndex = 24
        Me.Button14.Tag = "طباعة آخر فاتورة"
        Me.Button14.Text = "Print"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'btn_cash
        '
        Me.btn_cash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cash.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_cash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cash.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cash.FlatAppearance.BorderSize = 3
        Me.btn_cash.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cash.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cash.ForeColor = System.Drawing.Color.Black
        Me.btn_cash.Image = Global.ExtraPOS.My.Resources.Resources.Annotate_Default1
        Me.btn_cash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cash.ImageKey = "(none)"
        Me.btn_cash.Location = New System.Drawing.Point(382, 18)
        Me.btn_cash.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_cash.Name = "btn_cash"
        Me.btn_cash.Padding = New System.Windows.Forms.Padding(1)
        Me.btn_cash.Size = New System.Drawing.Size(176, 66)
        Me.btn_cash.TabIndex = 19
        Me.btn_cash.Text = "Direct cash payment"
        Me.btn_cash.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cash.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(11, 28)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(674, 103)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage1.Controls.Add(Me.txtbarcode)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(666, 77)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Barcode                      "
        '
        'txtbarcode
        '
        Me.txtbarcode.BackColor = System.Drawing.Color.White
        Me.txtbarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbarcode.ForeColor = System.Drawing.Color.Black
        Me.txtbarcode.Location = New System.Drawing.Point(6, 24)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(649, 29)
        Me.txtbarcode.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(666, 77)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Product Name"
        '
        'TextBox1
        '
        Me.TextBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox1.FormattingEnabled = True
        Me.TextBox1.Location = New System.Drawing.Point(6, 5)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(654, 30)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(667, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "اسم المنتج / الباركود"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 52)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(387, 550)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Popular Products"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.last_invoice, Me.ToolStripStatusLabel3, Me.lbl_last_date, Me.ToolStripStatusLabel5, Me.lbl_t_count, Me.ToolStripStatusLabel2, Me.lbl_total_costs, Me.ToolStripStatusLabel8, Me.lbl_time})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 615)
        Me.StatusStrip1.Margin = New System.Windows.Forms.Padding(5)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(12, 0, 1, 0)
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1111, 32)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(126, 27)
        Me.ToolStripStatusLabel1.Text = "Last transaction id"
        '
        'last_invoice
        '
        Me.last_invoice.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.last_invoice.Name = "last_invoice"
        Me.last_invoice.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.last_invoice.Size = New System.Drawing.Size(31, 27)
        Me.last_invoice.Text = "-"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel3.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Padding = New System.Windows.Forms.Padding(5)
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(142, 27)
        Me.ToolStripStatusLabel3.Text = "Last transaction date"
        '
        'lbl_last_date
        '
        Me.lbl_last_date.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last_date.Name = "lbl_last_date"
        Me.lbl_last_date.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lbl_last_date.Size = New System.Drawing.Size(31, 27)
        Me.lbl_last_date.Text = "-"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel5.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Padding = New System.Windows.Forms.Padding(5)
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(130, 27)
        Me.ToolStripStatusLabel5.Text = "Transactions today"
        '
        'lbl_t_count
        '
        Me.lbl_t_count.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_t_count.Name = "lbl_t_count"
        Me.lbl_t_count.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lbl_t_count.Size = New System.Drawing.Size(31, 27)
        Me.lbl_t_count.Text = "-"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Padding = New System.Windows.Forms.Padding(5)
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(88, 27)
        Me.ToolStripStatusLabel2.Text = "Total Today"
        '
        'lbl_total_costs
        '
        Me.lbl_total_costs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_costs.Name = "lbl_total_costs"
        Me.lbl_total_costs.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lbl_total_costs.Size = New System.Drawing.Size(31, 27)
        Me.lbl_total_costs.Text = "-"
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripStatusLabel8.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(65, 27)
        Me.ToolStripStatusLabel8.Text = "Time Now"
        '
        'lbl_time
        '
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lbl_time.Size = New System.Drawing.Size(32, 27)
        Me.lbl_time.Text = "-"
        '
        'Timer
        '
        '
        'btn_pre
        '
        Me.btn_pre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_pre.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pre.Location = New System.Drawing.Point(257, 5)
        Me.btn_pre.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_pre.Name = "btn_pre"
        Me.btn_pre.Padding = New System.Windows.Forms.Padding(1)
        Me.btn_pre.Size = New System.Drawing.Size(55, 35)
        Me.btn_pre.TabIndex = 0
        Me.btn_pre.Text = ">"
        Me.btn_pre.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_next.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(57, 5)
        Me.btn_next.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Padding = New System.Windows.Forms.Padding(1)
        Me.btn_next.Size = New System.Drawing.Size(45, 35)
        Me.btn_next.TabIndex = 4
        Me.btn_next.Text = "<"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(1)
        Me.Label2.Size = New System.Drawing.Size(34, 35)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "/"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.txt_products_count, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_next, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_pre, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_current_limit, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(315, 45)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txt_products_count
        '
        Me.txt_products_count.BackColor = System.Drawing.Color.Transparent
        Me.txt_products_count.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_products_count.Location = New System.Drawing.Point(106, 5)
        Me.txt_products_count.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_products_count.Name = "txt_products_count"
        Me.txt_products_count.Padding = New System.Windows.Forms.Padding(1)
        Me.txt_products_count.Size = New System.Drawing.Size(72, 29)
        Me.txt_products_count.TabIndex = 0
        Me.txt_products_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageKey = "icons8-settings-32.png"
        Me.Button5.ImageList = Me.ImageList1
        Me.Button5.Location = New System.Drawing.Point(5, 5)
        Me.Button5.Margin = New System.Windows.Forms.Padding(1)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(3)
        Me.Button5.Size = New System.Drawing.Size(48, 35)
        Me.Button5.TabIndex = 8
        Me.Button5.Tag = "Customize colors"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_current_limit
        '
        Me.txt_current_limit.BackColor = System.Drawing.Color.Transparent
        Me.txt_current_limit.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_current_limit.Location = New System.Drawing.Point(220, 5)
        Me.txt_current_limit.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_current_limit.Name = "txt_current_limit"
        Me.txt_current_limit.Padding = New System.Windows.Forms.Padding(1)
        Me.txt_current_limit.Size = New System.Drawing.Size(33, 29)
        Me.txt_current_limit.TabIndex = 0
        Me.txt_current_limit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'FRMPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 647)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FRMPOS"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_cash As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents btnpoint As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents total_quantaty As TextBox
    Friend WithEvents lbl_next_invoice As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents last_invoice As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents lbl_last_date As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents lbl_t_count As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents lbl_total_costs As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As ToolStripStatusLabel
    Friend WithEvents lbl_time As ToolStripStatusLabel
    Friend WithEvents Timer As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents total_cost As Label
    Friend WithEvents btn_pre As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents txt_products_count As Label
    Friend WithEvents txt_current_limit As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbarcode As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_applications As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_last As Label
    Friend WithEvents pb As ProgressBar
    Friend WithEvents Button3 As Button
    Friend WithEvents btnonaccount As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents cost As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents الضريبة As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents عمليات As DataGridViewButtonColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
End Class
