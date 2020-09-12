Public Class Nuevo
    '
    'BOTON CANCELAR
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Limpia todos los capos y cier la ventana
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtMail.Text = ""
        txtTelefono.Text = ""
        txtDNI.Text = ""
        Me.Close()

    End Sub
    '
    'Boton Confirmar: Captura los datos de los campos y los usa para agregar el cliente
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim nombre, apellido, mail, telefono As String
        Dim dni As Decimal
        'se Cargan las variables con lo que esta en los campos
        nombre = txtNombre.Text.Trim
        apellido = txtApellido.Text.Trim
        mail = txtMail.Text.Trim
        telefono = txtTelefono.Text.Trim
        'dni = VNum(txtDNI.Text)
        dni = Val(txtDNI.Text)
        '
        'Se verifican que los  campos esenciales no esten vacios
        If nombre = "" Then
            'Si esta vacio se informa y se sale del proceso
            MsgBox("El campo nombre esta vacio.Completelo")
            Exit Sub
        End If

        If apellido = "" Then
            MsgBox("El campo apellido esta vacio.Completelo")
            Exit Sub
        End If

        If txtDNI.Text = "" Then
            MsgBox("El campo dni esta vacio.Completelo")
            Exit Sub
        Else
            dni = Val(txtDNI.Text)
        End If

        'Se pide confirmacion
        If MessageBox.Show("Esta seguro de agregar un cliente nuevo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            'Se ejecuta la consulta
            If SQL_Accion("INSERT INTO [dbo].[Clientes] ([Nom_cli], [Ape_cli], [DNI_cli], [Mail_cli],[Cel_cli]) VALUES ('" & nombre & "', '" & apellido & "', " & dni & ", '" & mail & "','" & telefono & "')") Then
                'Seinforma del exito
                If MessageBox.Show("El cliente " & nombre & " " & apellido & " ha sido agregado") Then
                    'Se limpian los campos y se cierra la ventana
                    txtNombre.Text = ""
                    txtApellido.Text = ""
                    txtMail.Text = ""
                    txtTelefono.Text = ""
                    txtDNI.Text = ""
                    Me.Close()
                End If
            End If

        End If
    End Sub

    'Evento que detecta cuando se tipea en el campo dni. Solopermite numeros
    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            'Si no ingresa numeros se avisa.
            MsgBox("En este campo ingrese numeros")
        End If

    End Sub


End Class