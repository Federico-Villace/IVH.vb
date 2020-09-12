Imports System.Data.SqlClient
Public Class HistorialCompras
    Dim todo As String
    'Metodo que carga el DataGrriView, recibe la consulta como parametro
    Public Sub CargaDG(query As String)

        Dim cmd As String = query
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter(cmd, conn)
        Dim ds As New DataSet

        da.Fill(ds, "compras")
        dgvHistCompras.DataSource = ds.Tables("compras")

        conn.Close()
    End Sub

    'Al abrir la ventana se carga el DGV con todas las compras,
    Private Sub HistorialCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        todo = "SELECT TOP (1000) [id_compra] as Cod, [fecha_compra] as Fecha, [monto_compra] as Monto, [proveedorDeCompra] as Proveedor , [prodComprado] as Producto FROM [TPFinal].[dbo].[Compras]"
        CargaDG(todo)
        rdProd.Select() 'selecciona por default el primer radio button
        DateTimePicker1.Visible = False 'Oculta el panel de fechas
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim consulta, product, provee, fecha As String
        'segun q radio buton esta seleccionado envia la consultapara cargar el DGV,con lo que esta en el textBox o el panel de fechas, segun corresponda
        If rdProd.Checked Then

            product = txtBusqueda.Text.Trim
            consulta = "SELECT TOP (1000) [id_compra] as Cod, [fecha_compra] as Fecha, [monto_compra] as Monto, [proveedorDeCompra] as Proveedor , [prodComprado] as Producto FROM [TPFinal].[dbo].[Compras] WHERE [prodComprado] LIKE '" & product & "%'"
            CargaDG(consulta)
        ElseIf rdProv.Checked Then
            provee = txtBusqueda.Text.Trim
            consulta = "SELECT TOP (1000) [id_compra] as Cod, [fecha_compra] as Fecha, [monto_compra] as Monto, [proveedorDeCompra] as Proveedor , [prodComprado] as Producto FROM [TPFinal].[dbo].[Compras] WHERE [proveedorDeCompra] LIKE '" & provee & "%'"
            CargaDG(consulta)
        ElseIf rdFecha.Checked Then

            fecha = Format(DateTimePicker1.Value, "yyyy/MM/dd").ToString
            consulta = "SELECT TOP (1000) [id_compra] as Cod, [fecha_compra] as Fecha, [monto_compra] as Monto, [proveedorDeCompra] as Proveedor , [prodComprado] as Producto FROM [TPFinal].[dbo].[Compras] WHERE [fecha_compra] = '" & fecha & "'"
            CargaDG(consulta)
        End If




    End Sub
    'Si esta seleccionado el RB de fecha se oculta el textBox de busqueda, y se muestra el panel de fecha
    Private Sub rdFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rdFecha.CheckedChanged
        DateTimePicker1.Visible = True
        txtBusqueda.Visible = False
        txtBusqueda.Text = ""
    End Sub
    'Si esta seleccionado el RB de Producto se oculta el panel de fecha , y se muestra el textBox de busqueda
    Private Sub rdProd_CheckedChanged(sender As Object, e As EventArgs) Handles rdProd.CheckedChanged
        DateTimePicker1.Visible = False
        txtBusqueda.Visible = True

    End Sub
    'Si esta seleccionado el RB de Proveedor se oculta el panel de fecha , y se muestra el textBox de busqueda
    Private Sub rdProv_CheckedChanged(sender As Object, e As EventArgs) Handles rdProv.CheckedChanged
        DateTimePicker1.Visible = False
        txtBusqueda.Visible = True
    End Sub
    '
    'Boton Todo: llama a la funcion cargaDB con la query para mostrar todo
    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        CargaDG(todo)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        txtBusqueda.Text = ""
        Me.Close()
    End Sub
End Class