Imports System.Data.SqlClient
Public Class movExtra
    '
    'Actualiza tablas: recibe un string con la accion a realizar
    Private Sub ActualizaTablas(accion As String)

        Dim monto, hora, fecha, queryIngreso, queryEgreso, updateCajaEgr, updateCajaIng, concepto As String
        monto = txtMontoExtra.Text.Replace(",", ".") 'Reemplaza la coma decimal por punto decimal que es el que recibe SQLServer
        concepto = TextConcepto.Text
        hora = DateTime.Now.ToShortTimeString
        'Se obtine la fecah actualllamando a la funcion FechaConFormatoIso()
        fecha = FechaConFormatoIso()

        'SENTENCIA SQL QUE REGISTRA EL INGRESO EXTRA RELIZADO 
        queryIngreso = "INSERT INTO [dbo].[MovExtras]([MONTO],[ING],[EGR],[FECHA],[HORA], [CONCEPTO]) VALUES('" & monto & "','SI','NO','" & fecha & "','" & hora & "','" & concepto & "')"
        'SENTENCIA SQL QUE ACTUALIZA EL ESTADO DE LA CAJA TRAS UN INGRESO 
        updateCajaIng = "UPDATE [dbo].[Caja] SET [Monto] =((select Monto from Caja where id_caja=1 )+'" & monto & "') WHERE id_caja=1"
        'SENTENCIA SQL QUE REGISTRA EL INGRESO EXTRA RELIZADO 
        queryEgreso = "INSERT INTO [dbo].[MovExtras]([MONTO],[ING],[EGR],[FECHA],[HORA], [CONCEPTO]) VALUES('" & monto & "','NO','SI','" & fecha & "','" & hora & "', '" & concepto & "')"
        'SENTENCIA SQL QUE ACTUALIZA EL ESTADO DE LA CAJA TRAS UN EGRESO 
        updateCajaEgr = "UPDATE [dbo].[Caja] SET [Monto] =((select Monto from Caja where id_caja=1 )-'" & monto & "') WHERE id_caja=1"

        '
        If accion = "INGRESAR" Then
            If SQL_Accion(queryIngreso) And SQL_Accion(updateCajaIng) Then
                MsgBox("Ingreso realizado correctamente")
            Else
                MsgBox("Verifique los datos ingresados")
            End If
        ElseIf accion = "RETIRAR" Then
            If SQL_Accion(queryEgreso) And SQL_Accion(updateCajaEgr) Then
                MsgBox("Retiro registrado correctamente")
            Else
                MsgBox("Verifique los datos ingresados")
            End If
        End If

    End Sub

    Private Sub btnIng_Click(sender As Object, e As EventArgs) Handles btnIng.Click
        'SI SE PRESIONA EL BOTON INGRESAR
        If txtMontoExtra.Text <> "" Then 'Se verifica que el campo no este vacio
            'Se pregunta si esta seguro de realizar la operacion
            If MessageBox.Show("Esta seguro de realizar INGRESO?", "Retirar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                'Se llama a la funcion actualiza tablas
                ActualizaTablas("INGRESAR")
                'Se vacia el campo
                txtMontoExtra.Text = ""
                TextConcepto.Text = ""
                txtMontoExtra.Select()
                actualizarMonto()
            End If

        Else
            MsgBox("Por favor ingrese un monto")

        End If
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        'SI SE PRESIONA EL BOTON RETIRAR
        If txtMontoExtra.Text <> "" Then 'Se verifica que el campo no este vacio
            'Se pregunta si esta seguro de realizar la operacion
            If MessageBox.Show("Esta seguro RETIRAR dinero?", "Retirar", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                'Se llama a la funcion actualiza tablas
                ActualizaTablas("RETIRAR")
                'Se vacia el campo
                txtMontoExtra.Text = ""
                TextConcepto.Text = ""
                txtMontoExtra.Select()
                actualizarMonto()
            End If

        Else
            MsgBox("Por favor ingreseun monto")

        End If

    End Sub

    'Actualizar monto de caja
    Private Sub actualizarMonto()
        Dim cmd As String = "SELECT TOP (1000) [id_caja],[Monto] FROM [TPFinal].[dbo].[Caja]"
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter(cmd, conn)
        Dim ds As New DataSet

        da.Fill(ds, "caja")
        txtMontoActual.Text = "$" & ds.Tables("caja").Rows(0)("Monto")

        conn.Close()
    End Sub

    '
    'Se selcciona por default el campo monto y se establecle el monto actual de caja
    Private Sub movExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMontoExtra.Select()
        actualizarMonto()

    End Sub


End Class