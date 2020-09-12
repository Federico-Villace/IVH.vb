<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vender
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
        Me.lblSeleccioncliente = New System.Windows.Forms.Label()
        Me.listClientes = New System.Windows.Forms.ComboBox()
        Me.DataGridViewVender = New System.Windows.Forms.DataGridView()
        Me.lblNomCli = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.lblListaProductos = New System.Windows.Forms.Label()
        Me.lblNumRem = New System.Windows.Forms.Label()
        Me.btcCancel = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.DataGridViewVender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeleccioncliente
        '
        Me.lblSeleccioncliente.AutoSize = True
        Me.lblSeleccioncliente.BackColor = System.Drawing.Color.Transparent
        Me.lblSeleccioncliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSeleccioncliente.ForeColor = System.Drawing.Color.Transparent
        Me.lblSeleccioncliente.Location = New System.Drawing.Point(26, 25)
        Me.lblSeleccioncliente.Name = "lblSeleccioncliente"
        Me.lblSeleccioncliente.Size = New System.Drawing.Size(156, 18)
        Me.lblSeleccioncliente.TabIndex = 0
        Me.lblSeleccioncliente.Text = "Seleccionar cliente:"
        '
        'listClientes
        '
        Me.listClientes.FormattingEnabled = True
        Me.listClientes.Location = New System.Drawing.Point(29, 46)
        Me.listClientes.Name = "listClientes"
        Me.listClientes.Size = New System.Drawing.Size(315, 21)
        Me.listClientes.TabIndex = 1
        '
        'DataGridViewVender
        '
        Me.DataGridViewVender.AllowUserToAddRows = False
        Me.DataGridViewVender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewVender.Location = New System.Drawing.Point(27, 118)
        Me.DataGridViewVender.Name = "DataGridViewVender"
        Me.DataGridViewVender.ReadOnly = True
        Me.DataGridViewVender.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewVender.Size = New System.Drawing.Size(438, 320)
        Me.DataGridViewVender.TabIndex = 2
        '
        'lblNomCli
        '
        Me.lblNomCli.AutoSize = True
        Me.lblNomCli.BackColor = System.Drawing.Color.Transparent
        Me.lblNomCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNomCli.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblNomCli.Location = New System.Drawing.Point(590, 124)
        Me.lblNomCli.Name = "lblNomCli"
        Me.lblNomCli.Size = New System.Drawing.Size(49, 16)
        Me.lblNomCli.TabIndex = 3
        Me.lblNomCli.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(590, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(504, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CLIENTE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(504, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "DNI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(575, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(300, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Documento No valido como fractura."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(849, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nº:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(391, 91)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.Producto, Me.Cant, Me.Precio, Me.Stock})
        Me.DataGridView1.Location = New System.Drawing.Point(507, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(422, 269)
        Me.DataGridView1.TabIndex = 10
        '
        'COD
        '
        Me.COD.HeaderText = "COD"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Cant
        '
        Me.Cant.HeaderText = "Cant."
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(335, 91)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDown1.TabIndex = 11
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(786, 460)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "TOTAL:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(861, 504)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 14
        Me.btnOK.Text = "VENDER"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(509, 457)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Eliminar"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblTotal.Location = New System.Drawing.Point(880, 464)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(49, 16)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "Label8"
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.BackColor = System.Drawing.Color.Transparent
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblCant.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblCant.Location = New System.Drawing.Point(261, 91)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(68, 16)
        Me.lblCant.TabIndex = 17
        Me.lblCant.Text = "Cantidad: "
        '
        'lblListaProductos
        '
        Me.lblListaProductos.AutoSize = True
        Me.lblListaProductos.BackColor = System.Drawing.Color.Transparent
        Me.lblListaProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblListaProductos.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblListaProductos.Location = New System.Drawing.Point(26, 91)
        Me.lblListaProductos.Name = "lblListaProductos"
        Me.lblListaProductos.Size = New System.Drawing.Size(145, 16)
        Me.lblListaProductos.TabIndex = 18
        Me.lblListaProductos.Text = "Productos disponibles:"
        '
        'lblNumRem
        '
        Me.lblNumRem.AutoSize = True
        Me.lblNumRem.BackColor = System.Drawing.Color.Transparent
        Me.lblNumRem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lblNumRem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblNumRem.Location = New System.Drawing.Point(895, 151)
        Me.lblNumRem.Name = "lblNumRem"
        Me.lblNumRem.Size = New System.Drawing.Size(32, 16)
        Me.lblNumRem.TabIndex = 19
        Me.lblNumRem.Text = "xxxx"
        '
        'btcCancel
        '
        Me.btcCancel.Location = New System.Drawing.Point(721, 504)
        Me.btcCancel.Name = "btcCancel"
        Me.btcCancel.Size = New System.Drawing.Size(134, 23)
        Me.btcCancel.TabIndex = 20
        Me.btcCancel.Text = "Cancelar compra"
        Me.btcCancel.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(27, 496)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(107, 31)
        Me.btnVolver.TabIndex = 21
        Me.btnVolver.Text = "Cerrar ventana"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Vender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Practicas.My.Resources.Resources.fondo_claro_01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(958, 541)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btcCancel)
        Me.Controls.Add(Me.lblNumRem)
        Me.Controls.Add(Me.lblListaProductos)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblNomCli)
        Me.Controls.Add(Me.DataGridViewVender)
        Me.Controls.Add(Me.listClientes)
        Me.Controls.Add(Me.lblSeleccioncliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Vender"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vender"
        CType(Me.DataGridViewVender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSeleccioncliente As Label
    Friend WithEvents listClientes As ComboBox
    Friend WithEvents DataGridViewVender As DataGridView
    Friend WithEvents lblNomCli As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCant As Label
    Friend WithEvents lblListaProductos As Label
    Friend WithEvents lblNumRem As Label
    Friend WithEvents COD As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents btcCancel As Button
    Friend WithEvents btnVolver As Button
End Class
