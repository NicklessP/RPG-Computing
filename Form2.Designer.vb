<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnTaskAdd = New System.Windows.Forms.Button()
        Me.hsbLength = New System.Windows.Forms.HScrollBar()
        Me.hsbDifficulty = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tboTask = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTask = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtnMinutes = New System.Windows.Forms.RadioButton()
        Me.rtnHours = New System.Windows.Forms.RadioButton()
        Me.rtnDays = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblDifficulty = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTaskAdd
        '
        Me.btnTaskAdd.Location = New System.Drawing.Point(62, 373)
        Me.btnTaskAdd.Name = "btnTaskAdd"
        Me.btnTaskAdd.Size = New System.Drawing.Size(222, 51)
        Me.btnTaskAdd.TabIndex = 0
        Me.btnTaskAdd.Text = "Add Task"
        Me.btnTaskAdd.UseVisualStyleBackColor = True
        '
        'hsbLength
        '
        Me.hsbLength.Location = New System.Drawing.Point(34, 267)
        Me.hsbLength.Maximum = 99
        Me.hsbLength.Minimum = 1
        Me.hsbLength.Name = "hsbLength"
        Me.hsbLength.Size = New System.Drawing.Size(285, 21)
        Me.hsbLength.TabIndex = 1
        Me.hsbLength.Value = 1
        '
        'hsbDifficulty
        '
        Me.hsbDifficulty.Location = New System.Drawing.Point(34, 115)
        Me.hsbDifficulty.Maximum = 109
        Me.hsbDifficulty.Minimum = 1
        Me.hsbDifficulty.Name = "hsbDifficulty"
        Me.hsbDifficulty.Size = New System.Drawing.Size(285, 21)
        Me.hsbDifficulty.TabIndex = 2
        Me.hsbDifficulty.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Difficulty (Out of 100)"
        '
        'tboTask
        '
        Me.tboTask.Location = New System.Drawing.Point(62, 39)
        Me.tboTask.Name = "tboTask"
        Me.tboTask.Size = New System.Drawing.Size(222, 20)
        Me.tboTask.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name Of Task"
        '
        'cboTask
        '
        Me.cboTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTask.FormattingEnabled = True
        Me.cboTask.Items.AddRange(New Object() {"Physical Activity", "Chores", "Homework", "Sit Down Work", "Other"})
        Me.cboTask.Location = New System.Drawing.Point(112, 346)
        Me.cboTask.Name = "cboTask"
        Me.cboTask.Size = New System.Drawing.Size(125, 21)
        Me.cboTask.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Type of Task"
        '
        'rtnMinutes
        '
        Me.rtnMinutes.AutoSize = True
        Me.rtnMinutes.Checked = True
        Me.rtnMinutes.Location = New System.Drawing.Point(62, 231)
        Me.rtnMinutes.Name = "rtnMinutes"
        Me.rtnMinutes.Size = New System.Drawing.Size(62, 17)
        Me.rtnMinutes.TabIndex = 9
        Me.rtnMinutes.TabStop = True
        Me.rtnMinutes.Text = "Minutes"
        Me.rtnMinutes.UseVisualStyleBackColor = True
        '
        'rtnHours
        '
        Me.rtnHours.AutoSize = True
        Me.rtnHours.Location = New System.Drawing.Point(146, 231)
        Me.rtnHours.Name = "rtnHours"
        Me.rtnHours.Size = New System.Drawing.Size(53, 17)
        Me.rtnHours.TabIndex = 10
        Me.rtnHours.Text = "Hours"
        Me.rtnHours.UseVisualStyleBackColor = True
        '
        'rtnDays
        '
        Me.rtnDays.AutoSize = True
        Me.rtnDays.Location = New System.Drawing.Point(235, 231)
        Me.rtnDays.Name = "rtnDays"
        Me.rtnDays.Size = New System.Drawing.Size(49, 17)
        Me.rtnDays.TabIndex = 11
        Me.rtnDays.Text = "Days"
        Me.rtnDays.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Length of Task"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(155, 288)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(40, 13)
        Me.lblLength.TabIndex = 13
        Me.lblLength.Text = "Length"
        '
        'lblDifficulty
        '
        Me.lblDifficulty.AutoSize = True
        Me.lblDifficulty.Location = New System.Drawing.Point(155, 136)
        Me.lblDifficulty.Name = "lblDifficulty"
        Me.lblDifficulty.Size = New System.Drawing.Size(40, 13)
        Me.lblDifficulty.TabIndex = 14
        Me.lblDifficulty.Text = "Length"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 448)
        Me.Controls.Add(Me.lblDifficulty)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rtnDays)
        Me.Controls.Add(Me.rtnHours)
        Me.Controls.Add(Me.rtnMinutes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboTask)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tboTask)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hsbDifficulty)
        Me.Controls.Add(Me.hsbLength)
        Me.Controls.Add(Me.btnTaskAdd)
        Me.name = "Form2"
        Me.Text = "Input Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTaskAdd As Button
    Friend WithEvents hsbLength As HScrollBar
    Friend WithEvents hsbDifficulty As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents tboTask As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboTask As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rtnMinutes As RadioButton
    Friend WithEvents rtnHours As RadioButton
    Friend WithEvents rtnDays As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblDifficulty As Label
End Class
