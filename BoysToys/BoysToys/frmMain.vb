'Programmed by: Jeffrey Marron
'CRN 1475

Option Explicit On

Public Module frmMainModule

    Public Structure BoatInfo
        <VBFixedString(15)> Public make As String
        <VBFixedString(15)> Public model As String
        Public year As Integer
        <VBFixedString(4)> Public purchased As String
        <VBFixedString(18)> Public location As String
        Public price As Long
        <VBFixedString(5)> Public MSRP As String ' <---------- Why is the MSRP a string and not numerical?
        Public Used As Boolean
        <VBFixedString(12)> Public style As String
        Public length As Integer
        Public beam As Decimal
        Public engine As Decimal
        Public horsepower As Integer
        <VBFixedString(10)> Public color As String
        <VBFixedString(35)> Public caption As String
        <VBFixedString(18)> Public pictureFileName As String
    End Structure

    Public Const noOfBoats = 4
    Public myToys(noOfBoats - 1) As BoatInfo
    Public i As Integer

End Module 'frmMainModule


Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileParser()
        ChangeDisplay()
    End Sub 'frmMain_Load

    Public Sub FileParser()
        Dim FilePath As String = "boytoys.dat"

        FileOpen(1, FilePath, OpenMode.Random, , , Len(myToys(0)))

        For i = 0 To noOfBoats - 1
            FileGet(1, myToys(i))
        Next
        i = 0
        FileClose(1)
    End Sub 'FileParser


    Public Sub ChangeDisplay()
        'these two if elseif statements hide and show btnPrev
        If i = 0 Then
            btnPrev.Hide()
        ElseIf i > 0 Then
            btnPrev.Show()
        End If

        If i = noOfBoats - 1 Then
            btnNext.Hide()
        ElseIf i < noOfBoats Then
            btnNext.Show()
        End If
        'sets values from the myToys array into the appropriate labels
        lblMake.Text = myToys(i).make
        lblModel.Text = myToys(i).model
        lblYear.Text = myToys(i).year
        lblYearPurchased.Text = myToys(i).purchased
        lblLocation.Text = myToys(i).location
        lblPrice.Text = myToys(i).price.ToString("C0") 'currency format
        'handles MSRP
        lblMSRP.Text = myToys(i).MSRP
        If IsNumeric(myToys(i).MSRP) = True Then
            lblMSRP.Text = Convert.ToInt32(myToys(i).MSRP).ToString("C0")
        End If
        'handles Used condition
        If myToys(i).Used = True Then
            lblNewUsed.Text = "Used"
        ElseIf myToys(i).Used = False Then
            lblNewUsed.Text = "New"
        End If
        lblStyle.Text = myToys(i).style
        lblLength.Text = myToys(i).length.ToString + " Ft"
        lblBeam.Text = myToys(i).beam.ToString + " Ft"
        lblEngine.Text = myToys(i).engine.ToString + " L"
        lblHorsepower.Text = myToys(i).horsepower.ToString + " HP"
        lblColor.Text = myToys(i).color
        lblDescription.Text = myToys(i).caption
        picVGA1.ImageLocation = myToys(i).pictureFileName
        picVGA1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    'button Handlers***************************
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        i = i + 1 'increments through array
        ChangeDisplay()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        i = i - 1 'decrements through array
        ChangeDisplay()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picVGA1.Click
        frmPicture.ShowDialog() 'makes form modal
    End Sub
    'END button Handlers**********************
End Class
