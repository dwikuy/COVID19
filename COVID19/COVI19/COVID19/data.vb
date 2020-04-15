Imports MySql.Data.MySqlClient

Public Class data
    Sub dgvdata()
        Call con()
        da = New MySqlDataAdapter("select nama, umur,j_kelamin, alamat,hasil, penilaian from pasien", cn)
        ds = New DataSet
        da.Fill(ds, "pasien")
        dgvpasien.DataSource = ds.Tables("pasien")
    End Sub

    Private Sub data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call dgvdata()
        Form1.Hide()
    End Sub

    Private Sub dgvpasien_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpasien.CellContentClick
        da = New MySqlDataAdapter("select nama, umur, alamat, penilaian from pasien", cn)
        ds = New DataSet
        da.Fill(ds, "pasien")
        dgvpasien.DataSource = ds.Tables("pasien")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class