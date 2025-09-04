<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStockQuantaties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStockQuantaties))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Gbx1 = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.gbx2 = New System.Windows.Forms.GroupBox()
        Me.stock_id = New System.Windows.Forms.Label()
        Me.TxtQuantary = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TLB = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.st_bar = New System.Windows.Forms.StatusStrip()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmbProducts = New System.Windows.Forms.ComboBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gbx1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx2.SuspendLayout()
        Me.TLB.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "printer.ico")
        Me.ImageList1.Images.SetKeyName(1, "008_Reminder.ico")
        Me.ImageList1.Images.SetKeyName(2, "112_ArrowReturnLeft_Blue.ico")
        Me.ImageList1.Images.SetKeyName(3, "112_ArrowReturnRight_Blue.ico")
        Me.ImageList1.Images.SetKeyName(4, "112_LeftArrowShort_Blue.ico")
        Me.ImageList1.Images.SetKeyName(5, "112_LeftArrowShort_Green.ico")
        Me.ImageList1.Images.SetKeyName(6, "174_magnify_uncompressed.ico")
        Me.ImageList1.Images.SetKeyName(7, "1507_ParallelPort.ico")
        Me.ImageList1.Images.SetKeyName(8, "Annotate_Default.ico")
        Me.ImageList1.Images.SetKeyName(9, "Annotate_Error.ico")
        Me.ImageList1.Images.SetKeyName(10, "Saki-Snowish-Actions-edit-clear.ico")
        Me.ImageList1.Images.SetKeyName(11, "Icons8-Ios7-Ecommerce-Clear-Shopping-Cart.ico")
        Me.ImageList1.Images.SetKeyName(12, "Icons8-Ios7-Finance-Pos-Terminal.ico")
        Me.ImageList1.Images.SetKeyName(13, "Icons8-Ios7-Ecommerce-Barcode-Scanner.ico")
        Me.ImageList1.Images.SetKeyName(14, "112_Plus_Green.ico")
        Me.ImageList1.Images.SetKeyName(15, "delete.png")
        Me.ImageList1.Images.SetKeyName(16, "delete1.png")
        Me.ImageList1.Images.SetKeyName(17, "edit.png")
        Me.ImageList1.Images.SetKeyName(18, "login.png")
        Me.ImageList1.Images.SetKeyName(19, "logout.png")
        '
        'Gbx1
        '
        Me.Gbx1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx1.Controls.Add(Me.dgv)
        Me.Gbx1.Controls.Add(Me.gbx2)
        Me.Gbx1.Controls.Add(Me.TLB)
        Me.Gbx1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Gbx1.Location = New System.Drawing.Point(20, 111)
        Me.Gbx1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Gbx1.Name = "Gbx1"
        Me.Gbx1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Gbx1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Gbx1.Size = New System.Drawing.Size(1015, 369)
        Me.Gbx1.TabIndex = 21
        Me.Gbx1.TabStop = False
        Me.Gbx1.Text = "Inventory"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.PCID, Me.PCName, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column8, Me.Column6, Me.Column7})
        Me.dgv.Enabled = False
        Me.dgv.Location = New System.Drawing.Point(7, 29)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1001, 207)
        Me.dgv.TabIndex = 27
        '
        'gbx2
        '
        Me.gbx2.BackColor = System.Drawing.SystemColors.Control
        Me.gbx2.Controls.Add(Me.stock_id)
        Me.gbx2.Controls.Add(Me.TxtQuantary)
        Me.gbx2.Controls.Add(Me.Label1)
        Me.gbx2.Enabled = False
        Me.gbx2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbx2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.gbx2.Location = New System.Drawing.Point(8, 243)
        Me.gbx2.Margin = New System.Windows.Forms.Padding(2)
        Me.gbx2.Name = "gbx2"
        Me.gbx2.Padding = New System.Windows.Forms.Padding(2)
        Me.gbx2.Size = New System.Drawing.Size(404, 45)
        Me.gbx2.TabIndex = 26
        Me.gbx2.TabStop = False
        '
        'stock_id
        '
        Me.stock_id.BackColor = System.Drawing.Color.White
        Me.stock_id.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.stock_id.Location = New System.Drawing.Point(6, 17)
        Me.stock_id.Name = "stock_id"
        Me.stock_id.Size = New System.Drawing.Size(88, 25)
        Me.stock_id.TabIndex = 17
        '
        'TxtQuantary
        '
        Me.TxtQuantary.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TxtQuantary.Location = New System.Drawing.Point(100, 16)
        Me.TxtQuantary.Name = "TxtQuantary"
        Me.TxtQuantary.Size = New System.Drawing.Size(169, 26)
        Me.TxtQuantary.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 22)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Quantity"
        '
        'TLB
        '
        Me.TLB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLB.BackColor = System.Drawing.SystemColors.Control
        Me.TLB.ColumnCount = 5
        Me.TLB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.95092!))
        Me.TLB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17791!))
        Me.TLB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TLB.Controls.Add(Me.btn_cancel, 0, 0)
        Me.TLB.Controls.Add(Me.btn_delete, 0, 0)
        Me.TLB.Controls.Add(Me.btn_add, 0, 0)
        Me.TLB.Controls.Add(Me.btn_save, 0, 0)
        Me.TLB.Controls.Add(Me.btn_close, 4, 0)
        Me.TLB.Enabled = False
        Me.TLB.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TLB.Location = New System.Drawing.Point(75, 295)
        Me.TLB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TLB.Name = "TLB"
        Me.TLB.RowCount = 1
        Me.TLB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLB.Size = New System.Drawing.Size(865, 64)
        Me.TLB.TabIndex = 25
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_cancel.Image = CType(resources.GetObject("btn_cancel.Image"), System.Drawing.Image)
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.Location = New System.Drawing.Point(371, 5)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(116, 54)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.Enabled = False
        Me.btn_delete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_delete.ImageKey = "delete.png"
        Me.btn_delete.ImageList = Me.ImageList1
        Me.btn_delete.Location = New System.Drawing.Point(547, 5)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(110, 54)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_add
        '
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_add.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_add.ImageKey = "login.png"
        Me.btn_add.ImageList = Me.ImageList1
        Me.btn_add.Location = New System.Drawing.Point(27, 5)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(110, 54)
        Me.btn_add.TabIndex = 14
        Me.btn_add.Text = "Add New"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(179, 5)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(149, 54)
        Me.btn_save.TabIndex = 15
        Me.btn_save.Text = "Save"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_close.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_close.ImageKey = "logout.png"
        Me.btn_close.ImageList = Me.ImageList1
        Me.btn_close.Location = New System.Drawing.Point(719, 5)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(116, 54)
        Me.btn_close.TabIndex = 19
        Me.btn_close.Text = "Close"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'st_bar
        '
        Me.st_bar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.st_bar.Location = New System.Drawing.Point(0, 492)
        Me.st_bar.Name = "st_bar"
        Me.st_bar.Padding = New System.Windows.Forms.Padding(19, 0, 1, 0)
        Me.st_bar.Size = New System.Drawing.Size(1057, 22)
        Me.st_bar.TabIndex = 20
        Me.st_bar.Text = "StatusStrip1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.btnUnlock)
        Me.GroupBox2.Controls.Add(Me.btnLock)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CmbProducts)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 24)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(1015, 68)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Products"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(573, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(434, 21)
        Me.TextBox1.TabIndex = 33
        '
        'btnUnlock
        '
        Me.btnUnlock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnUnlock.Image = Global.ExtraPOS.My.Resources.Resources.delete1
        Me.btnUnlock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUnlock.Location = New System.Drawing.Point(8, 22)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(110, 34)
        Me.btnUnlock.TabIndex = 2
        Me.btnUnlock.Text = "Deselect"
        Me.btnUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnlock.UseVisualStyleBackColor = True
        '
        'btnLock
        '
        Me.btnLock.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnLock.Image = CType(resources.GetObject("btnLock.Image"), System.Drawing.Image)
        Me.btnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLock.Location = New System.Drawing.Point(124, 22)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(94, 34)
        Me.btnLock.TabIndex = 3
        Me.btnLock.Text = "Select"
        Me.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(224, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Product Name"
        '
        'CmbProducts
        '
        Me.CmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProducts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.CmbProducts.FormattingEnabled = True
        Me.CmbProducts.Location = New System.Drawing.Point(316, 30)
        Me.CmbProducts.Name = "CmbProducts"
        Me.CmbProducts.Size = New System.Drawing.Size(251, 21)
        Me.CmbProducts.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.FillWeight = 140.0!
        Me.Column1.HeaderText = "QTY ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'PCID
        '
        Me.PCID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PCID.HeaderText = "Product ID"
        Me.PCID.Name = "PCID"
        Me.PCID.ReadOnly = True
        '
        'PCName
        '
        Me.PCName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PCName.HeaderText = "Product"
        Me.PCName.Name = "PCName"
        Me.PCName.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cat ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Category"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Date added"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Add time"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "User ID"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "User"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'FrmStockQuantaties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 514)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gbx1)
        Me.Controls.Add(Me.st_bar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStockQuantaties"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Quantities - SK"
        Me.Gbx1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx2.ResumeLayout(False)
        Me.gbx2.PerformLayout()
        Me.TLB.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Gbx1 As GroupBox
    Friend WithEvents st_bar As StatusStrip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUnlock As Button
    Friend WithEvents btnLock As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents CmbProducts As ComboBox
    Friend WithEvents gbx2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TLB As TableLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents TxtQuantary As TextBox
    Friend WithEvents stock_id As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents PCID As DataGridViewTextBoxColumn
    Friend WithEvents PCName As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
