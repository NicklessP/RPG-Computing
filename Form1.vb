Public Class Form1
    Dim GrossXP, LevelUp As Integer
    Public EXP1, EXP2, EXP3 As Integer
    Public Level As Integer = 1
    Dim SaveLocal As String = My.Application.Info.DirectoryPath + "\save.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Task_Create_Click(sender As Object, e As EventArgs) Handles btn_Task_Create.Click
        Form2.Show()
    End Sub
    Private Sub btnAccCard_Click(sender As Object, e As EventArgs) Handles btnAccCard.Click
        'Form3.Show()
    End Sub
    Private Sub ExpreienceBar_Click(sender As Object, e As EventArgs) Handles pgbExprienceBar.Click


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If System.IO.File.Exists(SaveLocal) = True Then
            Dim objWriter As New System.IO.StreamWriter(SaveLocal)
            objWriter.Write("Level: " & Level)
            objWriter.Write(vbNewLine & "Experience: " & pgbExprienceBar.Value)
            objWriter.Write(vbNewLine & "Task1 Data:")
            For i = 0 To ListBox1.Items.Count - 1
                objWriter.Write(vbNewLine & ListBox1.Items(i))
            Next
            objWriter.Write(vbNewLine & "Task2 Data:")
            For i = 0 To ListBox2.Items.Count - 1
                objWriter.Write(vbNewLine & ListBox2.Items(i))
            Next
            objWriter.Write(vbNewLine & "Task3 Data:")
            For i = 0 To ListBox3.Items.Count - 1
                objWriter.Write(vbNewLine & ListBox3.Items(i))
            Next
            objWriter.Write(vbNewLine & "Stockpiled XP for 1: " & EXP1)
            objWriter.Write(vbNewLine & "Stockpiled XP for 2: " & EXP2)
            objWriter.Write(vbNewLine & "Stockpiled XP for 3: " & EXP3)
            objWriter.Write(vbNewLine & "GrossXP: " & GrossXP)
            objWriter.Write(vbNewLine & "LevelUp: " & LevelUp)
            objWriter.Close()
            MsgBox("Game Saved")

        Else
            System.IO.File.Create(SaveLocal).Dispose()
            MsgBox("Save File Created")
            Dim objWriter As New System.IO.StreamWriter(SaveLocal)
            objWriter.Write("Level: " & Level)
            objWriter.Write(vbNewLine & "Experience: " & pgbExprienceBar.Value)
            objWriter.Write(vbNewLine & "Task1 Data:")
            For i = 0 To ListBox1.Items.Count - 1
                objWriter.Write(vbNewLine & ListBox1.Items(i))
            Next
            objWriter.Write(vbNewLine & "Task2 Data:")
            For i = 0 To ListBox2.Items.Count - 1
                objWriter.Write(vbNewLine & ListBox2.Items(i))
            Next
            objWriter.Write(vbNewLine & "Task3 Data:")
            For i = 0 To ListBox3.Items.Count - 1
                objWriter.Write(vbNewLine & ListBox3.Items(i))
            Next
            objWriter.Write(vbNewLine & "Stockpiled XP for 1: " & EXP1)
            objWriter.Write(vbNewLine & "Stockpiled XP for 2: " & EXP2)
            objWriter.Write(vbNewLine & "Stockpiled XP for 3: " & EXP3)
            objWriter.Write(vbNewLine & "GrossXP: " & GrossXP)
            objWriter.Write(vbNewLine & "LevelUp: " & LevelUp)
            objWriter.Close()
            MsgBox("Game Saved")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objReader As New System.IO.StreamReader(SaveLocal)
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        ListBox1.Items.Clear()
        CheckBox1.Enabled = False
        CheckBox1.CheckState = False
        GrossXP += EXP1
        LevelUp = pgbExprienceBar.Value + EXP1
        If LevelUp >= 100 Then
            LevelUp = 0
            pgbExprienceBar.Value = 0
            Level += 1
            Label6.Text = Level
        End If
        pgbExprienceBar.Value += EXP1
        Label1.Text = pgbExprienceBar.Value

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        ListBox2.Items.Clear()
        CheckBox2.Enabled = False
        CheckBox2.CheckState = False
        GrossXP += EXP2
        LevelUp = pgbExprienceBar.Value + EXP2
        If LevelUp >= 100 Then
            LevelUp = 0
            pgbExprienceBar.Value = 0
            Level += 1
            Label6.Text = Level
        End If
        pgbExprienceBar.Value += EXP2
        Label1.Text = pgbExprienceBar.Value

    End Sub


    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged


        ListBox3.Items.Clear()
        CheckBox3.Enabled = False
        CheckBox3.CheckState = False
        GrossXP += EXP3
        LevelUp = pgbExprienceBar.Value + EXP3
        If LevelUp >= 100 Then
            LevelUp = 0
            pgbExprienceBar.Value = 0
            Level += 1
            Label6.Text = Level
        End If
        pgbExprienceBar.Value += EXP3
        Label1.Text = pgbExprienceBar.Value

    End Sub
End Class
