Imports System.Security
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmusersManagement



    Private Sub FrmusersManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CmbRole.Items.Add("")
        CmbRole.Items.Add("Administrative")
        CmbRole.Items.Add("Direct sales employee")
        CmbRole.Items.Add("Cashier sales employee")
        CmbRole.Items.Add("Accountant")
        CmbRole.Items.Add("sales revenue")
        CmbRole.Items.Add("HR Officer")
        CmbRole.Items.Add("store manager")


        clearing_fields()
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "حفظ"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txt_full_name.Enabled = False
        Me.txt_username.Enabled = False
        Me.txt_password.Enabled = False
        Me.cactive.Enabled = False
        Me.Cadd.Enabled = False
        Me.caddusers.Enabled = False
        Me.cdelete.Enabled = False
        Me.cedit.Enabled = False
        Me.cprint.Enabled = False
        loading_full_userdata()
        CmbRole.Enabled = False




    End Sub




    Sub loading_full_userdata()
        myconect_pool()
        Dim sql As String = "select * from tbl_users_data"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader



        Try


            dReader = cmd.ExecuteReader()
            Do While dReader.Read = True
                Me.DataGridView1.Rows.Add(dReader(0), dReader(2), dReader(1), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7), dReader(8), dReader(9), dReader(10))
            Loop
            dReader.Close()

        Catch ex As Exception

        End Try
        con.Close()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()

    End Sub


    Sub fill_mydata()
        Try
            With Me.DataGridView1.CurrentRow
                Me.txt_user_id.Text = .Cells(0).Value
                Me.txt_full_name.Text = .Cells(1).Value
                'Me.GroupBox2.Text = "المستخدم الحالي " & .Cells(1).Value
                Me.txt_username.Text = .Cells(2).Value
                Me.txt_password.Text = .Cells(3).Value
                Me.cactive.Checked = .Cells(4).Value
                Me.cprint.Checked = .Cells(5).Value
                Me.Cadd.Checked = .Cells(6).Value
                Me.cdelete.Checked = .Cells(7).Value
                Me.caddusers.Checked = .Cells(8).Value
                Me.cedit.Checked = .Cells(9).Value
                If Not .Cells(10).Value = Nothing Then
                    Me.CmbRole.SelectedItem = .Cells(10).Value
                Else
                    Me.CmbRole.SelectedItem = ""

                End If


            End With


        Catch ex As Exception
        End Try
    End Sub
    Private Sub clearing_fields()
        Me.txt_user_id.Text = ""
        Me.txt_full_name.Text = ""
        Me.txt_username.Text = ""
        Me.txt_password.Text = ""
        Me.cactive.Checked = False
        Me.Cadd.Checked = False
        Me.caddusers.Checked = False
        Me.cdelete.Checked = False
        Me.cedit.Checked = False
        Me.cprint.Checked = False
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clearing_fields()
        fill_mydata()

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Me.CmbRole.SelectedItem = ""

        clearing_fields()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Enabled = False

        Me.btn_add.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_cancel.Enabled = True
        Me.txt_full_name.Focus()
        CmbRole.Enabled = True



        Me.txt_full_name.Enabled = True
        Me.txt_username.Enabled = True
        Me.txt_password.Enabled = True
        Me.cactive.Enabled = True
        Me.Cadd.Enabled = True
        Me.caddusers.Enabled = True
        Me.cdelete.Enabled = True
        Me.cedit.Enabled = True
        Me.cprint.Enabled = True
        txt_full_name.Focus()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.CmbRole.SelectedItem = ""

        clearing_fields()
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "حفظ"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txt_full_name.Enabled = False
        Me.txt_username.Enabled = False
        Me.txt_password.Enabled = False
        Me.cactive.Enabled = False
        Me.Cadd.Enabled = False
        Me.caddusers.Enabled = False
        Me.cdelete.Enabled = False
        Me.cedit.Enabled = False
        Me.cprint.Enabled = False
        loading_full_userdata()
        CmbRole.Enabled = False


    End Sub

    Private Sub txt_user_id_TextChanged(sender As Object, e As EventArgs) Handles txt_user_id.TextChanged
        If txt_user_id.Text = "" Then
            btn_edit.Enabled = False
            btn_delete.Enabled = False
        Else
            btn_edit.Enabled = True
            btn_delete.Enabled = True


        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Me.DataGridView1.Enabled = False
        Me.btn_add.Enabled = False
        Me.btn_delete.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_save.Text = "حفظ التعديل"
        Me.btn_cancel.Enabled = True
        Me.txt_full_name.Enabled = True
        Me.txt_username.Enabled = True
        Me.txt_password.Enabled = True
        Me.cactive.Enabled = True
        Me.Cadd.Enabled = True
        Me.caddusers.Enabled = True
        Me.cdelete.Enabled = True
        Me.cedit.Enabled = True
        Me.cprint.Enabled = True
        CmbRole.Enabled = True
        trace("Start Edit Operation For User : " & Me.txt_username.Text)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If Me.txt_user_id.Text = "1" Then
            MsgBox("لا يمكنك حذف حساب إدارة النظام", vbCritical)
            Exit Sub
        End If

        Dim sure = MsgBox("هل تريد حذف المستخدم " & Me.txt_username.Text, vbYesNo, "")
        If sure = vbYes Then
            If con.State = ConnectionState.Open Then con.Close()
            myconect_pool()
            If Me.txt_user_id.Text <> "" Then
                Dim sql As String = "delete from tbl_users_data where user_id='" & Me.txt_user_id.Text & "'"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)

                Try
                    cmd.ExecuteNonQuery()

                    cmd.Dispose()
                    MsgBox("تم الحذف بنجاح", vbInformation)
                    trace("Delete Username :" & Me.txt_username.Text)

                    clearing_fields()
                    btn_add.Enabled = True
                    btn_save.Enabled = False
                    btn_save.Text = "حفظ"
                    btn_cancel.Enabled = False
                    Me.DataGridView1.Enabled = True
                    Me.DataGridView1.Rows.Clear()
                    con.Close()
                    loading_full_userdata()




                Catch ex As Exception

                End Try
            Else

                MsgBox("يرجى تحديد المستخدم المراد حذففه")
            End If

        End If

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim sql As String = ""

        If txt_user_id.Text = "" And btn_save.Text = "حفظ" Then
            sql = "insert into tbl_users_data (`username`
    , `name`
    , `password`
    , `enableded`
    , `print_permission`
    , `add_new_Permission`
    , `delete_permission`
    , `add_users_permission`, `edit_permisson`,role) " & " values
