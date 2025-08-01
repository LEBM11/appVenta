Module mdlCambioContenido
    Public Sub AbrirFormPanel(ByRef FormHijo As Form)
        If Form1.panelContenido.Controls.Count > 0 Then
            Form1.panelContenido.Controls.RemoveAt(0)
        End If
        FormHijo.TopLevel = False
        FormHijo.FormBorderStyle = FormBorderStyle.None
        FormHijo.Dock = DockStyle.Fill
        Form1.panelContenido.Controls.Add(FormHijo)
        Form1.panelContenido.Tag = FormHijo
        FormHijo.Show()
    End Sub
End Module
