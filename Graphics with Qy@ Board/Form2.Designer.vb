<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComPortComboBox = New System.Windows.Forms.ComboBox()
        Me.TXLabel = New System.Windows.Forms.Label()
        Me.RXLabel = New System.Windows.Forms.Label()
        Me.ComPortListBox = New System.Windows.Forms.ListBox()
        Me.ComPortButton = New System.Windows.Forms.Button()
        Me.PortDataListBox = New System.Windows.Forms.ListBox()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.HideButton = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.BaudRateComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BaudRateComboBox)
        Me.GroupBox1.Controls.Add(Me.ComPortComboBox)
        Me.GroupBox1.Controls.Add(Me.ComPortListBox)
        Me.GroupBox1.Controls.Add(Me.ComPortButton)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 234)
        Me.GroupBox1.TabIndex = 219
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ComPortComboBox
        '
        Me.ComPortComboBox.FormattingEnabled = True
        Me.ComPortComboBox.Location = New System.Drawing.Point(6, 95)
        Me.ComPortComboBox.Name = "ComPortComboBox"
        Me.ComPortComboBox.Size = New System.Drawing.Size(121, 28)
        Me.ComPortComboBox.TabIndex = 220
        '
        'TXLabel
        '
        Me.TXLabel.AutoSize = True
        Me.TXLabel.Location = New System.Drawing.Point(723, 215)
        Me.TXLabel.Name = "TXLabel"
        Me.TXLabel.Size = New System.Drawing.Size(29, 20)
        Me.TXLabel.TabIndex = 213
        Me.TXLabel.Text = "TX"
        '
        'RXLabel
        '
        Me.RXLabel.AutoSize = True
        Me.RXLabel.Location = New System.Drawing.Point(668, 215)
        Me.RXLabel.Name = "RXLabel"
        Me.RXLabel.Size = New System.Drawing.Size(32, 20)
        Me.RXLabel.TabIndex = 212
        Me.RXLabel.Text = "RX"
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
        Me.ComPortButton.Location = New System.Drawing.Point(6, 129)
        Me.ComPortButton.Name = "ComPortButton"
        Me.ComPortButton.Size = New System.Drawing.Size(130, 46)
        Me.ComPortButton.TabIndex = 208
        Me.ComPortButton.Text = "Com Port"
        Me.ComPortButton.UseVisualStyleBackColor = True
        '
        'PortDataListBox
        '
        Me.PortDataListBox.FormattingEnabled = True
        Me.PortDataListBox.ItemHeight = 20
        Me.PortDataListBox.Location = New System.Drawing.Point(589, 61)
        Me.PortDataListBox.Name = "PortDataListBox"
        Me.PortDataListBox.Size = New System.Drawing.Size(173, 64)
        Me.PortDataListBox.TabIndex = 211
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(612, 142)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(140, 45)
        Me.PortOpenButton.TabIndex = 210
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'HideButton
        '
        Me.HideButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.HideButton.Location = New System.Drawing.Point(672, 327)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(68, 57)
        Me.HideButton.TabIndex = 214
        Me.HideButton.Text = "Leave"
        Me.HideButton.UseVisualStyleBackColor = True
        '
        'BaudRateComboBox
        '
        Me.BaudRateComboBox.FormattingEnabled = True
        Me.BaudRateComboBox.Location = New System.Drawing.Point(149, 95)
        Me.BaudRateComboBox.Name = "BaudRateComboBox"
        Me.BaudRateComboBox.Size = New System.Drawing.Size(121, 28)
        Me.BaudRateComboBox.TabIndex = 221
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HideButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RXLabel)
        Me.Controls.Add(Me.TXLabel)
        Me.Controls.Add(Me.PortOpenButton)
        Me.Controls.Add(Me.PortDataListBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXLabel As Label
    Friend WithEvents RXLabel As Label
    Friend WithEvents ComPortListBox As ListBox
    Friend WithEvents ComPortButton As Button
    Friend WithEvents PortDataListBox As ListBox
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents HideButton As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ComPortComboBox As ComboBox
    Friend WithEvents BaudRateComboBox As ComboBox
End Class
