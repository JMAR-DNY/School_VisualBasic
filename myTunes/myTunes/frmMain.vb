'Programmed by: Jeffrey Marron
'CRN 1475

Option Explicit On

Public Module frmMainModule

    Public Structure musicInfo
        <VBFixedString(30)> Public title As String
        <VBFixedString(20)> Public artist As String
        <VBFixedString(20)> Public genre As String
        <VBFixedString(10)> Public duration As String
        Public year As Integer
        Public price As Double
        <VBFixedString(10)> Public cover As String
        <VBFixedString(15)> Public songFileName As String
    End Structure

    Public Const noOftunes = 5
    Public songs(noOftunes - 1) As musicInfo

    Public i As Integer
    Public subtotal As Double = 0
    Public taxRate As Double = 0
    Public tax As Double = 0
    Public PurchaseOrder As String = ""

End Module 'frmMainModule

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileParser()
        ChangeDisplay()
        MaximizeBox = False
        MinimizeBox = False
        btnFinishOrder.Enabled = False
    End Sub 'Load

    Public Sub FileParser()
        Dim FilePath As String = "music.dat"

        FileOpen(1, FilePath, OpenMode.Random, , , Len(songs(0)))

        For i = 0 To noOftunes - 1
            FileGet(1, songs(i))
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

        If i = noOftunes - 1 Then
            btnNext.Hide()
        ElseIf i < noOftunes Then
            btnNext.Show()
        End If
        'sets values from the myToys array into the appropriate labels
        lblTitle.Text = songs(i).title
        lblArtist.Text = songs(i).artist
        lblGenre.Text = songs(i).genre
        lblDuration.Text = songs(i).duration
        lblReleased.Text = songs(i).year.ToString
        lblPrice.Text = songs(i).price.ToString("C2") 'currency format

        picVGA1.ImageLocation = songs(i).cover
        picVGA1.SizeMode = PictureBoxSizeMode.StretchImage
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

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        btnFinishOrder.Enabled = True 'enables btnFinishOrder after an "item was added to the cart"
        subtotal = subtotal + songs(i).price 'appends subtotal
        PurchaseOrder = PurchaseOrder & (songs(i).price.ToString("C2")).PadRight(10) & songs(i).title & vbCrLf 'appends purchase order string
    End Sub 'btnAddToCart.Click

    Private Sub btnFinishOrder_Click(sender As Object, e As EventArgs) Handles btnFinishOrder.Click
        frmTax.ShowDialog() 'opens frmTax as modal
    End Sub 'btnFinishOrder.Click

    'END Button Handlers**********


    'picVGA1 mouseover handlers**********
    'Will play corresponding audio file on pic1VGA MouseEnter & stop playback on MouseLeave
    Private Sub panel1_MouseEnter(sender As Object, e As System.EventArgs) Handles picVGA1.MouseEnter
        My.Computer.Audio.Play(songs(i).songFileName)
    End Sub 'picVGA1.MouseEnter

    Private Sub panel1_MouseLeave(sender As Object, e As System.EventArgs) Handles picVGA1.MouseLeave
        My.Computer.Audio.Stop()
    End Sub 'picVGA1.MouseLeave
    'END picVGA1 mouseover handlers**********

End Class'frmMain