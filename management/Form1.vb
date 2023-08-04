
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form1
    Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
        clear_grid()
        DataGridView1.Columns.Add("Column1", "First Name")
        DataGridView1.Columns.Add("Column2", "Last Name")
        DataGridView1.Columns.Add("Column3", "Age")
        DataGridView1.Columns.Add("Column4", "Course")
        DataGridView1.Rows.Add(TxtFname.Text, TxtLname.Text, TxtAge.Text, TxtCourse.Text)
        add_Record()
        reset_button()

    End Sub

    Public Sub clear_grid()
        'DataGridView1.Rows.Clear()
        ds.Clear()  'clears dataset
        DataGridView1.DataSource = ds
        DataGridView1.DataSource = Nothing

        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
    End Sub

    Public Sub reset_button()
        TxtAge.Clear()
        TxtCourse.Clear()
        TxtFname.Clear()
        TxtLname.Clear()
        TxtFname.Focus()

    End Sub

    Public Sub delete_record()
        connectDatabase()
        Try
            sql = "DELETE FROM studenttb WHERE fname='" & TxtSearch.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            MsgBox("Record Delete Successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub add_Record()
        connectDatabase()
        Try
            sql = "INSERT INTO studenttb (fname, lname, age, course) VALUES ('" & TxtFname.Text & "', '" & TxtLname.Text & "', '" & TxtAge.Text & "', '" & TxtCourse.Text & "');"
            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader

            MsgBox("New Record Added Successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        clear_grid()
        connectDatabase()
        ada = New MySqlDataAdapter("SELECT * FROM studenttb;", conn)
        ada.Fill(ds)

        DataGridView1.DataSource = ds.Tables(0)
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

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        reset_button()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        delete_record()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
