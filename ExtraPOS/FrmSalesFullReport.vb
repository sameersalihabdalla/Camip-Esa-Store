Imports MySql.Data.MySqlClient

Public Class FrmSalesFullReport
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

            Dim searchqry As String = "select * from tbl_transactions_details where t_date >= '" & d1 & "' and t_date<='" & d2 & "' order by t_date desc"

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)

            'DataGridView1.DataSource = table
            Dim rp As New RepAllTrancs
            rp.DataSourceConnections.Clear()
            all_trancs1.SetDataSource(table)
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

    Private Sub frm_full_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ReportSource = Nothing
        Exit Sub


    End Sub
End Class