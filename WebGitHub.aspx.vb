
Partial Class GitHub_WebGitHub
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        out.Text = "Nama anda " & txtnama.Text & " <br> Nim anda " & txtnim.Text & "<br> Prodi anda " & txtprodi.Text
    End Sub
End Class
