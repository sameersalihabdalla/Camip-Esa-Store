<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCollectionCashier
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btn_cash = New System.Windows.Forms.Button()
        Me.lbl_cost = New System.Windows.Forms.Label()
        Me.lbl_invoice_id = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_details = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.الضريبة = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product, Me.cost, Me.quantity, Me.الضريبة, Me.Column1})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(403, 32)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 33
        Me.dgv.RowTemplate.Height = 40
        Me.dgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(802, 373)
        Me.dgv.TabIndex = 38
        '
        'btn_cash
        '
        Me.btn_cash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cash.BackColor = System.Drawing.Color.Green
        Me.btn_cash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cash.Enabled = False
        Me.btn_cash.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_cash.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cash.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btn_cash.ForeColor = System.Drawing.Color.White
        Me.btn_cash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cash.ImageKey = "(none)"
        Me.btn_cash.Location = New System.Drawing.Point(868, 410)
        Me.btn_cash.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_cash.Name = "btn_cash"
        Me.btn_cash.Padding = New System.Windows.Forms.Padding(1)
        Me.btn_cash.Size = New System.Drawing.Size(341, 75)
        Me.btn_cash.TabIndex = 40
        Me.btn_cash.Text = "Payment"
        Me.btn_cash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cash.UseVisualStyleBackColor = False
        '
        'lbl_cost
        '
        Me.lbl_cost.BackColor = System.Drawing.Color.Black
        Me.lbl_cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_cost.Font = New System.Drawing.Font("Arial", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_cost.ForeColor = System.Drawing.Color.White
        Me.lbl_cost.Location = New System.Drawing.Point(18, 411)
        Me.lbl_cost.Name = "lbl_cost"
        Me.lbl_cost.Size = New System.Drawing.Size(373, 75)
        Me.lbl_cost.TabIndex = 41
        Me.lbl_cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_invoice_id
        '
        Me.lbl_invoice_id.BackColor = System.Drawing.Color.Green
        Me.lbl_invoice_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_invoice_id.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_invoice_id.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_invoice_id.ForeColor = System.Drawing.Color.White
        Me.lbl_invoice_id.Location = New System.Drawing.Point(868, 411)
        Me.lbl_invoice_id.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lbl_invoice_id.Name = "lbl_invoice_id"
        Me.lbl_invoice_id.Size = New System.Drawing.Size(188, 35)
        Me.lbl_invoice_id.TabIndex = 42
        Me.lbl_invoice_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_username
        '
        Me.lbl_username.BackColor = System.Drawing.Color.Green
        Me.lbl_username.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_username.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_username.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.White
        Me.lbl_username.Location = New System.Drawing.Point(868, 458)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(185, 24)
        Me.lbl_username.TabIndex = 43
        Me.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_details)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 398)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaction details"
        '
        'dgv_details
        '
        Me.dgv_details.AllowUserToAddRows = False
        Me.dgv_details.AllowUserToDeleteRows = False
        Me.dgv_details.AllowUserToResizeColumns = False
        Me.dgv_details.AllowUserToResizeRows = False
        Me.dgv_details.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_details.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_details.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgv_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_details.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column2, Me.Column3, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_details.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgv_details.EnableHeadersVisualStyles = False
        Me.dgv_details.Location = New System.Drawing.Point(6, 20)
        Me.dgv_details.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_details.MultiSelect = False
        Me.dgv_details.Name = "dgv_details"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_details.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgv_details.RowHeadersVisible = False
        Me.dgv_details.RowHeadersWidth = 33
        Me.dgv_details.RowTemplate.Height = 40
        Me.dgv_details.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_details.Size = New System.Drawing.Size(373, 373)
        Me.dgv_details.TabIndex = 40
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.FillWeight = 140.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Unit price"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle16.NullValue = Nothing
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.DarkRed
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn2.FillWeight = 28.57905!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'product
        '
        Me.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.product.FillWeight = 140.0!
        Me.product.HeaderText = "Invoice number"
        Me.product.Name = "product"
        Me.product.ReadOnly = True
        '
        'cost
        '
        Me.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle11.NullValue = Nothing
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DarkRed
        Me.cost.DefaultCellStyle = DataGridViewCellStyle11
        Me.cost.FillWeight = 28.57905!
        Me.cost.HeaderText = "Cost"
        Me.cost.Name = "cost"
        Me.cost.ToolTipText = "يمكنك تعديل السعر مباشرة"
        Me.cost.Width = 70
        '
        'quantity
        '
        Me.quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.quantity.FillWeight = 5.647064!
        Me.quantity.HeaderText = "Transaction date"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        Me.quantity.Width = 140
        '
        'الضريبة
        '
        Me.الضريبة.FillWeight = 70.0!
        Me.الضريبة.HeaderText = "Username"
        Me.الضريبة.Name = "الضريبة"
        Me.الضريبة.ReadOnly = True
        Me.الضريبة.Width = 70
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(7)
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column1.FillWeight = 30.0!
        Me.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Column1.HeaderText = "Invoice details"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 128
        '
        'FrmCollectionCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.lbl_invoice_id)
        Me.Controls.Add(Me.lbl_cost)
        Me.Controls.Add(Me.btn_cash)
        Me.Controls.Add(Me.dgv)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCollectionCashier"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Collection"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_details, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btn_cash As Button
    Friend WithEvents lbl_cost As Label
    Friend WithEvents lbl_invoice_id As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_details As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents product As DataGridViewTextBoxColumn
    Friend WithEvents cost As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents الضريبة As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewButtonColumn
End Class
