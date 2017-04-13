<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsulta_entradas_a_almacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsulta_entradas_a_almacen))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblLibreriaSigloXXI = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PicbLogoDerecha = New System.Windows.Forms.PictureBox()
        Me.PicbLogoIzquierda = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbLogoDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(276, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Consulta de Ventas"
        '
        'LblLibreriaSigloXXI
        '
        Me.LblLibreriaSigloXXI.AutoSize = True
        Me.LblLibreriaSigloXXI.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLibreriaSigloXXI.Location = New System.Drawing.Point(327, 13)
        Me.LblLibreriaSigloXXI.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblLibreriaSigloXXI.Name = "LblLibreriaSigloXXI"
        Me.LblLibreriaSigloXXI.Size = New System.Drawing.Size(348, 58)
        Me.LblLibreriaSigloXXI.TabIndex = 39
        Me.LblLibreriaSigloXXI.Text = "Librería Siglo XXI"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(56, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 28)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Visualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 158)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1019, 293)
        Me.DataGridView1.TabIndex = 82
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(847, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 28)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(949, 457)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 28)
        Me.Button3.TabIndex = 84
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PicbLogoDerecha
        '
        Me.PicbLogoDerecha.Image = CType(resources.GetObject("PicbLogoDerecha.Image"), System.Drawing.Image)
        Me.PicbLogoDerecha.Location = New System.Drawing.Point(722, 13)
        Me.PicbLogoDerecha.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PicbLogoDerecha.Name = "PicbLogoDerecha"
        Me.PicbLogoDerecha.Size = New System.Drawing.Size(320, 138)
        Me.PicbLogoDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbLogoDerecha.TabIndex = 38
        Me.PicbLogoDerecha.TabStop = False
        '
        'PicbLogoIzquierda
        '
        Me.PicbLogoIzquierda.Image = CType(resources.GetObject("PicbLogoIzquierda.Image"), System.Drawing.Image)
        Me.PicbLogoIzquierda.Location = New System.Drawing.Point(15, 13)
        Me.PicbLogoIzquierda.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PicbLogoIzquierda.Name = "PicbLogoIzquierda"
        Me.PicbLogoIzquierda.Size = New System.Drawing.Size(233, 104)
        Me.PicbLogoIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbLogoIzquierda.TabIndex = 37
        Me.PicbLogoIzquierda.TabStop = False
        '
        'FrmConsulta_entradas_a_almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1057, 497)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblLibreriaSigloXXI)
        Me.Controls.Add(Me.PicbLogoDerecha)
        Me.Controls.Add(Me.PicbLogoIzquierda)
        Me.Name = "FrmConsulta_entradas_a_almacen"
        Me.Text = "Consulta_entradas_a_almacen"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbLogoDerecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblLibreriaSigloXXI As System.Windows.Forms.Label
    Friend WithEvents PicbLogoDerecha As System.Windows.Forms.PictureBox
    Friend WithEvents PicbLogoIzquierda As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
