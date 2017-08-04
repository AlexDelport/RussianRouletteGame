Public Class RussianRouletteHighScores

    Dim myGame As Game

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'Disbales X (windows close) on form, Close button must be used.
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub RussianRouletteHighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class