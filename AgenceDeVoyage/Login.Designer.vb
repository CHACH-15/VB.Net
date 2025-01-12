<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        UserNameBox = New TextBox()
        PasswordBox = New TextBox()
        BtnLogin = New Button()
        BtnCancel = New Button()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(122, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(227, 230)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(33, 273)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 38)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(42, 338)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 38)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' UserNameBox
        ' 
        UserNameBox.Location = New Point(227, 273)
        UserNameBox.Name = "UserNameBox"
        UserNameBox.Size = New Size(193, 27)
        UserNameBox.TabIndex = 3
        ' 
        ' PasswordBox
        ' 
        PasswordBox.Location = New Point(227, 349)
        PasswordBox.Name = "PasswordBox"
        PasswordBox.Size = New Size(190, 27)
        PasswordBox.TabIndex = 4
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.SteelBlue
        BtnLogin.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnLogin.Location = New Point(98, 428)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(271, 49)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' BtnCancel
        ' 
        BtnCancel.BackColor = Color.Transparent
        BtnCancel.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCancel.Location = New Point(98, 483)
        BtnCancel.Name = "BtnCancel"
        BtnCancel.Size = New Size(271, 50)
        BtnCancel.TabIndex = 6
        BtnCancel.Text = "cancel"
        BtnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(12, 388)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 20)
        Label3.TabIndex = 7
        Label3.Visible = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(255), CByte(218))
        ClientSize = New Size(504, 545)
        Controls.Add(Label3)
        Controls.Add(BtnCancel)
        Controls.Add(BtnLogin)
        Controls.Add(PasswordBox)
        Controls.Add(UserNameBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UserNameBox As TextBox
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label3 As Label

End Class
