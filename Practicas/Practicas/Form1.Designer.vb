<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientoExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistorialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(415, 353)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(130, 31)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ABMsToolStripMenuItem, Me.HistorialesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(557, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ABMsToolStripMenuItem
        '
        Me.ABMsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.MovimientoExtraToolStripMenuItem})
        Me.ABMsToolStripMenuItem.Name = "ABMsToolStripMenuItem"
        Me.ABMsToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.ABMsToolStripMenuItem.Text = "Acciones Generales"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'MovimientoExtraToolStripMenuItem
        '
        Me.MovimientoExtraToolStripMenuItem.Name = "MovimientoExtraToolStripMenuItem"
        Me.MovimientoExtraToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.MovimientoExtraToolStripMenuItem.Text = "Movimiento extra"
        '
        'HistorialesToolStripMenuItem
        '
        Me.HistorialesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.MovimientosExtrasToolStripMenuItem})
        Me.HistorialesToolStripMenuItem.Name = "HistorialesToolStripMenuItem"
        Me.HistorialesToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.HistorialesToolStripMenuItem.Text = "Historiales"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'MovimientosExtrasToolStripMenuItem
        '
        Me.MovimientosExtrasToolStripMenuItem.Name = "MovimientosExtrasToolStripMenuItem"
        Me.MovimientosExtrasToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MovimientosExtrasToolStripMenuItem.Text = "Movimientos extras"
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnClientes.Font = New System.Drawing.Font("Cambria", 7.8!)
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Location = New System.Drawing.Point(12, 234)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(130, 43)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnProveedores
        '
        Me.btnProveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnProveedores.Font = New System.Drawing.Font("Cambria", 7.8!)
        Me.btnProveedores.ForeColor = System.Drawing.Color.White
        Me.btnProveedores.Location = New System.Drawing.Point(12, 283)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Size = New System.Drawing.Size(130, 43)
        Me.btnProveedores.TabIndex = 3
        Me.btnProveedores.Text = "PROVEEDORES"
        Me.btnProveedores.UseVisualStyleBackColor = False
        '
        'btnVehiculos
        '
        Me.btnVehiculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnVehiculos.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehiculos.ForeColor = System.Drawing.Color.White
        Me.btnVehiculos.Location = New System.Drawing.Point(12, 53)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(130, 43)
        Me.btnVehiculos.TabIndex = 4
        Me.btnVehiculos.Text = "PRODUCTOS"
        Me.btnVehiculos.UseVisualStyleBackColor = False
        '
        'btnVender
        '
        Me.btnVender.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.btnVender.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVender.FlatAppearance.BorderSize = 5
        Me.btnVender.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Bold)
        Me.btnVender.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVender.Location = New System.Drawing.Point(12, 102)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(130, 43)
        Me.btnVender.TabIndex = 5
        Me.btnVender.Text = "VENTAS"
        Me.btnVender.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Practicas.My.Resources.Resources.LogoFacu21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(557, 396)
        Me.Controls.Add(Me.btnVender)
        Me.Controls.Add(Me.btnVehiculos)
        Me.Controls.Add(Me.btnProveedores)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1354, 982)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABMsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnVehiculos As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents MovimientoExtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistorialesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosExtrasToolStripMenuItem As ToolStripMenuItem
End Class
