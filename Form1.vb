'***************************** Module Header *******************************
' Module Name:  Form1
' Project:      RPG_Task_Setter
' Name:         Nicholas, Max
'Description    The main form, houses all the main buttons to take you to other forms and houses the tasks


Public Class Form1


    'Initialize variables
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
    Private Sub ExpreienceBar_Click(sender As Object, e As EventArgs) Handles pgbExperienceBar.Click


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnComplete1.Click
        'Finish task on button press, clear listbox, check for level up and award money (Task1)
        lboTask1.Items.Clear()
        btnComplete1.Enabled = False
        GrossXP += EXP1
        If pgbExperienceBar.Value + EXP1 >= pgbExperienceBar.Maximum Then
            pgbExperienceBar.Value = 0
            Level += 1
            Label6.Text = Level
            Label1.Text = pgbExperienceBar.Value
            MsgBox("You leveled up")
            pgbExperienceBar.Maximum = Level * 100
        Else
            pgbExperienceBar.Value += EXP1
            Label1.Text = pgbExperienceBar.Value
            pgbExperienceBar.Maximum = Level * 100
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnComplete2.Click
        'Finish task on button press, clear listbox, check for level up and award money (Task1)
        lboTask2.Items.Clear()
        btnComplete2.Enabled = False
        GrossXP += EXP2
        LevelUp = pgbExperienceBar.Value + EXP2
        If LevelUp >= 100 Then
            LevelUp = 0
            pgbExperienceBar.Value = 0
            Level += 1
            Label6.Text = Level
            Label1.Text = pgbExperienceBar.Value
            MsgBox("You leveled up")
            pgbExperienceBar.Maximum = Level * 100
        Else
            pgbExperienceBar.Value += EXP2
            Label1.Text = pgbExperienceBar.Value
            pgbExperienceBar.Maximum = Level * 100
        End If


    End Sub

    Private Sub btnShop_Click(sender As Object, e As EventArgs) Handles btnShop.Click
        Form4.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnComplete3.Click
        'Finish task on button press, clear listbox, check for level up and award money (Task1)
        lboTask3.Items.Clear()
        btnComplete3.Enabled = False
        GrossXP += EXP2
        LevelUp = pgbExperienceBar.Value + EXP2
        If LevelUp >= 100 Then
            LevelUp = 0
            pgbExperienceBar.Value = 0
            Level += 1
            Label6.Text = Level
            Label1.Text = pgbExperienceBar.Value
            MsgBox("You leveled up")
            pgbExperienceBar.Maximum = Level * 100

        Else
            pgbExperienceBar.Value += EXP3
            Label1.Text = pgbExperienceBar.Value
            pgbExperienceBar.Maximum = Level * 100
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'grabs all values and puts it in a save.txt in lines
        If System.IO.File.Exists(SaveLocal) = True Then
            Dim objWriter As New System.IO.StreamWriter(SaveLocal)
            objWriter.Write("Level: " & Level)
            objWriter.Write(vbNewLine & "Experience: " & pgbExperienceBar.Value)
            objWriter.Write(vbNewLine & "Task1 Data:")
            'checks if there are tasks to save and saves them
            If lboTask1.Items.Count > 0 Then

                For i = 0 To lboTask1.Items.Count - 1
                    objWriter.Write(vbNewLine & lboTask1.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If

            objWriter.Write(vbNewLine & "Task2 Data:")
            If lboTask2.Items.Count > 0 Then

                For i = 0 To lboTask2.Items.Count - 1
                    objWriter.Write(vbNewLine & lboTask2.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If
            objWriter.Write(vbNewLine & "Task3 Data:")
            If lboTask3.Items.Count > 0 Then
                For i = 0 To lboTask3.Items.Count - 1
                    objWriter.Write(vbNewLine & lboTask3.Items(i))
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

            'if there is no save.txt, create one and basically do exactly what is above
        Else
            System.IO.File.Create(SaveLocal).Dispose()
            MsgBox("Save File Created")
            Dim objWriter As New System.IO.StreamWriter(SaveLocal)
            objWriter.Write("Level: " & Level)
            objWriter.Write(vbNewLine & "Experience: " & pgbExperienceBar.Value)
            objWriter.Write(vbNewLine & "Task1 Data:")
            If lboTask1.Items.Count > 0 Then

                For i = 0 To lboTask1.Items.Count - 1
                    objWriter.Write(vbNewLine & lboTask1.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If

            objWriter.Write(vbNewLine & "Task2 Data:")
            If lboTask2.Items.Count > 0 Then

                For i = 0 To lboTask2.Items.Count - 1
                    objWriter.Write(vbNewLine & lboTask2.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If
            objWriter.Write(vbNewLine & "Task3 Data:")
            If lboTask3.Items.Count > 0 Then
                For i = 0 To lboTask3.Items.Count - 1
                    objWriter.Write(vbNewLine & lboTask3.Items(i))
                Next
            Else
                objWriter.Write(vbNewLine & vbNewLine & vbNewLine & vbNewLine)
            End If

            objWriter.Write(vbNewLine & "Stockpiled XP for 1: " & EXP1)
            objWriter.Write(vbNewLine & "Stockpiled XP for 2: " & EXP2)
            objWriter.Write(vbNewLine & "Stockpiled XP for 3: " & EXP3)
            objWriter.Write(vbNewLine & "GrossXP: " & pgbExperienceBar.Value)
            objWriter.Write(vbNewLine & "LevelUp: " & LevelUp)
            objWriter.Write(vbNewLine & "English Shop: " & Form4.OldEng)
            objWriter.Write(vbNewLine & "Nasty Shop: " & Form4.Nasty)
            objWriter.Write(vbNewLine & "Wingdings Shop: " & Form4.Wingdings)
            objWriter.Close()
            MsgBox("Game Saved")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Disgustingly long and unoptimized loading code, reads each line of the save.txt and cuts off the bits of the string it doesn't need
        Dim objReader As New System.IO.StreamReader(SaveLocal)
        lboTask1.Items.Clear()
        lboTask2.Items.Clear()
        lboTask3.Items.Clear()
        Level = objReader.ReadLine.Remove(0, 7)
        pgbExperienceBar.Maximum = Level * 100
        pgbExperienceBar.Value = objReader.ReadLine.Remove(0, 12)
        objReader.ReadLine()
        lboTask1.Items.Add(objReader.ReadLine)
        lboTask1.Items.Add(objReader.ReadLine)
        lboTask1.Items.Add(objReader.ReadLine)
        lboTask1.Items.Add(objReader.ReadLine)
        objReader.ReadLine()
        lboTask2.Items.Add(objReader.ReadLine)
        lboTask2.Items.Add(objReader.ReadLine)
        lboTask2.Items.Add(objReader.ReadLine)
        lboTask2.Items.Add(objReader.ReadLine)
        objReader.ReadLine()
        lboTask3.Items.Add(objReader.ReadLine)
        lboTask3.Items.Add(objReader.ReadLine)
        lboTask3.Items.Add(objReader.ReadLine)
        lboTask3.Items.Add(objReader.ReadLine)
        EXP1 = objReader.ReadLine.Remove(0, 21)
        EXP2 = objReader.ReadLine.Remove(0, 21)
        EXP3 = objReader.ReadLine.Remove(0, 21)
        GrossXP = objReader.ReadLine.Remove(0, 9)
        LevelUp = objReader.ReadLine.Remove(0, 9)
        Form4.OldEng = objReader.ReadLine.Remove(0, 14)
        Form4.Nasty = objReader.ReadLine.Remove(0, 12)
        Form4.Wingdings = objReader.ReadLine.Remove(0, 16)
        Label1.Text = pgbExperienceBar.Value
        Label6.Text = Level
        'Make sure there are no empty items in the list box
        If lboTask1.Items(1) = "" Then
            lboTask1.Items.Clear()
        Else
            btnComplete1.Enabled = True
        End If

        If lboTask2.Items(1) = "" Then
            lboTask2.Items.Clear()
        Else
            btnComplete2.Enabled = True
        End If

        If lboTask3.Items(1) = "" Then
            lboTask3.Items.Clear()
        Else
            btnComplete3.Enabled = True
        End If

        objReader.Close()

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)



    End Sub



End Class