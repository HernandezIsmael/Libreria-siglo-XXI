<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresar))
        Me.LblLibreriaSigloXXI = New System.Windows.Forms.Label()
        Me.LblBienvenida = New System.Windows.Forms.Label()
        Me.PicbLogoDerecha = New System.Windows.Forms.PictureBox()
        Me.PicbLogoIzquierda = New System.Windows.Forms.PictureBox()
        Me.LblInstrucciones = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtusuario = New System.Windows.Forms.TextBox()
        Me.cmbtipo_usuario = New System.Windows.Forms.ComboBox()
        CType(Me.PicbLogoDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLibreriaSigloXXI
        '
        Me.LblLibreriaSigloXXI.AutoSize = True
        Me.LblLibreriaSigloXXI.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLibreriaSigloXXI.Location = New System.Drawing.Point(198, 156)
        Me.LblLibreriaSigloXXI.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblLibreriaSigloXXI.Name = "LblLibreriaSigloXXI"
        Me.LblLibreriaSigloXXI.Size = New System.Drawing.Size(348, 58)
        Me.LblLibreriaSigloXXI.TabIndex = 7
        Me.LblLibreriaSigloXXI.Text = "Librería Siglo XXI"
        '
        'LblBienvenida
        '
        Me.LblBienvenida.AutoSize = True
        Me.LblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBienvenida.Location = New System.Drawing.Point(240, 101)
        Me.LblBienvenida.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblBienvenida.Name = "LblBienvenida"
        Me.LblBienvenida.Size = New System.Drawing.Size(247, 40)
        Me.LblBienvenida.TabIndex = 6
        Me.LblBienvenida.Text = "BIENVENIDO"
        '
        'PicbLogoDerecha
        '
        Me.PicbLogoDerecha.Image = CType(resources.GetObject("PicbLogoDerecha.Image"), System.Drawing.Image)
        Me.PicbLogoDerecha.Location = New System.Drawing.Point(483, 13)
        Me.PicbLogoDerecha.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PicbLogoDerecha.Name = "PicbLogoDerecha"
        Me.PicbLogoDerecha.Size = New System.Drawing.Size(235, 139)
        Me.PicbLogoDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbLogoDerecha.TabIndex = 5
        Me.PicbLogoDerecha.TabStop = False
        '
        'PicbLogoIzquierda
        '
        Me.PicbLogoIzquierda.Image = CType(resources.GetObject("PicbLogoIzquierda.Image"), System.Drawing.Image)
        Me.PicbLogoIzquierda.Location = New System.Drawing.Point(1, 13)
        Me.PicbLogoIzquierda.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PicbLogoIzquierda.Name = "PicbLogoIzquierda"
        Me.PicbLogoIzquierda.Size = New System.Drawing.Size(234, 139)
        Me.PicbLogoIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbLogoIzquierda.TabIndex = 4
        Me.PicbLogoIzquierda.TabStop = False
        '
        'LblInstrucciones
        '
        Me.LblInstrucciones.AutoSize = True
        Me.LblInstrucciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInstrucciones.Location = New System.Drawing.Point(63, 225)
        Me.LblInstrucciones.Name = "LblInstrucciones"
        Me.LblInstrucciones.Size = New System.Drawing.Size(642, 20)
        Me.LblInstrucciones.TabIndex = 8
        Me.LblInstrucciones.Text = "Para iniciar sesión selecciona el tipo de usuario, escriba su nombre y su contras" & _
    "eña."
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(120, 295)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(115, 20)
        Me.LblNombre.TabIndex = 11
        Me.LblNombre.Text = "Tipo_usuario :"
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(120, 327)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(100, 20)
        Me.LblContraseña.TabIndex = 13
        Me.LblContraseña.Text = "Contraseña:"
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Location = New System.Drawing.Point(247, 329)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(121, 20)
        Me.TxtContraseña.TabIndex = 14
        Me.TxtContraseña.UseSystemPasswordChar = True
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(433, 299)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(85, 36)
        Me.BtnIngresar.TabIndex = 15
        Me.BtnIngresar.Text = "In&gresar."
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(563, 297)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(85, 36)
        Me.BtnSalir.TabIndex = 16
        Me.BtnSalir.Text = "&Salir."
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Usuario :"
        '
        'Txtusuario
        '
        Me.Txtusuario.Location = New System.Drawing.Point(247, 263)
        Me.Txtusuario.Name = "Txtusuario"
        Me.Txtusuario.Size = New System.Drawing.Size(121, 20)
        Me.Txtusuario.TabIndex = 19
        '
        'cmbtipo_usuario
        '
        Me.cmbtipo_usuario.FormattingEnabled = True
        Me.cmbtipo_usuario.Items.AddRange(New Object() {"Administrador", "Cajero" & Global.Microsoft.VisualBasic.ChrW(9), "Jefe"})
        Me.cmbtipo_usuario.Location = New System.Drawing.Point(247, 297)
        Me.cmbtipo_usuario.Name = "cmbtipo_usuario"
        Me.cmbtipo_usuario.Size = New System.Drawing.Size(121, 21)
        Me.cmbtipo_usuario.TabIndex = 20
        '
        'FrmIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(723, 392)
        Me.Controls.Add(Me.cmbtipo_usuario)
        Me.Controls.Add(Me.Txtusuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.LblContraseña)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblInstrucciones)
        Me.Controls.Add(Me.LblLibreriaSigloXXI)
        Me.Controls.Add(Me.LblBienvenida)
        Me.Controls.Add(Me.PicbLogoDerecha)
        Me.Controls.Add(Me.PicbLogoIzquierda)
        Me.Name = "FrmIngresar"
        Me.Text = "Biblioteca Siglo XXI--Iniciar Sesión"
        CType(Me.PicbLogoDerecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLibreriaSigloXXI As System.Windows.Forms.Label
    Friend WithEvents LblBienvenida As System.Windows.Forms.Label
    Friend WithEvents PicbLogoDerecha As System.Windows.Forms.PictureBox
    Friend WithEvents PicbLogoIzquierda As System.Windows.Forms.PictureBox
    Friend WithEvents LblInstrucciones As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblContraseña As System.Windows.Forms.Label
    Friend WithEvents TxtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents BtnIngresar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txtusuario As System.Windows.Forms.TextBox
    Friend WithEvents cmbtipo_usuario As System.Windows.Forms.ComboBox

End Class
