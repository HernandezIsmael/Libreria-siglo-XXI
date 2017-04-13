Imports System.Data
Imports System.Data.SqlClient
Public Class FrmIngresar
    Dim almacena As String
    Dim indicador As String
    Dim con As New OPERACIONES()
    Dim cadena As String
    Dim tabla = New DataTable


    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click

        almacena = Txtusuario.Text
        indicador = cmbtipo_usuario.SelectedIndex
        If indicador = 0 Then
            con.conexiones()
            cmbtipo_usuario.Text = "Administrador"
            cadena = "select USUARIO,TIPO_USER from TBL_TIPO_USUARIOS where USUARIO ='" + Txtusuario.Text + "'  and TIPO_USER ='" + TxtContraseña.Text + "'"
            tabla = con.buscar(cadena)
            Dim res As Integer = tabla.Rows.Count

            If (res = 0) Then

                MessageBox.Show("Acceso denegado usuario o contraseña no validas")

            Else
                Txtusuario.Clear()
                TxtContraseña.Clear()
                MessageBox.Show("Bienvenido ")
                FrmPrincipal.Show()


            End If
        Else
            If indicador = 1 Then
                con.conexiones()
                cmbtipo_usuario.Text = "Cajero"
                cadena = "select USUARIO,TIPO_USER from TBL_TIPO_USUARIOS where USUARIO ='" + Txtusuario.Text + "'  and TIPO_USER ='" + TxtContraseña.Text + "'"
                tabla = con.buscar(cadena)
                Dim res As Integer = tabla.Rows.Count
                If (res = 0) Then

                    MessageBox.Show("Acceso denegado usuario o contraseña no validas")

                Else
                    Txtusuario.Clear()
                    TxtContraseña.Clear()
                    MessageBox.Show("Bienvenido ")
                    FrmPrincipal.CONSULTASToolStripMenuItem.Visible = False
                    FrmPrincipal.CcmprarLibrosToolStripMenuItem.Visible = False
                    FrmPrincipal.AutoresToolStripMenuItem.Visible = False
                    FrmPrincipal.IngresarEditorialesToolStripMenuItem.Visible = False
                    FrmPrincipal.IngresosDeLibrosToolStripMenuItem.Visible = False
                    FrmPrincipal.UsuariosToolStripMenuItem.Visible = False
                    FrmPrincipal.IngresarPaisesToolStripMenuItem.Visible = False
                    FrmPrincipal.IngresoPuestosToolStripMenuItem.Visible = False
                    FrmPrincipal.Show()

                End If
            Else
                If indicador = 2 Then
                    con.conexiones()
                    cmbtipo_usuario.Text = "Jefe"
                    cadena = "select USUARIO,TIPO_USER from TBL_TIPO_USUARIOS where USUARIO ='" + Txtusuario.Text + "'  and TIPO_USER ='" + TxtContraseña.Text + "'"
                    tabla = con.buscar(cadena)
                    Dim res As Integer = tabla.Rows.Count
                    If (res = 0) Then

                        MessageBox.Show("Acceso denegado usuario o contraseña no validas")

                    Else
                        Txtusuario.Clear()
                        TxtContraseña.Clear()
                        MessageBox.Show("Bienvenido ")
                        FrmPrincipal.Show()

                    End If

                End If

            End If
        End If

    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
