Public Class Form4
    Public OldEng As Boolean = False
    Public Nasty As Boolean = False
    Public Wingdings As Boolean = False
    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub



    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Changes form colour and font, customization
        Form1.Font = New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular)
        Form1.ForeColor = Color.Black
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Changes form colour and font, customization
        Form1.Font = New Font("ScriptS", 8.25, FontStyle.Regular)
        Form1.ForeColor = Color.Brown


    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Changes form colour and font, customization
        Form1.Font = New Font("Comic Sans MS", 9.25, FontStyle.Bold)
                Form1.ForeColor = Color.Magenta


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Changes form colour and font, customization
        Form1.Font = New Font("Wingdings", 8.25, FontStyle.Bold)
        Form1.ForeColor = Color.Black


    End Sub
End Class