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
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Apellido, Me.Nombre})
        Me.dgvClientes.Location = New System.Drawing.Point(12, 74)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(340, 254)
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
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(481, 279)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(265, 20)
        Me.txtMail.TabIndex = 9
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(481, 220)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(265, 20)
        Me.txtTelefono.TabIndex = 8
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(481, 166)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(265, 20)
        Me.txtDNI.TabIndex = 7
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(481, 115)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(265, 20)
        Me.txtNombre.TabIndex = 6
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(481, 61)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(265, 20)
        Me.txtApellido.TabIndex = 5
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.BackColor = System.Drawing.Color.Transparent
        Me.lblMail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMail.Location = New System.Drawing.Point(481, 261)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(46, 15)
        Me.lblMail.TabIndex = 4
        Me.lblMail.Text = "e-mail:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.Color.Transparent
        Me.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTelefono.Location = New System.Drawing.Point(481, 202)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 15)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Celular:"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.BackColor = System.Drawing.Color.Transparent
        Me.lblDNI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblDNI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDNI.Location = New System.Drawing.Point(481, 148)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(35, 15)
        Me.lblDNI.TabIndex = 2
        Me.lblDNI.Text = "DNI:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombre.Location = New System.Drawing.Point(481, 97)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(56, 15)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.BackColor = System.Drawing.Color.Transparent
        Me.lblApellido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblApellido.Location = New System.Drawing.Point(481, 43)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(58, 15)
        Me.lblApellido.TabIndex = 0
        Me.lblApellido.Text = "Apellido:"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Lime
        Me.btnNuevo.Location = New System.Drawing.Point(481, 305)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(575, 305)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(671, 305)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 347)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Volver"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.lblBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBusqueda.Location = New System.Drawing.Point(12, 40)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(130, 18)
        Me.lblBusqueda.TabIndex = 6
        Me.lblBusqueda.Text = "Buscar por apellido:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(148, 38)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(204, 20)
        Me.txtBusqueda.TabIndex = 0
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
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Practicas.My.Resources.Resources.fondo_claro_01
        Me.ClientSize = New System.Drawing.Size(764, 381)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.btnMostrarTodo)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblBusqueda)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.dgvClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
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
