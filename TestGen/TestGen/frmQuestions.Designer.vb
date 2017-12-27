<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MnuStripMain = New System.Windows.Forms.MenuStrip()
        Me.lblQuestionTitle = New System.Windows.Forms.Label()
        Me.lblQuestions1 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.optT = New System.Windows.Forms.RadioButton()
        Me.optF = New System.Windows.Forms.RadioButton()
        Me.lblQNum = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.prgCompleted = New System.Windows.Forms.ProgressBar()
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.lbl100 = New System.Windows.Forms.Label()
        Me.lblcompleted = New System.Windows.Forms.Label()
        Me.lblPercentComplete = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MnuStripMain
        '
        Me.MnuStripMain.AutoSize = False
        Me.MnuStripMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MnuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuStripMain.Name = "MnuStripMain"
        Me.MnuStripMain.Size = New System.Drawing.Size(335, 24)
        Me.MnuStripMain.TabIndex = 1
        Me.MnuStripMain.Text = "JAM's Test Generator"
        '
        'lblQuestionTitle
        '
        Me.lblQuestionTitle.AutoSize = True
        Me.lblQuestionTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblQuestionTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblQuestionTitle.Location = New System.Drawing.Point(12, 0)
        Me.lblQuestionTitle.Name = "lblQuestionTitle"
        Me.lblQuestionTitle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblQuestionTitle.Size = New System.Drawing.Size(140, 18)
        Me.lblQuestionTitle.TabIndex = 2
        Me.lblQuestionTitle.Text = "JAM wishes you good Luck!"
        '
        'lblQuestions1
        '
        Me.lblQuestions1.AutoSize = True
        Me.lblQuestions1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestions1.Location = New System.Drawing.Point(23, 35)
        Me.lblQuestions1.Name = "lblQuestions1"
        Me.lblQuestions1.Size = New System.Drawing.Size(157, 13)
        Me.lblQuestions1.TabIndex = 3
        Me.lblQuestions1.Text = "Select the correct answer:"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(104, 216)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(104, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next Question"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'optT
        '
        Me.optT.AutoSize = True
        Me.optT.Location = New System.Drawing.Point(92, 145)
        Me.optT.Name = "optT"
        Me.optT.Size = New System.Drawing.Size(32, 17)
        Me.optT.TabIndex = 5
        Me.optT.TabStop = True
        Me.optT.Text = "T"
        Me.optT.UseVisualStyleBackColor = True
        '
        'optF
        '
        Me.optF.AutoSize = True
        Me.optF.Location = New System.Drawing.Point(92, 179)
        Me.optF.Name = "optF"
        Me.optF.Size = New System.Drawing.Size(31, 17)
        Me.optF.TabIndex = 6
        Me.optF.TabStop = True
        Me.optF.Text = "F"
        Me.optF.UseVisualStyleBackColor = True
        '
        'lblQNum
        '
        Me.lblQNum.AutoSize = True
        Me.lblQNum.Location = New System.Drawing.Point(32, 73)
        Me.lblQNum.Name = "lblQNum"
        Me.lblQNum.Size = New System.Drawing.Size(16, 13)
        Me.lblQNum.TabIndex = 7
        Me.lblQNum.Text = "1."
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(54, 73)
        Me.lblQuestion.MaximumSize = New System.Drawing.Size(240, 64)
        Me.lblQuestion.MinimumSize = New System.Drawing.Size(240, 64)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(240, 64)
        Me.lblQuestion.TabIndex = 8
        Me.lblQuestion.Text = "_"
        '
        'prgCompleted
        '
        Me.prgCompleted.Location = New System.Drawing.Point(57, 263)
        Me.prgCompleted.Name = "prgCompleted"
        Me.prgCompleted.Size = New System.Drawing.Size(208, 28)
        Me.prgCompleted.TabIndex = 9
        '
        'lbl0
        '
        Me.lbl0.AutoSize = True
        Me.lbl0.Location = New System.Drawing.Point(54, 307)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(21, 13)
        Me.lbl0.TabIndex = 10
        Me.lbl0.Text = "0%"
        '
        'lbl100
        '
        Me.lbl100.AutoSize = True
        Me.lbl100.Location = New System.Drawing.Point(226, 307)
        Me.lbl100.Name = "lbl100"
        Me.lbl100.Size = New System.Drawing.Size(33, 13)
        Me.lbl100.TabIndex = 11
        Me.lbl100.Text = "100%"
        '
        'lblcompleted
        '
        Me.lblcompleted.AutoSize = True
        Me.lblcompleted.Location = New System.Drawing.Point(132, 296)
        Me.lblcompleted.Name = "lblcompleted"
        Me.lblcompleted.Size = New System.Drawing.Size(57, 13)
        Me.lblcompleted.TabIndex = 12
        Me.lblcompleted.Text = "Completed"
        '
        'lblPercentComplete
        '
        Me.lblPercentComplete.AutoSize = True
        Me.lblPercentComplete.Location = New System.Drawing.Point(144, 271)
        Me.lblPercentComplete.Name = "lblPercentComplete"
        Me.lblPercentComplete.Size = New System.Drawing.Size(21, 13)
        Me.lblPercentComplete.TabIndex = 13
        Me.lblPercentComplete.Text = "0%"
        '
        'frmQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 329)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPercentComplete)
        Me.Controls.Add(Me.lblcompleted)
        Me.Controls.Add(Me.lbl100)
        Me.Controls.Add(Me.lbl0)
        Me.Controls.Add(Me.prgCompleted)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblQNum)
        Me.Controls.Add(Me.optF)
        Me.Controls.Add(Me.optT)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblQuestions1)
        Me.Controls.Add(Me.lblQuestionTitle)
        Me.Controls.Add(Me.MnuStripMain)
        Me.Name = "frmQuestions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuStripMain As MenuStrip
    Friend WithEvents lblQuestionTitle As Label
    Friend WithEvents lblQuestions1 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents optT As RadioButton
    Friend WithEvents optF As RadioButton
    Friend WithEvents lblQNum As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents prgCompleted As ProgressBar
    Friend WithEvents lbl0 As Label
    Friend WithEvents lbl100 As Label
    Friend WithEvents lblcompleted As Label
    Friend WithEvents lblPercentComplete As Label
End Class
