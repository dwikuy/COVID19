<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.gas = New System.Windows.Forms.Button()
        Me.rd_wanita = New System.Windows.Forms.RadioButton()
        Me.rd_pria = New System.Windows.Forms.RadioButton()
        Me.txt_alm = New System.Windows.Forms.TextBox()
        Me.txt_umur = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(407, 451)
        Me.Panel3.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_end)
        Me.Panel1.Controls.Add(Me.gas)
        Me.Panel1.Controls.Add(Me.rd_wanita)
        Me.Panel1.Controls.Add(Me.rd_pria)
        Me.Panel1.Controls.Add(Me.txt_alm)
        Me.Panel1.Controls.Add(Me.txt_umur)
        Me.Panel1.Controls.Add(Me.txt_nama)
        Me.Panel1.Controls.Add(Me.lbl_nama)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(405, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 451)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Javanese Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(90, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 42)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "DATA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_end.Font = New System.Drawing.Font("Javanese Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end.Location = New System.Drawing.Point(178, 352)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(102, 42)
        Me.btn_end.TabIndex = 11
        Me.btn_end.Text = "Close"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'gas
        '
        Me.gas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gas.Font = New System.Drawing.Font("Javanese Text", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gas.Location = New System.Drawing.Point(12, 352)
        Me.gas.Name = "gas"
        Me.gas.Size = New System.Drawing.Size(102, 42)
        Me.gas.TabIndex = 10
        Me.gas.Text = "Mulai Cek"
        Me.gas.UseVisualStyleBackColor = True
        '
        'rd_wanita
        '
        Me.rd_wanita.AutoSize = True
        Me.rd_wanita.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_wanita.Location = New System.Drawing.Point(112, 313)
        Me.rd_wanita.Name = "rd_wanita"
        Me.rd_wanita.Size = New System.Drawing.Size(94, 33)
        Me.rd_wanita.TabIndex = 9
        Me.rd_wanita.TabStop = True
        Me.rd_wanita.Text = "Perempuan"
        Me.rd_wanita.UseVisualStyleBackColor = True
        '
        'rd_pria
        '
        Me.rd_pria.AutoSize = True
        Me.rd_pria.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rd_pria.Location = New System.Drawing.Point(15, 313)
        Me.rd_pria.Name = "rd_pria"
        Me.rd_pria.Size = New System.Drawing.Size(92, 33)
        Me.rd_pria.TabIndex = 8
        Me.rd_pria.TabStop = True
        Me.rd_pria.Text = "Laki - Laki"
        Me.rd_pria.UseVisualStyleBackColor = True
        '
        'txt_alm
        '
        Me.txt_alm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_alm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_alm.Location = New System.Drawing.Point(12, 235)
        Me.txt_alm.Name = "txt_alm"
        Me.txt_alm.Size = New System.Drawing.Size(216, 20)
        Me.txt_alm.TabIndex = 7
        '
        'txt_umur
        '
        Me.txt_umur.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_umur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_umur.Location = New System.Drawing.Point(12, 161)
        Me.txt_umur.Name = "txt_umur"
        Me.txt_umur.Size = New System.Drawing.Size(216, 20)
        Me.txt_umur.TabIndex = 6
        '
        'txt_nama
        '
        Me.txt_nama.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nama.Location = New System.Drawing.Point(12, 101)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(216, 20)
        Me.txt_nama.TabIndex = 5
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nama.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(12, 78)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(55, 31)
        Me.lbl_nama.TabIndex = 4
        Me.lbl_nama.Text = "Nama :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Umur :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Javanese Text", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISI FORMULIR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(407, 452)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_end As Button
    Friend WithEvents gas As Button
    Friend WithEvents rd_wanita As RadioButton
    Friend WithEvents rd_pria As RadioButton
    Friend WithEvents txt_alm As TextBox
    Friend WithEvents txt_umur As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents lbl_nama As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
