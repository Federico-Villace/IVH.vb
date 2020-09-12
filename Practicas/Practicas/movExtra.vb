Public Class movExtra
    '
    'Actualiza tablas: recibe un string con la accion a realizar
    Private Sub ActualizaTablas(accion As String)

        Dim monto, hora, fecha, queryIngreso, queryEgreso, updateCajaEgr, updateCajaIng As String
        monto = txtMontoExtra.Text.Replace(",", ".") 'Reemplaza la coma decimal por punto decimal que es el que recibe SQLServer
        'Se obtiene la hora actual
        hora = DateTime.Now.ToShortTimeString
        'Se obtine la fecah actualllamando a la funcion FechaConFormatoIso()
        fecha = FechaConFormatoIso()

        'SENTENCIA SQL QUE REGISTRA EL INGRESO EXTRA RELIZADO 
        queryIngreso = "INSERT INTO [dbo].[MovExtras]([MONTO],[ING],[EGR],[FECHA],[HORA]) VALUES('" & monto & "','SI','NO','" & fecha & "','" & hora & "')"
        'SENTENCIA SQL QUE ACTUALIZA EL ESTADO DE LA CAJA TRAS UN INGRESO 
        updateCajaIng = "UPDATE [dbo].[Caja] SET [Monto] =((select Monto from Caja where id_caja=1 )+'" & monto & "') WHERE id_caja=1"
        'SENTENCIA SQL QUE REGISTRA EL INGRESO EXTRA RELIZADO 
        queryEgreso = "INSERT INTO [dbo].[MovExtras]([MONTO],[ING],[EGR],[FECHA],[HORA]) VALUES('" & monto & "','NO','SI','" & fecha & "','" & hora & "')"
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
                txtMontoExtra.Select()

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
                txtMontoExtra.Select()
            End If

        Else
            MsgBox("Por favor ingreseun monto")

        End If

    End Sub

    Private Sub movExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMontoExtra.Select()

    End Sub


End Class