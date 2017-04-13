Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_ACCESO_DE_DATOS
Imports CAPA_ENTIDAD
Public Class USUARIOS
    Dim ENTIDADES As New ENTIDAD_AUTORES
    Dim METODOS As New METODOS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "SELECT *FROM TBL_TIPO_USUARIOS  "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ENTIDADES.USUARIO = TextBox1.Text
            ENTIDADES.ID_TIP_USER = TextBox2.Text
            ENTIDADES.TIPO_USER = TextBox3.Text
            METODOS.REGIS_USUARIO_ENTR(ENTIDADES)
        Catch ex As Exception
            MsgBox("NO SE PUEDE REGISTRAR " + ex.Message)
        End Try
       
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = Format(METODOS.GeneraIdUsers, "0")
        TextBox1.Enabled = False
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            ENTIDADES.USUARIO = TextBox1.Text
            ENTIDADES.ID_TIP_USER = TextBox2.Text
            ENTIDADES.TIPO_USER = TextBox3.Text
            METODOS.MODIFICAR_USUARIOS(ENTIDADES)
        Else
            MsgBox("NO SE PUEDE MODIFICAR YA QUE  NO ES LA MISMA CLAVE A " + DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString)
        End If


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).EditedFormattedValue.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).EditedFormattedValue.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ENTIDADES.USUARIO = TextBox1.Text

            METODOS.ELIMINAR_USUARIOS_ENT(ENTIDADES)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        Catch ex As Exception
            MsgBox("NO SE PUDO ELIMINAR POR " + ex.Message)
        End Try
       

    End Sub
End Class