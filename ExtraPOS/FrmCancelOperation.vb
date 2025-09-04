Imports MySql.Data.MySqlClient

Public Class FrmCancelOperation1


    Private Sub txtbarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcode.KeyDown
        myconect_pool()
        If Not e.KeyCode = Keys.Enter Then Exit Sub

        GroupBox1.Text = ""
        DataGridView1.Rows.Clear()
        lblinvoice.Text = ""
        lblcost.Text = ""
        Dim sql0 As String = "select * from tbl_transactions where transaction_id=" & Me.txtbarcode.Text & ""
            Dim cmd0 As New MySql.Data.MySqlClient.MySqlCommand(sql0, con)

            Dim dReader0 As MySqlDataReader
            Dim invoice
            dReader0 = cmd0.ExecuteReader()
            If dReader0.Read Then
            Me.GroupBox1.Text = "Current invoice number : " & dReader0(3).ToString
            invoice = dReader0(0)
            lblinvoice.Text = dReader0(3)
            lblcost.Text = dReader0(8)
        End If



            'level 2
            myconect_pool()

        Dim sqlnew As String = "select * from tbl_transactions_details where tarns_id=" & invoice & ""
        Dim cmdnew As New MySql.Data.MySqlClient.MySqlCommand(sqlnew, con)
        Dim dReadernew As MySqlDataReader
            Try
                dReadernew = cmdnew.ExecuteReader()

                Do While dReadernew.Read = True

                DataGridView1.Rows.Add(dReadernew(0), dReadernew(1), dReadernew(2), dReadernew(3), dReadernew(4), dReadernew(6), dReadernew(7), dReadernew(8))
            Loop

            Catch ex As Exception

            End Try



    End Sub

    Private Sub FrmCancelOperation1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtbarcode_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sure = MsgBox("هل تريد حذف الفاتورة رقم :  " & Me.lblinvoice.Text, vbYesNo + vbMsgBoxRight + vbMsgBoxRtlReading, "")
        If sure = vbYes Then
            myconect_pool()

            If Me.lblinvoice.Text <> "" Then
                Dim sql As String = "delete from tbl_transactions where transaction_v_id='" & Me.lblinvoice.Text & "'"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()


                Dim sql2 As String = "delete from tbl_transactions_details where transaction_v_id='" & Me.lblinvoice.Text & "'"
                Dim cmd2 As New MySql.Data.MySqlClient.MySqlCommand(sql2, con)
                cmd2.ExecuteNonQuery()
                cmd2.Dispose()


                lblinvoice.Text = ""
                lblcost.Text = ""
                GroupBox1.Text = ""
                txtbarcode.Text = ""
                DataGridView1.Rows.Clear()
                MsgBox("Deleted successfully", vbInformation)

            Else
                MsgBox("Please select invoice")
            End If
        End If
    End Sub



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        myconect_pool()
        If Not e.KeyCode = Keys.Enter Then Exit Sub

        GroupBox1.Text = ""
        DataGridView1.Rows.Clear()
        lblinvoice.Text = ""
        lblcost.Text = ""

        Dim sql0 As String = "select * from tbl_transactions where transaction_v_id='" & Me.TextBox1.Text & "'"
        Dim cmd0 As New MySql.Data.MySqlClient.MySqlCommand(sql0, con)

        Dim dReader0 As MySqlDataReader
        Dim invoice
        dReader0 = cmd0.ExecuteReader()
        If dReader0.Read Then
            Me.GroupBox1.Text = "Current invoice number : " & dReader0(3).ToString
            invoice = dReader0(0)
            lblinvoice.Text = dReader0(3)
            lblcost.Text = dReader0(8)
            TextBox1.Text = ""
        End If



        'level 2
        myconect_pool()

        Dim sqlnew As String = "select * from tbl_transactions_details where tarns_id=" & invoice & ""
        Dim cmdnew As New MySql.Data.MySqlClient.MySqlCommand(sqlnew, con)
        Dim dReadernew As MySqlDataReader
        Try
            dReadernew = cmdnew.ExecuteReader()

            Do While dReadernew.Read = True

                DataGridView1.Rows.Add(dReadernew(0), dReadernew(1), dReadernew(2), dReadernew(3), dReadernew(4), dReadernew(6), dReadernew(7), dReadernew(8))
            Loop

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub lblcost_Click(sender As Object, e As EventArgs) Handles lblcost.Click

    End Sub
End Class
