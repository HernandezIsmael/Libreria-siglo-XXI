<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCartera_de_clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCartera_de_clientes))
        Me.LblLibreriaSigloXXI = New System.Windows.Forms.Label()
        Me.PicbLogoDerecha = New System.Windows.Forms.PictureBox()
        Me.PicbLogoIzquierda = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PicbLogoDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLibreriaSigloXXI
        '
        Me.LblLibreriaSigloXXI.AutoSize = True
        Me.LblLibreriaSigloXXI.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLibreriaSigloXXI.Location = New System.Drawing.Point(187, 13)
        Me.LblLibreriaSigloXXI.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblLibreriaSigloXXI.Name = "LblLibreriaSigloXXI"
        Me.LblLibreriaSigloXXI.Size = New System.Drawing.Size(348, 58)
        Me.LblLibreriaSigloXXI.TabIndex = 14
        Me.LblLibreriaSigloXXI.Text = "Librería Siglo XXI"
        '
        'PicbLogoDerecha
        '
        Me.PicbLogoDerecha.Image = CType(resources.GetObject("PicbLogoDerecha.Image"), System.Drawing.Image)
        Me.PicbLogoDerecha.Location = New System.Drawing.Point(573, 13)
        Me.PicbLogoDerecha.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PicbLogoDerecha.Name = "PicbLogoDerecha"
        Me.PicbLogoDerecha.Size = New System.Drawing.Size(147, 67)
        Me.PicbLogoDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbLogoDerecha.TabIndex = 13
        Me.PicbLogoDerecha.TabStop = False
        '
        'PicbLogoIzquierda
        '
        Me.PicbLogoIzquierda.Image = CType(resources.GetObject("PicbLogoIzquierda.Image"), System.Drawing.Image)
        Me.PicbLogoIzquierda.Location = New System.Drawing.Point(15, 13)
        Me.PicbLogoIzquierda.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.PicbLogoIzquierda.Name = "PicbLogoIzquierda"
        Me.PicbLogoIzquierda.Size = New System.Drawing.Size(137, 67)
        Me.PicbLogoIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicbLogoIzquierda.TabIndex = 12
        Me.PicbLogoIzquierda.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Cartera de Clientes"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(303, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 31)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "INFORME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 152)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(651, 293)
        Me.DataGridView1.TabIndex = 27
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(119, 114)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "ACTUALIZAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmCartera_de_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(735, 503)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblLibreriaSigloXXI)
        Me.Controls.Add(Me.PicbLogoDerecha)
        Me.Controls.Add(Me.PicbLogoIzquierda)
        Me.Name = "FrmCartera_de_clientes"
        Me.Text = "Cartera_de_clientes"
        CType(Me.PicbLogoDerecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicbLogoIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLibreriaSigloXXI As System.Windows.Forms.Label
    Friend WithEvents PicbLogoDerecha As System.Windows.Forms.PictureBox
    Friend WithEvents PicbLogoIzquierda As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
