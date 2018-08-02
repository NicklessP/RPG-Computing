Public Class Form1
    Dim GrossXP, LevelUp As Integer
    Public EXP1, EXP2, EXP3 As Integer
    Public Level As Integer = 1
    Dim SaveLocal As String = My.Application.Info.DirectoryPath + "\save.txt"
    Dim BoxItems1, BoxItems2, BoxItems3 As Boolean


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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnComplete1.Click
        ListBox1.Items.Clear()
        btnComplete1.Enabled = False
        GrossXP += EXP1
        If pgbExprienceBar.Value + EXP1 >= pgbExprienceBar.Maximum Then
            pgbExprienceBar.Value = 0
            Level += 1
            Label6.Text = Level
            Label1.Text = pgbExprienceBar.Value
            MsgBox("You leveled up")
            pgbExprienceBar.Maximum = Level * 100
        Else
            pgbExprienceBar.Value += EXP1
            Label1.Text = pgbExprienceBar.Value
            pgbExprienceBar.Maximum = Level * 100
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnComplete2.Click
        ListBox2.Items.Clear()
        btnComplete2.Enabled = False
        GrossXP += EXP2
        LevelUp = pgbExprienceBar.Value + EXP2
        If LevelUp >= 100 Then
            LevelUp = 0
            pgbExprienceBar.Value = 0
            Level += 1
            Label6.Text = Level
            Label1.Text = pgbExprienceBar.Value
            MsgBox("You leveled up")
            pgbExprienceBar.Maximum = Level * 100
        Else
            pgbExprienceBar.Value += EXP2
            Label1.Text = pgbExprienceBar.Value
            pgbExprienceBar.Maximum = Level * 100
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnComplete3.Click
        ListBox3.Items.Clear()
        btnComplete3.Enabled = False
        GrossXP += EXP2
        LevelUp = pgbExprienceBar.Value + EXP2
        If LevelUp >= 100 Then
            LevelUp = 0
            pgbExprienceBar.Value = 0
            Level += 1
            Label6.Text = Level
            Label1.Text = pgbExprienceBar.Value
            MsgBox("You leveled up")
            pgbExprienceBar.Maximum = Level * 100
        Else
            pgbExprienceBar.Value += EXP3
            Label1.Text = pgbExprienceBar.Value
            pgbExprienceBar.Maximum = Level * 100
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If System.IO.File.Exists(SaveLocal) = True Then
            Dim objWriter As New System.IO.StreamWriter(SaveLocal)
            objWriter.Write("Level: " & Level)
            objWriter.Write(vbNewLine & "Experience: " & pgbExprienceBar.Value)
            objWriter.Write(vbNewLine & "Task1 Data:")
            If ListBox1.Items.Count > 0 Then

                For i = 0 To ListBox1.Items.Count - 1
                    objWriter.Write(vbNewLine & ListBox1.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If

            objWriter.Write(vbNewLine & "Task2 Data:")
            If ListBox2.Items.Count > 0 Then

                For i = 0 To ListBox2.Items.Count - 1
                    objWriter.Write(vbNewLine & ListBox2.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If
            If ListBox3.Items.Count > 0 Then
                objWriter.Write(vbNewLine & "Task3 Data:")
                For i = 0 To ListBox3.Items.Count - 1
                    objWriter.Write(vbNewLine & ListBox3.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If

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
            If ListBox1.Items.Count > 0 Then

                For i = 0 To ListBox1.Items.Count - 1
                    objWriter.Write(vbNewLine & ListBox1.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If

            objWriter.Write(vbNewLine & "Task2 Data:")
            If ListBox2.Items.Count > 0 Then

                For i = 0 To ListBox2.Items.Count - 1
                    objWriter.Write(vbNewLine & ListBox2.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If
            If ListBox3.Items.Count > 0 Then
                objWriter.Write(vbNewLine & "Task3 Data:")
                For i = 0 To ListBox3.Items.Count - 1
                    objWriter.Write(vbNewLine & ListBox3.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If

            objWriter.Write(vbNewLine & "Stockpiled XP for 1: " & EXP1)
            objWriter.Write(vbNewLine & "Stockpiled XP for 2: " & EXP2)
            objWriter.Write(vbNewLine & "Stockpiled XP for 3: " & EXP3)
            objWriter.Write(vbNewLine & "GrossXP: " & pgbExprienceBar.Value)
            objWriter.Write(vbNewLine & "LevelUp: " & LevelUp)
            objWriter.Close()
            MsgBox("Game Saved")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objReader As New System.IO.StreamReader(SaveLocal)
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        Level = objReader.ReadLine.Remove(0, 7)
        pgbExprienceBar.Maximum = Level * 100
        pgbExprienceBar.Value = objReader.ReadLine.Remove(0, 12)
        objReader.ReadLine()
        ListBox1.Items.Add(objReader.ReadLine)
        ListBox1.Items.Add(objReader.ReadLine)
        ListBox1.Items.Add(objReader.ReadLine)
        ListBox1.Items.Add(objReader.ReadLine)
        objReader.ReadLine()
        ListBox2.Items.Add(objReader.ReadLine)
        ListBox2.Items.Add(objReader.ReadLine)
        ListBox2.Items.Add(objReader.ReadLine)
        ListBox2.Items.Add(objReader.ReadLine)
        objReader.ReadLine()
        ListBox3.Items.Add(objReader.ReadLine)
        ListBox3.Items.Add(objReader.ReadLine)
        ListBox3.Items.Add(objReader.ReadLine)
        ListBox3.Items.Add(objReader.ReadLine)
        EXP1 = objReader.ReadLine.Remove(0, 21)
        EXP2 = objReader.ReadLine.Remove(0, 21)
        EXP3 = objReader.ReadLine.Remove(0, 21)
        GrossXP = objReader.ReadLine.Remove(0, 9)
        LevelUp = objReader.ReadLine.Remove(0, 9)
        Label1.Text = pgbExprienceBar.Value
        Label6.Text = Level

        If ListBox1.Items(1) = "" Then
            ListBox1.Items.Clear()
        Else
            btnComplete1.Enabled = True
        End If

        If ListBox2.Items(1) = "" Then
            ListBox2.Items.Clear()
        Else
            btnComplete2.Enabled = True
        End If

        If ListBox3.Items(1) = "" Then
            ListBox3.Items.Clear()
        Else
            btnComplete3.Enabled = True
        End If


    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)



    End Sub



End Class
