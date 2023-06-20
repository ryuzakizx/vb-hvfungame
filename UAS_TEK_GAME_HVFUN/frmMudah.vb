Public Class frmMudah

    Private TargetDT1, TargetDT2 As DateTime
    Private CountDownFrom1 As TimeSpan = TimeSpan.FromSeconds(13)
    Private CountDownFrom2 As TimeSpan = TimeSpan.FromSeconds(13)
    Dim score As Integer = 0

    Public Sub pertanyaan1()
        Timer1.Start()
    End Sub

    Public Sub jawaban1(ByVal jawaban As String)
        Dim benar, salah As String
        If jawaban = "Kalimantan" Or jawaban = "kalimantan" Then
            benar = MessageBox.Show("Yeayy, Jawaban Benar !!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            score = score + 50
            LblScoreMudah.Text = score
        Else
            salah = MessageBox.Show("Yahhhh, Jawaban Salah !!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            score = score + 0
            LblScoreMudah.Text = score
        End If
    End Sub

    Public Sub jawaban2(ByVal jawaban As String)
        Dim benar, salah As String
        If jawaban = "Sumatera" Or jawaban = "sumatera" Then
            benar = MessageBox.Show("Yeayy, Jawaban Benar !!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            score = score + 50
            LblScoreMudah.Text = score
        Else
            salah = MessageBox.Show("Yahhhh, Jawaban Salah !!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            score = score + 0
            LblScoreMudah.Text = score
        End If
    End Sub

    Public Sub pertanyaan2()
        PBKalimantan.Hide()
        PBSumatera.Show()
        tbPermainan.Text = ""
        btnCek1.Hide()
        btnCek2.Show()
        Timer2.Start()
    End Sub


    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        tbPermainan.Text = ""
    End Sub

    Private Sub frmMudah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TargetDT1 = DateTime.Now.Add(CountDownFrom1)
        Pertanyaan1()
        LblScoreMudah.Text = score
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ts As TimeSpan = TargetDT1.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            LblWaktuMudah.Text = ts.ToString("mm\:ss")
        Else
            LblWaktuMudah.Text = "00:00"
            Timer1.Stop()
            pertanyaan2()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim ts As TimeSpan = TargetDT2.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            LblWaktuMudah.Text = ts.ToString("mm\:ss")
        Else
            LblWaktuMudah.Text = "00:00"
            Timer1.Stop()
            TargetDT2 = DateTime.Now.Add(CountDownFrom2)
            'pertanyaan2()
        End If
    End Sub

    Private Sub btnCek1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCek1.Click
        jawaban1(tbPermainan.Text)
        pertanyaan2()
        btnCek1.Hide()
        btnCek2.Show()
    End Sub

    Private Sub btnCek2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCek2.Click
        jawaban2(tbPermainan.Text)
        Timer2.Stop()
        Timer1.Stop()
        LblWaktuMudah.Text = "00:00"
        Dim setengah, sempurna, gagal As String
        If LblScoreMudah.Text > 99 Then
            sempurna = MessageBox.Show("Yeayy, Kamu mendapatkan score " + LblScoreMudah.Text, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf LblScoreMudah.Text > 50 Then
            setengah = MessageBox.Show("Yeayy, Kamu mendapatkan score " + LblScoreMudah.Text, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            gagal = MessageBox.Show("Yahhh, Kamu mendapatkan score " + LblScoreMudah.Text, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LblScoreMudah.Text = "0"
        tbPermainan.Text = ""
        Me.Hide()
        Beranda.Show()
    End Sub
End Class