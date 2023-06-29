Imports System.Data.SqlClient
Public Class Form1
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim ds As DataSet
    Dim rd As SqlDataReader
    Dim mydb As String
    Sub konekssi()
        mydb = "data source = PUNYARIPKI; initial catalog = PraktikumPemvis; integrated security = true"
        conn = New SqlConnection(mydb)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub clear()
        nim.Clear()
        nama.Clear()
        txt_angkatan.Clear()
        jurusan.Clear()
    End Sub

    Private Sub kondisiawal()
        Call konekssi()
        Call clear()
        da = New SqlDataAdapter("Select * from tb_mhs", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_mhs")
        DataGridView1.DataSource = (ds.Tables("tb_mhs"))
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call konekssi()
        da = New SqlDataAdapter("Select * from tb_mhs", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tb_mhs")
        DataGridView1.DataSource = (ds.Tables("tb_mhs"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If nim.Text = "" Or nama.Text = "" Or jurusan.Text = "" Or txt_angkatan.Text = "" Then
            MsgBox("lengkapi data dulu deckk", MsgBoxStyle.Critical, "failed")
        Else
            Call konekssi()
            Dim inputdata As String = "INSERT INTO tb_mhs VALUES ('" & nim.Text & "','" & nama.Text & "','" & jurusan.Text & "','" & txt_angkatan.Text & "')"
            cmd = New SqlCommand(inputdata, conn)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("data berhasil dek", MsgBoxStyle.Information, "information")
                Call kondisiawal()
            Catch ex As Exception
                MsgBox("error deck " & ex.Message, MsgBoxStyle.Critical, "failed")

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Call konekssi()
        Dim updatedata As String = "UPDATE tb_mhs ('" & nim.Text & "," & nama.Text & "," & jurusan.Text & "," & txt_angkatan.Text & "," '")
        cmd = New SqlCommand(updatedata, conn)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("data berhasil dek", MsgBoxStyle.Information, "information")
                Call kondisiawal()
            Catch ex As Exception
                MsgBox("error deck " & ex.Message, MsgBoxStyle.Critical, "failed")

            End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call konekssi()
        Dim deletedata As String = "SELECT * FROM tb_mhs where nim.Text & " '"
        cmd = New SqlCommand(deletedata, conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil dek", MsgBoxStyle.Information, "information")
            Call kondisiawal()
        Catch ex As Exception
            MsgBox("error deck " & ex.Message, MsgBoxStyle.Critical, "failed")

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call konekssi()
        cmd = New SqlCommand("SELECT * FROM tb_mhs where id_pasien='" & cari.Text & "'", conn)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("data berhasil dek", MsgBoxStyle.Information, "information")
            Call kondisiawal()
        Catch ex As Exception
            MsgBox("error deck " & ex.Message, MsgBoxStyle.Critical, "failed")

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub
End Class
