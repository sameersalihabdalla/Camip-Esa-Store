Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.Common


Public Class FrmBarcode

    
    Private Sub Frm_Barcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ReportSource = Nothing
        con.Close()

        Dim sql As String = "select * from tbl_products where PCactive=true"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader
        Try
            myconect_pool()

            dReader = cmd.ExecuteReader()
            Do While dReader.Read = True
                CmbBarcode.Items.Add(dReader(1))
            Loop
            dReader.Close()

        Catch ex As Exception

        End Try
        con.Close()


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub CmbBarcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBarcode.SelectedIndexChanged
        Dim txt_store_name_ar = ""
        Dim txt_store_name_en = ""
        If con.State = ConnectionState.Open Then con.Close()
        myconect_pool()





        Dim searchqry As String = "select *   from tbl_products where PCactive=true and  pnamearabic='" & Me.CmbBarcode.Text & "'"

        Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)

        Try

            'DataGridView1.DataSource = table
            Dim rp As New RepBarcodeSample1
            rp.DataSourceConnections.Clear()
            RepBarcodeSamPle11.SetDataSource(table)

            rp.SetDataSource(table)
            rp.Refresh()
            CrystalReportViewer1.ReportSource = rp

            '   Me.CrystalReportViewe.Refresh()
        Catch ex As Exception

        End Try
    End Sub


End Class
