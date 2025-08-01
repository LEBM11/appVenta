Imports Microsoft.Identity.Client.TelemetryCore.Internal

Public Class frmEditorGeneral
    Private objetoActual As Object
    Private camposTextBox As New Dictionary(Of String, TextBox)

    Private Sub frmEditorGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTipoObjeto.Items.AddRange({"Items", "Cliente", "Ventas", "VentaDT"})
        cmbTipoObjeto.SelectedIndex = 0
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        pnlCampos.Controls.Clear()
        camposTextBox.Clear()

        Dim tipoSeleccionado = cmbTipoObjeto.SelectedItem.ToString()
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
        If id > 0 Then
        objetoActual.CargarPorId(id)
        End If

        If objetoActual Is Nothing Then
            MessageBox.Show("No se encontró el objeto con el ID especificado.")
            Return
        End If

        ' Mostrar propiedades (menos el ID) en el panel
        Dim props = objetoActual.GetType().GetProperties().Where(Function(p) p.Name <> "Id")
        Dim yPos As Integer = 10

        For Each prop In props
            Dim lbl As New Label With {
                .Text = prop.Name,
                .Top = yPos,
                .Left = 10,
                .Width = 100
            }
            Dim txt As New TextBox With {
                .Top = yPos,
                .Left = 120,
                .Width = 200,
                .Text = prop.GetValue(objetoActual)?.ToString()
            }
            pnlCampos.Controls.Add(lbl)
            pnlCampos.Controls.Add(txt)
            camposTextBox.Add(prop.Name, txt)

            yPos += 30
        Next
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim metod As String = "Modificar"
        If objetoActual Is Nothing Then
            MessageBox.Show("Primero busque un objeto.")
            Return
        ElseIf objetoActual.id <= 0 Then
            metod = "Guardar"
        End If

        ' Usar reflexión para actualizar propiedades
        For Each kvp In camposTextBox
            Dim prop = objetoActual.GetType().GetProperty(kvp.Key)
            If prop IsNot Nothing AndAlso prop.CanWrite Then
                Dim valorTexto = kvp.Value.Text
                Dim tipoProp = prop.PropertyType

                ' Conversión de tipo segura
                Dim valorConvertido As Object = Convert.ChangeType(valorTexto, tipoProp)
                prop.SetValue(objetoActual, valorConvertido)
            End If
        Next

        ' Llamar al método de actualización
        Dim metodo = objetoActual.GetType().GetMethod($"{metod}")
        If metodo IsNot Nothing Then
            metodo.Invoke(objetoActual, Nothing)
            MessageBox.Show("Datos actualizados correctamente.")
        Else
            MessageBox.Show("No se encontró el método de actualización.")
        End If
    End Sub

    Private Sub pnlCampos_Paint(sender As Object, e As PaintEventArgs) Handles pnlCampos.Paint

    End Sub
End Class
