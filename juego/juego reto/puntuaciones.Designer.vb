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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Puntuaciones))
        Me.lstPuntuacion = New System.Windows.Forms.ListBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtPuntuacion = New System.Windows.Forms.TextBox()
        Me.lblPuntuacion = New System.Windows.Forms.Label()
        Me.lblTop10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstPuntuacion
        '
        Me.lstPuntuacion.FormattingEnabled = True
        Me.lstPuntuacion.ItemHeight = 15
        Me.lstPuntuacion.Location = New System.Drawing.Point(105, 161)
        Me.lstPuntuacion.Name = "lstPuntuacion"
        Me.lstPuntuacion.Size = New System.Drawing.Size(168, 154)
        Me.lstPuntuacion.TabIndex = 1
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(60, 353)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(116, 56)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "MENU PRINCIPAL"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(205, 353)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 56)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtPuntuacion
        '
        Me.txtPuntuacion.Location = New System.Drawing.Point(105, 73)
        Me.txtPuntuacion.Name = "txtPuntuacion"
        Me.txtPuntuacion.ReadOnly = True
        Me.txtPuntuacion.Size = New System.Drawing.Size(168, 23)
        Me.txtPuntuacion.TabIndex = 4
        '
        'lblPuntuacion
        '
        Me.lblPuntuacion.AutoSize = True
        Me.lblPuntuacion.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPuntuacion.Location = New System.Drawing.Point(105, 41)
        Me.lblPuntuacion.Name = "lblPuntuacion"
        Me.lblPuntuacion.Size = New System.Drawing.Size(157, 25)
        Me.lblPuntuacion.TabIndex = 5
        Me.lblPuntuacion.Text = "Puntuacion Final:"
        '
        'lblTop10
        '
        Me.lblTop10.AutoSize = True
        Me.lblTop10.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTop10.Location = New System.Drawing.Point(60, 133)
        Me.lblTop10.Name = "lblTop10"
        Me.lblTop10.Size = New System.Drawing.Size(261, 25)
        Me.lblTop10.TabIndex = 6
        Me.lblTop10.Text = "Sus 10 mejores puntuaciones:"
        '
        'Puntuaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(380, 454)
        Me.Controls.Add(Me.lblTop10)
        Me.Controls.Add(Me.lblPuntuacion)
        Me.Controls.Add(Me.txtPuntuacion)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lstPuntuacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Puntuaciones"
        Me.Text = "TRIVIALMI"
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
End Class
