Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmCollectionCashier

    Sub loading_data()
        myconect_pool()
        Dim sql As String = "select * from tbl_transactions where payment_status='notpaid'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader
        dReader = cmd.ExecuteReader()
        Do While dReader.Read = True
            Me.dgv.Rows.Add(dReader(8), dReader(7), Format(dReader(3), "dd/MM/yyyy"), dReader(5), "  Pay    ")
        Loop
            dReader.Close()
        con.Close()
    End Sub
    Private Sub FrmCollectionCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading_data()
    End Sub


    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.ColumnIndex = 4 Then
            dgv_details.Rows.Clear()

            lbl_invoice_id.Text = dgv.CurrentRow.Cells(0).Value
            lbl_cost.Text = dgv.CurrentRow.Cells(1).Value & "  " & currency_char_ar
            lbl_username.Text = dgv.CurrentRow.Cells(3).Value
            myconect_pool()

            Dim sql As String = "select * from tbl_transactions_details where  transaction_v_id='" & dgv.CurrentRow.Cells(0).Value & "'"
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
            Dim dReader As MySqlDataReader
            Try
                dReader = cmd.ExecuteReader()
                Do While dReader.Read = True
                    Me.dgv_details.Rows.Add(dReader(1), dReader(2), dReader(3), dReader(4))
                Loop
                dReader.Close()
            Catch ex As Exception
            End Try
            con.Close()
        End If
    End Sub

    Private Sub lbl_invoice_id_Click(sender As Object, e As EventArgs) Handles lbl_invoice_id.Click
        payment()
    End Sub

    Private Sub btn_cash_Click(sender As Object, e As EventArgs) Handles btn_cash.Click
        payment()
    End Sub


    Sub payment()

        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim sql As String
        sql = "update tbl_transactions  set `payment_status`=@d1 where transaction_v_id='" & Me.lbl_invoice_id.Text & "'"
        Dim sure = MsgBox("هل تريد الحفظ؟", vbYesNo)
        If sure = vbNo Then
            Exit Sub
        End If

        myconect_pool()
        With cmd
            .Connection = con
            .CommandText = sql
            .Parameters.AddWithValue("@d1", "paid")

        End With
        Try

            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MsgBox("لم تحفظ البيانات بعد")
                trace("Cashier Payment invalid  ....")
            Else
                MsgBox("تم سداد المعاملة بنجاح")
                trace("Cashier Payment Successfuly ")
            End If
            con.Close()
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally

        End Try

        Dim searchqry As String = "select * from tbl_transactions_details where transaction_v_id= '" & Me.lbl_invoice_id.Text & "'"
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(searchqry, con)
        Dim adapter As New MySql.Data.MySqlClient.MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        Dim rp As New RepPosInvoicepaid
        rp.DataSourceConnections.Clear()
        rp.SetDataSource(table)
        rp.SummaryInfo.ReportTitle = store_name_arabic
        rp.SummaryInfo.ReportAuthor = "<center style='color:blue;' dir='rtl'>   تحصيل مركزي بواسطة   <span style='color:red;'> " & Me.lbl_username.Text & "  </span> </center>"
        rp.SummaryInfo.ReportComments = "<center>" & store_name_en & "</center>"
        rp.SetDataSource(table)
        Console.Beep(4000, 300)
        rp.PrintOptions.PrinterName = My.Settings.invoices_printer
        rp.PrintToPrinter(1, False, 0, 0)
        clearing_fields()
        ' get_tancs_count()
    End Sub

    Private Sub lbl_username_Click(sender As Object, e As EventArgs) Handles lbl_username.Click
        payment()
    End Sub


    Sub clearing_fields()
        dgv.Rows.Clear()
        dgv_details.Rows.Clear()
        loading_data()

        lbl_invoice_id.Text = ""
        lbl_username.Text = ""
        lbl_cost.Text = ""

    End Sub

    Private Sub lbl_cost_Click(sender As Object, e As EventArgs) Handles lbl_cost.Click

    End Sub

    Private Sub dgv_details_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_details.CellContentClick

    End Sub

    Private Sub dgv_details_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles dgv_details.RowStateChanged

    End Sub

    Sub btn()
        If dgv_details.Rows.Count = 0 Then
            btn_cash.Enabled = False
        Else
            btn_cash.Enabled = True

        End If
    End Sub

    Private Sub dgv_details_TextChanged(sender As Object, e As EventArgs) Handles dgv_details.TextChanged
        btn()
    End Sub

    Private Sub dgv_details_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgv_details.RowValidating
        btn()
    End Sub
End Class
