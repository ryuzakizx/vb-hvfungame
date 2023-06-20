<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMudah
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
        Me.components = New System.ComponentModel.Container()
        Me.PBKalimantan = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPermainan = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCek1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PBSumatera = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblWaktuMudah = New System.Windows.Forms.Label()
        Me.LblScoreMudah = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCek2 = New System.Windows.Forms.Button()
        CType(Me.PBKalimantan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBSumatera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBKalimantan
        '
        Me.PBKalimantan.Image = Global.UAS_TEK_GAME_HVFUN.My.Resources.Resources.pulau_kalimantan
        Me.PBKalimantan.Location = New System.Drawing.Point(97, 100)
        Me.PBKalimantan.Name = "PBKalimantan"
        Me.PBKalimantan.Size = New System.Drawing.Size(432, 226)
        Me.PBKalimantan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBKalimantan.TabIndex = 0
        Me.PBKalimantan.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "APA NAMA PULAU DI ATAS ??"
        '
        'tbPermainan
        '
        Me.tbPermainan.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPermainan.Location = New System.Drawing.Point(132, 472)
        Me.tbPermainan.Name = "tbPermainan"
        Me.tbPermainan.Size = New System.Drawing.Size(349, 39)
        Me.tbPermainan.TabIndex = 2
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(132, 553)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(128, 47)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(499, 38)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "TEBAK GAMBAR - PROVINSI/PULAU"
        '
        'btnCek1
        '
        Me.btnCek1.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCek1.Location = New System.Drawing.Point(353, 553)
        Me.btnCek1.Name = "btnCek1"
        Me.btnCek1.Size = New System.Drawing.Size(128, 47)
        Me.btnCek1.TabIndex = 5
        Me.btnCek1.Text = "CEK"
        Me.btnCek1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'PBSumatera
        '
        Me.PBSumatera.Image = Global.UAS_TEK_GAME_HVFUN.My.Resources.Resources.pulau_sumatera
        Me.PBSumatera.Location = New System.Drawing.Point(97, 100)
        Me.PBSumatera.Name = "PBSumatera"
        Me.PBSumatera.Size = New System.Drawing.Size(432, 226)
        Me.PBSumatera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBSumatera.TabIndex = 6
        Me.PBSumatera.TabStop = False
        Me.PBSumatera.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Waktu :"
        '
        'LblWaktuMudah
        '
        Me.LblWaktuMudah.AutoSize = True
        Me.LblWaktuMudah.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWaktuMudah.Location = New System.Drawing.Point(445, 343)
        Me.LblWaktuMudah.Name = "LblWaktuMudah"
        Me.LblWaktuMudah.Size = New System.Drawing.Size(74, 29)
        Me.LblWaktuMudah.TabIndex = 8
        Me.LblWaktuMudah.Text = "00:00"
        '
        'LblScoreMudah
        '
        Me.LblScoreMudah.AutoSize = True
        Me.LblScoreMudah.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScoreMudah.Location = New System.Drawing.Point(186, 341)
        Me.LblScoreMudah.Name = "LblScoreMudah"
        Me.LblScoreMudah.Size = New System.Drawing.Size(26, 29)
        Me.LblScoreMudah.TabIndex = 9
        Me.LblScoreMudah.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Score :"
        '
        'btnCek2
        '
        Me.btnCek2.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCek2.Location = New System.Drawing.Point(353, 553)
        Me.btnCek2.Name = "btnCek2"
        Me.btnCek2.Size = New System.Drawing.Size(128, 47)
        Me.btnCek2.TabIndex = 11
        Me.btnCek2.Text = "CEK"
        Me.btnCek2.UseVisualStyleBackColor = True
        Me.btnCek2.Visible = False
        '
        'frmMudah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(633, 658)
        Me.Controls.Add(Me.btnCek2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblScoreMudah)
        Me.Controls.Add(Me.LblWaktuMudah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PBSumatera)
        Me.Controls.Add(Me.btnCek1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.tbPermainan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PBKalimantan)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMudah"
        Me.Text = ":: Permainan - Mudah"
        CType(Me.PBKalimantan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBSumatera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBKalimantan As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPermainan As System.Windows.Forms.TextBox
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCek1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PBSumatera As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblWaktuMudah As System.Windows.Forms.Label
    Friend WithEvents LblScoreMudah As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCek2 As System.Windows.Forms.Button
End Class
