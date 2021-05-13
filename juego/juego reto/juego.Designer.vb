<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juego
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(135, 28)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(516, 457)
        Me.picFoto.TabIndex = 0
        Me.picFoto.TabStop = False
        '
        'timerImagen
        '
        Me.timerImagen.Interval = 1000
        '
        'btnRespuesta1
        '
        Me.btnRespuesta1.Location = New System.Drawing.Point(12, 245)
        Me.btnRespuesta1.Name = "btnRespuesta1"
        Me.btnRespuesta1.Size = New System.Drawing.Size(375, 123)
        Me.btnRespuesta1.TabIndex = 1
        Me.btnRespuesta1.Text = "v"
        Me.btnRespuesta1.UseVisualStyleBackColor = True
        Me.btnRespuesta1.Visible = False
        '
        'lblPregunta
        '
        Me.lblPregunta.Location = New System.Drawing.Point(257, 101)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(283, 33)
        Me.lblPregunta.TabIndex = 5
        Me.lblPregunta.Text = "Pregunta"
        Me.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPregunta.Visible = False
        '
        'btnRespuesta2
        '
        Me.btnRespuesta2.Location = New System.Drawing.Point(410, 245)
        Me.btnRespuesta2.Name = "btnRespuesta2"
        Me.btnRespuesta2.Size = New System.Drawing.Size(375, 123)
        Me.btnRespuesta2.TabIndex = 6
        Me.btnRespuesta2.Text = "Button2"
        Me.btnRespuesta2.UseVisualStyleBackColor = True
        Me.btnRespuesta2.Visible = False
        '
        'btnRespuesta3
        '
        Me.btnRespuesta3.Location = New System.Drawing.Point(12, 390)
        Me.btnRespuesta3.Name = "btnRespuesta3"
        Me.btnRespuesta3.Size = New System.Drawing.Size(375, 123)
        Me.btnRespuesta3.TabIndex = 7
        Me.btnRespuesta3.Text = "Button3"
        Me.btnRespuesta3.UseVisualStyleBackColor = True
        Me.btnRespuesta3.Visible = False
        '
        'btnRespuesta4
        '
        Me.btnRespuesta4.Location = New System.Drawing.Point(410, 390)
        Me.btnRespuesta4.Name = "btnRespuesta4"
        Me.btnRespuesta4.Size = New System.Drawing.Size(375, 123)
        Me.btnRespuesta4.TabIndex = 8
        Me.btnRespuesta4.Text = "Button4"
        Me.btnRespuesta4.UseVisualStyleBackColor = True
        Me.btnRespuesta4.Visible = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 12)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(54, 27)
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.Text = "Button1"
        Me.btnVolver.UseVisualStyleBackColor = True
        Me.btnVolver.Visible = False
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(721, 28)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(41, 15)
        Me.lblContador.TabIndex = 10
        Me.lblContador.Text = "Label1"
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 538)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.picFoto)
        Me.Controls.Add(Me.btnRespuesta4)
        Me.Controls.Add(Me.btnRespuesta3)
        Me.Controls.Add(Me.btnRespuesta2)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.btnRespuesta1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Juego"
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
End Class
