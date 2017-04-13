<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class solicitar_compras
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LIBRERIA_SIGLO_XXIDataSet3 = New LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet3()
        Me.SOLICITAR_PRODUCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SOLICITAR_PRODUCTableAdapter = New LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet3TableAdapters.SOLICITAR_PRODUCTableAdapter()
        CType(Me.LIBRERIA_SIGLO_XXIDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SOLICITAR_PRODUCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROVEDOR:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(124, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(124, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(216, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FECHA :"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.Aquamarine
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SOLICITAR_PRODUCBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIBRERIA_SIGLO_XXI.Report_SOLICITAR PRODUCTOS.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 87)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(872, 396)
        Me.ReportViewer1.TabIndex = 7
        '
        'LIBRERIA_SIGLO_XXIDataSet3
        '
        Me.LIBRERIA_SIGLO_XXIDataSet3.DataSetName = "LIBRERIA_SIGLO_XXIDataSet3"
        Me.LIBRERIA_SIGLO_XXIDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SOLICITAR_PRODUCBindingSource
        '
        Me.SOLICITAR_PRODUCBindingSource.DataMember = "SOLICITAR_PRODUC"
        Me.SOLICITAR_PRODUCBindingSource.DataSource = Me.LIBRERIA_SIGLO_XXIDataSet3
        '
        'SOLICITAR_PRODUCTableAdapter
        '
        Me.SOLICITAR_PRODUCTableAdapter.ClearBeforeFill = True
        '
        'solicitar_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(890, 495)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "solicitar_compras"
        Me.Text = "solicitar_compras"
        CType(Me.LIBRERIA_SIGLO_XXIDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SOLICITAR_PRODUCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SOLICITAR_PRODUCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIBRERIA_SIGLO_XXIDataSet3 As LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet3
    Friend WithEvents SOLICITAR_PRODUCTableAdapter As LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet3TableAdapters.SOLICITAR_PRODUCTableAdapter
End Class
