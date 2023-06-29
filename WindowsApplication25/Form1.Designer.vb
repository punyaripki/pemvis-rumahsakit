<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.nim = New System.Windows.Forms.TextBox()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.jurusan = New System.Windows.Forms.TextBox()
        Me.txt_angkatan = New System.Windows.Forms.TextBox()
        Me.cari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(108, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(455, 191)
        Me.DataGridView1.TabIndex = 0
        '
        'nim
        '
        Me.nim.Location = New System.Drawing.Point(271, 12)
        Me.nim.Name = "nim"
        Me.nim.Size = New System.Drawing.Size(100, 26)
        Me.nim.TabIndex = 1
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(271, 61)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(100, 26)
        Me.nama.TabIndex = 2
        '
        'jurusan
        '
        Me.jurusan.Location = New System.Drawing.Point(271, 103)
        Me.jurusan.Name = "jurusan"
        Me.jurusan.Size = New System.Drawing.Size(100, 26)
        Me.jurusan.TabIndex = 3
        '
        'txt_angkatan
        '
        Me.txt_angkatan.Location = New System.Drawing.Point(271, 146)
        Me.txt_angkatan.Name = "txt_angkatan"
        Me.txt_angkatan.Size = New System.Drawing.Size(100, 26)
        Me.txt_angkatan.TabIndex = 4
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(271, 217)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(100, 26)
        Me.cari.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(191, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(191, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Angkatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 220)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Cari"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = " insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(424, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 36)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(424, 105)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 38)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(424, 149)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 32)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(424, 217)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 26)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 570)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cari)
        Me.Controls.Add(Me.txt_angkatan)
        Me.Controls.Add(Me.jurusan)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.nim)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents nim As System.Windows.Forms.TextBox
    Friend WithEvents nama As System.Windows.Forms.TextBox
    Friend WithEvents jurusan As System.Windows.Forms.TextBox
    Friend WithEvents txt_angkatan As System.Windows.Forms.TextBox
    Friend WithEvents cari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
