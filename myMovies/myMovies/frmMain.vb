'Programmed by: Jeffrey Marron
'CRN 1475

Option Explicit On

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeDisplay()
    End Sub

    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal _
     lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As _
          Integer, ByVal hwndCallback As Integer) As Integer


    Public Sub ChangeDisplay()
        retVal = mciSendString("close all", vbNullString, 0, 0)
        'these two if elseif statements hide and show btnPrev
        If i = 0 Then
            btnPrev.Hide()
        ElseIf i > 0 Then
            btnPrev.Show()
        End If

        If i = noOfMovies - 1 Then
            btnNext.Hide()
        ElseIf i < noOfMovies Then
            btnNext.Show()
        End If

        lblTitle.Text = movies(i).title
        lblStar.Text = movies(i).star
        lblDuration.Text = movies(i).duration & "     min."
        lblReleased.Text = movies(i).year
        lblRating.Text = movies(i).rating



    End Sub 'ChangeDisplay


    'Button Handlers**********
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        i = i + 1 'increments through array
        ChangeDisplay()
    End Sub 'btnNext.Click

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        i = i - 1 'decrements through array
        ChangeDisplay()
    End Sub 'btnPrev.Click


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmPassword.Close()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        retVal = mciSendString("close all", vbNullString, 0, 0)
        mciSendString("open " & movies(i).movieFileName & " type mpegvideo alias myMovie parent " _
        & picVGA1.Handle.ToInt32 & " style child", 0, 0, 0)
        'put command here
        retVal = mciSendString("put myMovie window at 0 0 " & picVGA1.Size.Width & " " & picVGA1.Size.Height, 0, 0, 0)
        retVal = mciSendString("play myMovie", vbNullString, 0, IntPtr.Zero)
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        retVal = mciSendString("pause myMovie", vbNullString, 0, IntPtr.Zero)
    End Sub

    Private Sub btnResume_Click(sender As Object, e As EventArgs) Handles btnResume.Click
        retVal = mciSendString("resume myMovie", vbNullString, 0, IntPtr.Zero)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        retVal = mciSendString("close all", vbNullString, 0, 0)
    End Sub
    'END Button Handlers****************************
End Class