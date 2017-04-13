Public Class reporte_inventario

    Private Sub reporte_inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIBRERIA_SIGLO_XXIDataSet.productos' Puede moverla o quitarla según sea necesario.
        Me.productosTableAdapter.Fill(Me.LIBRERIA_SIGLO_XXIDataSet.productos)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class