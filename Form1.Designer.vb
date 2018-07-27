<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Task_Create = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.pgbExprienceBar = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Task_Create
        '
        Me.btn_Task_Create.Location = New System.Drawing.Point(446, 199)
        Me.btn_Task_Create.Name = "btn_Task_Create"
        Me.btn_Task_Create.Size = New System.Drawing.Size(133, 46)
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
        Me.pgbExprienceBar.Location = New System.Drawing.Point(50, 213)
        Me.pgbExprienceBar.Minimum = 1
        Me.pgbExprienceBar.Name = "pgbExprienceBar"
        Me.pgbExprienceBar.Size = New System.Drawing.Size(243, 23)
        Me.pgbExprienceBar.TabIndex = 1
        Me.pgbExprienceBar.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 308)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pgbExprienceBar)
        Me.Controls.Add(Me.btn_Task_Create)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Task_Create As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents pgbExprienceBar As ProgressBar
    Friend WithEvents Label1 As Label
End Class
