<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btn_Task_Create = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.pgbExprienceBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAccCard = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnComplete1 = New System.Windows.Forms.Button()
        Me.btnComplete2 = New System.Windows.Forms.Button()
        Me.btnComplete3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_Task_Create
        '
        Me.btn_Task_Create.Location = New System.Drawing.Point(669, 306)
        Me.btn_Task_Create.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_Task_Create.Name = "btn_Task_Create"
        Me.btn_Task_Create.Size = New System.Drawing.Size(200, 71)
        Me.btn_Task_Create.TabIndex = 0
        Me.btn_Task_Create.Text = "Create Task"
        Me.btn_Task_Create.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'pgbExprienceBar
        '
        Me.pgbExprienceBar.Location = New System.Drawing.Point(75, 328)
        Me.pgbExprienceBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pgbExprienceBar.Name = "pgbExprienceBar"
        Me.pgbExprienceBar.Size = New System.Drawing.Size(364, 35)
        Me.pgbExprienceBar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(228, 303)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(38, 48)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(178, 144)
        Me.ListBox1.TabIndex = 3
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(260, 48)
        Me.ListBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(178, 144)
        Me.ListBox2.TabIndex = 4
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 20
        Me.ListBox3.Location = New System.Drawing.Point(486, 48)
        Me.ListBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(178, 144)
        Me.ListBox3.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Task 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Task 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(482, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Task 3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(448, 332)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Level:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(512, 332)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(694, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 75)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAccCard
        '
        Me.btnAccCard.Location = New System.Drawing.Point(669, 388)
        Me.btnAccCard.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAccCard.Name = "btnAccCard"
        Me.btnAccCard.Size = New System.Drawing.Size(200, 35)
        Me.btnAccCard.TabIndex = 15
        Me.btnAccCard.Text = "Account Card"
        Me.btnAccCard.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(858, 31)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 51)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnComplete1
        '
        Me.btnComplete1.Enabled = False
        Me.btnComplete1.Location = New System.Drawing.Point(56, 200)
        Me.btnComplete1.Name = "btnComplete1"
        Me.btnComplete1.Size = New System.Drawing.Size(141, 45)
        Me.btnComplete1.TabIndex = 17
        Me.btnComplete1.Text = "Task Complete"
        Me.btnComplete1.UseVisualStyleBackColor = True
        '
        'btnComplete2
        '
        Me.btnComplete2.Enabled = False
        Me.btnComplete2.Location = New System.Drawing.Point(281, 200)
        Me.btnComplete2.Name = "btnComplete2"
        Me.btnComplete2.Size = New System.Drawing.Size(142, 43)
        Me.btnComplete2.TabIndex = 18
        Me.btnComplete2.Text = "Task Complete"
        Me.btnComplete2.UseVisualStyleBackColor = True
        '
        'btnComplete3
        '
        Me.btnComplete3.Enabled = False
        Me.btnComplete3.Location = New System.Drawing.Point(503, 200)
        Me.btnComplete3.Name = "btnComplete3"
        Me.btnComplete3.Size = New System.Drawing.Size(142, 43)
        Me.btnComplete3.TabIndex = 19
        Me.btnComplete3.Text = "Task Complete"
        Me.btnComplete3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 474)
        Me.Controls.Add(Me.btnComplete3)
        Me.Controls.Add(Me.btnComplete2)
        Me.Controls.Add(Me.btnComplete1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAccCard)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pgbExprienceBar)
        Me.Controls.Add(Me.btn_Task_Create)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Task_Create As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents pgbExprienceBar As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAccCard As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnComplete1 As Button
    Friend WithEvents btnComplete2 As Button
    Friend WithEvents btnComplete3 As Button
End Class
