'Programmed by: Jeffrey Marron
'CRN 1475

Option Explicit On
Option Strict On

Public Class frmQuestions

    Private Sub frmQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calculateScoreValues()
        lblQuestion.Text = test(i).question
        lblQNum.Text = ((i + 1).ToString) + "."
    End Sub 'END frmQuestions_Load

    Public Sub calculateScoreValues()
        rightValue = 100 / NumOfQuestions
        wrongValue = ((rightValue) / 2) * -1
        percentComplete = (Convert.ToInt32(rightValue))
    End Sub 'END calculateScoreValues


    Public Sub nextQuestion()

        If i = (NumOfQuestions - 2) Then 'evaluates if there is one more question left, changes btnNext Text
            btnNext.Text = "Finished" 'now shows btnNext will fishih the test
        End If

        lblQuestion.Text = test(i + 1).question 'sets the test question to the lblQuestion Text
        lblQNum.Text = ((i + 2).ToString) + "." ' sets the test number to the lblQNum Text

        answerCheck()

        i = i + 1 'increments through the test array

        'sets values for progress bar & increments it
        prgCompleted.Increment(Convert.ToInt32(rightValue))
        lblPercentComplete.Text = percentComplete & "%"
        percentComplete += (Convert.ToInt32(rightValue))
    End Sub 'END nextQuestion


    Public Sub answerCheck()
        'the test results string and final score are modified in real time as opposed to
        'allocating an array and saving the data there and then calculating when the test is complete

        'leftSpace and rightSpace used to separate values in testResults string
        Dim leftSpace As String = "              "
        Dim rightSpace As String = "                     "

        'handles true selection
        If optT.Checked Then 'evaluates if radio button T is selected

            If test(i).correctAnswer = "T" Then 'If T is the correct answer then
                finalScore = finalScore + rightValue 'the final score is modified
                testResults = testResults & leftSpace & "T" & rightSpace & "T" & Chr(13) 'the testResults string appended
            End If

            If test(i).correctAnswer = "F" Then
                finalScore = finalScore + wrongValue
                testResults = testResults & leftSpace & "F" & rightSpace & "T" & Chr(13)
            End If

        End If 'END true selection

        'handles false selection
        If optF.Checked Then
            If test(i).correctAnswer = "F" Then
                finalScore = finalScore + rightValue
                testResults = testResults & leftSpace & "F" & rightSpace & "F" & Chr(13)
            End If

            If test(i).correctAnswer = "T" Then
                finalScore = finalScore + wrongValue
                testResults = testResults & leftSpace & "T" & rightSpace & "F" & Chr(13)
            End If

        End If 'END false selection

        'handles unchecked selection
        If optT.Checked = False And optF.Checked = False Then

            If test(i).correctAnswer = "F" Then
                testResults = testResults & leftSpace & "F" & rightSpace & "*" & Chr(13)
            ElseIf test(i).correctAnswer = "T" Then
                testResults = testResults & leftSpace & "T" & rightSpace & "*" & Chr(13)
            End If

        End If 'END unchecked selection

        'clears the radio buttons
        optT.Checked = False
        optF.Checked = False
    End Sub 'END answerCheck

    'button handler******************************
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If i = NumOfQuestions - 1 Then 'evaluates if on the last question
            answerCheck() 'calls answerCheck instead of nextQuestion 
            testResults = testResults & Chr(13) & Chr(13) & "*indicates that you did not answer that question"
            testResults = testResults & Chr(13) & Chr(13) & "Your score Is: " & Convert.ToInt32(finalScore)
            Me.Hide() 'hides current frame
            frmMain.Show() 'displays frmMain
            MessageBox.Show(testResults, "Test Results") 'shows the testResults string in a message box
            testTaken = True 'returns boolean value to frmMain to prevent taking test again
        End If

        If i < NumOfQuestions - 1 Then 'prevents nextQuestion to increment i beyond index value of test array
            nextQuestion()
        End If

    End Sub 'btnNext_Click
    'END button handler***************************
End Class