'Programmed by: Jeffrey Marron
'CRN 1475

Option Explicit On

Public Class frmPicture
    Private Sub frmPicture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picVGA2.ImageLocation = myToys(i).pictureFileName
        picVGA2.SizeMode = PictureBoxSizeMode.StretchImage
        Me.TopMost = True
    End Sub

    Private Sub Me_Click(sender As Object, e As EventArgs) Handles Me.Click, picVGA2.Click, lbl1.Click
        Me.Close()
    End Sub
End Class