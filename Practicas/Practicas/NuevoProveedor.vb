Public Class NuevoProveedor
    '
    'Boton confirmar
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim nombre, direccion, telefono, mail As String
        'Se btienen los datos de los campos
        nombre = txtNombre.Text.Trim
        direccion = txtDireccion.Text.Trim
        mail = txtMail.Text.Trim
        telefono = txtTelefono.Text.Trim

        'Se verifican que los  campos esenciales no esten vacios
        If nombre = "" Then
            'Si esta vacio se informa y se sale del proceso
            MsgBox("El campo nombre esta vacio.Completelo")
            Exit Sub
        End If


        If direccion = "" Then
            MsgBox("El campo direccion esta vacio.Completelo")
            Exit Sub
        End If


        If mail = "" Then
            MsgBox("El campo mail esta vacio.Completelo")
            Exit Sub
        End If


        If telefono = "" Then
            MsgBox("El campo telefono esta vacio.Completelo")
            Exit Sub
        End If

        'Se pide confirmacion
        If MessageBox.Show("Esta seguro de agregar un Proveedor nuevo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            'Se ejecuta la consulta
            If SQL_Accion("INSERT INTO [dbo].[Proveedores] ([Nom_prov], [Dir_prov],[Tel_prov], [Mail_prov]) VALUES ('" & nombre & "', '" & direccion & "',  '" & telefono & "', '" & mail & "')") Then
                'Se informa del exito
                If MessageBox.Show("El Proveedor " & nombre & " ha sido agregado") Then
                    'Se limpian los campos
                    txtNombre.Text = ""
                    txtDireccion.Text = ""
                    txtMail.Text = ""
                    txtTelefono.Text = ""
                    'Se cierra la ventana
                    Me.Close()
                End If

            End If

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Se limpian los campos
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtMail.Text = ""
        txtTelefono.Text = ""
        'Se cierra la ventana
        Me.Close()
    End Sub
End Class