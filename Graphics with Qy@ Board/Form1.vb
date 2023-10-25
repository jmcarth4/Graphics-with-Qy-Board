Public Class Form1
    Dim portState As Boolean                    'Enables serial communication
    Dim receiveByte(18) As Byte                 'Receive Data Bytes
    Public TXdata(3) As Byte                    'Byte array to transmit data to Qy@ board
    Dim vOut As String                          'Calculated voltage in for analog inputs
    Dim dOut As String                          'Calculated binary in for analog inputs   
    Dim receiveCount, TransmitCount As Double
    Dim newData As Integer                       'Received data
    Dim dataIn1, dataIn2, dataIn3, dataIn4, dataIn5, dataIn6, dataIn7, dataIn8 As Integer
    Public newX As Single
    Public newY As Single
    Public maxAmplidue As Integer
    Public lastX As Single
    Public lastY As Single
    Public timerloop As Integer
    Public width1 As Integer
    Public width2 As Integer
    Public width3 As Integer
    Public width4 As Integer
    Public width5 As Integer
    Public width6 As Integer
    Public width7 As Integer
    Public width8 As Integer
    Public width9 As Integer
    Dim gndHieght As Integer
    Public vPens As Pen

    Sub draw()


        gndHieght = GndTrackBar.Value
        VRefValueLabel.Text = GndTrackBar.Value

        maxAmplidue = AmpTrackBar.Value
        MaxAmVLabel.Text = AmpTrackBar.Value

        'newY = (Rnd() * maxAmplidue) + (PictureBox1.Height / 2) - (maxAmplidue / 2)


        newX = timerloop

        If AnIn1CheckBox.Checked = False Then
            newY = (Rnd() * maxAmplidue) + gndHieght - (maxAmplidue / 2)

        ElseIf AnIn1CheckBox.Checked = True Then
            newY = vOut + gndHieght '- (maxAmplidue / 2)
        End If
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, 0, newX + 1, PictureBox1.Height)
        PictureBox1.CreateGraphics.DrawLine(Pens.White, lastX, lastY, newX, newY)





        lastX = newX
        lastY = newY


    End Sub

    'Draw horizontal division every 12.5 % of picture box hieght (7 markers)
    Sub HDiv()
        Dim hieght1 As Integer
        Dim hieght2 As Integer
        Dim hieght3 As Integer
        Dim hieght4 As Integer
        Dim hieght5 As Integer
        Dim hieght6 As Integer
        Dim hieght7 As Integer


        hieght1 = PictureBox1.Height * 0.125
        hieght2 = PictureBox1.Height * 0.25
        hieght3 = PictureBox1.Height * 0.375
        hieght4 = PictureBox1.Height * 0.5
        hieght5 = PictureBox1.Height * 0.625
        hieght6 = PictureBox1.Height * 0.75
        hieght7 = PictureBox1.Height * 0.875

        vPens = Pens.Blue

        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght1, PictureBox1.Width, hieght1)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght2, PictureBox1.Width, hieght2)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght3, PictureBox1.Width, hieght3)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght4, PictureBox1.Width, hieght4)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght5, PictureBox1.Width, hieght5)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght6, PictureBox1.Width, hieght6)
        PictureBox1.CreateGraphics.DrawLine(vPens, newX + 1, hieght7, PictureBox1.Width, hieght7)
    End Sub

    Private Sub DefaultButton_Click(sender As Object, e As EventArgs) Handles DefaultButton.Click
        GndTrackBar.Value = 160
        AmpTrackBar.Value = 100
    End Sub








    'Displays serial port data in a list box and interacts with Qy@ board
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dataIn As String
        Dim inPut1, inPut2, inPut3, inPut4, inPut5, inPut6, inPut7, inPut8 As Integer
        If timerloop > 1000 Then
            draw()
            HDiv()

            timerloop = 0
        ElseIf timerloop = width2 Or timerloop = width1 Or timerloop = width3 Or timerloop = width4 Or
            timerloop = width5 Or timerloop = width6 Or timerloop = width7 Or timerloop = width8 Or
             timerloop = width9 Then
            vPens = Pens.Blue
            draw()
            HDiv()

        ElseIf timerloop = 1 Then
            lastX = 0
            vPens = Pens.Black
            draw()
            HDiv()

        Else
            vPens = Pens.Black

            draw()

            HDiv()


        End If
        timerloop += 1



        If AnIn1CheckBox.Checked = True Then


            dataIn = ""
            PortDataListBox.Items.Clear()
            PortDataListBox.Items.Add("Com port = " & SerialPort1.PortName)  'Show current baud rate
            PortDataListBox.Items.Add("Baud Rate = " & SerialPort1.BaudRate) 'Show current baud rate
            PortDataListBox.Items.Add("Data bits = " & SerialPort1.DataBits)
            PortDataListBox.Items.Add("Stop bits = " & SerialPort1.StopBits)
            PortDataListBox.Items.Add("Parity = " & SerialPort1.Parity)
            'Calls functions to talk to the different parts of the Qy@ board when serial communication is present
            If portState = True Then
                'Transmit and receive data from analog inputs when radio button enabled
                ' If AnIn1CheckBox.Checked = True Then
                AnalogIn()
                'End If
                'Transmit and receive data from digital inputs when radio button enabled

            End If
        End If
        'updates output label


        If newData > 0 Then                             'Test newData if >0 there is information to display
            Select Case newData
                Case = 8
                    inPut8 = dataIn8
                    newData -= 1
            End Select
            Select Case newData
                Case = 7
                    inPut7 = dataIn7
                    newData -= 1
            End Select
            Select Case newData
                Case = 6
                    inPut6 = dataIn6
                    newData -= 1
            End Select
            Select Case newData
                Case = 5
                    inPut5 = dataIn5
                    newData -= 1
            End Select
            Select Case newData
                Case = 4
                    inPut4 = dataIn4
                    newData -= 1
            End Select
            Select Case newData
                Case = 3
                    inPut3 = dataIn3
                    newData -= 1
            End Select
            Select Case newData
                Case = 2
                    inPut2 = dataIn2
                    newData -= 1
            End Select
            Select Case newData
                Case = 1
                    inPut1 = dataIn1
                    newData -= 1
            End Select
            'Update input RX label with new data
            RXLabel.Text = inPut1 & inPut2 & inPut2 & inPut3 & inPut4 & inPut5 & inPut6 & inPut7 & inPut8
        End If
    End Sub

    'Establishs communication and displays received data from the analog inputs
    Sub AnalogIn()
        'Each input is seperatly enabled using radio buttons
        'If AnIn1CheckBox.Checked = True Then
        TXdata(0) = 81                          'Send command for analog in 1
            TXdata(1) = 0
            TXdata(2) = 0
            SendData()
            AnVoltage()
            VA1Label.Text = vOut                   'Display input voltage
            DA1Label.Text = dOut                   'Display recieved binary value

        ' End If





    End Sub

    'Converts received byte 1 and 2 to binary value (0 to 1024) and voltage (0 to 3.3)
    Sub AnVoltage()
        Dim vPort As Double             'Variables to manipulate received data
        Dim n1 As Double
        Dim n2 As Double
        Dim n3 As Double
        Dim n4 As Double

        n1 = dataIn1 * 4
        n2 = dataIn2 / 64
        n3 = Fix(n1 + n2)
        n4 = 3.3 / 1023
        vPort = n4 * n3
        vOut = Format(vPort, "n")
        dOut = n3
    End Sub



    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub
    'Loads serial settings when load the form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clears old Com Ports
        portState = False                              'Disables serial port

        SerialPort1.BaudRate = 9600                    '9600 baud rate
        SerialPort1.DataBits = 8                       '8 data bits
        SerialPort1.StopBits = IO.Ports.StopBits.One   '1 stop bit
        SerialPort1.Parity = IO.Ports.Parity.None      'no Parity

        Timer1.Enabled = True                           'timer set to 100 ms

        AnIn1CheckBox.Checked = False


        timerloop = 1
        width1 = PictureBox1.Width * 0.1
        width2 = PictureBox1.Width * 0.2
        width3 = PictureBox1.Width * 0.3
        width4 = PictureBox1.Width * 0.4
        width5 = PictureBox1.Width * 0.5
        width6 = PictureBox1.Width * 0.6
        width7 = PictureBox1.Width * 0.7
        width8 = PictureBox1.Width * 0.8
        width9 = PictureBox1.Width * 0.9
        GndTrackBar.Value = 160
        GndTrackBar.Maximum = PictureBox1.Height
        AmpTrackBar.Value = 100

    End Sub
    'Sends byte array to serial port
    Function SendData() As Byte
        Timer1.Enabled = False                                 'Disable timer when writing to serial port
        If portState = True Then
            SerialPort1.Write(TXdata, 0, 3)                    'Write byte array to serial port
            TXLabel.Text = TXdata(0) & TXdata(1) & TXdata(2)   'Value of byte array displayed for user to see
        Else
            MsgBox("Please configure and open serial port to procede")
        End If
        Timer1.Enabled = True

    End Function



    'Asynchronous Serial receive subroutine triggered by serial receive event
    Private Sub DataReceived(sender As Object, e As EventArgs) Handles SerialPort1.DataReceived
        receiveCount += 1                                           'increment recieve byte counter
        SerialPort1.Read(receiveByte, 0, 4)                         'read serial buffer value

        Select Case newData                                         'test case to determine where to place info
            Case = 0

                dataIn1 = receiveByte(0)
            Case = 1
                dataIn2 = receiveByte(0)
            Case = 2
                dataIn3 = receiveByte(0)
            Case = 3
                dataIn4 = receiveByte(0)
            Case = 4
                dataIn5 = receiveByte(0)
            Case = 5
                dataIn6 = receiveByte(0)
            Case = 6
                dataIn7 = receiveByte(0)
            Case = 7
                dataIn8 = receiveByte(0)

            Case Else
                newData = 0                                             'possible over flow, reset newData
                Exit Sub

        End Select
        newData += 1                                                    'Increment newData once loop is complete
    End Sub



    'Finds and list all com ports present on the system
    Private Sub ComPortButton_Click(sender As Object, e As EventArgs) Handles ComPortButton.Click
        ComPortListBox.Items.Clear()                                    'Clears past com ports
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComPortListBox.Items.Add(sp)                                'Loads all current com ports to list box
        Next
    End Sub

    'Activates selected comport
    Private Sub PortOpenButton_Click(sender As Object, e As EventArgs) Handles PortOpenButton.Click
        If PortOpenButton.Text = "Connect" Then                     'Com port is disconnected. Press button to connect.
            Try
                SerialPort1.Open()
                PortOpenButton.Text = "Disconnect"                  'Displays that con port is connected
                portState = True                                    'To disconnect press button again
            Catch ex As Exception
                MsgBox("Port Already Open or Port Unavailable")     'Com port is disconnected. Press button to connect.
                PortOpenButton.Text = "Connect"
                portState = False
            End Try
        Else                                                        'Com port is disconnected. Press button to connect.
            Try                                                     'Com port stays disconned until button is pressed
                SerialPort1.Close()
            Catch ex As Exception

            End Try
            portState = False
            PortOpenButton.Text = "Connect"
        End If
    End Sub


    Private Sub ComPortList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortListBox.SelectedIndexChanged
        Try
            SerialPort1.Close()                             'Try to close port before change
        Catch ex As Exception

        End Try

        PortOpenButton.Text = "Connect"
        portState = False
        Try
            SerialPort1.BaudRate = ComPortListBox.SelectedItem 'See if baud rate data is in the list box
        Catch ex As Exception
            SerialPort1.PortName = ComPortListBox.SelectedItem 'Bot baud rate, save port name
        End Try
    End Sub

    'Loads baud rate values into list box




    'Closes Serial Ports when forms closes
    Private Sub Form1_UnLoad()
        Try
            SerialPort1.Close()                 'Closes serial port
        Catch ex As Exception

        End Try
    End Sub
End Class



