Imports MySql.Data.MySqlClient

Public Class FRMPOS
    Dim lastcellrow As Integer




    Private Sub getbuttonslist(ByVal x As Integer, ByVal y As Integer)
        GroupBox2.Controls.Clear()
        Dim wid As Integer
        wid = (GroupBox2.Width / 8) - 5
        Dim intleft As Integer = 5
        Dim inttop As Integer = 25
        Dim intwidth As Integer = wid
        Dim intheight As Integer = 90
        Dim myCommand As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim SQL As String
        SQL = "SELECT  `pnamearabic`, `pid`, `mainProductsCatName`, `unitprice` FROM tbl_products where PCShow='true' and PCActive='true'  order by mainProductsCatID LIMIT " & x & "," & y & " ; "
        myCommand.Connection = myconn()
        myCommand.CommandText = SQL
        myAdapter.SelectCommand = myCommand
        myAdapter.Fill(myData)
        Dim xcolor As Color = My.Settings.color1

        Dim i As Integer = 0

        For Each drRow As DataRow In myData.Rows

            If intleft >= Me.GroupBox2.Width - intwidth Then
                intleft = 5
                inttop += 95
            End If
            i = Val(drRow.Item("Pid"))
            Dim btn As New System.Windows.Forms.Button
            Dim lbl As New System.Windows.Forms.LinkLabel
            Dim lbl2 As New System.Windows.Forms.LinkLabel

            lbl.LinkColor = Color.Black

            lbl2.LinkColor = Color.Blue


            TextBox1.Items.Add(drRow.Item("Pnamearabic"))
            btn.Text = vbNewLine & Format(drRow.Item("unitprice"), "###,##.00") & " " & currency_char_ar
            btn.Tag = drRow.Item("pid").ToString
            lbl.Left = intleft + 2
            lbl2.Left = intleft + 2

            btn.Left = intleft

            btn.Cursor = Cursors.Hand


            lbl.Top = inttop + 3
            lbl2.Top = inttop + 30

            lbl.Visible = True
            lbl.AutoSize = False
            lbl2.Visible = True
            lbl2.AutoSize = False
            lbl.Cursor = Cursors.Hand
            lbl2.Cursor = Cursors.Hand

            lbl2.Width = intwidth - 4
            lbl.Width = intwidth - 4
            lbl.Height = intheight / 3
            lbl2.Height = intheight / 3

            btn.Top = inttop
            lbl.Text = drRow.Item("Pnamearabic")
            lbl2.Text = drRow.Item("mainProductsCatName")
            lbl.FlatStyle = FlatStyle.Popup
            lbl2.FlatStyle = FlatStyle.Popup

            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.FlatStyle = FlatStyle.Popup
            btn.Width = intwidth
            btn.Height = intheight
            btn.Visible = True
            If xcolor = My.Settings.color1 Then
                xcolor = My.Settings.color2
            ElseIf xcolor = My.Settings.color2 Then
                xcolor = My.Settings.color3
            ElseIf xcolor = My.Settings.color3 Then
                xcolor = My.Settings.color4
            ElseIf xcolor = My.Settings.color4 Then
                xcolor = My.Settings.color5
            ElseIf xcolor = My.Settings.color5 Then
                xcolor = My.Settings.color6
            ElseIf xcolor = My.Settings.color6 Then
                xcolor = My.Settings.color1
            End If
            btn.BackColor = xcolor
            lbl.BackColor = xcolor
            lbl2.BackColor = xcolor
            'lbl.BackColor = Color.FromArgb(192, 192, 255)
            lbl.Tag = drRow.Item("pid").ToString
            lbl2.Tag = drRow.Item("pid").ToString
            btn.TextAlign = ContentAlignment.BottomLeft
            lbl.TextAlign = ContentAlignment.MiddleLeft
            lbl2.TextAlign = ContentAlignment.MiddleLeft




            Me.GroupBox2.Controls.Add(lbl)
            Me.GroupBox2.Controls.Add(lbl2)
            Me.GroupBox2.Controls.Add(btn)



            intleft += intwidth + 5
            AddHandler btn.Click, New EventHandler(AddressOf button_click)
            AddHandler lbl.Click, New EventHandler(AddressOf lbl_click)
            AddHandler lbl2.Click, New EventHandler(AddressOf lbl_click)

        Next
    End Sub


    Private Sub buttons(sender As Object, e As EventArgs)
        If total_cost.Text = "" Then
            total_cost.Text = sender.text
        Else total_cost.Text = total_cost.Text & sender.text
            total_get()

        End If

    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        DataGridView1.Rows.Clear()
        total_get()
        ' System.Media.SystemSounds.Asterisk.Play()
        Console.Beep(3000, 100)



    End Sub




    Private Sub button_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As New Button
        btn = CType(sender, Button)
        If qu_validation = True Then
            'FrmMsgPopUp.ShowDialog()
            Dim stock_q As Integer = 0
            Dim sales_q As Integer = 0
            Try
                Dim goal As String
                myconect_pool()
                Dim sql0 As String = "select * from tbl_products where pid='" & btn.Tag & "'"
                Dim cmd0 As New MySql.Data.MySqlClient.MySqlCommand(sql0, con)
                Dim dReader0 As MySqlDataReader

                dReader0 = cmd0.ExecuteReader()
                If dReader0.Read Then
                    goal = dReader0(1)
                End If

                myconect_pool()
                Dim mysql As String = "select sum(quantaty) from tbl_stock where productname='" & goal & "'"
                Dim mycmd As New MySql.Data.MySqlClient.MySqlCommand(mysql, con)
                Dim myReader As MySqlDataReader

                myReader = mycmd.ExecuteReader()
                If myReader.Read Then
                    stock_q = Val(myReader(0).ToString)

                Else
                    stock_q = 0
                End If
                myReader.Dispose()
                con.Close()

                myconect_pool()
                Dim mysql2 = "select sum(t_quantity) from tbl_transactions_details where t_product_name='" & goal & "'"
                Dim mycmd2 As New MySql.Data.MySqlClient.MySqlCommand(mysql2, con)
                Dim myReader2 As MySqlDataReader

                myReader2 = mycmd2.ExecuteReader()
                If myReader2.Read Then
                    sales_q = Val(myReader2(0).ToString)
                Else
                    sales_q = 0
                End If
                myReader2.Dispose()
                con.Close()

            Catch ex As Exception

            End Try
            Dim t_q = (stock_q - sales_q)
            If Val(t_q) <= 0 Then
                FrmMsgPopUp.ShowDialog()
                Exit Sub
            End If
        End If

        myconect_pool()

        Dim sql As String = "select * from tbl_products where pid='" & btn.Tag & "'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader



        Try


            dReader = cmd.ExecuteReader()
            Dim total = 0
            Do While dReader.Read = True


                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    For ColNo As Integer = 0 To 0
                        If dReader(1) = DataGridView1.Rows(i).Cells(ColNo).Value Then
                            total = DataGridView1.Rows(i).Cells(2).Value + 1
                            DataGridView1.Rows(i).Cells(2).Value = total

                            Dim maintotal = DataGridView1.Rows(i).Cells(2).Value * DataGridView1.Rows(i).Cells(1).Value
                            Dim maintax = maintotal * DataGridView1.Rows(i).Cells(3).Value
                            Dim maindiscount = DataGridView1.Rows(i).Cells(4).Value
                            DataGridView1.Rows(i).Cells(5).Value = (maintotal + maintax) - maindiscount

                            GoTo m
                        End If


                    Next
                Next

                DataGridView1.Rows.Add(dReader(1), dReader(5), total + 1, dReader(12), dReader(9), 0, "+", "-")
                '
            Loop
