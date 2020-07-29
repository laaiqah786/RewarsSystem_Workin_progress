Imports System.Data.OleDb
Public Class ClientInfo
    Dim closeProgram As New ProgramClose
    ReadOnly connection As New OleDbConnection(My.Settings.ClientConnectionString)
    Private Sub TblClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClientDataSet)


    End Sub

    Private Sub ClientInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientDataSet.tblClient' table. You can move, or remove it, as needed.
        Me.TblClientTableAdapter.Fill(Me.ClientDataSet.tblClient)

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Try
            txtLen.Text = txtID.Text.Length
            'Determine the gender of the person
            If txtID.Text.Chars(6).ToString < 5 Then
                txtGender.Text = "male"
            Else
                txtGender.Text = "female"
            End If

            'Determine the Date of birth
            txtDoB.Text = txtID.Text.Chars(0).ToString & txtID.Text.Chars(1).ToString & "/" &
            txtID.Text.Chars(2).ToString & txtID.Text.Chars(3).ToString & "/" &
            txtID.Text.Chars(4).ToString & txtID.Text.Chars(5).ToString

            'Determine the country of orgin
            If txtID.Text.Chars(10).ToString = 0 Then
                txtCitizenship.Text = "South African"
            Else
                txtCitizenship.Text = "Foreigener"
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter all fields marked with the (*) ")
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Opens the connection of the database
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        'Check data
        Using create As New OleDbCommand("INSERT INTO tblClient([Firstname], [Lastname], [Cellphone], [IDNumber], [Length], [Gender], [DateofBirth], [Citizenship]) VALUES(@Firstname, @Lastname, @Cellphone, @IDNumber, @Length, @Gender, @DateofBirth, @Citizenship)", connection)
            'add data to respective database coloums
            create.Parameters.AddWithValue("@Firstname", OleDbType.VarChar).Value = txtName.Text.Trim
            create.Parameters.AddWithValue("@Lastname", OleDbType.VarChar).Value = txtSurname.Text.Trim
            create.Parameters.AddWithValue("@Cellphone", OleDbType.VarChar).Value = txtCellphone.Text.Trim
            create.Parameters.AddWithValue("@IDNumber", OleDbType.VarChar).Value = txtID.Text.Trim
            create.Parameters.AddWithValue("@Length", OleDbType.VarChar).Value = txtLen.Text.Trim
            create.Parameters.AddWithValue("@Gender", OleDbType.VarChar).Value = txtGender.Text.Trim
            create.Parameters.AddWithValue("@DateofBirth", OleDbType.VarChar).Value = txtDoB.Text.Trim
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
        MainMenu.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        closeProgram.CloseApp()
    End Sub
End Class