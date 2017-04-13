<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresos_de_Libros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresos_de_Libros))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblLibreriaSigloXXI = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid_libr = New System.Windows.Forms.TextBox()
        Me.txtnombre_libro = New System.Windows.Forms.TextBox()
        Me.txtañodeedicion = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtexistencia = New System.Windows.Forms.TextBox()
        Me.CmbID_Aut = New System.Windows.Forms.ComboBox()
        Me.Cmdgenero = New System.Windows.Forms.ComboBox()
        Me.CmdID_edi = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Ingresos de libros."
        '
        'LblLibreriaSigloXXI
        '
        Me.LblLibreriaSigloXXI.AutoSize = True
        Me.LblLibreriaSigloXXI.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLibreriaSigloXXI.Location = New System.Drawing.Point(137, 9)
        Me.LblLibreriaSigloXXI.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblLibreriaSigloXXI.Name = "LblLibreriaSigloXXI"
        Me.LblLibreriaSigloXXI.Size = New System.Drawing.Size(348, 58)
        Me.LblLibreriaSigloXXI.TabIndex = 50
        Me.LblLibreriaSigloXXI.Text = "Librería Siglo XXI"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 39)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "INSERTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "ID_LIBRO:"
        '
        'txtid_libr
        '
        Me.txtid_libr.Location = New System.Drawing.Point(165, 136)
        Me.txtid_libr.Name = "txtid_libr"
        Me.txtid_libr.Size = New System.Drawing.Size(121, 20)
        Me.txtid_libr.TabIndex = 54
        '
        'txtnombre_libro
        '
        Me.txtnombre_libro.Location = New System.Drawing.Point(165, 162)
        Me.txtnombre_libro.Name = "txtnombre_libro"
        Me.txtnombre_libro.Size = New System.Drawing.Size(121, 20)
        Me.txtnombre_libro.TabIndex = 55
        '
        'txtañodeedicion
        '
        Me.txtañodeedicion.Location = New System.Drawing.Point(165, 269)
        Me.txtañodeedicion.Name = "txtañodeedicion"
        Me.txtañodeedicion.Size = New System.Drawing.Size(121, 20)
        Me.txtañodeedicion.TabIndex = 56
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(165, 295)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(121, 20)
        Me.txtprecio.TabIndex = 57
        '
        'txtexistencia
        '
        Me.txtexistencia.Location = New System.Drawing.Point(165, 321)
        Me.txtexistencia.Name = "txtexistencia"
        Me.txtexistencia.Size = New System.Drawing.Size(121, 20)
        Me.txtexistencia.TabIndex = 58
        '
        'CmbID_Aut
        '
        Me.CmbID_Aut.FormattingEnabled = True
        Me.CmbID_Aut.Location = New System.Drawing.Point(165, 188)
        Me.CmbID_Aut.Name = "CmbID_Aut"
        Me.CmbID_Aut.Size = New System.Drawing.Size(121, 21)
        Me.CmbID_Aut.TabIndex = 59
        '
        'Cmdgenero
        '
        Me.Cmdgenero.FormattingEnabled = True
        Me.Cmdgenero.Location = New System.Drawing.Point(165, 215)
        Me.Cmdgenero.Name = "Cmdgenero"
        Me.Cmdgenero.Size = New System.Drawing.Size(121, 21)
        Me.Cmdgenero.TabIndex = 60
        '
        'CmdID_edi
        '
        Me.CmdID_edi.FormattingEnabled = True
        Me.CmdID_edi.Location = New System.Drawing.Point(165, 242)
        Me.CmdID_edi.Name = "CmdID_edi"
        Me.CmdID_edi.Size = New System.Drawing.Size(121, 21)
        Me.CmdID_edi.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 15)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "NOMBRE DEL LIBRO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "ID DE AUTOR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "ID GENERO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 15)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "ID EDITORIAL:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 15)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "AÑO DE EDICION:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 15)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "PRECIO UNITARIO:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 15)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "EXISTENCIAS:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(334, 139)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 189)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(383, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 56)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(138, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 39)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "MODIFICAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(255, 357)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 39)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(807, 93)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 34)
        Me.Button5.TabIndex = 75
        Me.Button5.Text = "VER"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(572, 142)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(554, 254)
        Me.DataGridView1.TabIndex = 76
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(90, 402)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(175, 35)
        Me.Button6.TabIndex = 77
        Me.Button6.Text = "NUEVO"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Ingresos_de_Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1138, 449)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdID_edi)
        Me.Controls.Add(Me.Cmdgenero)
        Me.Controls.Add(Me.CmbID_Aut)
        Me.Controls.Add(Me.txtexistencia)
        Me.Controls.Add(Me.txtprecio)
        Me.Controls.Add(Me.txtañodeedicion)
        Me.Controls.Add(Me.txtnombre_libro)
        Me.Controls.Add(Me.txtid_libr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblLibreriaSigloXXI)
        Me.Name = "Ingresos_de_Libros"
        Me.Text = "Ingresos_de_Libros"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblLibreriaSigloXXI As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid_libr As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre_libro As System.Windows.Forms.TextBox
    Friend WithEvents txtañodeedicion As System.Windows.Forms.TextBox
    Friend WithEvents txtprecio As System.Windows.Forms.TextBox
    Friend WithEvents txtexistencia As System.Windows.Forms.TextBox
    Friend WithEvents CmbID_Aut As System.Windows.Forms.ComboBox
    Friend WithEvents Cmdgenero As System.Windows.Forms.ComboBox
    Friend WithEvents CmdID_edi As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
