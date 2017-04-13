Imports System.Data.SqlClient
Imports System.Data
Public Class OPERACIONES
    Dim RES As Integer
    Dim CON As String
    Dim CONECTAR As SqlConnection
    'Conexion con la base de datos
    Public Sub conexiones()
        CON = ("Data Source=izma-pc;Initial Catalog=LIBRERIA_SIGLO_XXI;User ID=sa;Password=ismael1234")
        CONECTAR = New SqlConnection(CON)
        CONECTAR.Open()
    End Sub
    'end conexion

    'Initialization function multiplicar
    Public Function MULTIPLICAR(X As Integer, Y As Integer)
        RES = X * Y
        Return RES
    End Function
    'end function

    'Initialization function buscar
    Public Function buscar(ByVal cadena2 As String)
        Dim ver As New SqlDataAdapter(cadena2, CONECTAR)
        Dim tabla As New DataTable
        ver.Fill(tabla)
        Return tabla
    End Function
    'End function

End Class
