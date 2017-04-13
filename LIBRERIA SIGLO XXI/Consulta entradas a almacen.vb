Imports System.Data.SqlClient
Imports System.Data
Public Class FrmConsulta_entradas_a_almacen

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = " select V.ID_VENTA,L.NOMBRE_LIBRO,A.NOMBRE+' '+A.APE_PAT AS 'AUTOR' ,G.GENERO,E.EDITORIAL,U.NOMBRE+''+U.AP_PAT+' '+U.AP_MAT AS 'USUARIO',V.CLIENTE,V.FECHA_VENTA,V.NUM_EJEMPLARES,V.TOTAL_DE_COMPRA  from TBL_VENTAS  as V LEFT JOIN TBL_LIBRO AS L ON L.ID_LIBRO=V.ID_LIBRO LEFT JOIN TBL_AUTORES AS A ON A.ID_AUTOR =V.ID_AUTOR LEFT JOIN TBL_GENERO AS G ON G.ID_GENERO =V.ID_GENERO LEFT JOIN TBL_EDITORIAL AS E ON E.ID_EDITORIAL =V.ID_EDITORIAL LEFT JOIN TBL_USERS AS U ON U.RFC_USUARIOS=V.RFC_USUARIOS "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reporte_de_Ventas.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class