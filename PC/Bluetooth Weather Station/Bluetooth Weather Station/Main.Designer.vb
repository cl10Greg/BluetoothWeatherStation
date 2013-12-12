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
        Me.csBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.csTxt = New System.Windows.Forms.TextBox()
        Me.getBox = New System.Windows.Forms.GroupBox()
        Me.getAllBtn = New System.Windows.Forms.Button()
        Me.getTimeBtn = New System.Windows.Forms.Button()
        Me.getHLoBtn = New System.Windows.Forms.Button()
        Me.getHHiBtn = New System.Windows.Forms.Button()
        Me.getTLoBtn = New System.Windows.Forms.Button()
        Me.getTHiBtn = New System.Windows.Forms.Button()
        Me.getHBtn = New System.Windows.Forms.Button()
        Me.getTBtn = New System.Windows.Forms.Button()
        Me.setBox = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.adcTxt = New System.Windows.Forms.TextBox()
        Me.setADCRateBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.hHiNum = New System.Windows.Forms.NumericUpDown()
        Me.tHiNum = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hLowNum = New System.Windows.Forms.NumericUpDown()
        Me.tLowNum = New System.Windows.Forms.NumericUpDown()
        Me.setHRangeBtn = New System.Windows.Forms.Button()
        Me.setTRangeBtn = New System.Windows.Forms.Button()
        Me.tempFRad = New System.Windows.Forms.RadioButton()
        Me.tempCRad = New System.Windows.Forms.RadioButton()
        Me.setTUnitBtn = New System.Windows.Forms.Button()
        Me.getBox.SuspendLayout()
        Me.setBox.SuspendLayout()
        CType(Me.hHiNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tHiNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hLowNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tLowNum, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.exitBtn.Location = New System.Drawing.Point(20, 431)
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
        Me.msgBtn.Location = New System.Drawing.Point(249, 145)
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
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Message"
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
        Me.dataTxt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.dataTxt.Location = New System.Drawing.Point(409, 55)
        Me.dataTxt.Multiline = True
        Me.dataTxt.Name = "dataTxt"
        Me.dataTxt.ReadOnly = True
        Me.dataTxt.Size = New System.Drawing.Size(353, 197)
        Me.dataTxt.TabIndex = 11
        '
        'csBtn
        '
        Me.csBtn.Location = New System.Drawing.Point(249, 116)
        Me.csBtn.Name = "csBtn"
        Me.csBtn.Size = New System.Drawing.Size(107, 23)
        Me.csBtn.TabIndex = 12
        Me.csBtn.Text = "Add Checksum"
        Me.csBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Checksum:"
        '
        'csTxt
        '
        Me.csTxt.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.csTxt.Enabled = False
        Me.csTxt.Location = New System.Drawing.Point(83, 148)
        Me.csTxt.Name = "csTxt"
        Me.csTxt.Size = New System.Drawing.Size(100, 20)
        Me.csTxt.TabIndex = 14
        '
        'getBox
        '
        Me.getBox.Controls.Add(Me.getAllBtn)
        Me.getBox.Controls.Add(Me.getTimeBtn)
        Me.getBox.Controls.Add(Me.getHLoBtn)
        Me.getBox.Controls.Add(Me.getHHiBtn)
        Me.getBox.Controls.Add(Me.getTLoBtn)
        Me.getBox.Controls.Add(Me.getTHiBtn)
        Me.getBox.Controls.Add(Me.getHBtn)
        Me.getBox.Controls.Add(Me.getTBtn)
        Me.getBox.Location = New System.Drawing.Point(55, 261)
        Me.getBox.Name = "getBox"
        Me.getBox.Size = New System.Drawing.Size(296, 108)
        Me.getBox.TabIndex = 15
        Me.getBox.TabStop = False
        Me.getBox.Text = "Get Commands"
        '
        'getAllBtn
        '
        Me.getAllBtn.Location = New System.Drawing.Point(192, 77)
        Me.getAllBtn.Name = "getAllBtn"
        Me.getAllBtn.Size = New System.Drawing.Size(92, 23)
        Me.getAllBtn.TabIndex = 16
        Me.getAllBtn.Text = "Get All"
        Me.getAllBtn.UseVisualStyleBackColor = True
        '
        'getTimeBtn
        '
        Me.getTimeBtn.Location = New System.Drawing.Point(6, 77)
        Me.getTimeBtn.Name = "getTimeBtn"
        Me.getTimeBtn.Size = New System.Drawing.Size(75, 23)
        Me.getTimeBtn.TabIndex = 16
        Me.getTimeBtn.Text = "Get Time"
        Me.getTimeBtn.UseVisualStyleBackColor = True
        '
        'getHLoBtn
        '
        Me.getHLoBtn.Location = New System.Drawing.Point(192, 48)
        Me.getHLoBtn.Name = "getHLoBtn"
        Me.getHLoBtn.Size = New System.Drawing.Size(92, 23)
        Me.getHLoBtn.TabIndex = 16
        Me.getHLoBtn.Text = "Get Humid Low"
        Me.getHLoBtn.UseVisualStyleBackColor = True
        '
        'getHHiBtn
        '
        Me.getHHiBtn.Location = New System.Drawing.Point(87, 48)
        Me.getHHiBtn.Name = "getHHiBtn"
        Me.getHHiBtn.Size = New System.Drawing.Size(99, 23)
        Me.getHHiBtn.TabIndex = 16
        Me.getHHiBtn.Text = "Get Humid High"
        Me.getHHiBtn.UseVisualStyleBackColor = True
        '
        'getTLoBtn
        '
        Me.getTLoBtn.Location = New System.Drawing.Point(192, 19)
        Me.getTLoBtn.Name = "getTLoBtn"
        Me.getTLoBtn.Size = New System.Drawing.Size(92, 23)
        Me.getTLoBtn.TabIndex = 16
        Me.getTLoBtn.Text = "Get Temp Low"
        Me.getTLoBtn.UseVisualStyleBackColor = True
        '
        'getTHiBtn
        '
        Me.getTHiBtn.Location = New System.Drawing.Point(87, 19)
        Me.getTHiBtn.Name = "getTHiBtn"
        Me.getTHiBtn.Size = New System.Drawing.Size(99, 23)
        Me.getTHiBtn.TabIndex = 16
        Me.getTHiBtn.Text = "Get Temp High"
        Me.getTHiBtn.UseVisualStyleBackColor = True
        '
        'getHBtn
        '
        Me.getHBtn.Location = New System.Drawing.Point(6, 48)
        Me.getHBtn.Name = "getHBtn"
        Me.getHBtn.Size = New System.Drawing.Size(75, 23)
        Me.getHBtn.TabIndex = 16
        Me.getHBtn.Text = "Get Humid"
        Me.getHBtn.UseVisualStyleBackColor = True
        '
        'getTBtn
        '
        Me.getTBtn.Location = New System.Drawing.Point(6, 19)
        Me.getTBtn.Name = "getTBtn"
        Me.getTBtn.Size = New System.Drawing.Size(75, 23)
        Me.getTBtn.TabIndex = 0
        Me.getTBtn.Text = "Get Temp"
        Me.getTBtn.UseVisualStyleBackColor = True
        '
        'setBox
        '
        Me.setBox.Controls.Add(Me.Label11)
        Me.setBox.Controls.Add(Me.adcTxt)
        Me.setBox.Controls.Add(Me.setADCRateBtn)
        Me.setBox.Controls.Add(Me.Label8)
        Me.setBox.Controls.Add(Me.Label7)
        Me.setBox.Controls.Add(Me.Label9)
        Me.setBox.Controls.Add(Me.Label6)
        Me.setBox.Controls.Add(Me.hHiNum)
        Me.setBox.Controls.Add(Me.tHiNum)
        Me.setBox.Controls.Add(Me.Label10)
        Me.setBox.Controls.Add(Me.Label5)
        Me.setBox.Controls.Add(Me.hLowNum)
        Me.setBox.Controls.Add(Me.tLowNum)
        Me.setBox.Controls.Add(Me.setHRangeBtn)
        Me.setBox.Controls.Add(Me.setTRangeBtn)
        Me.setBox.Controls.Add(Me.tempFRad)
        Me.setBox.Controls.Add(Me.tempCRad)
        Me.setBox.Controls.Add(Me.setTUnitBtn)
        Me.setBox.Location = New System.Drawing.Point(409, 261)
        Me.setBox.Name = "setBox"
        Me.setBox.Size = New System.Drawing.Size(296, 214)
        Me.setBox.TabIndex = 16
        Me.setBox.TabStop = False
        Me.setBox.Text = "Set Commands"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(222, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "ms"
        '
        'adcTxt
        '
        Me.adcTxt.Location = New System.Drawing.Point(151, 167)
        Me.adcTxt.Name = "adcTxt"
        Me.adcTxt.Size = New System.Drawing.Size(57, 20)
        Me.adcTxt.TabIndex = 17
        '
        'setADCRateBtn
        '
        Me.setADCRateBtn.Location = New System.Drawing.Point(6, 165)
        Me.setADCRateBtn.Name = "setADCRateBtn"
        Me.setADCRateBtn.Size = New System.Drawing.Size(124, 23)
        Me.setADCRateBtn.TabIndex = 17
        Me.setADCRateBtn.Text = "Set ADC Refresh Rate"
        Me.setADCRateBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(235, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "High"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(222, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "High"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Low"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(117, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Low"
        '
        'hHiNum
        '
        Me.hHiNum.Location = New System.Drawing.Point(229, 102)
        Me.hHiNum.Maximum = New Decimal(New Integer() {155, 0, 0, 0})
        Me.hHiNum.Minimum = New Decimal(New Integer() {55, 0, 0, -2147483648})
        Me.hHiNum.Name = "hHiNum"
        Me.hHiNum.Size = New System.Drawing.Size(45, 20)
        Me.hHiNum.TabIndex = 24
        '
        'tHiNum
        '
        Me.tHiNum.Location = New System.Drawing.Point(216, 51)
        Me.tHiNum.Maximum = New Decimal(New Integer() {155, 0, 0, 0})
        Me.tHiNum.Minimum = New Decimal(New Integer() {55, 0, 0, -2147483648})
        Me.tHiNum.Name = "tHiNum"
        Me.tHiNum.Size = New System.Drawing.Size(45, 20)
        Me.tHiNum.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(188, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(175, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "To"
        '
        'hLowNum
        '
        Me.hLowNum.Location = New System.Drawing.Point(124, 102)
        Me.hLowNum.Maximum = New Decimal(New Integer() {155, 0, 0, 0})
        Me.hLowNum.Minimum = New Decimal(New Integer() {55, 0, 0, -2147483648})
        Me.hLowNum.Name = "hLowNum"
        Me.hLowNum.Size = New System.Drawing.Size(45, 20)
        Me.hLowNum.TabIndex = 23
        '
        'tLowNum
        '
        Me.tLowNum.Location = New System.Drawing.Point(111, 51)
        Me.tLowNum.Maximum = New Decimal(New Integer() {155, 0, 0, 0})
        Me.tLowNum.Minimum = New Decimal(New Integer() {55, 0, 0, -2147483648})
        Me.tLowNum.Name = "tLowNum"
        Me.tLowNum.Size = New System.Drawing.Size(45, 20)
        Me.tLowNum.TabIndex = 17
        '
        'setHRangeBtn
        '
        Me.setHRangeBtn.Location = New System.Drawing.Point(6, 113)
        Me.setHRangeBtn.Name = "setHRangeBtn"
        Me.setHRangeBtn.Size = New System.Drawing.Size(105, 23)
        Me.setHRangeBtn.TabIndex = 25
        Me.setHRangeBtn.Text = "Set Humid Range"
        Me.setHRangeBtn.UseVisualStyleBackColor = True
        '
        'setTRangeBtn
        '
        Me.setTRangeBtn.Location = New System.Drawing.Point(6, 58)
        Me.setTRangeBtn.Name = "setTRangeBtn"
        Me.setTRangeBtn.Size = New System.Drawing.Size(96, 23)
        Me.setTRangeBtn.TabIndex = 19
        Me.setTRangeBtn.Text = "Set Temp Range"
        Me.setTRangeBtn.UseVisualStyleBackColor = True
        '
        'tempFRad
        '
        Me.tempFRad.AutoSize = True
        Me.tempFRad.Location = New System.Drawing.Point(192, 22)
        Me.tempFRad.Name = "tempFRad"
        Me.tempFRad.Size = New System.Drawing.Size(69, 17)
        Me.tempFRad.TabIndex = 18
        Me.tempFRad.Text = "Farenheit"
        Me.tempFRad.UseVisualStyleBackColor = True
        '
        'tempCRad
        '
        Me.tempCRad.AutoSize = True
        Me.tempCRad.Checked = True
        Me.tempCRad.Location = New System.Drawing.Point(111, 22)
        Me.tempCRad.Name = "tempCRad"
        Me.tempCRad.Size = New System.Drawing.Size(58, 17)
        Me.tempCRad.TabIndex = 17
        Me.tempCRad.TabStop = True
        Me.tempCRad.Text = "Celsius"
        Me.tempCRad.UseVisualStyleBackColor = True
        '
        'setTUnitBtn
        '
        Me.setTUnitBtn.Location = New System.Drawing.Point(6, 19)
        Me.setTUnitBtn.Name = "setTUnitBtn"
        Me.setTUnitBtn.Size = New System.Drawing.Size(88, 23)
        Me.setTUnitBtn.TabIndex = 17
        Me.setTUnitBtn.Text = "Set Temp Units"
        Me.setTUnitBtn.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 469)
        Me.Controls.Add(Me.setBox)
        Me.Controls.Add(Me.getBox)
        Me.Controls.Add(Me.csTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.csBtn)
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
        Me.getBox.ResumeLayout(False)
        Me.setBox.ResumeLayout(False)
        Me.setBox.PerformLayout()
        CType(Me.hHiNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tHiNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hLowNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tLowNum, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents csBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents csTxt As System.Windows.Forms.TextBox
    Friend WithEvents getBox As System.Windows.Forms.GroupBox
    Friend WithEvents getHBtn As System.Windows.Forms.Button
    Friend WithEvents getTBtn As System.Windows.Forms.Button
    Friend WithEvents getHLoBtn As System.Windows.Forms.Button
    Friend WithEvents getHHiBtn As System.Windows.Forms.Button
    Friend WithEvents getTLoBtn As System.Windows.Forms.Button
    Friend WithEvents getTHiBtn As System.Windows.Forms.Button
    Friend WithEvents getAllBtn As System.Windows.Forms.Button
    Friend WithEvents getTimeBtn As System.Windows.Forms.Button
    Friend WithEvents setBox As System.Windows.Forms.GroupBox
    Friend WithEvents tempFRad As System.Windows.Forms.RadioButton
    Friend WithEvents tempCRad As System.Windows.Forms.RadioButton
    Friend WithEvents setTUnitBtn As System.Windows.Forms.Button
    Friend WithEvents tHiNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tLowNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents setTRangeBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents hHiNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents hLowNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents setHRangeBtn As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents adcTxt As System.Windows.Forms.TextBox
    Friend WithEvents setADCRateBtn As System.Windows.Forms.Button

End Class
