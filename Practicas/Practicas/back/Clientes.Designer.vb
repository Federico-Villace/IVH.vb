<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pdatos = New System.Windows.Forms.Panel()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnMostrarTodo = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pdatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Apellido, Me.Nombre})
        Me.dgvClientes.Location = New System.Drawing.Point(27, 85)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(319, 243)
        Me.dgvClientes.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "id_cli"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Ape_cli"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nom_cli"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Pdatos
        '
        Me.Pdatos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pdatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pdatos.Controls.Add(Me.txtMail)
        Me.Pdatos.Controls.Add(Me.txtTelefono)
        Me.Pdatos.Controls.Add(Me.txtDNI)
        Me.Pdatos.Controls.Add(Me.txtNombre)
        Me.Pdatos.Controls.Add(Me.txtApellido)
        Me.Pdatos.Controls.Add(Me.lblMail)
        Me.Pdatos.Controls.Add(Me.lblTelefono)
        Me.Pdatos.Controls.Add(Me.lblDNI)
        Me.Pdatos.Controls.Add(Me.lblNombre)
        Me.Pdatos.Controls.Add(Me.lblApellido)
        Me.Pdatos.Location = New System.Drawing.Point(450, 85)
        Me.Pdatos.Name = "Pdatos"
        Me.Pdatos.Size = New System.Drawing.Size(313, 243)
        Me.Pdatos.TabIndex = 1
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(120, 174)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(153, 20)
        Me.txtMail.TabIndex = 9
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(120, 136)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(153, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(120, 104)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(153, 20)
        Me.txtDNI.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(120, 68)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(153, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(120, 35)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(153, 20)
        Me.txtApellido.TabIndex = 5
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMail.Location = New System.Drawing.Point(31, 174)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(36, 15)
        Me.lblMail.TabIndex = 4
        Me.lblMail.Text = "e-mail"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTelefono.Location = New System.Drawing.Point(31, 136)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(51, 15)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Telefono"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDNI.Location = New System.Drawing.Point(31, 104)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(28, 15)
        Me.lblDNI.TabIndex = 2
        Me.lblDNI.Text = "DNI"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombre.Location = New System.Drawing.Point(31, 68)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(46, 15)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblApellido.Location = New System.Drawing.Point(31, 42)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(46, 15)
        Me.lblApellido.TabIndex = 0
        Me.lblApellido.Text = "Apellido"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(450, 378)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(570, 378)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(688, 378)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(27, 415)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.Location = New System.Drawing.Point(27, 40)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(130, 18)
        Me.lblBusqueda.TabIndex = 6
        Me.lblBusqueda.Text = "Buscar por apellido:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(163, 38)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(171, 20)
        Me.txtBusqueda.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(358, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 20)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnMostrarTodo
        '
        Me.btnMostrarTodo.Location = New System.Drawing.Point(358, 74)
        Me.btnMostrarTodo.Name = "btnMostrarTodo"
        Me.btnMostrarTodo.Size = New System.Drawing.Size(75, 38)
        Me.btnMostrarTodo.TabIndex = 9
        Me.btnMostrarTodo.Text = "Mostrar Todo"
        Me.btnMostrarTodo.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMostrarTodo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.lblBusqueda)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Pdatos)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pdatos.ResumeLayout(False)
        Me.Pdatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Pdatos As Panel
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtMail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnMostrarTodo As Button
End Class
