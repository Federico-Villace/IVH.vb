

Imports System.Data.SqlClient

Public Class Clientes
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub
    Dim idcli As Integer
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As String = "SELECT TOP (1000) [id_cli], [Nom_cli], [Ape_cli] FROM [TPFinal].[dbo].[Clientes]"
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter(cmd, conn)
        Dim ds As New DataSet


        da.Fill(ds, "clientes")
        dgvClientes.DataSource = ds.Tables("clientes")
        conn.Close()




    End Sub

    Private Sub dgvClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellContentClick

    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        Dim fila As Integer = dgvClientes.CurrentRow.Index
        Dim id As Integer

        id = dgvClientes.Item(0, fila).Value()
        idcli = id
        CargarCampos(id)




    End Sub

    '
    'Buscar: recibe una condicion
    '
    Sub buscar(ByVal condicion As String)
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        'Dim da As New SqlDataAdapter("SELECT TOP 100 Ape_cli,Nom_cli,id_cli from Clientes where " & condicion & " order by Ape_cli", conn)
        Dim da As New SqlDataAdapter("SELECT TOP (100) [id_cli], [Nom_cli], [Ape_cli] FROM [TPFinal].[dbo].[Clientes] where " & condicion & " order by id_cli", conn)
        Dim ds As New DataSet
        da.Fill(ds, "Clientes")

        dgvClientes.DataSource = ds.Tables("Clientes")
        'dgvClientes.Refresh()
        'dgvClientes.Visible = True
        conn.Close()



    End Sub

    '
    'Boton buscar Envia como parametro del metodo buscar() lo escrito en el txt(Es parte de la condicion de busqueda).
    '
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscar(" Ape_cli like '" & txtBusqueda.Text & "%' ")

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
        buscar(" Ape_cli like '" & txtBusqueda.Text & "%' ")
    End Sub

    '
    'Carga todos los campos correspondientes al ID que se le pasa, los carga en un data set y de ahi los va pasando a los respectivos texbox
    '
    Sub CargarCampos(id As Integer)
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        'If Val(lLegajo.Text) = 0 Then
        '    pBotones.Visible = False
        '    pCampos.Visible = False

        '    Exit Sub
        'Else
        '    pBotones.Visible = True
        '    pCampos.Visible = True
        'Dim da As New SqlDataAdapter("SELECT  upper(ltrim(rtrim(isnull(apellidoprof,'****')))) as apellido, upper(ltrim(rtrim(isnull(nombreprof,'****')))) as nombres,isnull([documento-Prof],0) as doc, ltrim(rtrim(isnull(domicilioprof,''))) as dirección,ltrim(rtrim(isnull(localidadprof,''))) as localidad,ltrim(rtrim(isnull(provinciaprof,''))) as provincia,ltrim(rtrim(isnull(teléfonosProf,''))) as teléfonos,FechanacimientoProf as fechanacimiento,ltrim(rtrim(isnull(comentariosProf,''))) as comentarios,ltrim(rtrim(isnull([E-Mail-Prof],''))) as email, isnull(estado,0) as Estado  from profesores where nprof=" & Val(lLegajo.Text), con)
        Dim da As New SqlDataAdapter("SELECT TOP (1000) [id_cli],[Nom_cli] as nombre, [Ape_cli] as apellido ,[DNI_cli] as dni, [Tel_cli] as telefono, [Mail_cli] as mail FROM [TPFinal].[dbo].[Clientes] WHERE id_cli =" & id, conn)
        Dim ds As New DataSet
        da.Fill(ds, "Clientes")
        txtApellido.Text = ds.Tables("Clientes").Rows(0)("apellido")
        txtNombre.Text = ds.Tables("Clientes").Rows(0)("Nombre")
        txtDNI.Text = ds.Tables("Clientes").Rows(0)("dni")
        txtTelefono.Text = ds.Tables("Clientes").Rows(0)("telefono")
        txtMail.Text = ds.Tables("Clientes").Rows(0)("mail")
        '    TextBox1.Text = ds.Tables("Alumnos").Rows(0)("apellido")
        '    TextBox2.Text = ds.Tables("Alumnos").Rows(0)("nombres")
        '    TextBox3.Text = ds.Tables("Alumnos").Rows(0)("doc")

        '    TextBox4.Text = ds.Tables("Alumnos").Rows(0)("Dirección")
        '    TextBox5.Text = ds.Tables("Alumnos").Rows(0)("localidad")
        '    TextBox8.Text = ds.Tables("Alumnos").Rows(0)("provincia")
        '    TextBox6.Text = ds.Tables("Alumnos").Rows(0)("teléfonos")
        '    TextBox7.Text = ds.Tables("Alumnos").Rows(0)("email")
        '    CheckBox1.Checked = IIf(ds.Tables("Alumnos").Rows(0)("estado") = 0, False, True)


        '    TextBox12.Text = ds.Tables("Alumnos").Rows(0)("comentarios")

        '    DateTimePicker1.Value = ds.Tables("Alumnos").Rows(0)("fechanacimiento")
        'End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Nuevo.ShowDialog()
        'Dim nombre, apellido, mail, telefono As String
        'Dim dni As Decimal
        'nombre = txtNombre.Text.Trim
        'apellido = txtApellido.Text.Trim
        'mail = txtMail.Text.Trim
        'telefono = txtTelefono.Text.Trim
        'dni = VNum(txtDNI.Text)

        'If MessageBox.Show("Esta seguro de agregar un cliente nuevo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
        '    '"INSERT INTO [dbo].[Clientes] ([Nom_cli], [Ape_cli], [DNI_cli], [Tel_cli], [Mail_cli]) VALUES ('Alejandro', 'apellido', 92365987, 'telefon', 'algo@hotmail.com')"
        '    If SQL_Accion("INSERT INTO [dbo].[Clientes] ([Nom_cli], [Ape_cli], [DNI_cli], [Tel_cli], [Mail_cli]) VALUES ('" & nombre & "', '" & apellido & "', " & dni & ", '" & telefono & "', '" & mail & "')") Then
        '        'MsgBox.show("El cliente "& nombre &" "& apellido & " ha sido agregado" )
        '        MessageBox.Show("El cliente " & nombre & " " & apellido & " ha sido agregado")
        txtBusqueda.Text = Nuevo.txtApellido.Text
        buscar(" Ape_cli like '" & txtBusqueda.Text & "%' ")

        'End If
        'End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If idcli > 0 Then
            If MessageBox.Show("Está por ELIMINAR definitivamente al Cliente: " & txtNombre.Text.Trim.ToUpper & " " & txtApellido.Text.Trim.ToUpper & ". Es defitivi, sus datos no se podran recuperar. Está SEGURO?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

            If SQL_Accion("delete from Clientes  where  id_cli=" & idcli) = False Then
                MsgBox("Hubo un error al intentar borrar al Profesor, reintente, y si el error persiste, anote todos los datos que quizo ingresar y comuníquese con el programador.")
            Else

                txtBusqueda.Text = ""
                buscar(" Ape_cli like '" & txtBusqueda.Text & "%' ")
                MsgBox("El Profesor fue ELIMINADO de la base de datos.")

            End If
        Else
            MessageBox.Show("Seleccione un cliente para eliminar!")

        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click


        If idcli > 0 Then
            Dim nombre, apellido, mail, telefono As String
            Dim dni As Decimal
            nombre = txtNombre.Text.Trim
            apellido = txtApellido.Text.Trim
            mail = txtMail.Text.Trim
            telefono = txtTelefono.Text.Trim
            dni = VNum(txtDNI.Text)
            If MessageBox.Show("Está por modicar los datos del Cliente seleccionado. Está SEGURO?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then Exit Sub

            If SQL_Accion("UPDATE [dbo].[Clientes] SET [Nom_cli] ='" & nombre & "', [Ape_cli] ='" & apellido & "', [DNI_cli] = " & dni & ", [Tel_cli] = '" & telefono & "', [Mail_cli] = '" & mail & "' WHERE id_cli = " & idcli) = True Then
                MsgBox("Cambios realizados correctamente.")
            End If
        Else
            MsgBox("Seleccione un cliente para realizar los cambios.")
        End If
    End Sub
End Class