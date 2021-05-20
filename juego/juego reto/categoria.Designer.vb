<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class categoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(categoria))
        Me.btnCategoria1 = New System.Windows.Forms.Button()
        Me.lblCategorias = New System.Windows.Forms.Label()
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
        Me.btnCategoria1.BackColor = System.Drawing.Color.Peru
        Me.btnCategoria1.Location = New System.Drawing.Point(271, 190)
        Me.btnCategoria1.Name = "btnCategoria1"
        Me.btnCategoria1.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria1.TabIndex = 0
        Me.btnCategoria1.Text = "Historia"
        Me.btnCategoria1.UseVisualStyleBackColor = False
        '
        'lblCategorias
        '
        Me.lblCategorias.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCategorias.Location = New System.Drawing.Point(100, 22)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(293, 40)
        Me.lblCategorias.TabIndex = 1
        Me.lblCategorias.Text = "CATEGORIAS:"
        Me.lblCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCategoria2
        '
        Me.btnCategoria2.BackColor = System.Drawing.Color.Yellow
        Me.btnCategoria2.Location = New System.Drawing.Point(64, 263)
        Me.btnCategoria2.Name = "btnCategoria2"
        Me.btnCategoria2.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria2.TabIndex = 2
        Me.btnCategoria2.Text = "Celebridades"
        Me.btnCategoria2.UseVisualStyleBackColor = False
        '
        'btnAtras
        '
        Me.btnAtras.Location = New System.Drawing.Point(20, 22)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(78, 29)
        Me.btnAtras.TabIndex = 8
        Me.btnAtras.Text = "<<Atras"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnCategoria3
        '
        Me.btnCategoria3.BackColor = System.Drawing.Color.HotPink
        Me.btnCategoria3.Location = New System.Drawing.Point(271, 117)
        Me.btnCategoria3.Name = "btnCategoria3"
        Me.btnCategoria3.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria3.TabIndex = 9
        Me.btnCategoria3.Text = "Entretenimiento"
        Me.btnCategoria3.UseVisualStyleBackColor = False
        '
        'btnCategoria4
        '
        Me.btnCategoria4.BackColor = System.Drawing.Color.GreenYellow
        Me.btnCategoria4.Location = New System.Drawing.Point(271, 263)
        Me.btnCategoria4.Name = "btnCategoria4"
        Me.btnCategoria4.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria4.TabIndex = 10
        Me.btnCategoria4.Text = "Ciencia"
        Me.btnCategoria4.UseVisualStyleBackColor = False
        '
        'btnCategoria5
        '
        Me.btnCategoria5.BackColor = System.Drawing.Color.Tomato
        Me.btnCategoria5.Location = New System.Drawing.Point(64, 190)
        Me.btnCategoria5.Name = "btnCategoria5"
        Me.btnCategoria5.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria5.TabIndex = 11
        Me.btnCategoria5.Text = "Deportes"
        Me.btnCategoria5.UseVisualStyleBackColor = False
        '
        'btnCategoria6
        '
        Me.btnCategoria6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCategoria6.Location = New System.Drawing.Point(64, 117)
        Me.btnCategoria6.Name = "btnCategoria6"
        Me.btnCategoria6.Size = New System.Drawing.Size(142, 34)
        Me.btnCategoria6.TabIndex = 12
        Me.btnCategoria6.Text = "Geografia"
        Me.btnCategoria6.UseVisualStyleBackColor = False
        '
        'btnAleatorio
        '
        Me.btnAleatorio.BackColor = System.Drawing.Color.Orange
        Me.btnAleatorio.Location = New System.Drawing.Point(167, 334)
        Me.btnAleatorio.Name = "btnAleatorio"
        Me.btnAleatorio.Size = New System.Drawing.Size(142, 34)
        Me.btnAleatorio.TabIndex = 13
        Me.btnAleatorio.Text = "Aleatorio"
        Me.btnAleatorio.UseVisualStyleBackColor = False
        '
        'categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(481, 406)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAleatorio)
        Me.Controls.Add(Me.btnCategoria6)
        Me.Controls.Add(Me.btnCategoria5)
        Me.Controls.Add(Me.btnCategoria4)
        Me.Controls.Add(Me.btnCategoria3)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnCategoria2)
        Me.Controls.Add(Me.lblCategorias)
        Me.Controls.Add(Me.btnCategoria1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(497, 445)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(497, 445)
        Me.Name = "categoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRIVIALMI"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents lblCategorias As Label
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
