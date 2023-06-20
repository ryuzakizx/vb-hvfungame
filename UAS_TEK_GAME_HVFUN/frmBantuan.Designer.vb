<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBantuan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cara Bermain/ Peraturan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(610, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1. Pilih salah satu tipe kesulitan (Mudah, Sedang, Sulit)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(522, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2. Perbedaan antara kesulit berada pada *detik"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(574, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "3. Tebak dan jawablah pertanyaan yang diberikan !!"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(491, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "4. Nilai di bawah 50 = Gagal , 80+ = Berhasil"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(266, 29)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "5. Semoga beruntung !!"
        '
        'btnKembali
        '
        Me.btnKembali.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.Location = New System.Drawing.Point(12, 598)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(143, 48)
        Me.btnKembali.TabIndex = 6
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'frmBantuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(633, 658)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 7.8!)
        Me.Name = "frmBantuan"
        Me.Text = ":: Permainan - Bantuan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
End Class
