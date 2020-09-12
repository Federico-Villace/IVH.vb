Imports System.Data.SqlClient
Public Class HistorialVentas
    Dim query As String
    '
    'Funcion que carga el DGV: Recibe la consulta sql como parametro
    Private Sub cargaventas(consulta As String)
        Dim cmd As String = consulta
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter(cmd, conn)
        Dim ds As New DataSet

        da.Fill(ds, "ventas")
        dgvVentas.DataSource = ds.Tables("ventas")
        'Se oculta la columna de comentarios
        dgvVentas.Columns(6).Visible = False

        conn.Close()
    End Sub

    'Funcion que llena la lista desplegable con apellido y nombre de clientes
    Public Sub llenacbClientes()
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter("SELECT [Ape_cli] +' '+[Nom_cli] as nombre,[DNI_cli] as dni FROM [TPFinal].[dbo].[Clientes] order by nombre", conn)
        Dim ds As New DataTable

        da.Fill(ds)

        cbClientes.DataSource = ds
        cbClientes.DisplayMember = "nombre" 'Valor que se muestra en el texto
        cbClientes.ValueMember = "nombre" ' Valor que se usa para realizar alguna accion

        conn.Close()

    End Sub
    '
    'Evento que se ejecuta al abrir la ventana
    '
    Private Sub HistorialVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "SELECT  [id_vent], [Cli_ven] as Cliente, [Total_vendido] as Total, [Remito_ven] as Remito, [Fecha_ven] as Fecha, [Hora_ven] as Hora, [Detalle_Ven] As Detalle FROM [TPFinal].[dbo].[Ventas]"
        'Se oculta el calendario
        calendario.Visible = False
        'Se cargar  cal lista de clientes
        llenacbClientes()
        'Se selecciona un radiobuttonpor defecto
        rbCliente.Select()
        'Se llena el DGV con todo lo diponible
        cargaventas(query)
    End Sub
    '
    'Evento que sucede al cambiar elemento seleccionado
    Private Sub dgvVentas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVentas.SelectionChanged
        If dgvVentas.Rows.Count > 0 Then 'Se verifica que hay algo seleccionado
            'Secarga el cuadrode detalle con el comentario de la columna oculta
            txtComentarios.Text = dgvVentas.Item(6, dgvVentas.CurrentRow.Index).Value()
        Else
            'Se borra el cuadro de detalle
            txtComentarios.Text = ""
        End If


    End Sub

    '
    'Evento que sucede al seleccionar el RB fecha
    Private Sub rbFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbFecha.CheckedChanged
        'Se oculta el campo de busqueda y la lista de clientes
        txtBusqueda.Visible = False
        cbClientes.Visible = False
        'Se limpia al campo buqueda
        txtBusqueda.Text = ""
        'Se muestra el calendario
        calendario.Visible = True

    End Sub
    '
    'Evento que sucede al seleccionar el RB cliente
    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged
        'Se ocultan elcalenario y          el campo busqueda
        calendario.Visible = False
        txtBusqueda.Visible = False
        cbClientes.Visible = True
    End Sub
    '
    'Evento que sucede al seleccionar el RB remito
    Private Sub rbRemito_CheckedChanged(sender As Object, e As EventArgs) Handles rbRemito.CheckedChanged
        'Se ocultan la lista de clientes y el calendario
        calendario.Visible = False
        cbClientes.Visible = False
        'Se muestra el campo de busqueda
        txtBusqueda.Visible = True
    End Sub
    '
    'Boton Mostrar Todo
    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        'Se lla a la funcion de cargar el DGV con la query corrspondiente para cargar y mostrar todo
        query = "SELECT TOP (1000) [id_vent], [Cli_ven] as Cliente, [Total_vendido] as Total, [Remito_ven] as Remito, [Fecha_ven] as Fecha, [Hora_ven] as Hora, [Detalle_Ven] As Detalle FROM [TPFinal].[dbo].[Ventas]"
        cargaventas(query)
    End Sub
    '
    'Boton buscar: Segun el RB seleccionado se realiza la busqueda correspondiente
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim fecha, numRem, nombre As String
        'Se declara la query que traera los campos correspondientes de la BDD. será completada segun corresponda.
        query = "SELECT TOP (1000) [id_vent], [Cli_ven] as Cliente, [Total_vendido] as Total, [Remito_ven] as Remito, [Fecha_ven] as Fecha, [Hora_ven] as Hora, [Detalle_Ven] As Detalle FROM [TPFinal].[dbo].[Ventas] WHERE"
        '
        'De acuerdo a que RB esta seleccionado se completa la query para llamar a la funcion carga DGV
        If rbFecha.Checked Then
            fecha = Format(calendario.Value, "yyyy/MM/dd").ToString
            query = query & "[Fecha_ven] = '" & fecha & "'"
            cargaventas(query)
        ElseIf rbCliente.Checked Then
            nombre = cbClientes.Text
            query = query & "[Cli_ven]='" & nombre & "'"
            cargaventas(query)
        ElseIf rbRemito.Checked Then
            'Si esta seleccionado el botn remito y elcuadro de busqueda esta vacio, se informa y no se realiza la busqueda
            If txtBusqueda.Text = "" Then
                MsgBox("Complete el campo de busqueda")
                Exit Sub
            Else
                numRem = Val(txtBusqueda.Text) 'Convierte el numero a int. Si hay texto lo convierte a cero
            End If

            If numRem <= 0 Then 'Se verifica que sea un numero mayor a cero
                MsgBox("remito inexistente o numero mal ingresado: " & numRem)
                Exit Sub
            Else
                query = query & "[Remito_ven]='" & numRem & "'"
                cargaventas(query)
            End If

        End If
    End Sub
    'Boton volver:Cierra la ventana
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class