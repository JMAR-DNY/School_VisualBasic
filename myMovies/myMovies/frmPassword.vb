'Programmed by: Jeffrey Marron
'CRN 1475

Option Explicit On
Imports System.IO

Public Module frmMainModule
    'movies
    Public Structure movieInfo
        <VBFixedString(30)> Public title As String
        <VBFixedString(20)> Public star As String
        Public duration As Integer
        Public year As Integer
        <VBFixedString(5)> Public rating As String
        <VBFixedString(15)> Public movieFileName As String
    End Structure

    Public i, j, attempt, retVal As Integer

    Public Const noOfMovies = 3
    Public movies(noOfMovies - 1) As movieInfo

    'passwords
    Public Const MaxNoOfPasswords = 10
    Public passwords(MaxNoOfPasswords - 1) As String

End Module 'frmMainModule


Public Class frmPassword


    'LOAD'*******************************
    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        FileParser()
        passParser()
    End Sub

    'FILE PARSERS******************************
    Public Sub passParser()
        For Each line As String In File.ReadLines("passwords.txt")
            passwords(j) = (line)
            j = j + 1
        Next line
    End Sub


    Public Sub FileParser()
        Dim FilePath As String = "video.dat"

        FileOpen(1, FilePath, OpenMode.Random, , , Len(movies(0)))

        For j = 0 To noOfMovies - 1
            FileGet(1, movies(j))
        Next
        j = 0
        FileClose(1)
    End Sub 'FileParser
    'END FILE PARSERS*****************************


    'Button Handler********************
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        'If attempt = 2 Then

        ' End If

        If attempt < 2 Then
            For j = 0 To (MaxNoOfPasswords - 1)
                If passwords(j) = txtPassword.Text And txtPassword.Text.Length > 0 Then
                    frmMain.Show()
                    Me.Hide()
                    attempt = attempt - 3
                End If
            Next
            attempt = attempt + 1

            If attempt = 2 Then
                CloseProgram()
            End If
        End If

        If attempt = 1 Then
            Dim result = MessageBox.Show("Invalid Password. One more attempt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub CloseProgram()
        Dim result = MessageBox.Show("The program will now terminate", "Shutting Down", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        frmMain.Close()
        Me.Close()
    End Sub
    'END Button Handler*************************
End Class
