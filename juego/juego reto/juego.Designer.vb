<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Juego
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Juego))
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.timerImagen = New System.Windows.Forms.Timer(Me.components)
        Me.btnRespuesta1 = New System.Windows.Forms.Button()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.btnRespuesta2 = New System.Windows.Forms.Button()
        Me.btnRespuesta3 = New System.Windows.Forms.Button()
        Me.btnRespuesta4 = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.btnValorar = New System.Windows.Forms.Button()
        Me.btnPausa = New System.Windows.Forms.Button()
        Me.lblPuntuacion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumpregunta = New System.Windows.Forms.Label()
        Me.lblPausar = New System.Windows.Forms.Label()
        Me.lblElegido1 = New System.Windows.Forms.Label()
        Me.lblElegido3 = New System.Windows.Forms.Label()
        Me.lblElegido2 = New System.Windows.Forms.Label()
        Me.lblElegido4 = New System.Windows.Forms.Label()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFoto
        '
        Me.picFoto.BackColor = System.Drawing.Color.Transparent
        Me.picFoto.Location = New System.Drawing.Point(133, 52)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(516, 457)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'timerImagen
        '
        Me.timerImagen.Interval = 1000
        '
        'btnRespuesta1
        '
        Me.btnRespuesta1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRespuesta1.Location = New System.Drawing.Point(12, 245)
        Me.btnRespuesta1.Name = "btnRespuesta1"
        Me.btnRespuesta1.Size = New System.Drawing.Size(375, 123)
        Me.btnRespuesta1.TabIndex = 1
        Me.btnRespuesta1.Text = "btn1"
        Me.btnRespuesta1.UseVisualStyleBackColor = True
        Me.btnRespuesta1.Visible = False
        '
        'lblPregunta
        '
        Me.lblPregunta.BackColor = System.Drawing.Color.Transparent
        Me.lblPregunta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPregunta.Location = New System.Drawing.Point(97, 52)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(593, 131)
        Me.lblPregunta.TabIndex = 5
        Me.lblPregunta.Text = "Pregunta"
        Me.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPregunta.Visible = False
        '
        'btnRespuesta2
        '
        Me.btnRespuesta2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRespuesta2.Location = New System.Drawing.Point(410, 245)
        Me.btnRespuesta2.Name = "btnRespuesta2"
        Me.btnRespuesta2.Size = New System.Drawing.Size(375, 123)
        Me.btnRespuesta2.TabIndex = 6
        Me.btnRespuesta2.Text = "btn2"
        Me.btnRespuesta2.UseVisualStyleBackColor = True
        Me.btnRespuesta2.Visible = False
        '
        'btnRespuesta3
        '
        Me.btnRespuesta3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRespuesta3.Location = New System.Drawing.Point(12, 390)
        Me.btnRespuesta3.Name = "btnRespuesta3"
        Me.btnRespuesta3.Size = New System.Drawing.Size(375, 123)
        Me.btnRespuesta3.TabIndex = 7
        Me.btnRespuesta3.Text = "btn3"
        Me.btnRespuesta3.UseVisualStyleBackColor = True
        Me.btnRespuesta3.Visible = False
        '
        'btnRespuesta4
        '
        Me.btnRespuesta4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRespuesta4.Location = New System.Drawing.Point(410, 390)
        Me.btnRespuesta4.Name = "btnRespuesta4"
        Me.btnRespuesta4.Size = New System.Drawing.Size(375, 123)
        Me.btnRespuesta4.TabIndex = 8
        Me.btnRespuesta4.Text = "btn4"
        Me.btnRespuesta4.UseVisualStyleBackColor = True
        Me.btnRespuesta4.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.White
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 27)
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.Text = "<<ATRAS"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.BackColor = System.Drawing.Color.Transparent
        Me.lblContador.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblContador.Location = New System.Drawing.Point(687, 12)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(23, 28)
        Me.lblContador.TabIndex = 10
        Me.lblContador.Text = "0"
        Me.lblContador.Visible = False
        '
        'btnValorar
        '
        Me.btnValorar.BackColor = System.Drawing.Color.White
        Me.btnValorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValorar.Location = New System.Drawing.Point(12, 202)
        Me.btnValorar.Name = "btnValorar"
        Me.btnValorar.Size = New System.Drawing.Size(102, 29)
        Me.btnValorar.TabIndex = 11
        Me.btnValorar.Text = "<3"
        Me.btnValorar.UseVisualStyleBackColor = False
        Me.btnValorar.Visible = False
        '
        'btnPausa
        '
        Me.btnPausa.BackColor = System.Drawing.Color.White
        Me.btnPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPausa.Location = New System.Drawing.Point(12, 72)
        Me.btnPausa.Name = "btnPausa"
        Me.btnPausa.Size = New System.Drawing.Size(75, 27)
        Me.btnPausa.TabIndex = 14
        Me.btnPausa.Text = "Pausa"
        Me.btnPausa.UseVisualStyleBackColor = False
        '
        'lblPuntuacion
        '
        Me.lblPuntuacion.AutoSize = True
        Me.lblPuntuacion.BackColor = System.Drawing.Color.Transparent
        Me.lblPuntuacion.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPuntuacion.Location = New System.Drawing.Point(414, 12)
        Me.lblPuntuacion.Name = "lblPuntuacion"
        Me.lblPuntuacion.Size = New System.Drawing.Size(24, 28)
        Me.lblPuntuacion.TabIndex = 15
        Me.lblPuntuacion.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(294, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 28)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Puntuacion:"
        '
        'lblNumpregunta
        '
        Me.lblNumpregunta.AutoSize = True
        Me.lblNumpregunta.BackColor = System.Drawing.Color.Transparent
        Me.lblNumpregunta.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNumpregunta.Location = New System.Drawing.Point(133, 12)
        Me.lblNumpregunta.Name = "lblNumpregunta"
        Me.lblNumpregunta.Size = New System.Drawing.Size(63, 28)
        Me.lblNumpregunta.TabIndex = 17
        Me.lblNumpregunta.Text = "0 / 10"
        '
        'lblPausar
        '
        Me.lblPausar.AutoSize = True
        Me.lblPausar.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPausar.Location = New System.Drawing.Point(282, 183)
        Me.lblPausar.Name = "lblPausar"
        Me.lblPausar.Size = New System.Drawing.Size(255, 47)
        Me.lblPausar.TabIndex = 18
        Me.lblPausar.Text = "Juego Pausado"
        Me.lblPausar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPausar.Visible = False
        '
        'lblElegido1
        '
        Me.lblElegido1.BackColor = System.Drawing.Color.Transparent
        Me.lblElegido1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblElegido1.Location = New System.Drawing.Point(294, 339)
        Me.lblElegido1.Name = "lblElegido1"
        Me.lblElegido1.Size = New System.Drawing.Size(84, 19)
        Me.lblElegido1.TabIndex = 19
        Me.lblElegido1.Text = "0%"
        Me.lblElegido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblElegido1.Visible = False
        '
        'lblElegido3
        '
        Me.lblElegido3.BackColor = System.Drawing.Color.Transparent
        Me.lblElegido3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblElegido3.Location = New System.Drawing.Point(294, 483)
        Me.lblElegido3.Name = "lblElegido3"
        Me.lblElegido3.Size = New System.Drawing.Size(84, 19)
        Me.lblElegido3.TabIndex = 20
        Me.lblElegido3.Text = "0%"
        Me.lblElegido3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblElegido3.Visible = False
        '
        'lblElegido2
        '
        Me.lblElegido2.BackColor = System.Drawing.Color.Transparent
        Me.lblElegido2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblElegido2.Location = New System.Drawing.Point(691, 339)
        Me.lblElegido2.Name = "lblElegido2"
        Me.lblElegido2.Size = New System.Drawing.Size(84, 19)
        Me.lblElegido2.TabIndex = 21
        Me.lblElegido2.Text = "0%"
        Me.lblElegido2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblElegido2.Visible = False
        '
        'lblElegido4
        '
        Me.lblElegido4.BackColor = System.Drawing.Color.Transparent
        Me.lblElegido4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblElegido4.Location = New System.Drawing.Point(691, 483)
        Me.lblElegido4.Name = "lblElegido4"
        Me.lblElegido4.Size = New System.Drawing.Size(84, 19)
        Me.lblElegido4.TabIndex = 22
        Me.lblElegido4.Text = "0%"
        Me.lblElegido4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblElegido4.Visible = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(797, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblElegido4)
        Me.Controls.Add(Me.lblElegido2)
        Me.Controls.Add(Me.lblElegido3)
        Me.Controls.Add(Me.lblElegido1)
        Me.Controls.Add(Me.lblPausar)
        Me.Controls.Add(Me.lblNumpregunta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPuntuacion)
        Me.Controls.Add(Me.btnPausa)
        Me.Controls.Add(Me.btnValorar)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnRespuesta4)
        Me.Controls.Add(Me.btnRespuesta3)
        Me.Controls.Add(Me.btnRespuesta2)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.btnRespuesta1)
        Me.Controls.Add(Me.picFoto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(813, 577)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(813, 577)
        Me.Name = "Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIVIALMI"
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picFoto As PictureBox
    Friend WithEvents timerImagen As Timer
    Friend WithEvents btnRespuesta1 As Button
    Friend WithEvents lblPregunta As Label
    Friend WithEvents btnRespuesta2 As Button
    Friend WithEvents btnRespuesta3 As Button
    Friend WithEvents btnRespuesta4 As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblContador As Label
    Friend WithEvents btnValorar As Button
    Friend WithEvents btnPausa As Button
    Friend WithEvents lblPuntuacion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumpregunta As Label
    Friend WithEvents lblPausar As Label
    Friend WithEvents lblElegido1 As Label
    Friend WithEvents lblElegido3 As Label
    Friend WithEvents lblElegido2 As Label
    Friend WithEvents lblElegido4 As Label
End Class