m:

            dReader.Close()
            total_get()
        Catch ex As Exception

        End Try
        con.Close()

        total_get()
        Console.Beep(3000, 100)


    End Sub





    Private Sub FrmPos_Resize(sender As Object, e As EventArgs)
        getbuttonslist(Val(txt_current_limit.Text), Val(txt_products_count.Text))
    End Sub

    Private Sub lbl_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim btn As New LinkLabel
        btn = CType(sender, LinkLabel)


        If qu_validation = True Then
            'FrmMsgPopUp.ShowDialog()
            Dim stock_q As Integer = 0
            Dim sales_q As Integer = 0
            Try
                Dim goal As String
                myconect_pool()
                Dim sql0 As String = "select * from tbl_products where pid='" & btn.Tag & "'"
                Dim cmd0 As New MySql.Data.MySqlClient.MySqlCommand(sql0, con)
                Dim dReader0 As MySqlDataReader

                dReader0 = cmd0.ExecuteReader()
                If dReader0.Read Then
                    goal = dReader0(1)
                End If

                myconect_pool()
                Dim mysql As String = "select sum(quantaty) from tbl_stock where productname='" & goal & "'"
                Dim mycmd As New MySql.Data.MySqlClient.MySqlCommand(mysql, con)
                Dim myReader As MySqlDataReader

                myReader = mycmd.ExecuteReader()
                If myReader.Read Then
                    stock_q = Val(myReader(0).ToString)

                Else
                    stock_q = 0
                End If
                myReader.Dispose()
                con.Close()

                myconect_pool()
                Dim mysql2 = "select sum(t_quantity) from tbl_transactions_details where t_product_name='" & goal & "'"
                Dim mycmd2 As New MySql.Data.MySqlClient.MySqlCommand(mysql2, con)
                Dim myReader2 As MySqlDataReader

                myReader2 = mycmd2.ExecuteReader()
                If myReader2.Read Then
                    sales_q = Val(myReader2(0).ToString)
                Else
                    sales_q = 0
                End If
                myReader2.Dispose()
                con.Close()

            Catch ex As Exception

            End Try
            Dim t_q = (stock_q - sales_q)
            If Val(t_q) <= 0 Then
                FrmMsgPopUp.ShowDialog()
                Exit Sub
            End If
        End If

        myconect_pool()
        Dim sql As String = "select * from tbl_products where pid='" & btn.Tag & "'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader
        Try
            dReader = cmd.ExecuteReader()
            Dim total = 0
            Do While dReader.Read = True
                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    For ColNo As Integer = 0 To 0
                        If dReader(1) = DataGridView1.Rows(i).Cells(ColNo).Value Then
                            total = DataGridView1.Rows(i).Cells(2).Value + 1
                            DataGridView1.Rows(i).Cells(2).Value = total
                            Dim maintotal = DataGridView1.Rows(i).Cells(2).Value * DataGridView1.Rows(i).Cells(1).Value
                            Dim maintax = maintotal * DataGridView1.Rows(i).Cells(3).Value
                            Dim maindiscount = DataGridView1.Rows(i).Cells(4).Value
                            DataGridView1.Rows(i).Cells(5).Value = (maintotal + maintax) - maindiscount
                            GoTo m
                        End If
                    Next
                Next

                DataGridView1.Rows.Add(dReader(1), dReader(5), total + 1, dReader(12), dReader(9), 0, "+", "-")
                '
            Loop
