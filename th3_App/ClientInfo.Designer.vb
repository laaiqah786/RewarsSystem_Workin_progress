﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim LastnameLabel As System.Windows.Forms.Label
        Dim CellphoneLabel As System.Windows.Forms.Label
        Dim IDnumberLabel As System.Windows.Forms.Label
        Dim LengthLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DateofBirthLabel As System.Windows.Forms.Label
        Dim CitizenshipLabel As System.Windows.Forms.Label
        Me.ClientDataSet = New th3_App.ClientDataSet()
        Me.TblClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClientTableAdapter = New th3_App.ClientDataSetTableAdapters.tblClientTableAdapter()
        Me.TableAdapterManager = New th3_App.ClientDataSetTableAdapters.TableAdapterManager()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtCellphone = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtLen = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtDoB = New System.Windows.Forms.TextBox()
        Me.txtCitizenship = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        LastnameLabel = New System.Windows.Forms.Label()
        CellphoneLabel = New System.Windows.Forms.Label()
        IDnumberLabel = New System.Windows.Forms.Label()
        LengthLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DateofBirthLabel = New System.Windows.Forms.Label()
        CitizenshipLabel = New System.Windows.Forms.Label()
        CType(Me.ClientDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(22, 81)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        IDLabel.Visible = False
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(22, 107)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(59, 13)
        FirstnameLabel.TabIndex = 3
        FirstnameLabel.Text = "Firstname*:"
        '
        'LastnameLabel
        '
        LastnameLabel.AutoSize = True
        LastnameLabel.Location = New System.Drawing.Point(22, 133)
        LastnameLabel.Name = "LastnameLabel"
        LastnameLabel.Size = New System.Drawing.Size(60, 13)
        LastnameLabel.TabIndex = 5
        LastnameLabel.Text = "Lastname*:"
        '
        'CellphoneLabel
        '
        CellphoneLabel.AutoSize = True
        CellphoneLabel.Location = New System.Drawing.Point(22, 159)
        CellphoneLabel.Name = "CellphoneLabel"
        CellphoneLabel.Size = New System.Drawing.Size(61, 13)
        CellphoneLabel.TabIndex = 7
        CellphoneLabel.Text = "Cellphone*:"
        '
        'IDnumberLabel
        '
        IDnumberLabel.AutoSize = True
        IDnumberLabel.Location = New System.Drawing.Point(22, 185)
        IDnumberLabel.Name = "IDnumberLabel"
        IDnumberLabel.Size = New System.Drawing.Size(60, 13)
        IDnumberLabel.TabIndex = 9
        IDnumberLabel.Text = "IDnumber*:"
        '
        'LengthLabel
        '
        LengthLabel.AutoSize = True
        LengthLabel.Location = New System.Drawing.Point(22, 211)
        LengthLabel.Name = "LengthLabel"
        LengthLabel.Size = New System.Drawing.Size(39, 13)
        LengthLabel.TabIndex = 11
        LengthLabel.Text = "length:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.Location = New System.Drawing.Point(22, 237)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(45, 13)
        GenderLabel.TabIndex = 13
        GenderLabel.Text = "Gender:"
        '
        'DateofBirthLabel
        '
        DateofBirthLabel.AutoSize = True
        DateofBirthLabel.Location = New System.Drawing.Point(22, 263)
        DateofBirthLabel.Name = "DateofBirthLabel"
        DateofBirthLabel.Size = New System.Drawing.Size(66, 13)
        DateofBirthLabel.TabIndex = 15
        DateofBirthLabel.Text = "Dateof Birth:"
        '
        'CitizenshipLabel
        '
        CitizenshipLabel.AutoSize = True
        CitizenshipLabel.Location = New System.Drawing.Point(22, 289)
        CitizenshipLabel.Name = "CitizenshipLabel"
        CitizenshipLabel.Size = New System.Drawing.Size(60, 13)
        CitizenshipLabel.TabIndex = 17
        CitizenshipLabel.Text = "Citizenship:"
        '
        'ClientDataSet
        '
        Me.ClientDataSet.DataSetName = "ClientDataSet"
        Me.ClientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblClientBindingSource
        '
        Me.TblClientBindingSource.DataMember = "tblClient"
        Me.TblClientBindingSource.DataSource = Me.ClientDataSet
        '
        'TblClientTableAdapter
        '
        Me.TblClientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblClientTableAdapter = Me.TblClientTableAdapter
        Me.TableAdapterManager.UpdateOrder = th3_App.ClientDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'txtKey
        '
        Me.txtKey.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtKey.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientBindingSource, "ID", True))
        Me.txtKey.Location = New System.Drawing.Point(94, 78)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(331, 20)
        Me.txtKey.TabIndex = 2
        Me.txtKey.Visible = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientBindingSource, "Firstname", True))
        Me.txtName.Location = New System.Drawing.Point(94, 104)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(331, 20)
        Me.txtName.TabIndex = 4
        '
        'txtSurname
        '
        Me.txtSurname.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientBindingSource, "Lastname", True))
        Me.txtSurname.Location = New System.Drawing.Point(94, 130)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(331, 20)
        Me.txtSurname.TabIndex = 6
        '
        'txtCellphone
        '
        Me.txtCellphone.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtCellphone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientBindingSource, "Cellphone", True))
        Me.txtCellphone.Location = New System.Drawing.Point(94, 156)
        Me.txtCellphone.Name = "txtCellphone"
        Me.txtCellphone.Size = New System.Drawing.Size(331, 20)
        Me.txtCellphone.TabIndex = 8
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.NavajoWhite
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientBindingSource, "IDnumber", True))
        Me.txtID.Location = New System.Drawing.Point(94, 182)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(331, 20)
        Me.txtID.TabIndex = 10
        '
        'txtLen
        '
        Me.txtLen.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtLen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientBindingSource, "length", True))
        Me.txtLen.Location = New System.Drawing.Point(94, 208)
        Me.txtLen.Name = "txtLen"
        Me.txtLen.ReadOnly = True
        Me.txtLen.Size = New System.Drawing.Size(331, 20)
        Me.txtLen.TabIndex = 12
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtGender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientBindingSource, "Gender", True))
        Me.txtGender.Location = New System.Drawing.Point(94, 234)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.ReadOnly = True
        Me.txtGender.Size = New System.Drawing.Size(331, 20)
        Me.txtGender.TabIndex = 14
        '
        'txtDoB
        '
        Me.txtDoB.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtDoB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientBindingSource, "DateofBirth", True))
        Me.txtDoB.Location = New System.Drawing.Point(94, 260)
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.ReadOnly = True
        Me.txtDoB.Size = New System.Drawing.Size(331, 20)
        Me.txtDoB.TabIndex = 16
        '
        'txtCitizenship
        '
        Me.txtCitizenship.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txtCitizenship.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblClientBindingSource, "Citizenship", True))
        Me.txtCitizenship.Location = New System.Drawing.Point(94, 286)
        Me.txtCitizenship.Name = "txtCitizenship"
        Me.txtCitizenship.ReadOnly = True
        Me.txtCitizenship.Size = New System.Drawing.Size(331, 20)
        Me.txtCitizenship.TabIndex = 18
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(338, 327)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(257, 326)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(176, 327)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 24
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(94, 327)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 23
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'ClientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(FirstnameLabel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(LastnameLabel)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(CellphoneLabel)
        Me.Controls.Add(Me.txtCellphone)
        Me.Controls.Add(IDnumberLabel)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(LengthLabel)
        Me.Controls.Add(Me.txtLen)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(DateofBirthLabel)
        Me.Controls.Add(Me.txtDoB)
        Me.Controls.Add(CitizenshipLabel)
        Me.Controls.Add(Me.txtCitizenship)
        Me.Name = "ClientInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile"
        CType(Me.ClientDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientDataSet As ClientDataSet
    Friend WithEvents TblClientBindingSource As BindingSource
    Friend WithEvents TblClientTableAdapter As ClientDataSetTableAdapters.tblClientTableAdapter
    Friend WithEvents TableAdapterManager As ClientDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtKey As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtCellphone As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtLen As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtDoB As TextBox
    Friend WithEvents txtCitizenship As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnView As Button
End Class
