<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_inventario
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
        Me.LIBRERIA_SIGLO_XXIDataSet = New LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet()
        Me.productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.productosTableAdapter = New LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSetTableAdapters.productosTableAdapter()
        CType(Me.LIBRERIA_SIGLO_XXIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.LightSeaGreen
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.productosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LIBRERIA_SIGLO_XXI.Report_inventario.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(24, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(896, 267)
        Me.ReportViewer1.TabIndex = 0
        '
        'LIBRERIA_SIGLO_XXIDataSet
        '
        Me.LIBRERIA_SIGLO_XXIDataSet.DataSetName = "LIBRERIA_SIGLO_XXIDataSet"
        Me.LIBRERIA_SIGLO_XXIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'productosBindingSource
        '
        Me.productosBindingSource.DataMember = "productos"
        Me.productosBindingSource.DataSource = Me.LIBRERIA_SIGLO_XXIDataSet
        '
        'productosTableAdapter
        '
        Me.productosTableAdapter.ClearBeforeFill = True
        '
        'reporte_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(979, 327)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "reporte_inventario"
        Me.Text = "reporte_inventario"
        CType(Me.LIBRERIA_SIGLO_XXIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents productosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIBRERIA_SIGLO_XXIDataSet As LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSet
    Friend WithEvents productosTableAdapter As LIBRERIA_SIGLO_XXI.LIBRERIA_SIGLO_XXIDataSetTableAdapters.productosTableAdapter
End Class
