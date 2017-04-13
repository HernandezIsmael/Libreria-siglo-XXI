<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.LblLibreriaSigloXXI = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CATÁLOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AutoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarEditorialesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresosDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresaLugarOrigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarPaisesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoPuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOVIMIENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevoluciónDeClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CcmprarLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeInventariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEntradasLibrosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConsultarEstadoDeCuentaDelClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarteleraDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AYUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANUALDEUSARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESPALDOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACERCADEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACERCADEToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblFechaHoy = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PicbLogoDerecha = New System.Windows.Forms.PictureBox()
        Me.PicbLogoIzquierda = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbLogoDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLibreriaSigloXXI
        '
        Me.LblLibreriaSigloXXI.AutoSize = True
        Me.LblLibreriaSigloXXI.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLibreriaSigloXXI.Location = New System.Drawing.Point(284, 38)
        Me.LblLibreriaSigloXXI.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblLibreriaSigloXXI.Name = "LblLibreriaSigloXXI"
        Me.LblLibreriaSigloXXI.Size = New System.Drawing.Size(348, 58)
        Me.LblLibreriaSigloXXI.TabIndex = 11
        Me.LblLibreriaSigloXXI.Text = "Librería Siglo XXI"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CATÁLOGOSToolStripMenuItem, Me.MOVIMIENTOSToolStripMenuItem, Me.CONSULTASToolStripMenuItem, Me.AYUDAToolStripMenuItem, Me.RESPALDOToolStripMenuItem, Me.ACERCADEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1041, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CATÁLOGOSToolStripMenuItem
        '
        Me.CATÁLOGOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.AutoresToolStripMenuItem, Me.IngresarEditorialesToolStripMenuItem, Me.IngresosDeLibrosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.IngresarClientesToolStripMenuItem1, Me.IngresaLugarOrigenToolStripMenuItem, Me.IngresarPaisesToolStripMenuItem, Me.IngresoPuestosToolStripMenuItem})
        Me.CATÁLOGOSToolStripMenuItem.Name = "CATÁLOGOSToolStripMenuItem"
        Me.CATÁLOGOSToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CATÁLOGOSToolStripMenuItem.Text = "CATÁLOGOS"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(181, 6)
        '
        'AutoresToolStripMenuItem
        '
        Me.AutoresToolStripMenuItem.Name = "AutoresToolStripMenuItem"
        Me.AutoresToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AutoresToolStripMenuItem.Text = "Autores"
        '
        'IngresarEditorialesToolStripMenuItem
        '
        Me.IngresarEditorialesToolStripMenuItem.Name = "IngresarEditorialesToolStripMenuItem"
        Me.IngresarEditorialesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.IngresarEditorialesToolStripMenuItem.Text = "Ingresar Editoriales"
        '
        'IngresosDeLibrosToolStripMenuItem
        '
        Me.IngresosDeLibrosToolStripMenuItem.Name = "IngresosDeLibrosToolStripMenuItem"
        Me.IngresosDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.IngresosDeLibrosToolStripMenuItem.Text = "Ingresos de Libros"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'IngresarClientesToolStripMenuItem1
        '
        Me.IngresarClientesToolStripMenuItem1.Name = "IngresarClientesToolStripMenuItem1"
        Me.IngresarClientesToolStripMenuItem1.Size = New System.Drawing.Size(184, 22)
        Me.IngresarClientesToolStripMenuItem1.Text = "Ingresar clientes"
        '
        'IngresaLugarOrigenToolStripMenuItem
        '
        Me.IngresaLugarOrigenToolStripMenuItem.Name = "IngresaLugarOrigenToolStripMenuItem"
        Me.IngresaLugarOrigenToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.IngresaLugarOrigenToolStripMenuItem.Text = "Ingresa Lugar Origen"
        '
        'IngresarPaisesToolStripMenuItem
        '
        Me.IngresarPaisesToolStripMenuItem.Name = "IngresarPaisesToolStripMenuItem"
        Me.IngresarPaisesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.IngresarPaisesToolStripMenuItem.Text = "Ingresar paises"
        '
        'IngresoPuestosToolStripMenuItem
        '
        Me.IngresoPuestosToolStripMenuItem.Name = "IngresoPuestosToolStripMenuItem"
        Me.IngresoPuestosToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.IngresoPuestosToolStripMenuItem.Text = "Ingreso puestos"
        '
        'MOVIMIENTOSToolStripMenuItem
        '
        Me.MOVIMIENTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DevoluciónDeClienteToolStripMenuItem, Me.CcmprarLibrosToolStripMenuItem, Me.VentaDeLibrosToolStripMenuItem})
        Me.MOVIMIENTOSToolStripMenuItem.Name = "MOVIMIENTOSToolStripMenuItem"
        Me.MOVIMIENTOSToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.MOVIMIENTOSToolStripMenuItem.Text = "MOVIMIENTOS"
        '
        'DevoluciónDeClienteToolStripMenuItem
        '
        Me.DevoluciónDeClienteToolStripMenuItem.Name = "DevoluciónDeClienteToolStripMenuItem"
        Me.DevoluciónDeClienteToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DevoluciónDeClienteToolStripMenuItem.Text = "Devolución de Libro"
        '
        'CcmprarLibrosToolStripMenuItem
        '
        Me.CcmprarLibrosToolStripMenuItem.Name = "CcmprarLibrosToolStripMenuItem"
        Me.CcmprarLibrosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CcmprarLibrosToolStripMenuItem.Text = "Comprar libros"
        '
        'VentaDeLibrosToolStripMenuItem
        '
        Me.VentaDeLibrosToolStripMenuItem.Name = "VentaDeLibrosToolStripMenuItem"
        Me.VentaDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.VentaDeLibrosToolStripMenuItem.Text = "Venta de Libros"
        '
        'CONSULTASToolStripMenuItem
        '
        Me.CONSULTASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaDeInventariosToolStripMenuItem1, Me.ConsultarEntradasLibrosToolStripMenuItem1, Me.ToolStripSeparator5, Me.ConsultarEstadoDeCuentaDelClienteToolStripMenuItem, Me.CarteleraDeClientesToolStripMenuItem})
        Me.CONSULTASToolStripMenuItem.Name = "CONSULTASToolStripMenuItem"
        Me.CONSULTASToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CONSULTASToolStripMenuItem.Text = "CONSULTAS"
        '
        'ConsultaDeInventariosToolStripMenuItem1
        '
        Me.ConsultaDeInventariosToolStripMenuItem1.Name = "ConsultaDeInventariosToolStripMenuItem1"
        Me.ConsultaDeInventariosToolStripMenuItem1.Size = New System.Drawing.Size(251, 22)
        Me.ConsultaDeInventariosToolStripMenuItem1.Text = "Consulta de Inventarios de Llibros"
        '
        'ConsultarEntradasLibrosToolStripMenuItem1
        '
        Me.ConsultarEntradasLibrosToolStripMenuItem1.Name = "ConsultarEntradasLibrosToolStripMenuItem1"
        Me.ConsultarEntradasLibrosToolStripMenuItem1.Size = New System.Drawing.Size(251, 22)
        Me.ConsultarEntradasLibrosToolStripMenuItem1.Text = "Consultar Ventas"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(248, 6)
        '
        'ConsultarEstadoDeCuentaDelClienteToolStripMenuItem
        '
        Me.ConsultarEstadoDeCuentaDelClienteToolStripMenuItem.Name = "ConsultarEstadoDeCuentaDelClienteToolStripMenuItem"
        Me.ConsultarEstadoDeCuentaDelClienteToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.ConsultarEstadoDeCuentaDelClienteToolStripMenuItem.Text = "Consulta Clientes"
        '
        'CarteleraDeClientesToolStripMenuItem
        '
        Me.CarteleraDeClientesToolStripMenuItem.Name = "CarteleraDeClientesToolStripMenuItem"
        Me.CarteleraDeClientesToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.CarteleraDeClientesToolStripMenuItem.Text = "Cartelera de Clientes"
        '
        'AYUDAToolStripMenuItem
        '
        Me.AYUDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANUALDEUSARIOToolStripMenuItem})
        Me.AYUDAToolStripMenuItem.Name = "AYUDAToolStripMenuItem"
        Me.AYUDAToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AYUDAToolStripMenuItem.Text = "AYUDA"
        '
        'MANUALDEUSARIOToolStripMenuItem
        '
        Me.MANUALDEUSARIOToolStripMenuItem.Name = "MANUALDEUSARIOToolStripMenuItem"
        Me.MANUALDEUSARIOToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.MANUALDEUSARIOToolStripMenuItem.Text = "MANUAL DE USARIO"
        '
        'RESPALDOToolStripMenuItem
        '
        Me.RESPALDOToolStripMenuItem.Name = "RESPALDOToolStripMenuItem"
        Me.RESPALDOToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.RESPALDOToolStripMenuItem.Text = "RESPALDO "
        '
        'ACERCADEToolStripMenuItem
        '
        Me.ACERCADEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ACERCADEToolStripMenuItem1})
        Me.ACERCADEToolStripMenuItem.Name = "ACERCADEToolStripMenuItem"
        Me.ACERCADEToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ACERCADEToolStripMenuItem.Text = "ACERCA DE"
        '
        'ACERCADEToolStripMenuItem1
        '
        Me.ACERCADEToolStripMenuItem1.Name = "ACERCADEToolStripMenuItem1"
        Me.ACERCADEToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.ACERCADEToolStripMenuItem1.Text = "ACERCA DE"
        '
        'LblFechaHoy
        '
        Me.LblFechaHoy.AutoSize = True
        Me.LblFechaHoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFechaHoy.Location = New System.Drawing.Point(538, 436)
        Me.LblFechaHoy.Name = "LblFechaHoy"
        Me.LblFechaHoy.Size = New System.Drawing.Size(55, 20)
        Me.LblFechaHoy.TabIndex = 14
        Me.LblFechaHoy.Text = "Fecha"
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(954, 434)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 32)
        Me.BtnSalir.TabIndex = 15
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LIBRERIA_SIGLO_XXI.My.Resources.Resources._1549350_637026819710941_344422953_n
        Me.PictureBox1.Location = New System.Drawing.Point(74, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(904, 329)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'PicbLogoDerecha
        '
        Me.PicbLogoDerecha.Image = CType(resources.GetObject("PicbLogoDerecha.Image"), System.Drawing.Image)
        Me.PicbLogoDerecha.Location = New System.Drawing.Point(879, 28)
        Me.PicbLogoDerecha.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PicbLogoDerecha.Name = "PicbLogoDerecha"
        Me.PicbLogoDerecha.Size = New System.Drawing.Size(147, 67)
        Me.PicbLogoDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbLogoDerecha.TabIndex = 9
        Me.PicbLogoDerecha.TabStop = False
        '
        'PicbLogoIzquierda
        '
        Me.PicbLogoIzquierda.Image = CType(resources.GetObject("PicbLogoIzquierda.Image"), System.Drawing.Image)
        Me.PicbLogoIzquierda.Location = New System.Drawing.Point(15, 28)
        Me.PicbLogoIzquierda.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PicbLogoIzquierda.Name = "PicbLogoIzquierda"
        Me.PicbLogoIzquierda.Size = New System.Drawing.Size(137, 67)
        Me.PicbLogoIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbLogoIzquierda.TabIndex = 8
        Me.PicbLogoIzquierda.TabStop = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1041, 478)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblFechaHoy)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblLibreriaSigloXXI)
        Me.Controls.Add(Me.PicbLogoDerecha)
        Me.Controls.Add(Me.PicbLogoIzquierda)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "Biblioteca_Siglo_XXI__Sistema_de_Ventas_e_Inventario"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbLogoDerecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLibreriaSigloXXI As System.Windows.Forms.Label
    Friend WithEvents PicbLogoDerecha As System.Windows.Forms.PictureBox
    Friend WithEvents PicbLogoIzquierda As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CATÁLOGOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MOVIMIENTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONSULTASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RESPALDOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AYUDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACERCADEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LblFechaHoy As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AutoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents MANUALDEUSARIOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACERCADEToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaDeInventariosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarEntradasLibrosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DevoluciónDeClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarEstadoDeCuentaDelClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarEditorialesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresosDeLibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarteleraDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CcmprarLibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentaDeLibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresaLugarOrigenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarPaisesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoPuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
