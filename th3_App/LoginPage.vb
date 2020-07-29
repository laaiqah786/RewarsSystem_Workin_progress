Imports System.Data.OleDb
Public Class LoginPage
    'We used global variables to make the variables easier to use. Enums is probally better
    Dim user As New ValidateLoginData
    Dim InputTest = False

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Input is send to the Validate Login class 
        user.SetName(txtUsername.Text.Trim)
        user.SetPassword(txtPassword.Text.Trim)
        'Call different methods
        TestData()
        Popups()
        ExecuteData()
        ClearData()

    End Sub
    'This is a method to check if input data is correct
    Private Sub ExecuteData()
        If InputTest = True Then
            MainMenu.Show()
            Me.Visible = False
        Else
            MessageBox.Show("Acount not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'This method is to clear input fields
    Private Sub ClearData()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
    'This method is validating the data
    Public Sub Popups()
        If txtUsername.Text.Length = 0 Then
            MessageBox.Show("Please enter a username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If txtPassword.Text.Length = 0 Then
            MessageBox.Show("Please enter a password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    'This method checks the database for possible accounts
    Public Sub TestData()
        Dim connection As New OleDbConnection(My.Settings.NewFlixDBConnectionString)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        connection.Equals(connection)
        Dim cmd As New OleDbCommand("select count(*) from tblUsers where Username=@username and Password=@password", connection)
        cmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = user.GetName
        cmd.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = user.GetPassword
        Dim count = Convert.ToInt32(cmd.ExecuteScalar())
        If (count > 0) Then
            InputTest = True
        End If
    End Sub

    Private Sub lnkHere_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHere.LinkClicked
        Visible = False
        SignUp.Show()
        SignUp.TblUsersBindingSource.AddNew()
    End Sub
End Class
