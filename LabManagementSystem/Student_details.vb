Imports System.Data.OleDb


Public Class Student_details

    Private Sub Student_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTimeOut.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "update StudentDetails set [Name]='" & txtName.Text & "',[Class]='" & txtClass.Text & "',[Date]=#" & txtDate.Text & "#,[TimeIn]=#" & txtTimeIn.Text & "#,[Timeout]=#" & txtTimeOut.Text & "#, [PCNo]=" & txtPCNo.Text & ", [LabNo]=" & txtLabNo.Text & ",[Teacher]='" & txtTeacher.Text & "' where [Name]='" & txtName.Text & "'"

        cmd.ExecuteNonQuery()
        MessageBox.Show("Record Updated ")
        txtStudentID.Text = ""
        txtName.Text = ""
        txtClass.Text = ""
        txtDate.Text = ""
        txtTimeIn.Text = ""
        txtTimeOut.Text = ""
        txtPCNo.Text = ""
        txtLabNo.Text = ""
        txtTeacher.Text = ""

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "insert into StudentDetails ([Name],[Class],[Date],[TimeIn],[Timeout],[PCNo],[LabNo],[Teacher]) values ('" & txtName.Text & "','" & txtClass.Text & "',#" & txtDate.Text & "#,#" & txtTimeIn.Text & "#,#" & txtTimeOut.Text & "#," & txtPCNo.Text & "," & txtLabNo.Text & ",'" & txtTeacher.Text & "')"

        cmd.ExecuteNonQuery()
        MessageBox.Show("Record inserted ")
        txtStudentID.Text = ""
        txtName.Text = ""
        txtClass.Text = ""
        txtDate.Text = ""
        txtTimeIn.Text = ""
        txtTimeOut.Text = ""
        txtPCNo.Text = ""
        txtLabNo.Text = ""
        txtTeacher.Text = ""



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Umair\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "delete from StudentDetails where Name='" & txtName.Text & "'"

        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted ")
        txtStudentID.Text = ""
        txtName.Text = ""
        txtClass.Text = ""
        txtDate.Text = ""
        txtTimeIn.Text = ""
        txtTimeOut.Text = ""
        txtPCNo.Text = ""
        txtLabNo.Text = ""
        txtTeacher.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from StudentDetails where [Name]='" & txtName.Text & "'"
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        ' Dim dt As New DataTable
        ' dt.Load(dr)
        ' DataGridView1.DataSource = dt
        ' DataGridView1.Refresh()
        If dr.Read Then
            txtStudentID.Text = dr(0).ToString
            txtClass.Text = dr(2).ToString
            txtDate.Text = Convert.ToDateTime(dr(3).ToString()).ToShortDateString

            txtTimeIn.Text = Convert.ToDateTime(dr(4).ToString()).ToShortTimeString
            txtTimeOut.Text = Convert.ToDateTime(dr(5).ToString()).ToShortTimeString
            txtPCNo.Text = dr(6).ToString
            txtLabNo.Text = dr(7).ToString
            txtTeacher.Text = dr(8).ToString
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
