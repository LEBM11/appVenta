<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imgMenu = New System.Windows.Forms.PictureBox()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.panelSuperios = New System.Windows.Forms.Panel()
        Me.imgMenuSegundario = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSuperios.SuspendLayout()
        CType(Me.imgMenuSegundario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.panelMenu.Controls.Add(Me.btnItems)
        Me.panelMenu.Controls.Add(Me.btnVentas)
        Me.panelMenu.Controls.Add(Me.btnClientes)
        Me.panelMenu.Controls.Add(Me.Label1)
        Me.panelMenu.Controls.Add(Me.PictureBox1)
        Me.panelMenu.Controls.Add(Me.imgMenu)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 53)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(237, 456)
        Me.panelMenu.TabIndex = 1
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnItems.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.Image = Global.appVenta.My.Resources.Resources.productos
        Me.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItems.Location = New System.Drawing.Point(21, 352)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(194, 54)
        Me.btnItems.TabIndex = 4
        Me.btnItems.Text = "Items"
        Me.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.Image = Global.appVenta.My.Resources.Resources.venta
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.Location = New System.Drawing.Point(21, 263)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(194, 54)
        Me.btnVentas.TabIndex = 3
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnClientes.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.Image = Global.appVenta.My.Resources.Resources.clientes
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(21, 174)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(194, 54)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inicio"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.appVenta.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(21, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'imgMenu
        '
        Me.imgMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgMenu.Image = Global.appVenta.My.Resources.Resources.menu
        Me.imgMenu.Location = New System.Drawing.Point(180, 3)
        Me.imgMenu.Name = "imgMenu"
        Me.imgMenu.Size = New System.Drawing.Size(51, 53)
        Me.imgMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgMenu.TabIndex = 0
        Me.imgMenu.TabStop = False
        '
        'panelContenido
        '
        Me.panelContenido.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(237, 53)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(885, 456)
        Me.panelContenido.TabIndex = 2
        '
        'panelSuperios
        '
        Me.panelSuperios.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.panelSuperios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelSuperios.Controls.Add(Me.imgMenuSegundario)
        Me.panelSuperios.Controls.Add(Me.btnSalir)
        Me.panelSuperios.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSuperios.Location = New System.Drawing.Point(0, 0)
        Me.panelSuperios.Name = "panelSuperios"
        Me.panelSuperios.Size = New System.Drawing.Size(1122, 53)
        Me.panelSuperios.TabIndex = 0
        '
        'imgMenuSegundario
        '
        Me.imgMenuSegundario.BackColor = System.Drawing.Color.White
        Me.imgMenuSegundario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgMenuSegundario.Image = Global.appVenta.My.Resources.Resources.menu
        Me.imgMenuSegundario.Location = New System.Drawing.Point(10, 3)
        Me.imgMenuSegundario.Name = "imgMenuSegundario"
        Me.imgMenuSegundario.Size = New System.Drawing.Size(47, 43)
        Me.imgMenuSegundario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgMenuSegundario.TabIndex = 1
        Me.imgMenuSegundario.TabStop = False
        Me.imgMenuSegundario.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(1059, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(59, 49)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "X"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1122, 509)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelSuperios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Examen"
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSuperios.ResumeLayout(False)
        CType(Me.imgMenuSegundario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelContenido As Panel
    Friend WithEvents imgMenu As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnItems As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents panelSuperios As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents imgMenuSegundario As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
