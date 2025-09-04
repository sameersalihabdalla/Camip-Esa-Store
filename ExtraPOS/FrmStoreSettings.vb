Imports System.IO
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FrmStoreSettings



    Private Sub FrmMyStoreSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim InstalledPrinters As String

            ' Find all printers installed
            For Each InstalledPrinters In
             System.Drawing.Printing.PrinterSettings.InstalledPrinters
                Me.cmbPrinterOne.Items.Add(InstalledPrinters)
                Me.cmbPrintertwo.Items.Add(InstalledPrinters)
            Next InstalledPrinters



        Catch ex As Exception
        Finally
            cmbPrinterOne.Text = My.Settings.invoices_printer
            cmbPrintertwo.Text = My.Settings.report_printer
            Dim sql As String = "select * from tbl_settings"
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, con)
            Dim dReader As MySqlDataReader
            myconect_pool()
            dReader = cmd.ExecuteReader()
            If dReader.Read = True Then
                txt_store_name_ar.Text = dReader(1).ToString
                txt_store_name_en.Text = dReader(2).ToString
                txt_currency_ar.Text = dReader(3).ToString
                txt_currency_en.Text = dReader(4).ToString
                txt_currency_char__ar.Text = dReader(5).ToString
                txt_currncy_char_en.Text = dReader(6).ToString
                txt_phone.Text = dReader(11).ToString
                Me.cmbPrinterOne.SelectedText = dReader(9).ToString
                Me.cmbPrintertwo.SelectedText = dReader(9).ToString
                If dReader(12) = True Then
                    r1.Checked = True
                Else
                    r2.Checked = True

                End If


                Dim bytes As [Byte]() = dReader(7)
                    Dim ms As New MemoryStream(bytes)

                    Dim bytes2 As [Byte]() = dReader(8)
                    Dim ms2 As New MemoryStream(bytes2)

                ' pb.Image = Image.FromStream(ms)
                ' pb2.Image = Image.FromStream(ms2)

            End If
                dReader.Close()
            con.Close()


        End Try
        ' Set the combo to the first printer in the list


    End Sub


    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Close()

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pb.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

        Dim ofd As New OpenFileDialog
        ofd.Filter = "PNG|*.PNG" 'If you like file type filters you can add them here
        'any other modifications to the dialog
        ' If ofd.ShowDialog = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Try
            Dim bmp As New Bitmap(ofd.FileName)
            If Not IsNothing(pb.Image) Then pb.Image.Dispose() 'Optional if you want to destroy the previously loaded image
            pb.Image = bmp
        Catch
            MsgBox("Not a valid image file.")
        End Try
        If pb.Image.Size.Width.ToString <> "128" And pb.Image.Size.Height.ToString <> "128" Then
            pb.Image = Nothing


        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            pb2.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

        Dim ofd As New OpenFileDialog
        ofd.Filter = "PNG|*.png|JPEG|*.jpg" 'If you like file type filters you can add them here
        'any other modifications to the dialog
        Try
            Dim bmp As New Bitmap(ofd.FileName)
            If Not IsNothing(pb2.Image) Then pb2.Image.Dispose() 'Optional if you want to destroy the previously loaded image
            pb2.Image = bmp
        Catch
            MsgBox("Not a valid image file.")
        End Try
        If pb2.Image.Size.Width.ToString <> "597" And pb2.Image.Size.Height.ToString <> "111" Then
            pb2.Image = Nothing


        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)




        Dim cmd As New MySqlCommand
        Dim result As Integer


        Dim mstream As New System.IO.MemoryStream()
        pb.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
        Dim arrImage() As Byte = mstream.GetBuffer()



        Dim mstream2 As New System.IO.MemoryStream()
        pb2.Image.Save(mstream2, System.Drawing.Imaging.ImageFormat.Png)
        Dim arrImage2() As Byte = mstream2.GetBuffer()





        mstream.Close()



        Dim sql As String
        sql = "update tbl_settings  set `logo`=@File,`banner`=@banner"


        Dim sure = MsgBox("هل تريد فعلا حفظ البيانات ؟", vbYesNo + vbInformation + vbMsgBoxRtlReading + vbMsgBoxRight, "الحفظ")
        If sure = vbNo Then
            Exit Sub
        End If


        Try
            myconect_pool()
            With cmd
                .Connection = con
                .CommandText = sql
                .Parameters.AddWithValue("@File", arrImage)
                .Parameters.AddWithValue("@banner", arrImage2)
            End With

            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MsgBox("لم تحفظ البيانات بعد")
            Else
                MsgBox("تم حفظ البيانات بنجاح")
            End If


            con.Close()
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally


        End Try
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try

            If  cmbPrinterOne.Text <>"" Or cmbPrintertwo .Text <> "" Then
                My.Settings.invoices_printer = cmbPrinterOne.Text
                My.Settings.report_printer = cmbPrintertwo.Text

                My.Settings.Save()
                MsgBox("تم حفظ الطابعات ")
            Else
                MsgBox("يرجى تحديد الطابعات")
            End If


        Catch ex As Exception
            MsgBox("لم يكتمل الحفظ")
        End Try



    End Sub


    Private Function OpenFile() As String
        'build and configure an OpenFileDialog
        Dim OFD As New OpenFileDialog
        With OFD
            .AddExtension = True
            .CheckFileExists = True
            .Filter = "PNG|*.png|JPEG|*.jpg"
            .Multiselect = False
            .Title = "Select an Image to Upload"
        End With

        'show the ofd and if a file was selected return it, otherwise return nothing
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return OFD.FileName
        Else
            Return Nothing
        End If
    End Function

    Private Sub btn_update_basic_data_Click(sender As Object, e As EventArgs) Handles btn_update_basic_data.Click
        trace("Open Store Settings - Update ")
        Dim cmd As New MySqlCommand
        Dim result As Integer
        Dim sql As String
        sql = "update tbl_settings  set `store_name_ar`=@d1,`store_name_en`=@d2,`store_currency_ar`=@d3,`store_currency_en`=@d4,`store_currency_char_ar`=@d5,`sore_currency_char_en`=@d6,`phone`=@d7,`qu_validation`=@d8"
        Dim sure = MsgBox("هل تريد الحفظ؟", vbYesNo)
        If sure = vbNo Then
            Exit Sub
        End If
        Try
            myconect_pool()
            With cmd
                .Connection = con
                .CommandText = sql
                .Parameters.AddWithValue("@d1", Me.txt_store_name_ar.Text.ToString)
                .Parameters.AddWithValue("@d2", Me.txt_store_name_en.Text.ToString)
                .Parameters.AddWithValue("@d3", Me.txt_currency_ar.Text.ToString)
                .Parameters.AddWithValue("@d4", Me.txt_currency_en.Text.ToString)
                .Parameters.AddWithValue("@d5", Me.txt_currency_char__ar.Text.ToString)
                .Parameters.AddWithValue("@d6", Me.txt_currncy_char_en.Text.ToString)
                .Parameters.AddWithValue("@d7", Me.txt_phone.Text.ToString)
                .Parameters.AddWithValue("@d8", r1.Checked.ToString)
            End With
            If r1.Checked = True Then
                qu_validation = "True"
            Else
                qu_validation = "False"

            End If
            result = cmd.ExecuteNonQuery
            If result = 0 Then
                MsgBox("لم تحفظ البيانات بعد")
                trace("Update : Sotre Settings Update Failed ....")
            Else
                MsgBox("Update : Store Settings Update Successfull")
            End If
            con.Close()
        Catch ex As Exception
            If con.State = ConnectionState.Open Then con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        Finally
        End Try



    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles r1.CheckedChanged

    End Sub
End Class
