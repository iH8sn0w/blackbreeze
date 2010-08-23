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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.blackra1n = New System.Windows.Forms.OpenFileDialog
        Me.Quote = New System.Windows.Forms.Label
        Me.blackra1nsave = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(421, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Fix my ra1n!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clicking the button above will solve issues with the latest iTunes (9.1)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " and ma" & _
            "ke blackra1n work again for 3.1.2."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Quote
        '
        Me.Quote.AutoSize = True
        Me.Quote.Location = New System.Drawing.Point(13, 108)
        Me.Quote.Name = "Quote"
        Me.Quote.Size = New System.Drawing.Size(12, 13)
        Me.Quote.TabIndex = 2
        Me.Quote.Text = """"
        Me.Quote.Visible = False
        '
        'blackra1nsave
        '
        Me.blackra1nsave.FileName = "blackra1n-fixed"
        Me.blackra1nsave.Filter = "Executables|*.exe"
        Me.blackra1nsave.InitialDirectory = "C:/"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(445, 126)
        Me.Controls.Add(Me.Quote)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "blackbreeze -- Making blackra1n a breeze... By: iH8sn0w"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents blackra1n As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Quote As System.Windows.Forms.Label
    Friend WithEvents blackra1nsave As System.Windows.Forms.SaveFileDialog

End Class
