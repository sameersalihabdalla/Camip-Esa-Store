Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient


Module MdConnection
    Public ipAddress = Utils.GetIPv4Address

    Dim MysqlConn As New MySqlConnection
    Public con As MySqlConnection = myconn()
    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim da As New MySqlDataAdapter
    Dim dt As New DataTable
    Dim dReader As MySqlDataReader
    Public sql As String
    Public fullname As String
    Public username As String
    Public PrintPermisson As Boolean
    Public Add_usersPermission As Boolean
    Public AddPermission As Boolean
    Public EditPermisson As Boolean
    Public DeletePermisson As Boolean
    Public isActived As Boolean
    Public userid As Integer
    Public currentPassword
    Public currency_char_ar = "ج. س "
    Public account_type As String = ""
    Public qu_validation As String


    Public Sub myconect_pool()
        Try
            If con.State = ConnectionState.Open Then
                con.Close()
                con.Open()
            Else
                con.Open()
            End If
        Catch ex As Exception
            MsgBox("Failed to connect to the main server Check the network connection status")

        End Try


    End Sub

    Public Function myconn() As MySqlConnection


        Dim EncryptionKey As String = "SamSun"
        Dim serverip As String = passwordDecrypt(My.Settings.serverip, EncryptionKey)
        Dim dbusername As String = passwordDecrypt(My.Settings.dbusername, EncryptionKey)

        Dim dbname As String = passwordDecrypt(My.Settings.dbname, EncryptionKey)
        Dim dbpassword As String = passwordDecrypt(My.Settings.dbpassword, EncryptionKey)
        Dim dbport As String = passwordDecrypt(My.Settings.dbport, EncryptionKey)

        Return New MySqlConnection("server=" & serverip & ";user id=" & dbusername & ";port=3306;password='" & dbpassword & "';character set=utf8;database=" & dbname & ";")


    End Function


    Public Function GetHash(theInput As String) As String
        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function
End Module
