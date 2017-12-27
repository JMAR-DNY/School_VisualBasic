<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntermediate
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
        Me.lblIntTitle = New System.Windows.Forms.Label()
        Me.lblNumberText = New System.Windows.Forms.Label()
        Me.cboNumSelector = New System.Windows.Forms.ComboBox()
        Me.btnBeginTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MnuStripMain
        '
        Me.MnuStripMain.AutoSize = False
        Me.MnuStripMain.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MnuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuStripMain.Name = "MnuStripMain"
        Me.MnuStripMain.Size = New System.Drawing.Size(273, 24)
        Me.MnuStripMain.TabIndex = 1
        Me.MnuStripMain.Text = "JAM's Test Generator"
        '
        'lblIntTitle
        '
        Me.lblIntTitle.AutoSize = True
        Me.lblIntTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblIntTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblIntTitle.Location = New System.Drawing.Point(12, 0)
        Me.lblIntTitle.Name = "lblIntTitle"
        Me.lblIntTitle.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.lblIntTitle.Size = New System.Drawing.Size(112, 18)
        Me.lblIntTitle.TabIndex = 2
        Me.lblIntTitle.Text = "Number of Questions?"
        '
        'lblNumberText
        '
        Me.lblNumberText.AutoSize = True
        Me.lblNumberText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberText.Location = New System.Drawing.Point(48, 51)
        Me.lblNumberText.Name = "lblNumberText"
        Me.lblNumberText.Size = New System.Drawing.Size(183, 39)
        Me.lblNumberText.TabIndex = 3
        Me.lblNumberText.Text = "Select the number of questions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for your test:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cboNumSelector
        '
        Me.cboNumSelector.FormattingEnabled = True
        Me.cboNumSelector.Items.AddRange(New Object() {"5", "10", "15", "20", "25"})
        Me.cboNumSelector.Location = New System.Drawing.Point(104, 93)
        Me.cboNumSelector.Name = "cboNumSelector"
        Me.cboNumSelector.Size = New System.Drawing.Size(46, 21)
        Me.cboNumSelector.TabIndex = 4
        Me.cboNumSelector.Text = "5"
        '
        'btnBeginTest
        '
        Me.btnBeginTest.Location = New System.Drawing.Point(65, 129)
        Me.btnBeginTest.Name = "btnBeginTest"
        Me.btnBeginTest.Size = New System.Drawing.Size(138, 31)
        Me.btnBeginTest.TabIndex = 6
        Me.btnBeginTest.Text = "Begin Test"
        Me.btnBeginTest.UseVisualStyleBackColor = True
        '
        'frmIntermediate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBeginTest)
        Me.Controls.Add(Me.cboNumSelector)
        Me.Controls.Add(Me.lblNumberText)
        Me.Controls.Add(Me.lblIntTitle)
        Me.Controls.Add(Me.MnuStripMain)
        Me.MaximumSize = New System.Drawing.Size(289, 239)
        Me.MinimumSize = New System.Drawing.Size(289, 239)
        Me.Name = "frmIntermediate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuStripMain As MenuStrip
    Friend WithEvents lblIntTitle As Label
    Friend WithEvents lblNumberText As Label
    Friend WithEvents cboNumSelector As ComboBox
    Friend WithEvents btnBeginTest As Button
End Class
