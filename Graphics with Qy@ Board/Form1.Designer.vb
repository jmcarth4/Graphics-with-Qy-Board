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
        Me.components = New System.ComponentModel.Container()
        Me.AInGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VA1Label = New System.Windows.Forms.Label()
        Me.DA1Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PortDataListBox = New System.Windows.Forms.ListBox()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.ComPortListBox = New System.Windows.Forms.ListBox()
        Me.ComPortButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXLabel = New System.Windows.Forms.Label()
        Me.RXLabel = New System.Windows.Forms.Label()
        Me.MaxAmVLabel = New System.Windows.Forms.Label()
        Me.AmpTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VDLabel = New System.Windows.Forms.Label()
        Me.TDLabel = New System.Windows.Forms.Label()
        Me.VRefValueLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GndTrackBar = New System.Windows.Forms.TrackBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AnIn1CheckBox = New System.Windows.Forms.CheckBox()
        Me.DefaultButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.AInGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AmpTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GndTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AInGroupBox
        '
        Me.AInGroupBox.Controls.Add(Me.Label6)
        Me.AInGroupBox.Controls.Add(Me.Label5)
        Me.AInGroupBox.Controls.Add(Me.VA1Label)
        Me.AInGroupBox.Controls.Add(Me.DA1Label)
        Me.AInGroupBox.Location = New System.Drawing.Point(1018, 105)
        Me.AInGroupBox.Name = "AInGroupBox"
        Me.AInGroupBox.Size = New System.Drawing.Size(217, 101)
        Me.AInGroupBox.TabIndex = 207
        Me.AInGroupBox.TabStop = False
        Me.AInGroupBox.Text = "Analog  Inputs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 209
        Me.Label6.Text = "Voltage In"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(136, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Binary In"
        '
        'VA1Label
        '
        Me.VA1Label.AutoSize = True
        Me.VA1Label.Location = New System.Drawing.Point(42, 63)
        Me.VA1Label.Name = "VA1Label"
        Me.VA1Label.Size = New System.Drawing.Size(44, 20)
        Me.VA1Label.TabIndex = 209
        Me.VA1Label.Text = "VA1 "
        '
        'DA1Label
        '
        Me.DA1Label.AutoSize = True
        Me.DA1Label.Location = New System.Drawing.Point(136, 63)
        Me.DA1Label.Name = "DA1Label"
        Me.DA1Label.Size = New System.Drawing.Size(45, 20)
        Me.DA1Label.TabIndex = 213
        Me.DA1Label.Text = "DA1 "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(1191, 621)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(68, 57)
        Me.QuitButton.TabIndex = 56
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'PortDataListBox
        '
        Me.PortDataListBox.FormattingEnabled = True
        Me.PortDataListBox.ItemHeight = 20
        Me.PortDataListBox.Location = New System.Drawing.Point(121, 20)
        Me.PortDataListBox.Name = "PortDataListBox"
        Me.PortDataListBox.Size = New System.Drawing.Size(173, 64)
        Me.PortDataListBox.TabIndex = 211
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(142, 111)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(140, 45)
        Me.PortOpenButton.TabIndex = 210
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'ComPortListBox
        '
        Me.ComPortListBox.FormattingEnabled = True
        Me.ComPortListBox.ItemHeight = 20
        Me.ComPortListBox.Location = New System.Drawing.Point(6, 25)
        Me.ComPortListBox.Name = "ComPortListBox"
        Me.ComPortListBox.Size = New System.Drawing.Size(109, 64)
        Me.ComPortListBox.TabIndex = 209
        '
        'ComPortButton
        '
        Me.ComPortButton.Location = New System.Drawing.Point(6, 110)
        Me.ComPortButton.Name = "ComPortButton"
        Me.ComPortButton.Size = New System.Drawing.Size(130, 46)
        Me.ComPortButton.TabIndex = 208
        Me.ComPortButton.Text = "Com Port"
        Me.ComPortButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXLabel)
        Me.GroupBox1.Controls.Add(Me.RXLabel)
        Me.GroupBox1.Controls.Add(Me.ComPortListBox)
        Me.GroupBox1.Controls.Add(Me.ComPortButton)
        Me.GroupBox1.Controls.Add(Me.PortDataListBox)
        Me.GroupBox1.Controls.Add(Me.PortOpenButton)
        Me.GroupBox1.Location = New System.Drawing.Point(1012, 355)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 234)
        Me.GroupBox1.TabIndex = 218
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TXLabel
        '
        Me.TXLabel.AutoSize = True
        Me.TXLabel.Location = New System.Drawing.Point(175, 195)
        Me.TXLabel.Name = "TXLabel"
        Me.TXLabel.Size = New System.Drawing.Size(29, 20)
        Me.TXLabel.TabIndex = 213
        Me.TXLabel.Text = "TX"
        '
        'RXLabel
        '
        Me.RXLabel.AutoSize = True
        Me.RXLabel.Location = New System.Drawing.Point(46, 195)
        Me.RXLabel.Name = "RXLabel"
        Me.RXLabel.Size = New System.Drawing.Size(32, 20)
        Me.RXLabel.TabIndex = 212
        Me.RXLabel.Text = "RX"
        '
        'MaxAmVLabel
        '
        Me.MaxAmVLabel.AutoSize = True
        Me.MaxAmVLabel.Location = New System.Drawing.Point(380, 575)
        Me.MaxAmVLabel.Name = "MaxAmVLabel"
        Me.MaxAmVLabel.Size = New System.Drawing.Size(112, 20)
        Me.MaxAmVLabel.TabIndex = 228
        Me.MaxAmVLabel.Text = "MaxAmpValue"
        '
        'AmpTrackBar
        '
        Me.AmpTrackBar.Location = New System.Drawing.Point(159, 564)
        Me.AmpTrackBar.Maximum = 1000
        Me.AmpTrackBar.Name = "AmpTrackBar"
        Me.AmpTrackBar.Size = New System.Drawing.Size(181, 69)
        Me.AmpTrackBar.TabIndex = 227
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 524)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 226
        Me.Label2.Text = "Amplitude"
        '
        'VDLabel
        '
        Me.VDLabel.AutoSize = True
        Me.VDLabel.Location = New System.Drawing.Point(1012, 272)
        Me.VDLabel.Name = "VDLabel"
        Me.VDLabel.Size = New System.Drawing.Size(111, 20)
        Me.VDLabel.TabIndex = 225
        Me.VDLabel.Text = "Volts / Division"
        '
        'TDLabel
        '
        Me.TDLabel.AutoSize = True
        Me.TDLabel.Location = New System.Drawing.Point(451, 517)
        Me.TDLabel.Name = "TDLabel"
        Me.TDLabel.Size = New System.Drawing.Size(109, 20)
        Me.TDLabel.TabIndex = 224
        Me.TDLabel.Text = "Time / Division"
        '
        'VRefValueLabel
        '
        Me.VRefValueLabel.AutoSize = True
        Me.VRefValueLabel.Location = New System.Drawing.Point(843, 575)
        Me.VRefValueLabel.Name = "VRefValueLabel"
        Me.VRefValueLabel.Size = New System.Drawing.Size(99, 20)
        Me.VRefValueLabel.TabIndex = 223
        Me.VRefValueLabel.Text = "RefVolValue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(692, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "Voltage Reference"
        '
        'GndTrackBar
        '
        Me.GndTrackBar.Location = New System.Drawing.Point(639, 547)
        Me.GndTrackBar.Maximum = 500
        Me.GndTrackBar.Name = "GndTrackBar"
        Me.GndTrackBar.Size = New System.Drawing.Size(181, 69)
        Me.GndTrackBar.TabIndex = 221
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Location = New System.Drawing.Point(6, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1000, 500)
        Me.PictureBox1.TabIndex = 220
        Me.PictureBox1.TabStop = False
        '
        'AnIn1CheckBox
        '
        Me.AnIn1CheckBox.AutoSize = True
        Me.AnIn1CheckBox.Location = New System.Drawing.Point(1072, 62)
        Me.AnIn1CheckBox.Name = "AnIn1CheckBox"
        Me.AnIn1CheckBox.Size = New System.Drawing.Size(130, 24)
        Me.AnIn1CheckBox.TabIndex = 229
        Me.AnIn1CheckBox.Text = "Analog Input "
        Me.AnIn1CheckBox.UseVisualStyleBackColor = True
        '
        'DefaultButton
        '
        Me.DefaultButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.DefaultButton.Location = New System.Drawing.Point(472, 612)
        Me.DefaultButton.Name = "DefaultButton"
        Me.DefaultButton.Size = New System.Drawing.Size(102, 57)
        Me.DefaultButton.TabIndex = 230
        Me.DefaultButton.Text = "Default"
        Me.DefaultButton.UseVisualStyleBackColor = True
        '
        'SettingsButton
        '
        Me.SettingsButton.Location = New System.Drawing.Point(1064, 311)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(98, 38)
        Me.SettingsButton.TabIndex = 231
        Me.SettingsButton.Text = "Settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 681)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.DefaultButton)
        Me.Controls.Add(Me.AnIn1CheckBox)
        Me.Controls.Add(Me.MaxAmVLabel)
        Me.Controls.Add(Me.AmpTrackBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VDLabel)
        Me.Controls.Add(Me.TDLabel)
        Me.Controls.Add(Me.VRefValueLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GndTrackBar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.AInGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.AInGroupBox.ResumeLayout(False)
        Me.AInGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AmpTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GndTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AInGroupBox As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents VA1Label As Label
    Friend WithEvents DA1Label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents QuitButton As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PortDataListBox As ListBox
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents ComPortListBox As ListBox
    Friend WithEvents ComPortButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MaxAmVLabel As Label
    Friend WithEvents AmpTrackBar As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents VDLabel As Label
    Friend WithEvents TDLabel As Label
    Friend WithEvents VRefValueLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GndTrackBar As TrackBar
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RXLabel As Label
    Friend WithEvents TXLabel As Label
    Friend WithEvents AnIn1CheckBox As CheckBox
    Friend WithEvents DefaultButton As Button
    Friend WithEvents SettingsButton As Button
End Class
