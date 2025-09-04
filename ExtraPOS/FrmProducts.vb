Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class FrmProducts


    Private Sub FrmCatogery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableLayoutPanel1.Enabled = False

        Gbx1.Enabled = False
        cmbMainCat.Enabled = True
        If con.State = ConnectionState.Open Then con.Close()
        myconect_pool()
        Dim sql As String = "select * from tbl_mainproducts_category where PCshow='true' "
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable

        myAdapter.SelectCommand = cmd
        myAdapter.Fill(myData)

        cmbMainCat.DisplayMember = "Text"
        cmbMainCat.ValueMember = "Value"
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        For Each drRow As DataRow In myData.Rows
            tb.Rows.Add(drRow.Item("PCName"), Val(drRow.Item("PCId")))



        Next
        cmbMainCat.DataSource = tb

        Me.cmbMainCat.SelectedIndex = 0

        con.Close()

        btn_add.Enabled = True
        btn_save.Enabled = False
        txt_pack_price.Enabled = False

        btn_save.Text = "حفظ"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txtcatname.Enabled = False
        Me.txt_cat_english.Enabled = False
        Me.txt_summary.Enabled = False
        Me.cactive.Enabled = False
        Me.cshow.Enabled = False
        txt_units.Enabled = False
        txt_price.Enabled = False
        txt_disc.Enabled = False
        TxtBuyPrice.Enabled = False
        Gbx2.Visible = False
        btnUnlock.Enabled = False
        btnLock.Enabled = True

        '  loading_full_data()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        cmbMainCat.Enabled = False
        Gbx1.Enabled = True
        btnUnlock.Enabled = True
        btnLock.Enabled = False
        Gbx2.Enabled = True
        Gbx2.Visible = True

        TableLayoutPanel1.Enabled = True
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
        txt_pack_price.Enabled = False
        txt_units.Enabled = False
        txt_price.Enabled = False
        txt_disc.Enabled = False
        loading_full_data()
        TxtBuyPrice.Enabled = False
        txt_tax.Enabled = False
        Txt_Barcode.Enabled = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        Gbx1.Enabled = False
        cmbMainCat.Enabled = True
        btnUnlock.Enabled = False
        TxtBuyPrice.Enabled = False

        btnLock.Enabled = True
        Gbx2.Enabled = False
        TableLayoutPanel1.Enabled = False
        loading_full_data()
        clearing_fields()
        Me.DataGridView1.Rows.Clear()
        Gbx2.Visible = False

    End Sub



    Sub loading_full_data()

        myconect_pool()

        Dim sql As String = "select * from tbl_products where mainProductsCatID='" & txt_id.Text & "'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader



        Try


            dReader = cmd.ExecuteReader()
            Do While dReader.Read = True
                Me.DataGridView1.Rows.Add(dReader(0), dReader(1), dReader(2), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7), dReader(8), dReader(9), dReader(10), dReader(11), dReader(14), dReader(12), dReader(13))
            Loop
            dReader.Close()

        Catch ex As Exception

        End Try
        con.Close()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)


    End Sub


    Sub fill_mydata()
        On Error Resume Next


        With Me.DataGridView1.CurrentRow
                Me.txt_cat_id.Text = .Cells(0).Value
                Me.txtcatname.Text = .Cells(1).Value
                Me.Gbx2.Text = "المنتج الحالي " & .Cells(1).Value
                Me.txt_cat_english.Text = .Cells(2).Value
                Me.txt_summary.Text = .Cells(6).Value
                txt_units.Text = .Cells(3).Value

                txt_pack_price.Text = .Cells(4).Value
                txt_price.Text = .Cells(5).Value
                txt_disc.Text = .Cells(9).Value
                Me.cactive.Checked = .Cells(10).Value
                Me.cshow.Checked = .Cells(11).Value
                Me.Txt_Barcode.Text = .Cells(12).Value
                Me.txt_tax.Text = .Cells(13).Value
                Me.TxtBuyPrice.Text = .Cells(14).Value
            End With


    End Sub
    Private Sub clearing_fields()
        Me.txt_cat_id.Text = ""
        Me.txtcatname.Text = ""
        Me.txt_cat_english.Text = ""
        Me.txt_summary.Text = ""
        Me.cactive.Checked = False
        Me.cshow.Checked = False
        txt_units.Text = ""
        txt_price.Text = ""
        TxtBuyPrice.Text = ""
        txt_disc.Text = ""
        txt_pack_price.Text = ""
        Txt_Barcode.Text = ""
        Me.Gbx2.Text = "المنتج الحالي "
        Me.TxtBuyPrice.Text = ""
        txt_tax.Text = ""
        Txt_Barcode.Text = ""


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






    Private Sub btn_close_Click_1(sender As Object, e As EventArgs)
        Close()
    End Sub





    Private Sub cmbMainCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMainCat.SelectedIndexChanged
        txt_id.Text = cmbMainCat.SelectedValue
        DataGridView1.Rows.Clear()


        clearing_fields()

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clearing_fields()
        fill_mydata()

    End Sub



    Private Sub txt_pack_price_TextChanged(sender As Object, e As EventArgs) Handles txt_pack_price.TextChanged
        Try

            Dim X = Val(txt_pack_price.Text) / Val(txt_units.Text)
            txt_price.Text = Math.Round(X, 2)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_units_TextChanged(sender As Object, e As EventArgs) Handles txt_units.TextChanged
        Try

            Dim X = Val(txt_pack_price.Text) / Val(txt_units.Text)
            txt_price.Text = Math.Round(X, 2)

        Catch ex As Exception

        End Try

    End Sub



    Private Sub FrmCatogery_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim x = txt_cat_id.Text
        Dim sure = MsgBox("هل تريد االفئة " & Me.txtcatname.Text, vbYesNo, "")
        If sure = vbYes Then
            myconect_pool()

            If x <> "" Then
                Dim sql As String = "delete from tbl_products where pid='" & x & "'"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("تم الحذف بنجاح", vbInformation)
                con.Close()
                clearing_fields()
                btn_add.Enabled = True
                btn_save.Enabled = False
                btn_save.Text = "حفظ"
                btn_cancel.Enabled = False
                Me.DataGridView1.Enabled = True
                Me.DataGridView1.Rows.Clear()
                loading_full_data()
            Else
                MsgBox("يرجى تحديد الفئة  المراد حذفها")
            End If
        Else
            clearing_fields()
            btn_add.Enabled = True
            btn_save.Enabled = False
            btn_save.Text = "حفظ"
            btn_cancel.Enabled = False
            Me.DataGridView1.Enabled = True
            Me.DataGridView1.Rows.Clear()
            Me.txtcatname.Enabled = False
            Me.Txt_Barcode.Enabled = False

            Me.txt_cat_english.Enabled = False
            Me.txt_summary.Enabled = False
            Me.cactive.Enabled = False
            Me.cshow.Enabled = False
            txt_pack_price.Enabled = False
            txt_units.Enabled = False
            txt_price.Enabled = False
            txt_tax.Enabled = False
            TxtBuyPrice.Enabled = False
            txt_disc.Enabled = False
            loading_full_data()
        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Me.DataGridView1.Enabled = False
        Me.btn_add.Enabled = False
        Me.btn_delete.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_save.Text = "حفظ التعديل"
        Me.btn_cancel.Enabled = True
        txt_disc.Enabled = True
        txt_pack_price.Enabled = True
        Txt_Barcode.Enabled = True
        Me.txtcatname.Enabled = True
        Me.txt_cat_english.Enabled = True
        Me.txt_summary.Enabled = True
        Me.cactive.Enabled = True
        Me.cshow.Enabled = True
        txt_units.Enabled = True
        TxtBuyPrice.Enabled = True
        txt_tax.Enabled = True

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        clearing_fields()
        Me.DataGridView1.Rows.Clear()
        Me.DataGridView1.Enabled = False
        txt_pack_price.Enabled = True
        Me.btn_add.Enabled = False
        Me.btn_save.Enabled = True
        Me.btn_cancel.Enabled = True
        Me.txtcatname.Focus()
        Me.txtcatname.Enabled = True
        Me.txt_cat_english.Enabled = True
        Me.txt_summary.Enabled = True
        Me.cactive.Enabled = True
        Me.Txt_Barcode.Enabled = True
        Me.cshow.Enabled = True
        TxtBuyPrice.Enabled = True
        txt_units.Enabled = True
        txt_tax.Enabled = True
        txt_disc.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        myconect_pool()

        If Me.txtcatname.Text = "" Then
            MsgBox("يرجى ادخال ام المننج")
            Exit Sub
        End If
        If Me.txt_cat_english.Text = "" Then
            MsgBox("يرجى تحديد الاسم الانجليزي")
            Exit Sub

        End If

        If txt_cat_id.Text = "" And btn_save.Text = "حفظ" Then
            Dim cmd As New MySqlCommand
            Dim result As Integer
            Dim sql As String = "insert tbl_products(
    `pnamearabic`
    , `pnameenglish`
    , `parts`
    , `price`
    , `unitprice`
    , `summary`
    , `mainProductsCatID`
    , `mainProductsCatName`
    , `discount`
    , `PCActive`
    , `PCShow`,`Ptax`,`barcode`,`PBprice`)  values
