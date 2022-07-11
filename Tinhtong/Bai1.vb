Public Class Bai1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Tinh.Click
        Tong.Text = Val(a.Text) + Val(b.Text)
    End Sub

    Private Sub Thoat_Click(sender As Object, e As EventArgs) Handles Thoat.Click
        Dim hoi As Integer
        hoi = MsgBox("Ban co muon thoat?", vbYesNo, "Trợ giúp")
        If hoi = vbYes Then
            Close()
        Else
            Enabled = True
        End If
    End Sub
End Class
