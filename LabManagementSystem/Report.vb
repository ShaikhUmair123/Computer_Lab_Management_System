Imports System.Data.OleDb
Imports System.Data

Public Class Report

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con
        If RadioButton1.Checked Then

            cmd.CommandText = "select * from LabMaster where [LabNo]=" & txtLab.Text & ""
        Else

            cmd.CommandText = "select * from LabMaster"

        End If


        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        'If dr.Read Then
        '    txtLabNo.Text = dr(0).ToString
        '    txtCompQty.Text = dr(1).ToString
        '    txtLabSub.Text = dr(2).ToStrings
        '    txtLabInsName.Text = dr(3).ToString
        '    txtLabTiming.Text = dr(4).ToString
        'End If

    End Sub

    Private Function txtLabNo() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtCompQty() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtLabSub() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtLabInsName() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtLabTiming() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection
        Dim cmd As New OleDbCommand
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Umair\\Documents\Database2.accdb"
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from LabMaster "
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(dr)

        txtLab.DataSource = dt
        txtLab.DisplayMember = "LabNo"
        txtLab.Refresh()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtLab_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLab.SelectedIndexChanged

    End Sub
End Class