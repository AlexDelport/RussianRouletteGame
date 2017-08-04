<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RussianRoulettePlay
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
        Me.lbLetsPlay = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbShootHead = New System.Windows.Forms.RadioButton()
        Me.rbShootAway = New System.Windows.Forms.RadioButton()
        Me.txtGameResults = New System.Windows.Forms.TextBox()
        Me.TrackBarShotsFired = New System.Windows.Forms.TrackBar()
        Me.lbShotsFired = New System.Windows.Forms.Label()
        Me.lbShot1 = New System.Windows.Forms.Label()
        Me.lbShot2 = New System.Windows.Forms.Label()
        Me.lbShot3 = New System.Windows.Forms.Label()
        Me.lbShot4 = New System.Windows.Forms.Label()
        Me.lbShot5 = New System.Windows.Forms.Label()
        Me.lbShot6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.pbGunPic = New System.Windows.Forms.PictureBox()
        Me.pbPlayerPic = New System.Windows.Forms.PictureBox()
        Me.OpenFileHighScores = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TrackBarShotsFired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGunPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlayerPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbLetsPlay
        '
        Me.lbLetsPlay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbLetsPlay.AutoSize = True
        Me.lbLetsPlay.Font = New System.Drawing.Font("Broadway", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLetsPlay.Location = New System.Drawing.Point(45, 19)
        Me.lbLetsPlay.Name = "lbLetsPlay"
        Me.lbLetsPlay.Size = New System.Drawing.Size(0, 36)
        Me.lbLetsPlay.TabIndex = 0
        Me.lbLetsPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbShootHead)
        Me.GroupBox1.Controls.Add(Me.rbShootAway)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 321)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbShootHead
        '
        Me.rbShootHead.AutoSize = True
        Me.rbShootHead.Checked = True
        Me.rbShootHead.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbShootHead.Location = New System.Drawing.Point(35, 41)
        Me.rbShootHead.Name = "rbShootHead"
        Me.rbShootHead.Size = New System.Drawing.Size(145, 23)
        Me.rbShootHead.TabIndex = 1
        Me.rbShootHead.TabStop = True
        Me.rbShootHead.Text = "Point at Head"
        Me.rbShootHead.UseVisualStyleBackColor = True
        '
        'rbShootAway
        '
        Me.rbShootAway.AutoSize = True
        Me.rbShootAway.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbShootAway.Location = New System.Drawing.Point(35, 82)
        Me.rbShootAway.Name = "rbShootAway"
        Me.rbShootAway.Size = New System.Drawing.Size(125, 23)
        Me.rbShootAway.TabIndex = 2
        Me.rbShootAway.Text = "Point Away"
        Me.rbShootAway.UseVisualStyleBackColor = True
        '
        'txtGameResults
        '
        Me.txtGameResults.BackColor = System.Drawing.SystemColors.Control
        Me.txtGameResults.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGameResults.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtGameResults.Location = New System.Drawing.Point(262, 321)
        Me.txtGameResults.Multiline = True
        Me.txtGameResults.Name = "txtGameResults"
        Me.txtGameResults.ReadOnly = True
        Me.txtGameResults.Size = New System.Drawing.Size(355, 167)
        Me.txtGameResults.TabIndex = 0
        Me.txtGameResults.TabStop = False
        Me.txtGameResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackBarShotsFired
        '
        Me.TrackBarShotsFired.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TrackBarShotsFired.Enabled = False
        Me.TrackBarShotsFired.LargeChange = 1
        Me.TrackBarShotsFired.Location = New System.Drawing.Point(156, 494)
        Me.TrackBarShotsFired.Maximum = 12
        Me.TrackBarShotsFired.Name = "TrackBarShotsFired"
        Me.TrackBarShotsFired.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TrackBarShotsFired.Size = New System.Drawing.Size(469, 45)
        Me.TrackBarShotsFired.SmallChange = 0
        Me.TrackBarShotsFired.TabIndex = 0
        Me.TrackBarShotsFired.TabStop = False
        Me.TrackBarShotsFired.TickFrequency = 2
        Me.TrackBarShotsFired.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lbShotsFired
        '
        Me.lbShotsFired.AutoSize = True
        Me.lbShotsFired.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShotsFired.Location = New System.Drawing.Point(56, 506)
        Me.lbShotsFired.Name = "lbShotsFired"
        Me.lbShotsFired.Size = New System.Drawing.Size(94, 19)
        Me.lbShotsFired.TabIndex = 0
        Me.lbShotsFired.Text = "Shots Left"
        '
        'lbShot1
        '
        Me.lbShot1.AutoSize = True
        Me.lbShot1.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShot1.Location = New System.Drawing.Point(234, 535)
        Me.lbShot1.Name = "lbShot1"
        Me.lbShot1.Size = New System.Drawing.Size(19, 19)
        Me.lbShot1.TabIndex = 0
        Me.lbShot1.Text = "1"
        '
        'lbShot2
        '
        Me.lbShot2.AutoSize = True
        Me.lbShot2.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShot2.Location = New System.Drawing.Point(306, 535)
        Me.lbShot2.Name = "lbShot2"
        Me.lbShot2.Size = New System.Drawing.Size(19, 19)
        Me.lbShot2.TabIndex = 0
        Me.lbShot2.Text = "2"
        '
        'lbShot3
        '
        Me.lbShot3.AutoSize = True
        Me.lbShot3.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShot3.Location = New System.Drawing.Point(381, 535)
        Me.lbShot3.Name = "lbShot3"
        Me.lbShot3.Size = New System.Drawing.Size(19, 19)
        Me.lbShot3.TabIndex = 0
        Me.lbShot3.Text = "3"
        '
        'lbShot4
        '
        Me.lbShot4.AutoSize = True
        Me.lbShot4.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShot4.Location = New System.Drawing.Point(455, 535)
        Me.lbShot4.Name = "lbShot4"
        Me.lbShot4.Size = New System.Drawing.Size(19, 19)
        Me.lbShot4.TabIndex = 0
        Me.lbShot4.Text = "4"
        '
        'lbShot5
        '
        Me.lbShot5.AutoSize = True
        Me.lbShot5.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShot5.Location = New System.Drawing.Point(529, 535)
        Me.lbShot5.Name = "lbShot5"
        Me.lbShot5.Size = New System.Drawing.Size(19, 19)
        Me.lbShot5.TabIndex = 0
        Me.lbShot5.Text = "5"
        '
        'lbShot6
        '
        Me.lbShot6.AutoEllipsis = True
        Me.lbShot6.AutoSize = True
        Me.lbShot6.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbShot6.Location = New System.Drawing.Point(603, 535)
        Me.lbShot6.Name = "lbShot6"
        Me.lbShot6.Size = New System.Drawing.Size(19, 19)
        Me.lbShot6.TabIndex = 0
        Me.lbShot6.Text = "6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 535)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "0"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(636, 468)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(125, 45)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Game"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFire
        '
        Me.btnFire.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFire.Location = New System.Drawing.Point(636, 351)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(125, 50)
        Me.btnFire.TabIndex = 3
        Me.btnFire.Text = "Fire"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.Location = New System.Drawing.Point(636, 412)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(125, 45)
        Me.btnPlayAgain.TabIndex = 4
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        '
        'pbGunPic
        '
        Me.pbGunPic.Location = New System.Drawing.Point(314, 75)
        Me.pbGunPic.Name = "pbGunPic"
        Me.pbGunPic.Size = New System.Drawing.Size(447, 226)
        Me.pbGunPic.TabIndex = 2
        Me.pbGunPic.TabStop = False
        '
        'pbPlayerPic
        '
        Me.pbPlayerPic.Location = New System.Drawing.Point(30, 75)
        Me.pbPlayerPic.Name = "pbPlayerPic"
        Me.pbPlayerPic.Size = New System.Drawing.Size(255, 226)
        Me.pbPlayerPic.TabIndex = 1
        Me.pbPlayerPic.TabStop = False
        '
        'OpenFileHighScores
        '
        Me.OpenFileHighScores.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Broadway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(633, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "~ Good Luck ~"
        '
        'RussianRoulettePlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbShot6)
        Me.Controls.Add(Me.lbShot5)
        Me.Controls.Add(Me.lbShot4)
        Me.Controls.Add(Me.lbShot3)
        Me.Controls.Add(Me.lbShot2)
        Me.Controls.Add(Me.lbShot1)
        Me.Controls.Add(Me.lbShotsFired)
        Me.Controls.Add(Me.TrackBarShotsFired)
        Me.Controls.Add(Me.txtGameResults)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbLetsPlay)
        Me.Controls.Add(Me.pbGunPic)
        Me.Controls.Add(Me.pbPlayerPic)
        Me.MaximizeBox = False
        Me.Name = "RussianRoulettePlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Russian Roulette Play Game"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TrackBarShotsFired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGunPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlayerPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbPlayerPic As System.Windows.Forms.PictureBox
    Friend WithEvents pbGunPic As System.Windows.Forms.PictureBox
    Friend WithEvents lbLetsPlay As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbShootHead As System.Windows.Forms.RadioButton
    Friend WithEvents rbShootAway As System.Windows.Forms.RadioButton
    Friend WithEvents txtGameResults As System.Windows.Forms.TextBox
    Friend WithEvents TrackBarShotsFired As System.Windows.Forms.TrackBar
    Friend WithEvents lbShotsFired As System.Windows.Forms.Label
    Friend WithEvents lbShot1 As System.Windows.Forms.Label
    Friend WithEvents lbShot2 As System.Windows.Forms.Label
    Friend WithEvents lbShot3 As System.Windows.Forms.Label
    Friend WithEvents lbShot4 As System.Windows.Forms.Label
    Friend WithEvents lbShot5 As System.Windows.Forms.Label
    Friend WithEvents lbShot6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFire As System.Windows.Forms.Button
    Friend WithEvents btnPlayAgain As System.Windows.Forms.Button
    Friend WithEvents OpenFileHighScores As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