m:

            dReader.Close()
            total_get()
        Catch ex As Exception

        End Try
        con.Close()

        total_get()
        Console.Beep(3000, 100)

    End Sub


    Sub total_get()
        Try
            Dim total_costs As Double = 0
            Dim total_qu As Double = 0
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                For ColNo As Integer = 5 To 5
                    total_qu = total_qu + DataGridView1.Rows(i).Cells(2).Value
                    total_costs = total_costs + DataGridView1.Rows(i).Cells(5).Value
                    Dim maintotal = DataGridView1.Rows(i).Cells(2).Value * DataGridView1.Rows(i).Cells(1).Value
                    Dim maintax = maintotal * DataGridView1.Rows(i).Cells(3).Value / 100
                    Dim maindiscount = DataGridView1.Rows(i).Cells(4).Value * DataGridView1.Rows(i).Cells(2).Value
                    DataGridView1.Rows(i).Cells(5).Value = (maintotal + maintax) - maindiscount
                Next
            Next
            total_quantaty.Text = total_qu
            total_cost.Text = total_costs
            lbl_next_invoice.Text = "INV -" & SystemSerialNumber() & "-" & Format(Now, "ss-mm-dd-MM-yyyy") & "-" & userid
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.ColumnIndex = 7 Then
                DataGridView1.CurrentRow.Cells(2).Value = DataGridView1.CurrentRow.Cells(2).Value - 1
                DataGridView1.CurrentRow.Cells(5).Value = DataGridView1.CurrentRow.Cells(2).Value * DataGridView1.CurrentRow.Cells(1).Value
            End If
            If e.ColumnIndex = 6 Then

                DataGridView1.CurrentRow.Cells(2).Value = DataGridView1.CurrentRow.Cells(2).Value + 1
                DataGridView1.CurrentRow.Cells(5).Value = DataGridView1.CurrentRow.Cells(2).Value * DataGridView1.CurrentRow.Cells(1).Value
            End If
        Catch ex As Exception
        End Try
        If Not DataGridView1.Rows.Count = 0 Then
            If DataGridView1.CurrentRow.Cells(2).Value = 0 Then
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            End If
        End If
        total_get()
    End Sub



    Private Function SystemSerialNumber() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")
        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object =
        wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers =
        serial_numbers.Substring(2)
        Return serial_numbers
    End Function


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_cash.Click
        myconect_pool()
        payment("cash", "paid")
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        lbl_time.Text = Format(Now, "hh:mm:ss")
    End Sub

    Sub get_tancs_count()
        Dim mmydate = Format(Now, "yyy-MM-dd")

        Dim sql As String = "SELECT
   COUNT(`transaction_id`) t_count
    
    , SUM(`t_cost`) AS t_total
