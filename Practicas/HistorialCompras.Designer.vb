<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialCompras
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
        Me.dgvHistCompras = New System.Windows.Forms.DataGridView()
        Me.rdProd = New System.Windows.Forms.RadioButton()
        Me.rdProv = New System.Windows.Forms.RadioButton()
        Me.rdFecha = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dgvHistCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHistCompras
        '
        Me.dgvHistCompras.AllowUserToAddRows = False
        Me.dgvHistCompras.AllowUserToDeleteRows = False
        Me.dgvHistCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistCompras.Location = New System.Drawing.Point(12, 121)
        Me.dgvHistCompras.Name = "dgvHistCompras"
        Me.dgvHistCompras.ReadOnly = True
        Me.dgvHistCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistCompras.Size = New System.Drawing.Size(558, 203)
        Me.dgvHistCompras.TabIndex = 0
        '
        'rdProd
        '
        Me.rdProd.AutoSize = True
        Me.rdProd.BackColor = System.Drawing.Color.Transparent
        Me.rdProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdProd.Location = New System.Drawing.Point(15, 57)
        Me.rdProd.Name = "rdProd"
        Me.rdProd.Size = New System.Drawing.Size(76, 17)
        Me.rdProd.TabIndex = 2
        Me.rdProd.TabStop = True
        Me.rdProd.Text = "Producto"
        Me.rdProd.UseVisualStyleBackColor = False
        '
        'rdProv
        '
        Me.rdProv.AutoSize = True
        Me.rdProv.BackColor = System.Drawing.Color.Transparent
        Me.rdProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdProv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdProv.Location = New System.Drawing.Point(97, 57)
        Me.rdProv.Name = "rdProv"
        Me.rdProv.Size = New System.Drawing.Size(83, 17)
        Me.rdProv.TabIndex = 3
        Me.rdProv.TabStop = True
        Me.rdProv.Text = "Proveedor"
        Me.rdProv.UseVisualStyleBackColor = False
        '
        'rdFecha
        '
        Me.rdFecha.AutoSize = True
        Me.rdFecha.BackColor = System.Drawing.Color.Transparent
        Me.rdFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rdFecha.Location = New System.Drawing.Point(186, 57)
        Me.rdFecha.Name = "rdFecha"
        Me.rdFecha.Size = New System.Drawing.Size(60, 17)
        Me.rdFecha.TabIndex = 4
        Me.rdFecha.TabStop = True
        Me.rdFecha.Text = "Fecha"
        Me.rdFecha.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar por:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(414, 75)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Transparent
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.DodgerBlue
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(252, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(15, 78)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(393, 20)
        Me.txtBusqueda.TabIndex = 9
        '
        'btnTodo
        '
        Me.btnTodo.Location = New System.Drawing.Point(495, 75)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(75, 23)
        Me.btnTodo.TabIndex = 10
        Me.btnTodo.Text = "Mostrar todo"
        Me.btnTodo.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 345)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 11
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'HistorialCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Practicas.My.Resources.Resources.IMG_0521_wide_01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(584, 380)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rdFecha)
        Me.Controls.Add(Me.rdProv)
        Me.Controls.Add(Me.rdProd)
        Me.Controls.Add(Me.dgvHistCompras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(698, 571)
        Me.MinimumSize = New System.Drawing.Size(600, 300)
        Me.Name = "HistorialCompras"
        Me.Text = "Historial Compras"
        CType(Me.dgvHistCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHistCompras As DataGridView
    Friend WithEvents rdProd As RadioButton
    Friend WithEvents rdProv As RadioButton
    Friend WithEvents rdFecha As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents btnTodo As Button
    Friend WithEvents btnVolver As Button
End Class
