Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Module MdFunctions

    Public store_name_arabic
    Public store_name_en

    Sub trace(ByVal operation)
        Dim cmdd As New MySqlCommand
        Dim resultt As Integer
        Dim sqll As String = ""

        Dim c_time = Format(Now, "HH:mm:ss")
        Dim c_date = Format(Now, "yyy-MM-dd")

        sqll = "insert into tbl_user_trace ( `trace_time` , `trace_date`, `main_operation`, `user_id`, `user_name`)  values
( '" & c_time & "' ,'" & c_date & "','" & operation & "' ," & userid & ",'" & username & "')"

        myconect_pool()

        With cmdd
            .Connection = con
            .CommandText = sqll
            resultt = cmdd.ExecuteNonQuery
        End With

        cmdd.Dispose()

    End Sub

    Public Function passwordEncrypt(ByVal inText As String, ByVal key As String) As String
        Dim bytesBuff As Byte() = Encoding.Unicode.GetBytes(inText)
        Using aes__1 As Aes = Aes.Create()
            Dim crypto As New Rfc2898DeriveBytes(key, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            aes__1.Key = crypto.GetBytes(32)
            aes__1.IV = crypto.GetBytes(16)
            Using mStream As New MemoryStream()
                Using cStream As New CryptoStream(mStream, aes__1.CreateEncryptor(), CryptoStreamMode.Write)
                    cStream.Write(bytesBuff, 0, bytesBuff.Length)
                    cStream.Close()
                End Using
                inText = Convert.ToBase64String(mStream.ToArray())
            End Using
        End Using
        Return inText
    End Function
    'Decrypting a string
    Public Function passwordDecrypt(ByVal cryptTxt As String, ByVal key As String) As String
        cryptTxt = cryptTxt.Replace(" ", "+")
        Dim bytesBuff As Byte() = Convert.FromBase64String(cryptTxt)
        Using aes__1 As Aes = Aes.Create()
            Dim crypto As New Rfc2898DeriveBytes(key, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            aes__1.Key = crypto.GetBytes(32)
            aes__1.IV = crypto.GetBytes(16)
            Using mStream As New MemoryStream()
                Using cStream As New CryptoStream(mStream, aes__1.CreateDecryptor(), CryptoStreamMode.Write)
                    cStream.Write(bytesBuff, 0, bytesBuff.Length)
                    cStream.Close()
                End Using
                cryptTxt = Encoding.Unicode.GetString(mStream.ToArray())
            End Using
        End Using
        Return cryptTxt
    End Function



End Module
