Public Class Form2


    'TODO ADD BAUD RATE
    'ADD WRITE TO FILE

    Dim portState As Boolean                    'Enables serial communication

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComPortComboBox.Items.Clear()                                    'Clears past com ports
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComPortComboBox.Items.Add(sp)                                'Loads all current com ports to list box
        Next
        Try
            SerialPort1.Close()                             'Try to close port before change
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComPortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortComboBox.SelectedIndexChanged
        ReadComPorts()
    End Sub
    Sub ReadComPorts()
        PortOpenButton.Text = "Connect"
        portState = False
        Try
            SerialPort1.BaudRate = ComPortComboBox.SelectedItem 'See if baud rate data is in the list box
        Catch ex As Exception
            SerialPort1.PortName = ComPortComboBox.SelectedItem 'Bot baud rate, save port name
        End Try
    End Sub
    'TODO add baud rate list 
    Private Sub BaudRateComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BaudRateComboBox.SelectedIndexChanged

    End Sub
    Private Sub HideButton_Click(sender As Object, e As EventArgs) Handles HideButton.Click
        Me.Hide()
    End Sub

    'Not need
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

    'not need
    'Private Sub ComPortList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPortListBox.SelectedIndexChanged

    '    Try
    '        SerialPort1.Close()                             'Try to close port before change
    '    Catch ex As Exception

    '    End Try

    '    PortOpenButton.Text = "Connect"
    '    portState = False
    '    Try
    '        SerialPort1.BaudRate = ComPortListBox.SelectedItem 'See if baud rate data is in the list box
    '    Catch ex As Exception
    '        SerialPort1.PortName = ComPortListBox.SelectedItem 'Bot baud rate, save port name
    '    End Try
    'End Sub


End Class