Public Class Form1
    Dim GrossXP, LevelUp As Integer
    Public EXP1, EXP2, EXP3 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Task_Create_Click(sender As Object, e As EventArgs) Handles btn_Task_Create.Click
        Form2.Show()
    End Sub

    Private Sub ExpreienceBar_Click(sender As Object, e As EventArgs) Handles pgbExprienceBar.Click


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        ListBox1.Items.Clear()
        CheckBox1.Enabled = False
        CheckBox1.CheckState = False
        GrossXP += EXP1
        LevelUp += EXP1
        If LevelUp >= 100 Then
            LevelUp = 0
            pgbExprienceBar.Value = 0
        End If
        pgbExprienceBar.Value += EXP1
        Label1.Text = pgbExprienceBar.Value

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        ListBox1.Items.Clear()
        CheckBox1.Enabled = False
        CheckBox1.CheckState = False
        GrossXP += EXP2

        pgbExprienceBar.Value += EXP2
        If pgbExprienceBar.Value >= 100 Then
            pgbExprienceBar.Value = 0
        End If
        Label1.Text = pgbExprienceBar.Value


    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        ListBox1.Items.Clear()
        CheckBox1.Enabled = False
        CheckBox1.CheckState = False
        GrossXP += EXP3

        pgbExprienceBar.Value += EXP3
        If pgbExprienceBar.Value >= 100 Then
            pgbExprienceBar.Value = 0
        End If
        Label1.Text = pgbExprienceBar.Value

    End Sub
End Class
