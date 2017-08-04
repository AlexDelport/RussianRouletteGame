Imports System.IO
Public Class Game
    'Game class deals with playing the game.

    Dim myGun As Gun
    Dim PlayerName As String
    Dim ShootAwayCount As Integer = 0 'Total shots fired away because they may not be greater than two.
    Dim ShotCount As Integer = 0 'Total shots fired count because they may be greater than the 6 gun chambers.
    Dim LoseScore As Integer = 0 'Record of games lost required for Win/Lose total. 
    Public WinScore As Integer = 0 'Record of games won required for Win/Lose total and also required for High Score.
    Dim HighScoreList As New List(Of HighScore)

    Sub LoadGameStartForm()
        'Assigns the values and pictures when the Russian Roulette Start form is initialised.

        RussianRouletteStart.pbStartPic.SizeMode = PictureBoxSizeMode.Zoom
        RussianRouletteStart.pbStartPic.Image = My.Resources.StartPic
        RussianRouletteStart.txtPlayerName.Text = PlayerName
        RussianRouletteStart.btnOpenCylinder.Enabled = True
        RussianRouletteStart.btnLoadBullet.Enabled = False
        RussianRouletteStart.btnSpinCylinder.Enabled = False

    End Sub

    Public Sub SetPlayerName()
        'When playing again, resets the win and lose score count and writes to high score file if the player name changes.

        If RussianRouletteStart.txtPlayerName.Text <> PlayerName Then
            HighScoresWriteFile()
            WinScore = 0
            LoseScore = 0
        End If

        If RussianRouletteStart.txtPlayerName.Text <> "" Then
            PlayerName = RussianRouletteStart.txtPlayerName.Text
        Else
            PlayerName = "Anonymous"
        End If

    End Sub

    Public Function GetPlayerName()
        Return PlayerName
    End Function

    Sub LoadGamePlayForm()
        'Assigns the values and pictures when the Russian Roulette Play form is initialised.

        myGun = RussianRouletteStart.myGun

        RussianRoulettePlay.lbLetsPlay.Text = "Let's Play Russian Roulette " & PlayerName

        ShootAwayCount = 0
        ShotCount = 0
        RussianRoulettePlay.TrackBarShotsFired.Value = 0
        RussianRoulettePlay.rbShootAway.Enabled = True
        RussianRoulettePlay.btnFire.Enabled = True
        RussianRoulettePlay.rbShootHead.Checked = True
        RussianRoulettePlay.btnPlayAgain.Enabled = False

        RussianRoulettePlay.pbPlayerPic.SizeMode = PictureBoxSizeMode.Zoom
        RussianRoulettePlay.pbPlayerPic.Image = My.Resources.emoticonTeary
        RussianRoulettePlay.pbGunPic.SizeMode = PictureBoxSizeMode.Zoom
        RussianRoulettePlay.pbGunPic.Image = My.Resources.loaded

        'Game rules and how to play.
        RussianRoulettePlay.txtGameResults.Text =
             vbCrLf & "- Dead or Alive - " & vbCrLf &
             vbCrLf &
             vbCrLf &
                      "<--- <--- <--- Make a selection." & vbCrLf &
             vbCrLf &
                      "You can elect to Shoot away 2 times only!!" & vbCrLf &
             vbCrLf &
                      "Click the ""Fire"" button when ready."

    End Sub

    Sub PlayRussianRoulette()

        myGun = RussianRouletteStart.myGun

        'Checking if Shoot Away is selected and two shots away have not yet been used.
        If RussianRoulettePlay.rbShootAway.Checked = True And ShootAwayCount < 2 Then
            ShotCount += 1
            ShootAwayCount += 1
            RussianRoulettePlay.TrackBarShotsFired.Value += 2

            'Checking if the bullet is in the chamber during the shot away.
            If ShotCount = myGun.ChamberNum Then
                GameWin()
            Else
                GameLucky()
            End If

            'Checking if Shoot Away is selected and two shots away have already been used.
        ElseIf RussianRoulettePlay.rbShootAway.Checked = True And ShootAwayCount = 2 Then
            ShotsAwayUsed()

            'Checking if Shoot Head is selected and total shots used are less than 6 (the number of chambers in this gun.)
        ElseIf RussianRoulettePlay.rbShootHead.Checked = True And ShotCount < 6 Then
            ShotCount += 1
            RussianRoulettePlay.TrackBarShotsFired.Value += 2

            'Checking if the bullet is in the chamber during the head shot.
            If ShotCount = myGun.ChamberNum Then
                GameLose()
            Else
                GameLucky()
            End If

        End If

    End Sub

    Sub GameLucky()
        'Actions to be followed when the bullet is not in the chamber during the shot fired.

        myGun.PlayEmptyShotSound()
        RussianRoulettePlay.pbPlayerPic.Image = My.Resources.emoticonRelieved
        RussianRoulettePlay.txtGameResults.Text = vbCrLf &
            vbCrLf &
            vbCrLf &
            vbCrLf & "You were lucky this time !!"

    End Sub

    Sub GameLose()
        'Actions to be followed when the bullet is in the chamber during the shot fired.

        myGun.PlayGunShotSound()
        RussianRoulettePlay.pbPlayerPic.Image = My.Resources.emoticonDead
        RussianRoulettePlay.pbGunPic.Image = My.Resources.shooting
        LoseScore += 1
        RussianRoulettePlay.btnFire.Enabled = False
        RussianRoulettePlay.btnPlayAgain.Enabled = True
        RussianRoulettePlay.txtGameResults.Text =
            vbCrLf &
            vbCrLf & "!!! You Lose - you're dead !!!" & vbCrLf &
            vbCrLf &
            vbCrLf & "You have no bullets left," & vbCrLf &
                     "to continue click ""Play Again"" ---> --->" & vbCrLf &
            vbCrLf &
                     "Won - " & WinScore & " / " & LoseScore & " - Lost"

    End Sub

    Sub GameWin()
        'Actions to be followed when the bullet is in the chamber during the shot fired and it is shot away.

        myGun.PlayGunShotSound()
        RussianRoulettePlay.pbGunPic.Image = My.Resources.shooting
        WinScore += 1
        RussianRoulettePlay.btnFire.Enabled = False
        RussianRoulettePlay.pbPlayerPic.Image = My.Resources.emoticonHappy
        RussianRoulettePlay.btnPlayAgain.Enabled = True
        RussianRoulettePlay.txtGameResults.Text =
            vbCrLf &
            vbCrLf & "!!! You W I N !!!" & vbCrLf &
            vbCrLf &
            vbCrLf & "You have no bullets left," & vbCrLf &
                     "to continue click ""Play Again"" ---> --->" & vbCrLf &
            vbCrLf &
                     "Won - " & WinScore & " / " & LoseScore & " - Lost"

    End Sub

    Sub ShotsAwayUsed()
        'Actions to be followed when the bullet is not in the chamber and two shot away have been used up.

        RussianRoulettePlay.rbShootAway.Enabled = False
        RussianRoulettePlay.rbShootHead.Checked = True
        RussianRoulettePlay.txtGameResults.Text =
            vbCrLf &
            vbCrLf &
            vbCrLf &
            vbCrLf & "You have already used your 2 Shots Away!!"

    End Sub

    Sub ResetGameStartForm()
        LoadGameStartForm()
    End Sub

    Sub ResetGamePlayForm()
        LoadGamePlayForm()
    End Sub

    Sub HighScoresWriteFile()
        'Writes Win score total, provided it is greater than 0, to a high score text file, checks whether file exists first,
        'if not - creates file, if yes - writes data.

        Dim path As String = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) &
                              "\Russian Roulette Game\RussianRouletteHighScores.txt") '<------ path to create directory if one does not exist.
        Dim filewrite As StreamWriter

        Try
            If File.Exists(path) = False Then
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) &
                          "\Russian Roulette Game\") '<------ path to create directory if one does not exist, permission dependant.
                filewrite = File.CreateText(path)
                If WinScore > 0 Then '<------ to include all scores in high scores, exclude these
                    filewrite.WriteLine(PlayerName & "," & WinScore & "," & LoseScore)
                End If '<------ to include all scores in high scores, exclude these
                filewrite.Flush()
                filewrite.Close()
            Else
                If WinScore > 0 Then '<------ to include all scores in high scores, exclude these
                    filewrite = File.AppendText(path)
                    filewrite.WriteLine(PlayerName & "," & WinScore & "," & LoseScore)
                    filewrite.Flush()
                    filewrite.Close()
                End If '<------ to include all scores in high scores, exclude these
            End If

        Catch ex As Exception
            MsgBox("File Writing Error: " & ex.Message)
        End Try

    End Sub

    Sub HighScoresReadFile()
        'Reads the high score file into an object list to enable sorting of high scores

        Dim path As String = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) &
                              "\Russian Roulette Game\RussianRouletteHighScores.txt")
        Dim fileread As StreamReader
        Dim Line As String

        Try
            fileread = New StreamReader(path)
            Do Until fileread.EndOfStream
                Line = fileread.ReadLine

                Dim HighScore As New HighScore
                Dim HighScoreArray = Line.Split(",")

                HighScore.Name = HighScoreArray(0)
                HighScore.Win = HighScoreArray(1)
                HighScore.Loss = HighScoreArray(2)
                'MsgBox(HighScoreArray(0) & HighScoreArray(1) & HighScoreArray(2)) ' <--- for testing purposes, remember to comment out.
                HighScoreList.Add(HighScore)

            Loop
            fileread.Close()
        Catch ex As Exception
            MsgBox("File Reading Error: " & ex.Message)
        End Try

        'Different way to sort multidimensional arrays/list (object list)
        'Lambda Expressions - Dim queryScore = HighScoreList.OrderBy(Function(c As HighScore) c.Score).Reverse().ToList()

        'LINQ - used to sort the second column, in this case the score, of an object list.
        Dim queryScore = From hscore In HighScoreList
            Order By hscore.Win Descending
        Select hscore.Name, hscore.Win, hscore.Loss
        For Each result In queryScore
            RussianRouletteHighScores.rtxtHighScores.Text = RussianRouletteHighScores.rtxtHighScores.Text + ("Won  " & result.Win &
            "  /  " & result.Loss & "  Lost  --  " & result.Name & vbCrLf)
        Next

    End Sub

End Class
