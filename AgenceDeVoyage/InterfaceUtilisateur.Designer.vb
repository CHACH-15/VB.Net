<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfaceUtilisateur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfaceUtilisateur))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        DateD = New DateTimePicker()
        BtnRecherche = New Button()
        Label2 = New Label()
        Label1 = New Label()
        DestinaTionTxTb = New TextBox()
        Panel2 = New Panel()
        BtnReserver = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        NumTelTXTbox = New TextBox()
        PrenomTxtBox = New TextBox()
        NomTxtBox = New TextBox()
        dgvVol = New DataGridView()
        NumeVol = New DataGridViewTextBoxColumn()
        Destination = New DataGridViewTextBoxColumn()
        DateVol = New DataGridViewTextBoxColumn()
        PDs = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(dgvVol, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PeachPuff
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(DateD)
        Panel1.Controls.Add(BtnRecherche)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(DestinaTionTxTb)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(407, 583)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 276)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(407, 303)
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' DateD
        ' 
        DateD.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateD.Location = New Point(134, 105)
        DateD.Name = "DateD"
        DateD.Size = New Size(250, 31)
        DateD.TabIndex = 5
        ' 
        ' BtnRecherche
        ' 
        BtnRecherche.BackColor = Color.Chocolate
        BtnRecherche.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRecherche.Location = New Point(91, 181)
        BtnRecherche.Name = "BtnRecherche"
        BtnRecherche.Size = New Size(207, 51)
        BtnRecherche.TabIndex = 4
        BtnRecherche.Text = "rechercher"
        BtnRecherche.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(29, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 28)
        Label2.TabIndex = 2
        Label2.Text = "date"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 28)
        Label1.TabIndex = 1
        Label1.Text = "destination"
        ' 
        ' DestinaTionTxTb
        ' 
        DestinaTionTxTb.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DestinaTionTxTb.Location = New Point(173, 47)
        DestinaTionTxTb.Name = "DestinaTionTxTb"
        DestinaTionTxTb.Size = New Size(211, 34)
        DestinaTionTxTb.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Peru
        Panel2.Controls.Add(BtnReserver)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(NumTelTXTbox)
        Panel2.Controls.Add(PrenomTxtBox)
        Panel2.Controls.Add(NomTxtBox)
        Panel2.Controls.Add(dgvVol)
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(416, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(710, 583)
        Panel2.TabIndex = 1
        ' 
        ' BtnReserver
        ' 
        BtnReserver.BackColor = Color.Firebrick
        BtnReserver.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnReserver.ForeColor = SystemColors.ButtonFace
        BtnReserver.Location = New Point(223, 458)
        BtnReserver.Name = "BtnReserver"
        BtnReserver.Size = New Size(156, 60)
        BtnReserver.TabIndex = 4
        BtnReserver.Text = "Reserver"
        BtnReserver.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(9, 371)
        Label5.Name = "Label5"
        Label5.Size = New Size(192, 28)
        Label5.TabIndex = 7
        Label5.Text = "Numero Telephone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 299)
        Label4.Name = "Label4"
        Label4.Size = New Size(85, 28)
        Label4.TabIndex = 6
        Label4.Text = "Prenom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 28)
        Label3.TabIndex = 5
        Label3.Text = "Nom"
        ' 
        ' NumTelTXTbox
        ' 
        NumTelTXTbox.Location = New Point(233, 375)
        NumTelTXTbox.Name = "NumTelTXTbox"
        NumTelTXTbox.Size = New Size(125, 27)
        NumTelTXTbox.TabIndex = 3
        ' 
        ' PrenomTxtBox
        ' 
        PrenomTxtBox.Location = New Point(122, 299)
        PrenomTxtBox.Name = "PrenomTxtBox"
        PrenomTxtBox.Size = New Size(125, 27)
        PrenomTxtBox.TabIndex = 2
        ' 
        ' NomTxtBox
        ' 
        NomTxtBox.Location = New Point(76, 233)
        NomTxtBox.Name = "NomTxtBox"
        NomTxtBox.Size = New Size(125, 27)
        NomTxtBox.TabIndex = 1
        ' 
        ' dgvVol
        ' 
        dgvVol.BackgroundColor = Color.Silver
        dgvVol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVol.Columns.AddRange(New DataGridViewColumn() {NumeVol, Destination, DateVol, PDs, Prix})
        dgvVol.GridColor = SystemColors.Info
        dgvVol.Location = New Point(0, 3)
        dgvVol.Name = "dgvVol"
        dgvVol.RowHeadersWidth = 51
        dgvVol.Size = New Size(710, 188)
        dgvVol.TabIndex = 0
        ' 
        ' NumeVol
        ' 
        NumeVol.HeaderText = "Numéro Vol"
        NumeVol.MinimumWidth = 6
        NumeVol.Name = "NumeVol"
        NumeVol.Width = 125
        ' 
        ' Destination
        ' 
        Destination.HeaderText = "Destination"
        Destination.MinimumWidth = 6
        Destination.Name = "Destination"
        Destination.Width = 125
        ' 
        ' DateVol
        ' 
        DateVol.HeaderText = "Date"
        DateVol.MinimumWidth = 6
        DateVol.Name = "DateVol"
        DateVol.Width = 125
        ' 
        ' PDs
        ' 
        PDs.HeaderText = "Places Disponibles"
        PDs.MinimumWidth = 6
        PDs.Name = "PDs"
        PDs.Width = 126
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "Prix"
        Prix.MinimumWidth = 6
        Prix.Name = "Prix"
        Prix.Width = 125
        ' 
        ' InterfaceUtilisateur
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1126, 583)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "InterfaceUtilisateur"
        Text = "InterfaceUtilisateur"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvVol, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DestinaTionTxTb As TextBox
    Friend WithEvents DateD As DateTimePicker
    Friend WithEvents BtnRecherche As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvVol As DataGridView
    Friend WithEvents PrenomTxtBox As TextBox
    Friend WithEvents NomTxtBox As TextBox
    Friend WithEvents BtnReserver As Button
    Friend WithEvents NumTelTXTbox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Places_Disponibles As DataGridViewTextBoxColumn
    Friend WithEvents PlacesDisponibles As DataGridViewTextBoxColumn
    Friend WithEvents NumeVol As DataGridViewTextBoxColumn
    Friend WithEvents Destination As DataGridViewTextBoxColumn
    Friend WithEvents DateVol As DataGridViewTextBoxColumn
    Friend WithEvents PDs As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
End Class
