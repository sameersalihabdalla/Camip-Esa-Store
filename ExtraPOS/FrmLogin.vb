Imports System.Security
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class FrmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Then
            MsgBox("Enter Username")
            UsernameTextBox.Focus()
            Media.SystemSounds.Exclamation.Play()

            Exit Sub
        End If
        If PasswordTextBox.Text = "" Then
            MsgBox("Enter Password")
            Media.SystemSounds.Exclamation.Play()
            PasswordTextBox.Focus()
            Exit Sub
        End If
        Dim sql As String = "select*from  tbl_users_data where username='" & Me.UsernameTextBox.Text & "' and password='" & GetHash(Me.PasswordTextBox.Text.ToString) & "'"
        Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
        Dim dReader As MySqlDataReader
        Try
            myconect_pool()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("There was a connection error.")
            Console.Beep(3000, 100)
            Exit Sub
        End Try


        Try
            dReader = cmd.ExecuteReader()
            '  Do While dReader.Read = True
            ' Me.DataGridView1.Rows.Add(dReader(0), dReader(2), dReader(1), dReader(3), dReader(4), dReader(5), dReader(6), dReader(7), dReader(8), dReader(9))
            'Loop
            If dReader.Read Then
                userid = dReader(0)
                username = dReader(1)
                currentPassword = dReader(3)
                fullname = dReader(2)
                PrintPermisson = dReader(5)
                isActived = dReader(4)
                DeletePermisson = dReader(7)
                EditPermisson = dReader(9)
                AddPermission = dReader(6)
                Add_usersPermission = dReader(8)

                account_type = dReader(10)
                trace("Login Successfuly  : UserName is :" & username)
                If isActived = True Then
                    Media.SystemSounds.Hand.Play()
                    cmd.Dispose()
                    dReader.Dispose()
                    con.Close()




                    FrmMain.Show()
                    Me.Close()

                End If

            Else
                Console.Beep(3000, 100)
                MsgBox("Unable to access..You may have entered incorrect login information")
                trace("Login Error")

                UsernameTextBox.Focus()
            End If
            dReader.Close()
        Catch ex As Exception
        End Try
        con.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        FrmServerSettings.Show()
        Me.Close()
    End Sub
End Class
