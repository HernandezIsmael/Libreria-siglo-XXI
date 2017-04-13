<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTE_CLIENTS
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LIBRERIA_SIGLO_XXIDataSet2 = New LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet2()
        Me.clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.clientesTableAdapter = New LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet2TableAdapters.clientesTableAdapter()
        CType(Me.LIBRERIA_SIGLO_XXIDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.MediumAquamarine
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.clientesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIBRERIA_SIGLO_XXI.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 9)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1177, 409)
        Me.ReportViewer1.TabIndex = 0
        '
        'LIBRERIA_SIGLO_XXIDataSet2
        '
        Me.LIBRERIA_SIGLO_XXIDataSet2.DataSetName = "LIBRERIA_SIGLO_XXIDataSet2"
        Me.LIBRERIA_SIGLO_XXIDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'clientesBindingSource
        '
        Me.clientesBindingSource.DataMember = "clientes"
        Me.clientesBindingSource.DataSource = Me.LIBRERIA_SIGLO_XXIDataSet2
        '
        'clientesTableAdapter
        '
        Me.clientesTableAdapter.ClearBeforeFill = True
        '
        'REPORTE_CLIENTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 448)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "REPORTE_CLIENTS"
        Me.Text = "REPORTE CLIENTES"
        CType(Me.LIBRERIA_SIGLO_XXIDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents clientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIBRERIA_SIGLO_XXIDataSet2 As LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet2
    Friend WithEvents clientesTableAdapter As LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet2TableAdapters.clientesTableAdapter
End Class
