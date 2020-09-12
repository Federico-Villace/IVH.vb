Imports System.Data.SqlClient
Public Class HistorialMovimientosExtras
    '
    'Funcion que carga el DGV: recibe una consulta
    Private Sub cargaventas(consulta As String)
        Dim cmd As String = consulta
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter(cmd, conn)
        Dim ds As New DataSet

        da.Fill(ds, "movExtras")
        dgvMovExt.DataSource = ds.Tables("movExtras")


        conn.Close()
    End Sub
    'Evento LOAD
    Private Sub HistorialMovimientosExtras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'LLamado a la funcion de cargar DGV con todos los elementos
        cargaventas("SELECT * FROM [TPFinal].[dbo].[MovExtras]")
        'Se selecciona por defecto el radioButton Fecha al abrir la ventana
        rbFecha.Select()

    End Sub
    '
    'Boton buscar(filtrar)
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim query, fecha As String
        'Se declara la consulta dejando la condicion
        query = "SELECT TOP (1000) [ID_ME] as ID, [MONTO], [ING], [EGR], [FECHA], [HORA] FROM [TPFinal].[dbo].[MovExtras] WHERE "

        'Dependiendo de que RadioButton este selecciona seconcatena la condicion a la consulta y luegose llama a la funcion para cargar la tabla
        If rbFecha.Checked Then
            fecha = Format(Calendario.Value, "yyyy/MM/dd").ToString 'Se obtiene la fecha seleccionada en el panel de fecha
            cargaventas(query & "[FECHA] = '" & fecha & "'")
        ElseIf rbIngreso.Checked Then
            'Para mostrar solo los ingresos
            cargaventas(query & "[ING]='SI'")
        ElseIf rbEgreso.Checked Then
            'Para mostrar solo los egresos
            cargaventas(query & "[EGR] = 'SI'")
        End If
    End Sub
    '
    'Boton mostrar todo
    Private Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        'LLama a la funcion para cargar el DGV con todo lo que hay guardado
        cargaventas("SELECT * FROM [TPFinal].[dbo].[MovExtras]")
    End Sub
    '
    'Boton Volver
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        'Se cierra la ventana
        Me.Close()
    End Sub
End Class