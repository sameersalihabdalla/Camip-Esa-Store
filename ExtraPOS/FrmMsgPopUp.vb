Imports System.Windows.Forms

Public Class FrmMsgPopUp


    Private Sub FrmMsgPopUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Beep(2000, 300)
        Timer1.Start()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.BackColor = Color.Black Then
            Me.BackColor = Color.White
            Button1.BackColor = Color.Red
        Else
            Me.BackColor = Color.Black
            Button1.BackColor = Color.Black
        End If
    End Sub
End Class
