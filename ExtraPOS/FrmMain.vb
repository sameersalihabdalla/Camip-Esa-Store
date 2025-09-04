Imports MySql.Data.MySqlClient

Public Class FrmMain

    Sub menus()


        If account_type = "Administrative" Then
            MenuPOS.Enabled = True

        ElseIf account_type = "direct sales employee" Then

            MenuPOS.Enabled = True
        ElseIf account_type = "cashier sales employee" Then
            MenuPOS.Enabled = False
        ElseIf account_type = "accountant" Then
            MenuPOS.Enabled = True
        ElseIf account_type = "sales revenue" Then
            MenuPOS.Enabled = True
        ElseIf account_type = "HR Officer" Then
            MenuPOS.Enabled = False
        ElseIf account_type = "store manager" Then
            MenuPOS.Enabled = True
        ElseIf account_type = "Stock manager" Then

            MenuPOS.Enabled = False

        End If


    End Sub
    Dim counter As Integer = 0

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myconect_pool()
        Dim sql2 = "select * from tbl_settings where id=1"
        Dim cmd2 As New MySql.Data.MySqlClient.MySqlCommand(sql2, con)
        Dim dReader2 As MySqlDataReader
        dReader2 = cmd2.ExecuteReader()
        If dReader2.Read = True Then
            store_name_arabic = dReader2(1).ToString
            store_name_en = dReader2(2).ToString
            qu_validation = dReader2(12)
        End If
        dReader2.Close()
        con.Close()
        myinformation.Text = store_name_arabic & " | Powered By Sameer Salih "
        menus()
        susername.Text = fullname
        sprint.Enabled = PrintPermisson
        sadd.Enabled = AddPermission
        sedit.Enabled = EditPermisson
        saddusers.Enabled = Add_usersPermission
        susername.Enabled = isActived
        sdelete.Enabled = DeletePermisson
        If Add_usersPermission = False Then MenuUsers.Enabled = False
        Timer1.Interval = 100
        Timer1.Start()
    End Sub

    Private Sub MenuUsers_Click(sender As Object, e As EventArgs) Handles MenuUsers.Click
        trace("Open users Management window")

        FrmusersManagement.ShowDialog()
    End Sub

    Private Sub MenuPOS_Click(sender As Object, e As EventArgs) Handles MenuPOS.Click
        trace("Open POS | Direct Sells | Point Of Sales")

        FRMPOS.ShowDialog()


    End Sub

    Private Sub MenuCangePassowrd_Click(sender As Object, e As EventArgs) Handles MenuCangePassowrd.Click
        trace("Open Change Password Window")

        FrmChangePassword.ShowDialog()
    End Sub

    Private Sub MenuMainProductsCategory_Click(sender As Object, e As EventArgs) Handles MenuMainProductsCategory.Click
        FrmMainProductsCategory.ShowDialog()
        trace("Open Products Categoery")
    End Sub

    Private Sub MenuPCSub_Click(sender As Object, e As EventArgs) Handles MenuPCSub.Click
        FrmProducts.ShowDialog()
        trace("Open Products")
    End Sub

    Private Sub menuMyStoreSettings_Click(sender As Object, e As EventArgs) Handles menuMyStoreSettings.Click
        FrmStoreSettings.ShowDialog()
        trace("Open Store Settings window")
    End Sub

    Private Sub حToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حToolStripMenuItem.Click
        FrmAbout.ShowDialog()

    End Sub





    Private Sub MenuStock_Click(sender As Object, e As EventArgs)
        FrmStockQuantaties.ShowDialog()
    End Sub

    Private Sub MnuBarcode_Click(sender As Object, e As EventArgs) Handles MnuBarcode.Click
        FrmBarcode.ShowDialog()
    End Sub

    Private Sub MnuReportUsersSales_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        myconect_pool()

        counter = counter + 1
        If counter <= 60 Then
            Try


                Dim sql As String = "select count(transaction_id) as c, sum(t_cost) as s from tbl_transactions where t_username ='" & username & "' and t_date='" & Format(Now, "yyy-MM-dd") & "';"
                Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
                Dim dReader As MySqlDataReader

                dReader = cmd.ExecuteReader()

                If dReader.Read Then
                    Lbl_operations_count.Text = dReader(0)
                    If dReader(1).ToString = "" Then
                        Lbl_total_cost.Text = "0.0" & " " & currency_char_ar

                    Else
                        Lbl_total_cost.Text = Format(dReader(1), "###,##.00") & " " & currency_char_ar
                    End If


                    dReader.Dispose()

                End If
            Catch ex As Exception

            End Try




            Dim sql2 As String = "select count(transactions_details_id) as c, sum(t_quantity) as s from tbl_transactions_details where t_username ='" & username & "' and t_date='" & Format(Now, "yyy-MM-dd") & "';"
            Dim cmd2 As New MySql.Data.MySqlClient.MySqlCommand(sql2, con)
            Dim dReader2 As MySqlDataReader

            Try


                dReader2 = cmd2.ExecuteReader()

                If dReader2.Read Then
                    Lbl_count_p.Text = dReader2(0)
                    Lbl_all_prod.Text = dReader2(1)
                    dReader2.Dispose()

                End If

            Catch ex As Exception

            End Try








        Else
            counter = 0

        End If

    End Sub

    Private Sub Mnu_P_Wins_report_Click(sender As Object, e As EventArgs) Handles Mnu_P_Wins_report.Click
        FrmProductWin.ShowDialog()

    End Sub

    Private Sub MnuProductsAdded_Click(sender As Object, e As EventArgs) Handles MnuProductsAdded.Click
        FrmStockQAdded.ShowDialog()
    End Sub

    Private Sub MnuReportSales_Click(sender As Object, e As EventArgs) Handles MnuReportSales.Click
        FrmSalesFullReport.ShowDialog()

    End Sub

    Private Sub MnuSellersReport_Click(sender As Object, e As EventArgs) Handles MnuSellersReport.Click
        FrmRepUsersSales.ShowDialog()

    End Sub

    Private Sub MnuUsersTrace_Click(sender As Object, e As EventArgs) Handles MnuUsersTrace.Click
        FrmTraceUsers.ShowDialog()

    End Sub


    Private Sub mnuStockStatus_Click(sender As Object, e As EventArgs) Handles mnuStockStatus.Click
        Try
            FrmQuantatyStatus.ShowDialog()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub MnuProductsQuantaty_Click(sender As Object, e As EventArgs) Handles MnuProductsQuantaty.Click
        FrmStockQuantaties.ShowDialog()

    End Sub


    Private Sub MnuCenteralCollection_Click_1(sender As Object, e As EventArgs) Handles MnuCenteralCollection.Click
        FrmCollectionCashier.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        FrmCancelOperation1.ShowDialog()

    End Sub
End Class
