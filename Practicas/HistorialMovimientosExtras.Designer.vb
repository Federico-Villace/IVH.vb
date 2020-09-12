<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HistorialMovimientosExtras
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
        Me.dgvMovExt = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbIngreso = New System.Windows.Forms.RadioButton()
        Me.rbEgreso = New System.Windows.Forms.RadioButton()
        Me.Calendario = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Calendario2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMontoActual = New System.Windows.Forms.Label()
        CType(Me.dgvMovExt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMovExt
        '
        Me.dgvMovExt.AllowUserToAddRows = False
        Me.dgvMovExt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovExt.Location = New System.Drawing.Point(18, 127)
        Me.dgvMovExt.Name = "dgvMovExt"
        Me.dgvMovExt.ReadOnly = True
        Me.dgvMovExt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovExt.Size = New System.Drawing.Size(480, 188)
        Me.dgvMovExt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtrar por:"
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.BackColor = System.Drawing.Color.Transparent
        Me.rbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbFecha.Location = New System.Drawing.Point(18, 47)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(60, 17)
        Me.rbFecha.TabIndex = 2
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = False
        '
        'rbIngreso
        '
        Me.rbIngreso.AutoSize = True
        Me.rbIngreso.BackColor = System.Drawing.Color.Transparent
        Me.rbIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIngreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbIngreso.Location = New System.Drawing.Point(328, 70)
        Me.rbIngreso.Name = "rbIngreso"
        Me.rbIngreso.Size = New System.Drawing.Size(67, 17)
        Me.rbIngreso.TabIndex = 3
        Me.rbIngreso.TabStop = True
        Me.rbIngreso.Text = "Ingreso"
        Me.rbIngreso.UseVisualStyleBackColor = False
        '
        'rbEgreso
        '
        Me.rbEgreso.AutoSize = True
        Me.rbEgreso.BackColor = System.Drawing.Color.Transparent
        Me.rbEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEgreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbEgreso.Location = New System.Drawing.Point(432, 70)
        Me.rbEgreso.Name = "rbEgreso"
        Me.rbEgreso.Size = New System.Drawing.Size(64, 17)
        Me.rbEgreso.TabIndex = 4
        Me.rbEgreso.TabStop = True
        Me.rbEgreso.Text = "Egreso"
        Me.rbEgreso.UseVisualStyleBackColor = False
        '
        'Calendario
        '
        Me.Calendario.CalendarForeColor = System.Drawing.Color.Transparent
        Me.Calendario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Calendario.Location = New System.Drawing.Point(62, 70)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.Size = New System.Drawing.Size(93, 20)
        Me.Calendario.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(320, 95)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Filtrar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnTodo
        '
        Me.btnTodo.Location = New System.Drawing.Point(401, 95)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(95, 23)
        Me.btnTodo.TabIndex = 7
        Me.btnTodo.Text = "Mostrar Todo"
        Me.btnTodo.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(18, 330)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 8
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Calendario2
        '
        Me.Calendario2.CalendarForeColor = System.Drawing.Color.Transparent
        Me.Calendario2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Calendario2.Location = New System.Drawing.Point(62, 96)
        Me.Calendario2.Name = "Calendario2"
        Me.Calendario2.Size = New System.Drawing.Size(93, 20)
        Me.Calendario2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(18, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Desde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(18, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Hasta"
        '
        'txtMontoActual
        '
        Me.txtMontoActual.BackColor = System.Drawing.Color.Transparent
        Me.txtMontoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoActual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtMontoActual.Location = New System.Drawing.Point(349, 320)
        Me.txtMontoActual.Name = "txtMontoActual"
        Me.txtMontoActual.Size = New System.Drawing.Size(149, 18)
        Me.txtMontoActual.TabIndex = 11
        Me.txtMontoActual.Text = "Saldo caja"
        '
        'HistorialMovimientosExtras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Practicas.My.Resources.Resources.IMG_0521_wide_01
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(538, 365)
        Me.Controls.Add(Me.txtMontoActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Calendario2)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.rbEgreso)
        Me.Controls.Add(Me.rbIngreso)
        Me.Controls.Add(Me.rbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvMovExt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "HistorialMovimientosExtras"
        Me.Text = "Historial Movimientos De Caja"
        CType(Me.dgvMovExt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvMovExt As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents rbIngreso As RadioButton
    Friend WithEvents rbEgreso As RadioButton
    Friend WithEvents Calendario As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnTodo As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents Calendario2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMontoActual As Label
End Class
