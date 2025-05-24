Imports System.Drawing.Drawing2D
Imports System.IO

Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.BackColor = Color.Transparent
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form3 As New Form3
        form3.ShowDialog()
        Call form3.BringToFront()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then End

    End Sub


    Private Sub PlayEmbeddedMusic()
        Dim tempPath As String = Path.Combine(Path.GetTempPath(), "BG MUSIC.wav")
        Dim stream As IO.UnmanagedMemoryStream = My.Resources.THEMESONG
        Dim song(stream.Length - 1) As Byte
        stream.Read(song, 0, stream.Length)
        File.WriteAllBytes(tempPath, song) ' Use your resource name here
        AxWindowsMediaPlayer1.URL = tempPath
        AxWindowsMediaPlayer1.settings.setMode("loop", True) ' Optional loop
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        AxWindowsMediaPlayer1.Visible = False
    End Sub


End Class