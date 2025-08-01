Public Class Ventas
    Inherits BD_Sql

    Public Property Id As Integer
    Public Property Fecha As Date
    Public Property ClienteId As Integer
    Public Property Total As Decimal

    Public Sub New()
    End Sub

    Public Sub New(fecha As Date, clienteId As Integer, total As Decimal)
        Me.Fecha = fecha
        Me.ClienteId = clienteId
        Me.Total = total
        Guardar()
    End Sub

    Public Sub Guardar()
        Dim datos As New Dictionary(Of String, Object) From {
            {"Fecha", Me.Fecha},
            {"ClienteId", Me.ClienteId},
            {"Total", Me.Total}
        }
        EnviarDatos("ventas", datos)
    End Sub

    Public Sub Modificar()
        Dim datos As New Dictionary(Of String, Object) From {
            {"Fecha", Me.Fecha},
            {"ClienteId", Me.ClienteId},
            {"Total", Me.Total}
        }
        ActualizarDatos("ventas", datos, Me.Id)
    End Sub

    Public Sub Eliminar()
        EliminarDatos("ventas", Me.Id.ToString())
    End Sub

    Public Sub CargarPorId(idVenta As Integer)
        Dim consulta As String = $"SELECT * FROM ventas WHERE ID = {idVenta}"
        Dim resultado As DataTable = EjecutarConsulta(consulta)

        If resultado.Rows.Count > 0 Then
            Dim fila = resultado.Rows(0)
            Me.Id = idVenta
            Me.Fecha = Convert.ToDateTime(fila("Fecha"))
            Me.ClienteId = Convert.ToInt32(fila("ClienteId"))
            Me.Total = Convert.ToDecimal(fila("Total"))
        Else
            Throw New Exception("Venta no encontrada.")
        End If
    End Sub
End Class


Public Class VentaDT
    Inherits BD_Sql

    Public Property Id As Integer
    Public Property VentaId As Integer
    Public Property ProductoId As Integer
    Public Property Cantidad As Integer
    Public Property Subtotal As Decimal

    Public Sub New()
    End Sub

    Public Sub New(ventaId As Integer, productoId As Integer, cantidad As Integer, subtotal As Decimal)
        Me.VentaId = ventaId
        Me.ProductoId = productoId
        Me.Cantidad = cantidad
        Me.Subtotal = subtotal
        Guardar()
    End Sub

    Public Sub Guardar()
        Dim datos As New Dictionary(Of String, Object) From {
            {"VentaId", Me.VentaId},
            {"ProductoId", Me.ProductoId},
            {"Cantidad", Me.Cantidad},
            {"Subtotal", Me.Subtotal}
        }
        EnviarDatos("ventasitems", datos)
    End Sub

    Public Sub Modificar()
        Dim datos As New Dictionary(Of String, Object) From {
            {"VentaId", Me.VentaId},
            {"ProductoId", Me.ProductoId},
            {"Cantidad", Me.Cantidad},
            {"Subtotal", Me.Subtotal}
        }
        ActualizarDatos("ventasitems", datos, Me.Id)
    End Sub

    Public Sub Eliminar()
        EliminarDatos("ventasitems", Me.Id.ToString())
    End Sub

    Public Sub CargarPorId(idVentaItem As Integer)
        Dim consulta As String = $"SELECT * FROM ventasitems WHERE ID = {idVentaItem}"
        Dim resultado As DataTable = EjecutarConsulta(consulta)

        If resultado.Rows.Count > 0 Then
            Dim fila = resultado.Rows(0)
            Me.Id = idVentaItem
            Me.VentaId = Convert.ToInt32(fila("VentaId"))
            Me.ProductoId = Convert.ToInt32(fila("ProductoId"))
            Me.Cantidad = Convert.ToInt32(fila("Cantidad"))
            Me.Subtotal = Convert.ToDecimal(fila("Subtotal"))
        Else
            Throw New Exception("Detalle de venta no encontrado.")
        End If
    End Sub
End Class
