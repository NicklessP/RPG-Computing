Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Task_Create_Click(sender As Object, e As EventArgs) Handles btn_Task_Create.Click
        Form2.Show()
    End Sub

    Private Sub ExpreienceBar_Click(sender As Object, e As EventArgs) Handles pgbExprienceBar.Click
        Dim x As Form2 = New Form2
        x.Show()

    End Sub
End Class

