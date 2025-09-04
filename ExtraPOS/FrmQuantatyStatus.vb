Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmQuantatyStatus


    Private Sub FrmQuantatyStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ReportSource = Nothing




        Dim q_sales = 0
        Dim prd_name = ""
        Dim q_stock = 0

        Dim sql As String = "select * from tbl_products"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader




        Dim sqlstock As String = "select sum(quantaty) from tbl_stock where productname='" & prd_name & "'"
        Dim cmdstock As New MySql.Data.MySqlClient.MySqlCommand(sqlstock, con)
        Dim dReaderstock As MySqlDataReader






        myconect_pool()
        dReader = cmd.ExecuteReader()
        ToolStripStatusLabel1.Text = " عدد المنتجات " & dReader.FieldCount
        Do While dReader.Read = True
            prd_name = dReader(1)
            dgv.Rows.Add(prd_name, q_sales, q_stock, "")
        Loop
        dReader.Dispose()
        con.Close()

        For i As Integer = 0 To dgv.Rows.Count - 1
            Dim sqlSales = "select sum(t_quantity) from tbl_transactions_details where t_product_name='" & dgv.Rows.Item(i).Cells(0).Value.ToString & "'"
            Dim cmdSales As New MySql.Data.MySqlClient.MySqlCommand(sqlSales, con)
            Dim dReaderSales As MySqlDataReader
            myconect_pool()
            dReaderSales = cmdSales.ExecuteReader()
            If dReaderSales.Read() = True And dReaderSales(0).ToString <> "" Then
                dgv.Rows.Item(i).Cells(1).Value = Val(dReaderSales(0).ToString)
            Else
                dgv.Rows.Item(i).Cells(1).Value = 0

            End If
            dReaderSales.Dispose()
            con.Close()
        Next



        For i As Integer = 0 To dgv.Rows.Count - 1
            Dim sqlSales = "select sum(quantaty) from tbl_stock where productname='" & dgv.Rows.Item(i).Cells(0).Value.ToString & "'"
            Dim cmdSales As New MySql.Data.MySqlClient.MySqlCommand(sqlSales, con)
            Dim dReaderSales As MySqlDataReader
            myconect_pool()
            dReaderSales = cmdSales.ExecuteReader()
            If dReaderSales.Read() = True And dReaderSales(0).ToString <> "" Then
                dgv.Rows.Item(i).Cells(2).Value = Val(dReaderSales(0).ToString)
            Else
                dgv.Rows.Item(i).Cells(2).Value = 0

            End If
            dReaderSales.Dispose()
            con.Close()
        Next



        For i As Integer = 0 To dgv.Rows.Count - 1
            dgv.Rows.Item(i).Cells(3).Value = dgv.Rows.Item(i).Cells(2).Value - dgv.Rows.Item(i).Cells(1).Value
        Next



        For i As Integer = 0 To dgv.Rows.Count - 1
            If Val(dgv.Rows.Item(i).Cells(3).Value) <= 0 Then
                dgv.Rows.Item(i).Cells(3).Style.BackColor = Color.Red
                dgv.Rows.Item(i).Cells(3).Style.ForeColor = Color.White
            Else
                dgv.Rows.Item(i).Cells(3).Style.BackColor = Color.DarkGreen
                dgv.Rows.Item(i).Cells(3).Style.ForeColor = Color.White

            End If

        Next




    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim resultdelte As Integer
        Dim sqldelete As String = "delete from tbl_temp_stock where username='" & username & "'"
        Dim cmddelete As New MySql.Data.MySqlClient.MySqlCommand(sqldelete, con)
        Dim dReaderdelete As MySqlDataReader
        myconect_pool()
        cmddelete.ExecuteNonQuery()
        cmddelete.Dispose()
        con.Close()
        Pbar.Maximum = dgv.Rows.Count
        Pbar.Value = 0
        Pbar.UseWaitCursor = True
        For i As Integer = 0 To dgv.Rows.Count - 1
            Pbar.Value = Pbar.Value + 1
            Dim result As Integer
            Dim sql As String = ""
            sql = "insert into tbl_temp_stock (`product_name`, `stock`,`sales`,`current`, `username`)" & " values('" & dgv.Rows.Item(i).Cells(0).Value & "', " & dgv.Rows.Item(i).Cells(1).Value & " ," & dgv.Rows.Item(i).Cells(2).Value & "," & dgv.Rows.Item(i).Cells(3).Value & ",'" & username & "')"
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
            Dim dReader As MySqlDataReader
            myconect_pool()
            dReader = cmd.ExecuteReader()
            con.Close()
        Next
        Pbar.UseWaitCursor = False



        Dim searchqry As String = "select * from tbl_temp_stock where username = '" & username & "'"

        Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        'DataGridView1.DataSource = table
        Dim rp As New Rep_current_stock_status
        rp.DataSourceConnections.Clear()
        Rep_current_stock_status1.SetDataSource(table)
        rp.SummaryInfo.ReportTitle = store_name_arabic
        rp.SummaryInfo.ReportComments = store_name_en
        rp.SummaryInfo.ReportAuthor = "حالة المخزون الحالية"

        rp.SetDataSource(table)
        rp.Refresh()
        CrystalReportViewer1.ReportSource = rp

        '   Me.CrystalReportViewe.Refresh()
        Pbar.Value = 0
    End Sub

End Class
