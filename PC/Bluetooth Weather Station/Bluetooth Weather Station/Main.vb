Public Class Main
    Dim _continue As Boolean

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        If spObj.IsOpen Then
            spObj.Close()
        End If
        End
    End Sub

    Private Sub portsBtn_Click(sender As Object, e As EventArgs) Handles portsBtn.Click
        For Each sp As String In My.Computer.Ports.SerialPortNames
            portsCmb.Items.Add(sp)
            addText("Port " + sp + " added.")
        Next
    End Sub

    Private Sub portsCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles portsCmb.SelectedIndexChanged
        connectBtn.Enabled = True
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connectBtn.Enabled = False
        msgBtn.Enabled = False
        disBtn.Enabled = False
    End Sub

    Private Sub connectBtn_Click(sender As Object, e As EventArgs) Handles connectBtn.Click
        spObj.PortName = portsCmb.Text

        addText("Connecting to " + portsCmb.Text)
        If spObj.IsOpen Then
            spObj.Close()
        End If

        spObj.Open()
        If spObj.IsOpen Then
            addText("Port is open.")
            msgBtn.Enabled = True
            disBtn.Enabled = True
            connectBtn.Enabled = False
            _continue = True
        End If

    End Sub

    Private Sub disBtn_Click(sender As Object, e As EventArgs) Handles disBtn.Click
        If spObj.IsOpen Then
            spObj.Close()
            addText("Port is closed.")
            msgBtn.Enabled = False
            disBtn.Enabled = False
            connectBtn.Enabled = True
        End If
    End Sub

    Private Sub msgBtn_Click(sender As Object, e As EventArgs) Handles msgBtn.Click
        If msgTxt.TextLength = 0 Then
            addText("No data to send")
            Exit Sub
        End If

        If Not (spObj.IsOpen) Then
            addText("Port is not open")
            Exit Sub
        End If

        masterSlaveComm(msgTxt.Text + vbLf)


    End Sub

    Private Sub addText(tempString As String)
        If dataTxt.TextLength = 0 Then
            dataTxt.Text = tempString
        Else
            dataTxt.Text = dataTxt.Text + vbCrLf + tempString
        End If
    End Sub

    Private Sub masterSlaveComm(tempString As String)
        spObj.Write(tempString)
        addText("Message sent")
        Dim decIn As String = ""
        Dim charIn As String = ""
        Try
            Do
                Dim incoming As String = spObj.ReadByte
                If incoming Is Nothing Then
                    Exit Do
                Else
                    decIn &= incoming & " "
                    charIn &= Chr(incoming) & " "
                End If
            Loop
        Catch ex As TimeoutException

        End Try
        addText(decIn)
        addText(charIn)
    End Sub
End Class
