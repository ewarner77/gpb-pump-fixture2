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
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "pump"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(185, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 34)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(183, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "fwd"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(32, 37)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(127, 22)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1500, 0, 0, 0})
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(388, 77)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 50)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "run 60 sec"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(390, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
End Class
