Public Class Form1
    Dim g As Graphics
    Dim rys As Boolean
    Dim p As New Pen(Color.Blue, 2)
    Dim x, y, x0, y0 As Single

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics()

    End Sub

    Private Sub CzyszczenieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CzyszczenieToolStripMenuItem.Click
        g.Clear(Me.BackColor)
    End Sub

    Private Sub KoniecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KoniecToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        rys = True
        x0 = e.X
        y0 = e.Y
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        rys = False
        
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If rys Then
            x = e.X
            y = e.Y

            g.DrawLine(p, x0, y0, x, y)
            x0 = x
            y0 = y

        End If
    End Sub

    Private Sub KolorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KolorToolStripMenuItem.Click
        Dim ColorDialog1 As New ColorDialog()
        ColorDialog1.ShowDialog()
        p.Color = ColorDialog1.Color
    End Sub

   
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        p.Width = 1
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        p.Width = 2
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        p.Width = 3
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        p.Width = 4
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        p.Width = 5
    End Sub
End Class
