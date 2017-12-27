'Programmed by: Jeffrey Marron
'CRN 1475

Option Explicit On

Public Module frmMainModule

    Structure testQuestion
        <VBFixedString(150)> Public question As String
        <VBFixedString(1)> Public correctAnswer As String
    End Structure

    'test results are stored as a string and its value is appended for each answer
    'this allows the answers to be stored without allocating another array and then performing calculations
    Public testResults As String = "Correct Answer   Your Answer" & Chr(13) & Chr(13)
    Public rightValue As Double
    Public wrongValue As Double
    Public finalScore As Double = 0
    Public testTaken As Boolean = False
    Public percentComplete As Integer

    Public Const MaxNumOfQuestions = 25
    Public test(MaxNumOfQuestions - 1) As testQuestion
    Public NumOfQuestions As Integer = 0
    Public i As Integer

End Module 'frmMainModule


Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileParser()
    End Sub 'frmMain_Load

    Public Sub FileParser()
        Dim FilePath As String = "ExcelTest.dat"

        FileOpen(1, FilePath, OpenMode.Random, , , Len(test(0)))

        For i = 0 To 24
            FileGet(1, test(i))
        Next
        i = 0
        FileClose(1)
    End Sub 'FileParser

    'button handlers***************************
    Private Sub btnExitTestGen_Click(sender As Object, e As EventArgs) Handles btnExitTestGen.Click
        Me.Close()
    End Sub 'btnExitTestGen

    Private Sub btnTakeTest_Click(sender As Object, e As EventArgs) Handles btnTakeTest.Click

        If testTaken = True Then
            Dim result = MessageBox.Show(" You already took the test!", "Testing Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf testTaken = False Then
            frmIntermediate.Show()
            Me.Hide()
        End If
    End Sub 'END btnTakeTest_Click
    'END button handlers************************
End Class