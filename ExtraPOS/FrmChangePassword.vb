Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmChangePassword



    Private Sub FrmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Text = fullname
        Me.txtCurrentUsername.Text = username

    End Sub

    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Dim cmd As New MySqlCommand
        Dim result As Integer

        If txtNewPasword.Text = "" Or txtCurrentPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MsgBox("يرجى تعبئة الحقول")
            Media.SystemSounds.Exclamation.Play()

            Exit Sub
        End If
        If currentPassword <> GetHash(Me.txtCurrentPassword.Text) Then
            MsgBox("كلمة المرور الحالية خاطئة ")
            trace("Password Change : Current Password Error")
            Media.SystemSounds.Exclamation.Play()
            txtCurrentPassword.Focus()
            Exit Sub
        End If

        If txtNewPasword.Text <> txtConfirmPassword.Text Then
            MsgBox("كلمة المرور الجديدة غير مطابقة للتأكيد")
            txtNewPasword.Focus()
            Media.SystemSounds.Exclamation.Play()
            Exit Sub

        End If
        Dim sql As String = "update  tbl_users_data  set `password`='" & GetHash(Me.txtConfirmPassword.Text) & "'" & " where user_id = '" & userid & "'"

        Media.SystemSounds.Exclamation.Play()
        Dim sure = MsgBox("هل تريد فعلا تغيير كلمة المرور ؟", vbYesNo)
        If sure = vbNo Then
            Exit Sub
        End If


        Try
            myconect_pool()
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MsgBox("لم تحفظ البيانات بعد")
                trace("Change Password - Failure")
                Console.Beep(2000, 300)


            Else
                MsgBox("تم حفظ كلمة المرور الجديدة")
                trace("Change Password - Success")
                Console.Beep(2000, 300)

            End If


                con.Close()
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally


        End Try


    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub
End Class
