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
        Me.pointsBox = New System.Windows.Forms.TextBox()
        Me.inchesBox = New System.Windows.Forms.TextBox()
        Me.Go = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pointsBox
        '
        Me.pointsBox.Location = New System.Drawing.Point(12, 29)
        Me.pointsBox.Name = "pointsBox"
        Me.pointsBox.Size = New System.Drawing.Size(100, 20)
        Me.pointsBox.TabIndex = 0
        '
        'inchesBox
        '
        Me.inchesBox.Location = New System.Drawing.Point(134, 29)
        Me.inchesBox.Name = "inchesBox"
        Me.inchesBox.Size = New System.Drawing.Size(100, 20)
        Me.inchesBox.TabIndex = 1
        '
        'Go
        '
        Me.Go.Location = New System.Drawing.Point(12, 55)
        Me.Go.Name = "Go"
        Me.Go.Size = New System.Drawing.Size(100, 23)
        Me.Go.TabIndex = 2
        Me.Go.Text = "Convert"
        Me.Go.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Points"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Inches"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 89)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Go)
        Me.Controls.Add(Me.inchesBox)
        Me.Controls.Add(Me.pointsBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pointsBox As TextBox
    Friend WithEvents inchesBox As TextBox
    Friend WithEvents Go As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
