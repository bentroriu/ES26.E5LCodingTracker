Imports System.Drawing.Drawing2D
Imports System.IO
Imports AxWMPLib

Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim player As New System.Media.SoundPlayer(My.Resources.THEMESONG)
        player.PlayLooping()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Transparent
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form3 As New Form3
        form3.ShowDialog()
        Call form3.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then End

    End Sub

End Class