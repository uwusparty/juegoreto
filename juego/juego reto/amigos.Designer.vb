<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class amigos
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
        Me.lstAmigos = New System.Windows.Forms.ListBox()
        Me.lblAmigos = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstAmigos
        '
        Me.lstAmigos.FormattingEnabled = True
        Me.lstAmigos.ItemHeight = 15
        Me.lstAmigos.Location = New System.Drawing.Point(28, 47)
        Me.lstAmigos.Name = "lstAmigos"
        Me.lstAmigos.Size = New System.Drawing.Size(181, 319)
        Me.lstAmigos.TabIndex = 0
        '
        'lblAmigos
        '
        Me.lblAmigos.AutoSize = True
        Me.lblAmigos.Location = New System.Drawing.Point(28, 20)
        Me.lblAmigos.Name = "lblAmigos"
        Me.lblAmigos.Size = New System.Drawing.Size(51, 15)
        Me.lblAmigos.TabIndex = 1
        Me.lblAmigos.Text = "Amigos:"
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(28, 389)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(84, 33)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "BORRAR"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(128, 389)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(81, 33)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "CERRAR"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'amigos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(235, 433)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.lblAmigos)
        Me.Controls.Add(Me.lstAmigos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(251, 472)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(251, 472)
        Me.Name = "amigos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trivialmi"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstAmigos As ListBox
    Friend WithEvents lblAmigos As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lstAmigo As ListBox
End Class
