<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Puntuaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Puntuaciones))
        Me.lstPuntuacion = New System.Windows.Forms.ListBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtPuntuacion = New System.Windows.Forms.TextBox()
        Me.lblPuntuacion = New System.Windows.Forms.Label()
        Me.lblTop10 = New System.Windows.Forms.Label()
        Me.pbRuleta2 = New System.Windows.Forms.PictureBox()
        Me.pbRuleta1 = New System.Windows.Forms.PictureBox()
        Me.tmRuleta = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pbRuleta2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRuleta1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstPuntuacion
        '
        Me.lstPuntuacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstPuntuacion.FormattingEnabled = True
        Me.lstPuntuacion.ItemHeight = 21
        Me.lstPuntuacion.Location = New System.Drawing.Point(104, 133)
        Me.lstPuntuacion.Name = "lstPuntuacion"
        Me.lstPuntuacion.Size = New System.Drawing.Size(168, 214)
        Me.lstPuntuacion.TabIndex = 1
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(59, 367)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(116, 56)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "MENU PRINCIPAL"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(204, 367)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 56)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtPuntuacion
        '
        Me.txtPuntuacion.BackColor = System.Drawing.Color.White
        Me.txtPuntuacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPuntuacion.Location = New System.Drawing.Point(105, 62)
        Me.txtPuntuacion.Name = "txtPuntuacion"
        Me.txtPuntuacion.ReadOnly = True
        Me.txtPuntuacion.Size = New System.Drawing.Size(168, 29)
        Me.txtPuntuacion.TabIndex = 4
        Me.txtPuntuacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPuntuacion
        '
        Me.lblPuntuacion.AutoSize = True
        Me.lblPuntuacion.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPuntuacion.Location = New System.Drawing.Point(105, 30)
        Me.lblPuntuacion.Name = "lblPuntuacion"
        Me.lblPuntuacion.Size = New System.Drawing.Size(167, 25)
        Me.lblPuntuacion.TabIndex = 5
        Me.lblPuntuacion.Text = "Puntuacion Final:"
        '
        'lblTop10
        '
        Me.lblTop10.AutoSize = True
        Me.lblTop10.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTop10.Location = New System.Drawing.Point(59, 105)
        Me.lblTop10.Name = "lblTop10"
        Me.lblTop10.Size = New System.Drawing.Size(261, 25)
        Me.lblTop10.TabIndex = 6
        Me.lblTop10.Text = "Sus 10 mejores puntuaciones:"
        '
        'pbRuleta2
        '
        Me.pbRuleta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbRuleta2.Image = Global.juego_reto.My.Resources.Resources.ruleta_1_
        Me.pbRuleta2.Location = New System.Drawing.Point(303, 10)
        Me.pbRuleta2.Name = "pbRuleta2"
        Me.pbRuleta2.Size = New System.Drawing.Size(65, 81)
        Me.pbRuleta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRuleta2.TabIndex = 7
        Me.pbRuleta2.TabStop = False
        '
        'pbRuleta1
        '
        Me.pbRuleta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbRuleta1.Image = Global.juego_reto.My.Resources.Resources.ruleta_1_
        Me.pbRuleta1.Location = New System.Drawing.Point(12, 10)
        Me.pbRuleta1.Name = "pbRuleta1"
        Me.pbRuleta1.Size = New System.Drawing.Size(65, 81)
        Me.pbRuleta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbRuleta1.TabIndex = 8
        Me.pbRuleta1.TabStop = False
        '
        'tmRuleta
        '
        '
        'Puntuaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbRuleta1)
        Me.Controls.Add(Me.pbRuleta2)
        Me.Controls.Add(Me.lblTop10)
        Me.Controls.Add(Me.lblPuntuacion)
        Me.Controls.Add(Me.txtPuntuacion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lstPuntuacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(396, 493)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(396, 493)
        Me.Name = "Puntuaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIVIALMI"
        CType(Me.pbRuleta2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRuleta1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPuntuaciones As ListBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lstPuntuacion As ListBox
    Friend WithEvents txtPuntuacion As TextBox
    Friend WithEvents lblPuntuacion As Label
    Friend WithEvents lblTop10 As Label
    Friend WithEvents pbRuleta2 As PictureBox
    Friend WithEvents pbRuleta1 As PictureBox
    Friend WithEvents tmRuleta As Timer
End Class
