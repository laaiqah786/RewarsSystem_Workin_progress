Imports System.Data.OleDb
Public Class SignUp
    Dim closeProgram As New ProgramClose
    ReadOnly connection As New OleDbConnection(My.Settings.NewFlixDBConnectionString)
    Private Sub TblUsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.TblUsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NewFlixDBDataSet)
        TblUsersBindingSource.AddNew()


    End Sub
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NewFlixDBDataSet.tblUsers' table. You can move, or remove it, as needed.
        Me.TblUsersTableAdapter.Fill(Me.NewFlixDBDataSet.tblUsers)
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        txtIDLen.Text = txtID.Text.Length
        'Determine the gender of the person
        If txtID.Text.Chars(6).ToString < 5 Then
            txtGender.Text = "male"
        Else
            txtGender.Text = "female"
        End If

        'Determine the Date of birth
        txtDateofBirth.Text = txtID.Text.Chars(0).ToString & txtID.Text.Chars(1).ToString & "/" &
        txtID.Text.Chars(2).ToString & txtID.Text.Chars(3).ToString & "/" &
        txtID.Text.Chars(4).ToString & txtID.Text.Chars(5).ToString

        'Determine the country of orgin
        If txtID.Text.Chars(10).ToString = 0 Then
            txtCitizenship.Text = "South African"
        Else
            txtCitizenship.Text = "Foreigener"
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Opens the connection of the database
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        'Check data
        Using create As New OleDbCommand("INSERT INTO tblUsers([Username], [Password], [Email], [ID_Number], [ID_Length], [Gender], [Date_of_Birth], [Citizenship]) VALUES(@Username, @Password, @Email, @ID_Number, @ID_Length, @Gender, @Date_of_Birth, @Citizenship)", connection)
            'add data to respective database coloums
            create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtName.Text.Trim
            create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim
            create.Parameters.AddWithValue("@Email", OleDbType.VarChar).Value = txtEmail.Text.Trim
            create.Parameters.AddWithValue("@ID_Number", OleDbType.VarChar).Value = txtID.Text.Trim
            create.Parameters.AddWithValue("@ID_Length", OleDbType.VarChar).Value = txtIDLen.Text.Trim
            create.Parameters.AddWithValue("@Gender", OleDbType.VarChar).Value = txtGender.Text.Trim
            create.Parameters.AddWithValue("@Date_of_Birth", OleDbType.VarChar).Value = txtDateofBirth.Text.Trim
            create.Parameters.AddWithValue("@Citizenship", OleDbType.VarChar).Value = txtCitizenship.Text.Trim

            If create.ExecuteNonQuery() Then
            Else
                MessageBox.Show("Registration Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
        'Close the oledb connection
        connection.Close()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Close()
        LoginPage.Show()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        closeProgram.CloseApp()
    End Sub

End Class