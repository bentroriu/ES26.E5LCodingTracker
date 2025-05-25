Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim player As New System.Media.SoundPlayer(My.Resources.THEMESONG)
        player.PlayLooping()
        CheckBox1.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim player As New System.Media.SoundPlayer(My.Resources.THEMESONG)
        If CheckBox1.Checked = True Then
            player.Play()
        Else
            player.Stop()
        End If
    End Sub
End Class