Public Class Items
    Inherits BD_Sql

    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Precio As Decimal
    Public Property Categoria As String

    ' Constructor vacío (para luego asignar propiedades manualmente)
    Public Sub New()
    End Sub

    ' Constructor para crear y guardar un nuevo producto
    Public Sub New(nombre As String, precio As Decimal, categoria As String)
        Me.Nombre = nombre
        Me.Precio = precio
        Me.Categoria = categoria
        Guardar()
    End Sub

    ' Guarda el item en la base de datos (INSERT)
    Public Sub Guardar()
        Dim datos As New Dictionary(Of String, Object) From {
            {"Nombre", Me.Nombre},
            {"Precio", Me.Precio},
            {"Categoria", Me.Categoria}
        }
        EnviarDatos("productos", datos)
    End Sub

    ' Actualiza el registro existente
    Public Sub Modificar()
        Dim datos As New Dictionary(Of String, Object) From {
            {"Nombre", Me.Nombre},
            {"Precio", Me.Precio},
            {"Categoria", Me.Categoria}
        }
        ActualizarDatos("productos", datos, Me.Id)
    End Sub

    ' Elimina el registro
    Public Sub Eliminar()
        EliminarDatos("productos", Me.Id.ToString())
    End Sub

    ' Cargar un producto desde la base de datos usando su ID
    Public Sub CargarPorId(idProducto As Integer)
        Dim consulta As String = $"SELECT * FROM productos WHERE ID = {idProducto}"
        Dim resultado As DataTable = EjecutarConsulta(consulta)

        If resultado.Rows.Count > 0 Then
            Dim fila = resultado.Rows(0)
            Me.Id = idProducto
            Me.Nombre = fila("Nombre").ToString()
            Me.Precio = Convert.ToDecimal(fila("Precio"))
            Me.Categoria = fila("Categoria").ToString()
        Else
            Throw New Exception("Producto no encontrado.")
        End If
    End Sub
End Class
