Public Class Form2
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label5.Text = HScrollBar1.Value
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        HScrollBar1.Maximum = 33
        HScrollBar1.Value = 24
        Label5.Text = HScrollBar1.Value
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        HScrollBar1.Maximum = 99
        HScrollBar1.Value = 90
        Label5.Text = HScrollBar1.Value
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        HScrollBar1.Maximum = 23
        HScrollBar1.Value = 14
        Label5.Text = HScrollBar1.Value
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Label6.Text = HScrollBar2.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        'Bring Experience points from Form 2 back to Form 1
        Form1.pgbExprienceBar.Value = 10
    End Sub
End Class
