<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPicture
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
        Me.picVGA2 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        CType(Me.picVGA2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picVGA2
        '
        Me.picVGA2.Location = New System.Drawing.Point(6, 7)
        Me.picVGA2.Name = "picVGA2"
        Me.picVGA2.Size = New System.Drawing.Size(600, 400)
        Me.picVGA2.TabIndex = 0
        Me.picVGA2.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(233, 424)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(161, 13)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Click anywhere to close Window"
        '
        'frmPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.picVGA2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(620, 480)
        Me.MinimumSize = New System.Drawing.Size(620, 480)
        Me.Name = "frmPicture"
        Me.ShowIcon = False
        CType(Me.picVGA2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picVGA2 As PictureBox
    Friend WithEvents lbl1 As Label
End Class
