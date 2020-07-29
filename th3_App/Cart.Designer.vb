<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cart
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
        Me.btnYes = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkRice = New System.Windows.Forms.CheckBox()
        Me.chkMaize = New System.Windows.Forms.CheckBox()
        Me.chkOats = New System.Windows.Forms.CheckBox()
        Me.chkFlour = New System.Windows.Forms.CheckBox()
        Me.chkSugar = New System.Windows.Forms.CheckBox()
        Me.chkEggs = New System.Windows.Forms.CheckBox()
        Me.chkRama = New System.Windows.Forms.CheckBox()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.chkBread = New System.Windows.Forms.CheckBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(259, 421)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 13
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 26)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Do you want to edit your existing profile?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(120, 147)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(214, 228)
        Me.lblDisplay.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkRice)
        Me.GroupBox1.Controls.Add(Me.chkMaize)
        Me.GroupBox1.Controls.Add(Me.chkOats)
        Me.GroupBox1.Controls.Add(Me.chkFlour)
        Me.GroupBox1.Controls.Add(Me.chkSugar)
        Me.GroupBox1.Controls.Add(Me.chkEggs)
        Me.GroupBox1.Controls.Add(Me.chkRama)
        Me.GroupBox1.Controls.Add(Me.chkOil)
        Me.GroupBox1.Controls.Add(Me.chkBread)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 228)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Essentials"
        '
        'chkRice
        '
        Me.chkRice.AutoSize = True
        Me.chkRice.Location = New System.Drawing.Point(7, 159)
        Me.chkRice.Name = "chkRice"
        Me.chkRice.Size = New System.Drawing.Size(48, 17)
        Me.chkRice.TabIndex = 0
        Me.chkRice.Text = "Rice"
        Me.chkRice.UseVisualStyleBackColor = True
        '
        'chkMaize
        '
        Me.chkMaize.AutoSize = True
        Me.chkMaize.Location = New System.Drawing.Point(6, 136)
        Me.chkMaize.Name = "chkMaize"
        Me.chkMaize.Size = New System.Drawing.Size(80, 17)
        Me.chkMaize.TabIndex = 0
        Me.chkMaize.Text = "Maize Meal"
        Me.chkMaize.UseVisualStyleBackColor = True
        '
        'chkOats
        '
        Me.chkOats.AutoSize = True
        Me.chkOats.Location = New System.Drawing.Point(6, 113)
        Me.chkOats.Name = "chkOats"
        Me.chkOats.Size = New System.Drawing.Size(69, 17)
        Me.chkOats.TabIndex = 0
        Me.chkOats.Text = "Oat Meal"
        Me.chkOats.UseVisualStyleBackColor = True
        '
        'chkFlour
        '
        Me.chkFlour.AutoSize = True
        Me.chkFlour.Location = New System.Drawing.Point(6, 182)
        Me.chkFlour.Name = "chkFlour"
        Me.chkFlour.Size = New System.Drawing.Size(80, 17)
        Me.chkFlour.TabIndex = 0
        Me.chkFlour.Text = "Bread Flour"
        Me.chkFlour.UseVisualStyleBackColor = True
        '
        'chkSugar
        '
        Me.chkSugar.AutoSize = True
        Me.chkSugar.Location = New System.Drawing.Point(6, 205)
        Me.chkSugar.Name = "chkSugar"
        Me.chkSugar.Size = New System.Drawing.Size(54, 17)
        Me.chkSugar.TabIndex = 0
        Me.chkSugar.Text = "Sugar"
        Me.chkSugar.UseVisualStyleBackColor = True
        '
        'chkEggs
        '
        Me.chkEggs.AutoSize = True
        Me.chkEggs.Location = New System.Drawing.Point(6, 90)
        Me.chkEggs.Name = "chkEggs"
        Me.chkEggs.Size = New System.Drawing.Size(50, 17)
        Me.chkEggs.TabIndex = 0
        Me.chkEggs.Text = "Eggs"
        Me.chkEggs.UseVisualStyleBackColor = True
        '
        'chkRama
        '
        Me.chkRama.AutoSize = True
        Me.chkRama.Location = New System.Drawing.Point(6, 67)
        Me.chkRama.Name = "chkRama"
        Me.chkRama.Size = New System.Drawing.Size(91, 17)
        Me.chkRama.TabIndex = 0
        Me.chkRama.Text = "Butter Spread"
        Me.chkRama.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.AutoSize = True
        Me.chkOil.Location = New System.Drawing.Point(7, 44)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(89, 17)
        Me.chkOil.TabIndex = 0
        Me.chkOil.Text = "Vegatable Oil"
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'chkBread
        '
        Me.chkBread.AutoSize = True
        Me.chkBread.Location = New System.Drawing.Point(7, 21)
        Me.chkBread.Name = "chkBread"
        Me.chkBread.Size = New System.Drawing.Size(54, 17)
        Me.chkBread.TabIndex = 0
        Me.chkBread.Text = "Bread"
        Me.chkBread.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(177, 381)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 19
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(259, 382)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(96, 381)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(15, 382)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 16
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 60)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Enjoy your shopping"
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Cart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnYes As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkRice As CheckBox
    Friend WithEvents chkMaize As CheckBox
    Friend WithEvents chkOats As CheckBox
    Friend WithEvents chkFlour As CheckBox
    Friend WithEvents chkSugar As CheckBox
    Friend WithEvents chkEggs As CheckBox
    Friend WithEvents chkRama As CheckBox
    Friend WithEvents chkOil As CheckBox
    Friend WithEvents chkBread As CheckBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents Label1 As Label
End Class
