<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducts))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Gbx1 = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RSBName = New System.Windows.Forms.RadioButton()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.st_bar = New System.Windows.Forms.StatusStrip()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Gbx2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBuyPrice = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_Barcode = New System.Windows.Forms.TextBox()
        Me.txt_tax = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_units = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_disc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_pack_price = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cshow = New System.Windows.Forms.CheckBox()
        Me.cactive = New System.Windows.Forms.CheckBox()
        Me.txt_summary = New System.Windows.Forms.TextBox()
        Me.txt_cat_english = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcatname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cat_id = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbMainCat = New System.Windows.Forms.ComboBox()
        Me.PCID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCNameEnglish = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.parts = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Summary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainProductsCatID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainProductsCatName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Showin = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gbx1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Gbx2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx1
        '
        resources.ApplyResources(Me.Gbx1, "Gbx1")
        Me.Gbx1.Controls.Add(Me.StatusStrip1)
        Me.Gbx1.Controls.Add(Me.DataGridView1)
        Me.Gbx1.Controls.Add(Me.RSBName)
        Me.Gbx1.Controls.Add(Me.TextBox5)
        Me.Gbx1.Name = "Gbx1"
        Me.Gbx1.TabStop = False
        '
        'StatusStrip1
        '
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PCID, Me.PCName, Me.PCNameEnglish, Me.parts, Me.price, Me.unitprice, Me.Summary, Me.mainProductsCatID, Me.mainProductsCatName, Me.discount, Me.Active, Me.Showin, Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'RSBName
        '
        resources.ApplyResources(Me.RSBName, "RSBName")
        Me.RSBName.Checked = True
        Me.RSBName.Name = "RSBName"
        Me.RSBName.TabStop = True
        Me.RSBName.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        resources.ApplyResources(Me.TextBox5, "TextBox5")
        Me.TextBox5.Name = "TextBox5"
        '
        'st_bar
        '
        resources.ApplyResources(Me.st_bar, "st_bar")
        Me.st_bar.Name = "st_bar"
        '
        'GroupBox2
        '
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.txt_id)
        Me.GroupBox2.Controls.Add(Me.Gbx2)
        Me.GroupBox2.Controls.Add(Me.btnUnlock)
        Me.GroupBox2.Controls.Add(Me.btnLock)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmbMainCat)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'txt_id
        '
        resources.ApplyResources(Me.txt_id, "txt_id")
        Me.txt_id.BackColor = System.Drawing.Color.Yellow
        Me.txt_id.Name = "txt_id"
        '
        'Gbx2
        '
        resources.ApplyResources(Me.Gbx2, "Gbx2")
        Me.Gbx2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Gbx2.Controls.Add(Me.TableLayoutPanel1)
        Me.Gbx2.Controls.Add(Me.Label11)
        Me.Gbx2.Controls.Add(Me.TxtBuyPrice)
        Me.Gbx2.Controls.Add(Me.Label10)
        Me.Gbx2.Controls.Add(Me.Txt_Barcode)
        Me.Gbx2.Controls.Add(Me.txt_tax)
        Me.Gbx2.Controls.Add(Me.Label9)
        Me.Gbx2.Controls.Add(Me.txt_units)
        Me.Gbx2.Controls.Add(Me.Label7)
        Me.Gbx2.Controls.Add(Me.txt_price)
        Me.Gbx2.Controls.Add(Me.txt_disc)
        Me.Gbx2.Controls.Add(Me.Label6)
        Me.Gbx2.Controls.Add(Me.Label5)
        Me.Gbx2.Controls.Add(Me.txt_pack_price)
        Me.Gbx2.Controls.Add(Me.Label4)
        Me.Gbx2.Controls.Add(Me.cshow)
        Me.Gbx2.Controls.Add(Me.cactive)
        Me.Gbx2.Controls.Add(Me.txt_summary)
        Me.Gbx2.Controls.Add(Me.txt_cat_english)
        Me.Gbx2.Controls.Add(Me.Label2)
        Me.Gbx2.Controls.Add(Me.txtcatname)
        Me.Gbx2.Controls.Add(Me.Label1)
        Me.Gbx2.Controls.Add(Me.Label3)
        Me.Gbx2.Controls.Add(Me.txt_cat_id)
        Me.Gbx2.Controls.Add(Me.Label12)
        Me.Gbx2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Gbx2.Name = "Gbx2"
        Me.Gbx2.TabStop = False
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cancel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delete, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_add, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_close, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_edit, 4, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'btn_cancel
        '
        resources.ApplyResources(Me.btn_cancel, "btn_cancel")
        Me.btn_cancel.Name = "btn_cancel"
        '
        'btn_delete
        '
        resources.ApplyResources(Me.btn_delete, "btn_delete")
        Me.btn_delete.ImageList = Me.ImageList1
        Me.btn_delete.Name = "btn_delete"
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
        'btn_add
        '
        resources.ApplyResources(Me.btn_add, "btn_add")
        Me.btn_add.ImageList = Me.ImageList1
        Me.btn_add.Name = "btn_add"
        '
        'btn_save
        '
        resources.ApplyResources(Me.btn_save, "btn_save")
        Me.btn_save.Name = "btn_save"
        '
        'btn_close
        '
        resources.ApplyResources(Me.btn_close, "btn_close")
        Me.btn_close.ImageList = Me.ImageList1
        Me.btn_close.Name = "btn_close"
        '
        'btn_edit
        '
        resources.ApplyResources(Me.btn_edit, "btn_edit")
        Me.btn_edit.Name = "btn_edit"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Name = "Label11"
        '
        'TxtBuyPrice
        '
        resources.ApplyResources(Me.TxtBuyPrice, "TxtBuyPrice")
        Me.TxtBuyPrice.Name = "TxtBuyPrice"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Name = "Label10"
        '
        'Txt_Barcode
        '
        resources.ApplyResources(Me.Txt_Barcode, "Txt_Barcode")
        Me.Txt_Barcode.Name = "Txt_Barcode"
        '
        'txt_tax
        '
        resources.ApplyResources(Me.txt_tax, "txt_tax")
        Me.txt_tax.Name = "txt_tax"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Name = "Label9"
        '
        'txt_units
        '
        resources.ApplyResources(Me.txt_units, "txt_units")
        Me.txt_units.Name = "txt_units"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Name = "Label7"
        '
        'txt_price
        '
        resources.ApplyResources(Me.txt_price, "txt_price")
        Me.txt_price.Name = "txt_price"
        '
        'txt_disc
        '
        resources.ApplyResources(Me.txt_disc, "txt_disc")
        Me.txt_disc.Name = "txt_disc"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Name = "Label5"
        '
        'txt_pack_price
        '
        resources.ApplyResources(Me.txt_pack_price, "txt_pack_price")
        Me.txt_pack_price.Name = "txt_pack_price"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Name = "Label4"
        '
        'cshow
        '
        resources.ApplyResources(Me.cshow, "cshow")
        Me.cshow.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cshow.Name = "cshow"
        Me.cshow.UseVisualStyleBackColor = False
        '
        'cactive
        '
        resources.ApplyResources(Me.cactive, "cactive")
        Me.cactive.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cactive.Name = "cactive"
        Me.cactive.UseVisualStyleBackColor = False
        '
        'txt_summary
        '
        resources.ApplyResources(Me.txt_summary, "txt_summary")
        Me.txt_summary.Name = "txt_summary"
        '
        'txt_cat_english
        '
        resources.ApplyResources(Me.txt_cat_english, "txt_cat_english")
        Me.txt_cat_english.Name = "txt_cat_english"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Name = "Label2"
        '
        'txtcatname
        '
        resources.ApplyResources(Me.txtcatname, "txtcatname")
        Me.txtcatname.Name = "txtcatname"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Name = "Label1"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Name = "Label3"
        '
        'txt_cat_id
        '
        Me.txt_cat_id.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        resources.ApplyResources(Me.txt_cat_id, "txt_cat_id")
        Me.txt_cat_id.Name = "txt_cat_id"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'btnUnlock
        '
        resources.ApplyResources(Me.btnUnlock, "btnUnlock")
        Me.btnUnlock.Image = Global.ExtraPOS.My.Resources.Resources.delete1
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.UseVisualStyleBackColor = True
        '
        'btnLock
        '
        resources.ApplyResources(Me.btnLock, "btnLock")
        Me.btnLock.Name = "btnLock"
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Name = "Label8"
        '
        'cmbMainCat
        '
        resources.ApplyResources(Me.cmbMainCat, "cmbMainCat")
        Me.cmbMainCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMainCat.FormattingEnabled = True
        Me.cmbMainCat.Name = "cmbMainCat"
        '
        'PCID
        '
        Me.PCID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.PCID, "PCID")
        Me.PCID.Name = "PCID"
        Me.PCID.ReadOnly = True
        '
        'PCName
        '
        Me.PCName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.PCName, "PCName")
        Me.PCName.Name = "PCName"
        Me.PCName.ReadOnly = True
        '
        'PCNameEnglish
        '
        Me.PCNameEnglish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.PCNameEnglish, "PCNameEnglish")
        Me.PCNameEnglish.Name = "PCNameEnglish"
        Me.PCNameEnglish.ReadOnly = True
        '
        'parts
        '
        Me.parts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.parts, "parts")
        Me.parts.Name = "parts"
        Me.parts.ReadOnly = True
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.price, "price")
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'unitprice
        '
        Me.unitprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        resources.ApplyResources(Me.unitprice, "unitprice")
        Me.unitprice.Name = "unitprice"
        Me.unitprice.ReadOnly = True
        '
        'Summary
        '
        resources.ApplyResources(Me.Summary, "Summary")
        Me.Summary.Name = "Summary"
        Me.Summary.ReadOnly = True
        '
        'mainProductsCatID
        '
        resources.ApplyResources(Me.mainProductsCatID, "mainProductsCatID")
        Me.mainProductsCatID.Name = "mainProductsCatID"
        Me.mainProductsCatID.ReadOnly = True
        '
        'mainProductsCatName
        '
        resources.ApplyResources(Me.mainProductsCatName, "mainProductsCatName")
        Me.mainProductsCatName.Name = "mainProductsCatName"
        Me.mainProductsCatName.ReadOnly = True
        '
        'discount
        '
        resources.ApplyResources(Me.discount, "discount")
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        '
        'Active
        '
        resources.ApplyResources(Me.Active, "Active")
        Me.Active.Name = "Active"
        Me.Active.ReadOnly = True
        '
        'Showin
        '
        Me.Showin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        resources.ApplyResources(Me.Showin, "Showin")
        Me.Showin.Name = "Showin"
        Me.Showin.ReadOnly = True
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'FrmProducts
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.st_bar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gbx1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProducts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Gbx1.ResumeLayout(False)
        Me.Gbx1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Gbx2.ResumeLayout(False)
        Me.Gbx2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gbx1 As GroupBox
    Friend WithEvents st_bar As StatusStrip
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RSBName As RadioButton
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnUnlock As Button
    Friend WithEvents btnLock As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbMainCat As ComboBox
    Friend WithEvents Gbx2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_disc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_pack_price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cshow As CheckBox
    Friend WithEvents cactive As CheckBox
    Friend WithEvents txt_summary As TextBox
    Friend WithEvents txt_cat_english As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcatname As TextBox
    Friend WithEvents txt_cat_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_id As TextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txt_units As TextBox
    Friend WithEvents txt_tax As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_Barcode As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtBuyPrice As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents PCID As DataGridViewTextBoxColumn
    Friend WithEvents PCName As DataGridViewTextBoxColumn
    Friend WithEvents PCNameEnglish As DataGridViewTextBoxColumn
    Friend WithEvents parts As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents unitprice As DataGridViewTextBoxColumn
    Friend WithEvents Summary As DataGridViewTextBoxColumn
    Friend WithEvents mainProductsCatID As DataGridViewTextBoxColumn
    Friend WithEvents mainProductsCatName As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents Active As DataGridViewCheckBoxColumn
    Friend WithEvents Showin As DataGridViewCheckBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
