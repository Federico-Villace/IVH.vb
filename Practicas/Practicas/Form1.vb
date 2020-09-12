Imports System.Data.SqlClient
'Clase en la cual esta la ventana principal que contiene los botones para realizar las diferentes tareas
Public Class Menu


    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Clientes.Show()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Boton salir: pregunat si esta seguro de cerrar el programa
        If MessageBox.Show("Esta seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Application.Exit()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If MessageBox.Show("Esta seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then Application.Exit()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        Proveedores.Show()

    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Productos.Show()

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Clientes.Show()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        Proveedores.Show()
    End Sub

    Private Sub btnVehiculos_Click(sender As Object, e As EventArgs) Handles btnVehiculos.Click
        Productos.Show()
    End Sub



    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Me.Hide()
        Vender.Show()
        Vender.cargaCombo()

    End Sub

    Private Sub MovimientoExtraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientoExtraToolStripMenuItem.Click
        movExtra.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        HistorialCompras.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        HistorialVentas.Show()
    End Sub

    Private Sub MovimientosExtrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosExtrasToolStripMenuItem.Click
        HistorialMovimientosExtras.Show()
    End Sub
End Class
