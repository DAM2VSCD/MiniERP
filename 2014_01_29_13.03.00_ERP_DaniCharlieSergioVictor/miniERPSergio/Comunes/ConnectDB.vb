﻿Imports Oracle.DataAccess.Client

Public Class ConnectDB

    Const driver As String = "Data Source=(DESCRIPTION =" _
    + "(ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = LOCALHOST)(PORT = 1521)))" _
    + "(CONNECT_DATA = (SERVICE_NAME = ORADAM2))); " _
    + "User Id=minierp; Password=minierp;"
    '=======================================================================================================
    ReadOnly Property getData(ByVal query As String, ByVal table As String) As DataSet
        Get
            Dim objConexion As OracleConnection
            Dim objComando As OracleDataAdapter
            Dim requestquery As New DataSet

            objConexion = New OracleConnection(driver)
            objConexion.Open()
            objComando = New OracleDataAdapter(query, objConexion)
            objComando.Fill(requestquery, table)
            objConexion.Close()
            Return requestquery
        End Get
    End Property
    Sub setData(ByVal statement As String)

        Dim objconexion As OracleConnection
        Dim objcomando As OracleCommand

        objconexion = New OracleConnection(driver)
        objconexion.Open()
        objcomando = New OracleCommand(statement, objconexion)

        objcomando.ExecuteNonQuery()

        objcomando.Connection.Close()

    End Sub
    ReadOnly Property DLookUp(ByVal column As String, ByVal table As String, ByVal condition As String) As Object
        Get

            Dim objconexion As oracleconnection
            Dim objcomando As oracledataadapter
            Dim requestquery As New DataSet
            Dim result As Object

            objconexion = New oracleconnection(driver)
            objconexion.open()
            If condition = "" Then
                objcomando = New oracledataadapter("select " & column & " from " & table, objconexion)
            Else
                objcomando = New oracledataadapter("select " & column & " from " & table & " where " & condition, objconexion)
            End If

            objcomando.fill(requestquery)
            Try
                result = requestquery.Tables(0).Rows(0)(requestquery.Tables(0).Columns.IndexOf(column))
            Catch ex As Exception
                result = -1

            End Try
            objconexion.close()
            Return result
        End Get
    End Property

End Class

