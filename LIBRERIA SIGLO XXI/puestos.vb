﻿Imports System.Data
Imports System.Data.SqlClient
Imports CAPA_ACCESO_DE_DATOS
Imports CAPA_ENTIDAD
Public Class puestos
    Dim ENTIDADES As New ENTIDAD_AUTORES
    Dim METODOS As New METODOS
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim CON As String
        CON = "server = izma-pc ;database = LIBRERIA_SIGLO_XXI ;user id = sa ; pwd = ismael1234;"
        Dim CONECTAR As SqlConnection

        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()


        Dim CODIGO As String
        CODIGO = "SELECT *FROM TBL_PUESTOS"

        Dim X As SqlDataAdapter
        Dim XY As DataTable
        XY = New DataTable

        X = New SqlDataAdapter(CODIGO, CONECTAR)
        X.Fill(XY)
        DataGridView1.DataSource = XY
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
   
            ENTIDADES.ID_PUESTO = TextBox1.Text
            ENTIDADES.PUESTO = TextBox2.Text
        METODOS.RegistraPuesto(ENTIDADES)
    End Sub
End Class