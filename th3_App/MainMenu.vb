Public Class MainMenu
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        ClientInfo.Show()
        ClientInfo.TblClientBindingSource.AddNew()
        Me.Visible = False
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ClientLogin.Show()
        Me.Visible = False
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        Cart.Show()
        Me.Visible = False
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class