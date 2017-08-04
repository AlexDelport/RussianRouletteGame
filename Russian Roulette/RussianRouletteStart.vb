Public Class RussianRouletteStart

    Public myGun As New Gun
    Public myGame As New Game

    Private Sub RussianRouletteStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialises all the values and pictures when the Russian Roulette Start form loads.
        myGame.LoadGameStartForm()
    End Sub

    Private Sub btnOpenCylinder_Click(sender As Object, e As EventArgs) Handles btnOpenCylinder.Click
        'Sets the player's name, re-intialises the Russian Roulette Play form and draws the gun cylinder.
        myGame.SetPlayerName()
        myGame.ResetGamePlayForm()
        myGun.DrawCylinder()
        btnLoadBullet.Enabled = True
    End Sub

    Private Sub btnLoadBullet_Click(sender As Object, e As EventArgs) Handles btnLoadBullet.Click
        'Loads the bullet in the chamber.
        myGun.LoadBullet()
        btnSpinCylinder.Enabled = True
    End Sub

    Private Sub btnSpinCylinder_Click(sender As Object, e As EventArgs) Handles btnSpinCylinder.Click
        'Starts the timer, which determines how long the cylinder spins for.
        'Loads the bullet position.
        TimerStart.Enabled = True
        myGun.BulletPosition()
        'MsgBox(myGun.ChamberNum) ' <--- "cheat code" used for testing purposes, remember to comment out when not in use.
    End Sub

    Private Sub TimerStart_Tick(sender As Object, e As EventArgs) Handles TimerStart.Tick
        'Spins the cylinder and stops the timer.
        myGun.PlaySpinningCylinderSound()
        myGun.SpinCylinder()
        TimerStart.Enabled = False
        Me.Hide()
        RussianRoulettePlay.Show()
    End Sub

End Class