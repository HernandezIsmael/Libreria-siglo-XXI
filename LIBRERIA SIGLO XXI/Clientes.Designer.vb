<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.LblLibreriaSigloXXI = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.CmbID_puesto = New System.Windows.Forms.ComboBox()
        Me.CmbID_comunidd = New System.Windows.Forms.ComboBox()
        Me.CmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.CmbID_Estad = New System.Windows.Forms.ComboBox()
        Me.CmbID_pais = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PicbLogoIzquierda = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblLibreriaSigloXXI
        '
        Me.LblLibreriaSigloXXI.AutoSize = True
        Me.LblLibreriaSigloXXI.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLibreriaSigloXXI.Location = New System.Drawing.Point(224, 13)
        Me.LblLibreriaSigloXXI.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblLibreriaSigloXXI.Name = "LblLibreriaSigloXXI"
        Me.LblLibreriaSigloXXI.Size = New System.Drawing.Size(339, 57)
        Me.LblLibreriaSigloXXI.TabIndex = 14
        Me.LblLibreriaSigloXXI.Text = "Librería Siglo XXI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(399, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Clientes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID USUARIOS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "NOMBRE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "APE PATERNO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "APE MATERNO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "SEXO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "FECHA DE NACIMIENTO:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "ID PUESTO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "ID COMUNIDAD:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "ID MUNICIPIO:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "ID ESTADO:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "ID PAIS:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(181, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(181, 47)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 32
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(181, 73)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(121, 20)
        Me.TextBox3.TabIndex = 33
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(181, 99)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(121, 20)
        Me.TextBox4.TabIndex = 34
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(181, 125)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(121, 20)
        Me.TextBox5.TabIndex = 35
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(181, 151)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(121, 20)
        Me.TextBox6.TabIndex = 36
        '
        'CmbID_puesto
        '
        Me.CmbID_puesto.FormattingEnabled = True
        Me.CmbID_puesto.Location = New System.Drawing.Point(181, 177)
        Me.CmbID_puesto.Name = "CmbID_puesto"
        Me.CmbID_puesto.Size = New System.Drawing.Size(121, 21)
        Me.CmbID_puesto.TabIndex = 37
        '
        'CmbID_comunidd
        '
        Me.CmbID_comunidd.FormattingEnabled = True
        Me.CmbID_comunidd.Location = New System.Drawing.Point(181, 204)
        Me.CmbID_comunidd.Name = "CmbID_comunidd"
        Me.CmbID_comunidd.Size = New System.Drawing.Size(121, 21)
        Me.CmbID_comunidd.TabIndex = 38
        '
        'CmbMunicipio
        '
        Me.CmbMunicipio.FormattingEnabled = True
        Me.CmbMunicipio.Location = New System.Drawing.Point(181, 231)
        Me.CmbMunicipio.Name = "CmbMunicipio"
        Me.CmbMunicipio.Size = New System.Drawing.Size(121, 21)
        Me.CmbMunicipio.TabIndex = 39
        '
        'CmbID_Estad
        '
        Me.CmbID_Estad.FormattingEnabled = True
        Me.CmbID_Estad.Location = New System.Drawing.Point(181, 258)
        Me.CmbID_Estad.Name = "CmbID_Estad"
        Me.CmbID_Estad.Size = New System.Drawing.Size(121, 21)
        Me.CmbID_Estad.TabIndex = 40
        '
        'CmbID_pais
        '
        Me.CmbID_pais.FormattingEnabled = True
        Me.CmbID_pais.Location = New System.Drawing.Point(181, 285)
        Me.CmbID_pais.Name = "CmbID_pais"
        Me.CmbID_pais.Size = New System.Drawing.Size(121, 21)
        Me.CmbID_pais.TabIndex = 41
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 43)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "REGISTRAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(610, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 39)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "SALIR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PicbLogoIzquierda
        '
        Me.PicbLogoIzquierda.Image = CType(resources.GetObject("PicbLogoIzquierda.Image"), System.Drawing.Image)
        Me.PicbLogoIzquierda.Location = New System.Drawing.Point(15, 13)
        Me.PicbLogoIzquierda.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PicbLogoIzquierda.Name = "PicbLogoIzquierda"
        Me.PicbLogoIzquierda.Size = New System.Drawing.Size(202, 85)
        Me.PicbLogoIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbLogoIzquierda.TabIndex = 12
        Me.PicbLogoIzquierda.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(331, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 51)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "MODIFICAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(331, 166)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(123, 54)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "ELIMINAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CmbID_pais)
        Me.GroupBox1.Controls.Add(Me.CmbID_Estad)
        Me.GroupBox1.Controls.Add(Me.CmbMunicipio)
        Me.GroupBox1.Controls.Add(Me.CmbID_comunidd)
        Me.GroupBox1.Controls.Add(Me.CmbID_puesto)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(109, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 348)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuarios"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(331, 243)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 48)
        Me.Button6.TabIndex = 48
        Me.Button6.Text = "NUEVO"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(301, 11)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 30)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "VER"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(616, 293)
        Me.DataGridView1.TabIndex = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Location = New System.Drawing.Point(611, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(647, 359)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tabla_usuarios"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(316, 467)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(213, 23)
        Me.Button7.TabIndex = 52
        Me.Button7.Text = "agregar un lugar de origen"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1306, 511)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblLibreriaSigloXXI)
        Me.Controls.Add(Me.PicbLogoIzquierda)
        Me.Name = "FrmClientes"
        Me.Text = "Clientes"
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLibreriaSigloXXI As System.Windows.Forms.Label
    Friend WithEvents PicbLogoIzquierda As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents CmbID_puesto As System.Windows.Forms.ComboBox
    Friend WithEvents CmbID_comunidd As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMunicipio As System.Windows.Forms.ComboBox
    Friend WithEvents CmbID_Estad As System.Windows.Forms.ComboBox
    Friend WithEvents CmbID_pais As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
End Class
