Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Module Module1
    Public sql As String
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public ds As New DataSet
    Public ada As New MySqlDataAdapter

    Public conn As New MySqlConnection

    Public Sub connectDatabase()
        conn.Close()
        Try
            conn.ConnectionString = "server=localhost; database=vu; user=root; password=;"
            conn.Open()

            MsgBox("connection successful", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
