Imports MySql.Data.MySqlClient
Imports Module1

Public Class Form1

    Dim sqlQuery As String
    Dim da As New MySqlDataAdapter
    Dim dt As DataTable
    Dim conn As New MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click

        Me.Close()
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        Try
            sqlQuery = "SELECT * FROM employee"
            da = New MySqlDataAdapter(sqlQuery, conn)

            dt = New DataTable
            da.Fill(dt)

            datarecord.DataSource = dt
            datarecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DbConnect()
        Dim dbname As String = "it2a"
        Dim username As String = "root"
        Dim password As String = "admin"
        Dim server As String = "127.0.0.1"

        ' Establish new connection
        conn.ConnectionString = "server=" & server & ";user id=" & username & ";password=" & password & ";database=" & dbname

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open() ' Open connection
                MsgBox("Connected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Form2.Show()
        Me.Hide() 'hide form 2

    End Sub
End Class
