Public Class ENTIDAD_AUTORES

    'TABLA AUTORES
    ''Initialization entidades
    Private _ID_AUTOR As String
    Private _NOMBRE As String
    Private _APE_MAT As String
    Private _APE_PAT As String
    Private _ID_PAIS As String

    Public Property ID_AUTOR As String
        Get
            Return _ID_AUTOR
        End Get
        Set(value As String)
            _ID_AUTOR = value
        End Set
    End Property
    Public Property NOMBRE As String
        Get
            Return _NOMBRE
        End Get
        Set(value As String)
            _NOMBRE = value
        End Set
    End Property
    Public Property APE_MAT As String
        Get
            Return _APE_MAT
        End Get
        Set(value As String)
            _APE_MAT = value
        End Set
    End Property
    Public Property APE_PAT As String
        Get
            Return _APE_PAT
        End Get
        Set(value As String)
            _APE_PAT = value
        End Set
    End Property
    Public Property ID_PAIS As String
        Get
            Return _ID_PAIS
        End Get
        Set(value As String)
            _ID_PAIS = value
        End Set
    End Property

    'TABLA EDITORIALES
    Private _ID_EDITORIAL As String
    Private _EDITORIAL As String
    Public Property ID_EDITORIAL As String
        Get
            Return _ID_EDITORIAL
        End Get
        Set(value As String)
            _ID_EDITORIAL = value
        End Set
    End Property
    Public Property EDITORIAL As String
        Get
            Return _EDITORIAL
        End Get
        Set(value As String)
            _EDITORIAL = value
        End Set
    End Property

    'TABLA USUARIOS
    Private _USUARIO As String
    Private _ID_TIP_USER As String
    Private _TIPO_USER As String
    Public Property USUARIO As String
        Get
            Return _USUARIO
        End Get
        Set(value As String)
            _USUARIO = value
        End Set
    End Property
    Public Property ID_TIP_USER As String
        Get
            Return _ID_TIP_USER
        End Get
        Set(value As String)
            _ID_TIP_USER = value
        End Set
    End Property
    Public Property TIPO_USER As String
        Get
            Return _TIPO_USER
        End Get
        Set(value As String)
            _TIPO_USER = value
        End Set
    End Property

    'TABLA LIBROS
    Private _ID_LIBRO As String
    Private _NOMBRE_LIBRO As String
    Private _ID_GENERO As String
    Private _AÑO_EDICION As String
    Private _PRECIO_UNIT As String
    Private _EXISTENCIA As String
    Public Property ID_LIBRO As String
        Get
            Return _ID_LIBRO
        End Get
        Set(value As String)
            _ID_LIBRO = value
        End Set
    End Property
    Public Property NOMBRE_LIBRO As String
        Get
            Return _NOMBRE_LIBRO
        End Get
        Set(value As String)
            _NOMBRE_LIBRO = value
        End Set
    End Property
    Public Property ID_GENERO As String
        Get
            Return _ID_GENERO
        End Get
        Set(value As String)
            _ID_GENERO = value
        End Set
    End Property
    Public Property AÑO_EDICION As String
        Get
            Return _AÑO_EDICION
        End Get
        Set(value As String)
            _AÑO_EDICION = value
        End Set
    End Property
    Public Property PRECIO_UNIT As String
        Get
            Return _PRECIO_UNIT
        End Get
        Set(value As String)
            _PRECIO_UNIT = value
        End Set
    End Property
    Public Property EXISTENCIA As String
        Get
            Return _EXISTENCIA
        End Get
        Set(value As String)
            _EXISTENCIA = value
        End Set
    End Property

    'TABLA USER
    Private _RFC_USUARIOS As String
    Private _AP_PAT As String
    Private _AP_MAT As String
    Private _SEXO As String
    Private _FECHA_NAC As String
    Private _ID_PUESTO As String
    Private _ID_COMUNIDAD As String
    Private _ID_MUNICIPIO As String
    Private _ID_ESTADO As String
    Public Property RFC_USUARIOS As String
        Get
            Return _RFC_USUARIOS
        End Get
        Set(value As String)
            _RFC_USUARIOS = value
        End Set
    End Property
    Public Property AP_PAT As String
        Get
            Return _AP_PAT
        End Get
        Set(value As String)
            _AP_PAT = value
        End Set
    End Property
    Public Property AP_MAT As String
        Get
            Return _AP_MAT
        End Get
        Set(value As String)
            _AP_MAT = value
        End Set
    End Property
    Public Property SEXO As String
        Get
            Return _SEXO
        End Get
        Set(value As String)
            _SEXO = value
        End Set
    End Property
    Public Property FECHA_NAC As String
        Get
            Return _FECHA_NAC
        End Get
        Set(value As String)
            _FECHA_NAC = value
        End Set
    End Property
    Public Property ID_PUESTO As String
        Get
            Return _ID_PUESTO
        End Get
        Set(value As String)
            _ID_PUESTO = value
        End Set
    End Property
    Public Property ID_COMUNIDAD As String
        Get
            Return _ID_COMUNIDAD
        End Get
        Set(value As String)
            _ID_COMUNIDAD = value
        End Set
    End Property
    Public Property ID_MUNICIPIO As String
        Get
            Return _ID_MUNICIPIO
        End Get
        Set(value As String)
            _ID_MUNICIPIO = value
        End Set
    End Property
    Public Property ID_ESTADO As String
        Get
            Return _ID_ESTADO
        End Get
        Set(value As String)
            _ID_ESTADO = value
        End Set
    End Property

    'TABLA LUGARES
    Private _ESTADO As String
    Private _COMUNIDAD As String
    Private _MUNICIPIO As String
    Public Property ESTADO As String
        Get
            Return _ESTADO
        End Get
        Set(value As String)
            _ESTADO = value
        End Set
    End Property
    Public Property COMUNIDAD As String
        Get
            Return _COMUNIDAD
        End Get
        Set(value As String)
            _COMUNIDAD = value
        End Set
    End Property
    Public Property MUNICIPIO As String
        Get
            Return _MUNICIPIO
        End Get
        Set(value As String)
            _MUNICIPIO = value
        End Set
    End Property

    'TBL_PAIS
    Private _PAIS As String
    Public Property PAIS As String
        Get
            Return _PAIS
        End Get
        Set(value As String)
            _PAIS = value
        End Set
    End Property
    'TBL PUESTOS
    Private _PUESTO As String
    Public Property PUESTO As String
        Get
            Return _PUESTO
        End Get
        Set(value As String)
            _PUESTO = value
        End Set
    End Property
    'TBL_VENTAS
    Private _ID_VENTA As String
    Private _AUTOR As String
    Private _GENERO As String
    Private _NUM_EJEMPLARES As String
    Private _TOTAL_DE_COMPRA As String
    Private _CLIENTE As String
    Private _FECHA_VENTA As String
    Private _ID_CANCELACION As String

    Public Property ID_CANCELACION As String
        Get
            Return _ID_CANCELACION
        End Get
        Set(value As String)
            _ID_CANCELACION = value
        End Set
    End Property
    Public Property FECHA_VENTA As String
        Get
            Return _FECHA_VENTA
        End Get
        Set(value As String)
            _FECHA_VENTA = value
        End Set
    End Property
    Public Property CLIENTE As String
        Get
            Return _CLIENTE
        End Get
        Set(value As String)
            _CLIENTE = value
        End Set
    End Property
    Public Property TOTAL_DE_COMPRA As String
        Get
            Return _TOTAL_DE_COMPRA
        End Get
        Set(value As String)
            _TOTAL_DE_COMPRA = value
        End Set
    End Property
    Public Property NUM_EJEMPLARES As String
        Get
            Return _NUM_EJEMPLARES
        End Get
        Set(value As String)
            _NUM_EJEMPLARES = value
        End Set
    End Property
    Public Property ID_VENTA As String
        Get
            Return _ID_VENTA
        End Get
        Set(value As String)
            _ID_VENTA = value
        End Set
    End Property
    Public Property AUTOR As String
        Get
            Return _AUTOR
        End Get
        Set(value As String)
            _AUTOR = value
        End Set
    End Property
    Public Property GENERO As String
        Get
            Return _GENERO
        End Get
        Set(value As String)
            _GENERO = value
        End Set
    End Property

    'TBL_CANCELACION
    Private _ID_TIPO_CANCELACION As String
    Private _NUM_CANCELACIONES As String
    Public Property NUM_CANCELACIONES As Integer
        Get
            Return _NUM_CANCELACIONES
        End Get
        Set(value As Integer)
            _NUM_CANCELACIONES = value
        End Set
    End Property
    Public Property ID_TIPO_CANCELACION As String
        Get
            Return _ID_TIPO_CANCELACION
        End Get
        Set(value As String)
            _ID_TIPO_CANCELACION = value
        End Set
    End Property

End Class
