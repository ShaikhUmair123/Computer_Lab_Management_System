Imports System.Data.OleDb
Imports System.Data

Public Class Report2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        If RadioButton2.Checked Then
            cmd.CommandText = "select * from Staff where [Name]='" & txtTeacher.Text & "'"
        Else
            cmd.CommandText = "select * from Staff "

        End If

        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
        'If dr.Read Then
        '    txtStaffID.Text = dr(0).ToString
        '    txtName.Text = dr(1).ToString
        '    txtQualification.Text = dr(2).ToStrings
        '    txtSubject.Text = dr(3).ToString
        '    txtContactNo.Text = dr(4).ToString
        '    txtLabTiming.Text = dr(5).ToString
        '    txtEmailID.Text = dr(6).ToString

        'End If
    End Sub

    Private Sub Report2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from Staff "
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)

        txtTeacher.DataSource = dt
        txtTeacher.DisplayMember = "Name"
        txtTeacher.Refresh()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class