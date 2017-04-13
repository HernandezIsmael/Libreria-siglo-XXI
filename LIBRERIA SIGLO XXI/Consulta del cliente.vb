Imports System.Data
Imports System.Data.SqlClient

Public Class FrmEstado_de_cuenta_del_cliente

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "select DISTINCT U.RFC_USUARIOS, U.NOMBRE+' '+U.AP_PAT+' '+U.AP_MAT ,U.SEXO ,U.FECHA_NAC,P.PUESTO,C.COMUNIDAD,M.MUNICIPIO,E.ESTADO,PA.PAIS  from TBL_USERS AS U LEFT JOIN TBL_PUESTOS AS P ON P.ID_PUESTO =U.ID_PUESTO LEFT JOIN TBL_COMUNIDAD AS C ON C.ID_COMUNIDAD =U.ID_COMUNIDAD LEFT JOIN TBL_MUNICIPIO AS M ON M.ID_MUNICIPIO =U.ID_MUNICIPIO LEFT JOIN TBL_ESTADO AS E ON E.ID_ESTADO =U.ID_ESTADO LEFT JOIN TBL_PAIS AS PA ON PA.ID_PAIS =U.ID_PAIS WHERE PUESTO ='CLIENTE'"

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        REPORTE_CLIENTS.Show()

    End Sub
End Class