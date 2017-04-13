Public Class REPORTE_CLIENTS

    Private Sub REPORTE_CLIENTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIBRERIA_SIGLO_XXIDataSet2.clientes' Puede moverla o quitarla según sea necesario.
        Me.clientesTableAdapter.Fill(Me.LIBRERIA_SIGLO_XXIDataSet2.clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class