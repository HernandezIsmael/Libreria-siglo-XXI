Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_ACCESO_DE_DATOS
Imports CAPA_ENTIDAD

Public Class Ingresos_de_Libros
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
        CODIGO = " select L.ID_LIBRO,L.NOMBRE_LIBRO,A.NOMBRE +' '+A.APE_PAT+' '+A.APE_MAT AS 'AUTOR',G.GENERO ,E.EDITORIAL,L.AÑO_EDICION,L.PRECIO_UNIT,L.EXISTENCIA from TBL_LIBRO as L LEFT JOIN TBL_AUTORES AS A ON A.ID_AUTOR =L.ID_AUTOR LEFT JOIN TBL_GENERO AS G ON G.ID_GENERO =L.ID_GENERO LEFT JOIN TBL_EDITORIAL AS E ON E.ID_EDITORIAL =L.ID_EDITORIAL   "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    Private Sub CmbID_Aut_Click(sender As Object, e As EventArgs) Handles CmbID_Aut.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "SELECT ID_AUTOR from TBL_AUTORES  "
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        CmbID_Aut.DataSource = LISTATABLAS
        CONECTAR.Close()

    End Sub

    Private Sub CmdAutr_Click(sender As Object, e As EventArgs) Handles Cmdgenero.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "SELECT ID_GENERO from TBL_GENERO"
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        Cmdgenero.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub CmdID_edi_Click(sender As Object, e As EventArgs) Handles CmdID_edi.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "SELECT ID_EDITORIAL from TBL_EDITORIAL"
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        CmdID_edi.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtid_libr.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            MsgBox("NO SE PUEDE REGISTRAR YA QUE EXITE UNA CLAVE IGUAL A " + DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString)
        Else
            ENTIDADES.ID_LIBRO = txtid_libr.Text
            ENTIDADES.NOMBRE_LIBRO = txtnombre_libro.Text
            ENTIDADES.ID_AUTOR = CmbID_Aut.Text
            ENTIDADES.ID_GENERO = Cmdgenero.Text
            ENTIDADES.ID_EDITORIAL = CmdID_edi.Text
            ENTIDADES.AÑO_EDICION = txtañodeedicion.Text
            ENTIDADES.PRECIO_UNIT = txtprecio.Text
            ENTIDADES.EXISTENCIA = txtexistencia.Text

            METODOS.REGISTRO_LIBROS(ENTIDADES)
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtid_libr.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            ENTIDADES.ID_LIBRO = txtid_libr.Text
            ENTIDADES.NOMBRE_LIBRO = txtnombre_libro.Text
            ENTIDADES.ID_AUTOR = CmbID_Aut.Text
            ENTIDADES.ID_GENERO = Cmdgenero.Text
            ENTIDADES.ID_EDITORIAL = CmdID_edi.Text
            ENTIDADES.AÑO_EDICION = txtañodeedicion.Text
            ENTIDADES.PRECIO_UNIT = txtprecio.Text
            ENTIDADES.EXISTENCIA = txtexistencia.Text

            METODOS.MODIFICAR_LIBROS(ENTIDADES)
        Else
            MsgBox("NO SE PUEDE MODIFICAR DEBE SE IGUAL LA CLAVE A " + DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString)
           
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txtid_libr.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString
        txtnombre_libro.Text = DataGridView1.CurrentRow.Cells(1).EditedFormattedValue.ToString
        CmbID_Aut.Text = DataGridView1.CurrentRow.Cells(2).EditedFormattedValue.ToString
        Cmdgenero.Text = DataGridView1.CurrentRow.Cells(3).EditedFormattedValue.ToString
        CmdID_edi.Text = DataGridView1.CurrentRow.Cells(4).EditedFormattedValue.ToString
        txtañodeedicion.Text = DataGridView1.CurrentRow.Cells(5).EditedFormattedValue.ToString
        txtprecio.Text = DataGridView1.CurrentRow.Cells(6).EditedFormattedValue.ToString
        txtexistencia.Text = DataGridView1.CurrentRow.Cells(7).EditedFormattedValue.ToString

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ENTIDADES.ID_LIBRO = txtid_libr.Text
            METODOS.ELIMINAR_LIBROS(ENTIDADES)
            txtnombre_libro.Text = ""
            CmbID_Aut.Text = ""
            Cmdgenero.Text = ""
            CmdID_edi.Text = ""
            txtañodeedicion.Text = ""
            txtprecio.Text = ""
            txtexistencia.Text = ""
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR" + ex.Message)
        End Try
       
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        txtnombre_libro.Clear()
        CmbID_Aut.Text = ""
        Cmdgenero.Text = ""
        CmdID_edi.Text = ""
        txtañodeedicion.Clear()
        txtprecio.Clear()
        txtexistencia.Clear()
    End Sub

    Private Sub CmbID_Aut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbID_Aut.SelectedIndexChanged

    End Sub
End Class