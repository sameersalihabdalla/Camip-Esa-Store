Imports MySql.Data.MySqlClient

Public Class FrmTraceUsers
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Try

            myconect_pool()
            Dim d1, d2
            d1 = Format(DateTimePicker1.Value, "yyy-MM-dd")

            d2 = Format(DateTimePicker2.Value, "yyy-MM-dd")

            Dim searchqry As String = "select * from tbl_user_trace where trace_date >= '" & d1 & "' and trace_date<='" & d2 & "' order by trace_date desc"

            Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
            Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)

            'DataGridView1.DataSource = table
            Dim rp As New RepUsersTrace
            rp.DataSourceConnections.Clear()
            RepUsersTrace1.SetDataSource(table)
            rp.SummaryInfo.ReportTitle = store_name_arabic
            rp.SummaryInfo.ReportComments = store_name_en
            rp.SummaryInfo.ReportAuthor = "Track User Movement (TUM) " & d1 & " - " & d2

            rp.SetDataSource(table)
            rp.Refresh()
            CrystalReportViewer1.ReportSource = rp

            Me.CrystalReportViewer1.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Frm_trace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ReportSource = Nothing

    End Sub
End Class