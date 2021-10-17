Imports System.Data.OleDb

Public Class Staff

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Umair\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "insert into staff (Name,Qualification,Sub,ContactNo,EmailID,Timing) values ('" & txtName.Text & "','" & txtQualification.Text & "','" & txtSubject.Text & "','" & txtContactNo.Text & "','" & txtEmailID.Text & "','" & txtTiming.Text & "')"

        cmd.ExecuteNonQuery()
        MessageBox.Show("Record inserted ")
        txtStaffID.Text = ""
        txtName.Text = ""
        txtQualification.Text = ""
        txtSubject.Text = ""
        txtContactNo.Text = ""
        txtEmailID.Text = ""
        txtTiming.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Umair\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "delete from staff where Name='" & txtName.Text & "'"

        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted ")
        txtStaffID.Text = ""
        txtName.Text = ""
        txtQualification.Text = ""
        txtSubject.Text = ""
        txtContactNo.Text = ""
        txtEmailID.Text = ""
        txtTiming.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "update Staff set [Name]='" & txtName.Text & "',[Qualification]='" & txtQualification.Text & "',[Sub]='" & txtSubject.Text & "',[ContactNo]='" & txtContactNo.Text & "',[Timing]=#" & txtTiming.Text & "#, [EmailID]='" & txtEmailID.Text & "' where [Name]='" & txtName.Text & "'"

        cmd.ExecuteNonQuery()
        MessageBox.Show("Record Updated ")
        txtStaffID.Text = ""
        txtName.Text = ""
        txtQualification.Text = ""
        txtSubject.Text = ""
        txtContactNo.Text = ""
        txtEmailID.Text = ""
        txtTiming.Text = ""
    End Sub

    Private Sub Staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from Staff where [Name]='" & txtName.Text & "'"
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        ' Dim dt As New DataTable
        ' dt.Load(dr)
        ' DataGridView1.DataSource = dt
        ' DataGridView1.Refresh()
        If dr.Read Then
            txtStaffID.Text = dr(0).ToString
            txtQualification.Text = dr(2).ToString
            txtSubject.Text = dr(3).ToString
            txtContactNo.Text = dr(4).ToString
            txtTiming.Text = Convert.ToDateTime(dr(6).ToString()).ToShortTimeString



            txtEmailID.Text = dr(5).ToString
        End If
    End Sub
End Class