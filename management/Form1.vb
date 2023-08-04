
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form1
    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        connectDatabase()
        Try
            sql = "INSERT INTO studenttb (fname, lname, age, course) VALUES ('" & TxtFname.Text & "', '" & TxtLname.Text & "', '" & TxtAge.Text & "', '" & TxtCourse.Text & "')"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader


            MsgBox("New Record Added Successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit? ", "Student App", MessageBoxButtons.YesNo
                                )
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BtnConn_Click(sender As Object, e As EventArgs) Handles BtnConn.Click
        connectDatabase()

    End Sub


End Class
