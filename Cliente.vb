Public Class Cliente
    Inherits BD_Sql

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Correo As String
    Public Property Telefono As String

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, correo As String, telefono As String)
        Me.Nombre = nombre
        Me.Correo = correo
        Me.Telefono = telefono
        Guardar()
    End Sub

    Public Sub Guardar()
        Dim datos As New Dictionary(Of String, Object) From {
            {"Nombre", Me.Nombre},
            {"Correo", Me.Correo},
            {"Telefono", Me.Telefono}
        }
        EnviarDatos("Clientes", datos)
    End Sub

    Public Sub Modificar()
        Dim datos As New Dictionary(Of String, Object) From {
            {"Nombre", Me.Nombre},
            {"Correo", Me.Correo},
            {"Telefono", Me.Telefono}
        }
        ActualizarDatos("Clientes", datos, Me.Id)
    End Sub

    Public Sub Eliminar()
        EliminarDatos("Clientes", Me.Id.ToString())
    End Sub

    Public Sub CargarPorId(idCliente As Integer)
        Dim consulta As String = $"SELECT * FROM Clientes WHERE ID = {idCliente}"
        Dim resultado As DataTable = EjecutarConsulta(consulta)

        If resultado.Rows.Count > 0 Then
            Dim fila = resultado.Rows(0)
            Me.Id = idCliente
            Me.Nombre = fila("Nombre").ToString()
            Me.Correo = fila("Correo").ToString()
            Me.Telefono = fila("Telefono").ToString()
        Else
            Throw New Exception("Cliente no encontrado.")
        End If
    End Sub
End Class
