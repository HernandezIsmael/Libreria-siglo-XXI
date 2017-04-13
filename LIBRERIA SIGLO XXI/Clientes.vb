Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_ACCESO_DE_DATOS
Imports CAPA_ENTIDAD

Public Class FrmClientes
    Dim ENTIDADES As New ENTIDAD_AUTORES
    Dim METODOS As New METODOS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub CmbID_puesto_Click(sender As Object, e As EventArgs) Handles CmbID_puesto.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "SELECT ID_PUESTO  from TBL_PUESTOS WHERE ID_PUESTO ='CLIENT' "
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        CmbID_puesto.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub CmbID_comunidd_Click(sender As Object, e As EventArgs) Handles CmbID_comunidd.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "SELECT ID_COMUNIDAD  from TBL_COMUNIDAD  "
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        CmbID_comunidd.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub CmbMunicipio_Click(sender As Object, e As EventArgs) Handles CmbMunicipio.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "SELECT ID_MUNICIPIO  from TBL_MUNICIPIO  "
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        CmbMunicipio.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub CmbID_Estad_Click(sender As Object, e As EventArgs) Handles CmbID_Estad.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "SELECT ID_ESTADO  from TBL_ESTADO  "
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        CmbID_Estad.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "SELECT U.RFC_USUARIOS ,U.NOMBRE,U.AP_PAT,U.AP_MAT,U.SEXO,U.FECHA_NAC,P.PUESTO,C.COMUNIDAD,M.MUNICIPIO,E.ESTADO,PA.PAIS  FROM TBL_USERS AS U LEFT JOIN TBL_PUESTOS AS P ON P.ID_PUESTO =U.ID_PUESTO LEFT JOIN TBL_COMUNIDAD AS C ON C.ID_COMUNIDAD =U.ID_COMUNIDAD LEFT JOIN TBL_MUNICIPIO AS M ON M.ID_MUNICIPIO =U.ID_MUNICIPIO LEFT JOIN TBL_ESTADO AS E ON E.ID_ESTADO =U.ID_ESTADO LEFT JOIN TBL_PAIS AS PA ON PA.ID_PAIS =U.ID_PAIS WHERE U.ID_PUESTO ='CLIENT' "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    Private Sub CmbID_pais_Click(sender As Object, e As EventArgs) Handles CmbID_pais.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "SELECT ID_PAIS  from TBL_PAIS  "
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        CmbID_pais.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            MsgBox("NO SE PUEDE REGISTRAR YA QUE EXITE UNA CLAVE IGUAL A " + DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString)
        Else

            ENTIDADES.RFC_USUARIOS = TextBox1.Text
            ENTIDADES.NOMBRE = TextBox2.Text
            ENTIDADES.AP_PAT = TextBox3.Text
            ENTIDADES.AP_MAT = TextBox4.Text
            ENTIDADES.SEXO = TextBox5.Text
            ENTIDADES.FECHA_NAC = TextBox6.Text
            ENTIDADES.ID_PUESTO = CmbID_puesto.Text
            ENTIDADES.ID_COMUNIDAD = CmbID_comunidd.Text
            ENTIDADES.ID_MUNICIPIO = CmbMunicipio.Text
            ENTIDADES.ID_ESTADO = CmbID_Estad.Text
            ENTIDADES.ID_PAIS = CmbID_pais.Text

            METODOS.REGISTR_USER(ENTIDADES)
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            ENTIDADES.RFC_USUARIOS = TextBox1.Text
            ENTIDADES.NOMBRE = TextBox2.Text
            ENTIDADES.AP_PAT = TextBox3.Text
            ENTIDADES.AP_MAT = TextBox4.Text
            ENTIDADES.SEXO = TextBox5.Text
            ENTIDADES.FECHA_NAC = TextBox6.Text
            ENTIDADES.ID_PUESTO = CmbID_puesto.Text
            ENTIDADES.ID_COMUNIDAD = CmbID_comunidd.Text
            ENTIDADES.ID_MUNICIPIO = CmbMunicipio.Text
            ENTIDADES.ID_ESTADO = CmbID_Estad.Text
            ENTIDADES.ID_PAIS = CmbID_pais.Text

            METODOS.MODIFICAR_USER(ENTIDADES)
        Else
            MsgBox("DEBE SER IGUAL LA CALVE DEL CLIENTE A " + DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString)
        End If
       
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ENTIDADES.RFC_USUARIOS = TextBox1.Text
            METODOS.ELIMINAR_USER(ENTIDADES)

            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            CmbID_comunidd.Text = ""
            CmbID_Estad.Text = ""
            CmbID_pais.Text = ""
            CmbID_puesto.Text = ""
            CmbMunicipio.Text = ""
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR" + ex.Message)
        End Try
       
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = Format(METODOS.GENERA_CODI_USERS, "000")
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        CmbID_comunidd.Text = ""
        CmbID_Estad.Text = ""
        CmbID_pais.Text = ""
        CmbID_puesto.Text = ""
        CmbMunicipio.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Lugares_de_Origen.Show()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).EditedFormattedValue.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).EditedFormattedValue.ToString
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).EditedFormattedValue.ToString
        TextBox5.Text = DataGridView1.CurrentRow.Cells(4).EditedFormattedValue.ToString
        TextBox6.Text = DataGridView1.CurrentRow.Cells(5).EditedFormattedValue.ToString
        CmbID_puesto.Text = DataGridView1.CurrentRow.Cells(6).EditedFormattedValue.ToString
        CmbID_comunidd.Text = DataGridView1.CurrentRow.Cells(7).EditedFormattedValue.ToString
        CmbMunicipio.Text = DataGridView1.CurrentRow.Cells(8).EditedFormattedValue.ToString
        CmbID_Estad.Text = DataGridView1.CurrentRow.Cells(9).EditedFormattedValue.ToString
        CmbID_pais.Text = DataGridView1.CurrentRow.Cells(10).EditedFormattedValue.ToString
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class