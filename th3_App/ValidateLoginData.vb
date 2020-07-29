Public Class ValidateLoginData
    Private Name As String
    Private Password As String

    Public ReadOnly Property GetName() As String
        Get
            Return Name
        End Get
    End Property
    Public ReadOnly Property GetPassword() As String
        Get
            Return Password
        End Get
    End Property
    Public Sub SetName(tempName As String)
        Name = tempName
    End Sub
    Public Sub SetPassword(tempPassword As String)
        Password = tempPassword
    End Sub
    Public Sub New(Optional tname As String = "Enter Name",
                   Optional tpassword As String = "Enter Password")
        Name = tname
        Password = tpassword
    End Sub
End Class
