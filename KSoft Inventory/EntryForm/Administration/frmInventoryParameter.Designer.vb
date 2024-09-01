<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryParameter
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.RestrictionNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.SubmitButton = New System.Windows.Forms.Button
        CType(Me.RestrictionNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edit Restriction ( Days ) :"
        '
        'RestrictionNumericUpDown
        '
        Me.RestrictionNumericUpDown.Location = New System.Drawing.Point(173, 22)
        Me.RestrictionNumericUpDown.Name = "RestrictionNumericUpDown"
        Me.RestrictionNumericUpDown.Size = New System.Drawing.Size(68, 20)
        Me.RestrictionNumericUpDown.TabIndex = 1
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(267, 21)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(92, 23)
        Me.SubmitButton.TabIndex = 2
        Me.SubmitButton.Text = "Save"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'frmInventoryParameter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 60)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.RestrictionNumericUpDown)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInventoryParameter"
        Me.Text = "Inventory Parameter"
        CType(Me.RestrictionNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RestrictionNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
End Class
