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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Task"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(34, 365)
        Me.HScrollBar1.Maximum = 99
        Me.HScrollBar1.Minimum = 1
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(285, 21)
        Me.HScrollBar1.TabIndex = 1
        Me.HScrollBar1.Value = 1
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(34, 213)
        Me.HScrollBar2.Maximum = 109
        Me.HScrollBar2.Minimum = 1
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(285, 21)
        Me.HScrollBar2.TabIndex = 2
        Me.HScrollBar2.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(122, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Difficulty (Out of 100)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(222, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name Of Task"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Physical Activity", "Chores", "Homework", "Sit Down Work", "Other"})
        Me.ComboBox1.Location = New System.Drawing.Point(112, 444)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(143, 428)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Type of Task"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(62, 329)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 9
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Minutes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(146, 329)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(53, 17)
        Me.RadioButton2.TabIndex = 10
        Me.RadioButton2.Text = "Hours"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(235, 329)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton3.TabIndex = 11
        Me.RadioButton3.Text = "Days"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Length of Task"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(155, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Length"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(155, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Length"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 558)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Button1)
        Me.name = "Form2"
        Me.Text = "Input Task"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
