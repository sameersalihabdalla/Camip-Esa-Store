Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmProductWin



    Private Sub FrmProductWin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim txt_store_name_ar = ""
        Dim txt_store_name_en = ""


        Dim sql As String = "select * from tbl_settings"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader


        Try

            If con.State = ConnectionState.Open Then con.Close()
            myconect_pool()
            dReader = cmd.ExecuteReader()
            If dReader.Read = True Then
                txt_store_name_ar = dReader(1).ToString
                txt_store_name_en = dReader(2).ToString

            End If

            dReader.Close()



            con.Close()





            Dim searchqry As String = "SELECT *,
   ( (`price`/`parts`)-`PBprice`) AS wins
   
FROM
    `myproject`.`tbl_products`;"

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)

            'DataGridView1.DataSource = table
            Dim rp As New RepProductWin
            rp.DataSourceConnections.Clear()
            Me.RepProductWin1.SetDataSource(table)
            rp.SummaryInfo.ReportTitle = txt_store_name_ar
            rp.SummaryInfo.ReportComments = txt_store_name_en
            rp.SummaryInfo.ReportAuthor = "كشف ارباح المنتجات "

            rp.SetDataSource(table)
            rp.Refresh()
            CrystalReportViewer1.ReportSource = rp

            '   Me.CrystalReportViewe.Refresh()
        Catch ex As Exception

        End Try
    End Sub

End Class
