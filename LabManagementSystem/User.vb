Imports System.Data.OleDb
Public Class User

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Umair\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "insert into UserLogin ([Name],[Password],[ContactNo]) values ('" & txtName.Text & "'," & txtPassword.Text & ",'" & txtContactNo.Text & "')"

        cmd.ExecuteNonQuery()
        MessageBox.Show("Saved Successfull ")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class