FROM
    `tbl_transactions` WHERE t_username='" & username & "' AND t_date='" & mmydate & "';"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader

        myconect_pool()
        Try

            dReader = cmd.ExecuteReader()

            Do While dReader.Read = True




                lbl_t_count.Text = dReader(0)
                lbl_total_costs.Text = Format(dReader(1), "###,##,00") & "  " & currency_char_ar
            Loop


        Catch ex As Exception

        End Try



        Dim sql1 As String = "SELECT
    `t_date`
    , `t_username`
    , `transaction_v_id`
FROM
    `tbl_transactions`  where t_username='" & username & "' ORDER BY transaction_id;"
        Dim cmd1 As New MySql.Data.MySqlClient.MySqlCommand(sql1, con)
        Dim dReader1 As MySqlDataReader

        myconect_pool()
        Try

            dReader1 = cmd1.ExecuteReader()

            Do While dReader1.Read = True




                lbl_last_date.Text = dReader1(0)
                last_invoice.Text = dReader1(2)

            Loop


        Catch ex As Exception

        End Try


    End Sub



    Private Sub DataGridView1_TextChanged(sender As Object, e As EventArgs) Handles DataGridView1.TextChanged
        total_get()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_BindingContextChanged(sender As Object, e As EventArgs) Handles DataGridView1.BindingContextChanged

    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If Not DataGridView1.Rows.Count = 0 Then

            If Not IsNumeric(DataGridView1.CurrentCell.Value) = True And e.ColumnIndex = 1 Then
                DataGridView1.CurrentRow.Cells(1).Value = 0
                DataGridView1.CurrentRow.Cells(1).Style.BackColor = Color.Red
            End If

            total_get()


        End If
    End Sub

    Private Sub lbl_next_invoice_Click(sender As Object, e As EventArgs) Handles lbl_next_invoice.Click

    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        txt_current_limit.Text = txt_current_limit.Text + 64
        getbuttonslist(txt_current_limit.Text, txt_products_count.Text)
    End Sub

    Private Sub btn_pre_Click(sender As Object, e As EventArgs) Handles btn_pre.Click
        If txt_current_limit.Text - 64 >= 1 Then
            txt_current_limit.Text = txt_current_limit.Text - 64
        End If

        getbuttonslist(txt_current_limit.Text, txt_products_count.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FrmCustomColors.ShowDialog()
    End Sub



    Private Sub btn_next_Validated(sender As Object, e As EventArgs) Handles btn_next.Validated
        getbuttonslist(txt_current_limit.Text, txt_products_count.Text)
    End Sub

    Private Sub txt_products_count_Click(sender As Object, e As EventArgs) Handles txt_products_count.Click

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If lbl_last.Text <> "" Then
            myconect_pool()
            Dim searchqry As String = "select * from tbl_transactions_details where transaction_v_id= '" & lbl_last.Text & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            Dim rp As New RepPosInvoice
            rp.DataSourceConnections.Clear()
            rp.SetDataSource(table)
            rp.SummaryInfo.ReportTitle = store_name_arabic
            rp.SummaryInfo.ReportComments = "<center>" & store_name_en & "<h5>  <span style='color:blue;' > INVOICE:  </span>" & lbl_last.Text & "</h5></center>"
            rp.SetDataSource(table)
            rp.PrintOptions.PrinterName = My.Settings.invoices_printer
            rp.PrintToPrinter(1, False, 0, 0)
            trace("Print Last Invoice : [" & lbl_last.Text & "]" & "")
        Else
            MsgBox("You cannot print the last invoice again.")
        End If
        get_tancs_count()
    End Sub



    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        If e.KeyCode = Keys.Enter Then


            If qu_validation = True Then
                'FrmMsgPopUp.ShowDialog()
                Dim stock_q As Integer = 0
                Dim sales_q As Integer = 0
                Try
                    Dim goal As String
                    myconect_pool()
                    Dim sql0 As String = "select * from tbl_products where Barcode='" & Me.txtbarcode.Text & "'"
                    Dim cmd0 As New MySql.Data.MySqlClient.MySqlCommand(sql0, con)
                    Dim dReader0 As MySqlDataReader

                    dReader0 = cmd0.ExecuteReader()
                    If dReader0.Read Then
                        goal = dReader0(1)
                    End If

                    myconect_pool()
                    Dim mysql As String = "select sum(quantaty) from tbl_stock where productname='" & goal & "'"
                    Dim mycmd As New MySql.Data.MySqlClient.MySqlCommand(mysql, con)
                    Dim myReader As MySqlDataReader

                    myReader = mycmd.ExecuteReader()
                    If myReader.Read Then
                        stock_q = Val(myReader(0).ToString)

                    Else
                        stock_q = 0
                    End If
                    myReader.Dispose()
                    con.Close()

                    myconect_pool()
                    Dim mysql2 = "select sum(t_quantity) from tbl_transactions_details where t_product_name='" & goal & "'"
                    Dim mycmd2 As New MySql.Data.MySqlClient.MySqlCommand(mysql2, con)
                    Dim myReader2 As MySqlDataReader

                    myReader2 = mycmd2.ExecuteReader()
                    If myReader2.Read Then
                        sales_q = Val(myReader2(0).ToString)
                    Else
                        sales_q = 0
                    End If
                    myReader2.Dispose()
                    con.Close()

                Catch ex As Exception

                End Try
                Dim t_q = (stock_q - sales_q)
                If Val(t_q) <= 0 Then
                    FrmMsgPopUp.ShowDialog()
                    Exit Sub
                End If
            End If



            myconect_pool()
            Dim sql As String = "select * from tbl_products where Barcode='" & Me.txtbarcode.Text & "'"
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
            Dim dReader As MySqlDataReader
            Try
                dReader = cmd.ExecuteReader()
                Dim total = 0
                Do While dReader.Read = True
                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        For ColNo As Integer = 0 To 0
                            If dReader(1) = DataGridView1.Rows(i).Cells(ColNo).Value Then
                                total = DataGridView1.Rows(i).Cells(2).Value + 1
                                DataGridView1.Rows(i).Cells(2).Value = total
                                Dim maintotal = DataGridView1.Rows(i).Cells(2).Value * DataGridView1.Rows(i).Cells(1).Value
                                Dim maintax = maintotal * DataGridView1.Rows(i).Cells(3).Value
                                Dim maindiscount = DataGridView1.Rows(i).Cells(4).Value
                                DataGridView1.Rows(i).Cells(5).Value = (maintotal + maintax) - maindiscount
                                GoTo m
                            End If
                        Next
                    Next

                    DataGridView1.Rows.Add(dReader(1), dReader(5), total + 1, dReader(12), dReader(9), 0, "+", "-")
                    '
                Loop
m:

                dReader.Close()
                total_get()
            Catch ex As Exception

            End Try
            con.Close()

            total_get()
            txtbarcode.Text = ""
            Console.Beep(3000, 100)

        End If

    End Sub

    Private Sub TextBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then


            If qu_validation = True Then
                'FrmMsgPopUp.ShowDialog()
                Dim stock_q As Integer = 0
                Dim sales_q As Integer = 0
                Try


                    myconect_pool()
                    Dim mysql As String = "select sum(quantaty) from tbl_stock where productname='" & Me.TextBox1.Text & "'"
                    Dim mycmd As New MySql.Data.MySqlClient.MySqlCommand(mysql, con)
                    Dim myReader As MySqlDataReader

                    myReader = mycmd.ExecuteReader()
                    If myReader.Read Then
                        stock_q = Val(myReader(0).ToString)

                    Else
                        stock_q = 0
                    End If
                    myReader.Dispose()
                    con.Close()

                    myconect_pool()
                    Dim mysql2 = "select sum(t_quantity) from tbl_transactions_details where t_product_name='" & Me.TextBox1.Text & "'"
                    Dim mycmd2 As New MySql.Data.MySqlClient.MySqlCommand(mysql2, con)
                    Dim myReader2 As MySqlDataReader

                    myReader2 = mycmd2.ExecuteReader()
                    If myReader2.Read Then
                        sales_q = Val(myReader2(0).ToString)
                    Else
                        sales_q = 0
                    End If
                    myReader2.Dispose()
                    con.Close()

                Catch ex As Exception

                End Try
                Dim t_q = (stock_q - sales_q)
                If Val(t_q) <= 0 Then
                    FrmMsgPopUp.ShowDialog()
                    Exit Sub
                End If
            End If
            myconect_pool()
            Dim sql As String = "select * from tbl_products where pnamearabic='" & Me.TextBox1.Text & "'"
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
            Dim dReader As MySqlDataReader
            Try
                dReader = cmd.ExecuteReader()
                Dim total = 0
                Do While dReader.Read = True
                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        For ColNo As Integer = 0 To 0
                            If dReader(1) = DataGridView1.Rows(i).Cells(ColNo).Value Then
                                total = DataGridView1.Rows(i).Cells(2).Value + 1
                                DataGridView1.Rows(i).Cells(2).Value = total
                                Dim maintotal = DataGridView1.Rows(i).Cells(2).Value * DataGridView1.Rows(i).Cells(1).Value
                                Dim maintax = maintotal * DataGridView1.Rows(i).Cells(3).Value
                                Dim maindiscount = DataGridView1.Rows(i).Cells(4).Value
                                DataGridView1.Rows(i).Cells(5).Value = (maintotal + maintax) - maindiscount
                                GoTo m
                            End If
                        Next
                    Next

                    DataGridView1.Rows.Add(dReader(1), dReader(5), total + 1, dReader(12), dReader(9), 0, "+", "-")
                    '
                Loop
m:

                dReader.Close()
                total_get()
            Catch ex As Exception

            End Try
            con.Close()

            total_get()
            TextBox1.Text = ""
            Console.Beep(3000, 100)
        End If

    End Sub




    Sub payment(ByVal payment_method As String, ByVal payment_status As String)
        If DataGridView1.Rows.Count <> 0 Then
            Dim MSG As String = ""
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                For ColNo As Integer = 1 To 1
                    If DataGridView1.Rows(i).Cells(1).Value = 0 Then
                        MSG = MSG & vbNewLine & DataGridView1.Rows(i).Cells(0).Value
                    End If
                Next
            Next
            If MSG <> "" Then
                MsgBox("Please enter the following product prices:" & vbNewLine & MSG, vbMsgBoxRight + vbMsgBoxRtlReading + vbInformation, "تنبيه")
                Exit Sub
            End If
            lbl_last.Text = lbl_next_invoice.Text
            pb.Maximum = DataGridView1.Rows.Count + 1
            pb.Value = 0
            Dim cmd As New MySqlCommand
            Dim result As Integer
            Dim sql As String = ""
            Dim txt = ""
            Dim mydate = Format(Now, "yyy-MM-dd")
            Dim mytime = Format(Now, "HH:mm:ss")
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                For ColNo As Integer = 0 To 0
                    txt = txt + DataGridView1.Rows(i).Cells(0).Value & " ," & DataGridView1.Rows(i).Cells(1).Value & " ," & DataGridView1.Rows(i).Cells(2).Value & " ," & DataGridView1.Rows(i).Cells(3).Value & " ," & DataGridView1.Rows(i).Cells(4).Value & " ," & DataGridView1.Rows(i).Cells(5).Value & vbNewLine
                Next
            Next
            sql = "insert into tbl_transactions (`Transactions_data`,`user_device`,`transaction_v_id`,`t_date`,`t_time`,`t_username`,`t_user_id`,`t_cost`,`payment_method`,`payment_status`) " & " values('" & txt & "','" & SystemSerialNumber() & "','" & lbl_next_invoice.Text & "','" & mydate & "','" & mytime & "','" & username & "','" & userid & "','" & total_cost.Text & "','" & payment_method & "','" & payment_status & "')"
            Try
                myconect_pool()
                With cmd
                    .Connection = con
                    .CommandText = sql
                    result = cmd.ExecuteNonQuery
                    cmd.Dispose()
                End With




                Dim sqlid As String = "select transaction_id from tbl_transactions where transaction_v_id='" & lbl_next_invoice.Text & "'"
                Dim cmdid As New MySql.Data.MySqlClient.MySqlCommand(sqlid, con)
                Dim dReaderid As MySqlDataReader
                Try
                    myconect_pool()

                Catch ex As MySql.Data.MySqlClient.MySqlException
                    MessageBox.Show("حدث خطأ ما في الاتصال")
                    Console.Beep(3000, 100)
                    Exit Sub
                End Try

                Dim newid = 0

                dReaderid = cmdid.ExecuteReader()
                If dReaderid.Read Then
                    newid = dReaderid(0)
                End If





                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    Dim t1 = DataGridView1.Rows(i).Cells(0).Value
                    Dim t2 = DataGridView1.Rows(i).Cells(1).Value
                    Dim t3 = DataGridView1.Rows(i).Cells(2).Value
                    Dim t4 = DataGridView1.Rows(i).Cells(5).Value
                    sql = "insert into tbl_transactions_details (`t_product_name`,`t_unit_price`,`t_quantity`,`t_price`,`transaction_v_id`,`t_date`,`t_time`,`t_username`,`t_user_id`,`tarns_id`) " & " values('" & t1 & "','" & t2 & "','" & t3 & "','" & t4 & "','" & lbl_next_invoice.Text & "','" & mydate & "','" & mytime & "','" & username & "','" & userid & "'," & newid & ")"
                    myconect_pool()
                    With cmd
                        .Connection = con
                        pb.Value = pb.Value + 1

                        .CommandText = sql
                        result = cmd.ExecuteNonQuery
                        cmd.Dispose()
                    End With
                    For ColNo As Integer = 0 To 0
                    Next
                Next
                pb.Value = pb.Maximum
                ' FrmInvoices.lbl_invoice_number.Text = lbl_last.Text.ToString
                last_invoice.Text = lbl_next_invoice.Text
                DataGridView1.Rows.Clear()
                total_quantaty.Text = ""
                total_cost.Text = ""
                lbl_next_invoice.Text = ""
                con.Close()
            Catch ex As Exception
                If con.State = ConnectionState.Open Then con.Close()
                MsgBox(ex.Message, MsgBoxStyle.Information)
            Finally
            End Try
            Dim searchqry As String = "select * from tbl_transactions_details where transaction_v_id= '" & last_invoice.Text & "'"
            Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            Dim rp As New RepPosInvoice
            rp.DataSourceConnections.Clear()
            rp.SetDataSource(table)
            rp.SummaryInfo.ReportTitle = store_name_arabic
            If payment_status = "notpaid" Then
                rp.SummaryInfo.ReportAuthor = "<center style='color:blue;'>Payment Request  - PR </center>"
            Else
                rp.SummaryInfo.ReportAuthor = "<center style='color:blue;'>Purchase bill </center>"
            End If
            rp.SummaryInfo.ReportComments = "<center>" & store_name_en & "</center>"

            rp.SetDataSource(table)

            Console.Beep(4000, 300)
            rp.PrintOptions.PrinterName = My.Settings.invoices_printer
            rp.PrintToPrinter(1, False, 0, 0)
            trace("New Invoice : [" & lbl_last.Text & "]" & "Has Been Issued")
            My.Settings.last_invoice = Me.lbl_last.Text
            My.Settings.Save()
        End If
        get_tancs_count()
    End Sub


    Private Sub FRMPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Close()
        txt_products_count.Text = "0"
        txt_current_limit.Text = 0
        Dim sql As String = "select count(PCShow) from  tbl_products where PCShow=true "
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader
        myconect_pool()
        dReader = cmd.ExecuteReader()
        If dReader.Read() Then
            txt_products_count.Text = dReader(0)
        End If
        txt_current_limit.Text = 1
        Timer.Start()
        get_tancs_count()
        getbuttonslist(txt_current_limit.Text, txt_products_count.Text)
        lbl_last.Text = My.Settings.last_invoice

    End Sub

    Private Sub btnonaccount_Click(sender As Object, e As EventArgs) Handles btnonaccount.Click
        myconect_pool()
        payment("OnAccount", "paid")
    End Sub

    Private Sub btn_applications_Click(sender As Object, e As EventArgs) Handles btn_applications.Click
        myconect_pool()
        payment("application", "paid")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myconect_pool()
        payment("Pancard", "paid")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        myconect_pool()
        payment("cashier", "notpaid")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        myconect_pool()
        payment("check", "paid")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmCancelOperation1.ShowDialog()
        trace("Open Cancel Operation window")
    End Sub
End Class
