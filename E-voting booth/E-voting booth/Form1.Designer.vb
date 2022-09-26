<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblanswer = New System.Windows.Forms.Label()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtparty = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Richfield Voting center!!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(353, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the name of the party you wish to vote for"
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.Location = New System.Drawing.Point(6, 320)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(10, 13)
        Me.lblanswer.TabIndex = 2
        Me.lblanswer.Text = " "
        '
        'btnVote
        '
        Me.btnVote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVote.Location = New System.Drawing.Point(55, 233)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(75, 23)
        Me.btnVote.TabIndex = 3
        Me.btnVote.Text = "Vote!"
        Me.btnVote.UseVisualStyleBackColor = True
        '
        'btnResult
        '
        Me.btnResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResult.Location = New System.Drawing.Point(169, 233)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(75, 23)
        Me.btnResult.TabIndex = 4
        Me.btnResult.Text = "Result"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(274, 233)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtparty
        '
        Me.txtparty.Location = New System.Drawing.Point(128, 154)
        Me.txtparty.Name = "txtparty"
        Me.txtparty.Size = New System.Drawing.Size(164, 20)
        Me.txtparty.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 358)
        Me.Controls.Add(Me.txtparty)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Textbox E-voting booth"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblanswer As Label
    Friend WithEvents btnVote As Button
    Friend WithEvents btnResult As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtparty As TextBox
End Class
