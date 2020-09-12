Imports System.Data.SqlClient

Public Class Clientes
    'idcli, se declara aca para poder ser usado en todos los Subs procesos(funciones)
    Dim idcli As Integer
    'Funcion que cargar dataGridVBiew de clientes
    Public Sub cargadgvClientes()
        Dim cmd As String = "SELECT TOP (1000) [id_cli], [Nom_cli], [Ape_cli] FROM [TPFinal].[dbo].[Clientes]"
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter(cmd, conn)
        Dim ds As New DataSet


        da.Fill(ds, "clientes")
        dgvClientes.DataSource = ds.Tables("clientes")
        conn.Close()
    End Sub
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al abrir la ventana se llama a la funcion para cargar el data grid View
        cargadgvClientes()
    End Sub

    'Evento de cambio de cliente seleccionado en el data grid view
    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvClientes.SelectionChanged
        If dgvClientes.Rows.Count > 0 Then 'Se verifica que se el datagridView este lleno
            Dim fila As Integer = dgvClientes.CurrentRow.Index
            Dim id As Integer

            id = dgvClientes.Item(0, fila).Value() 'Se obtiene el id del cliente seleccionado en el DGV,Se utiliza para llenar los campos
            idcli = id
            CargarCampos(id) 'Se llama a la funcion para cargar los campos
        Else
            'Si esta vacio se limpian todos los ampos
            txtApellido.Text = ""
            txtNombre.Text = ""
            txtDNI.Text = ""
            txtMail.Text = ""
            txtTelefono.Text = ""
        End If

    End Sub


    'Buscar: recibe una condicion

    Sub buscar(ByVal condicion As String)
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        'Consulta conla cual se realiza la busqueda. Se concatena con la condicion recibida
        Dim da As New SqlDataAdapter("SELECT TOP (100) [id_cli], [Nom_cli], [Ape_cli] FROM [TPFinal].[dbo].[Clientes] where " & condicion & " order by id_cli", conn)
        Dim ds As New DataSet
        da.Fill(ds, "Clientes")

        dgvClientes.DataSource = ds.Tables("Clientes")

        conn.Close()



    End Sub


    'Boton buscar Envia como parametro del metodo buscar() lo escrito en el txt(Es parte de la condicion de busqueda).

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar(" Ape_cli like '" & txtBusqueda.Text & "%' ")

    End Sub



    'Boton Mostrar TODO: llama a la funcion para llenar el DGV

    Private Sub btnMostrarTodo_Click(sender As Object, e As EventArgs) Handles btnMostrarTodo.Click
        cargadgvClientes()
    End Sub


    'Carga todos los campos correspondientes al ID que se le pasa, los carga en un data set y de ahi los va pasando a los respectivos texbox

    Sub CargarCampos(id As Integer)
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")

        Dim da As New SqlDataAdapter("SELECT TOP (1000) [id_cli],[Nom_cli] as nombre, [Ape_cli] as apellido ,[DNI_cli] as dni, [Mail_cli] as mail,[Cel_cli] as cel FROM [TPFinal].[dbo].[Clientes] WHERE id_cli =" & id, conn)
        Dim ds As New DataSet
        da.Fill(ds, "Clientes")
        txtApellido.Text = ds.Tables("Clientes").Rows(0)("apellido")
        txtNombre.Text = ds.Tables("Clientes").Rows(0)("Nombre")
        txtDNI.Text = ds.Tables("Clientes").Rows(0)("dni")
        txtMail.Text = ds.Tables("Clientes").Rows(0)("mail")
        txtTelefono.Text = ds.Tables("Clientes").Rows(0)("cel")
        conn.Close()

    End Sub
    'Boton nuevo cliente: abre la ventana de nuevo cliente
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo.ShowDialog()
        '
        'Cuando se cierra la ventana de nue cliente se "refresca" el DGV 
        txtBusqueda.Text = "" 'Se pone el campo de busqueda en blanco
        buscar(" Ape_cli like '" & txtBusqueda.Text & "%' ") 'se llama a la funcion buscar com el campo vacio para que mestretodo


    End Sub
    '
    'Boton eliminar:Elimina al cliente selecciona actualmente
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Se verifica que haya cliente seleccionado
        If idcli > 0 Then
            'Se pide confirmacion
            If MessageBox.Show("Está por ELIMINAR definitivamente al Cliente: " & txtNombre.Text.Trim.ToUpper & " " & txtApellido.Text.Trim.ToUpper & ". Es defitivi, sus datos no se podran recuperar. Está SEGURO?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
            'Se ejecuta la accion
            If SQL_Accion("delete from Clientes  where  id_cli=" & idcli) = False Then
                'Si fgalla se informa
                MsgBox("Hubo un error al intentar borrar al Profesor, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
            Else
                'Si tiene exito, se eliman la fila correspondiente del DGV
                dgvClientes.Rows.RemoveAt(dgvClientes.CurrentRow.Index)
                'Se modifica a cero el valor del id (usado para ejeutar la eliminacion)
                idcli = 0
                'Se carga nuevamente el DGV
                cargadgvClientes()
                'Se informa del exito
                MsgBox("El cliente fue borrado de la base de datos.")

            End If
        Else
            'Si no hay nada seleccionado se informa
            MessageBox.Show("Seleccione un cliente para eliminar!")

        End If
    End Sub
    ''Boton actualizar: Actualiza losdatos del cliente seleccinado, utiliza los campos visibles de la ventana principal
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        'Se verifica que haya algo seleccionado
        If idcli > 0 Then
            'Se obtienen los ddatos de todos los campos, hayan sido modificados o no
            Dim nombre, apellido, mail, telefono As String
            Dim dni As Decimal
            nombre = txtNombre.Text.Trim
            apellido = txtApellido.Text.Trim
            mail = txtMail.Text.Trim
            telefono = txtTelefono.Text.Trim
            dni = Val(txtDNI.Text)
            'Se pide cofirmacion
            If MessageBox.Show("Está por modicar los datos del Cliente seleccionado. Está SEGURO?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub
            'Se ejecuta la consulta
            If SQL_Accion("UPDATE [dbo].[Clientes] SET [Nom_cli] ='" & nombre & "', [Ape_cli] ='" & apellido & "', [DNI_cli] = " & dni & ", [Mail_cli] = '" & mail & "',[Cel_cli] = '" & telefono & "' WHERE id_cli = " & idcli) = True Then
                'Se informa del exito
                MsgBox("Cambios realizados correctamente.")
            End If
        Else
            'Si no hay nada seleccionado se informa
            MsgBox("Seleccione un cliente para realizar los cambios.")
        End If
    End Sub
    '
    'Boton Volver. Cierra el formulario Clientes
    '
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


End Class