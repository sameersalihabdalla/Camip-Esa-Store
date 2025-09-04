Imports MySql.Data.MySqlClient

Public NotInheritable Class FrmInvoices

    Private Sub Frm_invoices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            '   Me.CrystalReportViewer1.PrintReport()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub crv_Load(sender As Object, e As EventArgs) Handles crv.Load

    End Sub
End Class
