<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RussianRouletteStart
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
        Me.lbWelcome = New System.Windows.Forms.Label()
        Me.lbSurvive = New System.Windows.Forms.Label()
        Me.btnLoadBullet = New System.Windows.Forms.Button()
        Me.btnSpinCylinder = New System.Windows.Forms.Button()
        Me.btnOpenCylinder = New System.Windows.Forms.Button()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.TimerStart = New System.Windows.Forms.Timer(Me.components)
        Me.pbStartPic = New System.Windows.Forms.PictureBox()
        CType(Me.pbStartPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbWelcome
        '
        Me.lbWelcome.AutoSize = True
        Me.lbWelcome.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWelcome.Location = New System.Drawing.Point(141, 22)
        Me.lbWelcome.Name = "lbWelcome"
        Me.lbWelcome.Size = New System.Drawing.Size(510, 36)
        Me.lbWelcome.TabIndex = 0
        Me.lbWelcome.Text = "Welcome to Russian Roulette"
        '
        'lbSurvive
        '
        Me.lbSurvive.AutoSize = True
        Me.lbSurvive.Font = New System.Drawing.Font("Broadway", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSurvive.Location = New System.Drawing.Point(76, 267)
        Me.lbSurvive.Name = "lbSurvive"
        Me.lbSurvive.Size = New System.Drawing.Size(184, 21)
        Me.lbSurvive.TabIndex = 0
        Me.lbSurvive.Text = "Can you Survive?"
        '
        'btnLoadBullet
        '
        Me.btnLoadBullet.Enabled = False
        Me.btnLoadBullet.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadBullet.Location = New System.Drawing.Point(84, 424)
        Me.btnLoadBullet.Name = "btnLoadBullet"
        Me.btnLoadBullet.Size = New System.Drawing.Size(149, 34)
        Me.btnLoadBullet.TabIndex = 3
        Me.btnLoadBullet.Text = "Load Bullet"
        Me.btnLoadBullet.UseVisualStyleBackColor = True
        '
        'btnSpinCylinder
        '
        Me.btnSpinCylinder.Enabled = False
        Me.btnSpinCylinder.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpinCylinder.Location = New System.Drawing.Point(84, 472)
        Me.btnSpinCylinder.Name = "btnSpinCylinder"
        Me.btnSpinCylinder.Size = New System.Drawing.Size(149, 34)
        Me.btnSpinCylinder.TabIndex = 4
        Me.btnSpinCylinder.Text = "Spin"
        Me.btnSpinCylinder.UseVisualStyleBackColor = True
        '
        'btnOpenCylinder
        '
        Me.btnOpenCylinder.Enabled = False
        Me.btnOpenCylinder.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenCylinder.Location = New System.Drawing.Point(84, 374)
        Me.btnOpenCylinder.Name = "btnOpenCylinder"
        Me.btnOpenCylinder.Size = New System.Drawing.Size(149, 34)
        Me.btnOpenCylinder.TabIndex = 2
        Me.btnOpenCylinder.Text = "Open Cylinder"
        Me.btnOpenCylinder.UseVisualStyleBackColor = True
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerName.Location = New System.Drawing.Point(22, 329)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(275, 26)
        Me.txtPlayerName.TabIndex = 1
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Font = New System.Drawing.Font("Broadway", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(94, 309)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(145, 17)
        Me.lbName.TabIndex = 0
        Me.lbName.Text = "Enter your Name"
        '
        'TimerStart
        '
        '
        'pbStartPic
        '
        Me.pbStartPic.Location = New System.Drawing.Point(22, 75)
        Me.pbStartPic.Name = "pbStartPic"
        Me.pbStartPic.Size = New System.Drawing.Size(275, 177)
        Me.pbStartPic.TabIndex = 0
        Me.pbStartPic.TabStop = False
        '
        'RussianRouletteStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 531)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.btnOpenCylinder)
        Me.Controls.Add(Me.btnSpinCylinder)
        Me.Controls.Add(Me.btnLoadBullet)
        Me.Controls.Add(Me.lbSurvive)
        Me.Controls.Add(Me.lbWelcome)
        Me.Controls.Add(Me.pbStartPic)
        Me.MaximizeBox = False
        Me.Name = "RussianRouletteStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Russian Roulette Start Game"
        CType(Me.pbStartPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbStartPic As System.Windows.Forms.PictureBox
    Friend WithEvents lbWelcome As System.Windows.Forms.Label
    Friend WithEvents lbSurvive As System.Windows.Forms.Label
    Friend WithEvents btnLoadBullet As System.Windows.Forms.Button
    Friend WithEvents btnSpinCylinder As System.Windows.Forms.Button
    Friend WithEvents btnOpenCylinder As System.Windows.Forms.Button
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents TimerStart As System.Windows.Forms.Timer

End Class
