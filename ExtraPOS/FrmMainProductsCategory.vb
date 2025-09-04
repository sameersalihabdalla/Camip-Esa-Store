Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmMainProductsCategory



    Sub loading_full_data()
        If con.State = ConnectionState.Open Then con.Close()
        Try
            myconect_pool()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("حدث خطأ ما في الاتصال")
            Exit Sub
        End Try
        Dim sql As String = "select * from tbl_mainproducts_category"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader



        Try


            dReader = cmd.ExecuteReader()
            Do While dReader.Read = True
                Me.DataGridView1.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5))
            Loop
            dReader.Close()

        Catch ex As Exception

        End Try
        con.Close()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)


    End Sub


    Sub fill_mydata()
        Try
            With Me.DataGridView1.CurrentRow
                Me.txt_cat_id.Text = .Cells(0).Value
                Me.txtcatname.Text = .Cells(1).Value
                Me.GroupBox2.Text = "الفئة الحالية " & .Cells(1).Value
                Me.txt_cat_english.Text = .Cells(2).Value
                Me.txt_summary.Text = .Cells(3).Value
                Me.cactive.Checked = .Cells(4).Value
                Me.cshow.Checked = .Cells(5).Value

            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub clearing_fields()
        Me.txt_cat_id.Text = ""
        Me.txtcatname.Text = ""
        Me.txt_cat_english.Text = ""
        Me.txt_summary.Text = ""
        Me.cactive.Checked = False
        Me.cshow.Checked = False

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clearing_fields()
        fill_mydata()

    End Sub





    Private Sub txt_user_id_TextChanged(sender As Object, e As EventArgs) Handles txt_cat_id.TextChanged
        If txt_cat_id.Text = "" Then
            btn_edit.Enabled = False
            btn_delete.Enabled = False
        Else
            btn_edit.Enabled = True
            btn_delete.Enabled = True


        End If
    End Sub







    Private Sub FrmMainProductsCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "حفظ"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txtcatname.Enabled = False
        Me.txt_cat_english.Enabled = False
        Me.txt_summary.Enabled = False
        Me.cactive.Enabled = False
        Me.cshow.Enabled = False
        loading_full_data()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_add.Click
        clearing_fields()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Enabled = False

        Me.btn_add.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_cancel.Enabled = True
        Me.txtcatname.Focus()
        Me.txtcatname.Enabled = True
        Me.txt_cat_english.Enabled = True
        Me.txt_summary.Enabled = True
        Me.cactive.Enabled = True
        Me.cshow.Enabled = True
    End Sub

    Private Sub btn_save_Click_1(sender As Object, e As EventArgs) Handles btn_save.Click
        If txtcatname.Text = "" Or txt_cat_english.Text = "" Or txt_summary.Text = "" Then
            MsgBox("يرجى تعبئة جميع الحقول ببيانات صحيحة و صالحة ", vbInformation)
            Exit Sub


        End If
        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim sql As String = ""

        If txt_cat_id.Text = "" And btn_save.Text = "حفظ" Then
            sql = "insert tbl_mainproducts_category (
     `PCName`
    , `PCNameEnglish`
    , `PCSummary`
    , `PCActive`
    , `PCShow`) " & " values
('" & Me.txtcatname.Text & "', '" & Me.txt_cat_english.Text & "' ,'" & Me.txt_summary.Text & "','" & Me.cactive.Checked & "' ,'" & Me.cshow.Checked & "')"
        End If

        If txt_cat_id.Text <> "" And btn_save.Text = "حفظ التعديل" Then

            sql = "update tbl_mainproducts_category  set  `PCName`='" & Me.txtcatname.Text & "'
    , `PCNameEnglish`='" & Me.txt_cat_english.Text & "'
    ,`PCSummary`='" & Me.txt_summary.Text & "'
    ,  `PCActive`='" & Me.cactive.Checked & "'
    ,  `PCShow`='" & Me.cshow.Checked & "' where PCid = '" & Me.txt_cat_id.Text & "'"


            Dim sure = MsgBox("هل تريد فعلا تعديل البيانات البيانات ؟", vbYesNo)
            If sure = vbNo Or txt_cat_id.Text = 1 Then
                Exit Sub
            End If
        End If

        Try
            If con.State = ConnectionState.Open Then con.Close()
            myconect_pool()
            With cmd
                .Connection = con
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("لم تحفظ البيانات بعد")
                Else
                    If btn_save.Text = "حفظ" Then
                        MsgBox("تم حفظ البيانات")
                    Else
                        MsgBox("تم تعديل البيانات بنجاح")

                    End If

                    clearing_fields()
                    btn_add.Enabled = True
                    btn_save.Enabled = False
                    btn_save.Text = "حفظ"
                    btn_cancel.Enabled = False
                    Me.DataGridView1.Rows.Clear()
                    Me.txtcatname.Enabled = False
                    Me.txt_cat_english.Enabled = False
                    Me.txt_summary.Enabled = False
                    Me.cactive.Enabled = False
                    Me.cshow.Enabled = False
                    Me.DataGridView1.Enabled = True
                    con.Close()
                    ' loading_full_data()


                End If
            End With
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally


        End Try

    End Sub

    Private Sub btn_cancel_Click_1(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clearing_fields()
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "حفظ"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txtcatname.Enabled = False
        Me.txt_cat_english.Enabled = False
        Me.txt_summary.Enabled = False
        Me.cactive.Enabled = False
        Me.cshow.Enabled = False
        loading_full_data()
    End Sub

    Private Sub btn_close_Click_1(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()
    End Sub

    Private Sub btn_edit_Click_1(sender As Object, e As EventArgs) Handles btn_edit.Click
        Me.DataGridView1.Enabled = False
        Me.btn_add.Enabled = False
        Me.btn_delete.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_save.Text = "حفظ التعديل"
        Me.btn_cancel.Enabled = True

        Me.btn_edit.Enabled = False
        Me.txtcatname.Enabled = True
        Me.txt_cat_english.Enabled = True
        Me.txt_summary.Enabled = True
        Me.cactive.Enabled = True
        Me.cshow.Enabled = True


    End Sub

    Private Sub btn_delete_Click_1(sender As Object, e As EventArgs) Handles btn_delete.Click


        Dim sure = MsgBox("هل تريد االفئة " & Me.txtcatname.Text, vbYesNo, "")
        If sure = vbYes Then
            If con.State = ConnectionState.Open Then con.Close()
            myconect_pool()
            If Me.txt_cat_id.Text <> "" Then
                Dim sql As String = "delete from tbl_mainproducts_category where PCid='" & Me.txt_cat_id.Text & "'"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)

                Try
                    cmd.ExecuteNonQuery()

                    cmd.Dispose()
                    MsgBox("تم الحذف بنجاح", vbInformation)
                    clearing_fields()
                    btn_add.Enabled = True
                    btn_save.Enabled = False
                    btn_save.Text = "حفظ"
                    btn_cancel.Enabled = False
                    Me.DataGridView1.Enabled = True
                    Me.DataGridView1.Rows.Clear()
                    con.Close()
                    loading_full_data()




                Catch ex As Exception

                End Try
            Else

                MsgBox("يرجى تحديد الفئة المراد حذفها")
            End If

        End If

    End Sub


End Class
