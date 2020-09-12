Public Class NuevoVehiculo
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim marca, categoria, modelo, anio, color, puerta As String
        Dim precio As Decimal

        marca = txtMarca.Text.Trim
        categoria = txtCategoria.Text.Trim
        modelo = txtModelo.Text.Trim
        anio = txtAnio.Text.Trim
        puerta = txtPuertas.Text.Trim
        color = txtColor.Text.Trim
        precio = txtPrecio.Text

        If color = "" Then color = "Varios"
        If puerta = "" Then puerta = "1"



        If MessageBox.Show("Esta seguro de agregar un Vehiculo nuevo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
            If SQL_Accion("INSERT INTO [dbo].[Productos] ([Marca_prod], [Cat_prod], [Mod_prod], [Año_prod], [Precio_prod], [Color_prod], [Puerta_prod]) VALUES ('" & marca & "', '" & categoria & "', '" & modelo & "', " & anio & ", " & precio & ",'" & color & "', '" & puerta & "')") Then
                If MessageBox.Show("El Vehiculo fue agregado exitosamente!") Then Me.Close()
            End If

        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class