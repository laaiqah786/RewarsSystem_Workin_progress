Imports System.Data.OleDb
Public Class ClientLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtCellphone.Text = Nothing Then
            MessageBox.Show("Please enter details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim connection As New OleDbConnection(My.Settings.ClientConnectionString)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim cmd As New OleDbCommand("select count(*) from tblClient where Cellphone=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = txtCellphone.Text

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If (count > 0) Then
                Cart.Show()
                txtCellphone.Text = ""
                Me.Visible = False

            Else
                MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txtCellphone.Text = ""
            End If

        End If
        My.Forms.Cart.boolIsUser = True

    End Sub
End Class