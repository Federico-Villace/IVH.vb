﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HistorialEntradas
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
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.txtComentarios = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.calendario = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnTodo = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.cbClientes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbRemito = New System.Windows.Forms.RadioButton()
        Me.Evento = New System.Windows.Forms.RadioButton()
        Me.FechaEvento = New System.Windows.Forms.DateTimePicker()
        Me.calendario2 = New System.Windows.Forms.DateTimePicker()
        Me.lblSumaTotal = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(25, 152)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVentas.Size = New System.Drawing.Size(625, 193)
        Me.dgvVentas.TabIndex = 0
        '
        'txtComentarios
        '
        Me.txtComentarios.BackColor = System.Drawing.SystemColors.Window
        Me.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtComentarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.Location = New System.Drawing.Point(672, 152)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ReadOnly = True
        Me.txtComentarios.Size = New System.Drawing.Size(248, 193)
        Me.txtComentarios.TabIndex = 1
        Me.txtComentarios.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar por:"
        '
        'rbFecha
        '
        Me.rbFecha.AutoSize = True
        Me.rbFecha.BackColor = System.Drawing.Color.Transparent
        Me.rbFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.rbFecha.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.rbFecha.Location = New System.Drawing.Point(27, 52)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(60, 17)
        Me.rbFecha.TabIndex = 3
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "Fecha"
        Me.rbFecha.UseVisualStyleBackColor = False
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.BackColor = System.Drawing.Color.Transparent
        Me.rbCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCliente.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.rbCliente.Location = New System.Drawing.Point(117, 52)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(64, 17)
        Me.rbCliente.TabIndex = 5
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(25, 81)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(363, 20)
        Me.txtBusqueda.TabIndex = 6
        '
        'calendario
        '
        Me.calendario.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calendario.Location = New System.Drawing.Point(75, 81)
        Me.calendario.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.calendario.Name = "calendario"
        Me.calendario.Size = New System.Drawing.Size(89, 20)
        Me.calendario.TabIndex = 7
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(479, 114)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnTodo
        '
        Me.btnTodo.Location = New System.Drawing.Point(575, 114)
        Me.btnTodo.Name = "btnTodo"
        Me.btnTodo.Size = New System.Drawing.Size(75, 23)
        Me.btnTodo.TabIndex = 9
        Me.btnTodo.Text = "Mostrar todo"
        Me.btnTodo.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(25, 367)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(25, 81)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(623, 24)
        Me.cbClientes.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(761, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Detalle"
        '
        'rbRemito
        '
        Me.rbRemito.AutoSize = True
        Me.rbRemito.BackColor = System.Drawing.Color.Transparent
        Me.rbRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRemito.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.rbRemito.Location = New System.Drawing.Point(203, 52)
        Me.rbRemito.Name = "rbRemito"
        Me.rbRemito.Size = New System.Drawing.Size(129, 17)
        Me.rbRemito.TabIndex = 4
        Me.rbRemito.TabStop = True
        Me.rbRemito.Text = "Numero de Remito"
        Me.rbRemito.UseVisualStyleBackColor = False
        '
        'Evento
        '
        Me.Evento.AutoSize = True
        Me.Evento.BackColor = System.Drawing.Color.Transparent
        Me.Evento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Evento.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Evento.Location = New System.Drawing.Point(356, 52)
        Me.Evento.Name = "Evento"
        Me.Evento.Size = New System.Drawing.Size(65, 17)
        Me.Evento.TabIndex = 13
        Me.Evento.TabStop = True
        Me.Evento.Text = "Evento"
        Me.Evento.UseVisualStyleBackColor = False
        '
        'FechaEvento
        '
        Me.FechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaEvento.Location = New System.Drawing.Point(427, 52)
        Me.FechaEvento.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.FechaEvento.Name = "FechaEvento"
        Me.FechaEvento.Size = New System.Drawing.Size(80, 20)
        Me.FechaEvento.TabIndex = 14
        Me.FechaEvento.Visible = False
        '
        'calendario2
        '
        Me.calendario2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calendario2.Location = New System.Drawing.Point(75, 114)
        Me.calendario2.MinDate = New Date(2019, 1, 1, 0, 0, 0, 0)
        Me.calendario2.Name = "calendario2"
        Me.calendario2.Size = New System.Drawing.Size(89, 20)
        Me.calendario2.TabIndex = 15
        Me.calendario2.Visible = False
        '
        'lblSumaTotal
        '
        Me.lblSumaTotal.AutoSize = True
        Me.lblSumaTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblSumaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSumaTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSumaTotal.Location = New System.Drawing.Point(503, 367)
        Me.lblSumaTotal.Name = "lblSumaTotal"
        Me.lblSumaTotal.Size = New System.Drawing.Size(51, 15)
        Me.lblSumaTotal.TabIndex = 16
        Me.lblSumaTotal.Text = "Label3"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.BackColor = System.Drawing.Color.Transparent
        Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.ForeColor = System.Drawing.SystemColors.Window
        Me.lblDesde.Location = New System.Drawing.Point(22, 81)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(54, 16)
        Me.lblDesde.TabIndex = 17
        Me.lblDesde.Text = "Desde"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.BackColor = System.Drawing.Color.Transparent
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.ForeColor = System.Drawing.SystemColors.Window
        Me.lblHasta.Location = New System.Drawing.Point(24, 114)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(49, 16)
        Me.lblHasta.TabIndex = 18
        Me.lblHasta.Text = "Hasta"
        '
        'HistorialEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Practicas.My.Resources.Resources.logoIVH1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(952, 417)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.lblSumaTotal)
        Me.Controls.Add(Me.calendario2)
        Me.Controls.Add(Me.FechaEvento)
        Me.Controls.Add(Me.Evento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnTodo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.calendario)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.rbCliente)
        Me.Controls.Add(Me.rbRemito)
        Me.Controls.Add(Me.rbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtComentarios)
        Me.Controls.Add(Me.dgvVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1060, 690)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "HistorialEntradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de Ventas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents txtComentarios As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbFecha As RadioButton
    Friend WithEvents rbCliente As RadioButton
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents calendario As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnTodo As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents cbClientes As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rbRemito As RadioButton
    Friend WithEvents Evento As RadioButton
    Friend WithEvents FechaEvento As DateTimePicker
    Friend WithEvents calendario2 As DateTimePicker
    Friend WithEvents lblSumaTotal As Label
    Friend WithEvents lblDesde As Label
    Friend WithEvents lblHasta As Label
End Class
