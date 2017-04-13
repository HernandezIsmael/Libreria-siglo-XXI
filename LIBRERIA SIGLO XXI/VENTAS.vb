Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_ACCESO_DE_DATOS
Imports CAPA_ENTIDAD
Public Class FrmVentas
    Dim ENTIDADES As New ENTIDAD_AUTORES
    Dim METODOS As New METODOS
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim agrega As String = DataGridView2.Rows.Count - 1
        DataGridView2.Rows.Add(1)
        DataGridView2.Rows(agrega).Cells(0).Value = txventa.Text
        DataGridView2.Rows(agrega).Cells(1).Value = txid_tlibro.Text
        DataGridView2.Rows(agrega).Cells(2).Value = TextBox2.Text
        DataGridView2.Rows(agrega).Cells(3).Value = TextBox3.Text
        DataGridView2.Rows(agrega).Cells(4).Value = txtid_gener.Text
        DataGridView2.Rows(agrega).Cells(5).Value = txteditorial.Text
        DataGridView2.Rows(agrega).Cells(6).Value = CmbuSUduario.Text
        DataGridView2.Rows(agrega).Cells(7).Value = Cmbclient.Text
        DataGridView2.Rows(agrega).Cells(8).Value = Txtpreciounitrio.Text
        DataGridView2.Rows(agrega).Cells(9).Value = Txtnumejemplrs.Text
        DataGridView2.Rows(agrega).Cells(10).Value = Txttotal.Text


        Try
            ENTIDADES.ID_VENTA = txventa.Text
            ENTIDADES.ID_LIBRO = txid_tlibro.Text
            ENTIDADES.ID_AUTOR = TextBox3.Text
            ENTIDADES.ID_GENERO = txtid_gener.Text
            ENTIDADES.ID_EDITORIAL = txteditorial.Text
            ENTIDADES.RFC_USUARIOS = CmbuSUduario.Text
            ENTIDADES.CLIENTE = Cmbclient.Text
            ENTIDADES.FECHA_VENTA = TextBox4.Text
            ENTIDADES.NUM_EJEMPLARES = Txtnumejemplrs.Text
            ENTIDADES.TOTAL_DE_COMPRA = Txttotal.Text

            METODOS.RegistroVentas(ENTIDADES)
        Catch ex As Exception
            MsgBox("NO SE PUEDO REGISTRAR ERROR" + ex.Message)
        End Try
        Txt_totalde_compra_producto.Text = Val(Txt_totalde_compra_producto.Text) + Val(Txttotal.Text)
    End Sub


    Private Sub BtnBuscarName_Click(sender As Object, e As EventArgs) Handles BtnBuscarName.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "select L.ID_LIBRO ,L.NOMBRE_LIBRO,A.ID_AUTOR,G.ID_GENERO ,E.ID_EDITORIAL ,L.AÑO_EDICION,L.PRECIO_UNIT,L.EXISTENCIA from TBL_LIBRO AS L LEFT JOIN TBL_AUTORES AS A ON A.ID_AUTOR=L.ID_AUTOR LEFT JOIN TBL_GENERO AS G ON G.ID_GENERO =L.ID_GENERO LEFT JOIN TBL_EDITORIAL AS E ON E.ID_EDITORIAL =L.ID_EDITORIAL where L.NOMBRE_LIBRO like '" & TxtNombrLibro.Text & "%'"

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "select L.ID_LIBRO ,L.NOMBRE_LIBRO,A.ID_AUTOR,G.ID_GENERO ,E.ID_EDITORIAL ,L.AÑO_EDICION,L.PRECIO_UNIT,L.EXISTENCIA from TBL_LIBRO AS L LEFT JOIN TBL_AUTORES AS A ON A.ID_AUTOR=L.ID_AUTOR LEFT JOIN TBL_GENERO AS G ON G.ID_GENERO =L.ID_GENERO LEFT JOIN TBL_EDITORIAL AS E ON E.ID_EDITORIAL =L.ID_EDITORIAL where  A.NOMBRE LIKE '" & TextBox1.Text & "%'"
        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY

    End Sub

    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtFecha As Date
        dtFecha = DateTime.Today
        Me.TextBox4.Text = dtFecha.ToString("dddd d 'de'  MMMM 'del año' yyyy")
    End Sub




    Private Sub Cmbuduario_Click(sender As Object, e As EventArgs) Handles CmbuSUduario.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "select RFC_USUARIOS from TBL_USERS where ID_PUESTO='CAJE'"
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        CmbuSUduario.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub Txtnumejemplrs_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtnumejemplrs.KeyDown
        Dim R As Integer
        Dim S As Integer
        Dim RES As String
        If (e.KeyCode = Keys.Enter) Then
            Dim X = New OPERACIONES
            R = Convert.ToInt32(Txtpreciounitrio.Text)
            S = Convert.ToInt32(Txtnumejemplrs.Text)
            RES = CStr(X.MULTIPLICAR(R, S))
            Txttotal.Text = RES

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = " SELECT ID_VENTA,L.NOMBRE_LIBRO,AA.NOMBRE+' '+AA.APE_PAT+' '+AA .APE_MAT AS 'NOMBRE AUTOR',G.GENERO ,E.EDITORIAL ,U.NOMBRE+' '+U.AP_PAT+' '+U.AP_MAT AS 'USUARIO',A.CLIENTE,A.FECHA_VENTA,L.PRECIO_UNIT,A.NUM_EJEMPLARES,A.TOTAL_DE_COMPRA  FROM TBL_VENTAS AS A LEFT JOIN TBL_LIBRO AS L ON L.ID_LIBRO =A.ID_LIBRO LEFT JOIN TBL_AUTORES AS AA ON AA.ID_AUTOR =A.ID_AUTOR LEFT JOIN TBL_GENERO AS G ON G.ID_GENERO =A.ID_GENERO LEFT JOIN TBL_EDITORIAL AS E ON E.ID_EDITORIAL =A.ID_EDITORIAL LEFT JOIN TBL_USERS AS U ON U.RFC_USUARIOS =A.RFC_USUARIOS "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView2.DataSource = XY
    End Sub

    Private Sub Cmbclient_Click(sender As Object, e As EventArgs) Handles Cmbclient.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "  select NOMBRE+''+AP_PAT+' '+AP_MAT FROM TBL_USERS where ID_PUESTO='CLIENT' "
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        Cmbclient.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub Bttnquitr_Click(sender As Object, e As EventArgs) Handles Bttnquitr.Click
        Try
            ENTIDADES.ID_VENTA = txventa.Text
            METODOS.EliminarVentas(ENTIDADES)
            TextBox2.Clear()
            TextBox3.Clear()
            txtid_gener.Clear()
            Cmbclient.Text = ""
            CmbuSUduario.Text = ""
            Txtpreciounitrio.Clear()
            Txtnumejemplrs.Clear()
            Txttotal.Clear()
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR POR EL ERROR " + ex.Message)
        End Try


    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txid_tlibro.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).EditedFormattedValue.ToString
        txtid_gener.Text = DataGridView1.CurrentRow.Cells(3).EditedFormattedValue.ToString
        txteditorial.Text = DataGridView1.CurrentRow.Cells(4).EditedFormattedValue.ToString
        Txtpreciounitrio.Text = DataGridView1.CurrentRow.Cells(6).EditedFormattedValue.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).EditedFormattedValue.ToString
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        txventa.Text = DataGridView2.CurrentRow.Cells(0).EditedFormattedValue.ToString
        TextBox2.Text = DataGridView2.CurrentRow.Cells(1).EditedFormattedValue.ToString
        TextBox3.Text = DataGridView2.CurrentRow.Cells(2).EditedFormattedValue.ToString
        txtid_gener.Text = DataGridView2.CurrentRow.Cells(3).EditedFormattedValue.ToString
        txteditorial.Text = DataGridView2.CurrentRow.Cells(4).EditedFormattedValue.ToString
        CmbuSUduario.Text = DataGridView2.CurrentRow.Cells(5).EditedFormattedValue.ToString
        Cmbclient.Text = DataGridView2.CurrentRow.Cells(6).EditedFormattedValue.ToString
        Txtpreciounitrio.Text = DataGridView2.CurrentRow.Cells(7).EditedFormattedValue.ToString
        Txtnumejemplrs.Text = DataGridView2.CurrentRow.Cells(8).EditedFormattedValue.ToString
        Txttotal.Text = DataGridView2.CurrentRow.Cells(9).EditedFormattedValue.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txventa.Text = Format(METODOS.generarcodigo, "000")
        txid_tlibro.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        txtid_gener.Clear()
        txteditorial.Clear()
        CmbuSUduario.Text = ""
        Cmbclient.Text = ""
        Txtpreciounitrio.Clear()
        Txtnumejemplrs.Clear()
        Txttotal.Clear()
    End Sub

    Private Sub TextBox5_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox5.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            CAMBIO.Text = Val(TextBox5.Text) - Val(Txt_totalde_compra_producto.Text)
        End If
    End Sub

   
End Class