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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblCompanyAverage = New System.Windows.Forms.Label()
        Me.lblFirstAvg = New System.Windows.Forms.Label()
        Me.lblSecondAvg = New System.Windows.Forms.Label()
        Me.lblThirdAvg = New System.Windows.Forms.Label()
        Me.txtFirstEmployeeUnits = New System.Windows.Forms.TextBox()
        Me.txtSecondEmployeeUnits = New System.Windows.Forms.TextBox()
        Me.txtThirdEmployeeUnits = New System.Windows.Forms.TextBox()
        Me.lblStaticEmployee1 = New System.Windows.Forms.Label()
        Me.lblStaticEmployee2 = New System.Windows.Forms.Label()
        Me.lblStaticEmployee3 = New System.Windows.Forms.Label()
        Me.lblStaticUnits = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 311)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(92, 23)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(239, 311)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(126, 311)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(92, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblCompanyAverage
        '
        Me.lblCompanyAverage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCompanyAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCompanyAverage.Location = New System.Drawing.Point(12, 282)
        Me.lblCompanyAverage.Name = "lblCompanyAverage"
        Me.lblCompanyAverage.Size = New System.Drawing.Size(319, 26)
        Me.lblCompanyAverage.TabIndex = 3
        Me.lblCompanyAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFirstAvg
        '
        Me.lblFirstAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstAvg.Location = New System.Drawing.Point(12, 250)
        Me.lblFirstAvg.Name = "lblFirstAvg"
        Me.lblFirstAvg.Size = New System.Drawing.Size(95, 26)
        Me.lblFirstAvg.TabIndex = 4
        Me.lblFirstAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSecondAvg
        '
        Me.lblSecondAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecondAvg.Location = New System.Drawing.Point(126, 250)
        Me.lblSecondAvg.Name = "lblSecondAvg"
        Me.lblSecondAvg.Size = New System.Drawing.Size(92, 26)
        Me.lblSecondAvg.TabIndex = 5
        Me.lblSecondAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThirdAvg
        '
        Me.lblThirdAvg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThirdAvg.Location = New System.Drawing.Point(236, 250)
        Me.lblThirdAvg.Name = "lblThirdAvg"
        Me.lblThirdAvg.Size = New System.Drawing.Size(95, 26)
        Me.lblThirdAvg.TabIndex = 6
        Me.lblThirdAvg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFirstEmployeeUnits
        '
        Me.txtFirstEmployeeUnits.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstEmployeeUnits.Location = New System.Drawing.Point(12, 85)
        Me.txtFirstEmployeeUnits.Multiline = True
        Me.txtFirstEmployeeUnits.Name = "txtFirstEmployeeUnits"
        Me.txtFirstEmployeeUnits.ReadOnly = True
        Me.txtFirstEmployeeUnits.Size = New System.Drawing.Size(95, 162)
        Me.txtFirstEmployeeUnits.TabIndex = 7
        Me.txtFirstEmployeeUnits.TabStop = False
        Me.txtFirstEmployeeUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSecondEmployeeUnits
        '
        Me.txtSecondEmployeeUnits.BackColor = System.Drawing.SystemColors.Window
        Me.txtSecondEmployeeUnits.Location = New System.Drawing.Point(126, 85)
        Me.txtSecondEmployeeUnits.Multiline = True
        Me.txtSecondEmployeeUnits.Name = "txtSecondEmployeeUnits"
        Me.txtSecondEmployeeUnits.ReadOnly = True
        Me.txtSecondEmployeeUnits.Size = New System.Drawing.Size(92, 162)
        Me.txtSecondEmployeeUnits.TabIndex = 8
        Me.txtSecondEmployeeUnits.TabStop = False
        Me.txtSecondEmployeeUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtThirdEmployeeUnits
        '
        Me.txtThirdEmployeeUnits.BackColor = System.Drawing.SystemColors.Window
        Me.txtThirdEmployeeUnits.Location = New System.Drawing.Point(236, 85)
        Me.txtThirdEmployeeUnits.Multiline = True
        Me.txtThirdEmployeeUnits.Name = "txtThirdEmployeeUnits"
        Me.txtThirdEmployeeUnits.ReadOnly = True
        Me.txtThirdEmployeeUnits.Size = New System.Drawing.Size(95, 162)
        Me.txtThirdEmployeeUnits.TabIndex = 9
        Me.txtThirdEmployeeUnits.TabStop = False
        Me.txtThirdEmployeeUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStaticEmployee1
        '
        Me.lblStaticEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaticEmployee1.Location = New System.Drawing.Point(12, 59)
        Me.lblStaticEmployee1.Name = "lblStaticEmployee1"
        Me.lblStaticEmployee1.Size = New System.Drawing.Size(94, 23)
        Me.lblStaticEmployee1.TabIndex = 10
        Me.lblStaticEmployee1.Text = "Employee 1:"
        Me.lblStaticEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStaticEmployee2
        '
        Me.lblStaticEmployee2.Location = New System.Drawing.Point(126, 59)
        Me.lblStaticEmployee2.Name = "lblStaticEmployee2"
        Me.lblStaticEmployee2.Size = New System.Drawing.Size(92, 23)
        Me.lblStaticEmployee2.TabIndex = 11
        Me.lblStaticEmployee2.Text = "Employee 2:"
        Me.lblStaticEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStaticEmployee3
        '
        Me.lblStaticEmployee3.Location = New System.Drawing.Point(236, 59)
        Me.lblStaticEmployee3.Name = "lblStaticEmployee3"
        Me.lblStaticEmployee3.Size = New System.Drawing.Size(95, 23)
        Me.lblStaticEmployee3.TabIndex = 12
        Me.lblStaticEmployee3.Text = "Employee 3:"
        Me.lblStaticEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStaticUnits
        '
        Me.lblStaticUnits.AutoSize = True
        Me.lblStaticUnits.Location = New System.Drawing.Point(12, 35)
        Me.lblStaticUnits.Name = "lblStaticUnits"
        Me.lblStaticUnits.Size = New System.Drawing.Size(37, 13)
        Me.lblStaticUnits.TabIndex = 13
        Me.lblStaticUnits.Text = "Units: "
        Me.lblStaticUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Day 1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(55, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(52, 20)
        Me.TextBox1.TabIndex = 15
        '
        'Form1
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(343, 340)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStaticUnits)
        Me.Controls.Add(Me.lblStaticEmployee3)
        Me.Controls.Add(Me.lblStaticEmployee2)
        Me.Controls.Add(Me.lblStaticEmployee1)
        Me.Controls.Add(Me.txtThirdEmployeeUnits)
        Me.Controls.Add(Me.txtSecondEmployeeUnits)
        Me.Controls.Add(Me.txtFirstEmployeeUnits)
        Me.Controls.Add(Me.lblThirdAvg)
        Me.Controls.Add(Me.lblSecondAvg)
        Me.Controls.Add(Me.lblFirstAvg)
        Me.Controls.Add(Me.lblCompanyAverage)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped Per Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblCompanyAverage As Label
    Friend WithEvents lblFirstAvg As Label
    Friend WithEvents lblSecondAvg As Label
    Friend WithEvents lblThirdAvg As Label
    Friend WithEvents txtFirstEmployeeUnits As TextBox
    Friend WithEvents txtSecondEmployeeUnits As TextBox
    Friend WithEvents txtThirdEmployeeUnits As TextBox
    Friend WithEvents lblStaticEmployee1 As Label
    Friend WithEvents lblStaticEmployee2 As Label
    Friend WithEvents lblStaticEmployee3 As Label
    Friend WithEvents lblStaticUnits As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
