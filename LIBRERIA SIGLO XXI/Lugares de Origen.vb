Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_ACCESO_DE_DATOS
Imports CAPA_ENTIDAD
Public Class Lugares_de_Origen
    Dim ENTIDADES As New ENTIDAD_AUTORES
    Dim METODOS As New METODOS
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "SELECT *FROM TBL_COMUNIDAD "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "SELECT *FROM TBL_ESTADO  "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView2.DataSource = XY
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "SELECT *FROM TBL_MUNICIPIO "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView3.DataSource = XY
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ENTIDADES.ID_COMUNIDAD = TextBox1.Text
        ENTIDADES.COMUNIDAD = TextBox2.Text
        METODOS.REGISTR_COMUNI(ENTIDADES)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ENTIDADES.ID_ESTADO = TextBox3.Text
        ENTIDADES.ESTADO = TextBox4.Text
        METODOS.RegistarEstados(ENTIDADES)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ENTIDADES.ID_MUNICIPIO = TextBox5.Text
        ENTIDADES.MUNICIPIO = TextBox6.Text
        METODOS.RegistrarMunicipio(ENTIDADES)
    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        TextBox1.Text = DataGridView1.SelectedCells.Item(0).Value
        TextBox2.Text = DataGridView1.SelectedCells.Item(1).Value

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        TextBox3.Text = DataGridView2.SelectedCells.Item(0).Value
        TextBox4.Text = DataGridView2.SelectedCells.Item(1).Value

    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        TextBox5.Text = DataGridView3.SelectedCells.Item(0).Value
        TextBox6.Text = DataGridView3.SelectedCells.Item(0).Value
    End Sub

    Private Sub Lugares_de_Origen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class