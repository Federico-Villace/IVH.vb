

Imports System.Data.SqlClient

Public Class Proveedores

    'Se declara aqui para que su ambito sea global
    Dim idpro As Integer
    '
    'Funcion que carga el DGV
    Public Sub cargaDataGrid()
        Dim cmd As String = "SELECT TOP (1000) [id_prov], [Nom_prov] FROM [TPFinal].[dbo].[Proveedores]"
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter(cmd, conn)
        Dim ds As New DataSet


        da.Fill(ds, "proveedores")
        dgvProveedores.DataSource = ds.Tables("proveedores")
        conn.Close()
    End Sub
    '
    'Funcion que se ejecuta al abrir la ventana
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llama a la funcion para cargar DGV
        cargaDataGrid()
    End Sub

    '
    'Evento que sucede al cambiar seleccion del DGV
    Private Sub dgvProveedores_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProveedores.SelectionChanged
        If dgvProveedores.Rows.Count > 0 Then 'Se verifica que no este vacio
            Dim fila As Integer = dgvProveedores.CurrentRow.Index
            'Se obtiene el ID correspondiente a la fila seccionda
            idpro = dgvProveedores.Item(0, fila).Value()
            'Se Usa el ID obtenido para llamar a la funcion Carga campos
            CargarCampos(idpro)
        Else
            'Si el dgv esta vacio se limpian los campos
            txtNombre.Text = ""
            txtDireccion.Text = ""
            txtMail.Text = ""
            txtTelefono.Text = ""
        End If
    End Sub

    '
    'Buscar: recibe una condicion
    '
    Sub buscar(ByVal condicion As String)
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")

        Dim da As New SqlDataAdapter("SELECT TOP (100) [id_prov], [Nom_prov] FROM [TPFinal].[dbo].[Proveedores] where " & condicion & " order by id_prov", conn)
        Dim ds As New DataSet
        da.Fill(ds, "proveedores")

        dgvProveedores.DataSource = ds.Tables("proveedores")

        conn.Close()



    End Sub

    '
    'Boton buscar Envia como parametro del metodo buscar() lo escrito en el txt(Es parte de la condicion de busqueda).
    '
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar(" Nom_prov like '" & txtBusqueda.Text & "%' ")

    End Sub
    '
    'Boton Volver. Cierra el formulario Clientes
    '
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    '
    'Boton Mostrar TODO: vacia el Text Box de busqueda y llama buscar, de este modo al estar vacio se muestran todos
    '
    Private Sub btnMostrarTodo_Click(sender As Object, e As EventArgs) Handles btnMostrarTodo.Click
        txtBusqueda.Text = ""
        buscar(" Nom_prov like '" & txtBusqueda.Text & "%' ")
    End Sub

    '
    'Carga todos los campos correspondientes al ID que se le pasa, los carga en un data set y de ahi los va pasando a los respectivos texbox
    '
    Sub CargarCampos(id As Integer)
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")

        Dim da As New SqlDataAdapter("SELECT TOP (1000) [id_prov],[Nom_prov] as nombre, [Dir_prov] as direccion ,[Tel_prov] as telefono, [Mail_prov] as mail FROM [TPFinal].[dbo].[Proveedores] WHERE id_prov =" & id, conn)
        Dim ds As New DataSet
        da.Fill(ds, "proveedores")
        txtDireccion.Text = ds.Tables("proveedores").Rows(0)("direccion")
        txtNombre.Text = ds.Tables("proveedores").Rows(0)("nombre")
        txtTelefono.Text = ds.Tables("proveedores").Rows(0)("telefono")
        txtMail.Text = ds.Tables("proveedores").Rows(0)("mail")

        conn.Close()
    End Sub
    '
    'Boton Nuevo Proveedor
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Se abre la ventana para agregar al nuevo proveeedor
        NuevoProveedor.ShowDialog()
        'Se llama a la funcion para cargar el DGV
        cargaDataGrid()

    End Sub
    '
    'BOTON eliminar
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idpro > 0 Then 'Se verifica si hay  producto seleccionado
            'Se pide confirmacion
            If MessageBox.Show("Está por ELIMINAR definitivamente al Proveedor: " & txtNombre.Text.Trim.ToUpper & ". Es defitivo, sus datos no se podran recuperar. Está SEGURO?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
            'Se ejecuta la consulta sql
            If SQL_Accion("delete from Proveedores  where  id_prov=" & idpro) = False Then
                'Si falla se informa
                MsgBox("Hubo un error al intentar eliminar al proveedor, reintente, y si el error persiste, anote todos los datos que quizo eliminar y comuníquese con el programador.")
            Else
                'Si hay exito se elimina la fila del eliminado del DGV
                dgvProveedores.Rows.RemoveAt(dgvProveedores.CurrentRow.Index)
                ''Se informa del exito
                MsgBox("El Proveedor fue ELIMINADO de la base de datos.")
                'Se iguala a cero elidpro(Que se uso para eliminarlos)
                idpro = 0
                'Se llama a la funcion de carga DGV 
                cargaDataGrid()
            End If
        Else
            'Si no hay nada seleccionado se informa
            MessageBox.Show("Seleccione un Proveedor para eliminar!")

        End If
    End Sub

    'Boton Actualizar
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        If idpro > 0 Then 'Se verifica si hay algo seleccionado
            Dim nombre, direccion, telefono, mail As String
            'Se obtienen los datos visibles en los diferentes campos
            nombre = txtNombre.Text.Trim
            direccion = txtDireccion.Text.Trim
            mail = txtMail.Text.Trim
            telefono = txtTelefono.Text.Trim
            'Se pide confirmaciom
            If MessageBox.Show("Está por modicar los datos del Proveedor seleccionado. Está SEGURO?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
            'Se realiza la consulta sql, Se usan los datos obtenidos de los campos
            If SQL_Accion("UPDATE [dbo].[Proveedores] SET [Nom_prov] ='" & nombre & "', [Dir_prov] ='" & direccion & "',[Tel_prov] = '" & telefono & "', [Mail_prov] = '" & mail & "' WHERE id_prov = " & idpro) = True Then
                'Se informa de exito
                MsgBox("Cambios realizados correctamente.")
            End If
        Else
            'Si no hay nada seleccionad se informa
            MsgBox("Seleccione un proveedor para realizar los cambios.")
        End If
    End Sub


End Class