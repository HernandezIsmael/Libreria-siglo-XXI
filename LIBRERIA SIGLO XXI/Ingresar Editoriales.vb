Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_ACCESO_DE_DATOS
Imports CAPA_ENTIDAD
Public Class Ingresar_Editoriales
    Dim ENTIDADES As New ENTIDAD_AUTORES
    Dim METODOS As New METODOS
    Dim CONECTAR As SqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"


        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "SELECT *FROM TBL_EDITORIAL  "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnINGRESAR.Click
        If txtid_edi.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            MsgBox("NO SE PUEDE REGISTRAR YA QUE EXISTE UNA CLAVE IGUAL")
        Else
            ENTIDADES.ID_EDITORIAL = txtid_edi.Text
            ENTIDADES.EDITORIAL = txtedi.Text

            METODOS.REGISTRAR_EDI(ENTIDADES)
        End If
        
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtid_edi.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            ENTIDADES.ID_EDITORIAL = txtid_edi.Text
            ENTIDADES.EDITORIAL = txtedi.Text

            METODOS.MODIFICAR_EDITORIALES(ENTIDADES)
        Else
            MsgBox("NO SE PUEDE MODIFICAR TIENE QUE SER LA CLAVE IGUAL A" + DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString)
        End If
        
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtid_edi.Text = DataGridView1.CurrentRow.Cells(0).EditedFormattedValue.ToString
        txtedi.Text = DataGridView1.CurrentRow.Cells(1).EditedFormattedValue.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            ENTIDADES.ID_EDITORIAL = txtid_edi.Text
            METODOS.ELIMINAR_EDITORIALES(ENTIDADES)
            txtid_edi.Text = ""
            txtedi.Text = ""
        Catch ex As Exception
            MsgBox("NO SE PUEDE ELIMINAR" + ex.Message)

        End Try
       

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "SELECT *FROM TBL_GENERO  "

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView2.DataSource = XY
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Txt_id_genr.Text = DataGridView2.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            MsgBox("NO SE PUEDE REGISTRAR YA QUE EXISTE UNA CLAVE IGUAL A" + DataGridView2.CurrentRow.Cells(0).EditedFormattedValue.ToString)
        Else
            ENTIDADES.ID_GENERO = Txt_id_genr.Text
            ENTIDADES.GENERO = Txt_genero.Text

            METODOS.REGISTRAR_gener(ENTIDADES)
        End If
        

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Txt_id_genr.Text = DataGridView2.CurrentRow.Cells(0).EditedFormattedValue.ToString Then
            ENTIDADES.ID_GENERO = Txt_id_genr.Text
            ENTIDADES.GENERO = Txt_genero.Text
            METODOS.MODIFICAR_GENER(ENTIDADES)
        Else
            MsgBox("NO SE PUEDE ELIMINAR POR QUE NO ES LA MISMA CLAVE A" + DataGridView2.CurrentRow.Cells(0).EditedFormattedValue.ToString)
        End If
       

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ENTIDADES.ID_GENERO = Txt_id_genr.Text
        METODOS.ELIMINAR_GENER(ENTIDADES)
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Txt_id_genr.Text = DataGridView2.CurrentRow.Cells(0).EditedFormattedValue.ToString
        Txt_genero.Text = DataGridView2.CurrentRow.Cells(1).EditedFormattedValue.ToString
    End Sub
End Class