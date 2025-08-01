Public Class fromVistaTablas

    Public Property tablaContenido As String = "clientes"
    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        AbrirFormPanel(frmEditorGeneral)
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AbrirFormPanel(frmEditorGeneral)
    End Sub
    Private Sub btnFiltradoCliente_Click(sender As Object, e As EventArgs) Handles btnFiltrado.Click
        Dim filtro As String = txtFiltro.Text
        Dim baseDato As New BD_Sql
        Dim consulta As String = $"SELECT * FROM {Me.tablaContenido} WHERE Nombre LIKE '%{filtro}%' OR Email LIKE '%{filtro}%'"
        Dim resultado As DataTable = baseDato.EjecutarConsulta(consulta)
        If resultado.Rows.Count > 0 Then
            dgvVistas.DataSource = resultado
        Else
            MessageBox.Show("No se encontraron resultados para el filtro especificado.")
        End If
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        mdlCambioContenido.AbrirFormPanel(formEliminar)
    End Sub

    Private Sub dgvVistas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVistas.CellContentClick

    End Sub
End Class