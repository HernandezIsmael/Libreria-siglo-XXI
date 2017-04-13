Public Class Reporte_de_Ventas

    Private Sub Reporte_de_Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIBRERIA_SIGLO_XXIDataSet1.ventas' Puede moverla o quitarla según sea necesario.
        Me.ventasTableAdapter.Fill(Me.LIBRERIA_SIGLO_XXIDataSet1.ventas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class