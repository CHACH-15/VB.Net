<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pizza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pizza))
        cmbTaille = New ComboBox()
        radCrouteFine = New RadioButton()
        radCrouteClassique = New RadioButton()
        radCrouteEpaisse = New RadioButton()
        chkChampignons = New CheckBox()
        chkOlives = New CheckBox()
        chkPoivrons = New CheckBox()
        chkFromage = New CheckBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        btnAfficherCommande = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbTaille
        ' 
        cmbTaille.FormattingEnabled = True
        cmbTaille.Items.AddRange(New Object() {"petite", "moyenne", "grande"})
        cmbTaille.Location = New Point(30, 44)
        cmbTaille.Name = "cmbTaille"
        cmbTaille.Size = New Size(151, 28)
        cmbTaille.TabIndex = 0
        ' 
        ' radCrouteFine
        ' 
        radCrouteFine.AutoSize = True
        radCrouteFine.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radCrouteFine.Location = New Point(230, 48)
        radCrouteFine.Name = "radCrouteFine"
        radCrouteFine.Size = New Size(133, 28)
        radCrouteFine.TabIndex = 1
        radCrouteFine.TabStop = True
        radCrouteFine.Text = "croute fine"
        radCrouteFine.UseVisualStyleBackColor = True
        ' 
        ' radCrouteClassique
        ' 
        radCrouteClassique.AutoSize = True
        radCrouteClassique.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radCrouteClassique.Location = New Point(369, 48)
        radCrouteClassique.Name = "radCrouteClassique"
        radCrouteClassique.Size = New Size(187, 28)
        radCrouteClassique.TabIndex = 2
        radCrouteClassique.TabStop = True
        radCrouteClassique.Text = "croute classique"
        radCrouteClassique.UseVisualStyleBackColor = True
        ' 
        ' radCrouteEpaisse
        ' 
        radCrouteEpaisse.AutoSize = True
        radCrouteEpaisse.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        radCrouteEpaisse.Location = New Point(576, 48)
        radCrouteEpaisse.Name = "radCrouteEpaisse"
        radCrouteEpaisse.Size = New Size(170, 28)
        radCrouteEpaisse.TabIndex = 3
        radCrouteEpaisse.TabStop = True
        radCrouteEpaisse.Text = "croute epaisse"
        radCrouteEpaisse.UseVisualStyleBackColor = True
        ' 
        ' chkChampignons
        ' 
        chkChampignons.AutoSize = True
        chkChampignons.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkChampignons.Location = New Point(42, 137)
        chkChampignons.Name = "chkChampignons"
        chkChampignons.Size = New Size(159, 28)
        chkChampignons.TabIndex = 4
        chkChampignons.Text = "champignons"
        chkChampignons.UseVisualStyleBackColor = True
        ' 
        ' chkOlives
        ' 
        chkOlives.AutoSize = True
        chkOlives.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkOlives.Location = New Point(452, 137)
        chkOlives.Name = "chkOlives"
        chkOlives.Size = New Size(87, 28)
        chkOlives.TabIndex = 5
        chkOlives.Text = "olives"
        chkOlives.UseVisualStyleBackColor = True
        ' 
        ' chkPoivrons
        ' 
        chkPoivrons.AutoSize = True
        chkPoivrons.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkPoivrons.Location = New Point(12, 285)
        chkPoivrons.Name = "chkPoivrons"
        chkPoivrons.Size = New Size(115, 28)
        chkPoivrons.TabIndex = 6
        chkPoivrons.Text = "poivrons"
        chkPoivrons.UseVisualStyleBackColor = True
        ' 
        ' chkFromage
        ' 
        chkFromage.AutoSize = True
        chkFromage.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkFromage.Location = New Point(432, 285)
        chkFromage.Name = "chkFromage"
        chkFromage.Size = New Size(261, 28)
        chkFromage.TabIndex = 7
        chkFromage.Text = "fromage supplementaire"
        chkFromage.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(197, 122)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(212, 181)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(565, 137)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(155, 133)
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(58, 322)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(143, 107)
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(504, 319)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(216, 117)
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' btnAfficherCommande
        ' 
        btnAfficherCommande.BackColor = Color.RosyBrown
        btnAfficherCommande.Font = New Font("Arial", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAfficherCommande.ForeColor = Color.Brown
        btnAfficherCommande.Location = New Point(315, 400)
        btnAfficherCommande.Name = "btnAfficherCommande"
        btnAfficherCommande.Size = New Size(103, 38)
        btnAfficherCommande.TabIndex = 12
        btnAfficherCommande.Text = "afficher"
        btnAfficherCommande.UseVisualStyleBackColor = False
        ' 
        ' pizza
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAfficherCommande)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(chkFromage)
        Controls.Add(chkPoivrons)
        Controls.Add(chkOlives)
        Controls.Add(chkChampignons)
        Controls.Add(radCrouteEpaisse)
        Controls.Add(radCrouteClassique)
        Controls.Add(radCrouteFine)
        Controls.Add(cmbTaille)
        Name = "pizza"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbTaille As ComboBox
    Friend WithEvents radCrouteFine As RadioButton
    Friend WithEvents radCrouteClassique As RadioButton
    Friend WithEvents radCrouteEpaisse As RadioButton
    Friend WithEvents chkChampignons As CheckBox
    Friend WithEvents chkOlives As CheckBox
    Friend WithEvents chkPoivrons As CheckBox
    Friend WithEvents chkFromage As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnAfficherCommande As Button

End Class
