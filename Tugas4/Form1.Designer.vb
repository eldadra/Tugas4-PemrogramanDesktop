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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.cmbUkuran = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlWarnaTepi = New System.Windows.Forms.Panel()
        Me.pnlWarnaIsi = New System.Windows.Forms.Panel()
        Me.Warna6 = New System.Windows.Forms.Panel()
        Me.Warna5 = New System.Windows.Forms.Panel()
        Me.Warna4 = New System.Windows.Forms.Panel()
        Me.Warna3 = New System.Windows.Forms.Panel()
        Me.Warna2 = New System.Windows.Forms.Panel()
        Me.Warna1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Mode Gambar"
        '
        'cmbMode
        '
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"Polygon", "Polygon Fill", "Brush Bebas", "Hatch Forward Diagonal", "Hatch Dotted Grid"})
        Me.cmbMode.Location = New System.Drawing.Point(126, 22)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(123, 21)
        Me.cmbMode.TabIndex = 1
        '
        'cmbUkuran
        '
        Me.cmbUkuran.FormattingEnabled = True
        Me.cmbUkuran.Items.AddRange(New Object() {"2px", "4px", "6px", "8px", "10px"})
        Me.cmbUkuran.Location = New System.Drawing.Point(357, 25)
        Me.cmbUkuran.Name = "cmbUkuran"
        Me.cmbUkuran.Size = New System.Drawing.Size(140, 21)
        Me.cmbUkuran.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ukuran Pena"
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(571, 28)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(75, 23)
        Me.btnBersihkan.TabIndex = 5
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Warna Tepi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 484)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Warna Isi"
        '
        'pnlWarnaTepi
        '
        Me.pnlWarnaTepi.BackColor = System.Drawing.Color.Black
        Me.pnlWarnaTepi.Location = New System.Drawing.Point(102, 421)
        Me.pnlWarnaTepi.Name = "pnlWarnaTepi"
        Me.pnlWarnaTepi.Size = New System.Drawing.Size(33, 33)
        Me.pnlWarnaTepi.TabIndex = 8
        '
        'pnlWarnaIsi
        '
        Me.pnlWarnaIsi.BackColor = System.Drawing.Color.White
        Me.pnlWarnaIsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlWarnaIsi.Location = New System.Drawing.Point(102, 475)
        Me.pnlWarnaIsi.Name = "pnlWarnaIsi"
        Me.pnlWarnaIsi.Size = New System.Drawing.Size(33, 33)
        Me.pnlWarnaIsi.TabIndex = 9
        '
        'Warna6
        '
        Me.Warna6.BackColor = System.Drawing.Color.Black
        Me.Warna6.Location = New System.Drawing.Point(604, 421)
        Me.Warna6.Name = "Warna6"
        Me.Warna6.Size = New System.Drawing.Size(42, 43)
        Me.Warna6.TabIndex = 19
        '
        'Warna5
        '
        Me.Warna5.BackColor = System.Drawing.Color.White
        Me.Warna5.Location = New System.Drawing.Point(556, 421)
        Me.Warna5.Name = "Warna5"
        Me.Warna5.Size = New System.Drawing.Size(42, 43)
        Me.Warna5.TabIndex = 20
        '
        'Warna4
        '
        Me.Warna4.BackColor = System.Drawing.Color.Blue
        Me.Warna4.Location = New System.Drawing.Point(508, 421)
        Me.Warna4.Name = "Warna4"
        Me.Warna4.Size = New System.Drawing.Size(42, 43)
        Me.Warna4.TabIndex = 18
        '
        'Warna3
        '
        Me.Warna3.BackColor = System.Drawing.Color.Green
        Me.Warna3.Location = New System.Drawing.Point(460, 421)
        Me.Warna3.Name = "Warna3"
        Me.Warna3.Size = New System.Drawing.Size(42, 43)
        Me.Warna3.TabIndex = 17
        '
        'Warna2
        '
        Me.Warna2.BackColor = System.Drawing.Color.Yellow
        Me.Warna2.Location = New System.Drawing.Point(412, 421)
        Me.Warna2.Name = "Warna2"
        Me.Warna2.Size = New System.Drawing.Size(42, 43)
        Me.Warna2.TabIndex = 16
        '
        'Warna1
        '
        Me.Warna1.BackColor = System.Drawing.Color.Red
        Me.Warna1.Location = New System.Drawing.Point(364, 421)
        Me.Warna1.Name = "Warna1"
        Me.Warna1.Size = New System.Drawing.Size(42, 43)
        Me.Warna1.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(15, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(631, 330)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 520)
        Me.Controls.Add(Me.Warna6)
        Me.Controls.Add(Me.Warna5)
        Me.Controls.Add(Me.Warna4)
        Me.Controls.Add(Me.Warna3)
        Me.Controls.Add(Me.Warna2)
        Me.Controls.Add(Me.Warna1)
        Me.Controls.Add(Me.pnlWarnaIsi)
        Me.Controls.Add(Me.pnlWarnaTepi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmbUkuran)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "My Paint"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbMode As ComboBox
    Friend WithEvents cmbUkuran As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlWarnaTepi As Panel
    Friend WithEvents pnlWarnaIsi As Panel
    Friend WithEvents Warna6 As Panel
    Friend WithEvents Warna5 As Panel
    Friend WithEvents Warna4 As Panel
    Friend WithEvents Warna3 As Panel
    Friend WithEvents Warna2 As Panel
    Friend WithEvents Warna1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
