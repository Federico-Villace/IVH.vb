Imports System.Data.SqlClient
'Clase/ventana vender: Por un lado muestra lalista de clientes y productos disponibles
'Por el otro muestra una lista con los productos que se van agregando
Public Class Vender
    'Variable global
    Dim total As Double = 0


    'Cargacombo: llena la lista de clientes
    Public Sub cargaCombo()
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter("SELECT [Ape_cli]+' '+[Nom_cli]  as nombre,[DNI_cli] as dni FROM [TPFinal].[dbo].[Clientes] order by nombre", conn)
        Dim ds As New DataTable

        da.Fill(ds)

        listClientes.DataSource = ds
        'Valor que muestra la lista
        listClientes.DisplayMember = "nombre"
        'Valor que se usa 
        listClientes.ValueMember = "dni"

        conn.Close()

    End Sub


    Public Sub NumRemito() 'obtiene el numero del ultimo remito, lesuma uno y lo establece en el nuevo remito
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter("SELECT  MAX([Remito_ven]) as NumRemito FROM [TPFinal].[dbo].[Ventas]", conn) 'Selecciona el remito con numero mas alto
        Dim ds As New DataSet

        da.Fill(ds, "remitos")

        If Not IsDBNull(ds.Tables("remitos").Rows(0)("NumRemito")) Then 'Se verifica que se recibe algo
            'Se lo convierte  a int y se le suma 1 y se lo coloxa en la label remito
            lblNumRem.Text = (Val(ds.Tables("remitos").Rows(0)("NumRemito"))) + 1
        Else
            'Si no se recibe nada se establece el uno(Sucede en el prime uso)
            lblNumRem.Text = "1"
        End If
        conn.Close()
    End Sub

    '
    'Evento load
    Private Sub Vender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se carga la lista de clientes
        cargaCombo()
        'Se le da valor a la label que muestra el total
        lblTotal.Text = total
        'Se llena el DGV de los productos
        Dim cmd As String = "SELECT TOP (1000) [id_prod] as COD ,[Nom_prod] AS NOMBRE  ,[Tipo_prod] as ALCHOL ,[Precio_pro] as PRECIO ,[Stock_pro] AS STOCK ,[Marca_pro] as MARCA FROM [TPFinal].[dbo].[Productos]"
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter(cmd, conn)
        Dim ds As New DataSet

        da.Fill(ds, "productos")
        DataGridViewVender.DataSource = ds.Tables("productos")

        conn.Close()
        'Se llama a la funcion para eatblcer el numero de remito
        NumRemito()
    End Sub
    '
    'evento que sucede al cambiar cliente seleccionado
    Private Sub listClientes_SelectedValueChanged(sender As Object, e As EventArgs) Handles listClientes.SelectedValueChanged
        'Se llenan los datos nombre u dni de cliente
        lblNomCli.Text = listClientes.Text
        Label2.Text = listClientes.SelectedValue.ToString
    End Sub
    '
    'Booton Agregar: Agrega el prod seleccionado a la lista de venta definitiva
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If DataGridViewVender.SelectedRows.Count > 0 Then 'Verifica si hay fila(producto seleccionao)
            Dim pro, Cod As String
            Dim cant, precioUni, precioTotal, Stock As Integer

            If NumericUpDown1.Value > 0 Or NumericUpDown1.Value < 1000 Then 'Verifica que la cantidad es en el rango correcto (Entre cero y mil)
                'Se estable  la cantidad para vender del prod seleccionado
                cant = NumericUpDown1.Value
            Else
                MessageBox.Show("La cantida esta fuera de rango")
                Exit Sub
            End If

            If cant > DataGridViewVender.Item(4, DataGridViewVender.CurrentRow.Index).Value() Then 'Verifica que la cantidad sea menor al stock disponible
                cant = NumericUpDown1.Value
                MessageBox.Show("No hay suficiente Stock")
                Exit Sub
            End If

            'Se obtien los datos a agregar al "carrito"
            Cod = DataGridViewVender.Item(0, DataGridViewVender.CurrentRow.Index).Value()
            pro = DataGridViewVender.Item(1, DataGridViewVender.CurrentRow.Index).Value()
            precioUni = Val(DataGridViewVender.Item(3, DataGridViewVender.CurrentRow.Index).Value())
            'Se mutiplica el precio unitario por la cantidad vendida para obtener un subtotal
            precioTotal = precioUni * cant
            Stock = DataGridViewVender.Item(4, DataGridViewVender.CurrentRow.Index).Value()
            'Se agreganal DGV que podriamos llamar carrito
            DataGridView1.Rows.Add(Cod, pro, cant, precioTotal, Stock)

            'Para establecer En la label el total
            'Se suma el valor del producto actual al total que ya habia
            total = total + Val(DataGridView1.Item(3, (DataGridView1.Rows.Count - 1)).Value())
            lblTotal.Text = total
            'Se desmarca el producto elegido
            DataGridViewVender.CurrentCell.Selected = False
            'Se desmarca todo
            DataGridViewVender.CurrentCell = Nothing
            'Se pone el campo cantidad en uno
            NumericUpDown1.Value = 1
        Else
            'Si noy prducto seleccionado se informa 
            MessageBox.Show("No Hay Producto Selecciona")
            Exit Sub
        End If
    End Sub

    'BOTON ELIMINAR PRODUCTO DEL "CARRITO"
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Se verifica si la tabla tiene elementos cargados
        If DataGridView1.Rows.Count > 0 Then
            'se elimina la fila seleccionada y Se establece el total a cero para sumarlo de nuevo
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            total = 0
            'se recorre y suma todos los valores de precios de los productos que quedan en la tabla
            For i = 0 To DataGridView1.Rows.Count - 1
                total = total + Val(DataGridView1.Item(3, i).Value())
            Next
            'Se estable en la label el nuevo total.
            lblTotal.Text = total
        Else
            MsgBox("La lista esta vacia.")
        End If

    End Sub
    '
    'Boton vender 
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'Primero se  verifica q la tabla tenga elementos cargados
        If DataGridView1.Rows.Count > 0 Then

            'Si tiene prod cargados se le pregunta al usuario si esta seguro de llevar a cabo la venta
            If MessageBox.Show("Esta seguro de realizar la venta?", "Vender", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                'Si responde SI se recontinua obteniendo los datos necesarios  para insertar/Actualizar la base
                Dim fecha, hora, query, cliente, pro, det, query_update_stock, query_update_caja, query_update_mov, concepto, fechaevento As String
                Dim total As Double
                Dim NRem, NewStock, cant, stock, id As Integer

                'Se obtiene la hora actual
                hora = DateTime.Now.ToShortTimeString
                'Se obtine la fecha actual 
                fecha = FechaConFormatoIso()
                'Se Obtiene Fecha Evento para venta de entradas
                fechaevento = Format(Evento.Value, "yyyy/MM/dd").ToString
                concepto = "Ingreso por Venta N°" & lblNumRem.Text
                NRem = Val(lblNumRem.Text)
                total = CDbl(lblTotal.Text)
                cliente = lblNomCli.Text
                det = lblNomCli.Text & " Compro el dia " & fecha & ", con un gasto de  $" & lblTotal.Text & " los siguiente productos: "

                'For que recorre la tabla(carrito) para actualizar stock y obtener dato
                For i = 0 To DataGridView1.Rows.Count - 1 'Se obtienen los datos necesarios para realizar la actualizacion de stock de los products vendidos
                    'Se obtiene el id del producto
                    id = Val(DataGridView1.Item(0, i).Value())
                    'El stock actual de ese stock
                    stock = Val(DataGridView1.Item(4, i).Value())
                    'La cantidad vendida de ese producto
                    cant = Val(DataGridView1.Item(2, i).Value())
                    'Se establece el nuevo stock
                    NewStock = stock - cant
                    'Se obtiene el nombre del pro para el detalle
                    pro = DataGridView1.Item(1, i).Value()
                    det = det & pro & ", " ' A medida que se recorre el bucle se agrgan los productos para el detalle final
                    'Se declara la query con el nuevo stock
                    query_update_stock = "UPDATE [dbo].[Productos] SET [Stock_pro] = " & NewStock & " WHERE id_prod=" & id
                    'Se ejecuta la actualizacion del stock
                    SQL_Accion(query_update_stock)
                Next

                'Query que actualiza la caja
                query_update_caja = "UPDATE [dbo].[Caja] SET [Monto] =((select Monto from Caja where id_caja=1 )+" & total & ") WHERE id_caja=1"
                If Not SQL_Accion(query_update_caja) Then
                    MsgBox("Eror en la actualizacion de caja")
                    Exit Sub
                End If

                'Query que actualiza Movimientos de Caja
                query_update_mov = "INSERT INTO [dbo].[MovExtras]([MONTO],[ING],[EGR],[FECHA],[HORA], [CONCEPTO]) VALUES('" & total & "','SI','NO','" & fecha & "','" & hora & "','" & concepto & "')"
                If Not SQL_Accion(query_update_mov) Then
                    MsgBox("Eror en la actualizacion de caja")
                    Exit Sub
                End If


                'Query para registrar la venta
                query = "INSERT INTO [dbo].[Ventas]([Cli_ven],[Total_vendido],[Remito_ven],[Fecha_ven],[Hora_ven],[Detalle_Ven], [FechaEvento]) VALUES('" & cliente & "'," & total & "," & NRem & ",'" & fecha & "','" & hora & "','" & det & "','" & fechaevento & "')"
                If SQL_Accion(query) Then
                    MsgBox("VENTA REALIZA CORRECTAMENTE")
                    reiniciar()
                Else
                    MsgBox("Error Insert ventas ")
                End If
            Else
                'Si no se recibe la confirmacion sale del evento del boton
                Exit Sub
            End If
        Else
            'Se informa que la tabla esta vacia
            MsgBox("No hay productos para vender")
        End If
    End Sub
    '
    'Boton cancelar compra: recarga la ventana
    Private Sub btcCancel_Click(sender As Object, e As EventArgs) Handles btcCancel.Click

        'Primero se verifica si el dataGridView tiene productos cargados
        If DataGridView1.Rows.Count > 0 Then
            'Si esta cargado se pregunta si esta seguro de realizar la operacion
            If MessageBox.Show("Esta seguro de cancelar la compra?", "Cancelar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                'llama a un metodo que cierra y abre la ventana nuevamente
                reiniciar()
            End If
        End If

    End Sub

    ''
    'Boton volver:cierra la ventana de ventas y abre  el menu principal
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()

        Mostrarmenu()
    End Sub
    'Al cerrar desde la cruz de la ventana de widows se vuelve a mostrar el menu principal
    Private Sub Vender_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Mostrarmenu()
    End Sub


    '
    'RadioButton: Si se marca esta opcion de musestra el calendario para elegir la fecha.
    Private Sub FechaEvento_CheckedChanged(sender As Object, e As EventArgs) Handles FechaEvento.CheckedChanged
        Evento.Visible = True
        Evento.Value = FechaConFormatoIso()
    End Sub
End Class