Imports System.Data.OleDb
Imports System.Data
Public Class LabMaster

    Private Sub LabMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
       
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Umair\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "insert into LabMaster (LabNo,CompQty,LabSub,LabInsName,LabTiming) values ('" & txtLabNo.Text & "','" & txtCompQty.Text & "','" & txtLabSub.Text & "','" & txtLabIns.Text & "','" & txtLabTiming.Text & "')"

        cmd.ExecuteNonQuery()
        MessageBox.Show("Record inserted ")
        txtLabNo.Text = ""
        txtCompQty.Text = ""
        txtLabSub.Text = ""
        txtLabIns.Text = ""
        txtLabTiming.Text = ""


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Umair\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "delete from LabMaster where LabNo=" & txtLabNo.Text & ""

        cmd.ExecuteNonQuery()
        MessageBox.Show("Record deleted ")
        txtLabNo.Text = ""
        txtCompQty.Text = ""
        txtLabSub.Text = ""
        txtLabIns.Text = ""
        txtLabTiming.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "update LabMaster set [LabNo]=" & txtLabNo.Text & ",[CompQty]=" & txtCompQty.Text & ",[LabSub]='" & txtLabSub.Text & "',[LabTiming]=#" & txtLabTiming.Text & "# where [LabInsName]='" & txtLabIns.Text & "'"

        cmd.ExecuteNonQuery()
        MessageBox.Show("Record Updated ")
        txtLabNo.Text = ""
        txtCompQty.Text = ""
        txtLabSub.Text = ""
        txtLabIns.Text = ""
        txtLabTiming.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand

        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con

        cmd.CommandText = "select * from LabMaster where [LabInsName]='" & txtLabIns.Text & "'"
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        ' Dim dt As New DataTable
        'dt.Load(dr)
        'DataGridView1.DataSource = dt
        'DataGridView1.Refresh()
        If dr.Read Then
            txtLabNo.Text = dr(0).ToString
            txtCompQty.Text = dr(1).ToString
            txtLabSub.Text = dr(2).ToString
            txtLabTiming.Text = Convert.ToDateTime(dr(4).ToString()).ToShortTimeString
        End If

    End Sub
End Class