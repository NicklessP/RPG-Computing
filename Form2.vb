Public Class Form2
    Dim difficulty As Integer
    Dim time As Integer
    Dim MHD As String
    Dim task As String
    Dim name As String
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Label5.Text = HScrollBar1.Value
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        HScrollBar1.Maximum = 33
        Form1.pgbExprienceBar.Maximum = 100
        Form1.pgbExprienceBar.Value = Form1.pgbExprienceBar.Value + 10        HScrollBar1.Value = 1
        Label5.Text = HScrollBar1.Value
        MHD = "Hours"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        HScrollBar1.Maximum = 99
        HScrollBar1.Value = 1
        Label5.Text = HScrollBar1.Value
        MHD = "Minutes"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        HScrollBar1.Maximum = 23
        HScrollBar1.Value = 1
        Label5.Text = HScrollBar1.Value
        MHD = "Days"
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar2.Scroll
        Label6.Text = HScrollBar2.Value
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.Value = 1
        HScrollBar2.Value = 1
        Label6.Text = HScrollBar2.Value
        Label5.Text = HScrollBar1.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        difficulty = HScrollBar2.Value
        time = HScrollBar1.Value
        name = TextBox1.Text
        Me.Close()
        MsgBox("Task: " & name & vbNewLine & "Difficulty: " & difficulty & vbNewLine & "Length: " & time & " " & MHD & vbNewLine & "Type: " & task)
        If Form1.ListBox1.Items.Count = 0 Then
            Form1.ListBox1.Items.Add("Task: " & name)
            Form1.ListBox1.Items.Add("Difficulty: " & difficulty)
            Form1.ListBox1.Items.Add("Length: " & time & " " & MHD)
            Form1.ListBox1.Items.Add("Type: " & task)
        ElseIf Form1.ListBox2.Items.Count = 0 Then
            Form1.ListBox2.Items.Add("Task: " & name)
            Form1.ListBox2.Items.Add("Difficulty: " & difficulty)
            Form1.ListBox2.Items.Add("Length: " & time & " " & MHD)
            Form1.ListBox2.Items.Add("Type: " & task)
        ElseIf Form1.ListBox3.Items.Count = 0 Then
            Form1.ListBox3.Items.Add("Task: " & name)
            Form1.ListBox3.Items.Add("Difficulty: " & difficulty)
            Form1.ListBox3.Items.Add("Length: " & time & " " & MHD)
            Form1.ListBox3.Items.Add("Type: " & task)
        Else
            MsgBox("Please finish a task")
        End If
        Form1.pgbExprienceBar.Maximum = 100
        Form1.pgbExprienceBar.Value = Form1.pgbExprienceBar.Value + 10
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        task = ComboBox1.Text
    End Sub
End Class
