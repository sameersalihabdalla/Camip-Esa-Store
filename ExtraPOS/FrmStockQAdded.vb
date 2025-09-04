Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmStockQAdded



    Private Sub FrmStockQAdded_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txt_store_name_ar = ""
        Dim txt_store_name_en = ""


        Dim sql As String = "select * from tbl_settings"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader


        Try

            myconect_pool()
            dReader = cmd.ExecuteReader()
            If dReader.Read = True Then
                txt_store_name_ar = dReader(1).ToString
                txt_store_name_en = dReader(2).ToString

            End If

            dReader.Close()



            con.Close()


            Dim d1, d2
            d1 = Format(DateTimePicker1.Value, "yyy-MM-dd")

            d2 = Format(DateTimePicker2.Value, "yyy-MM-dd")

            Dim searchqry As String = " SELECT * FROM  myproject.tbl_products tbl_products1 INNER JOIN myproject.tbl_stock tbl_stock1 ON tbl_products1.pid=tbl_stock1.productid
 ORDER BY tbl_products1.pnamearabic"

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)

            'DataGridView1.DataSource = table
            Dim rp As New RepStockStatus
            rp.DataSourceConnections.Clear()
            Me.RepStockStatus1.SetDataSource(table)
            rp.SummaryInfo.ReportTitle = txt_store_name_ar
            rp.SummaryInfo.ReportComments = txt_store_name_en
            rp.SummaryInfo.ReportAuthor = "كشف المعاملات من " & d1 & " - " & d2

            rp.SetDataSource(table)
            rp.Refresh()
            CrystalReportViewer1.ReportSource = rp

            '   Me.CrystalReportViewe.Refresh()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
