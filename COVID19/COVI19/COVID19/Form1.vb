Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)



    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        Me.Close()
    End Sub

    Private Sub gas_Click(sender As Object, e As EventArgs) Handles gas.Click
        If txt_alm.Text = "" And txt_nama.Text = "" And txt_umur.Text = "" And rd_pria.Checked = False And rd_wanita.Checked = False Then
            MsgBox("Harap Isi data terlebih dahulu", MsgBoxStyle.Critical, "ISI DATA")
        Else
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        data.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
