Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtFecha As Date
        dtFecha = DateTime.Today
        Me.LblFechaHoy.Text = dtFecha.ToString("dddd d 'de'  MMMM 'del año' yyyy")
    End Sub
    Private Sub TsmCliente_Click(sender As Object, e As EventArgs)
        FrmClientes.Show()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
    Private Sub ConsultaDeInventariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmConsultaInventarios.Show()
    End Sub
    Private Sub ConsultarEntradasLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmConsulta_entradas_a_almacen.Show()
    End Sub
    Private Sub ACERCADEToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ACERCADEToolStripMenuItem1.Click
        FrmAcerca_De.Show()
    End Sub

    Private Sub ConsultaDeInventariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConsultaDeInventariosToolStripMenuItem1.Click
        FrmConsultaInventarios.Show()
    End Sub

    Private Sub ConsultarEntradasLibrosToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ConsultarEntradasLibrosToolStripMenuItem1.Click
        FrmConsulta_entradas_a_almacen.Show()
    End Sub
    Private Sub ConsultarEstadoDeCuentaDelClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEstadoDeCuentaDelClienteToolStripMenuItem.Click
        FrmEstado_de_cuenta_del_cliente.Show()
    End Sub

    Private Sub CarteleraDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CarteleraDeClientesToolStripMenuItem.Click
        FrmCartera_de_clientes.Show()
    End Sub

    Private Sub IngresarClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IngresarClientesToolStripMenuItem1.Click
        FrmClientes.Show()
    End Sub

    Private Sub VentaDeLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaDeLibrosToolStripMenuItem.Click
        FrmVentas.Show()
    End Sub

    Private Sub AutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoresToolStripMenuItem.Click
        AUTORES.Show()
    End Sub

    Private Sub IngresarEditorialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarEditorialesToolStripMenuItem.Click
        Ingresar_Editoriales.Show()
    End Sub

    Private Sub IngresosDeLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosDeLibrosToolStripMenuItem.Click
        Ingresos_de_Libros.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        USUARIOS.Show()
    End Sub

    Private Sub CcmprarLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CcmprarLibrosToolStripMenuItem.Click
        solicitar_compras.Show()
    End Sub

    Private Sub DevoluciónDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevoluciónDeClienteToolStripMenuItem.Click
        devoluciones_de_libros.Show()
    End Sub

    Private Sub IngresaLugarOrigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresaLugarOrigenToolStripMenuItem.Click
        Lugares_de_Origen.Show()

    End Sub

    Private Sub IngresarPaisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarPaisesToolStripMenuItem.Click
        ingreso_paises.Show()

    End Sub

    Private Sub IngresoPuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoPuestosToolStripMenuItem.Click
        puestos.Show()

    End Sub

    Private Sub ConsultaGeneralDeDevolucionesDeClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CONSULTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTASToolStripMenuItem.Click

    End Sub
End Class