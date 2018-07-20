<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 51)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(42, 224)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(222, 21)
        Me.HScrollBar1.TabIndex = 1
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Location = New System.Drawing.Point(42, 161)
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.Size = New System.Drawing.Size(222, 21)
        Me.HScrollBar2.TabIndex = 2
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 472)
        Me.Controls.Add(Me.HScrollBar2)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Input Task"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents HScrollBar2 As HScrollBar
End Class
