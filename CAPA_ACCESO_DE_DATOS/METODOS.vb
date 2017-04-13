Imports System.Data.SqlClient

Public Class METODOS
    'Conexion con la base de datos
    Dim BD As New SqlConnection("Data Source=izma-pc;Initial Catalog=LIBRERIA_SIGLO_XXI;User ID=sa;Password=ismael1234")
    Dim RGISTR As New SqlCommand

    '== METODOS DE REGISTRO ==
    'Initialization resgistro de autores
    Public Sub REGISTRO_AUTORES(ByVal ENAUTORES As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("REGISTRA_AUTORES", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@CODA", ENAUTORES.ID_AUTOR)
            .AddWithValue("@NOMBRE", ENAUTORES.NOMBRE)
            .AddWithValue("@APE_MAT", ENAUTORES.APE_MAT)
            .AddWithValue("@APE_PAT", ENAUTORES.APE_PAT)
            .AddWithValue("@ID_PAIS", ENAUTORES.ID_PAIS)

        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    'End function

    'Initialization registro editorial
    Public Sub REGISTRAR_EDI(ByVal REDIS_EDI As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("REGISTRAR_EDITORIAL", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_EDIT", REDIS_EDI.ID_EDITORIAL)
            .AddWithValue("@EDITORIAL", REDIS_EDI.EDITORIAL)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    'End function

    'Initialization Resgistrar genero
    Public Sub REGISTRAR_gener(ByVal REDIS_gener As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("REGISTRAR_genero", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_GENER", REDIS_gener.ID_GENERO)
            .AddWithValue("@GENERO", REDIS_gener.GENERO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    'End function

    'Initialization Registro de Usuarios
    Public Sub REGIS_USUARIO_ENTR(ByVal RESGISTRA_USUARIOS As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("INSERT_USUARIO", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@USUARIO", RESGISTRA_USUARIOS.USUARIO)
            .AddWithValue("@ID_TIP_USER", RESGISTRA_USUARIOS.ID_TIP_USER)
            .AddWithValue("@TIP_USER", RESGISTRA_USUARIOS.TIPO_USER)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    'End function

    'Initialization Registro de libros
    Public Sub REGISTRO_LIBROS(ByVal REGISTRA_LIBROS As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("INSERT_LIBROS", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_LIBRO", REGISTRA_LIBROS.ID_LIBRO)
            .AddWithValue("@NOMBRE_LIBRO", REGISTRA_LIBROS.NOMBRE_LIBRO)
            .AddWithValue("@ID_AUTOR", REGISTRA_LIBROS.ID_AUTOR)
            .AddWithValue("@ID_GENERO", REGISTRA_LIBROS.ID_GENERO)
            .AddWithValue("@ID_EDITORIAL", REGISTRA_LIBROS.ID_EDITORIAL)
            .AddWithValue("@AÑO_EDICION", REGISTRA_LIBROS.AÑO_EDICION)
            .AddWithValue("@PRECIO_UNIT", REGISTRA_LIBROS.PRECIO_UNIT)
            .AddWithValue("@EXISTENCIA", REGISTRA_LIBROS.EXISTENCIA)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    'End function

    'Initialization Registro Usuarios
    Public Sub REGISTR_USER(ByVal REGISTR_USER As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("insert_user", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@RFC_USUARIOS", REGISTR_USER.RFC_USUARIOS)
            .AddWithValue("@NOMBRE", REGISTR_USER.NOMBRE)
            .AddWithValue("@AP_PAT", REGISTR_USER.AP_PAT)
            .AddWithValue("@AP_MAT", REGISTR_USER.AP_MAT)
            .AddWithValue("@SEXO", REGISTR_USER.SEXO)
            .AddWithValue("@FECHA_NAC", REGISTR_USER.FECHA_NAC)
            .AddWithValue("@ID_PUESTO ", REGISTR_USER.ID_PUESTO)
            .AddWithValue("@ID_COMUNIDAD", REGISTR_USER.ID_COMUNIDAD)
            .AddWithValue("@ID_MUNICIPIO", REGISTR_USER.ID_MUNICIPIO)
            .AddWithValue("@ID_ESTADO", REGISTR_USER.ID_ESTADO)
            .AddWithValue("@ID_PAIS", REGISTR_USER.ID_PAIS)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    'end function

    'Initialization Registrar comunidades
    Public Sub REGISTR_COMUNI(ByVal REGISTR_COMUNI As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("INSERT_COMUNIDAD", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_COMUNIDAD", REGISTR_COMUNI.ID_COMUNIDAD)
            .AddWithValue("@COMUNIDAD", REGISTR_COMUNI.COMUNIDAD)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    'End function 

    'Initialization Registrar pais
    Public Sub REGISTR_PAIS(ByVal REGISTR_PAIS As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("INSERT_PAIS", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_PAIS", REGISTR_PAIS.ID_PAIS)
            .AddWithValue("@PAIS", REGISTR_PAIS.PAIS)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    'End Function

    'Initialization Registrar puesto
    Public Sub RegistraPuesto(ByVal RegistraPuesto As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("INSERT_PUESTO", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_P", RegistraPuesto.ID_PUESTO)
            .AddWithValue("@P", RegistraPuesto.PUESTO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    'End function

    'Initialization function Registar Estado
    Public Sub RegistarEstados(ByVal RegistraUser As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("INSERT_ESTADO", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_ESTADO", RegistraUser.ID_ESTADO)
            .AddWithValue("@ESTADO", RegistraUser.ESTADO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    'End function

    'Initialization function Registar Municipio
    Public Sub RegistrarMunicipio(ByVal RegistroMunicipio As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("INSERT_MUNICIPIO", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_MUNICIPIO", RegistroMunicipio.ID_MUNICIPIO)
            .AddWithValue("@MUNICIPIO", RegistroMunicipio.MUNICIPIO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    'End function

    'Initialization function Registro Ventas
    Public Sub RegistroVentas(ByVal Ventas As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("INSERT_VENTAS", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_VENTA", Ventas.ID_VENTA)
            .AddWithValue("@ID_LIBRO", Ventas.ID_LIBRO)
            .AddWithValue("@ID_AUTOR", Ventas.ID_AUTOR)
            .AddWithValue("@ID_GENERO", Ventas.ID_GENERO)
            .AddWithValue("@ID_EDITORIAL", Ventas.ID_EDITORIAL)
            .AddWithValue("@RFC_USUARIOS", Ventas.RFC_USUARIOS)
            .AddWithValue("@CLIENTE", Ventas.CLIENTE)
            .AddWithValue("@FECHA_VENTA", Ventas.FECHA_VENTA)
            .AddWithValue("@NUM_EJEMPLARES", Ventas.NUM_EJEMPLARES)
            .AddWithValue("@TOTAL_DE_COMPRA", Ventas.TOTAL_DE_COMPRA)

        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    'End Function

    'Initialization function Cancelacion
    Public Sub Cancelacion(ByVal cancelacion As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("CANCELACIONES", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_CANCELACION", cancelacion.ID_CANCELACION)
            .AddWithValue("@ID_VENTA", cancelacion.ID_VENTA)
            .AddWithValue("@ID_TIPO_CANCELACION", cancelacion.ID_TIPO_CANCELACION)
            .AddWithValue("@ID_LIBRO", cancelacion.ID_LIBRO)
            .AddWithValue("@ID_AUTOR", cancelacion.ID_AUTOR)
            .AddWithValue("@ID_GENERO", cancelacion.ID_GENERO)
            .AddWithValue("@ID_EDITORIAL", cancelacion.ID_EDITORIAL)
            .AddWithValue("@RFC_USUARIOS", cancelacion.RFC_USUARIOS)
            .AddWithValue("@FECHA_VENTA", cancelacion.FECHA_VENTA)
            .AddWithValue("@TOTAL_DE_COMPRA", cancelacion.TOTAL_DE_COMPRA)
            .AddWithValue("@NUM_CANCELACIONES", cancelacion.NUM_CANCELACIONES)

        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub


    'METODOS PARA GENERAR CODIGO
    'Initialization function genera id
    Public Function generarcodigo() As Integer
        BD.Open()
        RGISTR = New SqlCommand("AUTOGENERA_CODIGO_VENTAS", BD)
        Dim parame As New SqlParameter("@ID_VENTA", SqlDbType.Int)
        parame.Direction = ParameterDirection.Output
        With RGISTR
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add(parame)
            .ExecuteNonQuery()
            BD.Close()

            Return .Parameters("@ID_VENTA").Value
        End With
    End Function
    'End  Function

    'Initialization function genera IdUsuarios
    Public Function GeneraIdUsers() As Integer
        BD.Open()
        RGISTR = New SqlCommand("GERACODIGO_USUARIO", BD)
        Dim PARAM As New SqlParameter("@USUARIO", SqlDbType.Int)
        PARAM.Direction = ParameterDirection.Output
        With RGISTR
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add(PARAM)
            .ExecuteNonQuery()
            BD.Close()

            Return .Parameters("@USUARIO").Value
        End With
    End Function
    'End Function

    'Initialization function generaIdUsers
    Public Function GENERA_CODI_USERS() As Integer
        BD.Open()
        RGISTR = New SqlCommand("GERACODIGO_USERS", BD)
        Dim PARAMETRR As New SqlParameter("@RFC_USUARIOS", SqlDbType.Int)
        PARAMETRR.Direction = ParameterDirection.Output
        With RGISTR
            .CommandType = CommandType.StoredProcedure
            .Parameters.Add(PARAMETRR)
            .ExecuteNonQuery()
            BD.Close()

            Return .Parameters("@RFC_USUARIOS").Value
        End With
    End Function
    'End function


    '== METODOS DE EDITAR DATOS ==
    Public Sub EDITAR_AUTORES(ByVal EDI_AUTORES As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("EDITAR_AUTORES", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@CODA", EDI_AUTORES.ID_AUTOR)
            .AddWithValue("@NOMBRE", EDI_AUTORES.NOMBRE)
            .AddWithValue("@APE_MAT", EDI_AUTORES.APE_MAT)
            .AddWithValue("@APE_PAT", EDI_AUTORES.APE_PAT)
            .AddWithValue("@ID_PAIS", EDI_AUTORES.ID_PAIS)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    Public Sub MODIFICAR_EDITORIALES(ByVal MODIFICAREDITO As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("MODIFICAR_EDITO", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_EDITORIAL", MODIFICAREDITO.ID_EDITORIAL)
            .AddWithValue("@EDITORIAL", MODIFICAREDITO.EDITORIAL)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    Public Sub MODIFICAR_GENER(ByVal MODIGENERO As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("MODIFICAR_GENE", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_GENE", MODIGENERO.ID_GENERO)
            .AddWithValue("@GENER", MODIGENERO.GENERO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    Public Sub MODIFICAR_USUARIOS(ByVal MODIFICR_USUARIO As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("MODIFICAR_USUARIOS", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@USUARIO", MODIFICR_USUARIO.USUARIO)
            .AddWithValue("@ID_TIP_USER", MODIFICR_USUARIO.ID_TIP_USER)
            .AddWithValue("@TIPO_USER", MODIFICR_USUARIO.TIPO_USER)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    Public Sub MODIFICAR_LIBROS(ByVal MODIFICAR_LIBR As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("MODIFICAR_LIBROS", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_LIBRO", MODIFICAR_LIBR.ID_LIBRO)
            .AddWithValue("@NOMBRE_LIBRO", MODIFICAR_LIBR.NOMBRE_LIBRO)
            .AddWithValue("@ID_AUTOR", MODIFICAR_LIBR.ID_AUTOR)
            .AddWithValue("@ID_GENERO", MODIFICAR_LIBR.ID_GENERO)
            .AddWithValue("@ID_EDITORIAL", MODIFICAR_LIBR.ID_EDITORIAL)
            .AddWithValue("@AÑO_EDICION", MODIFICAR_LIBR.AÑO_EDICION)
            .AddWithValue("@PRECIO_UNIT", MODIFICAR_LIBR.PRECIO_UNIT)
            .AddWithValue("@EXISTENCIA", MODIFICAR_LIBR.EXISTENCIA)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    Public Sub MODIFICAR_USER(ByVal MODIFICAR_USER As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("MODIFICAR_USER", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@RFC_USUARIOS", MODIFICAR_USER.RFC_USUARIOS)
            .AddWithValue("@NOMBRE", MODIFICAR_USER.NOMBRE)
            .AddWithValue("@AP_PAT", MODIFICAR_USER.AP_PAT)
            .AddWithValue("@AP_MAT", MODIFICAR_USER.AP_MAT)
            .AddWithValue("@SEXO", MODIFICAR_USER.SEXO)
            .AddWithValue("@FECHA_NAC", MODIFICAR_USER.FECHA_NAC)
            .AddWithValue("@ID_PUESTO ", MODIFICAR_USER.ID_PUESTO)
            .AddWithValue("@ID_COMUNIDAD", MODIFICAR_USER.ID_COMUNIDAD)
            .AddWithValue("@ID_MUNICIPIO", MODIFICAR_USER.ID_MUNICIPIO)
            .AddWithValue("@ID_ESTADO", MODIFICAR_USER.ID_ESTADO)
            .AddWithValue("@ID_PAIS", MODIFICAR_USER.ID_PAIS)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub


    '== METODOS PARA ELIMINAR ==

    Public Sub eliminarautores(ByVal ELI_AUTORES As CAPA_ENTIDAD.ENTIDAD_AUTORES)


        BD.Open()
        RGISTR = New SqlCommand("eliminar_autores", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_AUTOR", ELI_AUTORES.ID_AUTOR)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    Public Sub ELIMINAR_EDITORIALES(ByVal ELIMINAR_EDITORI As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("BORRAR_EDITORIALES", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_EDITORIAL", ELIMINAR_EDITORI.ID_EDITORIAL)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    Public Sub ELIMINAR_GENER(ByVal ELIMINAR_GENE As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("BORRAR_GENER", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_GENE", ELIMINAR_GENE.ID_GENERO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    Public Sub ELIMINAR_USUARIOS_ENT(ByVal ELIMINAR_USUAR_ENT As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("BORRAR_USUARIOS", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@USUARIO", ELIMINAR_USUAR_ENT.USUARIO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    Public Sub ELIMINAR_LIBROS(ByVal ELIMINACION_DE_LIBRS As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("BORRAR_LIBROS", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_LIBRO", ELIMINACION_DE_LIBRS.ID_LIBRO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()

    End Sub
    Public Sub ELIMINAR_USER(ByVal ELIMINACION_DE_USERS As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("ELIMINACION_CLIENT", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@RFC_USUARIOS ", ELIMINACION_DE_USERS.RFC_USUARIOS)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    Public Sub ELIMINAR_COMUNIDD(ByVal elimar_comuni As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("ELIMINACION_COMUNIDAD", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_COMUNIDAD", elimar_comuni.ID_COMUNIDAD)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()


    End Sub
    'End function

    'Initialization function Eliminar Estado
    Public Sub EliminarEstado(ByVal DeleteEstado As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("ELIMINACION_ESTADO", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_ESTADO", DeleteEstado.ID_ESTADO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    'Ed function

    'Initialization function EliminarMunicipio
    Public Sub EliminarMunicipio(ByVal DeleteMunicipio As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("ELIMINACION_MUNICIPIO", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_MUNICIPIO", DeleteMunicipio.ID_MUNICIPIO)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub
    'End function

    'Initialization Function Eliminarventa
    Public Sub EliminarVentas(ByVal DeleteVenta As CAPA_ENTIDAD.ENTIDAD_AUTORES)
        BD.Open()
        RGISTR = New SqlCommand("ELIMINACION_VENTA", BD)
        RGISTR.CommandType = CommandType.StoredProcedure
        With RGISTR.Parameters
            .AddWithValue("@ID_VENTA", DeleteVenta.ID_VENTA)
        End With
        RGISTR.ExecuteNonQuery()
        BD.Close()
    End Sub 'End Funtion



End Class
