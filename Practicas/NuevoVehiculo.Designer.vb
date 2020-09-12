<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoVehiculo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtPuertas = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.lblPtas = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PMingLiU-ExtB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATOS DEL VEHICULO"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(261, 412)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(66, 412)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 9
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtPuertas
        '
        Me.txtPuertas.Location = New System.Drawing.Point(172, 331)
        Me.txtPuertas.Name = "txtPuertas"
        Me.txtPuertas.Size = New System.Drawing.Size(153, 20)
        Me.txtPuertas.TabIndex = 7
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(172, 177)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(153, 20)
        Me.txtModelo.TabIndex = 3
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(172, 292)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(153, 20)
        Me.txtColor.TabIndex = 6
        '
        'lblPtas
        '
        Me.lblPtas.AutoSize = True
        Me.lblPtas.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPtas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPtas.Location = New System.Drawing.Point(76, 336)
        Me.lblPtas.Name = "lblPtas"
        Me.lblPtas.Size = New System.Drawing.Size(54, 16)
        Me.lblPtas.TabIndex = 26
        Me.lblPtas.Text = "Puertas"
        Me.lblPtas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(172, 251)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(153, 20)
        Me.txtPrecio.TabIndex = 5
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(76, 182)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(54, 16)
        Me.lblModelo.TabIndex = 28
        Me.lblModelo.Text = "Modelo"
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(76, 92)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(46, 16)
        Me.lblMarca.TabIndex = 17
        Me.lblMarca.Text = "Marca"
        Me.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(172, 214)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(153, 20)
        Me.txtAnio.TabIndex = 4
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(76, 137)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(67, 16)
        Me.lblCategoria.TabIndex = 16
        Me.lblCategoria.Text = "Categoria"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblAnio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnio.Location = New System.Drawing.Point(76, 219)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(37, 16)
        Me.lblAnio.TabIndex = 18
        Me.lblAnio.Text = "AÑO"
        Me.lblAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(76, 256)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(47, 16)
        Me.lblPrecio.TabIndex = 19
        Me.lblPrecio.Text = "Precio"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(172, 132)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(153, 20)
        Me.txtCategoria.TabIndex = 1
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(172, 89)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(153, 20)
        Me.txtMarca.TabIndex = 0
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(76, 297)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(40, 16)
        Me.lblColor.TabIndex = 20
        Me.lblColor.Text = "Color"
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NuevoVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(438, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.txtPuertas)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.lblPtas)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(454, 563)
        Me.Name = "NuevoVehiculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Vehiculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents txtPuertas As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lblPtas As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents lblAnio As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents lblColor As Label
End Class
