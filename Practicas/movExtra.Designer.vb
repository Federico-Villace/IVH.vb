<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class movExtra
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
        Me.btnIng = New System.Windows.Forms.Button()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.txtMontoExtra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextConcepto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMontoActual = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnIng
        '
        Me.btnIng.Location = New System.Drawing.Point(14, 152)
        Me.btnIng.Name = "btnIng"
        Me.btnIng.Size = New System.Drawing.Size(75, 23)
        Me.btnIng.TabIndex = 0
        Me.btnIng.Text = "Ingresar"
        Me.btnIng.UseVisualStyleBackColor = True
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(171, 152)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(75, 23)
        Me.btnRetirar.TabIndex = 1
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'txtMontoExtra
        '
        Me.txtMontoExtra.Location = New System.Drawing.Point(12, 32)
        Me.txtMontoExtra.Name = "txtMontoExtra"
        Me.txtMontoExtra.Size = New System.Drawing.Size(234, 20)
        Me.txtMontoExtra.TabIndex = 2
        Me.txtMontoExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(10, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese un monto:"
        '
        'TextConcepto
        '
        Me.TextConcepto.Location = New System.Drawing.Point(12, 78)
        Me.TextConcepto.Name = "TextConcepto"
        Me.TextConcepto.Size = New System.Drawing.Size(234, 20)
        Me.TextConcepto.TabIndex = 4
        Me.TextConcepto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(8, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ingrese Concepto:"
        '
        'txtMontoActual
        '
        Me.txtMontoActual.AutoSize = True
        Me.txtMontoActual.BackColor = System.Drawing.Color.Transparent
        Me.txtMontoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtMontoActual.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.txtMontoActual.Location = New System.Drawing.Point(112, 223)
        Me.txtMontoActual.Name = "txtMontoActual"
        Me.txtMontoActual.Size = New System.Drawing.Size(49, 16)
        Me.txtMontoActual.TabIndex = 6
        Me.txtMontoActual.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(11, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Saldo Actual :"
        '
        'movExtra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Practicas.My.Resources.Resources.logoIVH1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(268, 256)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMontoActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextConcepto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMontoExtra)
        Me.Controls.Add(Me.btnRetirar)
        Me.Controls.Add(Me.btnIng)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "movExtra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos de Caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnIng As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents txtMontoExtra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextConcepto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMontoActual As Label
    Friend WithEvents Label4 As Label
End Class
