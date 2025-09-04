Imports System.Windows.Forms

Public Class FrmCustomColors

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub lbl_color1_Click(sender As Object, e As EventArgs) Handles lbl_color1.Click
        Dim sure = Me.ColorDialog1.ShowDialog()

        If sure = vbOK Then
            lbl_color1.BackColor = Me.ColorDialog1.Color

        End If
    End Sub

    Private Sub lbl_color2_Click(sender As Object, e As EventArgs) Handles lbl_color2.Click
        Dim sure = Me.ColorDialog1.ShowDialog()

        If sure = vbOK Then
            lbl_color2.BackColor = Me.ColorDialog1.Color

        End If
    End Sub

    Private Sub lbl_color3_Click(sender As Object, e As EventArgs) Handles lbl_color3.Click
        Dim sure = Me.ColorDialog1.ShowDialog()

        If sure = vbOK Then
            lbl_color3.BackColor = Me.ColorDialog1.Color

        End If
    End Sub

    Private Sub lbl_color4_Click(sender As Object, e As EventArgs) Handles lbl_color4.Click
        Dim sure = Me.ColorDialog1.ShowDialog()

        If sure = vbOK Then
            lbl_color4.BackColor = Me.ColorDialog1.Color

        End If
    End Sub

    Private Sub lbl_color5_Click(sender As Object, e As EventArgs) Handles lbl_color5.Click
        Dim sure = Me.ColorDialog1.ShowDialog()

        If sure = vbOK Then
            lbl_color5.BackColor = Me.ColorDialog1.Color

        End If
    End Sub

    Private Sub lbl_color6_Click(sender As Object, e As EventArgs) Handles lbl_color6.Click
        Dim sure = Me.ColorDialog1.ShowDialog()

        If sure = vbOK Then
            lbl_color6.BackColor = Me.ColorDialog1.Color

        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            My.Settings.color1 = Me.lbl_color1.BackColor
            My.Settings.color2 = Me.lbl_color2.BackColor
            My.Settings.color3 = Me.lbl_color3.BackColor
            My.Settings.color4 = Me.lbl_color4.BackColor
            My.Settings.color5 = Me.lbl_color5.BackColor
            My.Settings.color6 = Me.lbl_color6.BackColor
            My.Settings.Save()

            Me.Close()



        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmCustomColors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.lbl_color1.BackColor = My.Settings.color1
            Me.lbl_color2.BackColor = My.Settings.color2
            Me.lbl_color3.BackColor = My.Settings.color3
            Me.lbl_color4.BackColor = My.Settings.color4
            Me.lbl_color5.BackColor = My.Settings.color5
            Me.lbl_color6.BackColor = My.Settings.color6




        Catch ex As Exception

        End Try
    End Sub
End Class
