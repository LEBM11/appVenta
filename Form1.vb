Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub imgMenu_Click(sender As Object, e As EventArgs) Handles imgMenu.Click
        Timer2.Interval = 1
        Timer2.Start()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If panelMenu.Width > 0 Then
            panelMenu.Width -= 2
        Else
            Timer2.Stop()
            imgMenu.Visible = Not imgMenu.Visible
            imgMenuSegundario.Visible = Not imgMenuSegundario.Visible
        End If
    End Sub
    Private Sub imgMenuSegundario_Click(sender As Object, e As EventArgs) Handles imgMenuSegundario.Click
        Timer1.Interval = 1
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If panelMenu.Width < 200 Then
            panelMenu.Width += 1
        Else
            Timer1.Stop()
            imgMenuSegundario.Visible = Not imgMenuSegundario.Visible
            imgMenu.Visible = Not imgMenu.Visible
        End If
    End Sub

    Private Sub ClearTabla(ByVal nombreTabla As String, Optional i As Integer = 0)
        fromVistaTablas.dgvVistas.DataSource = Nothing
        Dim baseDato As New BD_Sql
        If i = 200 Then
            baseDato.EjecutarConsulta($"Select * From {nombreTabla}")
        Else
            Dim consulta As String = "SELECT v.ID AS IDVenta, c.Nombre AS NombreCliente, p.Nombre AS NombreProducto, vi.Cantidad, vi.PrecioUnitario, vi.PrecioTotal FROM ventas vINNER JOIN clientes c ON v.IDCliente = c.ID INNER JOIN ventasitems vi ON v.ID = vi.IDVenta INNER JOIN productos p ON vi.IDProducto = p.ID ORDER BY v.ID "
            baseDato.EjecutarConsulta(consulta)

        End If

    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirFormPanel(fromVistaTablas)
        ClearTabla("clientes")
        fromVistaTablas.tablaContenido = "clientes"
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        AbrirFormPanel(fromVistaTablas)
        ClearTabla("ventas", 200)
        fromVistaTablas.tablaContenido = "ventas"
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        AbrirFormPanel(fromVistaTablas)
        ClearTabla("productos")
        fromVistaTablas.tablaContenido = "productos"
    End Sub

End Class