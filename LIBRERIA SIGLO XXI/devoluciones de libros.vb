Imports System.Data.SqlClient
Imports System.Data
Imports CAPA_ACCESO_DE_DATOS
Imports CAPA_ENTIDAD

Public Class devoluciones_de_libros
    Dim ENTIDADES As New ENTIDAD_AUTORES
    Dim METODOS As New METODOS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "  SELECT ID_VENTA,L.ID_LIBRO ,L.NOMBRE_LIBRO,AA.ID_AUTOR,G.ID_GENERO ,E.ID_EDITORIAL ,U.RFC_USUARIOS ,L.AÑO_EDICION ,A.FECHA_VENTA,L.PRECIO_UNIT , A.NUM_EJEMPLARES,A.TOTAL_DE_COMPRA,A.TOTAL_DE_COMPRA  FROM TBL_VENTAS AS A LEFT JOIN TBL_LIBRO AS L ON L.ID_LIBRO =A.ID_LIBRO LEFT JOIN TBL_AUTORES AS AA ON AA.ID_AUTOR =A.ID_AUTOR LEFT JOIN TBL_GENERO AS G ON G.ID_GENERO =A.ID_GENERO LEFT JOIN TBL_EDITORIAL AS E ON E.ID_EDITORIAL =A.ID_EDITORIAL LEFT JOIN TBL_USERS AS U ON U.RFC_USUARIOS =A.RFC_USUARIOS"

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        

        ENTIDADES.ID_VENTA = txventa.Text
        ENTIDADES.ID_CANCELACION = txtid_cancela.Text
        ENTIDADES.ID_TIPO_CANCELACION = Cmtipo_cancela.Text
        ENTIDADES.ID_LIBRO = txid_tlibro.Text
        ENTIDADES.ID_AUTOR = Txtautor.Text
        ENTIDADES.ID_GENERO = txtid_gener.Text
        ENTIDADES.ID_EDITORIAL = txteditorial.Text
        ENTIDADES.RFC_USUARIOS = Cmbuduario.Text
        ENTIDADES.FECHA_VENTA = Txtfech_vent.Text
        ENTIDADES.NUM_CANCELACIONES = Txtnum_cance.Text
        ENTIDADES.TOTAL_DE_COMPRA = Txttotal_compra.Text

        METODOS.Cancelacion(ENTIDADES)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txventa.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString
        txid_tlibro.Text = DataGridView1.CurrentRow.Cells(1).EditedFormattedValue.ToString
        txtnombre_libr.Text = DataGridView1.CurrentRow.Cells(2).EditedFormattedValue.ToString
        Txtautor.Text = DataGridView1.CurrentRow.Cells(3).EditedFormattedValue.ToString
        txtid_gener.Text = DataGridView1.CurrentRow.Cells(4).EditedFormattedValue.ToString
        txteditorial.Text = DataGridView1.CurrentRow.Cells(5).EditedFormattedValue.ToString
        Cmbuduario.Text = DataGridView1.CurrentRow.Cells(6).EditedFormattedValue.ToString
        Txtfech_vent.Text = DataGridView1.CurrentRow.Cells(8).EditedFormattedValue.ToString
        Txtpreciounitrio.Text = DataGridView1.CurrentRow.Cells(9).EditedFormattedValue.ToString
        Txtnum_cance.Text = DataGridView1.CurrentRow.Cells(10).EditedFormattedValue.ToString
        txtañoedi.Text = DataGridView1.CurrentRow.Cells(7).EditedFormattedValue.ToString
        Txttotal_compra.Text = DataGridView1.CurrentRow.Cells(11).EditedFormattedValue.ToString
    End Sub

    Private Sub devoluciones_de_libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class