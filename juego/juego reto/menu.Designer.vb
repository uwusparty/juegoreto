<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menu))
        Me.btnJugar = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnIdioma = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnAmigos = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnJugar
        '
        Me.btnJugar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnJugar.FlatAppearance.BorderSize = 0
        Me.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJugar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnJugar.ForeColor = System.Drawing.Color.White
        Me.btnJugar.Location = New System.Drawing.Point(97, 163)
        Me.btnJugar.Name = "btnJugar"
        Me.btnJugar.Size = New System.Drawing.Size(342, 71)
        Me.btnJugar.TabIndex = 1
        Me.btnJugar.Text = "JUGAR"
        Me.btnJugar.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(97, 240)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(342, 71)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "INICIAR SESIÓN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnIdioma
        '
        Me.btnIdioma.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIdioma.FlatAppearance.BorderSize = 0
        Me.btnIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIdioma.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnIdioma.ForeColor = System.Drawing.Color.White
        Me.btnIdioma.Location = New System.Drawing.Point(97, 394)
        Me.btnIdioma.Name = "btnIdioma"
        Me.btnIdioma.Size = New System.Drawing.Size(342, 71)
        Me.btnIdioma.TabIndex = 3
        Me.btnIdioma.Text = "CAMBIAR A INGLES"
        Me.btnIdioma.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(97, 471)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(342, 71)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMensaje.ForeColor = System.Drawing.Color.Red
        Me.lblMensaje.Location = New System.Drawing.Point(132, 110)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(284, 40)
        Me.lblMensaje.TabIndex = 9
        Me.lblMensaje.Text = "Usuario no logueado"
        Me.lblMensaje.Visible = False
        '
        'btnAmigos
        '
        Me.btnAmigos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAmigos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAmigos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAmigos.FlatAppearance.BorderSize = 0
        Me.btnAmigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAmigos.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnAmigos.ForeColor = System.Drawing.Color.White
        Me.btnAmigos.Location = New System.Drawing.Point(97, 317)
        Me.btnAmigos.Name = "btnAmigos"
        Me.btnAmigos.Size = New System.Drawing.Size(342, 71)
        Me.btnAmigos.TabIndex = 5
        Me.btnAmigos.Text = "AMIGOS"
        Me.btnAmigos.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.juego_reto.My.Resources.Resources.logo_large
        Me.PictureBox5.InitialImage = Global.juego_reto.My.Resources.Resources.logo_large
        Me.PictureBox5.Location = New System.Drawing.Point(97, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(342, 81)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.juego_reto.My.Resources.Resources.rayas
        Me.ClientSize = New System.Drawing.Size(541, 598)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnAmigos)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIdioma)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnJugar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(557, 637)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(557, 637)
        Me.Name = "menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIVIALMI"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnJugar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnIdioma As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnAmigos As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
