Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Form2
    Dim covid As String
    Dim y, t As Boolean
    Dim gender As String
    Dim gerak As Integer
    Sub bersih()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        txt_hasil.Text = ""
        txt_jumlah.Text = ""
    End Sub
    Sub jalan()
        If CheckBox1.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox2.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox3.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox4.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox5.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox6.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox7.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox8.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox9.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox11.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox12.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox13.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox14.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox15.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox16.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox17.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox18.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox19.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox20.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox21.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If
        If CheckBox22.Checked = True Then
            y = True + 1
        Else
            t = False + 0
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_jumlah.Text = (Val(CheckBox1.Checked) - Val(CheckBox2.Checked) - Val(CheckBox3.Checked) - Val(CheckBox4.Checked) - Val(CheckBox5.Checked) - Val(CheckBox6.Checked) - Val(CheckBox7.Checked) - Val(CheckBox8.Checked) - Val(CheckBox9.Checked) - Val(CheckBox10.Checked) - Val(CheckBox11.Checked) - Val(CheckBox12.Checked) - Val(CheckBox13.Checked) - Val(CheckBox14.Checked) - Val(CheckBox15.Checked) - Val(CheckBox16.Checked) - Val(CheckBox17.Checked) - Val(CheckBox18.Checked) - Val(CheckBox19.Checked) - Val(CheckBox20.Checked) - Val(CheckBox21.Checked))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_jumlah.Text <= 7 Then
            txt_hasil.Text = "Rendah"
        ElseIf txt_jumlah.Text <= 14 Then
            txt_hasil.Text = "Normal"
        ElseIf txt_jumlah.Text <= 21 Then
            txt_hasil.Text = "Tinggi"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call bersih()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        covid = txt_covid.Text
        lbl_nm.Text = Form1.txt_nama.Text
        lbl_umur.Text = Form1.txt_umur.Text
        lbl_alm.Text = Form1.txt_alm.Text
        Label35.Text = Form1.txt_nama.Text
        Timer1.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call con()
        cn.Open()
        Try
            If Form1.rd_pria.Checked = True Then
                gender = Form1.rd_pria.Text
            ElseIf Form1.rd_wanita.Checked = True Then
                gender = Form1.rd_wanita.Text
            End If
            Dim str As String
            str = "INSERT INTO pasien(nama, umur,j_kelamin, alamat, hasil, penilaian) VALUES ('" & lbl_nm.Text & "','" & Form1.txt_umur.Text & "', '" & gender & "','" & Form1.txt_alm.Text & "', '" & txt_jumlah.Text & "', '" & txt_hasil.Text & "')"
            Dim cmd As New MySqlCommand(str, cn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Insert Data Pasien Berhasil Dilakukan")
            Call bersih()
        Catch ex As Exception
            MessageBox.Show("Insert data Pasien gagal dilakukan.")
        End Try
        Form1.txt_nama.Text = ""
        Form1.txt_umur.Text = ""
        Form1.txt_alm.Text = ""
        Form1.rd_pria.Checked = False
        Form1.rd_wanita.Checked = False
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Call con()

        Try
            cn.Open()
            MessageBox.Show("Sukses")
        Catch ex As Exception
            MessageBox.Show("Gagal")
        End Try
    End Sub

    Private Sub lbl_umur_Click(sender As Object, e As EventArgs) Handles lbl_umur.Click

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txt_covid.Text = gerak
        covid = Microsoft.VisualBasic.Right(covid, Len(covid) - 1) & Microsoft.VisualBasic.Left(covid, 1)
        txt_covid.Text = covid
    End Sub

    Sub lari()

        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call con()

        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = covid
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        Form1.txt_nama.Text = ""
        Form1.txt_umur.Text = ""
        Form1.txt_alm.Text = ""
        txt_hasil.Text = ""
        txt_jumlah.Text = ""


    End Sub
End Class