Imports System.Configuration
Imports System.Data.SqlClient
Public Class BD_Sql
    Private Property Cadena As String = ConfigurationManager.ConnectionStrings("ConexionSQL").ConnectionString

    'Solicitar datos de una tabla
    Public Function EjecutarConsulta(ByVal consulta As String) As DataTable
        Dim tabla As New DataTable()

        Try
            Using conexion As New SqlConnection(Cadena)
                conexion.Open()

                Using cmd As New SqlCommand(consulta, conexion)
                    Using da As New SqlDataAdapter(cmd)
                        da.Fill(tabla)
                        If tabla.Rows.Count = 0 Then
                            MessageBox.Show("No se encontraron resultados para la consulta.")
                        Else
                            fromVistaTablas.dgvVistas.DataSource = tabla
                        End If
                    End Using
                End Using
                conexion.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al ejecutar la consulta: " & ex.Message)
        End Try

        Return tabla
    End Function

    'Enviar datos a una tabla
    Public Sub EnviarDatos(ByVal tabla As String, ByVal datos As Dictionary(Of String, Object))
        Try
            Using conexion As New SqlConnection(Cadena)
                conexion.Open()
                Dim columnas As String = String.Join(", ", datos.Keys)
                Dim valores As String = String.Join(", ", datos.Keys.Select(Function(k) "@" & k))
                Dim consulta As String = $"INSERT INTO {tabla} ({columnas}) VALUES ({valores})"
                Using cmd As New SqlCommand(consulta, conexion)
                    For Each kvp In datos
                        cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
                    Next
                    cmd.ExecuteNonQuery()
                    conexion.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al enviar los datos: " & ex.Message)
        End Try
    End Sub

    'Actualizar datos en una tabla
    Public Sub ActualizarDatos(ByVal tabla As String, ByVal datos As Dictionary(Of String, Object), ByVal condicion As String)
        Try
            Using conexion As New SqlConnection(Cadena)
                conexion.Open()
                Dim actualizaciones As String = String.Join(", ", datos.Keys.Select(Function(k) k & " = @" & k))
                Dim consulta As String = $"UPDATE {tabla} SET {actualizaciones} WHERE ID = {condicion}"
                Using cmd As New SqlCommand(consulta, conexion)
                    For Each kvp In datos
                        cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
                    Next
                    cmd.ExecuteNonQuery()
                    conexion.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos: " & ex.Message)
        End Try
    End Sub

    'Eliminar datos de una tabla
    Public Sub EliminarDatos(ByVal tabla As String, ByVal condicion As String)
        Try
            Using conexion As New SqlConnection(Cadena)
                conexion.Open()
                Dim consulta As String = $"DELETE FROM {tabla} WHERE ID = {condicion}"
                Using cmd As New SqlCommand(consulta, conexion)
                    cmd.ExecuteNonQuery()
                    conexion.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar los datos: " & ex.Message)
        End Try
    End Sub
End Class
