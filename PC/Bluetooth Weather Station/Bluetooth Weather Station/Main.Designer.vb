<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.portsBtn = New System.Windows.Forms.Button()
        Me.portsCmb = New System.Windows.Forms.ComboBox()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.connectBtn = New System.Windows.Forms.Button()
        Me.spObj = New System.IO.Ports.SerialPort(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.disBtn = New System.Windows.Forms.Button()
        Me.msgBtn = New System.Windows.Forms.Button()
        Me.msgTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dataTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'portsBtn
        '
        Me.portsBtn.Location = New System.Drawing.Point(249, 24)
        Me.portsBtn.Name = "portsBtn"
        Me.portsBtn.Size = New System.Drawing.Size(103, 23)
        Me.portsBtn.TabIndex = 0
        Me.portsBtn.Text = "Find Serial Ports"
        Me.portsBtn.UseVisualStyleBackColor = True
        '
        'portsCmb
        '
        Me.portsCmb.FormattingEnabled = True
        Me.portsCmb.Location = New System.Drawing.Point(122, 26)
        Me.portsCmb.Name = "portsCmb"
        Me.portsCmb.Size = New System.Drawing.Size(121, 21)
        Me.portsCmb.TabIndex = 1
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(34, 576)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 2
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'connectBtn
        '
        Me.connectBtn.Location = New System.Drawing.Point(249, 55)
        Me.connectBtn.Name = "connectBtn"
        Me.connectBtn.Size = New System.Drawing.Size(110, 23)
        Me.connectBtn.TabIndex = 3
        Me.connectBtn.Text = "Connect"
        Me.connectBtn.UseVisualStyleBackColor = True
        '
        'spObj
        '
        Me.spObj.ReadTimeout = 1000
        Me.spObj.WriteTimeout = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Port Name"
        '
        'disBtn
        '
        Me.disBtn.Location = New System.Drawing.Point(249, 84)
        Me.disBtn.Name = "disBtn"
        Me.disBtn.Size = New System.Drawing.Size(110, 23)
        Me.disBtn.TabIndex = 6
        Me.disBtn.Text = "Disconnect"
        Me.disBtn.UseVisualStyleBackColor = True
        '
        'msgBtn
        '
        Me.msgBtn.Location = New System.Drawing.Point(249, 113)
        Me.msgBtn.Name = "msgBtn"
        Me.msgBtn.Size = New System.Drawing.Size(110, 23)
        Me.msgBtn.TabIndex = 7
        Me.msgBtn.Text = "Send Message"
        Me.msgBtn.UseVisualStyleBackColor = True
        '
        'msgTxt
        '
        Me.msgTxt.Location = New System.Drawing.Point(12, 116)
        Me.msgTxt.Name = "msgTxt"
        Me.msgTxt.Size = New System.Drawing.Size(218, 20)
        Me.msgTxt.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Messages"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Port Comm"
        '
        'dataTxt
        '
        Me.dataTxt.Location = New System.Drawing.Point(409, 55)
        Me.dataTxt.Multiline = True
        Me.dataTxt.Name = "dataTxt"
        Me.dataTxt.Size = New System.Drawing.Size(353, 197)
        Me.dataTxt.TabIndex = 11
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 611)
        Me.Controls.Add(Me.dataTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.msgTxt)
        Me.Controls.Add(Me.msgBtn)
        Me.Controls.Add(Me.disBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.connectBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.portsCmb)
        Me.Controls.Add(Me.portsBtn)
        Me.Name = "Main"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents portsBtn As System.Windows.Forms.Button
    Friend WithEvents portsCmb As System.Windows.Forms.ComboBox
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents connectBtn As System.Windows.Forms.Button
    Friend WithEvents spObj As System.IO.Ports.SerialPort
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents disBtn As System.Windows.Forms.Button
    Friend WithEvents msgBtn As System.Windows.Forms.Button
    Friend WithEvents msgTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dataTxt As System.Windows.Forms.TextBox

End Class
