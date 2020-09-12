<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Productos
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
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbOpciones = New System.Windows.Forms.ComboBox()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblPrecioVenta = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblPrecioCompra = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtProd = New System.Windows.Forms.TextBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtPrecioCompra = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnComprarProd = New System.Windows.Forms.Button()
        Me.txtTipo = New System.Windows.Forms.ComboBox()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID})
        Me.dgvProductos.Location = New System.Drawing.Point(12, 116)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(362, 194)
        Me.dgvProductos.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "id_prod"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ID.Width = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bucar por:"
        '
        'cbOpciones
        '
        Me.cbOpciones.FormattingEnabled = True
        Me.cbOpciones.Items.AddRange(New Object() {"Marca", "Nombre"})
        Me.cbOpciones.Location = New System.Drawing.Point(11, 44)
        Me.cbOpciones.Name = "cbOpciones"
        Me.cbOpciones.Size = New System.Drawing.Size(141, 21)
        Me.cbOpciones.TabIndex = 2
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(201, 44)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(173, 20)
        Me.txtBusqueda.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CheckBox1.Location = New System.Drawing.Point(11, 77)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(183, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Buscar solo Bebidas con alcohol "
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(299, 77)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 381)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblID.Location = New System.Drawing.Point(441, 87)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(50, 13)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "Codigo:"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.BackColor = System.Drawing.Color.Transparent
        Me.lblProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblProd.Location = New System.Drawing.Point(441, 125)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(62, 13)
        Me.lblProd.TabIndex = 8
        Me.lblProd.Text = "Producto:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.BackColor = System.Drawing.Color.Transparent
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTipo.Location = New System.Drawing.Point(442, 164)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(53, 13)
        Me.lblTipo.TabIndex = 9
        Me.lblTipo.Text = "Alcohol:"
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.AutoSize = True
        Me.lblPrecioVenta.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecioVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPrecioVenta.Location = New System.Drawing.Point(442, 203)
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.Size = New System.Drawing.Size(87, 13)
        Me.lblPrecioVenta.TabIndex = 10
        Me.lblPrecioVenta.Text = "Precio venta: "
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.BackColor = System.Drawing.Color.Transparent
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblStock.Location = New System.Drawing.Point(441, 242)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(44, 13)
        Me.lblStock.TabIndex = 11
        Me.lblStock.Text = "Stock:"
        '
        'lblPrecioCompra
        '
        Me.lblPrecioCompra.AutoSize = True
        Me.lblPrecioCompra.BackColor = System.Drawing.Color.Transparent
        Me.lblPrecioCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPrecioCompra.Location = New System.Drawing.Point(441, 281)
        Me.lblPrecioCompra.Name = "lblPrecioCompra"
        Me.lblPrecioCompra.Size = New System.Drawing.Size(96, 13)
        Me.lblPrecioCompra.TabIndex = 12
        Me.lblPrecioCompra.Text = "Precio compra: "
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.BackColor = System.Drawing.Color.Transparent
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMarca.Location = New System.Drawing.Point(441, 324)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(50, 13)
        Me.lblMarca.TabIndex = 13
        Me.lblMarca.Text = "Marca: "
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(444, 105)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(292, 20)
        Me.txtID.TabIndex = 14
        '
        'txtProd
        '
        Me.txtProd.Location = New System.Drawing.Point(444, 141)
        Me.txtProd.Name = "txtProd"
        Me.txtProd.Size = New System.Drawing.Size(292, 20)
        Me.txtProd.TabIndex = 15
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.Location = New System.Drawing.Point(445, 219)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(292, 20)
        Me.txtPrecioVenta.TabIndex = 17
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(444, 258)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(292, 20)
        Me.txtStock.TabIndex = 18
        '
        'txtPrecioCompra
        '
        Me.txtPrecioCompra.Location = New System.Drawing.Point(444, 297)
        Me.txtPrecioCompra.Name = "txtPrecioCompra"
        Me.txtPrecioCompra.Size = New System.Drawing.Size(292, 20)
        Me.txtPrecioCompra.TabIndex = 19
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(444, 340)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(292, 20)
        Me.txtMarca.TabIndex = 20
        '
        'btnTodo
        '
        Me.btnTodo.Location = New System.Drawing.Point(11, 316)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(75, 23)
        Me.btnTodo.TabIndex = 21
        Me.btnTodo.Text = "Mostar todo"
        Me.btnTodo.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNuevo.Location = New System.Drawing.Point(444, 377)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 27)
        Me.btnNuevo.TabIndex = 22
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(556, 377)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 27)
        Me.btnModificar.TabIndex = 23
        Me.btnModificar.Text = "Actualizar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(671, 377)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(65, 27)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnComprarProd
        '
        Me.btnComprarProd.Location = New System.Drawing.Point(299, 316)
        Me.btnComprarProd.Name = "btnComprarProd"
        Me.btnComprarProd.Size = New System.Drawing.Size(75, 23)
        Me.btnComprarProd.TabIndex = 25
        Me.btnComprarProd.Text = "Comprar"
        Me.btnComprarProd.UseVisualStyleBackColor = True
        '
        'txtTipo
        '
        Me.txtTipo.FormattingEnabled = True
        Me.txtTipo.Items.AddRange(New Object() {"NO", "SI"})
        Me.txtTipo.Location = New System.Drawing.Point(445, 180)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(292, 21)
        Me.txtTipo.TabIndex = 26
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practicas.My.Resources.Resources.fondo_claro_01
        Me.ClientSize = New System.Drawing.Size(754, 411)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.btnComprarProd)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtPrecioCompra)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.txtProd)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.lblPrecioCompra)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblPrecioVenta)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.cbOpciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbOpciones As ComboBox
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents lblID As Label
    Friend WithEvents lblProd As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblPrecioVenta As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblPrecioCompra As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtProd As TextBox
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtPrecioCompra As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents btnTodo As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnComprarProd As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents txtTipo As ComboBox
End Class
