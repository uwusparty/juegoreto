<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class categoria
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
        Me.btnCategoria1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCategoria2 = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnCategoria3 = New System.Windows.Forms.Button()
        Me.btnCategoria4 = New System.Windows.Forms.Button()
        Me.btnCategoria5 = New System.Windows.Forms.Button()
        Me.btnCategoria6 = New System.Windows.Forms.Button()
        Me.btnAleatorio = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCategoria1
        '
        Me.btnCategoria1.BackColor = System.Drawing.Color.Transparent
        Me.btnCategoria1.Location = New System.Drawing.Point(66, 92)
        Me.btnCategoria1.Name = "btnCategoria1"
        Me.btnCategoria1.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria1.TabIndex = 0
        Me.btnCategoria1.Text = "categoria1"
        Me.btnCategoria1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(104, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CATEGORIAS:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCategoria2
        '
        Me.btnCategoria2.BackColor = System.Drawing.Color.Transparent
        Me.btnCategoria2.Location = New System.Drawing.Point(324, 92)
        Me.btnCategoria2.Name = "btnCategoria2"
        Me.btnCategoria2.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria2.TabIndex = 2
        Me.btnCategoria2.Text = "categoria2"
        Me.btnCategoria2.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(20, 15)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(78, 29)
        Me.btnAtras.TabIndex = 8
        Me.btnAtras.Text = "<<Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnCategoria3
        '
        Me.btnCategoria3.BackColor = System.Drawing.Color.Transparent
        Me.btnCategoria3.Location = New System.Drawing.Point(66, 158)
        Me.btnCategoria3.Name = "btnCategoria3"
        Me.btnCategoria3.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria3.TabIndex = 9
        Me.btnCategoria3.Text = "categoria3"
        Me.btnCategoria3.UseVisualStyleBackColor = False
        '
        'btnCategoria4
        '
        Me.btnCategoria4.BackColor = System.Drawing.Color.Transparent
        Me.btnCategoria4.Location = New System.Drawing.Point(324, 158)
        Me.btnCategoria4.Name = "btnCategoria4"
        Me.btnCategoria4.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria4.TabIndex = 10
        Me.btnCategoria4.Text = "categoria4"
        Me.btnCategoria4.UseVisualStyleBackColor = False
        '
        'btnCategoria5
        '
        Me.btnCategoria5.BackColor = System.Drawing.Color.Transparent
        Me.btnCategoria5.Location = New System.Drawing.Point(66, 225)
        Me.btnCategoria5.Name = "btnCategoria5"
        Me.btnCategoria5.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria5.TabIndex = 11
        Me.btnCategoria5.Text = "categoria5"
        Me.btnCategoria5.UseVisualStyleBackColor = False
        '
        'btnCategoria6
        '
        Me.btnCategoria6.BackColor = System.Drawing.Color.Transparent
        Me.btnCategoria6.Location = New System.Drawing.Point(324, 225)
        Me.btnCategoria6.Name = "btnCategoria6"
        Me.btnCategoria6.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria6.TabIndex = 12
        Me.btnCategoria6.Text = "categoria6"
        Me.btnCategoria6.UseVisualStyleBackColor = False
        '
        'btnAleatorio
        '
        Me.btnAleatorio.BackColor = System.Drawing.Color.Transparent
        Me.btnAleatorio.Location = New System.Drawing.Point(195, 280)
        Me.btnAleatorio.Name = "btnAleatorio"
        Me.btnAleatorio.Size = New System.Drawing.Size(142, 34)
        Me.btnAleatorio.TabIndex = 13
        Me.btnAleatorio.Text = "aleatorio"
        Me.btnAleatorio.UseVisualStyleBackColor = False
        '
        'categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(543, 357)
        Me.Controls.Add(Me.btnAleatorio)
        Me.Controls.Add(Me.btnCategoria6)
        Me.Controls.Add(Me.btnCategoria5)
        Me.Controls.Add(Me.btnCategoria4)
        Me.Controls.Add(Me.btnCategoria3)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnCategoria2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCategoria1)
        Me.Name = "categoria"
        Me.Text = "categoria"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCategoria4 As Button
    Friend WithEvents btnCategoria5 As Button
    Friend WithEvents btnCategoria6 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents btnCategoria1 As Button
    Friend WithEvents btnCategoria2 As Button
    Friend WithEvents btnCategoria3 As Button
    Friend WithEvents btnAleatorio As Button
End Class
