<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmMoverCarros = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Empezar = New System.Windows.Forms.Button()
        Me.tmMoverCalle = New System.Windows.Forms.Timer(Me.components)
        Me.Principal = New System.Windows.Forms.PictureBox()
        Me.Ego = New System.Windows.Forms.PictureBox()
        Me.Calle2 = New System.Windows.Forms.PictureBox()
        Me.Calle1 = New System.Windows.Forms.PictureBox()
        Me.Calle3 = New System.Windows.Forms.PictureBox()
        Me.Escenario1 = New System.Windows.Forms.Button()
        Me.Escenario2 = New System.Windows.Forms.Button()
        Me.Escenario3 = New System.Windows.Forms.Button()
        Me.Escenario4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Principal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ego, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calle3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmMoverCarros
        '
        Me.tmMoverCarros.Interval = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.Empezar)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(115, 100)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.IndianRed
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Snow
        Me.btnSalir.Location = New System.Drawing.Point(15, 57)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 28)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Empezar
        '
        Me.Empezar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Empezar.Enabled = False
        Me.Empezar.FlatAppearance.BorderSize = 0
        Me.Empezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Empezar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Empezar.ForeColor = System.Drawing.Color.Snow
        Me.Empezar.Location = New System.Drawing.Point(16, 19)
        Me.Empezar.Name = "Empezar"
        Me.Empezar.Size = New System.Drawing.Size(86, 32)
        Me.Empezar.TabIndex = 15
        Me.Empezar.Text = "Empezar"
        Me.Empezar.UseVisualStyleBackColor = False
        '
        'tmMoverCalle
        '
        '
        'Principal
        '
        Me.Principal.BackColor = System.Drawing.Color.Lime
        Me.Principal.Image = Global.FrmMain.My.Resources.Resources.Carro
        Me.Principal.Location = New System.Drawing.Point(37, 19)
        Me.Principal.Name = "Principal"
        Me.Principal.Size = New System.Drawing.Size(65, 85)
        Me.Principal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Principal.TabIndex = 6
        Me.Principal.TabStop = False
        '
        'Ego
        '
        Me.Ego.Image = Global.FrmMain.My.Resources.Resources.Carro
        Me.Ego.Location = New System.Drawing.Point(40, -86)
        Me.Ego.Name = "Ego"
        Me.Ego.Size = New System.Drawing.Size(65, 85)
        Me.Ego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ego.TabIndex = 5
        Me.Ego.TabStop = False
        '
        'Calle2
        '
        Me.Calle2.Image = Global.FrmMain.My.Resources.Resources.Pista
        Me.Calle2.Location = New System.Drawing.Point(0, -365)
        Me.Calle2.Name = "Calle2"
        Me.Calle2.Size = New System.Drawing.Size(273, 369)
        Me.Calle2.TabIndex = 23
        Me.Calle2.TabStop = False
        '
        'Calle1
        '
        Me.Calle1.Image = Global.FrmMain.My.Resources.Resources.Pista
        Me.Calle1.Location = New System.Drawing.Point(0, 0)
        Me.Calle1.Name = "Calle1"
        Me.Calle1.Size = New System.Drawing.Size(273, 369)
        Me.Calle1.TabIndex = 22
        Me.Calle1.TabStop = False
        '
        'Calle3
        '
        Me.Calle3.Image = Global.FrmMain.My.Resources.Resources.Pista
        Me.Calle3.Location = New System.Drawing.Point(0, 730)
        Me.Calle3.Name = "Calle3"
        Me.Calle3.Size = New System.Drawing.Size(273, 369)
        Me.Calle3.TabIndex = 24
        Me.Calle3.TabStop = False
        '
        'Escenario1
        '
        Me.Escenario1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Escenario1.FlatAppearance.BorderSize = 0
        Me.Escenario1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Escenario1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Escenario1.ForeColor = System.Drawing.Color.Snow
        Me.Escenario1.Location = New System.Drawing.Point(15, 19)
        Me.Escenario1.Name = "Escenario1"
        Me.Escenario1.Size = New System.Drawing.Size(86, 28)
        Me.Escenario1.TabIndex = 15
        Me.Escenario1.Text = "Escenario 1"
        Me.Escenario1.UseVisualStyleBackColor = False
        '
        'Escenario2
        '
        Me.Escenario2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Escenario2.FlatAppearance.BorderSize = 0
        Me.Escenario2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Escenario2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Escenario2.ForeColor = System.Drawing.Color.Snow
        Me.Escenario2.Location = New System.Drawing.Point(14, 53)
        Me.Escenario2.Name = "Escenario2"
        Me.Escenario2.Size = New System.Drawing.Size(87, 28)
        Me.Escenario2.TabIndex = 16
        Me.Escenario2.Text = "Escenario 2"
        Me.Escenario2.UseVisualStyleBackColor = False
        '
        'Escenario3
        '
        Me.Escenario3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Escenario3.FlatAppearance.BorderSize = 0
        Me.Escenario3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Escenario3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Escenario3.ForeColor = System.Drawing.Color.Snow
        Me.Escenario3.Location = New System.Drawing.Point(14, 87)
        Me.Escenario3.Name = "Escenario3"
        Me.Escenario3.Size = New System.Drawing.Size(86, 28)
        Me.Escenario3.TabIndex = 17
        Me.Escenario3.Text = "Escenario 3"
        Me.Escenario3.UseVisualStyleBackColor = False
        '
        'Escenario4
        '
        Me.Escenario4.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Escenario4.FlatAppearance.BorderSize = 0
        Me.Escenario4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Escenario4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Escenario4.ForeColor = System.Drawing.Color.Snow
        Me.Escenario4.Location = New System.Drawing.Point(13, 121)
        Me.Escenario4.Name = "Escenario4"
        Me.Escenario4.Size = New System.Drawing.Size(87, 28)
        Me.Escenario4.TabIndex = 18
        Me.Escenario4.Text = "Escenario 4"
        Me.Escenario4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Escenario4)
        Me.GroupBox1.Controls.Add(Me.Escenario3)
        Me.GroupBox1.Controls.Add(Me.Escenario2)
        Me.GroupBox1.Controls.Add(Me.Escenario1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(308, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 164)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(448, 365)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Principal)
        Me.Controls.Add(Me.Ego)
        Me.Controls.Add(Me.Calle2)
        Me.Controls.Add(Me.Calle1)
        Me.Controls.Add(Me.Calle3)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(464, 404)
        Me.MinimumSize = New System.Drawing.Size(464, 404)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulador de Sistema ACC"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Principal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ego, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calle3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ego As PictureBox

    Friend WithEvents Principal As PictureBox
    Friend WithEvents tmMoverCarros As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents Empezar As Button
    Friend WithEvents Calle1 As PictureBox
    Friend WithEvents Calle2 As PictureBox
    Friend WithEvents tmMoverCalle As Timer
    Friend WithEvents Calle3 As PictureBox
    Friend WithEvents Escenario1 As Button
    Friend WithEvents Escenario2 As Button
    Friend WithEvents Escenario3 As Button
    Friend WithEvents Escenario4 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
