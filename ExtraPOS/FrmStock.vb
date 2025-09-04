Imports MySql.Data.MySqlClient

Public Class FrmStockQuantaties
    Private Sub FrmStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "select * from tbl_products"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader
        If con.State = ConnectionState.Open Then con.Close()
        Try
            myconect_pool()

            dReader = cmd.ExecuteReader()
            Do While dReader.Read = True
                CmbProducts.Items.Add(dReader(1))
            Loop
            dReader.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cactive_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLock_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLock_Click_1(sender As Object, e As EventArgs) Handles btnLock.Click
        If CmbProducts.Text <> "" Then
            Gbx1.Enabled = True
            btnLock.Enabled = False
            btnUnlock.Enabled = True
            TLB.Enabled = True
            gbx2.Enabled = True
            dgv.Enabled = True
            CmbProducts.Enabled = False
            dgv.Rows.Clear()
            loading_data()
        End If
    End Sub

    Sub loading_data()
        myconect_pool()

        Dim sql As String = "SELECT * FROM `myproject`.`tbl_stock` INNER JOIN `myproject`.`tbl_products` ON (`tbl_stock`.`productid` = `tbl_products`.`pid`) where productname='" & Me.CmbProducts.Text & "' "
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader

        Try
            dReader = cmd.ExecuteReader()
            Do While dReader.Read = True
                Me.dgv.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7), dReader(8), dReader(9))
            Loop
            dReader.Close()

        Catch ex As Exception

        End Try
        con.Close()
    End Sub

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        btnLock.Enabled = True
        btnUnlock.Enabled = False
        CmbProducts.Enabled = True
        dgv.Rows.Clear()
        clearing_fields()
        fill_data()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Me.dgv.Rows.Clear()
        clearing_fields()
        Me.dgv.Enabled = False
        Me.btn_add.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_cancel.Enabled = True
        TxtQuantary.Enabled = True
        TxtQuantary.Focus()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If TxtQuantary.Text = "" Then
            MsgBox("Please fill in all fields with correct and valid data.", vbInformation)
            Exit Sub
        End If

        Dim resultnew As Integer
        Dim sqlnew As String = "select * from tbl_products where pnamearabic='" & Me.CmbProducts.Text & "'"
        Dim cmdnew As New MySql.Data.MySqlClient.MySqlCommand(sqlnew, con)
        Dim productid
        Dim dReadernew As MySqlDataReader
        Dim catid As Integer
        Dim catname As String

        myconect_pool()

        dReadernew = cmdnew.ExecuteReader()
        If dReadernew.Read Then
            productid = dReadernew(0)
            catid = dReadernew(7)
            catname = dReadernew(8)

            dReadernew.Close()
            con.Close()
        End If

        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim sql As String = ""

        If btn_save.Text = "Save" Then
            sql = "insert tbl_stock (`productname`,`quantaty`,`productid`,`catid`,`catname`,`userid`,`username`,`date`,`time`) values('" & Me.CmbProducts.Text & "','" & Me.TxtQuantary.Text & "','" & productid & "','" & catid & "','" & catname & "','" & userid & "','" & username & "','" & Format(Now, "yyy-MM-dd") & "','" & Format(Now, "HH:mm:ss") & "')"
        End If

        Try
            myconect_pool()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Data not saved yet")
                Else
                    If btn_save.Text = "Save" Then
                        MsgBox("Data saved")
                    Else
                        MsgBox("Data successfully modified")
                    End If

                    btn_add.Enabled = True
                    btn_save.Enabled = False
                    btn_save.Text = "Save"
                    btn_cancel.Enabled = False
                    Me.dgv.Rows.Clear()
                    Me.TxtQuantary.Enabled = False
                    Me.dgv.Enabled = True
                    con.Close()
                    loading_data()
                End If
            End With
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally

        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clearing_fields()
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "Save"
        btn_cancel.Enabled = False
        Me.dgv.Enabled = True
        Me.dgv.Rows.Clear()
        Me.TxtQuantary.Enabled = False
        loading_data()
    End Sub

    Sub clearing_fields()
        TxtQuantary.Text = ""
        Me.stock_id.Text = ""
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sure = MsgBox("Do you want to delete the quantity of the product added on " & Me.dgv.CurrentRow.Cells(2).Value & " on " & Me.dgv.CurrentRow.Cells(6).Value, vbYesNo, "")
        If sure = vbYes Then
            myconect_pool()
            If stock_id.Text <> "" Then
                Dim sql As String = "delete from tbl_stock where stockid='" & Me.stock_id.Text & "'"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    MsgBox("Successfully deleted", vbInformation)
                    clearing_fields()
                    btn_add.Enabled = True
                    btn_save.Enabled = False
                    btn_save.Text = "Save"
                    btn_cancel.Enabled = False
                    Me.dgv.Enabled = True
                    Me.dgv.Rows.Clear()
                    con.Close()
                    loading_data()
                Catch ex As Exception
                End Try
            Else
                MsgBox("Please specify the category to be deleted")
            End If
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        clearing_fields()
        fill_data()
    End Sub

    Sub fill_data()
        Try
            With Me.dgv.CurrentRow
                Me.TxtQuantary.Text = .Cells(5).Value
                Me.Gbx1.Text = "Warehouse: " & .Cells(2).Value
                stock_id.Text = .Cells(0).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtQuantary_TextChanged(sender As Object, e As EventArgs) Handles TxtQuantary.TextChanged
        If IsNumeric(TxtQuantary.Text) Then
        Else
            TxtQuantary.Text = ""
            Beep()
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        clearing_fields()
        fill_data()
    End Sub

    Private Sub stock_id_Click(sender As Object, e As EventArgs) Handles stock_id.Click

    End Sub

    Private Sub stock_id_TextChanged(sender As Object, e As EventArgs) Handles stock_id.TextChanged
        If stock_id.Text = "" Then
            btn_delete.Enabled = False
        Else
            btn_delete.Enabled = True
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub CmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProducts.SelectedIndexChanged

    End Sub
End Class
