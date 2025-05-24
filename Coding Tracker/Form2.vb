Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Users\Jan Marc\Downloads\BG MUSIC.wav")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class