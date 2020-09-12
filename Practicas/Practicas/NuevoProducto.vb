Public Class NuevoProducto
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim nombre, tipo, precioVenta, precioCompra, marca As String


        nombre = txtNombre.Text.Trim
        tipo = cbTipo.Text.Trim
        precioVenta = txtPrecioVenta.Text.Trim.Replace(",", ".") 'Si se incertan comas selas reemplaza por punto para evitar problemas con la base de datos 
        marca = txtMarca.Text.Trim
        precioCompra = txtPrecioCompra.Text.Replace(",", ".")
        ''Se verifica que los campos necesarios no esten vacios
        If nombre = "" Then
            MsgBox("Complete el campo nombre")
            Exit Sub
        End If

        If tipo = "" Then
            MsgBox("Complete el campo tipo")
            Exit Sub
        End If

        If marca = "" Then
            MsgBox("Complete el campo marca")
            Exit Sub
        End If


        'Si los campos que no son estrictamente necesarios estan vacion se los iguala a cero
        If precioVenta = "" Then precioVenta = "0"
        If precioCompra = "" Then precioCompra = "0"


        'Se pide confirmacion para agregar elproducto
        If MessageBox.Show("Esta seguro de agregar un Articulo nuevo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            'Se realiaza el insert en la tabla correspondiwente
            If SQL_Accion("INSERT INTO [dbo].[Productos] ([Nom_prod], [Tipo_prod], [Precio_pro], [Stock_pro], [PrecioCompra_prod], [Marca_pro]) VALUES ('" & nombre & "', '" & tipo & "', " & precioVenta & ", '0' , " & precioCompra & ",'" & marca & "')") Then
                'Se informa del exito mediante una ventanita con un unico boton que al precionarlo devuelve true 
                If MessageBox.Show("El Articulo fue agregado exitosamente!") Then
                    'Se llama a cargar el daat Grid view de la vent prod. Con el producto nuevo
                    Productos.cargadvgpro()
                    'Se limpian todos los campos y se cierra la ventana
                    txtNombre.Text = ""
                    txtPrecioVenta.Text = ""
                    txtMarca.Text = ""
                    txtPrecioCompra.Text = ""
                    Me.Close()
                End If
            End If

        End If
    End Sub
    'Boton Cancelar
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Se limpian todos los campos y se cierra la ventana
        txtNombre.Text = ""
        txtPrecioVenta.Text = ""
        txtMarca.Text = ""
        txtPrecioCompra.Text = ""
        Me.Close()
    End Sub


End Class