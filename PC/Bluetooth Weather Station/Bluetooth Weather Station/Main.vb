Public Class Main
    Dim getTempStr As String = "AA000000"
    Dim getTempHiStr As String = "AA000100"
    Dim getTempLowStr As String = "AA000200"
    Dim getHumStr As String = "AA000300"
    Dim getHumHiStr As String = "AA000400"
    Dim getHumLowStr As String = "AA000500"
    Dim getTimeStr As String = "AA000600"
    Dim getAllStr As String = "AA000700"
    Dim setTempUnitStr As String = "AA0108"
    Dim setTempHiStr As String = "AA0109"
    Dim setTempLowStr As String = "AA010A"
    Dim setHumHiStr As String = "AA010B"
    Dim setHumLowStr As String = "AA010C"
    Dim setADCStr As String = "AA010D"
    Dim setTimeStr As String = "AA010E"


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
        getBox.Enabled = False
        setBox.Enabled = False
        dataTxt.ScrollBars = ScrollBars.Both
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
            getBox.Enabled = True
            setBox.Enabled = True
        End If

    End Sub

    Private Sub disBtn_Click(sender As Object, e As EventArgs) Handles disBtn.Click
        If spObj.IsOpen Then
            spObj.Close()
            addText("Port is closed.")
            msgBtn.Enabled = False
            disBtn.Enabled = False
            connectBtn.Enabled = True
            getBox.Enabled = False
            setBox.Enabled = True
        End If
    End Sub

    Private Sub msgBtn_Click(sender As Object, e As EventArgs) Handles msgBtn.Click

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
        If tempString.Length = 0 Then
            addText("No data to send")
            Exit Sub
        End If

        If Not (spObj.IsOpen) Then
            addText("Port is not open")
            Exit Sub
        End If

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

    Private Function checkSumCreator(tempString As String) As String
        Dim i As Integer
        Dim csStr As String
        For x = 0 To tempString.Length - 1 Step 2
            i += Convert.ToInt32(tempString.Substring(x, 2), 16)
        Next
        csStr = Conversion.Hex(i)
        Return csStr.Substring(csStr.Length - 2)

    End Function

    Private Sub csBtn_Click(sender As Object, e As EventArgs) Handles csBtn.Click
        Dim csString As String
        If msgTxt.TextLength = 0 Or msgTxt.TextLength Mod 2 = 1 Then
            addText("Checksum fail, either no data or not the right number of bytes")
            Exit Sub
        End If
        csString = checkSumCreator(msgTxt.Text)
        csTxt.Text = csString
        msgTxt.Text &= csString
    End Sub

    Private Sub tempCRad_CheckedChanged(sender As Object, e As EventArgs) Handles tempCRad.CheckedChanged

    End Sub

    Private Sub getTBtn_Click(sender As Object, e As EventArgs) Handles getTBtn.Click
        Dim dataStr As String = getTempStr + checkSumCreator(getTempStr) + vbLf
        masterSlaveComm(dataStr)
    End Sub

    Private Sub getTHiBtn_Click(sender As Object, e As EventArgs) Handles getTHiBtn.Click
        Dim dataStr As String = getTempHiStr + checkSumCreator(getTempHiStr) + vbLf
        masterSlaveComm(dataStr)
    End Sub

    Private Sub getTLoBtn_Click(sender As Object, e As EventArgs) Handles getTLoBtn.Click
        Dim dataStr As String = getTempLowStr + checkSumCreator(getTempLowStr) + vbLf
        masterSlaveComm(dataStr)
    End Sub

    Private Sub getHBtn_Click(sender As Object, e As EventArgs) Handles getHBtn.Click
        Dim dataStr As String = getHumStr + checkSumCreator(getHumStr) + vbLf
        masterSlaveComm(dataStr)
    End Sub

    Private Sub getHHiBtn_Click(sender As Object, e As EventArgs) Handles getHHiBtn.Click
        Dim dataStr As String = getHumHiStr + checkSumCreator(getHumHiStr) + vbLf
        masterSlaveComm(dataStr)
    End Sub

    Private Sub getHLoBtn_Click(sender As Object, e As EventArgs) Handles getHLoBtn.Click
        Dim dataStr As String = getHumLowStr + checkSumCreator(getHumLowStr) + vbLf
        masterSlaveComm(dataStr)
    End Sub

    Private Sub getTimeBtn_Click(sender As Object, e As EventArgs) Handles getTimeBtn.Click
        Dim dataStr As String = getTimeStr + checkSumCreator(getTimeStr) + vbLf
        masterSlaveComm(dataStr)
    End Sub

    Private Sub getAllBtn_Click(sender As Object, e As EventArgs) Handles getAllBtn.Click
        Dim dataStr As String = getAllStr + checkSumCreator(getAllStr) + vbLf
        masterSlaveComm(dataStr)
    End Sub
End Class