('" & Me.txtcatname.Text & "', '" & Me.txt_cat_english.Text & "' ," & Me.txt_units.Text & "," & txt_pack_price.Text & "," & Me.txt_price.Text & " ,'" & txt_summary.Text & "'," & txt_id.Text & ",'" & Me.cmbMainCat.Text & "'," & Me.txt_disc.Text & ",'" & Me.cactive.Checked.ToString & "','" & cshow.Checked.ToString & "'," & txt_tax.Text & ",'" & Txt_Barcode.Text & "'," & TxtBuyPrice.Text & ")"
            cmd.Connection = con
            cmd.CommandText = sql
            result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("لم تحفظ البيانات بعد")
                Else

                    MsgBox("تم حفظ البيانات")

                End If
End If


        If txt_cat_id.Text <> "" And btn_save.Text = "حفظ التعديل" Then
            Try


                Dim cmd As New MySqlCommand
                Dim result As Integer
                Dim sql As String = "update tbl_products  set  `pnamearabic`='" & Me.txtcatname.Text & "'
    , `pnameenglish`='" & Me.txt_cat_english.Text & "'
    ,`parts`=" & Me.txt_units.Text & "
    ,  `price`=" & txt_pack_price.Text & "
    ,  `unitprice`=" & Me.txt_pack_price.Text & "
    ,  `summary`='" & Me.txt_pack_price.Text & "'
