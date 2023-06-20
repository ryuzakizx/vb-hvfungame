Public Class Beranda


    Private Sub btnMudah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMudah.Click
        frmMudah.Show()
        Me.Hide()
    End Sub

    Private Sub LblBantuan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBantuan.Click
        Me.Hide()
        frmBantuan.Show()
    End Sub
End Class
