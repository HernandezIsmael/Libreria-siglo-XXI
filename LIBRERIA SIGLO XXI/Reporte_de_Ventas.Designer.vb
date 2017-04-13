<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_de_Ventas
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
        Me.ventasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LIBRERIA_SIGLO_XXIDataSet1 = New LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ventasTableAdapter = New LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet1TableAdapters.ventasTableAdapter()
        CType(Me.ventasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIBRERIA_SIGLO_XXIDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ventasBindingSource
        '
        Me.ventasBindingSource.DataMember = "ventas"
        Me.ventasBindingSource.DataSource = Me.LIBRERIA_SIGLO_XXIDataSet1
        '
        'LIBRERIA_SIGLO_XXIDataSet1
        '
        Me.LIBRERIA_SIGLO_XXIDataSet1.DataSetName = "LIBRERIA_SIGLO_XXIDataSet1"
        Me.LIBRERIA_SIGLO_XXIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.Aquamarine
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ventasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIBRERIA_SIGLO_XXI.Report_venta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(24, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1185, 286)
        Me.ReportViewer1.TabIndex = 0
        '
        'ventasTableAdapter
        '
        Me.ventasTableAdapter.ClearBeforeFill = True
        '
        'Reporte_de_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 322)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reporte_de_Ventas"
        Me.Text = "Reporte_de_Ventas"
        CType(Me.ventasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIBRERIA_SIGLO_XXIDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ventasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIBRERIA_SIGLO_XXIDataSet1 As LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet1
    Friend WithEvents ventasTableAdapter As LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet1TableAdapters.ventasTableAdapter
End Class
