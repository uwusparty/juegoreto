<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class puntuaciones
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lstPuntuaciones = New System.Windows.Forms.ListBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Snap ITC", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.lblUsuario.Location = New System.Drawing.Point(85, 23)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(226, 25)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "LISTA DE AMIGOS"
        '
        'lstPuntuaciones
        '
        Me.lstPuntuaciones.FormattingEnabled = True
        Me.lstPuntuaciones.ItemHeight = 15
        Me.lstPuntuaciones.Location = New System.Drawing.Point(112, 62)
        Me.lstPuntuaciones.Name = "lstPuntuaciones"
        Me.lstPuntuaciones.Size = New System.Drawing.Size(168, 319)
        Me.lstPuntuaciones.TabIndex = 1
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(64, 415)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(116, 56)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "MENU PRINCIPAL"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(208, 415)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(116, 56)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'puntuaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(395, 528)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.lstPuntuaciones)
        Me.Controls.Add(Me.lblUsuario)
        Me.Name = "puntuaciones"
        Me.Text = "puntuaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lstPuntuaciones As ListBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents btnSalir As Button
End Class
