<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CelestialCoffee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CelestialCoffee))
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.txtRegular = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDecaf = New System.Windows.Forms.TextBox()
        Me.lblPounds2 = New System.Windows.Forms.Label()
        Me.lblPounds3 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtSubmit = New System.Windows.Forms.TextBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPounds.Location = New System.Drawing.Point(11, 69)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(398, 22)
        Me.lblPounds.TabIndex = 0
        Me.lblPounds.Text = "Please Enter the Amount of Coffee Desired"
        '
        'txtRegular
        '
        Me.txtRegular.Location = New System.Drawing.Point(86, 110)
        Me.txtRegular.Name = "txtRegular"
        Me.txtRegular.Size = New System.Drawing.Size(100, 20)
        Me.txtRegular.TabIndex = 1
        Me.txtRegular.Text = "0"
        Me.txtRegular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Regular "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Decaf"
        '
        'txtDecaf
        '
        Me.txtDecaf.Location = New System.Drawing.Point(85, 146)
        Me.txtDecaf.Name = "txtDecaf"
        Me.txtDecaf.Size = New System.Drawing.Size(100, 20)
        Me.txtDecaf.TabIndex = 4
        Me.txtDecaf.Text = "0"
        Me.txtDecaf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPounds2
        '
        Me.lblPounds2.AutoSize = True
        Me.lblPounds2.Location = New System.Drawing.Point(192, 115)
        Me.lblPounds2.Name = "lblPounds2"
        Me.lblPounds2.Size = New System.Drawing.Size(20, 13)
        Me.lblPounds2.TabIndex = 5
        Me.lblPounds2.Text = "lbs"
        '
        'lblPounds3
        '
        Me.lblPounds3.AutoSize = True
        Me.lblPounds3.Location = New System.Drawing.Point(192, 149)
        Me.lblPounds3.Name = "lblPounds3"
        Me.lblPounds3.Size = New System.Drawing.Size(20, 13)
        Me.lblPounds3.TabIndex = 6
        Me.lblPounds3.Text = "lbs"
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnEnter.Font = New System.Drawing.Font("Myanmar Text", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.White
        Me.btnEnter.Location = New System.Drawing.Point(85, 183)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 7
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(14, 221)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(110, 18)
        Me.lblAmount.TabIndex = 8
        Me.lblAmount.Text = "Amount Due "
        '
        'txtOut
        '
        Me.txtOut.Location = New System.Drawing.Point(17, 255)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(100, 20)
        Me.txtOut.TabIndex = 9
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(19, 334)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(343, 22)
        Me.lblInfo.TabIndex = 10
        Me.lblInfo.Text = "Please Enter Your Information Below"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(23, 389)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(46, 16)
        Me.lblName.TabIndex = 11
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(86, 386)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 12
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(86, 432)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 13
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(23, 435)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(61, 16)
        Me.lblAddress.TabIndex = 14
        Me.lblAddress.Text = "Address:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(26, 527)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(41, 16)
        Me.lblState.TabIndex = 15
        Me.lblState.Text = "State:"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(86, 481)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 16
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(26, 488)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(36, 16)
        Me.lblCity.TabIndex = 17
        Me.lblCity.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(86, 527)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 18
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(26, 574)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(65, 16)
        Me.lblZip.TabIndex = 19
        Me.lblZip.Text = "Zip Code:"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(86, 571)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(100, 20)
        Me.txtZip.TabIndex = 20
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnSubmit.ForeColor = System.Drawing.Color.Transparent
        Me.btnSubmit.Location = New System.Drawing.Point(85, 617)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(84, 25)
        Me.btnSubmit.TabIndex = 21
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtSubmit
        '
        Me.txtSubmit.Location = New System.Drawing.Point(388, 389)
        Me.txtSubmit.Multiline = True
        Me.txtSubmit.Name = "txtSubmit"
        Me.txtSubmit.Size = New System.Drawing.Size(208, 198)
        Me.txtSubmit.TabIndex = 22
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Script MT Bold", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(143, 9)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(438, 44)
        Me.lblWelcome.TabIndex = 23
        Me.lblWelcome.Text = "Welcome to Celestial Coffee!"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(521, 667)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 25
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(388, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'CelestialCoffee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(688, 714)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.txtSubmit)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblPounds3)
        Me.Controls.Add(Me.lblPounds2)
        Me.Controls.Add(Me.txtDecaf)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRegular)
        Me.Controls.Add(Me.lblPounds)
        Me.Name = "CelestialCoffee"
        Me.Text = "Celestial Coffee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPounds As Label
    Friend WithEvents txtRegular As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDecaf As TextBox
    Friend WithEvents lblPounds2 As Label
    Friend WithEvents lblPounds3 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtOut As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblState As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents lblZip As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtSubmit As TextBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
