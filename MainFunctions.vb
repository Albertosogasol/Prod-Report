'Imports System.Data.OleDb
Imports System.Net
Imports System.Runtime.CompilerServices

Module MainFunctions
    'Main functions module
    Public Function conStringBuilder() As String
        Dim dbProvider As String
        Dim dbSource As String
        dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0; "

        'BD BUENA
        dbSource = "Data Source=RUTA_DE_BASE_DATOS" 'VALOR A MODIFICAR SI CAMBIA LA RUTA'

        'BD con contraseña
        'dbSource = "Data Source=RUTA_DE_BASE_DATOS;Persist Security Info=True;Jet OLEDB:Database Password=CONTRASEÑA"

        Dim con As String
        con = dbProvider & dbSource

        conStringBuilder = con
    End Function
    Public Function connOleDbBuilder(con As String) As OleDb.OleDbConnection
        connOleDbBuilder = New OleDb.OleDbConnection(con)
        'Para construirla completamente desde otra clase usar:
        'Dim (nombreVariable) As New OleDbConnection(query, MainFunctions.connOleDbBuilder(MainFunctions.conStringBuilder()))
    End Function

    Public Function WeekNumber(argDate As Date) As Integer
        'Devuelve el número de semana del año de la fecha pasada por argumento
        Dim weekNum As Integer
        weekNum = DatePart(DateInterval.WeekOfYear, argDate, FirstDayOfWeek.Friday.Monday, FirstWeekOfYear.FirstFourDays)
        Return weekNum
    End Function

    Public Function GetUsername() As String
        Dim username As String
        username = SystemInformation.UserName
        Return username
    End Function

    Public Function GetHostname() As String
        Dim hostname As String
        hostname = SystemInformation.ComputerName
        Return hostname
    End Function

    Public Function GetIpAddress() As String
        Dim ip As String
        ip = Dns.GetHostByName(GetHostname()).AddressList(0).ToString()
        Return ip
    End Function

End Module
