Public Class Form1
    Dim GrossXP As Integer
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
        GrossXP += Form2.EXP1
        Label1.Text = Form2.EXP1

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ListBox2.Items.Clear()
        CheckBox2.Enabled = False
        CheckBox2.CheckState = False
        GrossXP += Form2.EXP2
        Label1.Text = GrossXP

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        ListBox3.Items.Clear()
        CheckBox3.Enabled = False
        CheckBox3.CheckState = False
        GrossXP += Form2.EXP3
        Label1.Text = GrossXP

    End Sub
End Class