, `mainProductsCatID`=" & Me.txt_id.Text & "
, `mainProductsCatName`='" & Me.cmbMainCat.Text & "'
,`discount`=" & Me.txt_disc.Text & "
, `PCActive`='" & cactive.Checked & "'
, `PCShow`='" & cshow.Checked & "'
,`Ptax`=" & Me.txt_tax.Text & "
,`barcode`='" & Me.Txt_Barcode.Text & "'
,`PBprice`=" & Me.TxtBuyPrice.Text & "   where pid = " & Me.txt_cat_id.Text & ";"

                Dim sure = MsgBox("هل تريد فعلا تعديل البيانات البيانات ؟", vbYesNo)
                If sure = vbNo Then
                    Exit Sub
                End If

                cmd.Connection = con
                cmd.CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("لم تحفظ البيانات بعد")
                Else

                    MsgBox("تم حفظ البيانات")

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If










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
        txt_tax.Enabled = False
        clearing_fields()
        txt_disc.Enabled = True
        con.Close()
        loading_full_data()







    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        clearing_fields()
        btn_add.Enabled = True
        btn_save.Enabled = False
        btn_save.Text = "حفظ"
        btn_cancel.Enabled = False
        Me.DataGridView1.Enabled = True
        Me.DataGridView1.Rows.Clear()
        Me.txtcatname.Enabled = False
        Me.Txt_Barcode.Enabled = False

        Me.txt_cat_english.Enabled = False
        Me.txt_summary.Enabled = False
        Me.cactive.Enabled = False
        Me.cshow.Enabled = False
        txt_pack_price.Enabled = False
        txt_units.Enabled = False
        txt_price.Enabled = False
        txt_tax.Enabled = False
        TxtBuyPrice.Enabled = False
        txt_disc.Enabled = False
        loading_full_data()
    End Sub

    Private Sub btn_close_Click_2(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class