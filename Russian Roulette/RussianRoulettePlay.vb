Public Class RussianRoulettePlay

    Dim myGame As Game

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'Disbales X (windows close) on form, Exit Game button must be used.
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub RussianRoulettePlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialises all the values and pictures when the Russian Roulette Play form loads.
        myGame = RussianRouletteStart.myGame
        myGame.LoadGamePlayForm()
    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        'Deals with the playing of the game.
        myGame.PlayRussianRoulette()
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        Me.Hide()
        'Re-initialises all the values and pictures when the Russian Roulette Start form loads.
        myGame.ResetGameStartForm()
        RussianRouletteStart.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Writes the total score to a file of high scores.
        myGame.HighScoresWriteFile()
        'Reads and sorts the high score file for display.
        myGame.HighScoresReadFile()
        RussianRouletteHighScores.Show()
        Me.Hide()
    End Sub

End Class
