Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim modeGambar As String
    Dim warnaTepi As Color = Color.Black
    Dim warnaIsian As Color = Color.White
    Dim tepi As New System.Drawing.Pen(warnaTepi, 2)
    Dim isian As New System.Drawing.SolidBrush(warnaIsian)
    Dim titik As Point = Nothing
    Dim polygonPoints(5) As Point
    Dim hatchBrush As Drawing2D.HatchBrush
    Dim dipencet As Boolean = False
    Dim bmp As Bitmap
    Dim namaFile As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnBersihkan.PerformClick()
        tepi.EndCap = LineCap.Round
    End Sub

    Private Sub cmbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMode.SelectedIndexChanged
        modeGambar = cmbMode.SelectedItem.ToString
    End Sub

    Private Sub cmbUkuran_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUkuran.SelectedIndexChanged
        Dim ukuran As String = cmbUkuran.SelectedItem
        Dim pecah() As Char = ukuran.ToCharArray
        Dim uk As String
        For Each ch As Char In pecah
            If Char.IsDigit(ch) Then
                'MsgBox(ch)
                uk += ch.ToString
            End If
        Next
        tepi.Width = uk.ToString
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        tepi.Color = warnaTepi
        isian.Color = warnaIsian
        titik = e.Location
        dipencet = True
    End Sub
    Private Sub Warna1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna1.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna1.BackColor
            pnlWarnaTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna1.BackColor
            pnlWarnaIsi.BackColor = warnaIsian
        End If
    End Sub
    Private Sub Warna2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna2.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna2.BackColor
            pnlWarnaTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna2.BackColor
            pnlWarnaIsi.BackColor = warnaIsian
        End If
    End Sub

    Private Sub Warna3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna3.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna3.BackColor
            pnlWarnaTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna3.BackColor
            pnlWarnaIsi.BackColor = warnaIsian
        End If
    End Sub

    Private Sub Warna4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna4.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna4.BackColor
            pnlWarnaTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna4.BackColor
            pnlWarnaIsi.BackColor = warnaIsian
        End If
    End Sub

    Private Sub Warna5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna5.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna5.BackColor
            pnlWarnaTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna5.BackColor
            pnlWarnaIsi.BackColor = warnaIsian
        End If
    End Sub

    Private Sub Warna6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Warna6.MouseDown
        If e.Button <> MouseButtons.Right Then
            warnaTepi = Warna6.BackColor
            pnlWarnaTepi.BackColor = warnaTepi
        Else
            warnaIsian = Warna6.BackColor
            pnlWarnaIsi.BackColor = warnaIsian
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Select Case modeGambar
            Case "Brush Bebas"
                If dipencet Then

                End If
            Case "Hatch Forward Diagonal"
                If dipencet Then
                    hatchBrush = New HatchBrush(HatchStyle.ForwardDiagonal, warnaIsian, Color.White)
                    Dim newPen As New Pen(hatchBrush, tepi.Width)
                    newPen.StartCap = LineCap.Round
                    newPen.EndCap = LineCap.Round
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(newPen, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()
                    titik = e.Location
                End If
            Case "Hatch Dotted Grid"
                If dipencet Then
                    hatchBrush = New HatchBrush(HatchStyle.DottedGrid, warnaIsian, Color.White)
                    Dim newPen As New Pen(hatchBrush, tepi.Width)
                    newPen.StartCap = LineCap.Round
                    newPen.EndCap = LineCap.Round
                    Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                        g.DrawLine(newPen, titik, e.Location)
                    End Using
                    PictureBox1.Invalidate()
                    titik = e.Location
                End If
        End Select
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Select Case modeGambar
            Case "Polygon"
                polygonPoints(0) = New Point(50, 150)
                polygonPoints(1) = New Point(20, 65)
                polygonPoints(2) = New Point(100, 10)
                polygonPoints(3) = New Point(175, 65)
                polygonPoints(4) = New Point(150, 150)
                polygonPoints(5) = New Point(50, 150)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.DrawPolygon(tepi, polygonPoints)
                End Using
            Case "Polygon Fill"
                polygonPoints(0) = New Point(50, 150)
                polygonPoints(1) = New Point(20, 65)
                polygonPoints(2) = New Point(100, 10)
                polygonPoints(3) = New Point(175, 65)
                polygonPoints(4) = New Point(150, 150)
                polygonPoints(5) = New Point(50, 150)
                hatchBrush = New Drawing2D.HatchBrush(HatchStyle.BackwardDiagonal, warnaTepi, warnaIsian)
                Using g As Graphics = Graphics.FromImage(PictureBox1.Image)
                    g.FillPolygon(hatchBrush, polygonPoints)
                    g.DrawPolygon(tepi, polygonPoints)
                End Using
        End Select
        PictureBox1.Invalidate()
        dipencet = False
    End Sub
    Private Sub btnBersihkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBersihkan.Click
        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.White)
        End Using
        PictureBox1.Image = bmp
    End Sub
End Class
