Imports System.Data
Imports System.Data.SqlClient

Public Class solicitar_compras

    Private Sub solicitar_compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'LIBRERIA_SIGLO_XXIDataSet3.SOLICITAR_PRODUC' Puede moverla o quitarla según sea necesario.
        Me.SOLICITAR_PRODUCTableAdapter.Fill(Me.LIBRERIA_SIGLO_XXIDataSet3.SOLICITAR_PRODUC)
        Dim dtFecha As Date
        dtFecha = DateTime.Today
        Me.TextBox1.Text = dtFecha.ToString("dddd d 'de'  MMMM 'del año' yyyy")
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles ComboBox1.Click
        Dim LISTATABLAS As List(Of String) = New List(Of String)
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()

        Dim CODIGO As String
        CODIGO = "select  NOMBRE +' '+AP_PAT+' '+AP_MAT from TBL_USERS where  ID_PUESTO ='PROVE'"
        Dim X As SqlCommand = New SqlCommand(CODIGO, CONECTAR)
        Dim Y As SqlDataReader = X.ExecuteReader()
        While (Y.Read())
            LISTATABLAS.Add(Y(0).ToString())
        End While

        ComboBox1.DataSource = LISTATABLAS
        CONECTAR.Close()
    End Sub

    Private Sub Btnsolicitar_Click(sender As Object, e As EventArgs)

    End Sub
End Class