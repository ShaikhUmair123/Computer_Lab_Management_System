Imports System.Data.OleDb

Public Class login

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from UserLogin where [Name]='" & txtName.Text & "' and [Password]=" & txtPassword.Text & ""
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        ' Dim dt As New DataTable
        ' dt.Load(dr)
        ' DataGridView1.DataSource = dt
        ' DataGridView1.Refresh()
        If dr.Read Then
            'txtName.Text = dr(0).ToString
            'txtPassword.Text = dr(1).ToString
            Me.Hide()
            MessageBox.Show("Login Successfull")
            MainMenu.Show()
        Else

            MessageBox.Show("Invalid username password")

        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub
End Class