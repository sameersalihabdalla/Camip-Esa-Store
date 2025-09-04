
Public Class FrmServerSettings




    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim EncryptionKey As String = "SamSun"
        Dim eStr As String = passwordEncrypt(Me.txtServerHost.Text, EncryptionKey)
        'MessageBox.Show(eStr)
        Dim dStr As String = passwordDecrypt(eStr, EncryptionKey)
        'MessageBox.Show(dStr)

        Try
            My.Settings.serverip = passwordEncrypt(Me.txtServerHost.Text, EncryptionKey)
            My.Settings.dbusername = passwordEncrypt(Me.txtUserName.Text, EncryptionKey)
            My.Settings.dbname = passwordEncrypt(Me.txtDatabase.Text, EncryptionKey)
            My.Settings.dbpassword = passwordEncrypt(Me.txtPassword.Text, EncryptionKey)
            My.Settings.dbport = passwordEncrypt(Me.txtPort.Text, EncryptionKey)
            My.Settings.Save()

            Me.Close()



        Catch ex As Exception

        End Try

    End Sub

    Private Sub FrmServerSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim EncryptionKey As String = "SamSun"
            Dim serverip As String = passwordDecrypt(My.Settings.serverip, EncryptionKey)
        Dim dbusername As String = passwordDecrypt(My.Settings.dbusername, EncryptionKey)

        Dim dbname As String = passwordDecrypt(My.Settings.dbname, EncryptionKey)
        Dim dbpassword As String = passwordDecrypt(My.Settings.dbpassword, EncryptionKey)
        Dim dbport As String = passwordDecrypt(My.Settings.dbport, EncryptionKey)

        Me.txtUserName.Text = dbusername
            Me.txtServerHost.Text = serverip
            Me.txtPort.Text = dbport
        Me.txtPassword.Text = "" ' dbpassword
        Me.txtDatabase.Text = "" 'dbname

    End Sub



    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        FrmBackupDb.Show()
        Me.Close()
    End Sub
End Class
