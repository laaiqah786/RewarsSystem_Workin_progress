<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ID_NumberLabel As System.Windows.Forms.Label
        Dim ID_LengthLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim CitizenshipLabel As System.Windows.Forms.Label
        Me.NewFlixDBDataSet = New th3_App.NewFlixDBDataSet()
        Me.TblUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUsersTableAdapter = New th3_App.NewFlixDBDataSetTableAdapters.tblUsersTableAdapter()
        Me.TableAdapterManager = New th3_App.NewFlixDBDataSetTableAdapters.TableAdapterManager()
        Me.txtkey = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtIDLen = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtDateofBirth = New System.Windows.Forms.TextBox()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ID_NumberLabel = New System.Windows.Forms.Label()
        ID_LengthLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        CitizenshipLabel = New System.Windows.Forms.Label()
        CType(Me.NewFlixDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(40, 142)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        IDLabel.Visible = False
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(40, 168)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(58, 13)
        UsernameLabel.TabIndex = 3
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(40, 194)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(40, 220)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "Email:"
        '
        'ID_NumberLabel
        '
        ID_NumberLabel.AutoSize = True
        ID_NumberLabel.Location = New System.Drawing.Point(40, 246)
        ID_NumberLabel.Name = "ID_NumberLabel"
        ID_NumberLabel.Size = New System.Drawing.Size(61, 13)
        ID_NumberLabel.TabIndex = 9
        ID_NumberLabel.Text = "ID Number:"
        '
        'ID_LengthLabel
        '
        ID_LengthLabel.AutoSize = True
        ID_LengthLabel.Location = New System.Drawing.Point(40, 272)
        ID_LengthLabel.Name = "ID_LengthLabel"
        ID_LengthLabel.Size = New System.Drawing.Size(57, 13)
        ID_LengthLabel.TabIndex = 11
        ID_LengthLabel.Text = "ID Length:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(40, 298)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 13
        GenderLabel.Text = "Gender:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Location = New System.Drawing.Point(40, 324)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(69, 13)
        Date_of_BirthLabel.TabIndex = 15
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'CitizenshipLabel
        '
        CitizenshipLabel.AutoSize = True
        CitizenshipLabel.Location = New System.Drawing.Point(40, 350)
        CitizenshipLabel.Name = "CitizenshipLabel"
        CitizenshipLabel.Size = New System.Drawing.Size(60, 13)
        CitizenshipLabel.TabIndex = 17
        CitizenshipLabel.Text = "Citizenship:"
        '
        'NewFlixDBDataSet
        '
        Me.NewFlixDBDataSet.DataSetName = "NewFlixDBDataSet"
        Me.NewFlixDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblUsersBindingSource
        '
        Me.TblUsersBindingSource.DataMember = "tblUsers"
        Me.TblUsersBindingSource.DataSource = Me.NewFlixDBDataSet
        '
        'TblUsersTableAdapter
        '
        Me.TblUsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblUsersTableAdapter = Me.TblUsersTableAdapter
        Me.TableAdapterManager.UpdateOrder = th3_App.NewFlixDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtkey
        '
        Me.txtkey.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtkey.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "ID", True))
        Me.txtkey.Location = New System.Drawing.Point(115, 139)
        Me.txtkey.Name = "txtkey"
        Me.txtkey.ReadOnly = True
        Me.txtkey.Size = New System.Drawing.Size(319, 20)
        Me.txtkey.TabIndex = 2
        Me.txtkey.Visible = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "Username", True))
        Me.txtName.Location = New System.Drawing.Point(115, 165)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(319, 20)
        Me.txtName.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "Password", True))
        Me.txtPassword.Location = New System.Drawing.Point(115, 191)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(319, 20)
        Me.txtPassword.TabIndex = 6
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "Email", True))
        Me.txtEmail.Location = New System.Drawing.Point(115, 217)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(319, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "ID_Number", True))
        Me.txtID.Location = New System.Drawing.Point(115, 243)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(319, 20)
        Me.txtID.TabIndex = 10
        '
        'txtIDLen
        '
        Me.txtIDLen.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtIDLen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "ID_Length", True))
        Me.txtIDLen.Location = New System.Drawing.Point(115, 269)
        Me.txtIDLen.Name = "txtIDLen"
        Me.txtIDLen.ReadOnly = True
        Me.txtIDLen.Size = New System.Drawing.Size(319, 20)
        Me.txtIDLen.TabIndex = 12
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "Gender", True))
        Me.txtGender.Location = New System.Drawing.Point(115, 295)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(319, 20)
        Me.txtGender.TabIndex = 14
        '
        'txtDateofBirth
        '
        Me.txtDateofBirth.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtDateofBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "Date_of_Birth", True))
        Me.txtDateofBirth.Location = New System.Drawing.Point(115, 321)
        Me.txtDateofBirth.Name = "txtDateofBirth"
        Me.txtDateofBirth.ReadOnly = True
        Me.txtDateofBirth.Size = New System.Drawing.Size(319, 20)
        Me.txtDateofBirth.TabIndex = 16
        '
        'txtCitizenship
        '
        Me.txtCitizenship.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCitizenship.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsersBindingSource, "Citizenship", True))
        Me.txtCitizenship.Location = New System.Drawing.Point(115, 347)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.ReadOnly = True
        Me.txtCitizenship.Size = New System.Drawing.Size(319, 20)
        Me.txtCitizenship.TabIndex = 18
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(115, 374)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 19
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(197, 374)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(278, 373)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 21
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(359, 374)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 22
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 60)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Sign Up Enjoy Rewards"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.txtkey)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(ID_NumberLabel)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(ID_LengthLabel)
        Me.Controls.Add(Me.txtIDLen)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Date_of_BirthLabel)
        Me.Controls.Add(Me.txtDateofBirth)
        Me.Controls.Add(CitizenshipLabel)
        Me.Controls.Add(Me.txtCitizenship)
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up Page"
        CType(Me.NewFlixDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewFlixDBDataSet As NewFlixDBDataSet
    Friend WithEvents TblUsersBindingSource As BindingSource
    Friend WithEvents TblUsersTableAdapter As NewFlixDBDataSetTableAdapters.tblUsersTableAdapter
    Friend WithEvents TableAdapterManager As NewFlixDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtkey As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtIDLen As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtDateofBirth As TextBox
    Friend WithEvents txtCitizenship As TextBox
    Friend WithEvents btnView As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
End Class
