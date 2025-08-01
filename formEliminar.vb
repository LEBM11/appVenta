Public Class formEliminar
    Private Sub formElimnar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoObjeto.Items.AddRange({"Items", "Cliente", "Ventas", "VentaDT"})
        cmbTipoObjeto.SelectedIndex = 0
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim tipoSeleccionado = cmbTipoObjeto.SelectedItem.ToString()
        Dim objetoActual As Object
        Dim id As Integer

        If Not Integer.TryParse(txtID.Text, id) Then
            MessageBox.Show("Ingrese un ID válido.")
            Return
        End If

        ' Crear el objeto correspondiente
        Select Case tipoSeleccionado
            Case "Items"
                objetoActual = New Items()
            Case "Cliente"
                objetoActual = New Cliente()
            Case "Ventas"
                objetoActual = New Ventas()
            Case "VentaDT"
                objetoActual = New VentaDT()
        End Select

        ' Cargar el objeto por ID
        Try
            objetoActual.CargarPorId(id)
            If objetoActual Is Nothing Then
                MessageBox.Show("No se encontró el objeto con el ID especificado.")
                Return
            Else
                objetoActual.Eliminar(id)
                MessageBox.Show("Objeto eliminado correctamente.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class