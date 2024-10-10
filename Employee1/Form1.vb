Imports MySql.Data.MySqlClient
Imports Module1
Public Class Form1

    Dim sqlQuery As String
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Try
            DbConnect()
            sqlQuery = " Select * from employee "
            da = New MySqlDataAdapter(sqlQuery, Module1.conn)


            dt = New DataTable
            'fill the data from mysql table
            da.Fill(dt)

            'set the srouce of datagrid voew
            datarecord.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class
