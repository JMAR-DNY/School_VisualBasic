'Programmed by: Jeffrey Marron
'CRN 1475

Option Explicit On
Option Strict On

Public Class frmIntermediate

    Private Sub frmIntermediate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboNumSelector.SelectedIndex = 4 'sets default value to 25
    End Sub 'END frmIntermediate_Load

    Private Sub btnBeginTest_Click(sender As Object, e As EventArgs) Handles btnBeginTest.Click
        NumOfQuestions = Convert.ToInt32(cboNumSelector.Text) 'calculates number of questions based on combo box value
        frmQuestions.Show() 'shows frmQuestions
        Me.Hide() 'hides current form
    End Sub 'END btnBeginTest_Click

End Class