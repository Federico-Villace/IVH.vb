Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail

Module Module1
    'Funcion que lee la "Ruta de sql" dentro de un archivo txt ubicado en el dico C:
    Function leerarchivo() As String
        'en ip.txt poner la instancia de SQL
        If File.Exists("c:\ABM\ip.txt") = True Then
            Dim SR As StreamReader = File.OpenText("c:\ABM\ip.txt")
            Dim Line As String = SR.ReadLine()
            SR.Close()
            Return Line
        End If
    End Function



    Function SQL_Accion(ByVal Sql_de_accion As String) As Boolean
        'Ejecuta la consulta de Segun la accion que recibe (INSER, UPDATE, DELETE)
        'devuelve true si se pudo hacer, y false si hubo algún error

        '
        Dim conn As New SqlConnection("data source=" & CStr(leerarchivo()) & "; initial catalog=TPFinal; integrated security=true")

        Dim adapter As New SqlDataAdapter, salida As Boolean = True

        Try
            conn.Open()
            If Sql_de_accion.ToUpper.IndexOf("INSERT") Then

                adapter.InsertCommand = New SqlCommand(Sql_de_accion, conn)
                adapter.InsertCommand.ExecuteNonQuery()
            Else
                If Sql_de_accion.ToUpper.IndexOf("UPDATE") Then
                    adapter.UpdateCommand = New SqlCommand(Sql_de_accion, conn)
                    adapter.UpdateCommand.ExecuteNonQuery()
                Else
                    If Sql_de_accion.ToUpper.IndexOf("DELETE") Then
                        adapter.DeleteCommand = New SqlCommand(Sql_de_accion, conn)
                        adapter.DeleteCommand.ExecuteNonQuery()
                    Else
                        'esta mal la sintaxis porque no hay ni insert, ni delete ni update
                        salida = False
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            salida = False
        End Try
        conn.Close()
        Return salida
    End Function

    'recarga el formulario vender
    Public Sub reiniciar()
        Vender.Close()
        Vender.Show()
        Menu.Hide()
    End Sub

    'funcion que muestra el menu
    Public Sub Mostrarmenu()
        Menu.Show()
    End Sub

    'Captura la fecha actual y le da elformato (Año-mes-dia)
    Function FechaConFormatoIso() As String
        Dim fecha As String
        fecha = Format(DateTime.Now.Date, "yyyy-MM-dd").ToString
        Return fecha
    End Function
End Module
