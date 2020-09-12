Imports System.Data.SqlClient

Public Class Compras
    Dim prov As String
    'Carga la lista de proovedores
    Public Sub cargaComboProv()
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")
        Dim da As New SqlDataAdapter("SELECT TOP (1000) [Nom_prov] as nombre FROM [TPFinal].[dbo].[Proveedores]", conn)
        Dim ds As New DataTable

        da.Fill(ds)

        ComboProv.DataSource = ds
        ComboProv.DisplayMember = "nombre" 'Que campo muestra
        ComboProv.ValueMember = "nombre" 'Que campo usa como valor

        conn.Close()
    End Sub

    Private Sub ComboProv_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboProv.SelectedValueChanged
        prov = ComboProv.Text
    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al abrir la ventana se usan los datos seleccionados del producto, se carga la lista de prov. y se marca como seleccionado el campo cantidad
        txtCod.Text = Productos.idC
        txtProd.Text = Productos.nombreP
        cargaComboProv()
        txtCant.Select()

    End Sub

    'Boton confirmar
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim fecha, queryInsertCompra, queryUpdateStock, queryUpdateCaja, monto, prod As String
        Dim cant, id As Integer
        'Se obtiene la fecha y hora actual y los datos cargados en los diferentes campos
        cant = Val(txtCant.Text)
        id = Val(txtCod.Text)
        fecha = FechaConFormatoIso()
        prod = txtProd.Text
        monto = txtTotal.Text.Replace(",", ".")

        'Si los campos que no son estrictamente nesesarios estan vacios se los iguala a cero
        If txtTotal.Text = "" Then
            MsgBox("Ingrese el monto de la compra")
            Exit Sub
        End If
        If txtCant.Text = "" Then
            cant = 0
        End If
        'Se declaran las diferentes consultadas para cada tabla afectada por la operacion
        queryInsertCompra = "INSERT INTO [dbo].[Compras] ([fecha_compra], [monto_compra], [proveedorDeCompra], [prodComprado]) VALUES ('" & fecha & "'," & monto & ",'" & prov & "','" & prod & "')"
        queryUpdateStock = "UPDATE [dbo].[Productos] SET [Stock_pro] =((select Stock_pro from Productos where id_prod=" & id & " )+ " & cant & ") WHERE id_prod=" & id
        queryUpdateCaja = "UPDATE [dbo].[Caja] SET [Monto] =((select Monto from Caja where id_caja=1 )-'" & monto & "') WHERE id_caja=1"

        Try
            'se ejecutan las consultas
            SQL_Accion(queryInsertCompra)
            SQL_Accion(queryUpdateCaja)
            SQL_Accion(queryUpdateStock)

            'Se informa que se realizo la copmpra correctamente
            MsgBox("Registro de compra realizado correctamente.")
            'Se limpian todos los campos
            txtCod.Text = ""
            txtProd.Text = ""
            txtCant.Text = ""
            txtTotal.Text = ""
            'Se cierra la ventana
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message & "Fallo al registrar datos")
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Se limpian todos los campos
        txtCod.Text = ""
        txtProd.Text = ""
        txtCant.Text = ""
        txtTotal.Text = ""
        'Se cierra la ventana
        Me.Close()
        Me.Close()
    End Sub
End Class