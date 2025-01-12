<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfaceAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfaceAdmin))
        dgvVol = New DataGridView()
        numVol = New DataGridViewTextBoxColumn()
        dateHeure = New DataGridViewTextBoxColumn()
        destination = New DataGridViewTextBoxColumn()
        PlacesDisponibles = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        DestinationAd = New TextBox()
        NumVolAD = New TextBox()
        PrixAd = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ajouterBtn = New Button()
        modifierBtn = New Button()
        SupprimerBtn = New Button()
        DateAd = New DateTimePicker()
        Dest = New Label()
        PlacesDispo = New NumericUpDown()
        afficherBtn = New Button()
        CType(dgvVol, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PlacesDispo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvVol
        ' 
        dgvVol.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVol.Columns.AddRange(New DataGridViewColumn() {numVol, dateHeure, destination, PlacesDisponibles, Prix})
        dgvVol.Location = New Point(472, 0)
        dgvVol.Name = "dgvVol"
        dgvVol.RowHeadersWidth = 51
        dgvVol.Size = New Size(774, 452)
        dgvVol.TabIndex = 0
        ' 
        ' numVol
        ' 
        numVol.HeaderText = "Numero  Vol"
        numVol.MinimumWidth = 6
        numVol.Name = "numVol"
        numVol.Width = 125
        ' 
        ' dateHeure
        ' 
        dateHeure.HeaderText = "Date/Heure"
        dateHeure.MinimumWidth = 6
        dateHeure.Name = "dateHeure"
        dateHeure.Width = 125
        ' 
        ' destination
        ' 
        destination.HeaderText = "Destination"
        destination.MinimumWidth = 6
        destination.Name = "destination"
        destination.Width = 125
        ' 
        ' PlacesDisponibles
        ' 
        PlacesDisponibles.HeaderText = "PLace Disponibles"
        PlacesDisponibles.MinimumWidth = 6
        PlacesDisponibles.Name = "PlacesDisponibles"
        PlacesDisponibles.Width = 125
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "Prix"
        Prix.MinimumWidth = 6
        Prix.Name = "Prix"
        Prix.Width = 125
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(164, 163)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' DestinationAd
        ' 
        DestinationAd.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DestinationAd.Location = New Point(254, 209)
        DestinationAd.Name = "DestinationAd"
        DestinationAd.Size = New Size(168, 31)
        DestinationAd.TabIndex = 2
        ' 
        ' NumVolAD
        ' 
        NumVolAD.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NumVolAD.Location = New Point(254, 166)
        NumVolAD.Name = "NumVolAD"
        NumVolAD.Size = New Size(168, 31)
        NumVolAD.TabIndex = 4
        ' 
        ' PrixAd
        ' 
        PrixAd.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PrixAd.Location = New Point(254, 386)
        PrixAd.Name = "PrixAd"
        PrixAd.Size = New Size(168, 31)
        PrixAd.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(41, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(124, 28)
        Label1.TabIndex = 6
        Label1.Text = "Numero vol"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(122, 28)
        Label2.TabIndex = 7
        Label2.Text = "Destination"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(74, 389)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 28)
        Label3.TabIndex = 8
        Label3.Text = "Prix"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(66, 267)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 28)
        Label4.TabIndex = 9
        Label4.Text = "Date"
        ' 
        ' ajouterBtn
        ' 
        ajouterBtn.BackColor = Color.IndianRed
        ajouterBtn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ajouterBtn.Location = New Point(197, 479)
        ajouterBtn.Name = "ajouterBtn"
        ajouterBtn.Size = New Size(113, 46)
        ajouterBtn.TabIndex = 10
        ajouterBtn.Text = "Ajouter"
        ajouterBtn.UseVisualStyleBackColor = False
        ' 
        ' modifierBtn
        ' 
        modifierBtn.BackColor = Color.IndianRed
        modifierBtn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        modifierBtn.Location = New Point(344, 479)
        modifierBtn.Name = "modifierBtn"
        modifierBtn.Size = New Size(119, 46)
        modifierBtn.TabIndex = 11
        modifierBtn.Text = "modifier"
        modifierBtn.UseVisualStyleBackColor = False
        ' 
        ' SupprimerBtn
        ' 
        SupprimerBtn.BackColor = Color.IndianRed
        SupprimerBtn.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SupprimerBtn.Location = New Point(505, 479)
        SupprimerBtn.Name = "SupprimerBtn"
        SupprimerBtn.Size = New Size(138, 46)
        SupprimerBtn.TabIndex = 12
        SupprimerBtn.Text = "Supprimer"
        SupprimerBtn.UseVisualStyleBackColor = False
        ' 
        ' DateAd
        ' 
        DateAd.CalendarFont = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateAd.Location = New Point(213, 267)
        DateAd.Name = "DateAd"
        DateAd.Size = New Size(250, 27)
        DateAd.TabIndex = 13
        ' 
        ' Dest
        ' 
        Dest.AutoSize = True
        Dest.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Dest.Location = New Point(25, 326)
        Dest.Name = "Dest"
        Dest.Size = New Size(187, 28)
        Dest.TabIndex = 16
        Dest.Text = "Places Disponibles"
        ' 
        ' PlacesDispo
        ' 
        PlacesDispo.Location = New Point(272, 327)
        PlacesDispo.Name = "PlacesDispo"
        PlacesDispo.Size = New Size(150, 27)
        PlacesDispo.TabIndex = 18
        ' 
        ' afficherBtn
        ' 
        afficherBtn.BackColor = Color.IndianRed
        afficherBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        afficherBtn.Location = New Point(666, 479)
        afficherBtn.Name = "afficherBtn"
        afficherBtn.Size = New Size(124, 46)
        afficherBtn.TabIndex = 19
        afficherBtn.Text = "Afficher"
        afficherBtn.UseVisualStyleBackColor = False
        ' 
        ' InterfaceAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1258, 540)
        Controls.Add(afficherBtn)
        Controls.Add(PlacesDispo)
        Controls.Add(Dest)
        Controls.Add(DateAd)
        Controls.Add(SupprimerBtn)
        Controls.Add(modifierBtn)
        Controls.Add(ajouterBtn)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PrixAd)
        Controls.Add(NumVolAD)
        Controls.Add(DestinationAd)
        Controls.Add(PictureBox1)
        Controls.Add(dgvVol)
        FormBorderStyle = FormBorderStyle.None
        Name = "InterfaceAdmin"
        Text = "InterfaceAdmin"
        CType(dgvVol, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PlacesDispo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvVol As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DestinationAd As TextBox
    Friend WithEvents NumVolAD As TextBox
    Friend WithEvents PrixAd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ajouterBtn As Button
    Friend WithEvents modifierBtn As Button
    Friend WithEvents SupprimerBtn As Button
    Friend WithEvents DateAd As DateTimePicker
    Friend WithEvents numVol As DataGridViewTextBoxColumn
    Friend WithEvents dateHeure As DataGridViewTextBoxColumn
    Friend WithEvents destination As DataGridViewTextBoxColumn
    Friend WithEvents PlacesDisponibles As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Dest As Label
    Friend WithEvents PlacesDispo As NumericUpDown
    Friend WithEvents afficherBtn As Button
End Class
