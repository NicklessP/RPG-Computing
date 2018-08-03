Public Class Form2
    'Initialize variables
    Dim difficulty As Integer
    Dim time As Integer
    Dim MHD As String
    Dim task As String
    Dim name As String
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbLength.Scroll
        lblLength.Text = hsbLength.Value
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rtnHours.CheckedChanged
        'Scrollbar maximum is strange, the real maximum is the .maximum - 9, this block changes time to days
        hsbLength.Maximum = 33
        hsbLength.Value = 1
        lblLength.Text = hsbLength.Value
        MHD = "Hours"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rtnMinutes.CheckedChanged
        'Scrollbar maximum is strange, the real maximum is the .maximum - 9, this block changes time to minutes
        hsbLength.Maximum = 99
        hsbLength.Value = 1
        lblLength.Text = hsbLength.Value
        MHD = "Minutes"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rtnDays.CheckedChanged
        'Scrollbar maximum is strange, the real maximum is the .maximum - 9, this block changes time to hours
        hsbLength.Maximum = 23
        hsbLength.Value = 1
        lblLength.Text = hsbLength.Value
        MHD = "Days"
    End Sub

    Private Sub HScrollBar2_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbDifficulty.Scroll
        lblDifficulty.Text = hsbDifficulty.Value
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets values for scrollbars to begin with
        hsbLength.Value = 1
        hsbDifficulty.Value = 1
        lblDifficulty.Text = hsbDifficulty.Value
        lblLength.Text = hsbLength.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTaskAdd.Click
        'Moves finished item to a listbox in form1 and closes form2
        difficulty = hsbDifficulty.Value
        time = hsbLength.Value
        name = tboTask.Text
        Me.Close()
        MsgBox("Task: " & name & vbNewLine & "Difficulty: " & difficulty & vbNewLine & "Length: " & time & " " & MHD & vbNewLine & "Type: " & task)
        If Form1.lboTask1.Items.Count = 0 Then

            Form1.lboTask1.Items.Add("Task: " & name)
            Form1.lboTask1.Items.Add("Difficulty: " & difficulty)
            Form1.lboTask1.Items.Add("Length: " & time & " " & MHD)
            Form1.lboTask1.Items.Add("Type: " & task)
            Form1.btnComplete1.Enabled = True
            'Graphical equation that doesn't allow the EXP to go over 100 and so the value slowly creeps up to 100
            If MHD = "Minutes" Then
                Form1.EXP1 = (100000 / ((-1 * difficulty * time) - 1000)) + Form1.pgbExperienceBar.Maximum
            ElseIf MHD = "Hours" Then
                Form1.EXP1 = (100000 / ((-1 * difficulty * time * 60) - 1000)) + Form1.pgbExperienceBar.Maximum
            ElseIf MHD = "Days" Then
                Form1.EXP1 = (100000 / ((-1 * difficulty * time) - 1000 * 60 * 24)) + Form1.pgbExperienceBar.Maximum
            Else
                MsgBox("Error Calculating Experience")
            End If

            'Same as above but for task 2
        ElseIf Form1.lboTask2.Items.Count = 0 Then

            Form1.lboTask2.Items.Add("Task: " & name)
            Form1.lboTask2.Items.Add("Difficulty: " & difficulty)
            Form1.lboTask2.Items.Add("Length: " & time & " " & MHD)
            Form1.lboTask2.Items.Add("Type: " & task)
            Form1.btnComplete2.Enabled = True
            If MHD = "Minutes" Then
                Form1.EXP2 = (100000 / ((-1 * difficulty * time) - 1000)) + Form1.pgbExperienceBar.Maximum
            ElseIf MHD = "Hours" Then
                Form1.EXP2 = (100000 / ((-1 * difficulty * time * 60) - 1000)) + Form1.pgbExperienceBar.Maximum
            ElseIf MHD = "Days" Then
                Form1.EXP2 = (100000 / ((-1 * difficulty * time) - 1000 * 60 * 24)) + Form1.pgbExperienceBar.Maximum
            Else
                MsgBox("Error Calculating Experience")
            End If

            'Same as above but for task 3
        ElseIf Form1.lboTask3.Items.Count = 0 Then

            Form1.lboTask3.Items.Add("Task: " & name)
            Form1.lboTask3.Items.Add("Difficulty: " & difficulty)
            Form1.lboTask3.Items.Add("Length: " & time & " " & MHD)
            Form1.lboTask3.Items.Add("Type: " & task)
            Form1.btnComplete3.Enabled = True

            If MHD = "Minutes" Then
                Form1.EXP3 = (100000 / ((-1 * difficulty * time) - 1000)) + Form1.pgbExperienceBar.Maximum / 2
            ElseIf MHD = "Hours" Then
                Form1.EXP3 = (100000 / ((-1 * difficulty * time * 60) - 1000)) + Form1.pgbExperienceBar.Maximum / 2
            ElseIf MHD = "Days" Then
                Form1.EXP3 = (100000 / ((-1 * difficulty * time) - 1000 * 60 * 24)) + Form1.pgbExperienceBar.Maximum / 2
            Else
                MsgBox("Error Calculating Experience")
            End If


        Else
            'Checks to see if there are already 3 tasks
            MsgBox("Please finish a task")
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTask.SelectedIndexChanged
        task = cboTask.Text
    End Sub
End Class