('" & Me.txt_username.Text.ToString & "', '" & Me.txt_full_name.Text.ToString & "' ,'" & GetHash(Me.txt_password.Text.ToString) & "','" & Me.cactive.Checked & "' ,'" & cprint.Checked & "','" & Cadd.Checked & "','" & cdelete.Checked & "','" & caddusers.Checked & "','" & cedit.Checked & "','" & Me.CmbRole.Text & "')"
        End If

        If txt_user_id.Text <> "" And btn_save.Text = "حفظ التعديل" Then

            sql = "update  tbl_users_data  set `username`='" & Me.txt_username.Text & "'
    , `name`='" & Me.txt_full_name.Text & "'
    , `password`='" & GetHash(Me.txt_password.Text.ToString) & "'
    , `enableded`='" & Me.cactive.Checked.ToString & "'
    , `print_permission`='" & Me.cprint.Checked.ToString & "'
    , `add_new_Permission`='" & Me.Cadd.Checked.ToString & "'
    , `delete_permission`='" & Me.cdelete.Checked.ToString & "'
    , `add_users_permission`='" & Me.caddusers.Checked.ToString & "', `role`='" & Me.CmbRole.Text & "', `edit_permisson`='" & Me.cedit.Checked.ToString & "'  where user_id = '" & Me.txt_user_id.Text & "'"


            Dim sure = MsgBox("هل تريد فعلا تعديل البيانات البيانات ؟", vbYesNo)
            If sure = vbNo Or txt_user_id.Text = 1 Then
                Exit Sub
            End If
        End If


        myconect_pool()




        With cmd
            .Connection = con
            .CommandText = sql
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MsgBox("لم تحفظ البيانات بعد")
                'archive Here
            Else
                If btn_save.Text = "حفظ" Then
                    MsgBox("تم حفظ البيانات")
                    trace("new user Name Has Been  Added :" & Me.txt_username.Text)

                    'archive Here
                Else
                    MsgBox("تم تعديل البيانات بنجاح")
                    trace("Edit : username " & Me.txt_username.Text & " Data Has Been Edited")

                    'archive Here

                End If

                clearing_fields()
                btn_add.Enabled = True
                btn_save.Enabled = False
                btn_save.Text = "حفظ"
                btn_cancel.Enabled = False
                Me.DataGridView1.Rows.Clear()

                Me.DataGridView1.Enabled = True
                con.Close()
                loading_full_userdata()
                Me.txt_full_name.Enabled = False
                Me.txt_username.Enabled = False
                Me.txt_password.Enabled = False
                Me.cactive.Enabled = False
                Me.Cadd.Enabled = False
                Me.caddusers.Enabled = False
                Me.cdelete.Enabled = False
                Me.cedit.Enabled = False
                Me.cprint.Enabled = False


            End If
        End With



    End Sub

    Private Sub st_bar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles st_bar.ItemClicked

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
