<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RussianRouletteHighScores
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.rtxtHighScores = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(99, 513)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(82, 36)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'rtxtHighScores
        '
        Me.rtxtHighScores.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtxtHighScores.Location = New System.Drawing.Point(13, 13)
        Me.rtxtHighScores.Name = "rtxtHighScores"
        Me.rtxtHighScores.Size = New System.Drawing.Size(260, 488)
        Me.rtxtHighScores.TabIndex = 1
        Me.rtxtHighScores.Text = ""
        Me.rtxtHighScores.WordWrap = False
        '
        'RussianRouletteHighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 561)
        Me.Controls.Add(Me.rtxtHighScores)
        Me.Controls.Add(Me.btnClose)
        Me.MaximizeBox = False
        Me.Name = "RussianRouletteHighScores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RussianRouletteHighScores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents rtxtHighScores As System.Windows.Forms.RichTextBox
End Class
