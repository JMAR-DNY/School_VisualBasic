<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MnuStripMain = New System.Windows.Forms.MenuStrip()
        Me.lblMainTitle = New System.Windows.Forms.Label()
        Me.lblMainText1 = New System.Windows.Forms.Label()
        Me.lblMainText2 = New System.Windows.Forms.Label()
        Me.lblMainText3 = New System.Windows.Forms.Label()
        Me.btnTakeTest = New System.Windows.Forms.Button()
        Me.btnExitTestGen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MnuStripMain
        '
        Me.MnuStripMain.AutoSize = False
        Me.MnuStripMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MnuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuStripMain.Name = "MnuStripMain"
        Me.MnuStripMain.Size = New System.Drawing.Size(273, 24)
        Me.MnuStripMain.TabIndex = 0
        Me.MnuStripMain.Text = "JAM's Test Generator"
        '
        'lblMainTitle
        '
        Me.lblMainTitle.AutoSize = True
        Me.lblMainTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMainTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMainTitle.Location = New System.Drawing.Point(12, 0)
        Me.lblMainTitle.Name = "lblMainTitle"
        Me.lblMainTitle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblMainTitle.Size = New System.Drawing.Size(109, 18)
        Me.lblMainTitle.TabIndex = 1
        Me.lblMainTitle.Text = "JAM's Test Generator"
        '
        'lblMainText1
        '
        Me.lblMainText1.AutoSize = True
        Me.lblMainText1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainText1.Location = New System.Drawing.Point(12, 44)
        Me.lblMainText1.Name = "lblMainText1"
        Me.lblMainText1.Size = New System.Drawing.Size(247, 26)
        Me.lblMainText1.TabIndex = 2
        Me.lblMainText1.Text = "This Program administers and records your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "answers to a True/False test." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblMainText2
        '
        Me.lblMainText2.AutoSize = True
        Me.lblMainText2.Location = New System.Drawing.Point(12, 82)
        Me.lblMainText2.Name = "lblMainText2"
        Me.lblMainText2.Size = New System.Drawing.Size(254, 91)
        Me.lblMainText2.TabIndex = 3
        Me.lblMainText2.Text = resources.GetString("lblMainText2.Text")
        '
        'lblMainText3
        '
        Me.lblMainText3.AutoSize = True
        Me.lblMainText3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainText3.Location = New System.Drawing.Point(55, 160)
        Me.lblMainText3.Name = "lblMainText3"
        Me.lblMainText3.Size = New System.Drawing.Size(204, 13)
        Me.lblMainText3.TabIndex = 4
        Me.lblMainText3.Text = "Note: you can only take the test one time."
        '
        'btnTakeTest
        '
        Me.btnTakeTest.Location = New System.Drawing.Point(58, 193)
        Me.btnTakeTest.Name = "btnTakeTest"
        Me.btnTakeTest.Size = New System.Drawing.Size(138, 31)
        Me.btnTakeTest.TabIndex = 5
        Me.btnTakeTest.Text = "Take Test"
        Me.btnTakeTest.UseVisualStyleBackColor = True
        '
        'btnExitTestGen
        '
        Me.btnExitTestGen.Location = New System.Drawing.Point(58, 247)
        Me.btnExitTestGen.Name = "btnExitTestGen"
        Me.btnExitTestGen.Size = New System.Drawing.Size(138, 31)
        Me.btnExitTestGen.TabIndex = 6
        Me.btnExitTestGen.Text = "Exit TestGen"
        Me.btnExitTestGen.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExitTestGen)
        Me.Controls.Add(Me.btnTakeTest)
        Me.Controls.Add(Me.lblMainText3)
        Me.Controls.Add(Me.lblMainText2)
        Me.Controls.Add(Me.lblMainText1)
        Me.Controls.Add(Me.lblMainTitle)
        Me.Controls.Add(Me.MnuStripMain)
        Me.MainMenuStrip = Me.MnuStripMain
        Me.MaximumSize = New System.Drawing.Size(289, 348)
        Me.MinimumSize = New System.Drawing.Size(289, 348)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuStripMain As MenuStrip
    Friend WithEvents lblMainTitle As Label
    Friend WithEvents lblMainText1 As Label
    Friend WithEvents lblMainText2 As Label
    Friend WithEvents lblMainText3 As Label
    Friend WithEvents btnTakeTest As Button
    Friend WithEvents btnExitTestGen As Button
End Class
