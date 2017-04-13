Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_ACCESO_DE_DATOS
Imports CAPA_ENTIDAD

Public Class AUTORES
    Dim EAUT As New ENTIDAD_AUTORES
    Dim METAURS As New METODOS


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "SELECT A.ID_AUTOR,A.NOMBRE,A.APE_MAT,A.APE_PAT,P.PAIS FROM TBL_AUTORES AS A LEFT JOIN TBL_PAIS AS P ON P.ID_PAIS=A.ID_PAIS  "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY

    End Sub

    Private Sub AUTORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public insrt As String
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        If txtidautor.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            MsgBox("no se puede registrar ya que existe una clave igual a " + DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString)
        Else
            EAUT.ID_AUTOR = txtidautor.Text
            EAUT.NOMBRE = txtname.Text
            EAUT.APE_MAT = txtamat.Text
            EAUT.APE_PAT = txtapel.Text
            EAUT.ID_PAIS = cmdpais.Text

            METAURS.REGISTRO_AUTORES(EAUT)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtname.Clear()
        txtamat.Clear()
        txtapel.Clear()
        cmdpais.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtidautor.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            EAUT.ID_AUTOR = txtidautor.Text
            EAUT.NOMBRE = txtname.Text
            EAUT.APE_MAT = txtamat.Text
            EAUT.APE_PAT = txtapel.Text
            EAUT.ID_PAIS = cmdpais.Text

            METAURS.EDITAR_AUTORES(EAUT)
        Else
            MsgBox("no se puede modificar porque no es igual el ID_AUTOR debe de estar igual a " + DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString)
           
        End If
       
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtidautor.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString
        txtname.Text = DataGridView1.CurrentRow.Cells(1).EditedFormattedValue.ToString
        txtamat.Text = DataGridView1.CurrentRow.Cells(2).EditedFormattedValue.ToString
        txtapel.Text = DataGridView1.CurrentRow.Cells(3).EditedFormattedValue.ToString
        cmdpais.Text = DataGridView1.CurrentRow.Cells(4).EditedFormattedValue.ToString
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            EAUT.ID_AUTOR = txtidautor.Text
            METAURS.eliminarautores(EAUT)
            txtname.Text = ""
            txtamat.Text = ""
            txtapel.Text = ""
            cmdpais.Text = ""
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR" + ex.Message)
        End Try
       
    End Sub

    Private Sub cmdpais_Click(sender As Object, e As EventArgs) Handles cmdpais.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "SELECT ID_PAIS from TBL_PAIS"
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        cmdpais.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub
End Class