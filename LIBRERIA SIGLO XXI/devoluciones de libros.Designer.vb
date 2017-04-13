<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devoluciones_de_libros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Txtautor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtnombre_libr = New System.Windows.Forms.TextBox()
        Me.Txtpreciounitrio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txtnum_cance = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cmbuduario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txteditorial = New System.Windows.Forms.TextBox()
        Me.txtid_gener = New System.Windows.Forms.TextBox()
        Me.txid_tlibro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txventa = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtañoedi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtfech_vent = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtid_cancela = New System.Windows.Forms.TextBox()
        Me.Cmtipo_cancela = New System.Windows.Forms.ComboBox()
        Me.Txttotal_compra = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.10309!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(481, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "==CANCELAR LIBROS VENDIDOS=="
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(358, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(515, 219)
        Me.DataGridView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.649485!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(345, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(234, 31)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CANCELAR VENTA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(57, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "AUTOR :"
        '
        'Txtautor
        '
        Me.Txtautor.Location = New System.Drawing.Point(147, 160)
        Me.Txtautor.Name = "Txtautor"
        Me.Txtautor.Size = New System.Drawing.Size(144, 20)
        Me.Txtautor.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(45, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "NOMBRE_LIBRO :"
        '
        'txtnombre_libr
        '
        Me.txtnombre_libr.Location = New System.Drawing.Point(154, 129)
        Me.txtnombre_libr.Name = "txtnombre_libr"
        Me.txtnombre_libr.Size = New System.Drawing.Size(144, 20)
        Me.txtnombre_libr.TabIndex = 74
        '
        'Txtpreciounitrio
        '
        Me.Txtpreciounitrio.Location = New System.Drawing.Point(176, 349)
        Me.Txtpreciounitrio.Name = "Txtpreciounitrio"
        Me.Txtpreciounitrio.Size = New System.Drawing.Size(113, 20)
        Me.Txtpreciounitrio.TabIndex = 73
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(39, 352)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "PRECIO UNITARIO :"
        '
        'Txtnum_cance
        '
        Me.Txtnum_cance.Location = New System.Drawing.Point(174, 380)
        Me.Txtnum_cance.Name = "Txtnum_cance"
        Me.Txtnum_cance.Size = New System.Drawing.Size(113, 20)
        Me.Txtnum_cance.TabIndex = 71
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 383)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "NUM_CANCELACIONES :"
        '
        'Cmbuduario
        '
        Me.Cmbuduario.FormattingEnabled = True
        Me.Cmbuduario.Location = New System.Drawing.Point(152, 321)
        Me.Cmbuduario.Name = "Cmbuduario"
        Me.Cmbuduario.Size = New System.Drawing.Size(144, 21)
        Me.Cmbuduario.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "CAJERO :"
        '
        'txteditorial
        '
        Me.txteditorial.Location = New System.Drawing.Point(154, 230)
        Me.txteditorial.Name = "txteditorial"
        Me.txteditorial.Size = New System.Drawing.Size(144, 20)
        Me.txteditorial.TabIndex = 67
        '
        'txtid_gener
        '
        Me.txtid_gener.Location = New System.Drawing.Point(154, 193)
        Me.txtid_gener.Name = "txtid_gener"
        Me.txtid_gener.Size = New System.Drawing.Size(144, 20)
        Me.txtid_gener.TabIndex = 66
        '
        'txid_tlibro
        '
        Me.txid_tlibro.Location = New System.Drawing.Point(145, 101)
        Me.txid_tlibro.Name = "txid_tlibro"
        Me.txid_tlibro.Size = New System.Drawing.Size(144, 20)
        Me.txid_tlibro.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "EDITORIAL :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "GENERO :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "ID_LIBRO :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "ID DE VENTA :"
        '
        'txventa
        '
        Me.txventa.Location = New System.Drawing.Point(145, 75)
        Me.txventa.Name = "txventa"
        Me.txventa.Size = New System.Drawing.Size(144, 20)
        Me.txventa.TabIndex = 60
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 9.649485!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(503, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 31)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "ACTUALIZAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtañoedi
        '
        Me.txtañoedi.Location = New System.Drawing.Point(152, 259)
        Me.txtañoedi.Name = "txtañoedi"
        Me.txtañoedi.Size = New System.Drawing.Size(144, 20)
        Me.txtañoedi.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "AÑO_DE_EDICION :"
        '
        'Txtfech_vent
        '
        Me.Txtfech_vent.Location = New System.Drawing.Point(152, 291)
        Me.Txtfech_vent.Name = "Txtfech_vent"
        Me.Txtfech_vent.Size = New System.Drawing.Size(144, 20)
        Me.Txtfech_vent.TabIndex = 82
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "FECHA VENTA :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "TIPO_CANCELACION :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "ID_CANCELACION :"
        '
        'txtid_cancela
        '
        Me.txtid_cancela.Location = New System.Drawing.Point(145, 23)
        Me.txtid_cancela.Name = "txtid_cancela"
        Me.txtid_cancela.Size = New System.Drawing.Size(144, 20)
        Me.txtid_cancela.TabIndex = 83
        '
        'Cmtipo_cancela
        '
        Me.Cmtipo_cancela.FormattingEnabled = True
        Me.Cmtipo_cancela.Items.AddRange(New Object() {"defectuso", "no le gusto"})
        Me.Cmtipo_cancela.Location = New System.Drawing.Point(145, 48)
        Me.Cmtipo_cancela.Name = "Cmtipo_cancela"
        Me.Cmtipo_cancela.Size = New System.Drawing.Size(144, 21)
        Me.Cmtipo_cancela.TabIndex = 86
        '
        'Txttotal_compra
        '
        Me.Txttotal_compra.Location = New System.Drawing.Point(174, 408)
        Me.Txttotal_compra.Name = "Txttotal_compra"
        Me.Txttotal_compra.Size = New System.Drawing.Size(113, 20)
        Me.Txttotal_compra.TabIndex = 88
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(39, 411)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 13)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "TOTAL_COMPRA :"
        '
        'devoluciones_de_libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(904, 435)
        Me.Controls.Add(Me.Txttotal_compra)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Cmtipo_cancela)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtid_cancela)
        Me.Controls.Add(Me.Txtfech_vent)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtañoedi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Txtautor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtnombre_libr)
        Me.Controls.Add(Me.Txtpreciounitrio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txtnum_cance)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Cmbuduario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txteditorial)
        Me.Controls.Add(Me.txtid_gener)
        Me.Controls.Add(Me.txid_tlibro)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txventa)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "devoluciones_de_libros"
        Me.Text = "devoluciones_de_libros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Txtautor As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtnombre_libr As System.Windows.Forms.TextBox
    Friend WithEvents Txtpreciounitrio As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txtnum_cance As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Cmbuduario As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txteditorial As System.Windows.Forms.TextBox
    Friend WithEvents txtid_gener As System.Windows.Forms.TextBox
    Friend WithEvents txid_tlibro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txventa As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtañoedi As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtfech_vent As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtid_cancela As System.Windows.Forms.TextBox
    Friend WithEvents Cmtipo_cancela As System.Windows.Forms.ComboBox
    Friend WithEvents Txttotal_compra As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
