<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beranda
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
        Me.btnMudah = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblBantuan = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaShell
        Me.Label1.Location = New System.Drawing.Point(180, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 100)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HAVE FUN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaShell
        Me.Label2.Location = New System.Drawing.Point(256, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pilih Level :"
        '
        'btnMudah
        '
        Me.btnMudah.Font = New System.Drawing.Font("Trebuchet MS", 19.8!, System.Drawing.FontStyle.Bold)
        Me.btnMudah.Location = New System.Drawing.Point(302, 234)
        Me.btnMudah.Name = "btnMudah"
        Me.btnMudah.Size = New System.Drawing.Size(176, 92)
        Me.btnMudah.TabIndex = 2
        Me.btnMudah.Text = "Mudah"
        Me.btnMudah.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UAS_TEK_GAME_HVFUN.My.Resources.Resources.cewe_menunjukan
        Me.PictureBox1.Location = New System.Drawing.Point(66, 172)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 399)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'LblBantuan
        '
        Me.LblBantuan.AutoSize = True
        Me.LblBantuan.Location = New System.Drawing.Point(536, 621)
        Me.LblBantuan.Name = "LblBantuan"
        Me.LblBantuan.Size = New System.Drawing.Size(99, 28)
        Me.LblBantuan.TabIndex = 6
        Me.LblBantuan.Text = "Bantuan"
        '
        'Beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(633, 658)
        Me.Controls.Add(Me.LblBantuan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMudah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe MDL2 Assets", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Beranda"
        Me.Text = "Beranda"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMudah As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LblBantuan As System.Windows.Forms.Label

End Class
