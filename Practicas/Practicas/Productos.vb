Imports System.Data.SqlClient

Public Class Productos
    Dim idprod As Integer

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    'Funcion que cargar el DGV con los productos
    Public Sub cargadvgpro()
        CheckBox1.Checked = False
        cbOpciones.SelectedIndex = 0
        Dim cmd As String = "SELECT TOP (1000) [id_prod], [Nom_prod], [Tipo_prod], [Marca_pro] FROM [TPFinal].[dbo].[Productos]"
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter(cmd, conn)
        Dim ds As New DataSet


        da.Fill(ds, "productos")
        dgvProductos.DataSource = ds.Tables("productos")
        conn.Close()
    End Sub
    '
    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al abrir la ventana se llama  a la funcion para cargar DGV
        cargadvgpro()
    End Sub

    'Evento que sucede al cambiar producto selecciona del DGV
    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged

        If dgvProductos.Rows.Count > 0 Then 'Se verifica que el DGV este cargado

            Dim fila As Integer = dgvProductos.CurrentRow.Index 'Se obtiene la fila seleccionada
            Dim id As Integer

            id = dgvProductos.Item(0, fila).Value() 'Se obtiene el ID del producto a partir de la fila seleccionada y la columna correspondiente
            idprod = id
            'Se utiliza el id obtenido para llamar a la funcion que carga los campos
            CargarCampos(id)
        Else
            'Si el DGV esta vacio se "limpian" los campos
            txtProd.Text = ""
            txtID.Text = ""
            txtPrecioVenta.Text = ""
            txtTipo.Text = ""
            txtStock.Text = ""
            txtPrecioCompra.Text = ""
            txtMarca.Text = ""
        End If
    End Sub

    'Funcion que carga los campos, recibe el ID Del producto seleccionado en el DGV 
    Sub CargarCampos(id As Integer)
        'Se abre la conexion a la bdd
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")

        Dim da As New SqlDataAdapter("SELECT TOP (1000) [id_prod],[Nom_prod] as prod, [Tipo_prod] as tipo ,[Precio_pro] as precio, [Stock_pro] as stock, [PrecioCompra_prod] as precioCompra,[Marca_pro] as marca FROM [TPFinal].[dbo].[Productos] WHERE id_prod =" & id, conn)
        Dim ds As New DataSet
        da.Fill(ds, "productos")
        'se llenan los campos con eldato correspondiente
        txtProd.Text = UCase(ds.Tables("productos").Rows(0)("prod"))
        txtID.Text = UCase(ds.Tables("productos").Rows(0)("id_prod"))
        txtPrecioVenta.Text = ds.Tables("productos").Rows(0)("precio")
        txtTipo.Text = UCase(ds.Tables("productos").Rows(0)("tipo"))
        txtStock.Text = ds.Tables("productos").Rows(0)("stock")
        txtPrecioCompra.Text = UCase(ds.Tables("productos").Rows(0)("precioCompra"))
        txtMarca.Text = UCase(ds.Tables("productos").Rows(0)("marca"))

        conn.Close() 'cierra conexion

    End Sub

    'Funcion que realiza busqueda
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim op As Integer = cbOpciones.SelectedIndex 'op es que opcion esta seleccionada (Buscar por nombre o marca)

        If txtBusqueda.Text = "" Then ' Se verifica que el campo de busqueda no este vacia
            MsgBox("El campo de busqueda esta vacio!!")
            Exit Sub
        End If
        Select Case op
            Case 0 'BUSCA POR MARCA
                If CheckBox1.Checked Then 'Busca bebidas alcolicas de la marca indicada
                    buscar(" Marca_pro like '" & txtBusqueda.Text & "%' AND Tipo_prod='SI' ")
                Else
                    buscar(" Marca_pro like '" & txtBusqueda.Text & "%' ") 'Busca cualquier producto tenga no alcohol
                End If
            Case 1 'Busca por NOMBRE

                If CheckBox1.Checked Then
                    buscar(" Nom_prod like '" & txtBusqueda.Text & "%' AND Tipo_prod='SI' ")
                Else
                    buscar(" Nom_prod like '" & txtBusqueda.Text & "%'")
                End If


        End Select

    End Sub

    'Funcion de busqueda. Recibe la condicion para realizar la busqueda y llenar el DGV en base a ella.
    Sub buscar(ByVal condicion As String)
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        'Declaracion de la consulta pare seleccionar los campos necesarios del DGV, se concatena con la condicion recibida
        Dim da As New SqlDataAdapter("SELECT TOP (1000) [id_prod], [Nom_prod], [Tipo_prod], [Marca_pro] FROM [TPFinal].[dbo].[Productos] where " & condicion & " order by id_prod", conn)
        Dim ds As New DataSet
        da.Fill(ds, "productos")
        'Se llena el DGV con lo recibido de la busqueda
        dgvProductos.DataSource = ds.Tables("productos")
        conn.Close()



    End Sub
    'Boton para mostrar todos los productos
    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        'Llamado a la funcion para cargar todos los productos
        cargadvgpro()
    End Sub
    'Boton Nuevo Producto
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Abre la ventana para ingresar un nuevo pproducto
        NuevoProducto.ShowDialog()
    End Sub
    'Boton Modificar
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If idprod > 0 Then ' Verifica que el campo id este completo. Significa que hay producto sseleccionado
            Dim nombre, tipo, precioV, stock, precioC, marca As String
            'Se llenan las variables con lo contenido en los campos. Si alguno se modifico impactara en la BDD, Sino mantendra el mismo valor al actualizar 
            nombre = txtProd.Text.Trim
            tipo = txtTipo.Text.Trim
            precioV = txtPrecioVenta.Text.Replace(",", ".")
            marca = txtMarca.Text.Trim
            precioC = txtPrecioCompra.Text.Replace(",", ".")
            stock = txtStock.Text


            'Se pide confirmacion de la actuyalizacion
            If MessageBox.Show("Está por modicar los datos del producto seleccionado. Está SEGURO?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
            'Si confirma se lleva a cabo la actualizacion
            If SQL_Accion("UPDATE [dbo].[Productos] SET [Nom_prod] ='" & nombre & "', [Tipo_prod] ='" & tipo & "', [Precio_pro] = " & precioV & ", [Stock_pro] = " & stock & ", [PrecioCompra_prod] = " & precioC & ", [Marca_pro]='" & marca & "' WHERE id_prod = " & idprod) = True Then
                MsgBox("Cambios realizados correctamente.")
                txtBusqueda.Text = idprod
                'Serealiza una busqueda con el prod modificadoparta mostrarlo con los cambios ya realizados
                buscar("id_prod= " & txtBusqueda.Text)
                txtBusqueda.Text = ""
            End If
        Else
            'Si no hay producto seleccionado
            MsgBox("Seleccione un producto para realizar los cambios.")
        End If

    End Sub
    'Boton eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idprod > 0 Then 'Se verifica que haya producto seleccionado
            'Se pide confirmacion para eliminar el producto seleccionado
            If MessageBox.Show("Está por ELIMINAR definitivamente al producto seleccionado!  Está SEGURO?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
            'Si confirma se lleva a cabo la eliminacion.
            If SQL_Accion("delete from Productos  where  id_prod=" & idprod) = False Then
                'Si falla la eliminacion se informa
                MsgBox("Hubo un error al intentar eliminar producto, reintente, y si el error persiste comuníquese con el programador.")
            Else

                dgvProductos.Rows.RemoveAt(dgvProductos.CurrentRow.Index) 'Se elimina la fila selecciona del datagridView
                idprod = 0 ' Se iguala a cero el  idprod(Que es el que fue usado para eliminar el producto)
                MsgBox("El producto fue ELIMINADO de la base de datos.") ' Seinforma que se realizo correctamente la eliminacion
                cargadvgpro() 'Se llama la a recargar el datagridview

            End If
        Else
            'Si no hay producto seleccionado se informa
            MessageBox.Show("Seleccione un producto para eliminar!")
        End If
    End Sub

    'Se declaran publicos para poder usarlos en la compra
    Public idC As Integer = 0
    Public nombreP As String
    'Boton Para realizar compra de producto seleccionado
    Private Sub btnComprarProd_Click(sender As Object, e As EventArgs) Handles btnComprarProd.Click

        If txtID.Text = "" Then
            MsgBox("Seleccione un producto para comprar. Si no existe, pulse el boton NUEVO, agregue el producto y regrese aqui")
        Else

            idC = txtID.Text
            nombreP = txtProd.Text

            Compras.ShowDialog() 'Abre ventana para realizar comprar
        End If
    End Sub


End Class